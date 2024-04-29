using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEmilianoFernandezEtapa2
{
    internal class clsVehiculo
    {
        //Propiedades
        public string nombre { get; set; }
        public string tipo { get; set; }
        public Image Imagen { get; set; }

        //Constructor


        //Metodos

        public void crearVehiculo(PictureBox Vehiculo) //pct del formulario
        {

            PictureBox ImagenVehiculo = new PictureBox(); //instancio en memora imagen
            Random rnd = new Random(); //creo random
            switch (rnd.Next(1,4))  //para cada caso un random
            {
                case 1:
                    Imagen = pryEmilianoFernandezEtapa2.Properties.Resources.Rayo_Mckuin;
                    break;
                case 2:
                    Imagen = pryEmilianoFernandezEtapa2.Properties.Resources.CAPTAIN_removebg_preview;
                    break;
                case 3:
                    Imagen = pryEmilianoFernandezEtapa2.Properties.Resources.jay_jay_removebg_preview;
                    break;
            }

            ImagenVehiculo.Image = Imagen;
            ImagenVehiculo.SizeMode = PictureBoxSizeMode.StretchImage;
            ImagenVehiculo.Location = Vehiculo.Location;
            ImagenVehiculo.Size = Vehiculo.Size;
            Vehiculo.Parent.Controls.Add(ImagenVehiculo);

            ImagenVehiculo.BringToFront();
            
        }
    }
}
