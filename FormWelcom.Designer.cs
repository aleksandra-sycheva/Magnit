namespace magnit
{
    partial class FormWelcom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWelcom));
            buttonEnter = new Button();
            SuspendLayout();
            // 
            // buttonEnter
            // 
            buttonEnter.Anchor = AnchorStyles.None;
            buttonEnter.BackColor = Color.Red;
            buttonEnter.FlatStyle = FlatStyle.Flat;
            buttonEnter.Font = new Font("Candal", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEnter.ForeColor = Color.White;
            buttonEnter.Location = new Point(504, 387);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(234, 60);
            buttonEnter.TabIndex = 0;
            buttonEnter.Text = "Вход";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // FormWelcom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.магнит;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(843, 474);
            Controls.Add(buttonEnter);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormWelcom";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonEnter;
    }
}