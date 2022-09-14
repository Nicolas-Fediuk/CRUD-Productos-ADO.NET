using Krypton.Toolkit;
using Dato;
using Entidad;
using CRUDproductos.ConfigControls;
namespace CRUDproductos
{
    public partial class Form1 : KryptonForm
    {
        conexion dao = new conexion();
        Producto p = new Producto();
        public Form1()
        {
            InitializeComponent();
            Btn _btn = new Btn();
            _btn.ConfigureControl(kryptonButton2);
            _btn.ConfigureControl(kryptonButton1);
            _btn.ConfigureControl(btnEditar);
            _btn.ConfigureControl(btnEliminar);

        }

        //para actualizar la tabla
        private void Refresh()
        {
            gvProductos.DataSource = dao.GetProducto();
        }

        //al cargar la pagina actializa l tabla
        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        //boton de refrescar
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            FormAdd add = new FormAdd();
            //hacer una accion si o si en este form para hacer algo en el anterior
            add.ShowDialog();
            Refresh();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // id = tendra el id del producto seleccionado o nulo
            int? id = GetId();
            if (id != null)
            {
                // le paso el id para que el constructor lo reciba 
                FormAdd add = new FormAdd(id);
                add.ShowDialog();
                Refresh();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            try
            {
                if (id != null)
                {
                    dao.Delete((int)id);
                    Refresh();
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("Error en la BD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }


        //una region 
        #region HELPER

        //entero o nulo 
        private int? GetId()
        {
            try
            {
                //para que al seleccionar la tabla me traiga el id de producto seleccionado 
                //en el grid, en la fila tal, traele el valor de esa posicion 
                return int.Parse(gvProductos.Rows[gvProductos.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch 
            {
                return null;
            }
            
        }



        #endregion


    }
}