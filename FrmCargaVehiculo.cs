namespace pryEmilianoFernandezEtapa2
{
    public partial class FrmCargaVehiculo : Form
    {
        clsVehiculo objetoVehiculo;

        public FrmCargaVehiculo()
        {
            InitializeComponent();
            objetoVehiculo = new clsVehiculo();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            objetoVehiculo.crearVehiculo(PctVehiculo);
        }
    }
}
