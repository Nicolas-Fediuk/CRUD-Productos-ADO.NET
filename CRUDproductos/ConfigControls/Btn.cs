using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krypton.Toolkit;

namespace CRUDproductos.ConfigControls
{
    public class Btn 
    {
        public void ConfigureControl(object control)
        {
            if(!(control is KryptonButton))
            {
                return;
            }


            KryptonButton _btn = (KryptonButton)control;
            _btn.Cursor = System.Windows.Forms.Cursors.Hand;
            _btn.OverrideDefault.Back.Color1 = System.Drawing.Color.Red;
            _btn.OverrideDefault.Back.Color2 = System.Drawing.Color.Red;
            _btn.OverrideDefault.Back.ColorAngle = 45F;
            _btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Red;
            _btn.OverrideDefault.Border.Color2 = System.Drawing.Color.Red;
            _btn.OverrideDefault.Border.ColorAngle = 45F;
            _btn.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            _btn.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            _btn.OverrideDefault.Border.Rounding = 20F;
            _btn.OverrideDefault.Border.Width = 1;
            _btn.Size = new System.Drawing.Size(139, 41);
            _btn.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            _btn.StateCommon.Back.Color2 = System.Drawing.Color.Red;
            _btn.StateCommon.Back.ColorAngle = 45F;
            _btn.StateCommon.Border.Color1 = System.Drawing.Color.Red;
            _btn.StateCommon.Border.Color2 = System.Drawing.Color.Red;
            _btn.StateCommon.Border.ColorAngle = 45F;
            _btn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            _btn.StateCommon.Border.Rounding = 20F;
            _btn.StateCommon.Border.Width = 1;
            _btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            _btn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            _btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _btn.StatePressed.Back.Color1 = System.Drawing.Color.Red;
            _btn.StatePressed.Back.Color2 = System.Drawing.Color.Red;
            _btn.StatePressed.Back.ColorAngle = 135F;
            _btn.StatePressed.Border.Color1 = System.Drawing.Color.Red;
            _btn.StatePressed.Border.Color2 = System.Drawing.Color.Red;
            _btn.StatePressed.Border.ColorAngle = 135F;
            _btn.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            _btn.StatePressed.Border.Rounding = 20F;
            _btn.StatePressed.Border.Width = 1;
            _btn.StateTracking.Back.Color1 = System.Drawing.Color.White;
            _btn.StateTracking.Back.Color2 = System.Drawing.Color.White;
            _btn.StateTracking.Back.ColorAngle = 45F;
            _btn.StateTracking.Border.Color1 = System.Drawing.Color.Red;
            _btn.StateTracking.Border.Color2 = System.Drawing.Color.Red;
            _btn.StateTracking.Border.ColorAngle = 45F;
            _btn.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            _btn.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            _btn.StateTracking.Border.Rounding = 20F;
            _btn.StateTracking.Border.Width = 1;
            _btn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            _btn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.BlanchedAlmond;
        }
    }
}
