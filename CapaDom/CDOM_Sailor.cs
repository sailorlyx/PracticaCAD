using CapaAD;
using System.Data;

namespace CapaDom
{
    public class CDOM_Sailor
    {
            private CAD_Sailors objetoCapaDom = new CAD_Sailors();

            public DataTable MostrarSailorCDOM()
            {

                DataTable tabla = new DataTable();
                tabla = objetoCapaDom.Mostrar();
                return tabla;
            }
            public void InsertarSailorCDOM(string nombre, string planeta)
            {

                objetoCapaDom.Insertar(nombre, planeta);
            }

            public void EditarSailorCDOM(string nombre, string planeta)
            {
                objetoCapaDom.Editar(nombre, planeta);
            }

            public void EliminarSailorCDOM(int id)
            {

                objetoCapaDom.Eliminar(Convert.ToInt32(id));
            }

        }
    }