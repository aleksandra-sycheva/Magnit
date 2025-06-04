
namespace magnit
{
    partial class FormDirector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDirector));
            panelMenu = new Panel();
            buttonUpdate = new Button();
            buttonExit = new Button();
            buttonDelete = new Button();
            buttonRegistration = new Button();
            buttonHistoryRevenue = new Button();
            pictureBox1 = new PictureBox();
            buttonEmployee = new Button();
            panelFill = new Panel();
            dataGridViewEmployee = new DataGridView();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(buttonUpdate);
            panelMenu.Controls.Add(buttonExit);
            panelMenu.Controls.Add(buttonDelete);
            panelMenu.Controls.Add(buttonRegistration);
            panelMenu.Controls.Add(buttonHistoryRevenue);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(buttonEmployee);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(348, 710);
            panelMenu.TabIndex = 0;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.None;
            buttonUpdate.BackColor = Color.Red;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Candal", 16F, FontStyle.Bold);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(12, 478);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(330, 93);
            buttonUpdate.TabIndex = 7;
            buttonUpdate.Text = "Обновить данные о сотруднике";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonExit
            // 
            buttonExit.Anchor = AnchorStyles.None;
            buttonExit.BackColor = Color.Red;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Candal", 16F, FontStyle.Bold);
            buttonExit.ForeColor = Color.White;
            buttonExit.Location = new Point(12, 630);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(330, 68);
            buttonExit.TabIndex = 6;
            buttonExit.Text = "Выйти";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.None;
            buttonDelete.BackColor = Color.Red;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Candal", 16F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(12, 282);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(330, 91);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Уволить сотрудника";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonRegistration
            // 
            buttonRegistration.Anchor = AnchorStyles.None;
            buttonRegistration.BackColor = Color.Red;
            buttonRegistration.FlatStyle = FlatStyle.Flat;
            buttonRegistration.Font = new Font("Candal", 16F, FontStyle.Bold);
            buttonRegistration.ForeColor = Color.White;
            buttonRegistration.Location = new Point(12, 379);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(330, 93);
            buttonRegistration.TabIndex = 4;
            buttonRegistration.Text = "Зарегистрировать сотрудника";
            buttonRegistration.UseVisualStyleBackColor = false;
            buttonRegistration.Click += buttonRegistration_Click;
            // 
            // buttonHistoryRevenue
            // 
            buttonHistoryRevenue.Anchor = AnchorStyles.None;
            buttonHistoryRevenue.BackColor = Color.Red;
            buttonHistoryRevenue.FlatStyle = FlatStyle.Flat;
            buttonHistoryRevenue.Font = new Font("Candal", 16F, FontStyle.Bold);
            buttonHistoryRevenue.ForeColor = Color.White;
            buttonHistoryRevenue.Location = new Point(12, 121);
            buttonHistoryRevenue.Name = "buttonHistoryRevenue";
            buttonHistoryRevenue.Size = new Size(330, 59);
            buttonHistoryRevenue.TabIndex = 3;
            buttonHistoryRevenue.Text = "История выручки";
            buttonHistoryRevenue.UseVisualStyleBackColor = false;
            buttonHistoryRevenue.Click += buttonHistoryRevenue_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._upload_iblock_e6c_Magnit_main_logo_RU;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 103);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // buttonEmployee
            // 
            buttonEmployee.Anchor = AnchorStyles.None;
            buttonEmployee.BackColor = Color.Red;
            buttonEmployee.FlatStyle = FlatStyle.Flat;
            buttonEmployee.Font = new Font("Candal", 16F, FontStyle.Bold);
            buttonEmployee.ForeColor = Color.White;
            buttonEmployee.Location = new Point(12, 186);
            buttonEmployee.Name = "buttonEmployee";
            buttonEmployee.Size = new Size(330, 90);
            buttonEmployee.TabIndex = 1;
            buttonEmployee.Text = "Подробнее о сотруднике";
            buttonEmployee.UseVisualStyleBackColor = false;
            buttonEmployee.Click += buttonEmployee_Click;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewEmployee);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(348, 0);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(687, 710);
            panelFill.TabIndex = 1;
            // 
            // dataGridViewEmployee
            // 
            dataGridViewEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmployee.BackgroundColor = Color.White;
            dataGridViewEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployee.Dock = DockStyle.Fill;
            dataGridViewEmployee.Location = new Point(0, 0);
            dataGridViewEmployee.Name = "dataGridViewEmployee";
            dataGridViewEmployee.RowHeadersWidth = 51;
            dataGridViewEmployee.ScrollBars = ScrollBars.Vertical;
            dataGridViewEmployee.Size = new Size(687, 710);
            dataGridViewEmployee.TabIndex = 0;
            // 
            // FormDirector
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 710);
            Controls.Add(panelFill);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormDirector";
            Text = "Список сотрудников";
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelFill;
        private DataGridView dataGridViewEmployee;
        private Button buttonHistoryRevenue;
        private PictureBox pictureBox1;
        private Button buttonEmployee;
        private Button buttonRegistration;
        private Button buttonDelete;
        private Button buttonExit;
        private Button buttonUpdate;
    }
}