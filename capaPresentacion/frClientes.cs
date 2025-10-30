namespace capaPresentacion
{
    public partial class frClientes : Form
    {
        public frClientes()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtId.Value = 0;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            picFoto.Image = null;

        }

        private void linkFoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofdFoto.FileName = string.Empty;
            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                picFoto.Load(ofdFoto.FileName);

            }
            ofdFoto.FileName = string.Empty;

        }
    }
}
