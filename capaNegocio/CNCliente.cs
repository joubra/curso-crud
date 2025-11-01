using capaEntidad;
using capaDatos;
using System.Windows.Forms;
using System;

namespace capaNegocio

{
    public class CNCliente
    {
        CDcliente cdcliente = new CDcliente();
        public bool validarDatos(CEClientes clientes)
        {
            if (clientes.Nombre == string.Empty)
            {
                MessageBox.Show("El campo Nombre no puede estar vacio");
                return false;

            }
            if (clientes.Apellido == string.Empty)
            {
                MessageBox.Show("El campo Apellido no puede estar vacio");
                return false;
            }
            if (clientes.foto == null)
            {
                MessageBox.Show("El campo Foto no puede estar vacio");
                return false;
            }
            return true;


        }
        
        public void Pruebamysqul()
        {
            cdcliente.pruebaConexion();
        }
        public void crearCliente(CEClientes cE)
        {
            cdcliente.crear(cE);
        }

    }
}
