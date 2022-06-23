SET IDENTITY_INSERT BusMark ON
-- Insert rows into table 'TableName' in schema '[dbo]'
INSERT INTO [dbo].[BusMark]
( -- Columns to insert data into
 [markId], [markName]
)
VALUES
( -- First row: values for the columns in the list above
 1, 'Renault'
),
( -- First row: values for the columns in the list above
 2, 'Citroen'
),
( -- First row: values for the columns in the list above
 3, 'Ford'
),
( -- Second row: values for the columns in the list above
 4, 'Mercedes-Benz'
),
( -- Second row: values for the columns in the list above
 5, 'Scania'
),
( -- Second row: values for the columns in the list above
 6, 'Fiat'
),
( -- Second row: values for the columns in the list above
 7, 'Volvo'
)
-- Add more rows here
GO
SET IDENTITY_INSERT BusMark OFF

--------------------------------------------------------------------------------

SET IDENTITY_INSERT Bus ON
-- Insert rows into table 'TableName' in schema '[dbo]'
INSERT INTO [dbo].[Bus]
( -- Columns to insert data into
 [busId], [capacity],[isOnGoing],[mark],[numberPlate],[color],[consumption]
)
VALUES
( -- First row: values for the columns in the list above
 1, 7, 0, 1,'BC1111BE', 'white', 7.1
),
( -- Second row: values for the columns in the list above
 2, 71, 0, 5,'BC1112AC', 'black', 18.2
),
( -- Second row: values for the columns in the list above
 3, 9, 0, 3,'BC1113AE', 'red', 5.5
),
( -- Second row: values for the columns in the list above
 4, 9, 0, 2,'BC1114CE', 'white', 9.5
),
( -- Second row: values for the columns in the list above
 5, 55, 0, 7,'BC1115AA', 'gray', 10.8
),
( -- Second row: values for the columns in the list above
 6, 15, 0, 4,'BC1116BA', 'black', 30.6
),
( -- Second row: values for the columns in the list above
 7, 9, 0, 6,'AA1116BE', 'white', 9.9
),
( -- Second row: values for the columns in the list above
 8, 53, 0, 4,'AC1118BC', 'blue', 32.7
),
( -- Second row: values for the columns in the list above
 9, 47, 0, 7,'AE1115CA', 'white', 28.5
),
( -- Second row: values for the columns in the list above
 10, 50, 0, 1,'BE1111CE', 'white', 25.1
),
( -- Second row: values for the columns in the list above
 11, 80, 0, 4,'CE1111BA', 'black', 25.0
),
( -- Second row: values for the columns in the list above
 12, 53, 0, 5,'AC1112AE', 'gray', 18.2
)
-- Add more rows here
GO



SET IDENTITY_INSERT Bus OFF

-----------------------------------------------------------------------------------------------

SET IDENTITY_INSERT ExcursionBus ON
-- Insert rows into table 'TableName' in schema '[dbo]'
INSERT INTO [dbo].[ExcursionBus]
( -- Columns to insert data into
 [busId], [excursionTypeId]
)
VALUES
( -- First row: values for the columns in the list above
 1, 1
),
( -- First row: values for the columns in the list above
 1, 2
),
( -- Second row: values for the columns in the list above
 2, 3
),
( -- Second row: values for the columns in the list above
 2, 4
),
( -- Second row: values for the columns in the list above
 3, 1
),
( -- Second row: values for the columns in the list above
 3, 2
),
( -- Second row: values for the columns in the list above
 4, 1
),
( -- Second row: values for the columns in the list above
 4, 3
),
( -- Second row: values for the columns in the list above
 5, 4
),
( -- Second row: values for the columns in the list above
 6, 3
),
( -- Second row: values for the columns in the list above
 7, 1
),
( -- Second row: values for the columns in the list above
 8, 1
),
( -- Second row: values for the columns in the list above
 8, 3
),
( -- Second row: values for the columns in the list above
 9, 1
),
( -- Second row: values for the columns in the list above
 10, 3
),
( -- Second row: values for the columns in the list above
 10, 4
),
( -- Second row: values for the columns in the list above
 11, 2
),
( -- Second row: values for the columns in the list above
 11, 4
),
( -- Second row: values for the columns in the list above
 12, 3
)
-- Add more rows here
GO
SET IDENTITY_INSERT ExcursionBus OFF

---------------------------------------------------------------------
SET IDENTITY_INSERT Driver ON
-- Insert rows into table 'TableName' in schema '[dbo]'
INSERT INTO [dbo].[Driver]
( -- Columns to insert data into
 [driverId]
      ,[isOnGoing]
      ,[number]
      ,[driverName]
      ,[driverLastName]
      ,[isOnVocation]
)
VALUES
( -- First row: values for the columns in the list above
 1, 0,'+380666666661', 'Vasyl', 'Vasylenko', 0
),
( -- First row: values for the columns in the list above
 2, 0,'+380666666662', 'Ivan', 'Ivanenko', 0
),
( -- First row: values for the columns in the list above
 3, 0,'+380666666663', 'Taras', 'Tarasenko', 0
),
( -- First row: values for the columns in the list above
 4, 0,'+380666666664', 'Stepan', 'Stepanenko', 0
),
( -- First row: values for the columns in the list above
 5, 0,'+380666666665', 'Andriy', 'Shevchenko', 0
),
( -- First row: values for the columns in the list above
 6, 0,'+380666666666', 'Kyrylo', 'Melnyk', 0
),
( -- First row: values for the columns in the list above
 6, 0,'+380666666666', 'Kyrylo', 'Melnyk', 0
),
( -- Second row: values for the columns in the list above
 7, 0,'+380666666667', 'Mykyta', 'Boiko', 0
),
( -- Second row: values for the columns in the list above
 8, 0, '+380666666668', 'Vladyslav', 'Tkachenko', 0
),
( -- Second row: values for the columns in the list above
 9, 0,'+380666666669', 'Ihor', 'Kravchuk', 0
),
( -- Second row: values for the columns in the list above
 10, 0,'+380666666610', 'Oleksiy', 'Karpenko', 0
),
( -- Second row: values for the columns in the list above
 11, 0,'+380666666611', 'Myhailo', 'Panchenko', 0
),
( -- Second row: values for the columns in the list above
 12, 0,'+380666666612', 'Anton', 'Pavliuk', 0
),
( -- Second row: values for the columns in the list above
 13, 0,'+380666666613', 'Artem', 'Bilous', 0
)
-- Add more rows here
GO
SET IDENTITY_INSERT Driver OFF

SET IDENTITY_INSERT Excursion ON
-- Insert rows into table 'TableName' in schema '[dbo]'
INSERT INTO [dbo].[Excursion]
( -- Columns to insert data into
  [excursionId]
      ,[startDate]
      ,[duration]
      ,[distanceKM]
      ,[countOfCustomers]
      ,[excursionType]
)
VALUES
( -- First row: values for the columns in the list above
 1, '2022-03-01 12:00:00', 4.5,300, 53, 3
),
( -- Second row: values for the columns in the list above
 2, '2022-03-05 10:00:00', 8.5, 520, 70, 4
),
( -- Second row: values for the columns in the list above
 3, '2022-03-09 12:00:00', 1.5, 45, 9, 2
),
( -- Second row: values for the columns in the list above
 4, '2022-04-02 08:00:00', 6.5, 340, 70, 4
),
( -- Second row: values for the columns in the list above
 5, '2022-05-10 09:00:00', 2, 70, 9, 1
),
( -- Second row: values for the columns in the list above
 6, '2022-05-10 10:00:00', 2.5, 20, 75, 2
),
( -- Second row: values for the columns in the list above
 7, '2022-05-10 08:00:00', 3.5, 210, 50, 3
)
-- Add more rows here
GO
SET IDENTITY_INSERT Excursion OFF

--------------------------------------------------------------

SET IDENTITY_INSERT Client ON
-- Insert rows into table 'TableName' in schema '[dbo]'
INSERT INTO [dbo].[Client]
( -- Columns to insert data into
[clientId]
      ,[clientName]
      ,[clientLastName]
      ,[phone]
      ,[country]
)
VALUES
( -- First row: values for the columns in the list above
 1, 'Anna', 'Pylyp','0969999991', 38
),
( -- Second row: values for the columns in the list above
 2, 'Oleksiy', 'Shpak','0969999992', 38
),
( -- Second row: values for the columns in the list above
 3, 'Jameson', 'Wels','0969999993', 38
),
( -- Second row: values for the columns in the list above
 4, 'Kamil', 'Nowak','0969999994', 38
),
( -- Second row: values for the columns in the list above
 5, 'Oleksandr', 'Koval','0969999995', 38
),
( -- Second row: values for the columns in the list above
 6, 'Maria', 'Koval','0969999996', 38
),
( -- Second row: values for the columns in the list above
 7,  'Volodymyr', 'Ivashko','0969999997', 38
)
-- Add more rows here
GO
SET IDENTITY_INSERT Client OFF

SET IDENTITY_INSERT Bus OFF

-----------------------------------------------------------------------------------------------
SET IDENTITY_INSERT ExcursionClient ON
-- Insert rows into table 'TableName' in schema '[dbo]'
INSERT INTO [dbo].[ExcursionClient]
( -- Columns to insert data into
[excursionClientId]
      ,[clientId]
      ,[excursionId]
)
VALUES
( -- First row: values for the columns in the list above
 1, 1,1
),
( -- First row: values for the columns in the list above
 2, 2, 2
),
( -- Second row: values for the columns in the list above
 3,3,3
),
( -- Second row: values for the columns in the list above
 4,4,4
),
( -- Second row: values for the columns in the list above
 5,5,5
),
( -- Second row: values for the columns in the list above
 6,6,6
),
( -- Second row: values for the columns in the list above
 7,7,7
)
-- Add more rows here
GO
SET IDENTITY_INSERT ExcursionClient OFF

-------------------------------------------------------------------------------------------------
SET IDENTITY_INSERT ExcursionBusDriver ON
INSERT INTO [dbo].[ExcursionBusDriver]
( -- Columns to insert data into
[excursionId]
      ,[busId]
      ,[driverId]
)
VALUES
( -- First row: values for the columns in the list above
 1, 12,1
),
( -- First row: values for the columns in the list above
 2, 2, 2
),
( -- Second row: values for the columns in the list above
 3,3,3
),
( -- Second row: values for the columns in the list above
 4,2,4
),
( -- Second row: values for the columns in the list above
 5,4,5
),
( -- Second row: values for the columns in the list above
 6,11,6
),
( -- Second row: values for the columns in the list above
 7,12,7
)
-- Add more rows here
GO
SET IDENTITY_INSERT ExcursionBusDriver OFF

---------------------------------------------------------------------------------

SET IDENTITY_INSERT Payment ON
INSERT INTO [dbo].[Payment]
( -- Columns to insert data into
 [paymentId]
      ,[excursionId]
      ,[clientId]
      ,[price]
      ,[isPaid]
      ,[paid]
)
VALUES
( -- First row: values for the columns in the list above
 1, 1,1,10000,1,10000
),
( -- First row: values for the columns in the list above
 2, 2, 2,700,1,700
),
( -- Second row: values for the columns in the list above
 3,3,3,2500,1,2500
),
( -- Second row: values for the columns in the list above
 4,4,4,3700,1,3700
),
( -- Second row: values for the columns in the list above
 5,5,5, 7500,1,7500
),
( -- Second row: values for the columns in the list above
 6,6,6,900,1,900
),
( -- Second row: values for the columns in the list above
 7,7,7, 1100,1,1100
)
-- Add more rows here
GO
SET IDENTITY_INSERT Payment OFF