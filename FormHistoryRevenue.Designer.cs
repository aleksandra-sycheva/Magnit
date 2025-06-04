namespace magnit
{
    partial class FormHistoryRevenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoryRevenue));
            panelMenu = new Panel();
            buttonBack = new Button();
            pictureBox1 = new PictureBox();
            buttonSort = new Button();
            buttonUpdate = new Button();
            buttonCreate = new Button();
            panelFill = new Panel();
            dataGridViewHistoryRevenue = new DataGridView();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistoryRevenue).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(buttonBack);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(buttonSort);
            panelMenu.Controls.Add(buttonUpdate);
            panelMenu.Controls.Add(buttonCreate);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(1233, 136);
            panelMenu.TabIndex = 0;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.None;
            buttonBack.BackColor = Color.Red;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Candal", 16F, FontStyle.Bold);
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(1010, 22);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(211, 90);
            buttonBack.TabIndex = 6;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._upload_iblock_09b_Magnit_M_sign;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 127);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // buttonSort
            // 
            buttonSort.Anchor = AnchorStyles.None;
            buttonSort.BackColor = Color.Red;
            buttonSort.FlatStyle = FlatStyle.Flat;
            buttonSort.Font = new Font("Candal", 16F, FontStyle.Bold);
            buttonSort.ForeColor = Color.White;
            buttonSort.Location = new Point(634, 22);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(228, 90);
            buttonSort.TabIndex = 4;
            buttonSort.Text = "Сортировать";
            buttonSort.UseVisualStyleBackColor = false;
            buttonSort.Click += buttonSort_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.None;
            buttonUpdate.BackColor = Color.Red;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Candal", 16F, FontStyle.Bold);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(401, 22);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(215, 90);
            buttonUpdate.TabIndex = 3;
            buttonUpdate.Text = "Обновить";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.Anchor = AnchorStyles.None;
            buttonCreate.BackColor = Color.Red;
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Candal", 16F, FontStyle.Bold);
            buttonCreate.ForeColor = Color.White;
            buttonCreate.Location = new Point(174, 22);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(211, 90);
            buttonCreate.TabIndex = 2;
            buttonCreate.Text = "Добавить";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewHistoryRevenue);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 136);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(1233, 434);
            panelFill.TabIndex = 1;
            // 
            // dataGridViewHistoryRevenue
            // 
            dataGridViewHistoryRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHistoryRevenue.BackgroundColor = Color.White;
            dataGridViewHistoryRevenue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistoryRevenue.Dock = DockStyle.Fill;
            dataGridViewHistoryRevenue.Location = new Point(0, 0);
            dataGridViewHistoryRevenue.Name = "dataGridViewHistoryRevenue";
            dataGridViewHistoryRevenue.RowHeadersWidth = 51;
            dataGridViewHistoryRevenue.ScrollBars = ScrollBars.Vertical;
            dataGridViewHistoryRevenue.Size = new Size(1233, 434);
            dataGridViewHistoryRevenue.TabIndex = 0;
            // 
            // FormHistoryRevenue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 570);
            Controls.Add(panelFill);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormHistoryRevenue";
            Text = "История выручки";
            Load += FormHistoryRevenue_Load;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistoryRevenue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelFill;
        private Button buttonSort;
        private Button buttonUpdate;
        private Button buttonCreate;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewHistoryRevenue;
        private Button buttonBack;
    }
}