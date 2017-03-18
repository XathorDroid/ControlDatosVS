namespace ControlDatos
{
    partial class DatosListaImagen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelImage = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.panelLabel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panelLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelImage
            // 
            this.panelImage.Controls.Add(this.pbImage);
            this.panelImage.Location = new System.Drawing.Point(3, 3);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(101, 144);
            this.panelImage.TabIndex = 0;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(3, 3);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(95, 138);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // panelLabel
            // 
            this.panelLabel.Controls.Add(this.lblTitle);
            this.panelLabel.Location = new System.Drawing.Point(107, 3);
            this.panelLabel.Name = "panelLabel";
            this.panelLabel.Size = new System.Drawing.Size(275, 144);
            this.panelLabel.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(275, 144);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DatosListaImagen
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelLabel);
            this.Controls.Add(this.panelImage);
            this.Name = "DatosListaImagen";
            this.Size = new System.Drawing.Size(383, 148);
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panelLabel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Panel panelLabel;
        private System.Windows.Forms.Label lblTitle;
    }
}
