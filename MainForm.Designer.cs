namespace CarRentalFleet
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblStatusFilter;
        private ComboBox cmbStatusFilter;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvCars;
        private Label lblStatus;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblStatusFilter = new Label();
            cmbStatusFilter = new ComboBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvCars = new DataGridView();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            SuspendLayout();
            //
            // lblSearch
            //
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(12, 15);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(48, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            //
            // txtSearch
            //
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(70, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(300, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            cmbStatusFilter.SelectedIndexChanged += cmbStatusFilter_SelectedIndexChanged;
            //
            // lblStatusFilter
            //
            lblStatusFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatusFilter.AutoSize = true;
            lblStatusFilter.Location = new Point(560, 15);
            lblStatusFilter.Name = "lblStatusFilter";
            lblStatusFilter.Size = new Size(42, 15);
            lblStatusFilter.TabIndex = 2;
            lblStatusFilter.Text = "Status:";
            //
            // cmbStatusFilter
            //
            cmbStatusFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Items.AddRange(new object[] { "All", "Available", "Rented", "Service" });
            cmbStatusFilter.Location = new Point(608, 12);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(150, 23);
            cmbStatusFilter.TabIndex = 3;
            cmbStatusFilter.SelectedIndex = 0;
            //
            // btnAdd
            //
            btnAdd.Location = new Point(12, 50);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 30);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            //
            // btnEdit
            //
            btnEdit.Location = new Point(110, 50);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 30);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            //
            // btnDelete
            //
            btnDelete.Location = new Point(208, 50);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 30);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            //
            // dgvCars
            //
            dgvCars.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCars.AllowUserToAddRows = false;
            dgvCars.AllowUserToDeleteRows = false;
            dgvCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCars.BackgroundColor = SystemColors.Window;
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCars.Location = new Point(12, 90);
            dgvCars.MultiSelect = false;
            dgvCars.Name = "dgvCars";
            dgvCars.ReadOnly = true;
            dgvCars.RowHeadersVisible = false;
            dgvCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCars.Size = new Size(876, 380);
            dgvCars.TabIndex = 7;
            dgvCars.CellDoubleClick += dgvCars_CellDoubleClick;
            dgvCars.CellFormatting += dgvCars_CellFormatting;
            //
            // lblStatus
            //
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.AutoSize = false;
            lblStatus.Location = new Point(12, 485);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(876, 23);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            //
            // MainForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 520);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblStatusFilter);
            Controls.Add(cmbStatusFilter);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(dgvCars);
            Controls.Add(lblStatus);
            MinimumSize = new Size(640, 400);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Rental Fleet";
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
