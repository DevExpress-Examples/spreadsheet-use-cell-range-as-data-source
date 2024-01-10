using DevExpress.XtraGauges.Base;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraGauges.Core.Primitive;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RangeDataSource {
    public static class GaugeHelper {
      public static void CalculateMouseValue(IGaugeContainer container, IConvertibleScaleEx scale, MouseEventArgs e) {
            BasePrimitiveHitInfo hi = container.CalcHitInfo(e.Location);
            if (hi.Element != null && !hi.Element.IsComposite) {
                PointF modelPt = MathHelper.PointToModelPoint(scale as DevExpress.XtraGauges.Core.Base.IElement<IRenderableElement>, new PointF(e.X, e.Y));
                float percent = scale.PointToPercent(modelPt);
                scale.Value = scale.PercentToValue(percent);
            }
        }
     public static void CheckCursor(IGaugeContainer container, System.Windows.Forms.MouseEventArgs e) {
            BasePrimitiveHitInfo hi = container.CalcHitInfo(e.Location);
            Cursor cursor = (hi.Element != null && !hi.Element.IsComposite) ?
                Cursors.Hand : Cursors.Default;
            if (((Control)container).Cursor != cursor)
                ((Control)container).Cursor = cursor;
        }
    }
}
