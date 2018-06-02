using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiskalnaBlagajna
{
    public partial class ChargeForm : Form
    {
        public ChargeForm()
        {
            InitializeComponent();
        }

        public ChargeForm(string user) : this()
        {
            this.userLabel.Text = userLabel.Text + " " + user.Trim();
        }

        private void ChargeForm_Load(object sender, EventArgs e)
        {

            int sum = 0;

            this.TimeLabel.Text = this.TimeLabel.Text + "   " + DateTime.Now.ToLongTimeString();
            this.numLabel.Text = numLabel.Text + " XXXXX";

            foreach(DataGridViewRow d in dataGridView1.Rows)
            {
                if (!(d.IsNewRow))
                {
                    
                    sum += Int32.Parse(d.Cells[2].Value.ToString());
                }
            }

            this.sumLabel.Text = sumLabel.Text + " " + sum.ToString() + " " + "Kn";

        }


        private void ChargeForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            (this.Tag as UserForm).Dispose();
            this.Dispose();
            Form1 fr = new Form1();
            fr.ShowDialog();

        }
    }
}
