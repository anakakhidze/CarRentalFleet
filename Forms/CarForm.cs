namespace CarRentalFleet
{
    public partial class CarForm : Form
    {
        private int carId;

        public CarForm()
        {
            InitializeComponent();
            Text = "Add car";
            numProductionYear.Value = DateTime.Now.Year;
        }

        public CarForm(Car car) : this()
        {
            Text = "Edit car";
            carId = car.Id;
            txtPlateNumber.Text = car.PlateNumber;
            txtMake.Text = car.Make;
            txtModel.Text = car.Model;
            numProductionYear.Value = car.ProductionYear;
            numDailyRate.Value = car.DailyRate;
            cmbStatus.SelectedIndex = cmbStatus.FindStringExact(car.Status);
        }

        public Car CurrentCar { get; private set; } = new Car();

        private void btnSave_Click(object sender, EventArgs e)
        {
            string plateNumber = txtPlateNumber.Text.Trim();
            string make = txtMake.Text.Trim();
            string model = txtModel.Text.Trim();
            int productionYear = (int)numProductionYear.Value;

            if (string.IsNullOrWhiteSpace(plateNumber))
            {
                ShowProblem("Plate number is required.", txtPlateNumber);
                return;
            }

            if (plateNumber.Length < 6)
            {
                ShowProblem("Plate number must be at least 6 characters, for example AB-101-CD.", txtPlateNumber);
                return;
            }

            if (string.IsNullOrWhiteSpace(make))
            {
                ShowProblem("Make is required.", txtMake);
                return;
            }

            if (string.IsNullOrWhiteSpace(model))
            {
                ShowProblem("Model is required.", txtModel);
                return;
            }

            if (productionYear > DateTime.Now.Year + 1)
            {
                ShowProblem($"Production year cannot be later than {DateTime.Now.Year + 1}.", numProductionYear);
                return;
            }

            if (cmbStatus.SelectedIndex < 0)
            {
                ShowProblem("Choose a status.", cmbStatus);
                return;
            }

            CurrentCar = new Car
            {
                Id = carId,
                PlateNumber = plateNumber,
                Make = make,
                Model = model,
                ProductionYear = productionYear,
                DailyRate = numDailyRate.Value,
                Status = cmbStatus.Text
            };
            DialogResult = DialogResult.OK;
        }

        private static void ShowProblem(string message, Control control)
        {
            MessageBox.Show(message, "Check your input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
        }
    }
}
