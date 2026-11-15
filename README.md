# Car Rental Fleet

A Windows Forms application that manages the cars of a small rental fleet.
You can list all cars, search by plate number or make, filter by status
(Available, Rented, Service), and add, edit or delete a car. Every change
is saved to a SQL Server LocalDB database.

## Table: Cars
Id, PlateNumber, Make, Model, ProductionYear, DailyRate, Status

## How to run it
1. Visual Studio 2026 -> View -> SQL Server Object Explorer
2. Right-click (localdb)\MSSQLLocalDB -> New Query
3. Paste database.sql (in this folder) and press Execute
4. Open CarRentalFleet.slnx (in this folder)
5. Build -> Rebuild Solution, then F5
