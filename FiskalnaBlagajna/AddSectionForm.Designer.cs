namespace FiskalnaBlagajna
{
    partial class AddSectionForm
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
            this.SectionNameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv odjeljka";
            // 
            // SectionNameTextBox
            // 
            this.SectionNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.SectionNameTextBox.Location = new System.Drawing.Point(18, 102);
            this.SectionNameTextBox.Name = "SectionNameTextBox";
            this.SectionNameTextBox.Size = new System.Drawing.Size(301, 38);
            this.SectionNameTextBox.TabIndex = 1;
            this.SectionNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.button1.Location = new System.Drawing.Point(18, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.button2.Location = new System.Drawing.Point(182, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddSectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 235);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SectionNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddSectionForm";
            this.Text = "AddSectionForm";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(700, 140);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);
            this.PerformLayout();
            

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SectionNameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;


        public string getName()
        {
            return SectionNameTextBox.Text.Trim();
        }

        public void setSectionName(string str)
        {
            SectionNameTextBox.Text = str.Trim();
        }

    }
}