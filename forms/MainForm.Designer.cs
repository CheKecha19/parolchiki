
namespace parolchiki.forms
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выполнитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаПодключенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаПодключенияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьНовыйАккаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВСЕАккаунтыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Site = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Others = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::parolchiki.Properties.Resources.d065a12ca62f5b8052f2ae58a501fe61;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выполнитьToolStripMenuItem,
            this.fAQToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выполнитьToolStripMenuItem
            // 
            this.выполнитьToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.выполнитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проверкаПодключенияToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.выполнитьToolStripMenuItem.Name = "выполнитьToolStripMenuItem";
            this.выполнитьToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выполнитьToolStripMenuItem.Text = "Меню";
            // 
            // проверкаПодключенияToolStripMenuItem
            // 
            this.проверкаПодключенияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проверкаПодключенияToolStripMenuItem1,
            this.добавитьНовыйАккаунтToolStripMenuItem,
            this.удалитьВСЕАккаунтыToolStripMenuItem});
            this.проверкаПодключенияToolStripMenuItem.Name = "проверкаПодключенияToolStripMenuItem";
            this.проверкаПодключенияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.проверкаПодключенияToolStripMenuItem.Text = "Действия с БД";
            // 
            // проверкаПодключенияToolStripMenuItem1
            // 
            this.проверкаПодключенияToolStripMenuItem1.Name = "проверкаПодключенияToolStripMenuItem1";
            this.проверкаПодключенияToolStripMenuItem1.Size = new System.Drawing.Size(239, 22);
            this.проверкаПодключенияToolStripMenuItem1.Text = "Обновить/переподключиться";
            this.проверкаПодключенияToolStripMenuItem1.Click += new System.EventHandler(this.проверкаПодключенияToolStripMenuItem1_Click);
            // 
            // добавитьНовыйАккаунтToolStripMenuItem
            // 
            this.добавитьНовыйАккаунтToolStripMenuItem.Name = "добавитьНовыйАккаунтToolStripMenuItem";
            this.добавитьНовыйАккаунтToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.добавитьНовыйАккаунтToolStripMenuItem.Text = "Добавить новый аккаунт";
            this.добавитьНовыйАккаунтToolStripMenuItem.Click += new System.EventHandler(this.добавитьНовыйАккаунтToolStripMenuItem_Click);
            // 
            // удалитьВСЕАккаунтыToolStripMenuItem
            // 
            this.удалитьВСЕАккаунтыToolStripMenuItem.Name = "удалитьВСЕАккаунтыToolStripMenuItem";
            this.удалитьВСЕАккаунтыToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.удалитьВСЕАккаунтыToolStripMenuItem.Text = "Удалить ВСЕ аккаунты";
            this.удалитьВСЕАккаунтыToolStripMenuItem.Click += new System.EventHandler(this.удалитьВСЕАккаунтыToolStripMenuItem_Click);
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fAQToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wikiToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.fAQToolStripMenuItem.Text = "FAQ";
            // 
            // wikiToolStripMenuItem
            // 
            this.wikiToolStripMenuItem.Name = "wikiToolStripMenuItem";
            this.wikiToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.wikiToolStripMenuItem.Text = "Wiki";
            this.wikiToolStripMenuItem.Click += new System.EventHandler(this.wikiToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.aboutToolStripMenuItem.Text = "about";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Login,
            this.Password,
            this.Site,
            this.Phone,
            this.EMail,
            this.Others});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 426);
            this.dataGridView1.TabIndex = 2;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 46;
            // 
            // Login
            // 
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.Width = 58;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.Width = 78;
            // 
            // Site
            // 
            this.Site.HeaderText = "Site";
            this.Site.Name = "Site";
            this.Site.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Site.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Site.Width = 50;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.Width = 63;
            // 
            // EMail
            // 
            this.EMail.HeaderText = "EMail";
            this.EMail.Name = "EMail";
            this.EMail.Width = 58;
            // 
            // Others
            // 
            this.Others.HeaderText = "Others";
            this.Others.Name = "Others";
            this.Others.Width = 63;
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выполнитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаПодключенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаПодключенияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьНовыйАккаунтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВСЕАккаунтыToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewLinkColumn Site;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Others;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}