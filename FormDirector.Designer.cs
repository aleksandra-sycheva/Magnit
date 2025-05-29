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
            button1 = new Button();
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
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(buttonHistoryRevenue);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(buttonEmployee);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(348, 537);
            panelMenu.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Candal", 16F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 357);
            button1.Name = "button1";
            button1.Size = new Size(330, 93);
            button1.TabIndex = 4;
            button1.Text = "Зарегистрировать сотрудника";
            button1.UseVisualStyleBackColor = false;
            // 
            // buttonHistoryRevenue
            // 
            buttonHistoryRevenue.Anchor = AnchorStyles.None;
            buttonHistoryRevenue.BackColor = Color.Red;
            buttonHistoryRevenue.FlatStyle = FlatStyle.Flat;
            buttonHistoryRevenue.Font = new Font("Candal", 16F, FontStyle.Bold);
            buttonHistoryRevenue.ForeColor = Color.White;
            buttonHistoryRevenue.Location = new Point(12, 260);
            buttonHistoryRevenue.Name = "buttonHistoryRevenue";
            buttonHistoryRevenue.Size = new Size(330, 59);
            buttonHistoryRevenue.TabIndex = 3;
            buttonHistoryRevenue.Text = "История выручки";
            buttonHistoryRevenue.UseVisualStyleBackColor = false;
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
            buttonEmployee.Location = new Point(12, 137);
            buttonEmployee.Name = "buttonEmployee";
            buttonEmployee.Size = new Size(330, 90);
            buttonEmployee.TabIndex = 1;
            buttonEmployee.Text = "Подробнее о сотруднике";
            buttonEmployee.UseVisualStyleBackColor = false;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewEmployee);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(348, 0);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(653, 537);
            panelFill.TabIndex = 1;
            // 
            // dataGridViewEmployee
            // 
            dataGridViewEmployee.BackgroundColor = Color.White;
            dataGridViewEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployee.Dock = DockStyle.Fill;
            dataGridViewEmployee.Location = new Point(0, 0);
            dataGridViewEmployee.Name = "dataGridViewEmployee";
            dataGridViewEmployee.RowHeadersWidth = 51;
            dataGridViewEmployee.Size = new Size(653, 537);
            dataGridViewEmployee.TabIndex = 0;
            // 
            // FormDirector
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 537);
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
        private Button button1;
    }
}