using System.Windows.Forms;
using System.Drawing;

namespace ControlDatos {
    public partial class DatosNormal : UserControl {

        public DatosNormal() {
            InitializeComponent();
        }

        public void loadDatas(string imageFile, string title) {
            Image image = Image.FromFile(imageFile);
            pbImage.SizeMode = PictureBoxSizeMode.CenterImage;
            pbImage.Image = image;
            lblTitle.Text = title;
        }

    }
}