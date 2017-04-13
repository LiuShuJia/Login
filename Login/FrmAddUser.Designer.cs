namespace Login
{
    partial class FrmAddUser
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIDcard = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.errortext = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbosex = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbowid = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errortext)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "性别：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "身份证：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "联系电话：";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(122, 22);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(90, 21);
            this.txtUserName.TabIndex = 6;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(122, 81);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(90, 21);
            this.txtpassword.TabIndex = 7;
            this.txtpassword.Enter += new System.EventHandler(this.txtpassword_Enter);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 111);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(90, 21);
            this.txtName.TabIndex = 8;
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            // 
            // txtIDcard
            // 
            this.txtIDcard.Location = new System.Drawing.Point(122, 184);
            this.txtIDcard.Name = "txtIDcard";
            this.txtIDcard.Size = new System.Drawing.Size(90, 21);
            this.txtIDcard.TabIndex = 10;
            this.txtIDcard.Enter += new System.EventHandler(this.txtIDcard_Enter);
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(122, 223);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(90, 21);
            this.txtphone.TabIndex = 11;
            this.txtphone.Enter += new System.EventHandler(this.txtphone_Enter);
            this.txtphone.Leave += new System.EventHandler(this.txtphone_Leave);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(29, 276);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 12;
            this.btnEnter.Text = "添加";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // errortext
            // 
            this.errortext.ContainerControl = this;
            // 
            // cbosex
            // 
            this.cbosex.FormattingEnabled = true;
            this.cbosex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbosex.Location = new System.Drawing.Point(122, 146);
            this.cbosex.Name = "cbosex";
            this.cbosex.Size = new System.Drawing.Size(90, 20);
            this.cbosex.TabIndex = 13;
            this.cbosex.Enter += new System.EventHandler(this.cbosex_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "仓库编号：";
            // 
            // cbowid
            // 
            this.cbowid.FormattingEnabled = true;
            this.cbowid.Location = new System.Drawing.Point(122, 50);
            this.cbowid.Name = "cbowid";
            this.cbowid.Size = new System.Drawing.Size(90, 20);
            this.cbowid.TabIndex = 15;
            this.cbowid.Enter += new System.EventHandler(this.cbowid_Enter);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(137, 276);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // FrmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 325);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbowid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbosex);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtIDcard);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddUser";
            this.Text = "添加用户";
            this.Load += new System.EventHandler(this.FrmAddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errortext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIDcard;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ErrorProvider errortext;
        private System.Windows.Forms.ComboBox cbosex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbowid;
        private System.Windows.Forms.Button btnExit;
    }
}