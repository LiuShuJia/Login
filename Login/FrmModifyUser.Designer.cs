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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblClassGuid = new System.Windows.Forms.Label();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.btnCertain = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.txtCardId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(161, 160);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 21);
            this.txtName.TabIndex = 53;
            // 
            // lblClassGuid
            // 
            this.lblClassGuid.AutoSize = true;
            this.lblClassGuid.Location = new System.Drawing.Point(78, 163);
            this.lblClassGuid.Name = "lblClassGuid";
            this.lblClassGuid.Size = new System.Drawing.Size(41, 12);
            this.lblClassGuid.TabIndex = 52;
            this.lblClassGuid.Text = "姓名：";
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Location = new System.Drawing.Point(78, 244);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(41, 12);
            this.lblStudentNo.TabIndex = 50;
            this.lblStudentNo.Text = "性别：";
            // 
            // btnCertain
            // 
            this.btnCertain.Location = new System.Drawing.Point(161, 397);
            this.btnCertain.Name = "btnCertain";
            this.btnCertain.Size = new System.Drawing.Size(75, 23);
            this.btnCertain.TabIndex = 48;
            this.btnCertain.Text = "确定";
            this.btnCertain.UseVisualStyleBackColor = true;
            this.btnCertain.Click += new System.EventHandler(this.btnCertain_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(161, 311);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(199, 21);
            this.txtPhone.TabIndex = 46;
            // 
            // txtLoginId
            // 
            this.txtLoginId.Location = new System.Drawing.Point(161, 88);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(199, 21);
            this.txtLoginId.TabIndex = 45;
            // 
            // txtCardId
            // 
            this.txtCardId.Location = new System.Drawing.Point(161, 25);
            this.txtCardId.Name = "txtCardId";
            this.txtCardId.Size = new System.Drawing.Size(199, 21);
            this.txtCardId.TabIndex = 44;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(78, 314);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 41;
            this.lblName.Text = "电话：";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(78, 91);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 12);
            this.lblPassword.TabIndex = 40;
            this.lblPassword.Text = "用户名：";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(78, 28);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(77, 12);
            this.lblUser.TabIndex = 39;
            this.lblUser.Text = "身份证号码：";
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Location = new System.Drawing.Point(161, 241);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(199, 20);
            this.cmbSex.TabIndex = 54;
            // 
            // FrmModifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 470);
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblClassGuid);
            this.Controls.Add(this.lblStudentNo);
            this.Controls.Add(this.btnCertain);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLoginId);
            this.Controls.Add(this.txtCardId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Name = "FrmModifyUser";
            this.Text = "修改用户信息";
            this.Load += new System.EventHandler(this.FrmModifyUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblClassGuid;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.Button btnCertain;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.TextBox txtCardId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox cmbSex;
    }
}