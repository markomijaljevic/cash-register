namespace FiskalnaBlagajna
{
    partial class ViewEditDeleteForm
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
            this.VEDGridView = new System.Windows.Forms.DataGridView();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VEDGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // VEDGridView
            // 
            this.VEDGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.VEDGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VEDGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VEDGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.VEDGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VEDGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.VEDGridView.EnableHeadersVisualStyles = false;
            this.VEDGridView.GridColor = System.Drawing.Color.Black;
            this.VEDGridView.Location = new System.Drawing.Point(0, 0);
            this.VEDGridView.Name = "VEDGridView";
            this.VEDGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VEDGridView.Size = new System.Drawing.Size(669, 301);
            this.VEDGridView.TabIndex = 0;
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.EditBtn.Location = new System.Drawing.Point(12, 357);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(158, 42);
            this.EditBtn.TabIndex = 1;
            this.EditBtn.Text = "Uredi";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.DeleteBtn.Location = new System.Drawing.Point(176, 357);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(158, 42);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Izbriši";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ViewEditDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 411);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.VEDGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(550, 140);
            this.Name = "ViewEditDeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ViewEditDeleteForm";
            ((System.ComponentModel.ISupportInitialize)(this.VEDGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView VEDGridView;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
    }
}