using btnagregarTel;
using EntidadesCompartidas;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interfaz
{
    public partial class MantenimientoAlumnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                this.LimpioFormulario();
        }

        private void ActivoBotonesBM()
        {
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;

            BtnAgregar.Enabled = false;
            BtnBuscar.Enabled = false;

            txtCedula.Enabled = false;
        }

        private void ActivoBotonesAlta()
        {
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;

            BtnAgregar.Enabled = true;
            BtnBuscar.Enabled = false;

            txtCedula.Enabled = false;
        }

        private void LimpioFormulario()
        {
            BtnAgregar.Enabled = false;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;

            BtnBuscar.Enabled = true;

            txtCedula.Enabled = true;

            txtCedula.Text = "0";
            txtNombre.Text = "";
            txtBarrio.Text = "";
            txtCalle.Text = "";
            Txtnumero.Text = "0";
            txttel.Text = "0";
            lblError.Text = "";
            DropDownList1.Items.Clear();
        }

        protected void Btnci_Click(object sender, EventArgs e)
        {
           
            try
            {
                Alumno unA = LogicaAlumno.Buscar(Convert.ToInt32(txtCedula.Text));
                if (unA != null)
                {

                    this.ActivoBotonesBM();
                    txtNombre.Text = unA.Nombre;
                    txtBarrio.Text = unA.Barrio;
                    txtCalle.Text = unA.Calle;
                    Txtnumero.Text = Convert.ToString(unA.Num);
                    DropDownList1.DataSource = LogicaAlumno.ListarTelefono(Convert.ToInt32(txtCedula.Text));
                    DropDownList1.DataTextField = "NumeroTelefono";
                    DropDownList1.DataValueField = "NumeroTelefono";
                    DropDownList1.DataBind();
                }

                else
                {
                    lblError.Text = "No hay Alumnos Con esa Cedula ";
                    this.ActivoBotonesAlta();
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
              
                Alumno unA = new Alumno(Convert.ToInt32(txtCedula.Text), txtNombre.Text, txtCalle.Text, Convert.ToInt32(Txtnumero.Text), txtBarrio.Text);
                
                LogicaAlumno.AgregarAlumno(unA);

                this.LimpioFormulario();
                lblError.Text = "Alta De Alumno con Exito";
                //limpio pantalla
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno unA = LogicaAlumno.Buscar(Convert.ToInt32(txtCedula.Text));
                LogicaAlumno.Eliminar(unA);
                this.LimpioFormulario();
                lblError.Text = "Se Elimino con Exito !!!";
                
                
            }
            catch (Exception ex )
            {
                
               lblError.Text= ex.Message;
            }
        }

        protected void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno unA = LogicaAlumno.Buscar(Convert.ToInt32(txtCedula.Text));
                unA.Cedula = Convert.ToInt32(txtCedula.Text);
                unA.Nombre = txtNombre.Text;
                unA.Calle = txtCalle.Text;
                unA.Num = Convert.ToInt32(Txtnumero.Text);
                unA.Barrio = txtBarrio.Text;
                LogicaAlumno.Editar(unA);

                this.LimpioFormulario();
                lblError.Text = "Edicion Exitosa !!";
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        protected void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpioFormulario();
        }

        protected void btnagregarTel_Click(object sender, EventArgs e)
        {
            try
            {

                Telefono unT = new Telefono(Convert.ToInt32(txttel.Text));
                int ci = Convert.ToInt32(txtCedula.Text);
                LogicaAlumno.AgregarTelefono(ci, unT);
               
                    DropDownList1.DataSource = LogicaAlumno.ListarTelefono(Convert.ToInt32(txtCedula.Text));
                DropDownList1.DataTextField = "NumeroTelefono";
                DropDownList1.DataValueField = "NumeroTelefono";
                DropDownList1.DataBind();
                this.LimpioFormulario();
                lblError.Text = "Se agrego telefono con exito";
                
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;

            }
        }

        protected void btnver_Click(object sender, EventArgs e)
        {
            txttel.Text = DropDownList1.SelectedItem.ToString();
        }

        protected void btnEt_Click(object sender, EventArgs e)
        {  try
            {
                LogicaAlumno.EliminarTel(Convert.ToInt32(txttel.Text));
                
                DropDownList1.DataSource = LogicaAlumno.ListarTelefono(Convert.ToInt32(txtCedula.Text));
                DropDownList1.DataTextField = "NumeroTelefono";
                DropDownList1.DataValueField = "NumeroTelefono";
                DropDownList1.DataBind();
                this.LimpioFormulario();
                lblError.Text = "Se Elimino con exito";
            }
            catch(Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
    }
}