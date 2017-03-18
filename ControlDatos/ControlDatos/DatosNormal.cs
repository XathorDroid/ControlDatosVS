﻿using System.Windows.Forms;
using System.Drawing;

namespace ControlDatos {
    public partial class DatosNormal : UserControl {

        private string imageFile, title;
        private Image image;

        public DatosNormal()
        {
            InitializeComponent();
        }

        public void loadDatas()
        {
            pbImage.SizeMode = PictureBoxSizeMode.CenterImage;
            pbImage.Image = image;
            lblTitle.Text = title;
        }

        public void setDatas(string imageFileSend, string titleSend)
        {
            title = titleSend;
            imageFile = imageFileSend;
            if(imageFileSend != null) {
                image = Bitmap.FromFile(imageFileSend);
            } else {
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

    }
}