using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MainForm
{
    public partial class ucPicture : UserControl
    {
        public ucPicture()
        {
            InitializeComponent();
        }

        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open Picture";
            open.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            open.InitialDirectory = $"{Directory.GetCurrentDirectory()}\\Pictures";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.OpenFile());
            }
            Filename = open.SafeFileName;
            open.Dispose();
        }

        [Description("Angezeigtes Bild."), Category("Data")]
        public Image Image
        {
            set
            {
                pictureBox1.Image = value;
            }
        }

        [Description("Filename des Bildes."), Category("Data")]
        public string Filename { get; set; }
    }
}
