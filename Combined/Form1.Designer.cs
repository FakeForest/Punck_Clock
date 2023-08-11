namespace Combined
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelCIOSubmenu = new System.Windows.Forms.Panel();
            this.btnout = new System.Windows.Forms.Button();
            this.btnin = new System.Windows.Forms.Button();
            this.btnCIO = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTime = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelSideMenu.SuspendLayout();
            this.panelCIOSubmenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelSideMenu.Controls.Add(this.panelCIOSubmenu);
            this.panelSideMenu.Controls.Add(this.btnCIO);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(151, 457);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelCIOSubmenu
            // 
            this.panelCIOSubmenu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelCIOSubmenu.Controls.Add(this.btnout);
            this.panelCIOSubmenu.Controls.Add(this.btnin);
            this.panelCIOSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCIOSubmenu.Location = new System.Drawing.Point(0, 100);
            this.panelCIOSubmenu.Name = "panelCIOSubmenu";
            this.panelCIOSubmenu.Size = new System.Drawing.Size(151, 60);
            this.panelCIOSubmenu.TabIndex = 2;
            // 
            // btnout
            // 
            this.btnout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnout.FlatAppearance.BorderSize = 0;
            this.btnout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnout.Font = new System.Drawing.Font("Pristina", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnout.Location = new System.Drawing.Point(0, 30);
            this.btnout.Name = "btnout";
            this.btnout.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnout.Size = new System.Drawing.Size(151, 30);
            this.btnout.TabIndex = 1;
            this.btnout.Text = "Swipe out";
            this.btnout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnout.UseVisualStyleBackColor = true;
            this.btnout.Click += new System.EventHandler(this.btnout_Click);
            // 
            // btnin
            // 
            this.btnin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnin.FlatAppearance.BorderSize = 0;
            this.btnin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnin.Font = new System.Drawing.Font("Pristina", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnin.Location = new System.Drawing.Point(0, 0);
            this.btnin.Name = "btnin";
            this.btnin.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnin.Size = new System.Drawing.Size(151, 30);
            this.btnin.TabIndex = 0;
            this.btnin.Text = "Swipe in";
            this.btnin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // btnCIO
            // 
            this.btnCIO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCIO.FlatAppearance.BorderSize = 0;
            this.btnCIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCIO.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCIO.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCIO.Location = new System.Drawing.Point(0, 64);
            this.btnCIO.Name = "btnCIO";
            this.btnCIO.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnCIO.Size = new System.Drawing.Size(151, 36);
            this.btnCIO.TabIndex = 1;
            this.btnCIO.Text = "Clock in/out";
            this.btnCIO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCIO.UseVisualStyleBackColor = true;
            this.btnCIO.Click += new System.EventHandler(this.btnCIO_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(151, 64);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.Azure;
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(151, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(557, 457);
            this.panelChildForm.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(134, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTime
            // 
            this.panelTime.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTime.Controls.Add(this.label2);
            this.panelTime.Controls.Add(this.label1);
            this.panelTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTime.Location = new System.Drawing.Point(151, 382);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(557, 75);
            this.panelTime.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pristina", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(101, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(299, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 457);
            this.Controls.Add(this.panelTime);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(724, 496);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Stamping";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelCIOSubmenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTime.ResumeLayout(false);
            this.panelTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelCIOSubmenu;
        private System.Windows.Forms.Button btnCIO;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button btnout;
        public System.Windows.Forms.Button btnin;
    }
}

