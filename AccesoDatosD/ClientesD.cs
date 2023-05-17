using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntidadesE;

namespace AccesoDatosD
{
    public class ClientesD
    {

        public String InsertarClientes(ClientesE obj)
        {
            string respuesta = "";
            SqlConnection connection = new SqlConnection();
            try
            {
                connection = Conexion.crearInstancia().crearConexion();
                SqlCommand command = new SqlCommand("sp_Ingreso_Clientes", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@strCedula_Cliente", SqlDbType.VarChar).Value = obj.Id_Cliente;
                command.Parameters.Add("@strNombre_Cliente", SqlDbType.VarChar).Value = obj.Nombre_Cliente;
                command.Parameters.Add("@strApellido_Cliente", SqlDbType.VarChar).Value = obj.Apellido_Cliente;
                command.Parameters.Add("@strTelefono_Cliente", SqlDbType.VarChar).Value = obj.Telefono_Cliente;
                command.Parameters.Add("@strDireccion_Cliente", SqlDbType.NVarChar).Value = obj.Direccion_Cliente;
                command.Parameters.Add("@strCorreo_Cliente", SqlDbType.NVarChar).Value = obj.Correo_Cliente;

                connection.Open();

                respuesta = command.ExecuteNonQuery() == 1 ? "!OK" : "!NO SE PUDO REALIZAR EL INGRESO";

            }
            catch (Exception e)
            {
                respuesta = e.Message;
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
            return respuesta;
        }

    }
}
