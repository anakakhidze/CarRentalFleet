IF DB_ID(N'CarRentalFleetDb') IS NULL
    CREATE DATABASE CarRentalFleetDb;
GO
USE CarRentalFleetDb;
GO
IF OBJECT_ID(N'dbo.Cars', N'U') IS NULL
CREATE TABLE Cars
(
    Id             INT IDENTITY(1,1) PRIMARY KEY,
    PlateNumber    NVARCHAR(15)  NOT NULL UNIQUE,    -- text
    Make           NVARCHAR(50)  NOT NULL,           -- text, searched
    Model          NVARCHAR(50)  NOT NULL,           -- text
    ProductionYear INT           NOT NULL,           -- a number
    DailyRate      DECIMAL(8,2)  NOT NULL,           -- a decimal
    Status         NVARCHAR(20)  NOT NULL            -- the column you filter by
        CHECK (Status IN (N'Available', N'Rented', N'Service'))
);
GO

IF NOT EXISTS (SELECT 1 FROM Cars)
BEGIN
    INSERT INTO Cars (PlateNumber, Make, Model, ProductionYear, DailyRate, Status) VALUES
    (N'AB-101-CD', N'Toyota',        N'Corolla',   2020,  45.00, N'Available'),
    (N'AB-102-CD', N'Toyota',        N'RAV4',      2022,  70.00, N'Rented'),
    (N'AB-103-CD', N'Toyota',        N'Camry',     2019,  60.00, N'Service'),
    (N'AB-104-CD', N'Hyundai',       N'Elantra',   2021,  40.00, N'Available'),
    (N'AB-105-CD', N'Hyundai',       N'Tucson',    2023,  75.00, N'Rented'),
    (N'AB-106-CD', N'Kia',           N'Sportage',  2021,  68.00, N'Available'),
    (N'AB-107-CD', N'Kia',           N'Rio',       2018,  35.00, N'Available'),
    (N'AB-108-CD', N'Volkswagen',    N'Golf',      2020,  50.00, N'Service'),
    (N'AB-109-CD', N'Volkswagen',    N'Passat',    2017,  48.00, N'Rented'),
    (N'AB-110-CD', N'BMW',           N'X5',        2023, 150.00, N'Available'),
    (N'AB-111-CD', N'Mercedes-Benz', N'E-Class',   2022, 130.00, N'Rented'),
    (N'AB-112-CD', N'Ford',          N'Focus',     2016,  30.00, N'Service'),
    (N'AB-113-CD', N'Ford',          N'Explorer',  2021,  90.00, N'Available'),
    (N'AB-114-CD', N'Skoda',         N'Octavia',   2019,  42.00, N'Available'),
    (N'AB-115-CD', N'Renault',       N'Duster',    2020,  55.00, N'Rented'),
    (N'AB-116-CD', N'Nissan',        N'Qashqai',   2022,  65.00, N'Available');
END
GO
