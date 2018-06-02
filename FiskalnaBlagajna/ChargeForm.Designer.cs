namespace FiskalnaBlagajna
{
    partial class ChargeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.numLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "U.O. Fiskalna Blagajna ";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TimeLabel.Location = new System.Drawing.Point(12, 59);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(71, 20);
            this.TimeLabel.TabIndex = 1;
            this.TimeLabel.Text = "Vrijeme:";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.userLabel.Location = new System.Drawing.Point(12, 88);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(80, 20);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "Operater:";
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.numLabel.Location = new System.Drawing.Point(12, 117);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(82, 20);
            this.numLabel.TabIndex = 4;
            this.numLabel.Text = "Racun br:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Quantity,
            this.Price});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(420, 334);
            this.dataGridView1.TabIndex = 5;
            // 
            // Name
            // 
            this.Name.HeaderText = "Naziv";
            this.Name.Name = "Name";
            this.Name.Width = 180;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Kolicina";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 120;
            // 
            // Price
            // 
            this.Price.HeaderText = "Cijena";
            this.Price.Name = "Price";
            this.Price.Width = 120;
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.sumLabel.Location = new System.Drawing.Point(89, 550);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(127, 29);
            this.sumLabel.TabIndex = 6;
            this.sumLabel.Text = "UKUPNO:";
            // 
            // ChargeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 618);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(400, 50);
           
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ChargeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChargeForm_FormClosing);
            this.Load += new System.EventHandler(this.ChargeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label numLabel;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label sumLabel;
    }
}