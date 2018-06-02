using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;

namespace FiskalnaBlagajna
{
    public partial class ViewEditDeleteForm : Form
    {
        public ViewEditDeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            var context = new FiskalnaBlagajnaEntities();
            int selectedID = Int32.Parse(VEDGridView.SelectedRows[0].Cells[0].Value.ToString());

            try
            {

                if (VEDGridView.ColumnCount == 5) //itemTabel
                {
                    var item = context.ItemTable.Find(selectedID);

                    //context.ItemTable.Attach(item);
                    context.ItemTable.Remove(item);
                    context.SaveChanges();

                    MessageBox.Show("Artikl uspiješno izbrisan!");

                }
                else if (VEDGridView.ColumnCount == 3)//userTabel
                {

                    var user = context.UserTable.Find(selectedID);

                    //context.ItemTable.Attach(item);
                    context.UserTable.Remove(user);
                    context.SaveChanges();

                    MessageBox.Show("Korisnik uspiješno izbrisan!");

                }
                else // sectionTable
                {

                    var section = context.SectionTable.Find(selectedID);

                    //context.ItemTable.Attach(item);
                    context.SectionTable.Remove(section);
                    context.SaveChanges();

                    MessageBox.Show("Odjeljak uspiješno izbrisan!");

                }



            }

            catch (Exception n)
            {
                MessageBox.Show(n.ToString());
            }

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

            var context = new FiskalnaBlagajnaEntities();
            int selectedID = Int32.Parse(VEDGridView.SelectedRows[0].Cells[0].Value.ToString());
     
            try
            {

                if (VEDGridView.ColumnCount == 5) //itemTabel
                {
                    var item = context.ItemTable.Find(selectedID);
                    AddItemForm aif = new AddItemForm();

                    aif.setItemNames(item.Name);
                    aif.setItemPrice(item.Price.ToString());
                    aif.setItemQuantity(item.Quantity.ToString());
                    aif.setItemTax(item.Tax.ToString());
                    //aif.setComboBoxSelection();

                    aif.ShowDialog();


                    if (aif.DialogResult == DialogResult.OK)
                    {

                        item.Name = aif.getItemName();
                        item.Price = Int32.Parse(aif.getItemPrice());
                        item.Quantity = Int32.Parse(aif.getItemQuantity());
                        item.Tax = Int32.Parse(aif.getItemTax());
                        item.SectionTable.Add(context.SectionTable.Find(aif.getComboBoxSelection()));

                        context.ItemTable.AddOrUpdate(item);
                        context.SaveChanges();
                        
                        MessageBox.Show("Artikal je uspiješno uređen");
                    }

                }
                else if (VEDGridView.ColumnCount == 3)//userTabel
                {
                    
                    var user = context.UserTable.Find(selectedID);
                    AddUserForm aif = new AddUserForm();

                    aif.setUserNames(user.Name);
                    aif.setIdTextBox(user.Id);

                    aif.ShowDialog();
                    
                    if (aif.DialogResult == DialogResult.OK)
                    {

                        user.Name = aif.getNameTextBox();
                   
                        context.UserTable.AddOrUpdate(user);
                        context.SaveChanges();

                        MessageBox.Show("Korisnik je uspiješno uređen");
                    }
                    
                }
                else // sectionTable
                {
                    var section = context.SectionTable.Find(selectedID);
                    AddSectionForm aif = new AddSectionForm();

                    
                    aif.setSectionName(section.Name);

                    aif.ShowDialog();

                    if (aif.DialogResult == DialogResult.OK)
                    {

                        section.Name = aif.getName();

                        context.SectionTable.AddOrUpdate(section);
                        context.SaveChanges();

                        MessageBox.Show("Odjeljak je uspiješno uređen");
                    }

                }



            }
            catch (Exception n)
            {
                MessageBox.Show(n.ToString());
            }
            
        }
    }
}
