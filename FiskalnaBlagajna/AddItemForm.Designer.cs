namespace FiskalnaBlagajna
{
    partial class AddItemForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.ItemName = new System.Windows.Forms.TextBox();
            this.ItemPrice = new System.Windows.Forms.TextBox();
            this.ItemQuantity = new System.Windows.Forms.TextBox();
            this.ItemTax = new System.Windows.Forms.TextBox();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SectionComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(25, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(25, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cijena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label3.Location = new System.Drawing.Point(25, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kolicina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label4.Location = new System.Drawing.Point(25, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "PDV (%)";
            // 
            // ItemName
            // 
            this.ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.ItemName.Location = new System.Drawing.Point(160, 46);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(289, 38);
            this.ItemName.TabIndex = 4;
            this.ItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ItemPrice
            // 
            this.ItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.ItemPrice.Location = new System.Drawing.Point(160, 124);
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.Size = new System.Drawing.Size(289, 38);
            this.ItemPrice.TabIndex = 5;
            this.ItemPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.ItemQuantity.Location = new System.Drawing.Point(160, 203);
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.Size = new System.Drawing.Size(289, 38);
            this.ItemQuantity.TabIndex = 6;
            this.ItemQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ItemTax
            // 
            this.ItemTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.ItemTax.Location = new System.Drawing.Point(160, 271);
            this.ItemTax.Name = "ItemTax";
            this.ItemTax.Size = new System.Drawing.Size(289, 38);
            this.ItemTax.TabIndex = 7;
            this.ItemTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OkBtn
            // 
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.OkBtn.Location = new System.Drawing.Point(160, 428);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(138, 45);
            this.OkBtn.TabIndex = 8;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.CancelBtn.Location = new System.Drawing.Point(304, 428);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(138, 45);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label5.Location = new System.Drawing.Point(28, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Odjeljak";
            // 
            // SectionComboBox
            // 
            this.SectionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.SectionComboBox.FormattingEnabled = true;
            this.SectionComboBox.Location = new System.Drawing.Point(160, 350);
            this.SectionComboBox.Name = "SectionComboBox";
            this.SectionComboBox.Size = new System.Drawing.Size(289, 39);
            this.SectionComboBox.TabIndex = 11;
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(473, 492);
            this.Controls.Add(this.SectionComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.ItemTax);
            this.Controls.Add(this.ItemQuantity);
            this.Controls.Add(this.ItemPrice);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(700, 140);
            this.Name = "AddItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddItemForm";
            this.Load += new System.EventHandler(this.AddItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.TextBox ItemPrice;
        private System.Windows.Forms.TextBox ItemQuantity;
        private System.Windows.Forms.TextBox ItemTax;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;


        public string getItemName()
        {
            return ItemName.Text.Trim();
        }
        public string getItemPrice()
        {
            return ItemPrice.Text.Trim();
        }
        public string getItemQuantity()
        {
            return ItemQuantity.Text.Trim();
        }
        public string getItemTax()
        {
            return ItemTax.Text.Trim();
        }

        public int getComboBoxSelection()
        {
           return ((System.Collections.Generic.KeyValuePair<int, string>)SectionComboBox.SelectedItem).Key;
        }

        public void setItemNames(string str)
        {
            ItemName.Text = str.Trim();
        }
        public void setItemPrice(string str)
        {
            ItemPrice.Text = str.Trim();
        }
        public void setItemQuantity(string str)
        {
            ItemQuantity.Text = str.Trim();
        }
        public void setItemTax(string str)
        {
            ItemTax.Text = str.Trim();
        }
        
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SectionComboBox;
    }
}