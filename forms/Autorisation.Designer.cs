
namespace parolchiki.forms
{
    partial class Autorisation
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.reg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(110, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 176);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(197, 86);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(250, 20);
            this.login.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(127, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(127, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "пароль";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(197, 128);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(250, 20);
            this.password.TabIndex = 4;
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.Black;
            this.enter.ForeColor = System.Drawing.SystemColors.Control;
            this.enter.Location = new System.Drawing.Point(197, 168);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(200, 25);
            this.enter.TabIndex = 5;
            this.enter.Text = "войти";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // reg
            // 
            this.reg.BackColor = System.Drawing.Color.Black;
            this.reg.ForeColor = System.Drawing.SystemColors.Control;
            this.reg.Location = new System.Drawing.Point(197, 207);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(200, 25);
            this.reg.TabIndex = 6;
            this.reg.Text = "зарегистрироваться";
            this.reg.UseVisualStyleBackColor = false;
            this.reg.Click += new System.EventHandler(this.button2_Click);
            // 
            // Autorisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::parolchiki.Properties.Resources.d065a12ca62f5b8052f2ae58a501fe61;
            this.ClientSize = new System.Drawing.Size(581, 326);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pictureBox1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Autorisation";
            this.Text = "Авторизация";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Autorisation_HelpButtonClicked);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button reg;
    }
}