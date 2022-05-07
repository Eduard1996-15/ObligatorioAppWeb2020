using EntidadesCompartidas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace Persistencia
{
    public class PersistenciaCurso
    {

        public static void AgregarCursoCorto(CursoCorto nCursoCorto)
        {
           
            SqlConnection oConexion = new SqlConnection(Conexion.STR);
            SqlCommand oComando = new SqlCommand("SP_AGREGAR_CURSO_CORTO", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;


            oComando.Parameters.AddWithValue("@IDE ", nCursoCorto.IDE);
            oComando.Parameters.AddWithValue("@NOMBRE ", nCursoCorto.Nombre);
            oComando.Parameters.AddWithValue("@DURACION ", nCursoCorto.Duracion);
            oComando.Parameters.AddWithValue("@PRECIO ", nCursoCorto.Precio);
            oComando.Parameters.AddWithValue("@AREA_APLICACION ", nCursoCorto.AreaAplicacion);

            SqlParameter oRetorno = new SqlParameter("@Retorno", SqlDbType.Int);
            oRetorno.Direction = ParameterDirection.ReturnValue;
            oComando.Parameters.Add(oRetorno);

            try
            {
                oConexion.Open();
                oComando.ExecuteNonQuery();
                if ((int)oRetorno.Value == -1)
                    throw new Exception("Ya Existe un curso con ese ide ");
                else if ((int)oRetorno.Value == -2)
                    throw new Exception("Error de Insercion de datos ");
                else if ((int)oRetorno.Value == -3)
                    throw new Exception("Error de insecrcion de datos ide o Area Aplicacion");
                
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

        public static void AgregarCursoEspecializado(CursoEspecializado nCursoEsp)
        {
            SqlConnection oConexion = new SqlConnection(Conexion.STR);
            SqlCommand oComando = new SqlCommand("SP_AGREGAR_ESPECIALIZADO", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;


            oComando.Parameters.AddWithValue("@IDE ", nCursoEsp.IDE);
            oComando.Parameters.AddWithValue("@NOMBRE ", nCursoEsp.Nombre);
            oComando.Parameters.AddWithValue("@DURACION ", nCursoEsp.Duracion);
            oComando.Parameters.AddWithValue("@PRECIO ", nCursoEsp.Precio);
            oComando.Parameters.AddWithValue("@PRERREQUISITOS ", nCursoEsp.PreRequisitos);

            SqlParameter oRetorno = new SqlParameter("@Retorno", SqlDbType.Int);
            oRetorno.Direction = ParameterDirection.ReturnValue;
            oComando.Parameters.Add(oRetorno);

            try
            {
                oConexion.Open();
                oComando.ExecuteNonQuery();
                if ((int)oRetorno.Value == -1)
                    throw new Exception("Ya Existe un curso con ese ide ");
                else if ((int)oRetorno.Value == -2)
                    throw new Exception("Error de Insercion de datos ");
                else if ((int)oRetorno.Value == -3)
                    throw new Exception("Error de insecrcion de datos ide o Prerrequisitos");
                
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

        public static List<CursoCorto> listarCursoCorto()
        {
            CursoCorto unC;


            List<CursoCorto> oListaCursoCorto = new List<CursoCorto>();
            SqlDataReader oReader;
            SqlConnection oConexion = new SqlConnection(Conexion.STR);
            SqlCommand oComando = new SqlCommand("SP_LISTADO_CURSOCORTO", oConexion);


            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();
                if (oReader.HasRows)
                {
                    while (oReader.Read())
                    {
                        // @IDE VARCHAR(6),@NOMBRE INT,@DURACION TINYINT,@PRECIO INT,@AREA_APLICACION VARCHAR(50)
                        string _ide = (string)oReader["IDE"];
                        string _Nombre = (string)oReader["NOMBRE"];
                        byte duracion = (byte)oReader["DURACION"];
                        int precio = (int)oReader["PRECIO"];
                        string areaAp = (string)oReader["AREA_APLICACION"];
                        unC = new CursoCorto(_ide, _Nombre, duracion, precio, areaAp);

                        oListaCursoCorto.Add(unC);


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
            return oListaCursoCorto;




        }

        public static List<CursoEspecializado> ListarCursoEspecializado()
        {
            CursoEspecializado unCe;


            List<CursoEspecializado> oListaCursoEspecializado = new List<CursoEspecializado>();
            SqlDataReader oReader;
            SqlConnection oConexion = new SqlConnection(Conexion.STR);
            SqlCommand oComando = new SqlCommand("SP_LISTADO_CURSOESPECIALIZADO", oConexion);


            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();
                if (oReader.HasRows)
                {
                    while (oReader.Read())
                    {
                        // @IDE VARCHAR(6),@NOMBRE INT,@DURACION TINYINT,@PRECIO INT,@PRERREQUISITOS VARCHAR(100)
                        string _ide = (string)oReader["IDE"];
                        string _Nombre = (string)oReader["NOMBRE"];
                        byte duracion = (byte)oReader["DURACION"];
                        int precio = (int)oReader["PRECIO"];
                        string prerre = (string)oReader["PRERREQUISITOS"];
                        unCe = new CursoEspecializado(_ide, _Nombre, duracion, precio, prerre);

                        oListaCursoEspecializado.Add(unCe);


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
            return oListaCursoEspecializado;
        }

       
        public static CursoCorto BuscarCursoCorto(string Ide)
        {
            CursoCorto C = null;
            SqlDataReader oReader;

            SqlConnection oConexion = new SqlConnection(Conexion.STR);
            SqlCommand oComando = new SqlCommand("Exec BUSCAR_CURSOCORTO " + Ide, oConexion);

            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();

                if (oReader.Read())
                {
                    Ide = (string)oReader["IDE"];
                    string _Nombre = (string)oReader["NOMBRE"];
                    byte duracion = (byte)oReader["DURACION"];
                    int precio = (int)oReader["PRECIO"];
                    string areaApp = (string)oReader["AREA_APLICACION"];
                    C = new CursoCorto(Ide, _Nombre, duracion, precio, areaApp);

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

            return C;
        }

        public static CursoEspecializado BuscarCursoEsp(string Ide)
        {
            CursoEspecializado CE = null;
            SqlDataReader oReader;

            SqlConnection oConexion = new SqlConnection(Conexion.STR);
            SqlCommand oComando = new SqlCommand("Exec BUSCAR_ESPECIALIZQADO " + Ide, oConexion);

            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();

                if (oReader.Read())
                {
                     Ide = (string)oReader["IDE"];
                    string _Nombre = (string)oReader["NOMBRE"];
                    byte duracion = (byte)oReader["DURACION"];
                    int precio = (int)oReader["PRECIO"];
                    string prerre = (string)oReader["PRERREQUISITOS"];
                    CE = new CursoEspecializado(Ide, _Nombre, duracion, precio, prerre);

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

            return CE;
        }

        public static CursoEspecializado BuscarCurso(string Ide)
        {
            CursoEspecializado CE = null;
            SqlDataReader oReader;

            SqlConnection oConexion = new SqlConnection(Conexion.STR);
            SqlCommand oComando = new SqlCommand("SP_BUSCARCURSO" + Ide, oConexion);

            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();

                if (oReader.Read())
                {
                    Ide = (string)oReader["IDE"];
                    string _Nombre = (string)oReader["NOMBRE"];
                    byte duracion = (byte)oReader["DURACION"];
                    int precio = (int)oReader["PRECIO"];
                    string prerre = (string)oReader["PRERREQUISITOS"];
                    CE = new CursoEspecializado(Ide, _Nombre, duracion, precio, prerre);

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

            return CE;
        }
    }
}
