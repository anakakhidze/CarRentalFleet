using Microsoft.Data.SqlClient;

namespace CarRentalFleet
{
    public class CarRepository
    {
        private readonly string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CarRentalFleetDb;" +
            "Integrated Security=True;TrustServerCertificate=True";

        // status "" means "all statuses"; text "" means "all cars"
        public List<Car> Search(string text, string status)
        {
            List<Car> cars = new List<Car>();
            string sql =
                "SELECT Id, PlateNumber, Make, Model, ProductionYear, DailyRate, Status " +
                "FROM Cars " +
                "WHERE (@text = N'' OR PlateNumber LIKE @pattern OR Make LIKE @pattern) " +
                "  AND (@status = N'' OR Status = @status) " +
                "ORDER BY Make, Model";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@text", text);
                command.Parameters.AddWithValue("@pattern", "%" + text + "%");
                command.Parameters.AddWithValue("@status", status);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cars.Add(ReadCar(reader));
                    }
                }
            }
            return cars;
        }

        public int Add(Car car)
        {
            string sql =
                "INSERT INTO Cars (PlateNumber, Make, Model, ProductionYear, DailyRate, Status) " +
                "OUTPUT INSERTED.Id " +
                "VALUES (@plate, @make, @model, @year, @rate, @status)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                AddCarParameters(command, car);
                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }

        public void Update(Car car)
        {
            string sql =
                "UPDATE Cars SET PlateNumber = @plate, Make = @make, Model = @model, " +
                "ProductionYear = @year, DailyRate = @rate, Status = @status " +
                "WHERE Id = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                AddCarParameters(command, car);
                command.Parameters.AddWithValue("@id", car.Id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("DELETE FROM Cars WHERE Id = @id", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private static void AddCarParameters(SqlCommand command, Car car)
        {
            command.Parameters.AddWithValue("@plate", car.PlateNumber);
            command.Parameters.AddWithValue("@make", car.Make);
            command.Parameters.AddWithValue("@model", car.Model);
            command.Parameters.AddWithValue("@year", car.ProductionYear);
            command.Parameters.AddWithValue("@rate", car.DailyRate);
            command.Parameters.AddWithValue("@status", car.Status);
        }

        private static Car ReadCar(SqlDataReader reader)
        {
            Car car = new Car();
            car.Id = (int)reader["Id"];
            car.PlateNumber = (string)reader["PlateNumber"];
            car.Make = (string)reader["Make"];
            car.Model = (string)reader["Model"];
            car.ProductionYear = (int)reader["ProductionYear"];
            car.DailyRate = (decimal)reader["DailyRate"];
            car.Status = (string)reader["Status"];
            return car;
        }
    }
}
