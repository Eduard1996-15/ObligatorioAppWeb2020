using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;
using EntidadesCompartidas;

namespace Interfaz
{
    public partial class ListadoCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnListar_Click(object sender, EventArgs e)
        {

        
            try
            {
                
                 if (DdlTipo.SelectedIndex == 0)
                {
                    grillacursos.DataSource = LogicaCurso.ListarCursoEspecializado();
                    grillacursos.DataBind();
                }
                else
                {
                    grillacursos.DataSource = LogicaCurso.listarCursoCorto();
                    grillacursos.DataBind();
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }

        }

       
    }
}