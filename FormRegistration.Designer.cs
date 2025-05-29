namespace magnit
{
    partial class FormRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistration));
            labelTypeOfEmployee = new Label();
            comboBoxTypeOfEmploee = new ComboBox();
            labelName = new Label();
            textBoxName = new TextBox();
            labelSurname = new Label();
            textBoxSurname = new TextBox();
            labelMiddleName = new Label();
            textBoxmMiddleName = new TextBox();
            labelDaterOfBirth = new Label();
            dateTimePickerDaterOfBirth = new DateTimePicker();
            labelResidentialAddress = new Label();
            textBoxResidentialAddress = new TextBox();
            labelPhone = new Label();
            textBoxPhone = new TextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            labelDateOfEmployment = new Label();
            dateTimePickerDateOfEmployment = new DateTimePicker();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            pictureBox1 = new PictureBox();
            buttonRegistration = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelTypeOfEmployee
            // 
            labelTypeOfEmployee.AutoSize = true;
            labelTypeOfEmployee.Font = new Font("Candal", 12F, FontStyle.Bold);
            labelTypeOfEmployee.ForeColor = Color.Black;
            labelTypeOfEmployee.Location = new Point(16, 90);
            labelTypeOfEmployee.Name = "labelTypeOfEmployee";
            labelTypeOfEmployee.Size = new Size(204, 29);
            labelTypeOfEmployee.TabIndex = 0;
            labelTypeOfEmployee.Text = "Роль сотрудника:";
            // 
            // comboBoxTypeOfEmploee
            // 
            comboBoxTypeOfEmploee.FormattingEnabled = true;
            comboBoxTypeOfEmploee.Location = new Point(224, 90);
            comboBoxTypeOfEmploee.Name = "comboBoxTypeOfEmploee";
            comboBoxTypeOfEmploee.Size = new Size(314, 28);
            comboBoxTypeOfEmploee.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Candal", 12F, FontStyle.Bold);
            labelName.ForeColor = Color.Black;
            labelName.Location = new Point(16, 124);
            labelName.Name = "labelName";
            labelName.Size = new Size(65, 29);
            labelName.TabIndex = 2;
            labelName.Text = "Имя:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(142, 124);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(396, 27);
            textBoxName.TabIndex = 3;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Candal", 12F, FontStyle.Bold);
            labelSurname.ForeColor = Color.Black;
            labelSurname.Location = new Point(16, 157);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(120, 29);
            labelSurname.TabIndex = 4;
            labelSurname.Text = "Фамилия:";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(142, 157);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(396, 27);
            textBoxSurname.TabIndex = 5;
            // 
            // labelMiddleName
            // 
            labelMiddleName.AutoSize = true;
            labelMiddleName.Font = new Font("Candal", 12F, FontStyle.Bold);
            labelMiddleName.ForeColor = Color.Black;
            labelMiddleName.Location = new Point(16, 190);
            labelMiddleName.Name = "labelMiddleName";
            labelMiddleName.Size = new Size(122, 29);
            labelMiddleName.TabIndex = 6;
            labelMiddleName.Text = "Отчество:";
            // 
            // textBoxmMiddleName
            // 
            textBoxmMiddleName.Location = new Point(144, 190);
            textBoxmMiddleName.Name = "textBoxmMiddleName";
            textBoxmMiddleName.Size = new Size(394, 27);
            textBoxmMiddleName.TabIndex = 7;
            // 
            // labelDaterOfBirth
            // 
            labelDaterOfBirth.AutoSize = true;
            labelDaterOfBirth.Font = new Font("Candal", 12F, FontStyle.Bold);
            labelDaterOfBirth.ForeColor = Color.Black;
            labelDaterOfBirth.Location = new Point(16, 223);
            labelDaterOfBirth.Name = "labelDaterOfBirth";
            labelDaterOfBirth.Size = new Size(186, 29);
            labelDaterOfBirth.TabIndex = 8;
            labelDaterOfBirth.Text = "Дата рождения:";
            // 
            // dateTimePickerDaterOfBirth
            // 
            dateTimePickerDaterOfBirth.Location = new Point(206, 223);
            dateTimePickerDaterOfBirth.Name = "dateTimePickerDaterOfBirth";
            dateTimePickerDaterOfBirth.Size = new Size(332, 27);
            dateTimePickerDaterOfBirth.TabIndex = 9;
            // 
            // labelResidentialAddress
            // 
            labelResidentialAddress.AutoSize = true;
            labelResidentialAddress.Font = new Font("Candal", 12F, FontStyle.Bold);
            labelResidentialAddress.ForeColor = Color.Black;
            labelResidentialAddress.Location = new Point(16, 253);
            labelResidentialAddress.Name = "labelResidentialAddress";
            labelResidentialAddress.Size = new Size(87, 29);
            labelResidentialAddress.TabIndex = 10;
            labelResidentialAddress.Text = "Адрес:";
            // 
            // textBoxResidentialAddress
            // 
            textBoxResidentialAddress.Location = new Point(109, 256);
            textBoxResidentialAddress.Name = "textBoxResidentialAddress";
            textBoxResidentialAddress.Size = new Size(429, 27);
            textBoxResidentialAddress.TabIndex = 11;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Candal", 12F, FontStyle.Bold);
            labelPhone.ForeColor = Color.Black;
            labelPhone.Location = new Point(16, 289);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(118, 29);
            labelPhone.TabIndex = 12;
            labelPhone.Text = "Телефон:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(140, 289);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(398, 27);
            textBoxPhone.TabIndex = 13;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Candal", 12F, FontStyle.Bold);
            labelEmail.ForeColor = Color.Black;
            labelEmail.Location = new Point(16, 322);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(90, 29);
            labelEmail.TabIndex = 14;
            labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(112, 322);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(426, 27);
            textBoxEmail.TabIndex = 15;
            // 
            // labelDateOfEmployment
            // 
            labelDateOfEmployment.AutoSize = true;
            labelDateOfEmployment.Font = new Font("Candal", 12F, FontStyle.Bold);
            labelDateOfEmployment.ForeColor = Color.Black;
            labelDateOfEmployment.Location = new Point(16, 355);
            labelDateOfEmployment.Name = "labelDateOfEmployment";
            labelDateOfEmployment.Size = new Size(180, 29);
            labelDateOfEmployment.TabIndex = 16;
            labelDateOfEmployment.Text = "Дата принятия:";
            // 
            // dateTimePickerDateOfEmployment
            // 
            dateTimePickerDateOfEmployment.Location = new Point(206, 355);
            dateTimePickerDateOfEmployment.Name = "dateTimePickerDateOfEmployment";
            dateTimePickerDateOfEmployment.Size = new Size(332, 27);
            dateTimePickerDateOfEmployment.TabIndex = 17;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Candal", 12F, FontStyle.Bold);
            labelPassword.ForeColor = Color.Black;
            labelPassword.Location = new Point(16, 388);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(101, 29);
            labelPassword.TabIndex = 18;
            labelPassword.Text = "Пароль:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(123, 388);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(415, 27);
            textBoxPassword.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._upload_iblock_e6c_Magnit_main_logo_RU;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ErrorImage = null;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(123, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 68);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // buttonRegistration
            // 
            buttonRegistration.BackColor = Color.Red;
            buttonRegistration.FlatStyle = FlatStyle.Flat;
            buttonRegistration.Font = new Font("Candal", 22.2F, FontStyle.Bold);
            buttonRegistration.ForeColor = Color.White;
            buttonRegistration.Location = new Point(45, 444);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(460, 59);
            buttonRegistration.TabIndex = 21;
            buttonRegistration.Text = "Зарегистрироваться";
            buttonRegistration.UseVisualStyleBackColor = false;
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(560, 515);
            Controls.Add(buttonRegistration);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(dateTimePickerDateOfEmployment);
            Controls.Add(labelDateOfEmployment);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(textBoxPhone);
            Controls.Add(labelPhone);
            Controls.Add(textBoxResidentialAddress);
            Controls.Add(labelResidentialAddress);
            Controls.Add(dateTimePickerDaterOfBirth);
            Controls.Add(labelDaterOfBirth);
            Controls.Add(textBoxmMiddleName);
            Controls.Add(labelMiddleName);
            Controls.Add(textBoxSurname);
            Controls.Add(labelSurname);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Controls.Add(comboBoxTypeOfEmploee);
            Controls.Add(labelTypeOfEmployee);
            ForeColor = Color.CornflowerBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormRegistration";
            Text = "Регистрация нового сотрудника";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTypeOfEmployee;
        private ComboBox comboBoxTypeOfEmploee;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelSurname;
        private TextBox textBoxSurname;
        private Label labelMiddleName;
        private TextBox textBoxmMiddleName;
        private Label labelDaterOfBirth;
        private DateTimePicker dateTimePickerDaterOfBirth;
        private Label labelResidentialAddress;
        private TextBox textBoxResidentialAddress;
        private Label labelPhone;
        private TextBox textBoxPhone;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelDateOfEmployment;
        private DateTimePicker dateTimePickerDateOfEmployment;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private PictureBox pictureBox1;
        private Button buttonRegistration;
    }
}