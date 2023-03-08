using System.Data.SqlClient;
using System.Data;

namespace CapaAD
{
    public class CAD_Conexion
    {
        private SqlConnection Conexion = new SqlConnectionConnection("Server=LAPTOP-GGTKFVHF\\SQLEXPRESS;Database=PracticaSailor;Integrated Security=true");
        
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close(); 
            return Conexion;
        }
    }