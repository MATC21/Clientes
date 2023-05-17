using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NegociosN;

namespace Clientes
{
    public partial class IngresoClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnguardarCliente_Click(object sender, EventArgs e)
        {
            String respuesta = "";
            respuesta = ClientesN.InsertarClientes(txtId_Cliente.Text, txtNombre_Cliente.Text, txtApellido_Cliente.Text, txtTelefono_Cliente.Text, txtDireccion_Cliente.Text, txtCorreo_Cliente.Text);

            limpiar();

        }

        public void limpiar() 
        { 
            txtId_Cliente.Text = string.Empty;
            txtNombre_Cliente.Text = string.Empty;
            txtApellido_Cliente.Text = string.Empty;
            txtTelefono_Cliente.Text = string.Empty;
            txtDireccion_Cliente.Text = string.Empty;
            txtCorreo_Cliente.Text = string.Empty;

        }
    }
}