namespace magnit
{
    partial class FormEnter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnter));
            pictureBox1 = new PictureBox();
            textBoxLogin = new TextBox();
            labelLogin = new Label();
            labelPassword = new Label();
            textBoxPasword = new TextBox();
            buttonEnter = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._upload_iblock_e6c_Magnit_main_logo_RU;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ErrorImage = null;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(52, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(348, 89);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.White;
            textBoxLogin.Location = new Point(52, 183);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(348, 27);
            textBoxLogin.TabIndex = 1;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Candal", 12F, FontStyle.Bold);
            labelLogin.ForeColor = Color.Black;
            labelLogin.Location = new Point(52, 151);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(177, 29);
            labelLogin.TabIndex = 2;
            labelLogin.Text = "Введите логин:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Candal", 12F, FontStyle.Bold);
            labelPassword.ForeColor = Color.Black;
            labelPassword.Location = new Point(52, 257);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(193, 29);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Введите пароль:";
            // 
            // textBoxPasword
            // 
            textBoxPasword.BackColor = Color.White;
            textBoxPasword.Location = new Point(52, 289);
            textBoxPasword.Name = "textBoxPasword";
            textBoxPasword.Size = new Size(348, 27);
            textBoxPasword.TabIndex = 4;
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.Red;
            buttonEnter.FlatStyle = FlatStyle.Flat;
            buttonEnter.Font = new Font("Candal", 22.2F, FontStyle.Bold);
            buttonEnter.ForeColor = Color.White;
            buttonEnter.Location = new Point(110, 375);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(238, 59);
            buttonEnter.TabIndex = 5;
            buttonEnter.Text = "Войти";
            buttonEnter.UseVisualStyleBackColor = false;
            // 
            // FormEnter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(463, 458);
            Controls.Add(buttonEnter);
            Controls.Add(textBoxPasword);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(textBoxLogin);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormEnter";
            Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBoxLogin;
        private Label labelLogin;
        private Label labelPassword;
        private TextBox textBoxPasword;
        private Button buttonEnter;
    }
}