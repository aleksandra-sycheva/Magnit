namespace magnit
{
    partial class FormCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreate));
            labelEmployee = new Label();
            comboBoxEmployee = new ComboBox();
            pictureBox1 = new PictureBox();
            labelSalesRegisters = new Label();
            comboBoxSalesRegisters = new ComboBox();
            labelRevenue = new Label();
            textBoxRevenue = new TextBox();
            labelDate = new Label();
            dateTimePickerDate = new DateTimePicker();
            dateTimePickerTimeStart = new DateTimePicker();
            labelTimeStart = new Label();
            labelTimeEnd = new Label();
            dateTimePicker1 = new DateTimePicker();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelEmployee
            // 
            labelEmployee.AutoSize = true;
            labelEmployee.Font = new Font("Candal", 12F, FontStyle.Bold);
            labelEmployee.ForeColor = Color.Black;
            labelEmployee.Location = new Point(12, 96);
            labelEmployee.Name = "labelEmployee";
            labelEmployee.Size = new Size(137, 29);
            labelEmployee.TabIndex = 1;
            labelEmployee.Text = "Сотрудник:";
            // 
            // comboBoxEmployee
            // 
            comboBoxEmployee.FormattingEnabled = true;
            comboBoxEmployee.Location = new Point(155, 96);
            comboBoxEmployee.Name = "comboBoxEmployee";
            comboBoxEmployee.Size = new Size(393, 28);
            comboBoxEmployee.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._upload_iblock_e6c_Magnit_main_logo_RU;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ErrorImage = null;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(137, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 68);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // labelSalesRegisters
            // 
            labelSalesRegisters.AutoSize = true;
            labelSalesRegisters.Font = new Font("Candal", 12F, FontStyle.Bold);
            labelSalesRegisters.ForeColor = Color.Black;
            labelSalesRegisters.Location = new Point(12, 129);
            labelSalesRegisters.Name = "labelSalesRegisters";
            labelSalesRegisters.Size = new Size(86, 29);
            labelSalesRegisters.TabIndex = 22;
            labelSalesRegisters.Text = "Касса:";
            // 
            // comboBoxSalesRegisters
            // 
            comboBoxSalesRegisters.FormattingEnabled = true;
            comboBoxSalesRegisters.Location = new Point(155, 130);
            comboBoxSalesRegisters.Name = "comboBoxSalesRegisters";
            comboBoxSalesRegisters.Size = new Size(393, 28);
            comboBoxSalesRegisters.TabIndex = 23;
            // 
            // labelRevenue
            // 
            labelRevenue.AutoSize = true;
            labelRevenue.Font = new Font("Candal", 12F, FontStyle.Bold);
            labelRevenue.ForeColor = Color.Black;
            labelRevenue.Location = new Point(12, 162);
            labelRevenue.Name = "labelRevenue";
            labelRevenue.Size = new Size(114, 29);
            labelRevenue.TabIndex = 24;
            labelRevenue.Text = "Выручка:";
            // 
            // textBoxRevenue
            // 
            textBoxRevenue.Location = new Point(155, 164);
            textBoxRevenue.Name = "textBoxRevenue";
            textBoxRevenue.Size = new Size(393, 27);
            textBoxRevenue.TabIndex = 25;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Candal", 12F, FontStyle.Bold);
            labelDate.ForeColor = Color.Black;
            labelDate.Location = new Point(12, 195);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(75, 29);
            labelDate.TabIndex = 26;
            labelDate.Text = "Дата:";
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Location = new Point(155, 197);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(393, 27);
            dateTimePickerDate.TabIndex = 27;
            // 
            // dateTimePickerTimeStart
            // 
            dateTimePickerTimeStart.Location = new Point(190, 230);
            dateTimePickerTimeStart.Name = "dateTimePickerTimeStart";
            dateTimePickerTimeStart.Size = new Size(358, 27);
            dateTimePickerTimeStart.TabIndex = 28;
            // 
            // labelTimeStart
            // 
            labelTimeStart.AutoSize = true;
            labelTimeStart.Font = new Font("Candal", 12F, FontStyle.Bold);
            labelTimeStart.ForeColor = Color.Black;
            labelTimeStart.Location = new Point(12, 230);
            labelTimeStart.Name = "labelTimeStart";
            labelTimeStart.Size = new Size(172, 29);
            labelTimeStart.TabIndex = 29;
            labelTimeStart.Text = "Время начала:";
            // 
            // labelTimeEnd
            // 
            labelTimeEnd.AutoSize = true;
            labelTimeEnd.Font = new Font("Candal", 12F, FontStyle.Bold);
            labelTimeEnd.ForeColor = Color.Black;
            labelTimeEnd.Location = new Point(12, 263);
            labelTimeEnd.Name = "labelTimeEnd";
            labelTimeEnd.Size = new Size(159, 29);
            labelTimeEnd.TabIndex = 30;
            labelTimeEnd.Text = "Время конца:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(190, 263);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(358, 27);
            dateTimePicker1.TabIndex = 31;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Red;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Candal", 22.2F, FontStyle.Bold);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(51, 329);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(460, 59);
            buttonSave.TabIndex = 32;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // FormCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(560, 400);
            Controls.Add(buttonSave);
            Controls.Add(dateTimePicker1);
            Controls.Add(labelTimeEnd);
            Controls.Add(labelTimeStart);
            Controls.Add(dateTimePickerTimeStart);
            Controls.Add(dateTimePickerDate);
            Controls.Add(labelDate);
            Controls.Add(textBoxRevenue);
            Controls.Add(labelRevenue);
            Controls.Add(comboBoxSalesRegisters);
            Controls.Add(labelSalesRegisters);
            Controls.Add(pictureBox1);
            Controls.Add(comboBoxEmployee);
            Controls.Add(labelEmployee);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCreate";
            Text = "Добавить/Обновить";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEmployee;
        private ComboBox comboBoxEmployee;
        private PictureBox pictureBox1;
        private Label labelSalesRegisters;
        private ComboBox comboBoxSalesRegisters;
        private Label labelRevenue;
        private TextBox textBoxRevenue;
        private Label labelDate;
        private DateTimePicker dateTimePickerDate;
        private DateTimePicker dateTimePickerTimeStart;
        private Label labelTimeStart;
        private Label labelTimeEnd;
        private DateTimePicker dateTimePicker1;
        private Button buttonSave;
    }
}