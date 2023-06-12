namespace UserInterface_WindowsForms
{
    partial class FormStart
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonFavorite = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonApply = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.buttonStart = new CustomControls.RJControls.RJButton();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(271, 590);
            this.sidebar.MinimumSize = new System.Drawing.Size(91, 590);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(271, 590);
            this.sidebar.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.menuButton);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 113);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::UserInterface_WindowsForms.Properties.Resources.menu_4_24;
            this.menuButton.Location = new System.Drawing.Point(26, 40);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(34, 30);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Location = new System.Drawing.Point(3, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 57);
            this.panel1.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = global::UserInterface_WindowsForms.Properties.Resources.house_24;
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(-18, -5);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.buttonHome.Size = new System.Drawing.Size(304, 66);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "               Acasă";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonFavorite);
            this.panel3.Location = new System.Drawing.Point(3, 185);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 57);
            this.panel3.TabIndex = 2;
            // 
            // buttonFavorite
            // 
            this.buttonFavorite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFavorite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFavorite.ForeColor = System.Drawing.Color.White;
            this.buttonFavorite.Image = global::UserInterface_WindowsForms.Properties.Resources.view_details_24;
            this.buttonFavorite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFavorite.Location = new System.Drawing.Point(-18, -5);
            this.buttonFavorite.Name = "buttonFavorite";
            this.buttonFavorite.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.buttonFavorite.Size = new System.Drawing.Size(304, 66);
            this.buttonFavorite.TabIndex = 0;
            this.buttonFavorite.Text = "               Lista preferințe";
            this.buttonFavorite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFavorite.UseVisualStyleBackColor = true;
            this.buttonFavorite.Click += new System.EventHandler(this.buttonFavorite_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonInfo);
            this.panel5.Location = new System.Drawing.Point(3, 248);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(268, 57);
            this.panel5.TabIndex = 4;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonInfo.ForeColor = System.Drawing.Color.White;
            this.buttonInfo.Image = global::UserInterface_WindowsForms.Properties.Resources.info_24;
            this.buttonInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInfo.Location = new System.Drawing.Point(-18, -5);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.buttonInfo.Size = new System.Drawing.Size(304, 66);
            this.buttonInfo.TabIndex = 0;
            this.buttonInfo.Text = "               Despre";
            this.buttonInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonApply);
            this.panel4.Location = new System.Drawing.Point(3, 311);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(268, 57);
            this.panel4.TabIndex = 5;
            // 
            // buttonApply
            // 
            this.buttonApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonApply.ForeColor = System.Drawing.Color.White;
            this.buttonApply.Image = global::UserInterface_WindowsForms.Properties.Resources.ok_24;
            this.buttonApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonApply.Location = new System.Drawing.Point(-18, -5);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.buttonApply.Size = new System.Drawing.Size(304, 66);
            this.buttonApply.TabIndex = 0;
            this.buttonApply.Text = "               Aplică";
            this.buttonApply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Location = new System.Drawing.Point(89, 0);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1126, 590);
            this.panelDesktopPanel.TabIndex = 4;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.buttonStart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.buttonStart.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonStart.BorderRadius = 10;
            this.buttonStart.BorderSize = 0;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI Black", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(277, 57);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(763, 271);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Aplicația care te va ajuta cu\r\nalegerea laptopului preferat.";
            this.buttonStart.TextColor = System.Drawing.Color.White;
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 590);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panelDesktopPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStart";
            this.Text = "Choose Laptop";
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonFavorite;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sidebarTimer;
        private CustomControls.RJControls.RJButton buttonStart;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonApply;
    }
}