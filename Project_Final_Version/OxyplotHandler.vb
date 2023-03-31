Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock
Imports OxyPlot
Imports OxyPlot.Axes
Imports OxyPlot.Series
Imports OxyPlot.WindowsForms

Public Class OxyplotHandler
    Public _plotView As PlotView
    Private _plotModel As PlotModel
    Private xAxis As New OxyPlot.Axes.LinearAxis()
    Private yAxis As New OxyPlot.Axes.LinearAxis()
    Dim ourLegend As New OxyPlot.Legends.Legend()

    Public Sub New(plotView As PlotView)
        _plotView = plotView
        _plotModel = New PlotModel()
        _plotView.Model = _plotModel
        _plotView.Location = New System.Drawing.Point(15, 25)
        _plotView.Size = New System.Drawing.Point(500, 200)

    End Sub

    Public Sub setPlotViewName(Name As String)
        _plotView.Name = Name
    End Sub

    Public Sub setPlotViewText(Text As String)
        _plotView.Text = Text
    End Sub

    Public Sub setPlotViewSize(Width, Height)
        _plotView.Size = New System.Drawing.Point(Width, Height)
    End Sub

    Public Sub boxSeries(sweepData, ini_Intensity, intensity_step)
        ' Create a new BoxPlotSeries
        Dim _ourSeries As New BoxPlotSeries()
        Dim data As New List(Of BoxPlotItem)()
        Dim intensity = ini_Intensity
        For Each item In sweepData
            Dim lq As Double = FindLowerQuartile(item)
            Dim uq As Double = FindUpperQuartile(item)
            Dim median As Double = FindMedian(item)
            Dim max As Double = FindMaximum(item)
            Dim min As Double = FindMinimum(item)
            intensity = intensity + intensity_step
            data.Add(New BoxPlotItem(intensity, lq, min, median, max, uq))
        Next
        ' Define the data for the box plot
        _ourSeries.ItemsSource = data

        updatePlot(_ourSeries)
    End Sub

    Public Sub UpdateDataSeries(time As Double(), voltage As Double())
        Dim _ourSeries As New OxyPlot.Series.LineSeries()
        _ourSeries.Title = "Voltage"
        _ourSeries.MarkerType = OxyPlot.MarkerType.None
        _ourSeries.MarkerSize = 0
        _ourSeries.Color = OxyPlot.OxyColor.FromRgb(100, 100, 0)


        For i As Long = 0 To time.Length - 1
            Dim tempPoint As New OxyPlot.DataPoint(time(i), voltage(i))
            _ourSeries.Points.Add(tempPoint)
        Next

        updatePlot(_ourSeries)
    End Sub

    Public Sub plot_autoScale(voltage As Double(), timespan As Double())
        Dim peakValue As Double = voltage(0)
        Dim bottomValue As Double = voltage(0)
        'Find max value and store it
        For i As Long = 0 To voltage.Length - 1
            If voltage(i) > peakValue Then
                peakValue = voltage(i)

            End If
        Next
        'Find min value and store it
        For i As Long = 0 To voltage.Length - 1
            If voltage(i) < bottomValue Then
                bottomValue = voltage(i)
            End If
        Next
        yAxis.Maximum = peakValue * 1.3
        yAxis.Minimum = bottomValue * 1.3

        xAxis.Maximum = FindMaximum(timespan)
        xAxis.Minimum = 0
    End Sub

    Public Sub plot_customScale(timespan As String)
        xAxis.Maximum = Double.Parse(timespan) / 1000
        xAxis.Minimum = 0
    End Sub
    Public Sub IW_plot_autoScale(sweepData As List(Of Double()), startVolt As Double, endVolt As Double)

        xAxis.Minimum = startVolt
        xAxis.Maximum = endVolt

        Dim ymax As Double
        Dim ymin As Double

        For Each item In sweepData
            If FindMaximum(item) > ymax Then
                ymax = FindMaximum(item)
            End If

            If FindMinimum(item) < ymin Then
                ymin = FindMinimum(item)
            End If
        Next

        yAxis.Minimum = ymin * 1.3
        yAxis.Maximum = ymax * 1.3
    End Sub

    Public Sub setupAxis(xtitle, xunit, ytitle, yunit)
        '''''''''''''''''''''''
        '' Set up x - axis ''''
        '''''''''''''''''''''''

        xAxis.Position = OxyPlot.Axes.AxisPosition.Bottom
        'Find range of data value
        'Dim EdgeValue_x = findEdge(data_x)
        'Define range of x-axis according to data range
        xAxis.Minimum = 0
        xAxis.Maximum = 0.01
        'Set title and unit
        xAxis.Title = xtitle
        xAxis.Unit = xunit
        'Set extent of user interface
        xAxis.IsZoomEnabled = True
        xAxis.IsPanEnabled = False
        xAxis.IsAxisVisible = True
        'Gridline font
        xAxis.MajorGridlineStyle = OxyPlot.LineStyle.None
        xAxis.MajorGridlineColor = OxyPlot.OxyColor.FromRgb(0, 0, 0)
        xAxis.MinorGridlineStyle = OxyPlot.LineStyle.None
        xAxis.MinorGridlineColor = OxyPlot.OxyColor.FromRgb(0, 0, 0)
        'Add to model
        _plotModel.Axes.Add(xAxis)

        '''''''''''''''''''''''
        '' Set up y - axis ''''
        '''''''''''''''''''''''

        'Define position of y axis
        yAxis.Position = OxyPlot.Axes.AxisPosition.Left
        'Find range of data value
        'Dim EdgeValue_y = findEdge(data_y)
        'Define range of x-axis according to data range
        yAxis.Minimum = -12
        yAxis.Maximum = 12
        'Set title and unit
        yAxis.Title = ytitle
        yAxis.Unit = yunit
        'Set extent of user interface
        yAxis.IsZoomEnabled = True
        yAxis.IsPanEnabled = False
        yAxis.IsAxisVisible = True
        'Gridline font
        yAxis.MajorGridlineStyle = OxyPlot.LineStyle.None
        yAxis.MajorGridlineColor = OxyPlot.OxyColor.FromRgb(0, 0, 0)
        yAxis.MinorGridlineStyle = OxyPlot.LineStyle.None
        yAxis.MinorGridlineColor = OxyPlot.OxyColor.FromRgb(0, 0, 0)
        'Add to model
        _plotModel.Axes.Add(yAxis)
    End Sub

    Public Sub setupLegends()
        'Define position and orientation of legends
        ourLegend.LegendPlacement = OxyPlot.Legends.LegendPlacement.Inside
        ourLegend.LegendPosition = OxyPlot.Legends.LegendPosition.TopRight
        ourLegend.LegendOrientation = OxyPlot.Legends.LegendOrientation.Horizontal
        'Make visble
        _plotModel.IsLegendVisible = True
        'Add to model
        _plotModel.Legends.Add(ourLegend)
    End Sub

    Public Sub addToPlotView()
        _plotView.Model = _plotModel
    End Sub

    Public Sub updatePlot(ByVal _ourSeries)

        _plotModel.Series.Clear()
        _plotModel.Series.Add(_ourSeries)
        _plotView.InvalidatePlot(True)
    End Sub
    ' Function to find the median of an array of numbers
    Private Function FindMedian(numbers() As Double) As Double
        ' Sort the array of numbers
        Array.Sort(numbers)

        ' Calculate the index of the middle element
        Dim middleIndex As Integer = numbers.Length \ 2

        ' Check if the array has an odd or even number of elements
        If numbers.Length Mod 2 = 0 Then
            ' If the array has an even number of elements, return the average of the middle two elements
            Return (numbers(middleIndex - 1) + numbers(middleIndex)) / 2
        Else
            ' If the array has an odd number of elements, return the middle element
            Return numbers(middleIndex)
        End If
    End Function

    ' Function to find the lower quartile of an array of numbers
    Private Function FindLowerQuartile(numbers() As Double) As Double
        ' Sort the array of numbers
        Array.Sort(numbers)

        ' Calculate the index of the middle element
        Dim middleIndex As Integer = numbers.Length \ 2

        ' Check if the array has an odd or even number of elements
        If numbers.Length Mod 2 = 0 Then
            ' If the array has an even number of elements, find the median of the lower half of the array
            Dim lowerHalf(numbers.Length \ 2 - 1) As Double
            Array.Copy(numbers, 0, lowerHalf, 0, middleIndex)
            Return FindMedian(lowerHalf)
        Else
            ' If the array has an odd number of elements, find the median of the lower half of the array (excluding the middle element)
            Dim lowerHalf(middleIndex - 1) As Double
            Array.Copy(numbers, 0, lowerHalf, 0, middleIndex)
            Return FindMedian(lowerHalf)
        End If
    End Function

    ' Function to find the upper quartile of an array of numbers
    Private Function FindUpperQuartile(numbers() As Double) As Double
        ' Sort the array of numbers
        Array.Sort(numbers)

        ' Calculate the index of the middle element
        Dim middleIndex As Integer = numbers.Length \ 2

        ' Check if the array has an odd or even number of elements
        If numbers.Length Mod 2 = 0 Then
            ' If the array has an even number of elements, find the median of the upper half of the array
            Dim upperHalf(numbers.Length \ 2 - 1) As Double
            Array.Copy(numbers, middleIndex, upperHalf, 0, middleIndex)
            Return FindMedian(upperHalf)
        Else
            ' If the array has an odd number of elements, find the median of the upper half of the array (excluding the middle element)
            Dim upperHalf(middleIndex - 1) As Double
            Array.Copy(numbers, middleIndex + 1, upperHalf, 0, middleIndex)
            Return FindMedian(upperHalf)
        End If
    End Function

    ' Function to find the minimum value in an array of numbers
    Public Function FindMinimum(numbers() As Double) As Double
        ' Sort the array of numbers and return the first element
        Array.Sort(numbers)
        Return numbers(0)
    End Function

    ' Function to find the maximum value in an array of numbers
    Public Function FindMaximum(numbers() As Double) As Double
        ' Sort the array of numbers in reverse order and return the first element
        Array.Sort(numbers)
        Array.Reverse(numbers)
        Return numbers(0)
    End Function


End Class
