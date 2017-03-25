using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class ucNewSingleItem : UserControl
    {
        public ucNewSingleItem()
        {
            InitializeComponent();
        }

        private string _name;

        [Description("Typ der selektiert und zurückgegeben werden soll."), Category("Data")]
        public string Type
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                lblName.Text = value;
                btnAddNewSingleItem.Text = $"New {value}";
            }
        }

        [Description("New SingleItem."), Category("Data")]
        public object NewSingleItem
        {
            get
            {
                if (Type == "Item")
                {
                    Item tmp = new Item { Name = txtName.Text };
                    return tmp;
                }
                else
                {
                    Quest tmp = new Quest { Name = txtName.Text };
                    return tmp;
                }

            }
        }

        [Description("Neues SingleItem wird hinzugefügt."), Category("Data")]
        public event EventHandler SingleItemAdded;

        private void btnAddNewSingleItem_Click(object sender, EventArgs e)
        {
            bool isThereTextInAnyTxtbox = (Controls.OfType<TextBox>().All(t => t.Text == "")) ? false : true;

            if (isThereTextInAnyTxtbox)
            {
                SingleItemAdded?.Invoke(sender, e);
                clearTxTBoxes();
            }
        }

        private void clearTxTBoxes()
        {
            foreach (var txtbox in Controls.OfType<TextBox>())
            {
                txtbox.Text = null;
            }
        }
    }
}
