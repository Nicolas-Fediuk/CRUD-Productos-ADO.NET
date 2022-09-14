namespace Entidad
{
    public class Producto
    {
        private int id;
        private string nombre;
        private decimal precio;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio { get => precio; set => precio = value; }
    }
}