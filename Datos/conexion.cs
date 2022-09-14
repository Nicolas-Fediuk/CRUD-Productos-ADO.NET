using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class conexion
    {
        private string conexionString 
            = "Data Source=SM-NFEDIUK\\SQLEXPRESS;Initial Catalog=CrudAdoNetProductos;" +
              "User=CLADDCOMAR\nfediuk";

        public bool ok()
        {
            try
            {
                SqlConnection connetion = new SqlConnection(conexionString);
                connetion.Open();
            }
            catch
            {
                return false;
            }
            return true;
            
        }
    }
}