using System.Windows.Forms;
using System.Drawing;

namespace ControlDatos {
    public partial class DatosNormal : UserControl {

        private string imageFile, title;

        public DatosNormal()
        {
            InitializeComponent();
        }

        public void loadDatas()
        {
            Image image = Bitmap.FromFile(imageFile);
            pbImage.SizeMode = PictureBoxSizeMode.CenterImage;
            pbImage.Image = image;
            lblTitle.Text = title;
        }

        public void setDatas(string imageFileSend, string titleSend)
        {
            title = titleSend;
            imageFile = imageFileSend;

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

    }
}