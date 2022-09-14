namespace CRUDproductos
{
    partial class FormAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.txtNombre = new Krypton.Toolkit.KryptonTextBox();
            this.txtPrecio = new Krypton.Toolkit.KryptonTextBox();
            this.btnAgregar = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(79, 85);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(78, 25);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Nombre";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(79, 147);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(65, 25);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Precio";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(213, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 39);
            this.txtNombre.StateActive.Border.Color1 = System.Drawing.Color.Black;
            this.txtNombre.StateActive.Border.Color2 = System.Drawing.Color.Black;
            this.txtNombre.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNombre.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtNombre.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtNombre.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNombre.StateCommon.Border.Rounding = 20F;
            this.txtNombre.StateDisabled.Border.Color1 = System.Drawing.Color.Black;
            this.txtNombre.StateDisabled.Border.Color2 = System.Drawing.Color.Black;
            this.txtNombre.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(213, 133);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(125, 39);
            this.txtPrecio.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtPrecio.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtPrecio.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPrecio.StateCommon.Border.Rounding = 20F;
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(137, 222);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 31);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Values.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(115, 12);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(180, 31);
            this.kryptonLabel3.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateNormal.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateNormal.ShortText.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel3.TabIndex = 5;
            this.kryptonLabel3.Values.Text = "Agregar / Editar";
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 293);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.ForeColor = System.Drawing.Color.White;
            this.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.FormCustom3;
            this.HeaderStyle = Krypton.Toolkit.HeaderStyle.DockInactive;
            this.Name = "FormAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.Red;
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.Red;
            this.StateCommon.Header.Border.Color1 = System.Drawing.Color.Red;
            this.StateCommon.Header.Border.Color2 = System.Drawing.Color.Red;
            this.StateCommon.Header.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Header.Border.Rounding = 0F;
            this.StateCommon.Header.Border.Width = 0;
            this.StateCommon.Header.Content.LongText.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.LongText.Color2 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.StateCommon.Header.Content.LongText.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StateCommon.Header.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Text = "Día";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txtNombre;
        private Krypton.Toolkit.KryptonTextBox txtPrecio;
        private Krypton.Toolkit.KryptonButton btnAgregar;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
    }
}