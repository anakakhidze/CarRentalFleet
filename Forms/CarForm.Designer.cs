namespace CarRentalFleet
{
    partial class CarForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Label lblPlateNumber;
        private TextBox txtPlateNumber;
        private Label lblMake;
        private TextBox txtMake;
        private Label lblModel;
        private TextBox txtModel;
        private Label lblProductionYear;
        private NumericUpDown numProductionYear;
        private Label lblDailyRate;
        private NumericUpDown numDailyRate;
        private Label lblCarStatus;
        private ComboBox cmbStatus;
        private Button btnSave;
        private Button btnCancel;

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
            lblPlateNumber = new Label();
            txtPlateNumber = new TextBox();
            lblMake = new Label();
            txtMake = new TextBox();
            lblModel = new Label();
            txtModel = new TextBox();
            lblProductionYear = new Label();
            numProductionYear = new NumericUpDown();
            lblDailyRate = new Label();
            numDailyRate = new NumericUpDown();
            lblCarStatus = new Label();
            cmbStatus = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numProductionYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDailyRate).BeginInit();
            SuspendLayout();
            //
            // lblPlateNumber
            //
            lblPlateNumber.AutoSize = true;
            lblPlateNumber.Location = new Point(12, 15);
            lblPlateNumber.Name = "lblPlateNumber";
            lblPlateNumber.Size = new Size(79, 15);
            lblPlateNumber.TabIndex = 0;
            lblPlateNumber.Text = "Plate number";
            //
            // txtPlateNumber
            //
            txtPlateNumber.Location = new Point(130, 12);
            txtPlateNumber.MaxLength = 15;
            txtPlateNumber.Name = "txtPlateNumber";
            txtPlateNumber.Size = new Size(220, 23);
            txtPlateNumber.TabIndex = 1;
            //
            // lblMake
            //
            lblMake.AutoSize = true;
            lblMake.Location = new Point(12, 50);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(36, 15);
            lblMake.TabIndex = 2;
            lblMake.Text = "Make";
            //
            // txtMake
            //
            txtMake.Location = new Point(130, 47);
            txtMake.MaxLength = 50;
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(220, 23);
            txtMake.TabIndex = 3;
            //
            // lblModel
            //
            lblModel.AutoSize = true;
            lblModel.Location = new Point(12, 85);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(39, 15);
            lblModel.TabIndex = 4;
            lblModel.Text = "Model";
            //
            // txtModel
            //
            txtModel.Location = new Point(130, 82);
            txtModel.MaxLength = 50;
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(220, 23);
            txtModel.TabIndex = 5;
            //
            // lblProductionYear
            //
            lblProductionYear.AutoSize = true;
            lblProductionYear.Location = new Point(12, 120);
            lblProductionYear.Name = "lblProductionYear";
            lblProductionYear.Size = new Size(94, 15);
            lblProductionYear.TabIndex = 6;
            lblProductionYear.Text = "Production year";
            //
            // numProductionYear
            //
            numProductionYear.Location = new Point(130, 117);
            numProductionYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numProductionYear.Minimum = new decimal(new int[] { 1980, 0, 0, 0 });
            numProductionYear.Name = "numProductionYear";
            numProductionYear.Size = new Size(100, 23);
            numProductionYear.TabIndex = 7;
            numProductionYear.Value = new decimal(new int[] { 2020, 0, 0, 0 });
            //
            // lblDailyRate
            //
            lblDailyRate.AutoSize = true;
            lblDailyRate.Location = new Point(12, 155);
            lblDailyRate.Name = "lblDailyRate";
            lblDailyRate.Size = new Size(66, 15);
            lblDailyRate.TabIndex = 8;
            lblDailyRate.Text = "Daily rate";
            //
            // numDailyRate
            //
            numDailyRate.DecimalPlaces = 2;
            numDailyRate.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numDailyRate.Location = new Point(130, 152);
            numDailyRate.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numDailyRate.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDailyRate.Name = "numDailyRate";
            numDailyRate.Size = new Size(100, 23);
            numDailyRate.TabIndex = 9;
            numDailyRate.Value = new decimal(new int[] { 50, 0, 0, 0 });
            //
            // lblCarStatus
            //
            lblCarStatus.AutoSize = true;
            lblCarStatus.Location = new Point(12, 190);
            lblCarStatus.Name = "lblCarStatus";
            lblCarStatus.Size = new Size(42, 15);
            lblCarStatus.TabIndex = 10;
            lblCarStatus.Text = "Status";
            //
            // cmbStatus
            //
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Available", "Rented", "Service" });
            cmbStatus.Location = new Point(130, 187);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(220, 23);
            cmbStatus.TabIndex = 11;
            cmbStatus.SelectedIndex = 0;
            //
            // btnSave
            //
            btnSave.Location = new Point(130, 230);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            //
            // btnCancel
            //
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(240, 230);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 30);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            //
            // CarForm
            //
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(366, 276);
            Controls.Add(lblPlateNumber);
            Controls.Add(txtPlateNumber);
            Controls.Add(lblMake);
            Controls.Add(txtMake);
            Controls.Add(lblModel);
            Controls.Add(txtModel);
            Controls.Add(lblProductionYear);
            Controls.Add(numProductionYear);
            Controls.Add(lblDailyRate);
            Controls.Add(numDailyRate);
            Controls.Add(lblCarStatus);
            Controls.Add(cmbStatus);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CarForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Car";
            ((System.ComponentModel.ISupportInitialize)numProductionYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDailyRate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
