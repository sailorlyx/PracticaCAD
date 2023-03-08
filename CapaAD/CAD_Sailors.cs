using System.Data;
using System.Data.SqlClient;

namespace CapaAD
{
        public class CD_Productos
        {
            private CAD_Conexion conexion = new CAD_Conexion();

            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();

            public DataTable Mostrar()
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "MostrarSailor";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.CerrarConexion();
                return tabla;

            }

            public void Insertar(string nombre, string planeta)
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "InsertarSailor";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@planeta", planeta);

                comando.ExecuteNonQuery();

                comando.Parameters.Clear();
                conexion.CerrarConexion();

            }

            public void Editar(string nombre, string planeta, int id)
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "EditarSailor";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@planeta", planeta);
                comando.Parameters.AddWithValue("@id", id);

                comando.ExecuteNonQuery();

                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }

            public void Eliminar(int id)
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "EliminarSailor";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idpro", id);

                comando.ExecuteNonQuery();

                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }

        }
 }
