namespace FiskalnaBlagajna
{
    partial class UserForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChargeBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.Xbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.UserNameLabel.Location = new System.Drawing.Point(13, 47);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(144, 31);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "UserName";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoScrollMinSize = new System.Drawing.Size(50, 0);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 153);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(275, 512);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(329, 153);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(608, 512);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Quantity,
            this.Price});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(974, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(299, 512);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            // 
            // Name
            // 
            this.Name.HeaderText = "Naziv";
            this.Name.Name = "Name";
            this.Name.Width = 158;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Kolicina";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 70;
            // 
            // Price
            // 
            this.Price.HeaderText = "Cijena";
            this.Price.Name = "Price";
            this.Price.Width = 70;
            // 
            // ChargeBtn
            // 
            this.ChargeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ChargeBtn.Location = new System.Drawing.Point(1026, 685);
            this.ChargeBtn.Name = "ChargeBtn";
            this.ChargeBtn.Size = new System.Drawing.Size(195, 43);
            this.ChargeBtn.TabIndex = 4;
            this.ChargeBtn.Text = "Naplati";
            this.ChargeBtn.UseVisualStyleBackColor = true;
            this.ChargeBtn.Click += new System.EventHandler(this.ChargeBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.ExitBtn.Location = new System.Drawing.Point(502, 47);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(259, 42);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Zaključivanje Prometa";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LogOutBtn.Location = new System.Drawing.Point(974, 47);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(349, 42);
            this.LogOutBtn.TabIndex = 6;
            this.LogOutBtn.Text = "Odjavi se";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // Xbtn
            // 
            this.Xbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Xbtn.Location = new System.Drawing.Point(1279, 354);
            this.Xbtn.Name = "Xbtn";
            this.Xbtn.Size = new System.Drawing.Size(54, 67);
            this.Xbtn.TabIndex = 7;
            this.Xbtn.Text = "X";
            this.Xbtn.UseVisualStyleBackColor = true;
            this.Xbtn.Click += new System.EventHandler(this.Xbtn_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 761);
            this.Controls.Add(this.Xbtn);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ChargeBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.UserNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            
            this.Text = "UserForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ChargeBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button Xbtn;


        public void resetDataGridView()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

    }
}