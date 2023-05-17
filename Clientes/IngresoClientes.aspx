<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IngresoClientes.aspx.cs" Inherits="Clientes.IngresoClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

     <style>
        * {
            padding: 0;
            margin: 0;
        }

        body {
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 50vh;
        }

        .principal {
            text-align: center;
            align-items: center;
        }

        .input-box {
            display: flex;
            justify-content: space-between;
        }

            .input-box label {
                margin: 0 150px;
            }

        h2 {
            text-align: center;
        }
    </style>

    <form id="form1" runat="server">
        <div class="principal">
            <h2>INGRESO DE CLIENTES</h2>
            <br />
            <asp:Label ID="lblcorrecto" runat="server" Text="LA INSERCION FUE CORRECTA" Visible="false"></asp:Label>
            <asp:Label ID="lblerror" runat="server" Text="LA INSERCION FUE INCORRECTA" Visible="false"></asp:Label>
            <br />
            <div class="input-box">
                <asp:Label ID="lblId_Cliente" runat="server" Text="CI CLIENTE: "></asp:Label>
                <asp:TextBox ID="txtId_Cliente" runat="server"></asp:TextBox>
            </div>

            <div class="input-box">
                <asp:Label ID="lblNombre_Cliente" runat="server" Text="NOMBRE: "></asp:Label>
                <asp:TextBox ID="txtNombre_Cliente" runat="server"></asp:TextBox>
            </div>

            <div class="input-box">
                <asp:Label ID="lblApellido_Cliente" runat="server" Text="APELLIDO: "></asp:Label>
                <asp:TextBox ID="txtApellido_Cliente" runat="server" Onkeypress="return isNumberKey(evt)"></asp:TextBox>
            </div>

            <div class="input-box">
                <asp:Label ID="lbltelf" runat="server" Text="TELEFONO: "></asp:Label>
                <asp:TextBox ID="txtTelefono_Cliente" runat="server"></asp:TextBox>
            </div>

            <div class="input-box">
                <asp:Label ID="lblDireccion" runat="server" Text="DIRECCION: "></asp:Label>
                <asp:TextBox ID="txtDireccion_Cliente" runat="server"></asp:TextBox>
            </div>

            <div class="input-box">
                <asp:Label ID="lblcorreo" runat="server" Text="CORREO: "></asp:Label>
                <asp:TextBox ID="txtCorreo_Cliente" runat="server"></asp:TextBox>
            </div>
            
            </div>
            <br />
            <div class="btx">
                <asp:Button ID="btnguardarCliente" runat="server" Text="GUARDAR" OnClick="btnguardarCliente_Click"/>
            </div>
        </div>
    </form>
</body>
</html>
