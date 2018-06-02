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
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {

            var context = new FiskalnaBlagajnaEntities();
            Dictionary<int, string> sections = new Dictionary<int, string>();

            foreach ( var s in context.SectionTable)
            {
                sections.Add(s.Id, s.Name);
            }

            this.SectionComboBox.DataSource = new BindingSource(sections, null);
            this.SectionComboBox.DisplayMember = "Value";
            this.SectionComboBox.ValueMember = "Key";
            

        }
    }
}
