namespace FiskalnaBlagajna
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.LogInTextBox = new System.Windows.Forms.TextBox();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(583, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite Lozinku";
            // 
            // LogInTextBox
            // 
            this.LogInTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.LogInTextBox.Location = new System.Drawing.Point(503, 351);
            this.LogInTextBox.Name = "LogInTextBox";
            this.LogInTextBox.PasswordChar = '•';
            this.LogInTextBox.Size = new System.Drawing.Size(370, 46);
            this.LogInTextBox.TabIndex = 1;
            this.LogInTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LogInTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LogInTextBox_KeyDown);
            // 
            // LogInBtn
            // 
            this.LogInBtn.BackColor = System.Drawing.SystemColors.Control;
            this.LogInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.LogInBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LogInBtn.Location = new System.Drawing.Point(589, 414);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(202, 44);
            this.LogInBtn.TabIndex = 2;
            this.LogInBtn.Text = "Prijavite se";
            this.LogInBtn.UseVisualStyleBackColor = false;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1152, 540);
            this.Controls.Add(this.LogInBtn);
            this.Controls.Add(this.LogInTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LogInTextBox;
        private System.Windows.Forms.Button LogInBtn;
    }
}

