namespace FiskalnaBlagajna
{
    partial class AdminForm
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
            this.AdminName = new System.Windows.Forms.Label();
            this.AddItemBtn = new System.Windows.Forms.Button();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.AddSectionBtn = new System.Windows.Forms.Button();
            this.ItemBtn = new System.Windows.Forms.Button();
            this.SectionBtn = new System.Windows.Forms.Button();
            this.UserBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminName
            // 
            this.AdminName.AutoSize = true;
            this.AdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.AdminName.Location = new System.Drawing.Point(27, 30);
            this.AdminName.Name = "AdminName";
            this.AdminName.Size = new System.Drawing.Size(162, 31);
            this.AdminName.TabIndex = 0;
            this.AdminName.Text = "AdminName";
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.AddItemBtn.Location = new System.Drawing.Point(33, 115);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(297, 44);
            this.AddItemBtn.TabIndex = 1;
            this.AddItemBtn.Text = "Dodaj Artikl";
            this.AddItemBtn.UseVisualStyleBackColor = true;
            this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.AddUserBtn.Location = new System.Drawing.Point(33, 165);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(297, 44);
            this.AddUserBtn.TabIndex = 2;
            this.AddUserBtn.Text = "Dodaj Korisnika";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Exitbtn.Location = new System.Drawing.Point(33, 688);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(297, 44);
            this.Exitbtn.TabIndex = 3;
            this.Exitbtn.Text = "Izlaz";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.LogOutBtn.Location = new System.Drawing.Point(33, 638);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(297, 44);
            this.LogOutBtn.TabIndex = 4;
            this.LogOutBtn.Text = "Odjavite se";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // AddSectionBtn
            // 
            this.AddSectionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.AddSectionBtn.Location = new System.Drawing.Point(33, 215);
            this.AddSectionBtn.Name = "AddSectionBtn";
            this.AddSectionBtn.Size = new System.Drawing.Size(297, 44);
            this.AddSectionBtn.TabIndex = 5;
            this.AddSectionBtn.Text = "Dodaj Odjeljak";
            this.AddSectionBtn.UseVisualStyleBackColor = true;
            this.AddSectionBtn.Click += new System.EventHandler(this.AddSectionBtn_Click);
            // 
            // ItemBtn
            // 
            this.ItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ItemBtn.Location = new System.Drawing.Point(33, 359);
            this.ItemBtn.Name = "ItemBtn";
            this.ItemBtn.Size = new System.Drawing.Size(297, 44);
            this.ItemBtn.TabIndex = 6;
            this.ItemBtn.Text = "Artikli";
            this.ItemBtn.UseVisualStyleBackColor = true;
            this.ItemBtn.Click += new System.EventHandler(this.ItemBtn_Click);
            // 
            // SectionBtn
            // 
            this.SectionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.SectionBtn.Location = new System.Drawing.Point(33, 409);
            this.SectionBtn.Name = "SectionBtn";
            this.SectionBtn.Size = new System.Drawing.Size(297, 44);
            this.SectionBtn.TabIndex = 7;
            this.SectionBtn.Text = "Odjeljci";
            this.SectionBtn.UseVisualStyleBackColor = true;
            this.SectionBtn.Click += new System.EventHandler(this.ItemBtn_Click);
            // 
            // UserBtn
            // 
            this.UserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.UserBtn.Location = new System.Drawing.Point(33, 459);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.Size = new System.Drawing.Size(297, 44);
            this.UserBtn.TabIndex = 8;
            this.UserBtn.Text = "Korisnici";
            this.UserBtn.UseVisualStyleBackColor = true;
            this.UserBtn.Click += new System.EventHandler(this.ItemBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 744);
            this.Controls.Add(this.UserBtn);
            this.Controls.Add(this.SectionBtn);
            this.Controls.Add(this.ItemBtn);
            this.Controls.Add(this.AddSectionBtn);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.AddUserBtn);
            this.Controls.Add(this.AddItemBtn);
            this.Controls.Add(this.AdminName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdminName;
        private System.Windows.Forms.Button AddItemBtn;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button AddSectionBtn;
        private System.Windows.Forms.Button ItemBtn;
        private System.Windows.Forms.Button SectionBtn;
        private System.Windows.Forms.Button UserBtn;
    }
}