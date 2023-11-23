namespace Laboratory_Number_1
{
    partial class LoginForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.HideLogin = new System.Windows.Forms.Label();
            this.SecondaryPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.MainText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            this.SecondaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(8)))), ((int)(((byte)(24)))));
            this.MainPanel.Controls.Add(this.HideLogin);
            this.MainPanel.Controls.Add(this.SecondaryPanel);
            this.MainPanel.Controls.Add(this.button1);
            this.MainPanel.Controls.Add(this.passField);
            this.MainPanel.Controls.Add(this.pictureBox2);
            this.MainPanel.Controls.Add(this.loginField);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 608);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // HideLogin
            // 
            this.HideLogin.AutoSize = true;
            this.HideLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HideLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HideLogin.ForeColor = System.Drawing.Color.White;
            this.HideLogin.Location = new System.Drawing.Point(265, 545);
            this.HideLogin.Name = "HideLogin";
            this.HideLogin.Size = new System.Drawing.Size(295, 31);
            this.HideLogin.TabIndex = 6;
            this.HideLogin.Text = "Начать без аккаунта";
            this.HideLogin.Click += new System.EventHandler(this.HideLogin_Click);
            this.HideLogin.MouseEnter += new System.EventHandler(this.HideLogin_MouseEnter);
            this.HideLogin.MouseLeave += new System.EventHandler(this.HideLogin_MouseLeave);
            // 
            // SecondaryPanel
            // 
            this.SecondaryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.SecondaryPanel.Controls.Add(this.closeButton);
            this.SecondaryPanel.Controls.Add(this.MainText);
            this.SecondaryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SecondaryPanel.Location = new System.Drawing.Point(0, 0);
            this.SecondaryPanel.Name = "SecondaryPanel";
            this.SecondaryPanel.Size = new System.Drawing.Size(800, 127);
            this.SecondaryPanel.TabIndex = 0;
            this.SecondaryPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecondaryPanel_MouseDown);
            this.SecondaryPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SecondaryPanel_MouseMove);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(770, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 29);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Х";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // MainText
            // 
            this.MainText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainText.Font = new System.Drawing.Font("MS Reference Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MainText.Location = new System.Drawing.Point(0, 0);
            this.MainText.Name = "MainText";
            this.MainText.Size = new System.Drawing.Size(800, 127);
            this.MainText.TabIndex = 0;
            this.MainText.Text = "Авторизация";
            this.MainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(117)))), ((int)(((byte)(43)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(328, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField.Location = new System.Drawing.Point(320, 344);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(261, 48);
            this.passField.TabIndex = 4;
            this.passField.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Laboratory_Number_1.Properties.Resources.lock_icon;
            this.pictureBox2.Location = new System.Drawing.Point(249, 344);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(320, 253);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(261, 64);
            this.loginField.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laboratory_Number_1.Properties.Resources.user_icon;
            this.pictureBox1.Location = new System.Drawing.Point(249, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.SecondaryPanel.ResumeLayout(false);
            this.SecondaryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel SecondaryPanel;
        private System.Windows.Forms.Label MainText;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label HideLogin;
    }
}