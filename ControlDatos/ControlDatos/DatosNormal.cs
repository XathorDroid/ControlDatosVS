﻿using System.Windows.Forms;
using System.Drawing;

namespace ControlDatos {
    public partial class DatosNormal : UserControl {

        public DatosNormal() {
            InitializeComponent();
        }

        public void loadDatas(string image, string title) {
            pbImage.Image = Image.FromFile(image);
            lblTitle.Text = title;
        }

    }
}