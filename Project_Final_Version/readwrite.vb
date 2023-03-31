Imports System.Text
Imports System.Xml
Imports System.IO

Public Class readwrite
    '' ''''''''''''''''' ''
    '' Parameters / Data ''
    '' '''''''''' '''''' ''

    Public ourFilePath As String
    Public savePath As String
    Public time() As Double
    Public voltage() As Double


    '' ''''''''''''''' ''
    '' Event Functions ''
    '' ''''''''''''''' ''

    Public Function getFilePath()
        Dim folderBrowserDialog As New FolderBrowserDialog()
        folderBrowserDialog.InitialDirectory = "C:\Users\WIN10\Desktop\Project"
        'ourDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"

        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            Return folderBrowserDialog.SelectedPath
        Else
            Return Nothing
        End If
    End Function

    Public Sub saveData(time As Double(), voltage As Double())
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "csv files (*.csv)|*.csv"

        If saveDialog.ShowDialog() = DialogResult.OK Then
            savePath = saveDialog.FileName
            writeData(saveDialog.FileName, time, voltage)
        End If
    End Sub


    '' '''''''''''''''''''''' ''
    '' Read / Write Functions ''
    '' '''''''''''''''''''''' ''

    'Read data
    Public Sub readFromeFile(inPath As String)

        'Define our temporary array lists
        Dim tempTime As New ArrayList()
        Dim tempVoltage As New ArrayList()

        'Define file reader
        Dim fileReader As System.IO.StreamReader

        'Open the file
        fileReader = My.Computer.FileSystem.OpenTextFileReader(inPath)

        'Read and ignore Headers
        Dim ourLine As String
        ourLine = fileReader.ReadLine()

        'Read Data
        Dim splitLine() As String
        Dim tempDouble As Double
        While (fileReader.Peek() <> -1)
            'Read whole line
            ourLine = fileReader.ReadLine()
            'Split the line by ,
            splitLine = ourLine.Split(",")
            'Convert string (1st colum) to Double and Add the converted number to time array
            tempDouble = Double.Parse(splitLine(0))
            tempTime.Add(tempDouble)
            'Convert String(2nd colum) to Double And Add the converted number to voltage array
            tempDouble = Double.Parse(splitLine(1))
            tempVoltage.Add(tempDouble)
        End While

        'Transfer data in temp array to actual data array
        ReDim time(0 To tempTime.Count() - 1)
        ReDim voltage(0 To tempTime.Count() - 1)
        For i As Long = 0 To tempTime.Count() - 1
            time(i) = tempTime(i)
            voltage(i) = tempVoltage(i)
        Next

    End Sub


    'Write data to a .csv file
    Public Sub writeData(inPath As String, time As Double(), voltage As Double())
        'Define Writer
        Dim myWriter As System.IO.StreamWriter
        'Open the file to write to
        Try
            myWriter = My.Computer.FileSystem.OpenTextFileWriter(inPath, False)
        Catch UnauthorizedAccessException As Exception
            MessageBox.Show("Access to directory is denied")
            Return
        End Try

        'Define the output line
        Dim outputLine As String
        'Start with headers
        outputLine = "Time(s),Voltage(V)"
        myWriter.WriteLine(outputLine)
        'Write the rest of the data
        If time IsNot Nothing And voltage IsNot Nothing Then
            Try
                For i As Long = 0 To time.Length - 1
                    outputLine = time(i) & "," & voltage(i)
                    myWriter.WriteLine(outputLine)
                Next
                myWriter.Close()
                'Feedback message box
                MessageBox.Show("Data Saved!")
            Catch ex As NullReferenceException
                MessageBox.Show("Empty data")
            End Try
        Else
            MessageBox.Show("Empty data")
        End If



    End Sub

    'Data writing function for intensity sweep section
    Public Sub writeDataIW(inPath As String, sweepData As List(Of Double()))
        Dim columnList As New List(Of List(Of Double))()
        For i As Integer = 0 To sweepData(0).Length - 1
            Dim columnData As New List(Of Double)()
            For Each row As Double() In sweepData
                columnData.Add(row(i))
            Next
            columnList.Add(columnData)
        Next

        ' Create a string builder to hold the CSV data
        Dim csvData As New StringBuilder()

        ' Append the column data to the string builder as CSV lines
        For Each column As List(Of Double) In columnList
            csvData.AppendLine(String.Join(",", column))
        Next

        ' Write the CSV data to a file
        Dim fileName As String = "data.csv"
        File.WriteAllText(inPath, csvData.ToString())
    End Sub

End Class
