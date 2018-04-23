Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text

Namespace RangeDataSourceForSnap
    Public NotInheritable Class DataSourceHelper

        Private Sub New()
        End Sub

        Public Shared Function IsFieldExists(ByVal dataSource As Object, ByVal fieldName As String, ByVal reqType As Type) As Boolean
            Dim pdc As PropertyDescriptorCollection = DirectCast(dataSource, ITypedList).GetItemProperties(Nothing)
            For Each pd As PropertyDescriptor In pdc
                If pd.DisplayName = fieldName Then
                    If reqType Is Nothing OrElse pd.PropertyType = reqType Then
                        Return True
                    End If
                End If
            Next pd
            Return False
        End Function
    End Class
End Namespace
