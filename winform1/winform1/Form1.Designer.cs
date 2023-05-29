namespace winform1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tilte = new System.Windows.Forms.Label();
            this.test_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loggedUsername = new System.Windows.Forms.Label();
            this.randomInt = new System.Windows.Forms.Label();
            this.myInputTextBox = new System.Windows.Forms.TextBox();
            this.retryMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tilte
            // 
            this.tilte.AutoSize = true;
            this.tilte.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tilte.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tilte.Location = new System.Drawing.Point(90, 9);
            this.tilte.Name = "tilte";
            this.tilte.Padding = new System.Windows.Forms.Padding(10);
            this.tilte.Size = new System.Drawing.Size(140, 57);
            this.tilte.TabIndex = 0;
            this.tilte.Text = "Devine";
            this.tilte.Click += new System.EventHandler(this.Label1_Click);
            // 
            // test_btn
            // 
            this.test_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.test_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.test_btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.test_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.test_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test_btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.test_btn.Location = new System.Drawing.Point(298, 257);
            this.test_btn.Name = "test_btn";
            this.test_btn.Size = new System.Drawing.Size(105, 41);
            this.test_btn.TabIndex = 1;
            this.test_btn.Text = "Tenter";
            this.test_btn.UseVisualStyleBackColor = false;
            this.test_btn.Click += new System.EventHandler(this.Test_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(420, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(490, 30);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Utilisateur:";
            // 
            // loggedUsername
            // 
            this.loggedUsername.AutoSize = true;
            this.loggedUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedUsername.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.loggedUsername.Location = new System.Drawing.Point(582, 30);
            this.loggedUsername.Name = "loggedUsername";
            this.loggedUsername.Padding = new System.Windows.Forms.Padding(1);
            this.loggedUsername.Size = new System.Drawing.Size(83, 22);
            this.loggedUsername.TabIndex = 4;
            this.loggedUsername.Text = "________";
            // 
            // randomInt
            // 
            this.randomInt.AutoSize = true;
            this.randomInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomInt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.randomInt.Location = new System.Drawing.Point(558, 356);
            this.randomInt.Name = "randomInt";
            this.randomInt.Padding = new System.Windows.Forms.Padding(10);
            this.randomInt.Size = new System.Drawing.Size(107, 57);
            this.randomInt.TabIndex = 5;
            this.randomInt.Text = ".......";
            // 
            // myInputTextBox
            // 
            this.myInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myInputTextBox.Location = new System.Drawing.Point(272, 167);
            this.myInputTextBox.Name = "myInputTextBox";
            this.myInputTextBox.Size = new System.Drawing.Size(282, 47);
            this.myInputTextBox.TabIndex = 6;
            this.myInputTextBox.TextChanged += new System.EventHandler(this.MyInputTextBox_TextChanged);
            // 
            // retryMessage
            // 
            this.retryMessage.AutoSize = true;
            this.retryMessage.ForeColor = System.Drawing.Color.Red;
            this.retryMessage.Location = new System.Drawing.Point(369, 141);
            this.retryMessage.Name = "retryMessage";
            this.retryMessage.Size = new System.Drawing.Size(16, 13);
            this.retryMessage.TabIndex = 7;
            this.retryMessage.Text = "   ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(757, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.retryMessage);
            this.Controls.Add(this.myInputTextBox);
            this.Controls.Add(this.randomInt);
            this.Controls.Add(this.loggedUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.test_btn);
            this.Controls.Add(this.tilte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tilte;
        private System.Windows.Forms.Button test_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loggedUsername;
        private System.Windows.Forms.Label randomInt;
        private System.Windows.Forms.TextBox myInputTextBox;
        private System.Windows.Forms.Label retryMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

