-- 1 ---------------------------------------------------------------------------------------
--За кожну екскурсію система повинна нарахувати оплату за певною формулою 
--яка враховує кількість екскурсантів, розхід бензину та тривалість екскурсії

CREATE OR ALTER FUNCTION  sum_price(@exc_id INT) RETURNS MONEY
AS
    BEGIN
       DECLARE  @cust_count INT, @gas_consumption FLOAT, @exc_duration FLOAT, @dist FLOAT, @excPrice MONEY;
       SELECT @cust_count = Excursion.countOfCustomers, @gas_consumption = Bus.consumption, @exc_duration = Excursion.duration, @dist = Excursion.distanceKM, @excPrice =  (@dist/@gas_consumption)*51
        FROM  Excursion JOIN ExcursionBusDriver ON Excursion.excursionId=ExcursionBusDriver.excursionId JOIN Bus ON ExcursionBusDriver.busId = Bus.busId
        WHERE Excursion.excursionId = @exc_id
        IF @exc_duration = 0 RETURN 0;
        IF @exc_duration > 0 RETURN (@excPrice + @cust_count*@excPrice*20/100 + @exc_duration*300)
        RETURN 0
    END
GO

GO	
SELECT Excursion.excursionId, dbo.sum_price(Excursion.excursionId) AS sum
FROM Excursion join ExcursionBusDriver on Excursion.excursionId=ExcursionBusDriver.excursionId join Bus on ExcursionBusDriver.busId = Bus.busId
GO

--процедура для заповнення чеків

DROP PROCEDURE IF EXISTS price_for_excursions
CREATE PROCEDURE price_for_excursions (@startDate DATE)
AS DECLARE paymentCursor CURSOR LOCAL FOR
SELECT paymentId FROM Payment
JOIN Excursion ON Excursion.excursionId = payment.excursionId
WHERE startDate > @startDate 
DECLARE @paymentId INT
OPEN paymentCursor 
FETCH NEXT FROM paymentCursor INTO @paymentId
WHILE @@FETCH_STATUS=0
BEGIN 

	UPDATE Payment
	SET price = dbo.sum_price(payment.excursionId)
	WHERE paymentId = @paymentId

FETCH NEXT FROM paymentCursor INTO @paymentId
END
CLOSE paymentCursor


EXEC price_for_excursions @startDate = '2022-01-01'
EXEC price_for_excursions @startDate = '2022-02-01'
EXEC price_for_excursions @startDate = '2022-04-01'
EXEC price_for_excursions @startDate = '2022-05-01'
EXEC price_for_excursions @startDate = '2022-06-01'
EXEC price_for_excursions @startDate = '2022-07-01'

--процедура оплати чеків

DROP PROCEDURE IF EXISTS pay_for_excursions
CREATE PROCEDURE pay_for_excursions (@startDate DATE)
AS DECLARE paymentCursor CURSOR LOCAL FOR
SELECT paymentId FROM Payment
JOIN Excursion ON Excursion.excursionId = payment.excursionId
WHERE startDate > @startDate
DECLARE @paymentId INT
OPEN paymentCursor 
FETCH NEXT FROM paymentCursor INTO @paymentId
WHILE @@FETCH_STATUS=0
BEGIN 

	UPDATE Payment
	SET paid = price, isPaid = 1
	WHERE paymentId = @paymentId

FETCH NEXT FROM paymentCursor INTO @paymentId
END
CLOSE paymentCursor

EXEC pay_for_excursions @startDate = '2022-01-01'
EXEC pay_for_excursions @startDate = '2022-02-01'
EXEC pay_for_excursions @startDate = '2022-04-01'
EXEC pay_for_excursions @startDate = '2022-05-01'
EXEC pay_for_excursions @startDate = '2022-06-01'
EXEC pay_for_excursions @startDate = '2022-07-01'



-- 3 -- Екскурсія не може надаватись замовнику, який має борг впродовж 30 днів.

CREATE TRIGGER debt_limit
ON Payment
INSTEAD OF INSERT
AS
BEGIN
	DECLARE @haveDebt INT
	DECLARE @clientId INT

	SELECT @clientId = clientId FROM inserted

	SET @haveDebt = (SELECT count(*) FROM Payment JOIN Excursion ON Excursion.excursionId = Payment.excursionId 
	WHERE clientId = @clientId AND startDate < DATEADD(month, -1, CURRENT_TIMESTAMP))
	
	IF @haveDebt <= 0
		INSERT INTO payment
		SELECT * FROM inserted
	ELSE
		SELECT 'Client has a debt' AS 'DEBT'

END


-- 4 --Автобус та шофер не можуть одночасно обслуговувати дві екскурсії

CREATE TRIGGER driverBusLimit
ON ExcursionBusDriver
INSTEAD OF INSERT
AS
BEGIN
	DECLARE @onGoingBus INT
	DECLARE @onGoingDriver INT
	DECLARE @driverId INT
	DECLARE @busId INT

	SELECT @driverId = driverId FROM inserted
	SELECT @busId = busId FROM inserted

	SET @onGoingDriver = (SELECT count(*) FROM ExcursionBusDriver 
					JOIN Excursion ON Excursion.excursionId= ExcursionBusDriver.excursionId
					WHERE driverId = @driverId AND CURRENT_TIMESTAMP BETWEEN startDate AND DATEADD(day, duration, startDate))

	SET @onGoingBus = (SELECT count(*) FROM ExcursionBusDriver 
					JOIN Excursion ON Excursion.excursionId= ExcursionBusDriver.excursionId
					WHERE busId = @busId AND CURRENT_TIMESTAMP BETWEEN startDate AND DATEADD(day, duration, startDate))

	IF @onGoingBus > 0
		SELECT 'Bus is Busy' AS 'BUS'
	ELSE IF @onGoingDriver > 0
		SELECT 'Driver is Busy' As 'Driver'
	ELSE
		INSERT INTO ExcursionBusDriver
		SELECT driverId, busId FROM inserted
END
GO

SET IDENTITY_INSERT ExcursionBusDriver OFF
GO

INSERT INTO ExcursionBusDriver VALUES(6, 2, 1)
-------------------------------------------------------------------------------------------------------------------------------------
--автобуси можуть обслуговувати певні типи екскурсій

CREATE TRIGGER busTypeLimit
ON ExcursionBusDriver
INSTEAD OF INSERT
AS
BEGIN
	DECLARE @typeId INT
	DECLARE @serve INT
	DECLARE @excursionId INT
	DECLARE @busId INT

	SELECT @busId = busId FROM inserted
	SELECT @excursionId = excursionId FROM inserted
	SET @serve = 0
	-- there i need some condition
	


	IF @serve = 1
		SELECT 'Current bus doesn`t serve this type of excursions' AS 'Bus'
	ELSE IF  @serve = 0
		INSERT INTO ExcursionBusDriver
		SELECT excursionId, busId FROM inserted
END
GO

