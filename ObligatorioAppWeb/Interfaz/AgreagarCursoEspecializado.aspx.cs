using EntidadesCompartidas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

namespace Interfaz
{
    public partial class AgreagarCursoEspecializado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          if (!IsPostBack)
            {
                this.LimpioFormulario();
            }
        }

        private void LimpioFormulario()
        {
            btnAgregar.Enabled = true;

            txtide.Enabled = true;
            txtnom.Text = "";
            txtprecio.Text = "0";
            txtdur.Text = "0";
            txtprerrequisitos.Text = "";
            lblerror.Text = "";
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                CursoEspecializado unC = new CursoEspecializado(txtide.Text.Trim(), txtnom.Text.Trim(),
                    Convert.ToByte(txtdur.Text), Convert.ToInt32(txtprecio.Text), txtprerrequisitos.Text.Trim());
                LogicaCurso.AgregarCursoEspecializado(unC);
                this.LimpioFormulario();
                lblerror.Text = "Se agrego exitosamente el Curso";
            }

            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }
    }
}