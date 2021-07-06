
namespace parolchiki.forms
{
    partial class Registration
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
            this.registrate = new System.Windows.Forms.Button();
            this.regpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reglog = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.regname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // registrate
            // 
            this.registrate.BackColor = System.Drawing.Color.Black;
            this.registrate.ForeColor = System.Drawing.SystemColors.Control;
            this.registrate.Location = new System.Drawing.Point(194, 205);
            this.registrate.Name = "registrate";
            this.registrate.Size = new System.Drawing.Size(200, 25);
            this.registrate.TabIndex = 13;
            this.registrate.Text = "зарегистрироваться";
            this.registrate.UseVisualStyleBackColor = false;
            this.registrate.Click += new System.EventHandler(this.registrate_Click);
            // 
            // regpass
            // 
            this.regpass.Location = new System.Drawing.Point(194, 161);
            this.regpass.Name = "regpass";
            this.regpass.Size = new System.Drawing.Size(250, 20);
            this.regpass.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(124, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(124, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "логин";
            // 
            // reglog
            // 
            this.reglog.Location = new System.Drawing.Point(194, 119);
            this.reglog.Name = "reglog";
            this.reglog.Size = new System.Drawing.Size(250, 20);
            this.reglog.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(107, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 176);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(124, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "имя";
            // 
            // regname
            // 
            this.regname.Location = new System.Drawing.Point(194, 76);
            this.regname.Name = "regname";
            this.regname.Size = new System.Drawing.Size(250, 20);
            this.regname.TabIndex = 15;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::parolchiki.Properties.Resources.d065a12ca62f5b8052f2ae58a501fe61;
            this.ClientSize = new System.Drawing.Size(581, 326);
            this.Controls.Add(this.regname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registrate);
            this.Controls.Add(this.regpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reglog);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Registration";
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registrate;
        private System.Windows.Forms.TextBox regpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reglog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox regname;
    }
}