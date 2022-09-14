using System.Data;
using System;
using System.Data.SqlClient;
using Entidad;

namespace Dato
{
    public class conexion
    {
        //cadena de conexion 
        private string conexionString
            = "Data Source=SM-NFEDIUK\\SQLEXPRESS;Initial Catalog=CrudAdoNetProductos;Integrated Security=True";

        //para probar la conexion 
        public bool ok()
        {
            try
            {
                SqlConnection connection = new SqlConnection(conexionString);
                connection.Open();
            }
            catch
            {
                return false;
            }
            return true;

        }


        //llenar el gv 
        public List<Producto> GetProducto()
        {
            List<Producto> producto = new List<Producto> ();

            string query = "select Id_prod,Nombre_prod,Precio_prod from Productos";

            using (SqlConnection connection = new SqlConnection(conexionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    //para lectura 
                    SqlDataReader reader = command.ExecuteReader();
                    //lee hasta que exista un registro
                    while (reader.Read())
                    {
                        Producto p = new Producto();
                        p.Id = reader.GetInt32(0);
                        p.Nombre = reader.GetString(1);
                        p.Precio = reader.GetDecimal(2);

                        producto.Add(p);

                    }
                    reader.Close();
                    connection.Close();
                }
                catch(Exception ex)
                {
                    throw new Exception("hay un error en la BD: "+ex.Message);
                }
            }

            return producto;
        }

        //agregar producto
        public void Add(string nombre, decimal precio)
        {
            string query = "insert into Productos(nombre_prod, precio_prod) select @nombre,@precio";

            using (SqlConnection connection = new SqlConnection(conexionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@precio", precio);

                try
                {
                    connection.Open();

                    command.ExecuteNonQuery();
                    
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("hay un error en la BD: " + ex.Message);
                }
            }
        }

        //editar producto
        public void Edit(string nombre, decimal precio, int id)
        {
            string query = "update Productos set nombre_prod=@nombre, precio_prod=@precio where Id_prod="+id;

            using (SqlConnection connection = new SqlConnection(conexionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@precio", precio);

                try
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("hay un error en la BD: " + ex.Message);
                }
            }
        }

        //eliminar producto
        public void Delete(int id)
        {
            string query = "delete from Productos where Id_prod=" + id;

            using (SqlConnection connection = new SqlConnection(conexionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("hay un error en la BD: " + ex.Message);
                }
            }
        }

        //retornar el nombre y precio del producto con el id
        public Producto GetProducto(int? id)
        {
            List<Producto> producto = new List<Producto>();

            string query = "select Id_prod,Nombre_prod,Precio_prod from Productos where Id_prod="+id;

            using (SqlConnection connection = new SqlConnection(conexionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    //para lectura 
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();

                    Producto p = new Producto();

                    p.Id = reader.GetInt32(0);
                    p.Nombre = reader.GetString(1);
                    p.Precio = reader.GetDecimal(2);

                    reader.Close();

                    connection.Close();

                    return p;
                    
                }
                catch (Exception ex)
                {
                    throw new Exception("hay un error en la BD: " + ex.Message);
                }
            }
        }

        //para ver si ya hay un producto existente
        public bool verificarProducto(string nombre)
        {
            string query = "select Nombre_prod from Productos";

            using (SqlConnection connection = new SqlConnection(conexionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                //para lectura 
                SqlDataReader reader = command.ExecuteReader();
                //lee hasta que exista un registro
                while (reader.Read())
                {
                    if(nombre == reader.GetString(0))
                    {
                        return true;
                    }
                }
                return false;

            }
        }
    }
}