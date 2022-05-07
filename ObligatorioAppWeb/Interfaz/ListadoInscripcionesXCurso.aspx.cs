using EntidadesCompartidas;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interfaz
{
    public partial class ListadoInscripcionesXCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if(!IsPostBack)
                {
                    DropDownList1.DataSource = LogicaCurso.listarCursoCorto();
                    DropDownList1.DataTextField = "Nombre";
                    DropDownList1.DataValueField = "IDE";
                    DropDownList1.DataBind();


                    DropDownList2.DataSource = LogicaCurso.ListarCursoEspecializado();
                    DropDownList2.DataTextField = "Nombre";
                    DropDownList2.DataValueField = "IDE";
                    DropDownList2.DataBind();
                }
                   
            }
            catch (Exception ex)
            {
                lblerror2.Text = ex.Message;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                    //obtengo Curso Seleccionado
                    
                    string ide = Convert.ToString(DropDownList1.SelectedValue);
                    lblCurso.Text = DropDownList1.SelectedItem.Text;

                        ////obtengo las inscripciones  de dicho Curso

                        grillains.DataSource = LogicaInscripcion.ListarInscripcionXCurso(ide);
                        grillains.DataBind();
            }
            catch (Exception ex)
            {
                lblerror2.Text = ex.Message;
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
              
                    //obtengo Curso Seleccionado
                    string ide = Convert.ToString(DropDownList2.SelectedValue);
                lblCurso.Text = DropDownList2.SelectedItem.Text;

                        ////obtengo las inscripciones  de dicho Curso

                        grillains.DataSource = LogicaInscripcion.ListarInscripcionXCurso(ide);
                        grillains.DataBind();
                
            }
            catch (Exception ex)
            {
                lblerror2.Text = ex.Message;
            }
        }

       
    }
}