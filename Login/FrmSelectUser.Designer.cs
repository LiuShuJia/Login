namespace Login
{
    partial class FrmSelectUser
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
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lstShow = new System.Windows.Forms.ListView();
            this.LoginId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserNmae = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDcard = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSex
            // 
            this.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSex.FormattingEnabled = true;
            this.cboSex.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboSex.Items.AddRange(new object[] {
            "男",
            "女",
            "显示所有"});
            this.cboSex.Location = new System.Drawing.Point(101, 82);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(147, 20);
            this.cboSex.TabIndex = 0;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(101, 26);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(147, 21);
            this.txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "性别：";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(291, 79);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lstShow
            // 
            this.lstShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LoginId,
            this.UserNmae,
            this.Sex,
            this.IDcard,
            this.Phone});
            this.lstShow.Location = new System.Drawing.Point(12, 141);
            this.lstShow.Name = "lstShow";
            this.lstShow.Size = new System.Drawing.Size(525, 243);
            this.lstShow.TabIndex = 5;
            this.lstShow.UseCompatibleStateImageBehavior = false;
            this.lstShow.View = System.Windows.Forms.View.Details;
            // 
            // LoginId
            // 
            this.LoginId.Text = "用户名";
            this.LoginId.Width = 95;
            // 
            // UserNmae
            // 
            this.UserNmae.DisplayIndex = 4;
            this.UserNmae.Text = "真实姓名";
            // 
            // Sex
            // 
            this.Sex.DisplayIndex = 1;
            this.Sex.Text = "性别";
            this.Sex.Width = 111;
            // 
            // IDcard
            // 
            this.IDcard.DisplayIndex = 2;
            this.IDcard.Text = "身份证";
            this.IDcard.Width = 124;
            // 
            // Phone
            // 
            this.Phone.DisplayIndex = 3;
            this.Phone.Text = "电话号码";
            this.Phone.Width = 92;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = global::Login.Properties.Resources._28b893b04595ce186701ed4f64d2ed2b;
            this.pictureBox1.Location = new System.Drawing.Point(12, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(424, 80);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "退出";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmSelectUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 396);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstShow);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.cboSex);
            this.Name = "FrmSelectUser";
            this.Text = "查询用户信息";
            this.Load += new System.EventHandler(this.FrmSelectUser_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ListView lstShow;
        private System.Windows.Forms.ColumnHeader LoginId;
        private System.Windows.Forms.ColumnHeader Sex;
        private System.Windows.Forms.ColumnHeader IDcard;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader UserNmae;
        private System.Windows.Forms.Button btnClose;
    }
}