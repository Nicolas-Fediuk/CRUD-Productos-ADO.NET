namespace CRUDproductos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gvProductos = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            this.btnEditar = new Krypton.Toolkit.KryptonButton();
            this.btnEliminar = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // gvProductos
            // 
            this.gvProductos.ColumnHeadersHeight = 36;
            this.gvProductos.Location = new System.Drawing.Point(182, 74);
            this.gvProductos.Name = "gvProductos";
            this.gvProductos.ReadOnly = true;
            this.gvProductos.RowHeadersVisible = false;
            this.gvProductos.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.gvProductos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvProductos.RowTemplate.Height = 29;
            this.gvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProductos.Size = new System.Drawing.Size(459, 246);
            this.gvProductos.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.gvProductos.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.gvProductos.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.gvProductos.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.gvProductos.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.Black;
            this.gvProductos.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gvProductos.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Red;
            this.gvProductos.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Red;
            this.gvProductos.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.gvProductos.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.Black;
            this.gvProductos.StateCommon.HeaderColumn.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gvProductos.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.gvProductos.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.gvProductos.StateCommon.HeaderColumn.Content.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Form;
            this.gvProductos.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gvProductos.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.gvProductos.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.gvProductos.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.White;
            this.gvProductos.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.White;
            this.gvProductos.StatePressed.HeaderRow.Back.Color1 = System.Drawing.Color.Red;
            this.gvProductos.StatePressed.HeaderRow.Back.Color2 = System.Drawing.Color.Red;
            this.gvProductos.StateSelected.HeaderRow.Back.Color1 = System.Drawing.Color.White;
            this.gvProductos.StateSelected.HeaderRow.Back.Color2 = System.Drawing.Color.White;
            this.gvProductos.TabIndex = 0;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(597, 373);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(112, 31);
            this.kryptonButton1.TabIndex = 1;
            this.kryptonButton1.Values.Text = "Refrescar";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton2.Location = new System.Drawing.Point(43, 373);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton2.TabIndex = 3;
            this.kryptonButton2.Values.Text = "Nuevo";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(228, 373);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 31);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Values.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(421, 373);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 31);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Values.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(252, 23);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(255, 31);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel1.TabIndex = 5;
            this.kryptonLabel1.Values.Text = "Control de productos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(762, 450);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.gvProductos);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.FormCustom3;
            this.HeaderStyle = Krypton.Toolkit.HeaderStyle.DockInactive;
            this.Name = "Form1";
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Krypton.Toolkit.KryptonDataGridView gvProductos;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton btnEditar;
        private Krypton.Toolkit.KryptonButton btnEliminar;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}