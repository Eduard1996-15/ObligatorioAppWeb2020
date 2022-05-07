<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RealizarInscripcionACurso.aspx.cs" Inherits="Interfaz.RealizarInscripcionACurso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 470px;
            background-color: #9999FF;
        }
        .auto-style2 {
            font-family: "Franklin Gothic Medium", "Arial Narrow", Arial, sans-serif;
            font-weight: bold;
            font-size: x-large;
        }
    </style>
</head>
<body style="height: 456px">
    <form id="form1" runat="server">
        <div id="" class="auto-style1">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="auto-style2"> REALIZAR INCRIPCION A CURSO</span><br />
            IDE DEL CURSO :<br />
            <asp:TextBox ID="TXTIDE" runat="server"></asp:TextBox>
            <br />
            <br />
            CI DEL ALUMNO:<br />
            <asp:TextBox ID="TXTCI" runat="server"></asp:TextBox>
            <br />
            <br />
            NOMBRE EMPLEADO :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblerror" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <asp:TextBox ID="TXTEMP" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAltains" runat="server" Text="Alta Inscripcion " OnClick="btnAltains_Click" />
        </div>
    </form>
</body>
</html>
