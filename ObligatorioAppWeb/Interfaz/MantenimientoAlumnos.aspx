<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MantenimientoAlumnos.aspx.cs" Inherits="Interfaz.MantenimientoAlumnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 639px;
            background-color: #0099CC;
        }
        .auto-style2 {
            font-family: "Franklin Gothic Medium", "Arial Narrow", Arial, sans-serif;
            font-weight: bold;
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="auto-style2">&nbsp; MANTENIMIENTO ALUMNOS</span><br />
            <br />
            CI :<br />
            <br />
&nbsp;<asp:TextBox ID="txtCedula" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="BtnBuscar" runat="server" Text="Buscar" OnClick="Btnci_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            Nombre :<br />
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            <br />
            Calle:<br />
            <asp:TextBox ID="txtCalle" runat="server"></asp:TextBox>
            <br />
            <br />
            Numero Casa o Apto:<br />
            <asp:TextBox ID="Txtnumero" runat="server"></asp:TextBox>
            <br />
            <br />
            Barrio :<br />
            <asp:TextBox ID="txtBarrio" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnAgregar" runat="server" Text="Agregar" Width="103px" OnClick="BtnAgregar_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" Width="97px" OnClick="BtnEliminar_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnEditar" runat="server" Text="Editar" Width="97px" OnClick="BtnEditar_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnLimpiar" runat="server" OnClick="BtnLimpiar_Click" Text="Limpiar/Deshacer" />
            <br />
            Telefono :<br />
            <asp:TextBox ID="txttel" runat="server"></asp:TextBox>
&nbsp;
            <asp:Button ID="btnagregarTel" runat="server" OnClick="btnagregarTel_Click" Text="Agregar Telefono" />
            &nbsp;
            <asp:Button ID="btnEt" runat="server" OnClick="btnEt_Click" Text="Eliminar Telefono" Width="150px" />
            <br />
            Lista Telefonos :<br />
            <asp:DropDownList ID="DropDownList1" runat="server" Height="33px" Width="126px">
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnver" runat="server" OnClick="btnver_Click" Text="Ver Telefono" />
            &nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;
            &nbsp;
            <br />
            <br />
        </div>
    </form>
</body>
</html>
