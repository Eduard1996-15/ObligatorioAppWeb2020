using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntidadesCompartidas;
using Logica;

namespace Interfaz
{
    public partial class RealizarInscripcionACurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                this.LimpioFormulario();
        }

        private void LimpioFormulario()
        {
            btnAltains.Enabled = true;
            TXTIDE.Text = "";
            TXTCI.Text = "0";
            TXTEMP.Text = "";


            lblerror.Text = "";
        }

        protected void btnAltains_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = DateTime.Now;

                Inscripcion unaI = new Inscripcion(0, Convert.ToInt32(TXTCI.Text), fecha, TXTEMP.Text, TXTIDE.Text);
                LogicaInscripcion.AgregarInscripcion(unaI);
                this.LimpioFormulario();
                lblerror.Text = "Se agrego inscripion con exito";
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }


        }
    }
}