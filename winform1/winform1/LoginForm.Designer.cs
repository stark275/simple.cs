namespace winform1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tilte = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.keepSessionCheckBox = new System.Windows.Forms.CheckBox();
            this.sessionInfoLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tilte
            // 
            this.tilte.AutoSize = true;
            this.tilte.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tilte.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tilte.Location = new System.Drawing.Point(99, 32);
            this.tilte.Name = "tilte";
            this.tilte.Padding = new System.Windows.Forms.Padding(10);
            this.tilte.Size = new System.Drawing.Size(254, 57);
            this.tilte.TabIndex = 1;
            this.tilte.Text = "Authetification";
            this.tilte.Click += new System.EventHandler(this.Tilte_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(106, 153);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(282, 47);
            this.usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(106, 232);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(282, 47);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.login_btn.Location = new System.Drawing.Point(106, 331);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(105, 41);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Connexion";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.reset_btn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.reset_btn.Location = new System.Drawing.Point(235, 331);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(105, 41);
            this.reset_btn.TabIndex = 5;
            this.reset_btn.Text = "Annuler";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // keepSessionCheckBox
            // 
            this.keepSessionCheckBox.AutoSize = true;
            this.keepSessionCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.keepSessionCheckBox.Location = new System.Drawing.Point(106, 295);
            this.keepSessionCheckBox.Name = "keepSessionCheckBox";
            this.keepSessionCheckBox.Size = new System.Drawing.Size(113, 17);
            this.keepSessionCheckBox.TabIndex = 6;
            this.keepSessionCheckBox.Text = "Garder ma session";
            this.keepSessionCheckBox.UseVisualStyleBackColor = true;
            this.keepSessionCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // sessionInfoLabel
            // 
            this.sessionInfoLabel.AutoSize = true;
            this.sessionInfoLabel.Location = new System.Drawing.Point(615, 50);
            this.sessionInfoLabel.Name = "sessionInfoLabel";
            this.sessionInfoLabel.Size = new System.Drawing.Size(28, 13);
            this.sessionInfoLabel.TabIndex = 7;
            this.sessionInfoLabel.Text = "       ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(463, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sessionInfoLabel);
            this.Controls.Add(this.keepSessionCheckBox);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.tilte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tilte;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.CheckBox keepSessionCheckBox;
        private System.Windows.Forms.Label sessionInfoLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}