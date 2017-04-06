using System;
using System.ComponentModel;
using System.Drawing;
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

        [Description("Neue Zeile wurde zu Place DataGrid hinzugefügt."), Category("Data")]
        public event EventHandler PictureAdded;

        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open Picture";
            open.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.OpenFile());
                Filename = open.SafeFileName;
                PictureAdded?.Invoke(sender, e);
            }
            open.Dispose();
        }

        [Description("Angezeigtes Bild."), Category("Data")]
        public byte[] Image
        {
            get
            {
                return ConvertImageToBinary(pictureBox1.Image);
            }
            set
            {
                pictureBox1.Image = ConvertBinaryToImage(value);
            }
        }

        [Description("Filename des Bildes."), Category("Data")]
        public string Filename { get; set; }

        private byte[] ConvertImageToBinary(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private Image ConvertBinaryToImage(byte[] bArray)
        {
            if (bArray == null)
                return null;

            Image newImage;

            try
            {
                using (MemoryStream ms = new MemoryStream(bArray, 0, bArray.Length))
                {
                    ms.Write(bArray, 0, bArray.Length);
                    newImage = System.Drawing.Image.FromStream(ms, true);
                }
            }
            catch (Exception)
            {
                newImage = null;
            }

            return newImage;
        }

    }
}
