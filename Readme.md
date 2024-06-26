<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128613361/16.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T483776)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/RangeDataSourceForSnap/Form1.cs) (VB: [Form1.vb](./VB/RangeDataSourceForSnap/Form1.vb))
* [MyColumnDetector.cs](./CS/RangeDataSourceForSnap/MyColumnDetector.cs) (VB: [MyColumnDetector.vb](./VB/RangeDataSourceForSnap/MyColumnDetector.vb))
<!-- default file list end -->
# An example of using a cell range as a data source


This example demonstrates how to select a worksheet range and use it as a data source for <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument11373">Snap reports</a>, <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument18226">Linear Gauge</a> and <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument634">Data Grid</a> controls.<br>Select the range containing data and click Provide Data to Snap. The data source will be created and passed to Snap reports and other data-aware controls. Switch to the Snap tab to view the report and to the Thermometer tab to see the linear gauge and a grid controls bound to the worksheet range.<br><img src="https://raw.githubusercontent.com/DevExpress-Examples/an-example-of-using-a-cell-range-as-a-data-source-t483776/16.2.5+/media/aae2b7c2-fcf5-11e6-80bf-00155d62480c.png"><br>The data binding range is created by calling the <a href="http://help.devexpress.com/#CoreLibraries/DevExpressSpreadsheetRange_GetDataSourcetopic">Range.GetDataSource</a> method. The <a href="http://help.devexpress.com/#CoreLibraries/DevExpressSpreadsheetRangeDataSourceOptions_UseFirstRowAsHeadertopic">UseFirstRowAsHeader</a> option allows to automatically name columns in the data source. The <a href="http://help.devexpress.com/#CoreLibraries/DevExpressSpreadsheetRangeDataSourceOptions_DataSourceColumnTypeDetectortopic">DataSourceColumnTypeDetector</a> option is used for specifying a custom object that provides column names and determines column types. The <a href="http://help.devexpress.com/#CoreLibraries/DevExpressSpreadsheetWorksheetDataBindingCollection_Errortopic">DataBindingCollection.Error</a> event is handled to obtain additional information if any error occurs during data binding.

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-spreadsheet-use-cell-range-as-data-source&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-spreadsheet-use-cell-range-as-data-source&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
