using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using Dato;
using Entidad;
using CRUDproductos.ConfigControls;

namespace CRUDproductos
{
    
    public partial class FormAdd : KryptonForm
    {
        conexion dao = new conexion();

        //va a servir para saber si se va a editar o agregar uno nuevo 
        private int? Id;

        //es id por defauld va hacer null, si no mando nada es nulll
        public FormAdd(int? Id = null)
        {
            InitializeComponent();
            Btn _btn = new Btn();
            _btn.ConfigureControl(btnAgregar);

            this.Id = Id;
            //si es nuevo no trae el id, por lo tanto es null
            if(this.Id != null)
            {
                LoadData();
            }
        }

     
        private void LoadData()
        {
            //si edito, con el id, cargo los txt con el nombre y el precio 
           Producto p = dao.GetProducto(Id);
            txtNombre.Text = p.Nombre;
            txtPrecio.Text = p.Precio.ToString();
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Id == null)
            {
                //agrego un nuevo producto
                if (txtNombre.Text == "" || txtPrecio.Text == "")
                {
                    KryptonMessageBox.Show("Verifique los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dao.verificarProducto(txtNombre.Text))
                {
                    KryptonMessageBox.Show("El producto ingresado ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dao.Add(txtNombre.Text, Convert.ToDecimal(txtPrecio.Text));
            }
            else
            {
                //edito un producto
                dao.Edit(txtNombre.Text, Convert.ToDecimal(txtPrecio.Text), (int)Id);
            }

            this.Close();
            
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPrecio.Focus();
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAgregar.Focus();
            }
        }
    }
}
