Imports DevExpress.XtraGauges.Base
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Core.Primitive
Imports System.Drawing
Imports System.Windows.Forms

Namespace RangeDataSource

    Public Module GaugeHelper

        Public Sub CalculateMouseValue(ByVal container As IGaugeContainer, ByVal scale As IConvertibleScaleEx, ByVal e As MouseEventArgs)
            Dim hi As BasePrimitiveHitInfo = container.CalcHitInfo(e.Location)
            If hi.Element IsNot Nothing AndAlso Not hi.Element.IsComposite Then
                Dim modelPt As PointF = MathHelper.PointToModelPoint(TryCast(scale, DevExpress.XtraGauges.Core.Base.IElement(Of IRenderableElement)), New PointF(e.X, e.Y))
                Dim percent As Single = scale.PointToPercent(modelPt)
                scale.Value = scale.PercentToValue(percent)
            End If
        End Sub

        Public Sub CheckCursor(ByVal container As IGaugeContainer, ByVal e As MouseEventArgs)
            Dim hi As BasePrimitiveHitInfo = container.CalcHitInfo(e.Location)
            Dim cursor As Cursor = If(hi.Element IsNot Nothing AndAlso Not hi.Element.IsComposite, Cursors.Hand, Cursors.Default)
            If CType(container, Control).Cursor IsNot cursor Then CType(container, Control).Cursor = cursor
        End Sub
    End Module
End Namespace
