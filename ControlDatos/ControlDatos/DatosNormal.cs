using System.Windows.Forms;
using System.Drawing;

namespace ControlDatos {
    public partial class DatosNormal : UserControl {

        public DatosNormal() {
            InitializeComponent();
        }

        public void loadDatas(string imageFile, string title) {
            Image image = Bitmap.FromFile(imageFile);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.Image = image;
            lblTitle.Text = title;
        }

    }
}