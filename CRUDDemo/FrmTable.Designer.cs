namespace CRUDDemo
{
    partial class FrmTable
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
            this.tabUser = new System.Windows.Forms.ListView();
            this.index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.realName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.regTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inputSearchName = new System.Windows.Forms.TextBox();
            this.labSearchName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLeftPage = new System.Windows.Forms.Button();
            this.labShowPageInfo = new System.Windows.Forms.Label();
            this.btnRightPage = new System.Windows.Forms.Button();
            this.comboPageSize = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabUser
            // 
            this.tabUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.index,
            this.realName,
            this.userName,
            this.password,
            this.regTime});
            this.tabUser.FullRowSelect = true;
            this.tabUser.Location = new System.Drawing.Point(98, 73);
            this.tabUser.Name = "tabUser";
            this.tabUser.Size = new System.Drawing.Size(551, 245);
            this.tabUser.TabIndex = 0;
            this.tabUser.UseCompatibleStateImageBehavior = false;
            this.tabUser.View = System.Windows.Forms.View.Details;
            // 
            // index
            // 
            this.index.Text = "序号";
            // 
            // realName
            // 
            this.realName.Text = "姓名";
            this.realName.Width = 80;
            // 
            // userName
            // 
            this.userName.Text = "用户名";
            this.userName.Width = 84;
            // 
            // password
            // 
            this.password.Text = "密码";
            this.password.Width = 74;
            // 
            // regTime
            // 
            this.regTime.Text = "注册时间";
            this.regTime.Width = 154;
            // 
            // inputSearchName
            // 
            this.inputSearchName.Location = new System.Drawing.Point(175, 36);
            this.inputSearchName.Name = "inputSearchName";
            this.inputSearchName.Size = new System.Drawing.Size(213, 25);
            this.inputSearchName.TabIndex = 1;
            // 
            // labSearchName
            // 
            this.labSearchName.AutoSize = true;
            this.labSearchName.Location = new System.Drawing.Point(104, 39);
            this.labSearchName.Name = "labSearchName";
            this.labSearchName.Size = new System.Drawing.Size(52, 15);
            this.labSearchName.TabIndex = 2;
            this.labSearchName.Text = "姓名：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GetUserListByName);
            // 
            // btnLeftPage
            // 
            this.btnLeftPage.Location = new System.Drawing.Point(592, 333);
            this.btnLeftPage.Name = "btnLeftPage";
            this.btnLeftPage.Size = new System.Drawing.Size(26, 23);
            this.btnLeftPage.TabIndex = 4;
            this.btnLeftPage.Text = "<";
            this.btnLeftPage.UseVisualStyleBackColor = true;
            this.btnLeftPage.Click += new System.EventHandler(this.ToLeftPage);
            // 
            // labShowPageInfo
            // 
            this.labShowPageInfo.AutoSize = true;
            this.labShowPageInfo.Location = new System.Drawing.Point(95, 334);
            this.labShowPageInfo.Name = "labShowPageInfo";
            this.labShowPageInfo.Size = new System.Drawing.Size(97, 15);
            this.labShowPageInfo.TabIndex = 5;
            this.labShowPageInfo.Text = "暂无分页信息";
            // 
            // btnRightPage
            // 
            this.btnRightPage.Location = new System.Drawing.Point(624, 333);
            this.btnRightPage.Name = "btnRightPage";
            this.btnRightPage.Size = new System.Drawing.Size(26, 23);
            this.btnRightPage.TabIndex = 6;
            this.btnRightPage.Text = ">";
            this.btnRightPage.UseVisualStyleBackColor = true;
            this.btnRightPage.Click += new System.EventHandler(this.ToRightPage);
            // 
            // comboPageSize
            // 
            this.comboPageSize.FormattingEnabled = true;
            this.comboPageSize.Items.AddRange(new object[] {
            " 5 条/页",
            "10条/页",
            "20条/页"});
            this.comboPageSize.Location = new System.Drawing.Point(450, 334);
            this.comboPageSize.Name = "comboPageSize";
            this.comboPageSize.Size = new System.Drawing.Size(121, 23);
            this.comboPageSize.TabIndex = 7;
            this.comboPageSize.SelectedIndexChanged += new System.EventHandler(this.PageSizeChange);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(574, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 8;
            this.button2.Text = "注销";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ToLogin);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(493, 36);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(75, 25);
            this.btnUpdateUser.TabIndex = 9;
            this.btnUpdateUser.Text = "修改";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.ToUpdate);
            // 
            // FrmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 404);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboPageSize);
            this.Controls.Add(this.btnRightPage);
            this.Controls.Add(this.labShowPageInfo);
            this.Controls.Add(this.btnLeftPage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labSearchName);
            this.Controls.Add(this.inputSearchName);
            this.Controls.Add(this.tabUser);
            this.Name = "FrmTable";
            this.Text = "FrmTable";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClose);
            this.Load += new System.EventHandler(this.TableInit);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView tabUser;
        private System.Windows.Forms.TextBox inputSearchName;
        private System.Windows.Forms.Label labSearchName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLeftPage;
        private System.Windows.Forms.Label labShowPageInfo;
        private System.Windows.Forms.Button btnRightPage;
        private System.Windows.Forms.ComboBox comboPageSize;
        private System.Windows.Forms.ColumnHeader realName;
        private System.Windows.Forms.ColumnHeader userName;
        private System.Windows.Forms.ColumnHeader password;
        private System.Windows.Forms.ColumnHeader regTime;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader index;
        private System.Windows.Forms.Button btnUpdateUser;
    }
}