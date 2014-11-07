'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Cells. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace SortDataExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			'Instantiating a Workbook object
			'Open an Excel file
			Dim workbook As New Workbook(dataDir & "Book_SourceData.xlsx")

			'Accessing the first worksheet in the Excel file
			Dim worksheet As Worksheet = workbook.Worksheets(0)

			'Get the cells collection in the sheet
			Dim cells As Cells = worksheet.Cells

			'Obtain the DataSorter object in the workbook
			Dim sorter As DataSorter = workbook.DataSorter

			'Set the first order
			sorter.Order1 = Aspose.Cells.SortOrder.Ascending
			'Define the first key.
			sorter.Key1 = 0
			'Set the second order
			sorter.Order2 = Aspose.Cells.SortOrder.Ascending
			'Define the second key
			sorter.Key2 = 1

			'Create a cells area (range).
			Dim ca As New CellArea()

			'Specify the start row index.
			ca.StartRow = 1
			'Specify the start column index.
			ca.StartColumn = 0
			'Specify the last row index.
			ca.EndRow = 9
			'Specify the last column index.
			ca.EndColumn = 2

			'Sort data in the specified data range (A2:C10)
			sorter.Sort(workbook.Worksheets(0).Cells, ca)

			'Saving the excel file in the default (that is Excel 2003) format
			workbook.Save(dataDir & "outBook_SortedData.xlsx")

		End Sub
	End Class
End Namespace