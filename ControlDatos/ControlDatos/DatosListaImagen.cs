using System.Windows.Forms;
using System.Drawing;

namespace ControlDatos {
    public partial class DatosListaImagen : UserControl {
        private string imageFile, title;
        private Image image;

        public DatosListaImagen()
        {
            InitializeComponent();
        }

        public void loadDatas()
        {
            pbImage.SizeMode = PictureBoxSizeMode.CenterImage;
            pbImage.Image = image;
            lblTitle.Text = title;
        }

        //public void setDatas(string imageFileSend, string titleSend)
        //{
        //    title = titleSend;
        //    imageFile = imageFileSend;
        //    if (imageFileSend != null)
        //    {
        //        image = Bitmap.FromFile(imageFileSend);
        //    }
        //    else
        //    {
        //        image = Properties.Resources.SinImagen;
        //    }

        //    loadDatas();
        //}

        public void setDatas(Image imageSend, string titleSend)
        {
            title = titleSend;
            //imageFile = imageFileSend;
            if (imageSend != null)
            {
                image = imageSend;
            }
            else
            {
                image = Properties.Resources.SinImagen;
            }

            loadDatas();
        }

        public string getTitle()
        {
            return title;
        }

        public string getImageFile()
        {
            return imageFile;
        }

        public Image getImage()
        {
            return image;
        }

        public PictureBox getPb()
        {
            return pbImage;
        }

        public Label getLbl()
        {
            return lblTitle;
        }

        public Panel getPanelPb()
        {
            return panelImage;
        }
    }
}
