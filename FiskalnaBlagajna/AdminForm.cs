using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FiskalnaBlagajna
{
    public partial class    AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        public AdminForm(UserTable admin) : this()
        {
           
            AdminName.Text = admin.Name.Trim();

        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
           
            AddItemForm aif = new AddItemForm();
            aif.ShowDialog();

            try
            {
                if (aif.DialogResult == DialogResult.OK)
                {
                    var context = new FiskalnaBlagajnaEntities();
                    var item = new ItemTable();
                   

                    item.Name = aif.getItemName();
                    item.Price = Convert.ToDecimal(aif.getItemPrice());
                    item.Quantity = Int32.Parse(aif.getItemQuantity());
                    item.Tax = Int32.Parse(aif.getItemTax());
                    item.SectionTable.Add(context.SectionTable.Find(aif.getComboBoxSelection()));

                    context.ItemTable.Add(item);
                    context.SaveChanges();
                    MessageBox.Show("Artikal uspiješno pohranjen!");
                   
                }

            }
            catch (Exception n)
            {
                MessageBox.Show(n.ToString());
            }


            aif.Dispose();

        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            AddUserForm auf = new AddUserForm();
   
            var context = new FiskalnaBlagajnaEntities();

            auf.setIdTextBox((context.UserTable.AsEnumerable().Last().Id) + 1 );
            auf.ShowDialog();

           

            try
            {
                if (auf.DialogResult == DialogResult.OK)
                {

                    var user = new UserTable();
                    var role = auf.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

                    user.Name = auf.getNameTextBox();
                    user.Role = role.Text.ToLower().Trim();

                    context.UserTable.Add(user);
                    context.SaveChanges();

                    MessageBox.Show("Korisnik je uspiješno pohranjen!");

                }

            }
            catch(Exception n)
            {
                MessageBox.Show(n.ToString());
            }

            auf.Dispose();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
           
            Application.Exit();

        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            this.Dispose();
            fr.ShowDialog();

        }

        private void AddSectionBtn_Click(object sender, EventArgs e)
        {

            AddSectionForm asf = new AddSectionForm();

            asf.ShowDialog();

            if(asf.DialogResult == DialogResult.OK)
            {
                var context = new FiskalnaBlagajnaEntities();
                var section = new SectionTable();

                section.Name = asf.getName();

                context.SectionTable.Add(section);
                context.SaveChanges();

                MessageBox.Show("Odijeljak uspiješno pohranjen!");

            }

        }

        private void ItemBtn_Click(object sender, EventArgs e)
        {
            ViewEditDeleteForm vedf = new ViewEditDeleteForm();
            var context = new FiskalnaBlagajnaEntities();
            DataGridViewColumn column;

            vedf.Show();

            if(((Button)sender).Text == "Artikli")
            {

               
                vedf.VEDGridView.Columns.Add("Id", "Id");
                vedf.VEDGridView.Columns.Add("Naziv","Naziv");
                vedf.VEDGridView.Columns.Add("Cijena","Cijena Kn");
                vedf.VEDGridView.Columns.Add("Kolicina","Kolicina");
                vedf.VEDGridView.Columns.Add("Porez","Porez   %");

                column = vedf.VEDGridView.Columns[1];
                column.Width = 200;

                foreach (var i in context.ItemTable)
                {
                    vedf.VEDGridView.Rows.Add(i.Id,i.Name,i.Price,i.Quantity,i.Tax);
                }

                

            }
            else if (((Button)sender).Text == "Korisnici")
            {

               
                vedf.VEDGridView.Columns.Add("Lozinka", "Lozinka");
                vedf.VEDGridView.Columns.Add("Naziv", "Naziv");
                vedf.VEDGridView.Columns.Add("Uloga", "Uloga");


                column = vedf.VEDGridView.Columns[1];
                column.Width = 200;
               

                foreach (var u in context.UserTable)
                {
                    vedf.VEDGridView.Rows.Add(u.Id,u.Name,u.Role);
                }


            }
            else
            {

                
                vedf.VEDGridView.Columns.Add("Id", "Id");
                vedf.VEDGridView.Columns.Add("Naziv", "Naziv");
              
                column = vedf.VEDGridView.Columns[1];
                column.Width = 200;

                foreach (var s in context.SectionTable)
                {
                    vedf.VEDGridView.Rows.Add(s.Id,s.Name);
                }

            }


        }
    }
}
