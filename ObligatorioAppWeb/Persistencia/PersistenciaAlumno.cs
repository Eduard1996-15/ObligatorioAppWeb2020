using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using EntidadesCompartidas;


namespace Persistencia
{
    public class PersistenciaAlumno
    {
        public static void AgregarAlumno(Alumno nAlumno)
        {
            SqlConnection oConexion = new SqlConnection(Conexion.STR);
            SqlCommand oComando = new SqlCommand("SP_AGREGAR_ALUMNO", oConexion)
            {
                CommandType = CommandType.StoredProcedure
            };

            //@CI, @NOMBRE, @CALLE, @NUMERO, @BARRIO, @NUMERO_TEL
            oComando.Parameters.AddWithValue("@CI ", nAlumno.Cedula);
            oComando.Parameters.AddWithValue("@NOMBRE ", nAlumno.Nombre);
            oComando.Parameters.AddWithValue("@CALLE ", nAlumno.Calle);
            oComando.Parameters.AddWithValue("@NUMERO ", nAlumno.Num);
            oComando.Parameters.AddWithValue("@BARRIO ", nAlumno.Barrio);

            SqlParameter oRetorno = new SqlParameter("@Retorno", SqlDbType.Int);
            oRetorno.Direction = ParameterDirection.ReturnValue;
            oComando.Parameters.Add(oRetorno);


            try
            {
                oConexion.Open();
                oComando.ExecuteNonQuery();

                int oAfectados = (int)oComando.Parameters["@Retorno"].Value;

                if (oAfectados == -1)
                    throw new Exception("YA EXISTE UN ALUMNO CON ESA CEDULA");
                else if (oAfectados == -2)
                    throw new Exception("ERROR DE INSERCION");


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

        public static void AgregarTelefono(int ci, Telefono unT)
        {
            SqlConnection oConexion = new SqlConnection(Conexion.STR);
            SqlCommand oComando = new SqlCommand("SP_AGREGAR_TEL", oConexion)
            {
                CommandType = CommandType.StoredProcedure
            };

            //@CI, @NOMBRE, @CALLE, @NUMERO, @BARRIO, @NUMERO_TEL
            oComando.Parameters.AddWithValue("@CI ", ci);
            oComando.Parameters.AddWithValue("@NUMERO_TEL", unT.NumeroTelefono);

            SqlParameter oRetorno = new SqlParameter("@Retorno", SqlDbType.Int);
            oRetorno.Direction = ParameterDirection.ReturnValue;
            oComando.Parameters.Add(oRetorno);


            try
            {
                oConexion.Open();
                oComando.ExecuteNonQuery();

                int oAfectados = (int)oComando.Parameters["@Retorno"].Value;
                if (oAfectados == -1)
                    throw new Exception("NO SE PUEDEN REPETIR LOS TELEFONOS");
                else  if (oAfectados == -2)
                    throw new Exception("ERROR DE INSERCION");


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
        public static void Eliminar(Alumno nAlumno)
        {
            //comando a ejecutar
            SqlConnection _Conexion = new SqlConnection(Conexion.STR);
            SqlCommand _Comando = new SqlCommand("SP_ELIMINAR_ALUMNO", _Conexion);
            _Comando.CommandType = CommandType.StoredProcedure;

            //parametros 
            SqlParameter _cedula = new SqlParameter("@CI", nAlumno.Cedula);

            SqlParameter _Retorno = new SqlParameter("@Retorno", SqlDbType.Int);
            _Retorno.Direction = ParameterDirection.ReturnValue;

            _Comando.Parameters.Add(_cedula);
            _Comando.Parameters.Add(_Retorno);

            try
            {
                _Conexion.Open();
                _Comando.ExecuteNonQuery();

                //determino devolucion del SP
                int oAfectados = (int)_Comando.Parameters["@Retorno"].Value;

                if (oAfectados == -1)
                    throw new Exception("NO EXISTE ALUMNO CON ESA CEDULA");
                else if (oAfectados == -2)
                    throw new Exception("ERROR AL ELIMINAR INSCRIPCION");
                else if (oAfectados == -3)
                    throw new Exception("ERROR AL ELIMINAR TELEFONO");
                else if (oAfectados == -4)
                    throw new Exception("ERROR AL ELIMINAR ALUMNO");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _Conexion.Close();
            }
        }

        public static void EliminarTel(int numero)
        {
            //comando a ejecutar
            SqlConnection _Conexion = new SqlConnection(Conexion.STR);
            SqlCommand _Comando = new SqlCommand("SP_ELIMINARTEL", _Conexion);
            _Comando.CommandType = CommandType.StoredProcedure;

            //parametros 
            SqlParameter unmun = new SqlParameter("@NUMERO_TEL", numero);

            _Comando.Parameters.Add(unmun);

            try
            {
                _Conexion.Open();
                _Comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _Conexion.Close();
            }
        }

        public static List<Alumno> ListarAlumnos()
        {
            
            List<Alumno> oListaAlumno = new List<Alumno>();
           
            SqlDataReader oReader;
            SqlConnection oConexion = new SqlConnection(Conexion.STR);
            SqlCommand oComando = new SqlCommand("SP_lISTADO_ALUMNOS", oConexion);

            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();
                if (oReader.HasRows)
                {
                    while(oReader.Read())

                    { 
                                int _CI = (int)oReader["CI"];
                                string _Nombre = (string)oReader["NOMBRE"];
                                string _calle = (string)oReader["CALLE"];
                                int _Numero = (int)oReader["NUMERO"];
                                string barrio = (string)oReader["BARRIO"];
                        Alumno unAl = new Alumno(_CI, _Nombre, _calle, _Numero, barrio);
                               oListaAlumno.Add(unAl);
                    }
                    
                    oReader.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Problemas con la base de datos:" + ex.Message);
            }
            finally
            {
                oConexion.Close();
            }
            return oListaAlumno;

        }

        public static void Editar(Alumno unA)
        {
            SqlConnection _Conexion = new SqlConnection(Conexion.STR);
            SqlCommand oComando = new SqlCommand("SP_EDITAR_ALUMNO", _Conexion);
            oComando.CommandType = CommandType.StoredProcedure;

            oComando.Parameters.AddWithValue("@CI", unA.Cedula);
            oComando.Parameters.AddWithValue("@NOMBRE", unA.Nombre);
            oComando.Parameters.AddWithValue("@CALLE", unA.Calle);
            oComando.Parameters.AddWithValue("@NUMERO", unA.Num);
            oComando.Parameters.AddWithValue("@BARRIO", unA.Barrio);


            SqlParameter _Retorno = new SqlParameter("@Retorno", SqlDbType.Int);
            _Retorno.Direction = ParameterDirection.ReturnValue;
            oComando.Parameters.Add(_Retorno);

            try
            {
                _Conexion.Open();
                oComando.ExecuteNonQuery();

                int oAfectados = (int)oComando.Parameters["@Retorno"].Value;

                if (oAfectados == -2)
                    throw new Exception("ERROR DE EDICION");

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _Conexion.Close();
            }
        }

        public static Alumno Buscar(int pCedula)
        {
            Alumno A = null;
            SqlDataReader oReader;

            SqlConnection oConexion = new SqlConnection(Conexion.STR);
            SqlCommand oComando = new SqlCommand("Exec SP_BUSCAR_ALUMNO " + pCedula, oConexion);

            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();

                if (oReader.Read())
                {
                    pCedula = (int)oReader["CI"];
                    string _Nombre = (string)oReader["NOMBRE"];
                    string _calle = (string)oReader["CALLE"];
                    int _Numero = (int)oReader["NUMERO"];
                    string barrio = (string)oReader["BARRIO"];
                    A = new Alumno(pCedula, _Nombre, _calle, _Numero, barrio);

                }

                oReader.Close();

            }
            catch (Exception ex)
            {
                throw new Exception( "Probemas por base de datos " + ex.Message);
            }
            finally
            {
                oConexion.Close();
            }

            return A;
        }

        public static List<Telefono> ListarTelefono(int cedula)
        {
            List<Telefono> oListaTEL = new List<Telefono>();
            SqlDataReader oReader;
            SqlConnection oConexion = new SqlConnection(Conexion.STR);
            SqlCommand oComando = new SqlCommand("SP_LISTAR_TELEFONOS " + cedula, oConexion);

            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();
                if (oReader.HasRows)
                {
                    while (oReader.Read())
                    {
                        //@idinscripcion, @IDE, @CI, @FECHA_INS, @NOMBRE_EMP
                        int _NumTEL = (int)oReader["NUMERO_TEL"];

                        Telefono unt;
                        unt = new Telefono(_NumTEL);

                        oListaTEL.Add(unt);

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
            return oListaTEL;

        }

    }
}
