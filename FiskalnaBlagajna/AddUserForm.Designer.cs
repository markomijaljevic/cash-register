namespace FiskalnaBlagajna
{
    partial class AddUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.adminRadioBtn = new System.Windows.Forms.RadioButton();
            this.UserRadioBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID ( Sifra )";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label3.Location = new System.Drawing.Point(12, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Uloga";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.IdTextBox.Location = new System.Drawing.Point(143, 63);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(196, 31);
            this.IdTextBox.TabIndex = 3;
            this.IdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.NameTextBox.Location = new System.Drawing.Point(143, 138);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(196, 31);
            this.NameTextBox.TabIndex = 4;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OkBtn
            // 
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.OkBtn.Location = new System.Drawing.Point(17, 306);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(136, 40);
            this.OkBtn.TabIndex = 6;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.CancelBtn.Location = new System.Drawing.Point(203, 306);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(136, 40);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // adminRadioBtn
            // 
            this.adminRadioBtn.AutoSize = true;
            this.adminRadioBtn.BackColor = System.Drawing.SystemColors.Control;
            this.adminRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.adminRadioBtn.Location = new System.Drawing.Point(143, 219);
            this.adminRadioBtn.Name = "adminRadioBtn";
            this.adminRadioBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adminRadioBtn.Size = new System.Drawing.Size(83, 28);
            this.adminRadioBtn.TabIndex = 8;
            this.adminRadioBtn.TabStop = true;
            this.adminRadioBtn.Text = "Admin";
            this.adminRadioBtn.UseVisualStyleBackColor = false;
            // 
            // UserRadioBtn
            // 
            this.UserRadioBtn.AutoSize = true;
            this.UserRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.UserRadioBtn.Location = new System.Drawing.Point(234, 219);
            this.UserRadioBtn.Name = "UserRadioBtn";
            this.UserRadioBtn.Size = new System.Drawing.Size(67, 28);
            this.UserRadioBtn.TabIndex = 9;
            this.UserRadioBtn.TabStop = true;
            this.UserRadioBtn.Text = "User";
            this.UserRadioBtn.UseVisualStyleBackColor = true;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(353, 377);
            this.Controls.Add(this.UserRadioBtn);
            this.Controls.Add(this.adminRadioBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(700, 140);
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;


        public void setIdTextBox(int id)
        {
            this.IdTextBox.Text = id.ToString();
        }

        public string getNameTextBox()
        {
            return NameTextBox.Text.Trim();
        }

        public void setUserNames(string str)
        {
            NameTextBox.Text = str.Trim();
        }

        private System.Windows.Forms.RadioButton adminRadioBtn;
        private System.Windows.Forms.RadioButton UserRadioBtn;
    }
}