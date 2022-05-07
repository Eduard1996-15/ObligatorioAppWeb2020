using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using EntidadesCompartidas;
using System.Runtime.Remoting.Messaging;

namespace Persistencia
{
    public class PersistenciaInscripcion
    {
        public static void AgregarInscripcion(Inscripcion nInscripcion)
        {
            SqlConnection oConexion = new SqlConnection(Conexion.STR);
            SqlCommand oComando = new SqlCommand("SP_Agregar_Inscripcion", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;


            oComando.Parameters.AddWithValue("@IDE", nInscripcion.IDE);
            oComando.Parameters.AddWithValue("@CI", nInscripcion.CedulaAlumno);
            oComando.Parameters.AddWithValue("@FECHA_INS", nInscripcion.Fecha);
            oComando.Parameters.AddWithValue("@NOMBRE_EMP", nInscripcion.Empleado);

            SqlParameter oRetorno = new SqlParameter("@Retorno", SqlDbType.Int);
            oRetorno.Direction = ParameterDirection.ReturnValue;
            oComando.Parameters.Add(oRetorno);

            try
            {
                oConexion.Open();
                oComando.ExecuteNonQuery();
                if ((int)oRetorno.Value == -1)
                    throw new Exception("Ya Existe una inscripcion para ese alumno en ese curso");
                else if ((int)oRetorno.Value == -2)
                    throw new Exception("Error de Insercion de datos \n puede ser IDE no encontrado o CI invalida ");
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                oConexion.Close();

            }

        }

        public static  List<Inscripcion> ListarInscripcionXCurso(string  IDE)
        {
           
            

            List<Inscripcion> oListaInscripcion = new List<Inscripcion>();
            SqlDataReader oReader;
            SqlConnection oConexion = new SqlConnection(Conexion.STR);
            SqlCommand oComando = new SqlCommand("exec LISTARINSCRIPCIONXCURSO " +  IDE, oConexion);

            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();
                if (oReader.HasRows)
                {
                    while (oReader.Read())
                    {
                        //@idinscripcion, @IDE, @CI, @FECHA_INS, @NOMBRE_EMP
                       
                        int _NumInscripcion = (int)oReader["IDINSCRIPCION"];
                        string _ide = (string)oReader["IDE"];
                        int Cedula = (int)oReader["CI"];
                        DateTime _Fecha = (DateTime)oReader["FECHA_INS"];
                        string _Empleado = (string)oReader["NOMBRE_EMP"];
                        Inscripcion ins;
                        ins = new Inscripcion(_NumInscripcion, Cedula, _Fecha, _Empleado, _ide);

                        oListaInscripcion.Add(ins);


                    }

                    oReader.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                oConexion.Close();
            }
            return oListaInscripcion;

        }

        public static List<Inscripcion> ListarPorAlumno(Alumno unA)
        {
            List<Inscripcion> olista = new List<Inscripcion>();
            SqlDataReader oReader;

            SqlConnection oConexion = new SqlConnection(Conexion.STR);
            SqlCommand oComando = new SqlCommand("SP_SP_LISTARINSCRIPCIONXALUMNO", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;

            oComando.Parameters.AddWithValue("@CI", unA.Cedula);

            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();

                if (oReader.HasRows)
                {
                    while (oReader.Read())
                    {
                        string ide = (string)oReader["IDE"];
                        int _NumInscripcion = (int)oReader["IDINSCRIPCION"];
                        DateTime _Fecha = (DateTime)oReader["FECHA_INS"];
                        string _Empleado = (string)oReader["NOMBRE_EMP"];

                       Inscripcion ins = new Inscripcion(_NumInscripcion, unA.Cedula, _Fecha, _Empleado, ide );

                        olista.Add(ins);
                    }
                }

                oReader.Close();

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Problemas con la base de datos:" + ex.Message);
            }
            finally
            {
                oConexion.Close();
            }

            return olista;
        }
    }

}

        
    

