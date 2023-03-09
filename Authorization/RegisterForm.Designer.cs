namespace Authorization
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.RegPanel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.RegLabel = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.PictureBox();
            this.userSurnameField = new System.Windows.Forms.TextBox();
            this.key = new System.Windows.Forms.PictureBox();
            this.PassField = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.auth = new System.Windows.Forms.Label();
            this.RegPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key)).BeginInit();
            this.SuspendLayout();
            // 
            // RegPanel2
            // 
            this.RegPanel2.BackColor = System.Drawing.Color.PeachPuff;
            this.RegPanel2.Controls.Add(this.panel1);
            this.RegPanel2.Controls.Add(this.RegLabel);
            this.RegPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegPanel2.Location = new System.Drawing.Point(0, 0);
            this.RegPanel2.Name = "RegPanel2";
            this.RegPanel2.Size = new System.Drawing.Size(711, 77);
            this.RegPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 23);
            this.panel1.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(671, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(38, 23);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // RegLabel
            // 
            this.RegLabel.AutoSize = true;
            this.RegLabel.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.RegLabel.Location = new System.Drawing.Point(248, 31);
            this.RegLabel.Name = "RegLabel";
            this.RegLabel.Size = new System.Drawing.Size(209, 36);
            this.RegLabel.TabIndex = 0;
            this.RegLabel.Text = "Регистрация";
            this.RegLabel.Click += new System.EventHandler(this.LogLabel_Click);
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.Image = ((System.Drawing.Image)(resources.GetObject("user.Image")));
            this.user.Location = new System.Drawing.Point(40, 111);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(73, 75);
            this.user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user.TabIndex = 2;
            this.user.TabStop = false;
            // 
            // userSurnameField
            // 
            this.userSurnameField.BackColor = System.Drawing.Color.White;
            this.userSurnameField.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userSurnameField.ForeColor = System.Drawing.Color.Black;
            this.userSurnameField.Location = new System.Drawing.Point(119, 150);
            this.userSurnameField.Name = "userSurnameField";
            this.userSurnameField.Size = new System.Drawing.Size(211, 33);
            this.userSurnameField.TabIndex = 3;
            this.userSurnameField.Enter += new System.EventHandler(this.userSurnameField_Enter);
            this.userSurnameField.Leave += new System.EventHandler(this.userSurnameField_Leave);
            // 
            // key
            // 
            this.key.BackColor = System.Drawing.Color.Transparent;
            this.key.Image = ((System.Drawing.Image)(resources.GetObject("key.Image")));
            this.key.Location = new System.Drawing.Point(382, 111);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(73, 75);
            this.key.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.key.TabIndex = 5;
            this.key.TabStop = false;
            // 
            // PassField
            // 
            this.PassField.BackColor = System.Drawing.Color.White;
            this.PassField.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.ForeColor = System.Drawing.Color.Black;
            this.PassField.Location = new System.Drawing.Point(461, 150);
            this.PassField.Name = "PassField";
            this.PassField.Size = new System.Drawing.Size(211, 33);
            this.PassField.TabIndex = 6;
            this.PassField.Enter += new System.EventHandler(this.PassField_Enter);
            this.PassField.Leave += new System.EventHandler(this.PassField_Leave);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Maroon;
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegister.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(243, 228);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(235, 40);
            this.buttonRegister.TabIndex = 7;
            this.buttonRegister.Text = "Зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // userNameField
            // 
            this.userNameField.BackColor = System.Drawing.Color.White;
            this.userNameField.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameField.ForeColor = System.Drawing.Color.Black;
            this.userNameField.Location = new System.Drawing.Point(119, 111);
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(211, 33);
            this.userNameField.TabIndex = 8;
            this.userNameField.Enter += new System.EventHandler(this.userNameField_Enter);
            this.userNameField.Leave += new System.EventHandler(this.userNameField_Leave);
            // 
            // loginField
            // 
            this.loginField.BackColor = System.Drawing.Color.White;
            this.loginField.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.ForeColor = System.Drawing.Color.Black;
            this.loginField.Location = new System.Drawing.Point(461, 111);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(211, 33);
            this.loginField.TabIndex = 9;
            this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
            this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
            // 
            // auth
            // 
            this.auth.AutoSize = true;
            this.auth.BackColor = System.Drawing.Color.Transparent;
            this.auth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.auth.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.auth.Location = new System.Drawing.Point(243, 276);
            this.auth.Name = "auth";
            this.auth.Size = new System.Drawing.Size(234, 25);
            this.auth.TabIndex = 10;
            this.auth.Text = "Уже есть аккаунт? Войти";
            this.auth.Click += new System.EventHandler(this.auth_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(711, 322);
            this.Controls.Add(this.auth);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.userNameField);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.PassField);
            this.Controls.Add(this.key);
            this.Controls.Add(this.userSurnameField);
            this.Controls.Add(this.user);
            this.Controls.Add(this.RegPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            this.RegPanel2.ResumeLayout(false);
            this.RegPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel RegPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label RegLabel;
        private System.Windows.Forms.PictureBox user;
        private System.Windows.Forms.TextBox userSurnameField;
        private System.Windows.Forms.PictureBox key;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Label auth;
    }
}