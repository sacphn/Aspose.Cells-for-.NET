﻿Namespace KnowledgeBase.Benchmarking
    Public Class CreateAnExcelFileSingleWorksheet
        ' ExStart:1
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            Try
                CreateAsposeCellsFile(dataDir & Convert.ToString("CellsSample_out.xls"))
            Catch ex As Exception
                Console.WriteLine("Error: " + ex.Message)
            End Try
        End Sub

        Private Shared Sub CreateAsposeCellsFile(filename As String)
            Dim start As DateTime = DateTime.Now
            Dim workbook As New Workbook()
            Dim ws As Worksheet = workbook.Worksheets(0)
            For row As Integer = 0 To 9999
                For col As Integer = 0 To 29
                    ws.Cells(row, col).PutValue(row.ToString() + "," + col.ToString())
                Next
            Next
            workbook.Save(filename)
            Dim [end] As DateTime = DateTime.Now
            Dim time As TimeSpan = [end] - start
            Console.WriteLine("File Created! " & vbLf + "Time consumed (Seconds): " + time.TotalSeconds.ToString())
        End Sub
        ' ExEnd:1
    End Class
End Namespace