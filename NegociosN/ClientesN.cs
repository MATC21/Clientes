using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatosD;
using EntidadesE;

namespace NegociosN
{
    public class ClientesN
    {

        public static String InsertarClientes(String Id_Cliente, String Nombre_Cliente, String Apellido_Cliente, String Telefono_Cliente, String Direccion_Cliente,String Correo_Cliente)
        {
            ClientesD datos = new ClientesD();
            ClientesE obj = new ClientesE();
            obj.Id_Cliente = Id_Cliente;
            obj.Nombre_Cliente = Nombre_Cliente;
            obj.Apellido_Cliente = Apellido_Cliente;
            obj.Telefono_Cliente = Telefono_Cliente;
            obj.Direccion_Cliente = Direccion_Cliente;
            obj.Correo_Cliente = Correo_Cliente;
           
            return datos.InsertarClientes(obj);
        }

    }
}
