Imports DevExpress.Spreadsheet
Imports System

Namespace RangeDataSource

#Region "#MyColumnDetector"
    Friend Class MyColumnDetector
        Implements IDataSourceColumnTypeDetector

        Public Function GetColumnName(ByVal index As Integer, ByVal offset As Integer, ByVal range As CellRange) As String Implements IDataSourceColumnTypeDetector.GetColumnName
            If offset > 3 Then Return String.Format("Column{0}", index)
            Dim names As String() = {"City", "Year", "Month", "Temperature"}
            Return names(index)
        End Function

        Public Function GetColumnType(ByVal index As Integer, ByVal offset As Integer, ByVal range As CellRange) As Type Implements IDataSourceColumnTypeDetector.GetColumnType
            Dim defaultType As Type = GetType(String)
            Dim value As CellValue = range(0, offset).Value
            If value.IsText Then Return GetType(String)
            If value.IsBoolean Then Return GetType(Boolean)
            If value.IsDateTime Then Return GetType(Date)
            If value.IsNumeric Then Return GetType(Double)
            Return defaultType
        End Function
    End Class
#End Region  ' #MyColumnDetector
End Namespace
