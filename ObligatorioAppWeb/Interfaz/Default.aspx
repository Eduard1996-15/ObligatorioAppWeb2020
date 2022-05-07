<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ObligatorioAppWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 446px;
            background-color: #00FFFF;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 380px;
        }
        .auto-style4 {
            width: 380px;
            height: 52px;
        }
        .auto-style5 {
            height: 52px;
        }
        .auto-style6 {
            font-size: x-large;
            color: #000080;
        }
        .auto-style7 {
            font-family: "Franklin Gothic Medium", "Arial Narrow", Arial, sans-serif;
            font-weight: bold;
        }
    </style>
</head>
<body style="height: 186px; width: 812px;">
    <form id="form1" runat="server">
        <div class="auto-style1">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<table class="auto-style2">
                <tr>
                    <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Image ID="Image" runat="server" Height="137px" Width="422px" ImageUrl="~/image/logoBios.jpg" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style7">INSTITUTO</span></span><br />
                    </td>
                    <td class="auto-style5">
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"><a href="javascript:__doPostBack('LinkButton2','')">&nbsp;
                        </a>
                        <asp:LinkButton ID="linkbtnMantenimientoAlumnos" runat="server" PostBackUrl="~/MantenimientoAlumnos.aspx">MantenimientoAlumno</asp:LinkButton>
                        </td>
                </tr>
                <tr>
                    <td class="auto-style3"><a href="javascript:__doPostBack('LinkButton2','')">
                        <asp:LinkButton ID="linkbtnACursoCorto" runat="server" PostBackUrl="~/AgregarCursoCorto.aspx">AgregarCursoCorto</asp:LinkButton>
                        </a></td>
                </tr>
                <tr>
                    <td class="auto-style3"><a href="javascript:__doPostBack('LinkButton3','')">
                        <asp:LinkButton ID="linkbtnACEspecializado" runat="server" PostBackUrl="~/AgreagarCursoEspecializado.aspx">AgreagarCursoEspecializado</asp:LinkButton>
                        </a></td>
                </tr>
                <tr>
                    <td class="auto-style3"><a href="javascript:__doPostBack('LinkButton4','')">
                        <asp:LinkButton ID="linkbtnRIAcurso" runat="server" PostBackUrl="~/RealizarInscripcionACurso.aspx">RealizarInscripcionACurso</asp:LinkButton>
                        </a></td>
                </tr>
                <tr>
                    <td class="auto-style3"><a href="javascript:__doPostBack('LinkButton5','')">
                        <asp:LinkButton ID="linkbtnAlumnos" runat="server" PostBackUrl="~/ListadoAlumnos.aspx">ListadoAlumnos</asp:LinkButton>
                        </a></td>
                </tr>
                <tr>
                    <td class="auto-style3"><a href="javascript:__doPostBack('LinkButton6','')">
                        <asp:LinkButton ID="linkbtnLIXCurso" runat="server" PostBackUrl="~/ListadoInscripcionesXCurso.aspx">ListadoInscripcionesXCurso</asp:LinkButton>
                        </a></td>
                </tr>
                <tr>
                    <td class="auto-style3"><a href="javascript:__doPostBack('LinkButton7','')">
                        <asp:LinkButton ID="LinkbtnListadoCursos" runat="server" PostBackUrl="~/ListadoCurso.aspx">ListadoCursos</asp:LinkButton>
                        </a></td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
