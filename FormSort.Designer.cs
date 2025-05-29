namespace magnit
{
    partial class FormSort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSort));
            radioButtonEmployee = new RadioButton();
            label1 = new Label();
            comboBoxEmploye = new ComboBox();
            radioButtonSalesRegisters = new RadioButton();
            comboBoxSalesRegisters = new ComboBox();
            radioButtonDate = new RadioButton();
            dateTimePickerDate = new DateTimePicker();
            buttonSort = new Button();
            SuspendLayout();
            // 
            // radioButtonEmployee
            // 
            radioButtonEmployee.AutoSize = true;
            radioButtonEmployee.Font = new Font("Candal", 12F, FontStyle.Bold);
            radioButtonEmployee.Location = new Point(54, 73);
            radioButtonEmployee.Name = "radioButtonEmployee";
            radioButtonEmployee.Size = new Size(162, 33);
            radioButtonEmployee.TabIndex = 0;
            radioButtonEmployee.TabStop = true;
            radioButtonEmployee.Text = "Сотруднику";
            radioButtonEmployee.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candal", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(24, 28);
            label1.Name = "label1";
            label1.Size = new Size(192, 29);
            label1.TabIndex = 1;
            label1.Text = "Сортировать по:";
            // 
            // comboBoxEmploye
            // 
            comboBoxEmploye.FormattingEnabled = true;
            comboBoxEmploye.Location = new Point(79, 112);
            comboBoxEmploye.Name = "comboBoxEmploye";
            comboBoxEmploye.Size = new Size(327, 28);
            comboBoxEmploye.TabIndex = 2;
            // 
            // radioButtonSalesRegisters
            // 
            radioButtonSalesRegisters.AutoSize = true;
            radioButtonSalesRegisters.Font = new Font("Candal", 12F, FontStyle.Bold);
            radioButtonSalesRegisters.Location = new Point(54, 160);
            radioButtonSalesRegisters.Name = "radioButtonSalesRegisters";
            radioButtonSalesRegisters.Size = new Size(99, 33);
            radioButtonSalesRegisters.TabIndex = 3;
            radioButtonSalesRegisters.TabStop = true;
            radioButtonSalesRegisters.Text = "Кассе";
            radioButtonSalesRegisters.UseVisualStyleBackColor = true;
            // 
            // comboBoxSalesRegisters
            // 
            comboBoxSalesRegisters.FormattingEnabled = true;
            comboBoxSalesRegisters.Location = new Point(79, 199);
            comboBoxSalesRegisters.Name = "comboBoxSalesRegisters";
            comboBoxSalesRegisters.Size = new Size(327, 28);
            comboBoxSalesRegisters.TabIndex = 4;
            // 
            // radioButtonDate
            // 
            radioButtonDate.AutoSize = true;
            radioButtonDate.Font = new Font("Candal", 12F, FontStyle.Bold);
            radioButtonDate.Location = new Point(54, 249);
            radioButtonDate.Name = "radioButtonDate";
            radioButtonDate.Size = new Size(88, 33);
            radioButtonDate.TabIndex = 5;
            radioButtonDate.TabStop = true;
            radioButtonDate.Text = "Дате";
            radioButtonDate.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Location = new Point(79, 288);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(327, 27);
            dateTimePickerDate.TabIndex = 6;
            // 
            // buttonSort
            // 
            buttonSort.BackColor = Color.Red;
            buttonSort.FlatStyle = FlatStyle.Flat;
            buttonSort.Font = new Font("Candal", 22.2F, FontStyle.Bold);
            buttonSort.ForeColor = Color.White;
            buttonSort.Location = new Point(38, 351);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(406, 67);
            buttonSort.TabIndex = 22;
            buttonSort.Text = "Отсортировать";
            buttonSort.UseVisualStyleBackColor = false;
            // 
            // FormSort
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 430);
            Controls.Add(buttonSort);
            Controls.Add(dateTimePickerDate);
            Controls.Add(radioButtonDate);
            Controls.Add(comboBoxSalesRegisters);
            Controls.Add(radioButtonSalesRegisters);
            Controls.Add(comboBoxEmploye);
            Controls.Add(label1);
            Controls.Add(radioButtonEmployee);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormSort";
            Text = "Сортировать";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtonEmployee;
        private Label label1;
        private ComboBox comboBoxEmploye;
        private RadioButton radioButtonSalesRegisters;
        private ComboBox comboBoxSalesRegisters;
        private RadioButton radioButtonDate;
        private DateTimePicker dateTimePickerDate;
        private Button buttonSort;
    }
}