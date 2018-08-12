namespace CRUDDemo
{
    partial class FrmReg
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
            this.chePwd = new System.Windows.Forms.CheckBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.inputPwd = new System.Windows.Forms.TextBox();
            this.labPwd = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.btnToLogin = new System.Windows.Forms.Button();
            this.inputRealName = new System.Windows.Forms.TextBox();
            this.labRealName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chePwd
            // 
            this.chePwd.AutoSize = true;
            this.chePwd.Location = new System.Drawing.Point(347, 255);
            this.chePwd.Name = "chePwd";
            this.chePwd.Size = new System.Drawing.Size(89, 19);
            this.chePwd.TabIndex = 13;
            this.chePwd.Text = "显示密码";
            this.chePwd.UseVisualStyleBackColor = true;
            this.chePwd.Click += new System.EventHandler(this.ShowPwdOrNot);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(164, 298);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(88, 36);
            this.btnReg.TabIndex = 14;
            this.btnReg.Text = "注册";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.UserReg);
            // 
            // inputPwd
            // 
            this.inputPwd.Location = new System.Drawing.Point(234, 210);
            this.inputPwd.Name = "inputPwd";
            this.inputPwd.PasswordChar = '*';
            this.inputPwd.Size = new System.Drawing.Size(201, 25);
            this.inputPwd.TabIndex = 12;
            // 
            // labPwd
            // 
            this.labPwd.AutoSize = true;
            this.labPwd.Location = new System.Drawing.Point(161, 213);
            this.labPwd.Name = "labPwd";
            this.labPwd.Size = new System.Drawing.Size(52, 15);
            this.labPwd.TabIndex = 11;
            this.labPwd.Text = "密码：";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(234, 91);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(201, 25);
            this.inputName.TabIndex = 8;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(161, 94);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(67, 15);
            this.labName.TabIndex = 7;
            this.labName.Text = "用户名：";
            // 
            // btnToLogin
            // 
            this.btnToLogin.Location = new System.Drawing.Point(315, 298);
            this.btnToLogin.Name = "btnToLogin";
            this.btnToLogin.Size = new System.Drawing.Size(120, 36);
            this.btnToLogin.TabIndex = 15;
            this.btnToLogin.Text = "返回登录页面";
            this.btnToLogin.UseVisualStyleBackColor = true;
            this.btnToLogin.Click += new System.EventHandler(this.BackToLogin);
            // 
            // inputRealName
            // 
            this.inputRealName.Location = new System.Drawing.Point(234, 151);
            this.inputRealName.Name = "inputRealName";
            this.inputRealName.Size = new System.Drawing.Size(201, 25);
            this.inputRealName.TabIndex = 10;
            // 
            // labRealName
            // 
            this.labRealName.AutoSize = true;
            this.labRealName.Location = new System.Drawing.Point(161, 154);
            this.labRealName.Name = "labRealName";
            this.labRealName.Size = new System.Drawing.Size(82, 15);
            this.labRealName.TabIndex = 9;
            this.labRealName.Text = "真实姓名：";
            // 
            // FrmReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 412);
            this.Controls.Add(this.inputRealName);
            this.Controls.Add(this.labRealName);
            this.Controls.Add(this.chePwd);
            this.Controls.Add(this.btnToLogin);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.inputPwd);
            this.Controls.Add(this.labPwd);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.labName);
            this.Name = "FrmReg";
            this.Text = "FrmReg";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegClose);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chePwd;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox inputPwd;
        private System.Windows.Forms.Label labPwd;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnToLogin;
        private System.Windows.Forms.TextBox inputRealName;
        private System.Windows.Forms.Label labRealName;
    }
}