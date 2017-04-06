using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace MainForm
{
    public partial class ucAddNewPlace : UserControl
    {
        public ucAddNewPlace()
        {
            InitializeComponent();
        }

        [Description("New Place."), Category("Data")]
        public Place NewPlace
        {
            get
            {
                Place tmp = new Place {
                                        Continent = txtContinent.Text,
                                        City = txtCity.Text,
                                        District = txtDistrict.Text,
                                        Building = txtBuilding.Text,
                                        Name = txtName.Text
                                      };
                return tmp;
            }
        }

        [Description("Neuer Place wird hinzugefügt."), Category("Data")]
        public event EventHandler PlaceAdded;

        private void btnAddNewPlace_Click(object sender, EventArgs e)
        {
            bool isThereTextInAnyTxtbox = (Controls.OfType<TextBox>().All(t => t.Text == "")) ? false : true;

            if (isThereTextInAnyTxtbox)
            {
                PlaceAdded?.Invoke(sender, e);
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
