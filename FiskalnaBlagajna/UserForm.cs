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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        public UserForm(UserTable user) : this()
        {
            UserNameLabel.Text = user.Name.Trim();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

            var context = new FiskalnaBlagajnaEntities();

            foreach (var section in context.SectionTable)
            {
                Button SectionBtn = new Button();

                SectionBtn.Name = "SectionBtn";
                SectionBtn.Tag = section;
                SectionBtn.Text = section.Name.Trim();
                SectionBtn.Width = 245;
                SectionBtn.Height = 60;
                SectionBtn.Font = new Font(SectionBtn.Font.FontFamily, 14);
                SectionBtn.MouseClick += new MouseEventHandler(this.displayData);

                flowLayoutPanel1.Controls.Add(SectionBtn);
            }

        }


        public void displayData(object sender, MouseEventArgs e)
        {

            var context = new FiskalnaBlagajnaEntities();
            int sectionID = ((SectionTable)(sender as Button).Tag).Id;

            flowLayoutPanel2.Controls.Clear();

            foreach (var c in context.SectionTable.Find(sectionID).ItemTable)
            {
                Button itemBtn = new Button();

                itemBtn.Name = "ItemBtn";
                itemBtn.Text = c.Name.Trim();
                itemBtn.Tag = c;
                itemBtn.Width = 180;
                itemBtn.Height = 60;
                itemBtn.Font = new Font(itemBtn.Font.FontFamily, 14);
                itemBtn.MouseClick += new MouseEventHandler(this.addItem);

                flowLayoutPanel2.Controls.Add(itemBtn);
            }

        }

        public void addItem(object sender, MouseEventArgs e)
        {
            var item = (ItemTable)(sender as Button).Tag;

            this.dataGridView1.Rows.Add(item.Name, 1, item.Price);
            //this.dataGridView1.Rows[this.dataGridView1.NewRowIndex - 1].Tag = item;
             this.dataGridView1.CurrentCell = dataGridView1.Rows[this.dataGridView1.NewRowIndex - 1].Cells[0];
        }


        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            this.Hide();
            fr.ShowDialog();
        }

        private void Xbtn_Click(object sender, EventArgs e)
        {
            if (!(dataGridView1.Rows[0].IsNewRow))
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);

        }

        private void ChargeBtn_Click(object sender, EventArgs e)
        {
            ChargeForm cf = new ChargeForm(UserNameLabel.Text);

            int br = 0;
            
            foreach (DataGridViewRow data in dataGridView1.Rows)
            {
                if (!(data.IsNewRow))
                {
                    
                    foreach (DataGridViewRow d in dataGridView1.Rows)
                    {
                            if (data.Cells[0].Value == d.Cells[0].Value)
                            {
 
                                br++;
                            if (br > 1)
                                dataGridView1.Rows.RemoveAt(d.Index);
                                
                            } 
                     }
                    
                    cf.dataGridView1.Rows.Add(data.Cells[0].Value, Int32.Parse(data.Cells[1].Value.ToString()) * br, Int32.Parse(data.Cells[2].Value.ToString()) * br);
                    br = 0;
                  
                }
            }

            cf.Tag = this;
            cf.ShowDialog();

        }
    }
}
