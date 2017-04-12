namespace Login
{
    partial class FrmModifyUser
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnCertain = new System.Windows.Forms.Button();
            this.txtCardID = new System.Windows.Forms.TextBox();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(168, -21);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(199, 21);
            this.txtUser.TabIndex = 44;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(73, -18);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(53, 12);
            this.lblUser.TabIndex = 39;
            this.lblUser.Text = "用户名：";
            // 
            // txtLoginId
            // 
            this.txtLoginId.Location = new System.Drawing.Point(172, 70);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(199, 21);
            this.txtLoginId.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 45;
            this.label1.Text = "用户名：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(77, 181);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 47;
            this.lblName.Text = "性别：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(77, 15);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(77, 12);
            this.lblSex.TabIndex = 48;
            this.lblSex.Text = "身份证号码：";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(77, 248);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 12);
            this.lblAddress.TabIndex = 49;
            this.lblAddress.Text = "电话号码：";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(172, 245);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(199, 21);
            this.txtPhone.TabIndex = 53;
            // 
            // btnCertain
            // 
            this.btnCertain.Location = new System.Drawing.Point(172, 320);
            this.btnCertain.Name = "btnCertain";
            this.btnCertain.Size = new System.Drawing.Size(75, 23);
            this.btnCertain.TabIndex = 54;
            this.btnCertain.Text = "确定";
            this.btnCertain.UseVisualStyleBackColor = true;
            this.btnCertain.Click += new System.EventHandler(this.btnCertain_Click);
            // 
            // txtCardID
            // 
            this.txtCardID.Location = new System.Drawing.Point(172, 12);
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.Size = new System.Drawing.Size(199, 21);
            this.txtCardID.TabIndex = 55;
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Location = new System.Drawing.Point(172, 178);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(199, 20);
            this.cmbSex.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 57;
            this.label2.Text = "真实姓名：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(172, 122);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 21);
            this.txtName.TabIndex = 58;
            // 
            // FrmModifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 414);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.txtCardID);
            this.Controls.Add(this.btnCertain);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLoginId);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUser);
            this.Name = "FrmModifyUser";
            this.Text = "修改用户信息";
            this.Load += new System.EventHandler(this.FrmModifyUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnCertain;
        private System.Windows.Forms.TextBox txtCardID;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
    }
}