namespace pryEmilianoFernandezEtapa2
{
    partial class FrmCargaVehiculo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnCargar = new Button();
            PctVehiculo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PctVehiculo).BeginInit();
            SuspendLayout();
            // 
            // BtnCargar
            // 
            BtnCargar.Location = new Point(105, 327);
            BtnCargar.Name = "BtnCargar";
            BtnCargar.Size = new Size(154, 70);
            BtnCargar.TabIndex = 0;
            BtnCargar.Text = "Cargar";
            BtnCargar.UseVisualStyleBackColor = true;
            BtnCargar.Click += BtnCargar_Click;
            // 
            // PctVehiculo
            // 
            PctVehiculo.BackColor = Color.White;
            PctVehiculo.BorderStyle = BorderStyle.Fixed3D;
            PctVehiculo.Image = Properties.Resources.jay_jay_removebg_preview;
            PctVehiculo.Location = new Point(12, 12);
            PctVehiculo.Name = "PctVehiculo";
            PctVehiculo.Size = new Size(341, 260);
            PctVehiculo.SizeMode = PictureBoxSizeMode.StretchImage;
            PctVehiculo.TabIndex = 1;
            PctVehiculo.TabStop = false;
            // 
            // FrmCargaVehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 428);
            Controls.Add(PctVehiculo);
            Controls.Add(BtnCargar);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmCargaVehiculo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Carga de Vehiculo";
            ((System.ComponentModel.ISupportInitialize)PctVehiculo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCargar;
        private PictureBox PctVehiculo;
    }
}
