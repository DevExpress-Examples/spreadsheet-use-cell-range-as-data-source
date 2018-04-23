Imports DevExpress.XtraGauges.Base
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Core.Primitive
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace RangeDataSourceForSnap
    Public NotInheritable Class GaugeHelper

        Private Sub New()
        End Sub

      Public Shared Sub CalculateMouseValue(ByVal container As IGaugeContainer, ByVal scale As IConvertibleScaleEx, ByVal e As MouseEventArgs)
            Dim hi As BasePrimitiveHitInfo = container.CalcHitInfo(e.Location)
            If hi.Element IsNot Nothing AndAlso (Not hi.Element.IsComposite) Then
                Dim modelPt As PointF = MathHelper.PointToModelPoint(TryCast(scale, DevExpress.XtraGauges.Core.Base.IElement(Of IRenderableElement)), New PointF(e.X, e.Y))
                Dim percent As Single = scale.PointToPercent(modelPt)
                scale.Value = scale.PercentToValue(percent)
            End If
      End Sub
     Public Shared Sub CheckCursor(ByVal container As IGaugeContainer, ByVal e As System.Windows.Forms.MouseEventArgs)
            Dim hi As BasePrimitiveHitInfo = container.CalcHitInfo(e.Location)
            Dim cursor As Cursor = If(hi.Element IsNot Nothing AndAlso (Not hi.Element.IsComposite), Cursors.Hand, Cursors.Default)
            If DirectCast(container, Control).Cursor IsNot cursor Then
                DirectCast(container, Control).Cursor = cursor
            End If
     End Sub
    End Class
End Namespace
