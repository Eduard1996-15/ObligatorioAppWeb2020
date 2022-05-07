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
    public partial class ListadoAlumnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
            try
            {
                grillaalumnos.DataSource = LogicaAlumno.ListarAlumnos();
                grillaalumnos.DataBind();

            }
            catch (Exception ex)

            {
                lblerror.Text = ex.Message;
            }

        }

        protected void grillaalumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //obtengo Alumno Seleccionado
                Alumno unA = LogicaAlumno.Buscar(Convert.ToInt32(grillaalumnos.SelectedRow.Cells[1].Text));
                DropDownList1.DataSource = LogicaAlumno.ListarTelefono(unA.Cedula);
                DropDownList1.DataTextField = "NumeroTelefono";
                DropDownList1.DataValueField = "NumeroTelefono";
                DropDownList1.DataBind();

                if (unA != null)
                {
                    lblalumno.Text = unA.ToString();

                    ////obtengo las inscripciones  de dicho Alumno

                    grillains.DataSource = LogicaInscripcion.ListarPorAlumno(unA);
                    grillains.DataBind();
                }
                else
                {
                    lblalumno.Text = "";
                    grillains.DataSource = null;
                    grillains.DataBind();
                }
            }
            catch (Exception ex)
            {
                lblerror2.Text = ex.Message;
            }
        }
    }
}