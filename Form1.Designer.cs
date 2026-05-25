namespace Assignment_2._1___GUI_Components
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            pnlControl = new Panel();
            btnExplore = new Button();
            lblStats = new Label();
            cmbLocation = new ComboBox();
            lblStory = new Label();
            pnlControl.SuspendLayout();
            SuspendLayout();
            // 
            // pnlControl
            // 
            pnlControl.Controls.Add(btnExplore);
            pnlControl.Controls.Add(lblStats);
            pnlControl.Controls.Add(cmbLocation);
            pnlControl.Controls.Add(lblStory);
            pnlControl.Location = new Point(12, 1015);
            pnlControl.Name = "pnlControl";
            pnlControl.Size = new Size(1750, 202);
            pnlControl.TabIndex = 0;
            // 
            // btnExplore
            // 
            btnExplore.Location = new Point(1588, 125);
            btnExplore.Name = "btnExplore";
            btnExplore.Size = new Size(147, 63);
            btnExplore.TabIndex = 1;
            btnExplore.Text = "Explore";
            btnExplore.UseVisualStyleBackColor = true;
            // 
            // lblStats
            // 
            lblStats.BorderStyle = BorderStyle.Fixed3D;
            lblStats.Font = new Font("Segoe UI", 15F);
            lblStats.ForeColor = Color.OrangeRed;
            lblStats.Location = new Point(1051, 18);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(684, 98);
            lblStats.TabIndex = 2;
            lblStats.Text = "Health: XXX Credits: XXX";
            lblStats.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbLocation
            // 
            cmbLocation.FormattingEnabled = true;
            cmbLocation.Location = new Point(1051, 137);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(531, 40);
            cmbLocation.TabIndex = 1;
            cmbLocation.SelectedIndexChanged += cmbLocation_SelectedIndexChanged;
            // 
            // lblStory
            // 
            lblStory.BorderStyle = BorderStyle.Fixed3D;
            lblStory.Font = new Font("Segoe UI", 12F);
            lblStory.ForeColor = Color.OrangeRed;
            lblStory.Location = new Point(12, 18);
            lblStory.Name = "lblStory";
            lblStory.Size = new Size(1016, 170);
            lblStory.TabIndex = 1;
            lblStory.Text = "Story";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.start;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1774, 1229);
            Controls.Add(pnlControl);
            MaximumSize = new Size(1800, 1300);
            MinimumSize = new Size(1800, 1300);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mars RPG";
            Load += frmMain_Load;
            pnlControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlControl;
        private Label lblStory;
        private Label lblStats;
        private ComboBox cmbLocation;
        private Button btnExplore;
    }
}
