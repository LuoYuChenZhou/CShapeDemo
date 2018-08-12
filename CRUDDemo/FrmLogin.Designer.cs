namespace CRUDDemo
{
    partial class FrmLogin
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
            this.labName = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputPwd = new System.Windows.Forms.TextBox();
            this.labPwd = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnToReg = new System.Windows.Forms.Button();
            this.chePwd = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(143, 60);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(67, 15);
            this.labName.TabIndex = 0;
            this.labName.Text = "用户名：";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(216, 57);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(201, 25);
            this.inputName.TabIndex = 1;
            // 
            // inputPwd
            // 
            this.inputPwd.Location = new System.Drawing.Point(216, 125);
            this.inputPwd.Name = "inputPwd";
            this.inputPwd.PasswordChar = '*';
            this.inputPwd.Size = new System.Drawing.Size(201, 25);
            this.inputPwd.TabIndex = 3;
            // 
            // labPwd
            // 
            this.labPwd.AutoSize = true;
            this.labPwd.Location = new System.Drawing.Point(143, 128);
            this.labPwd.Name = "labPwd";
            this.labPwd.Size = new System.Drawing.Size(52, 15);
            this.labPwd.TabIndex = 2;
            this.labPwd.Text = "密码：";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(146, 213);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(88, 36);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.LoginCheck);
            // 
            // btnToReg
            // 
            this.btnToReg.Location = new System.Drawing.Point(329, 213);
            this.btnToReg.Name = "btnToReg";
            this.btnToReg.Size = new System.Drawing.Size(88, 36);
            this.btnToReg.TabIndex = 5;
            this.btnToReg.Text = "注册";
            this.btnToReg.UseVisualStyleBackColor = true;
            this.btnToReg.Click += new System.EventHandler(this.ToReg);
            // 
            // chePwd
            // 
            this.chePwd.AutoSize = true;
            this.chePwd.Location = new System.Drawing.Point(329, 170);
            this.chePwd.Name = "chePwd";
            this.chePwd.Size = new System.Drawing.Size(89, 19);
            this.chePwd.TabIndex = 6;
            this.chePwd.Text = "显示密码";
            this.chePwd.UseVisualStyleBackColor = true;
            this.chePwd.Click += new System.EventHandler(this.ShowPwdOrNot);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 354);
            this.Controls.Add(this.chePwd);
            this.Controls.Add(this.btnToReg);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.inputPwd);
            this.Controls.Add(this.labPwd);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.labName);
            this.Name = "FrmLogin";
            this.Text = "欢迎登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputPwd;
        private System.Windows.Forms.Label labPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnToReg;
        private System.Windows.Forms.CheckBox chePwd;
    }
}

