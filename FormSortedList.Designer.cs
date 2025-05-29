namespace magnit
{
    partial class FormSortedList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSortedList));
            panelMenu = new Panel();
            panelFill = new Panel();
            dataGridViewHistoryRevenue = new DataGridView();
            pictureBox1 = new PictureBox();
            buttonCreate = new Button();
            buttonUpdate = new Button();
            panelMenu.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistoryRevenue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(buttonUpdate);
            panelMenu.Controls.Add(buttonCreate);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(719, 146);
            panelMenu.TabIndex = 0;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewHistoryRevenue);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 146);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(719, 341);
            panelFill.TabIndex = 1;
            // 
            // dataGridViewHistoryRevenue
            // 
            dataGridViewHistoryRevenue.BackgroundColor = Color.White;
            dataGridViewHistoryRevenue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistoryRevenue.Dock = DockStyle.Fill;
            dataGridViewHistoryRevenue.Location = new Point(0, 0);
            dataGridViewHistoryRevenue.Name = "dataGridViewHistoryRevenue";
            dataGridViewHistoryRevenue.RowHeadersWidth = 51;
            dataGridViewHistoryRevenue.Size = new Size(719, 341);
            dataGridViewHistoryRevenue.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._upload_iblock_09b_Magnit_M_sign;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 116);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonCreate
            // 
            buttonCreate.Anchor = AnchorStyles.None;
            buttonCreate.BackColor = Color.Red;
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Candal", 16F, FontStyle.Bold);
            buttonCreate.ForeColor = Color.White;
            buttonCreate.Location = new Point(182, 25);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(211, 90);
            buttonCreate.TabIndex = 3;
            buttonCreate.Text = "Добавить";
            buttonCreate.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.None;
            buttonUpdate.BackColor = Color.Red;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Candal", 16F, FontStyle.Bold);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(458, 25);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(215, 90);
            buttonUpdate.TabIndex = 4;
            buttonUpdate.Text = "Обновить";
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // FormSortedList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(719, 487);
            Controls.Add(panelFill);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormSortedList";
            Text = "Отсортированный список";
            panelMenu.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistoryRevenue).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private PictureBox pictureBox1;
        private Panel panelFill;
        private DataGridView dataGridViewHistoryRevenue;
        private Button buttonCreate;
        private Button buttonUpdate;
    }
}