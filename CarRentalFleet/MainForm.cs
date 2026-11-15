using Microsoft.Data.SqlClient;

namespace CarRentalFleet
{
    public partial class MainForm : Form
    {
        private readonly CarRepository repository = new CarRepository();

        public MainForm()
        {
            InitializeComponent();
            LoadCars();
        }

        private void LoadCars()
        {
            string searchText = txtSearch.Text.Trim();
            string status = cmbStatusFilter.SelectedIndex == 0 ? string.Empty : cmbStatusFilter.Text;

            try
            {
                List<Car> cars = repository.Search(searchText, status);
                dgvCars.DataSource = cars;
                ConfigureColumns();

                if (cars.Count > 0)
                    lblStatus.Text = $"Showing {cars.Count} car(s).";
                else if (searchText.Length > 0 || status.Length > 0)
                    lblStatus.Text = "No cars match your search.";
                else
                    lblStatus.Text = "The fleet is empty.";
            }
            catch (SqlException ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private void ConfigureColumns()
        {
            if (dgvCars.Columns.Count == 0) return;

            HideOrRename("Id", null);
            HideOrRename("PlateNumber", "Plate number");
            HideOrRename("Make", "Make");
            HideOrRename("Model", "Model");
            HideOrRename("ProductionYear", "Production year");
            HideOrRename("DailyRate", "Daily rate");
            HideOrRename("Status", "Status");
            HideOrRename("Age", "Age (years)");

            DataGridViewColumn? dailyRate = FindColumn("DailyRate");
            if (dailyRate != null)
                dailyRate.DefaultCellStyle.Format = "N2";
        }

        private DataGridViewColumn? FindColumn(string columnName)
        {
            return dgvCars.Columns.Contains(columnName) ? dgvCars.Columns[columnName] : null;
        }

        // headerText == null hides the column (used for the Id)
        private void HideOrRename(string columnName, string? headerText)
        {
            DataGridViewColumn? column = FindColumn(columnName);
            if (column == null) return;

            if (headerText == null)
                column.Visible = false;
            else
                column.HeaderText = headerText;
        }

        // Clears search and filter so a newly saved or edited car is visible
        private void ShowAllCars()
        {
            txtSearch.Text = string.Empty;
            cmbStatusFilter.SelectedIndex = 0;
        }

        private Car? GetSelectedCar()
        {
            if (dgvCars.CurrentRow == null) return null;
            return dgvCars.CurrentRow.DataBoundItem as Car;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (CarForm form = new CarForm())
            {
                if (form.ShowDialog(this) != DialogResult.OK) return;

                try
                {
                    repository.Add(form.CurrentCar);
                }
                catch (SqlException ex)
                {
                    ShowDatabaseError(ex);
                    return;
                }

                ShowAllCars();
                LoadCars();
                lblStatus.Text = "Car added.";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Car? selected = GetSelectedCar();
            if (selected == null)
            {
                MessageBox.Show("Select a car in the list first.", "No car selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (CarForm form = new CarForm(selected))
            {
                if (form.ShowDialog(this) != DialogResult.OK) return;

                try
                {
                    repository.Update(form.CurrentCar);
                }
                catch (SqlException ex)
                {
                    ShowDatabaseError(ex);
                    return;
                }

                ShowAllCars();
                LoadCars();
                lblStatus.Text = "Car updated.";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Car? selected = GetSelectedCar();
            if (selected == null)
            {
                MessageBox.Show("Select a car in the list first.", "No car selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult answer = MessageBox.Show(
                $"Delete {selected.PlateNumber} ({selected.Make} {selected.Model})? This cannot be undone.",
                "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer != DialogResult.Yes) return;

            try
            {
                repository.Delete(selected.Id);
            }
            catch (SqlException ex)
            {
                ShowDatabaseError(ex);
                return;
            }

            LoadCars();
            lblStatus.Text = "Car deleted.";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void dgvCars_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                btnEdit_Click(sender, e);
        }

        private void dgvCars_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Car? car = dgvCars.Rows[e.RowIndex].DataBoundItem as Car;
            if (car == null) return;

            if (car.Status == "Service")
                e.CellStyle.BackColor = Color.FromArgb(252, 228, 226);
            else if (car.Status == "Rented")
                e.CellStyle.BackColor = Color.FromArgb(255, 243, 205);
        }

        private static void ShowDatabaseError(SqlException ex)
        {
            string message = ex.Number == 2627
                ? "A car with this plate number already exists."
                : "The database returned an error:\n" + ex.Message;
            MessageBox.Show(message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
