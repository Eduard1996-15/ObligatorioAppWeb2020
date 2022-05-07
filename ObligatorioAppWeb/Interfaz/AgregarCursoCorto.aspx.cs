using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntidadesCompartidas;
using Logica;

namespace Interfaz
{
    public partial class AgregarCursoCorto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                this.LimpioFormulario();
        }
        private void LimpioFormulario()
        {
            Button1.Enabled = true;

            txtIdeCC.Enabled = true;
            txtNombreCC.Text = "";
            txtDuracionCC.Text = "0";
            txtPrecioCC.Text = "0";
            ListAreaApp.Text = "";
            lblerror.Text = "";
                }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListAreaApp.SelectedIndex == 0)
                {
                    ListAreaApp.Text = "Economia";
                    ListAreaApp.SelectedValue = "AreaAplicacion";
                }
                else if (ListAreaApp.SelectedIndex == 1)
                {
                    ListAreaApp.Text = "Programacion";
                    ListAreaApp.SelectedValue = "AreaAplicacion";
                }
                else if (ListAreaApp.SelectedIndex == 2)
                {
                    ListAreaApp.Text = "Disenio";
                    ListAreaApp.SelectedValue = "AreaAplicacion";
                }
                CursoCorto unC = new CursoCorto(txtIdeCC.Text, txtNombreCC.Text, Convert.ToByte(txtDuracionCC.Text), Convert.ToInt32(txtPrecioCC.Text), ListAreaApp.Text);
                LogicaCurso.AgregarCursoCorto(unC);
                this.LimpioFormulario();
                lblerror.Text = "Se agrego con exito";

            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }
    }
}