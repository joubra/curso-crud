using capaEntidad;
using capaNegocio;
using capaDatos;


namespace capaPresentacion
{
    public partial class frClientes : Form
    {
        CNCliente cNCliente = new CNCliente();

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool resul;
            CEClientes cEClientes = new CEClientes();
            cEClientes.Id = Convert.ToInt32(txtId.Value);
            cEClientes.Nombre = txtNombre.Text;
            cEClientes.Apellido = txtApellido.Text;
            cEClientes.foto = picFoto.ImageLocation;
            resul = cNCliente.validarDatos(cEClientes);
            if (!resul) return;

            if (cEClientes.Id == 0)
            {
                cNCliente.crearCliente(cEClientes);
            }
            else
            {
                cNCliente.editarCliente(cEClientes);
            }
           
            MessageBox.Show("Cliente guardado con exito");
            CargarDato();




        }
        

        public void btnEliminar_Click(object sender, EventArgs e)
        {
           cNCliente.eliminarCliente(new CEClientes() { Id = Convert.ToInt32(txtId.Value) });
            CargarDato();
        }

        private void frClientes_Load(object sender, EventArgs e)
        {
            CargarDato();

        }
        private void CargarDato()
        {
            dataGridView1.DataSource = cNCliente.ObtenerDatos().Tables["tbl"];
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtId.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            txtApellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
            picFoto.Load(dataGridView1.CurrentRow.Cells["Foto"].Value.ToString());

        }
    }
}
