Imports System
Imports System.ComponentModel

Namespace RangeDataSource

    Public Module DataSourceHelper

        Public Function IsFieldExists(ByVal dataSource As Object, ByVal fieldName As String, ByVal reqType As Type) As Boolean
            Dim pdc As PropertyDescriptorCollection = CType(dataSource, ITypedList).GetItemProperties(Nothing)
            For Each pd As PropertyDescriptor In pdc
                If Equals(pd.DisplayName, fieldName) Then
                    If reqType Is Nothing OrElse pd.PropertyType Is reqType Then Return True
                End If
            Next

            Return False
        End Function
    End Module
End Namespace
