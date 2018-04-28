namespace Enciclopedie
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RockOnLogo = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.currentSongTitle_Label = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.player = new System.Windows.Forms.WebBrowser();
            this.panel9 = new System.Windows.Forms.Panel();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.LeftMenu = new System.Windows.Forms.PictureBox();
            this.despre = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RockOnLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.RockOnLogo);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 39);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(251, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 80);
            this.panel2.TabIndex = 3;
            // 
            // RockOnLogo
            // 
            this.RockOnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RockOnLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.RockOnLogo.Image = ((System.Drawing.Image)(resources.GetObject("RockOnLogo.Image")));
            this.RockOnLogo.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.RockOnLogo.Location = new System.Drawing.Point(0, 0);
            this.RockOnLogo.Name = "RockOnLogo";
            this.RockOnLogo.Size = new System.Drawing.Size(212, 39);
            this.RockOnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RockOnLogo.TabIndex = 1;
            this.RockOnLogo.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CloseButton.Location = new System.Drawing.Point(1147, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(85, 39);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CloseButton.TabIndex = 2;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(203, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(21, 504);
            this.panel3.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(224, 532);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1008, 11);
            this.panel5.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 463);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(16, 11);
            this.panel7.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1216, 58);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(16, 474);
            this.panel6.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(224, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1008, 19);
            this.panel4.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel8.Controls.Add(this.currentSongTitle_Label);
            this.panel8.Controls.Add(this.nextButton);
            this.panel8.Controls.Add(this.previousButton);
            this.panel8.Controls.Add(this.player);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.browser);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(224, 58);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(992, 474);
            this.panel8.TabIndex = 9;
            // 
            // currentSongTitle_Label
            // 
            this.currentSongTitle_Label.AutoSize = true;
            this.currentSongTitle_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentSongTitle_Label.Location = new System.Drawing.Point(23, 331);
            this.currentSongTitle_Label.Name = "currentSongTitle_Label";
            this.currentSongTitle_Label.Size = new System.Drawing.Size(0, 20);
            this.currentSongTitle_Label.TabIndex = 9;
            // 
            // nextButton
            // 
            this.nextButton.Image = ((System.Drawing.Image)(resources.GetObject("nextButton.Image")));
            this.nextButton.Location = new System.Drawing.Point(219, 400);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(45, 45);
            this.nextButton.TabIndex = 8;
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // previousButton
            // 
            this.previousButton.Image = ((System.Drawing.Image)(resources.GetObject("previousButton.Image")));
            this.previousButton.Location = new System.Drawing.Point(72, 400);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(45, 45);
            this.previousButton.TabIndex = 7;
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // player
            // 
            this.player.Location = new System.Drawing.Point(6, 6);
            this.player.MinimumSize = new System.Drawing.Size(20, 20);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(334, 285);
            this.player.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(349, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(17, 474);
            this.panel9.TabIndex = 2;
            // 
            // browser
            // 
            this.browser.Dock = System.Windows.Forms.DockStyle.Right;
            this.browser.Location = new System.Drawing.Point(366, 0);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(626, 474);
            this.browser.TabIndex = 0;
            this.browser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // LeftMenu
            // 
            this.LeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.LeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMenu.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.LeftMenu.Location = new System.Drawing.Point(0, 39);
            this.LeftMenu.Margin = new System.Windows.Forms.Padding(0);
            this.LeftMenu.Name = "LeftMenu";
            this.LeftMenu.Size = new System.Drawing.Size(203, 504);
            this.LeftMenu.TabIndex = 2;
            this.LeftMenu.TabStop = false;
            // 
            // despre
            // 
            this.despre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.despre.Enabled = false;
            this.despre.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.despre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.despre.Location = new System.Drawing.Point(12, 58);
            this.despre.Name = "despre";
            this.despre.Size = new System.Drawing.Size(185, 473);
            this.despre.TabIndex = 10;
            this.despre.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 543);
            this.Controls.Add(this.despre);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.LeftMenu);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RockOnLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox RockOnLogo;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.WebBrowser player;
        private System.Windows.Forms.PictureBox LeftMenu;
        private System.Windows.Forms.RichTextBox despre;
        private System.Windows.Forms.Label currentSongTitle_Label;
    }
}