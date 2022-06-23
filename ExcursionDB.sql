CREATE TABLE [ExcursionBus] (
  busId int NOT NULL,
  excursionTypeId int NOT NULL
)

CREATE TABLE [Excursion] (
  excursionId int NOT NULL IDENTITY,
  startDate date NOT NULL,
  duration float NOT NULL,--minutes
  distanceKM int NOT NULL,
  countOfCustomers int NOT NULL,
  excursionType int NOT NULL,
  CONSTRAINT [PK_Excursion] PRIMARY KEY CLUSTERED
  (
  [excursionId] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [ExcursionType] (
  typeId int NOT NULL IDENTITY ,
  typeName nvarchar(50) NOT NULL,
  CONSTRAINT [PK_ExcursionType] PRIMARY KEY CLUSTERED
  (
  [typeId] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)


GO
CREATE TABLE [Driver] (
  driverId int NOT NULL IDENTITY,
  isOnGoing bit NOT NULL,
  number nvarchar(100) NOT NULL,
  driverName nvarchar(100) NOT NULL,
  driverLastName nvarchar(100) NOT NULL,
  isOnVocation bit NOT NULL,
  CONSTRAINT [PK_Driver] PRIMARY KEY CLUSTERED
  (
  [driverId] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO

CREATE TABLE [BusMark] (
  markId int NOT NULL IDENTITY ,
  markName nvarchar(16) NOT NULL,
  CONSTRAINT [PK_BusMark] PRIMARY KEY CLUSTERED
  (
  [markId] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO

CREATE TABLE [Bus] (
  busId int NOT NULL IDENTITY ,
  capacity int NOT NULL,
  isOnGoing bit NOT NULL,
  mark int NOT NULL,
  numberPlate nvarchar(16) NOT NULL,
  color nvarchar(100) NOT NULL,
  consumption float NOT NULL,--litr per 100 km
  CONSTRAINT [PK_Bus] PRIMARY KEY CLUSTERED
  (
  [busId] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO


CREATE TABLE [ExcursionBusDriver] (
  excursionId int NOT NULL IDENTITY,
  busId int NOT NULL,
  driverId int NOT NULL
)

GO
CREATE TABLE [Client] (
  clientId int NOT NULL IDENTITY ,
  clientName nvarchar(100) NOT NULL,
  clientLastName nvarchar(100) NOT NULL,
  phone nvarchar(100) NOT NULL,
  country int NOT NULL, 
  CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED
  (
  [clientId] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)

GO
CREATE TABLE [ExcursionClient] (
  excursionClientId int NOT NULL IDENTITY ,
  clientId int NOT NULL,
  excursionId int NOT NULL,
  CONSTRAINT [PK_ExcursionClient] PRIMARY KEY CLUSTERED
  (
  [excursionClientId] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)


GO
CREATE TABLE [Payment] (
  paymentId int NOT NULL IDENTITY ,
  excursionId int NOT NULL,
  clientId int NOT NULL,
  price numeric NOT NULL,
  isPaid bit NOT NULL,
  paid numeric NOT NULL,
  CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED
  (
  [paymentId] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)


GO
ALTER TABLE [Bus] WITH CHECK ADD CONSTRAINT [Bus_fk0] FOREIGN KEY ([mark]) REFERENCES [BusMark]([markId])
ON UPDATE CASCADE
GO
ALTER TABLE [Bus] CHECK CONSTRAINT [bus_fk0]
GO

ALTER TABLE [ExcursionBusDriver] WITH CHECK ADD CONSTRAINT [ExcursionBusDriver_fk0] FOREIGN KEY ([excursionId]) REFERENCES [Excursion]([excursionId])
ON UPDATE CASCADE
GO
ALTER TABLE [ExcursionBusDriver] CHECK CONSTRAINT [ExcursionBusDriver_fk0]
GO
ALTER TABLE [ExcursionBusDriver] WITH CHECK ADD CONSTRAINT [ExcursionBusDriver_fk1] FOREIGN KEY ([busId]) REFERENCES [Bus]([busId])
ON UPDATE CASCADE
GO
ALTER TABLE [ExcursionBusDriver] CHECK CONSTRAINT [ExcursionBusDriver_fk1]
GO
ALTER TABLE [ExcursionBusDriver] WITH CHECK ADD CONSTRAINT [ExcursionBusDriver_fk2] FOREIGN KEY ([driverId]) REFERENCES [Driver]([driverId])
ON UPDATE CASCADE
GO
ALTER TABLE [ExcursionBusDriver] CHECK CONSTRAINT [ExcursionBusDriver_fk2]
GO

ALTER TABLE [Excursion] WITH CHECK ADD CONSTRAINT [Excursion_fk0] FOREIGN KEY ([excursionType]) REFERENCES [ExcursionType]([typeId])
ON UPDATE CASCADE
GO
ALTER TABLE [Excursion] CHECK CONSTRAINT [Excursion_fk0]
GO

ALTER TABLE [ExcursionClient] WITH CHECK ADD CONSTRAINT [ExcursionClient_fk0] FOREIGN KEY ([clientId]) REFERENCES [Client]([clientId])
ON UPDATE CASCADE
GO
ALTER TABLE [ExcursionClient] CHECK CONSTRAINT [ExcursionClient_fk0]
GO
ALTER TABLE [ExcursionClient] WITH CHECK ADD CONSTRAINT [ExcursionClient_fk1] FOREIGN KEY ([excursionId]) REFERENCES [Excursion]([excursionId])
ON UPDATE CASCADE
GO
ALTER TABLE [ExcursionClient] CHECK CONSTRAINT [ExcursionClient_fk1]
GO


ALTER TABLE [Payment] WITH CHECK ADD CONSTRAINT [Payment_fk0] FOREIGN KEY ([excursionId]) REFERENCES [Excursion]([excursionId])
ON UPDATE CASCADE
GO
ALTER TABLE [Payment] CHECK CONSTRAINT [Payment_fk0]
GO

ALTER TABLE [Payment] WITH CHECK ADD CONSTRAINT [Payment_fk1] FOREIGN KEY ([clientId]) REFERENCES [Client]([clientId])
ON UPDATE CASCADE
GO
ALTER TABLE [Payment] CHECK CONSTRAINT [Payment_fk1]
GO
GO
ALTER TABLE [ExcursionBus] WITH CHECK ADD CONSTRAINT [ExcursionBus_fk0] FOREIGN KEY ([busId]) REFERENCES [Bus]([busId])

GO

ALTER TABLE [ExcursionBus] WITH CHECK ADD CONSTRAINT [ExcursionBus_fk1] FOREIGN KEY ([excursionTypeId]) REFERENCES [ExcursionType]([typeId])

GO
ALTER TABLE [ExcursionBus] CHECK CONSTRAINT [ExcursionBus_fk1]
GO

GO
ALTER TABLE dbo.Payment
ADD CHECK (price>=0);
GO

ALTER TABLE dbo.Excursion
ADD CHECK (duration>=0);

GO
ALTER TABLE dbo.Excursion
ADD CHECK (distanceKM>=0);

GO
ALTER TABLE dbo.Excursion
ADD CHECK (countOfCustomers>0);
GO

GO
ALTER TABLE dbo.Bus
ADD CHECK (capacity>0);
GO
