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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {


            var context = new FiskalnaBlagajnaEntities();
           
            

            try
            {
                var user = context.UserTable.Find(Int32.Parse(LogInTextBox.Text.Trim()));

                if (user.Role.Trim() == "admin")
                {
                    
                    AdminForm af = new AdminForm(user);
                    this.Hide();
                    af.ShowDialog();

                   

                }
                else
                {

                    UserForm uf = new UserForm(user);
                    this.Hide();
                    uf.ShowDialog();


                }


            }
            catch (NullReferenceException n) // format exception to handle
            {
                
                LogInTextBox.BackColor = Color.Red;
                LogInTextBox.Text = "";

            }

        }
 

        private void LogInTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LogInBtn.PerformClick();
                e.Handled = true;
            }
        }



    }
}
