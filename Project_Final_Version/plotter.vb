Imports System.Security.Cryptography.Xml
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock
Imports System.Xml
Imports OxyPlot.Series
Public Class plotter
    '' '''''''''' ''
    '' Parameters ''
    '' '''''''''' ''

    'Dim ourPlotView As New OxyPlot.WindowsForms.PlotView()
    '' Define the model ''

    '' Creat new data series ''



    '' Define legends ''



    Public Function display(ourPlotView, ourModel, Timespan)
        '' Define x AND y axis ''
        Dim xAxis As New OxyPlot.Axes.LinearAxis()
        Dim yAxis As New OxyPlot.Axes.LinearAxis()
        Dim ourLegend As New OxyPlot.Legends.Legend()
        '' Setup new plotview ''
        ourPlotView.Name = "DataPlotView"
        ourPlotView.Text = "Data Visualisation"
        ourPlotView.Location = New System.Drawing.Point(5, 5)
        ourPlotView.Size = New System.Drawing.Point(500, 300)

        ''''''''''''''''''''
        '' Clear old data ''
        ''''''''''''''''''''

        ourModel.InvalidatePlot(True)

        '''''''''''''''''''''''''''
        '' Set up series font '''''
        '''''''''''''''''''''''''''
        Dim ourseries As New OxyPlot.Series.LineSeries()
        ourseries.Title = "Voltage"
        ourseries.MarkerType = OxyPlot.MarkerType.None
        ourseries.MarkerSize = 0
        ourseries.Color = OxyPlot.OxyColor.FromRgb(100, 100, 0)

        '''''''''''''''''''''''''''''''''
        '' Add data to the series ''
        '''''''''''''''''''''''''''''''''


        'For i As Long = 0 To data_x.Length - 1
        '    Dim tempPoint As New OxyPlot.DataPoint(data_x(i), data_y(i))
        '    ourseries.Points.Add(tempPoint)
        'Next

        '''''''''''''''''''''''''''''''''
        '' Add the series to the model ''
        '''''''''''''''''''''''''''''''''

        ourModel.Series.Clear()
        ourModel.Series.Add(ourseries)

        '''''''''''''''''''''''
        '' Set up x - axis ''''
        '''''''''''''''''''''''

        xAxis.Position = OxyPlot.Axes.AxisPosition.Bottom
        'Find range of data value

        'Define range of x-axis according to data range
        xAxis.Minimum = 0
        xAxis.Maximum = Timespan
        'Set title and unit
        xAxis.Title = "Time"
        xAxis.Unit = "ms"
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
        ourModel.Axes.Add(xAxis)

        '''''''''''''''''''''''
        '' Set up y - axis ''''
        '''''''''''''''''''''''

        'Define position of y axis
        yAxis.Position = OxyPlot.Axes.AxisPosition.Left
        'Find range of data value

        'Define range of x-axis according to data range
        'yAxis.Minimum = EdgeValue_y(1) * 1.3
        'yAxis.Maximum = EdgeValue_y(0) * 1.3
        'Set title and unit
        yAxis.Title = "Voltage"
        yAxis.Unit = "V"
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
        ourModel.Axes.Add(yAxis)

        ''''''''''''''''''''
        '' Set up legends ''
        ''''''''''''''''''''
        '''
        'Define position and orientation of legends
        ourLegend.LegendPlacement = OxyPlot.Legends.LegendPlacement.Inside
        ourLegend.LegendPosition = OxyPlot.Legends.LegendPosition.TopLeft
        ourLegend.LegendOrientation = OxyPlot.Legends.LegendOrientation.Horizontal
        'Make visble
        ourModel.IsLegendVisible = True
        'Add to model
        ourModel.Legends.Add(ourLegend)

        '''''''''''''''''''''
        '' Add to the form ''
        '''''''''''''''''''''

        ourPlotView.Model = ourModel
        Return ourPlotView


    End Function
    'Public Sub update_plot(data_new_x, data_new_y)

    '    ''''''''''''''''''''
    '    '' Clear old data ''
    '    ''''''''''''''''''''

    '    ourModel.InvalidatePlot(True)

    '    '''''''''''''''''''''''''''
    '    '' Creat new data series ''
    '    '''''''''''''''''''''''''''
    '    Dim ourseries As New OxyPlot.Series.LineSeries()
    '    '''''''''''''''''''''''''''''''''
    '    '' Add data to the series '''''''
    '    '''''''''''''''''''''''''''''''''

    '    For i As Long = 0 To data_new_x.Length - 1
    '        Dim tempPoint As New OxyPlot.DataPoint(data_new_x(i), data_new_y(i))
    '        ourseries.Points.Add(tempPoint)
    '    Next

    '    '''''''''''''''''''''''''''''''''
    '    '' Add the series to the model ''
    '    '''''''''''''''''''''''''''''''''

    '    ourModel.Series.Clear()
    '    ourModel.Series.Add(ourseries)

    '    '''''''''''''''''''
    '    '' Adjust x axis ''
    '    '''''''''''''''''''

    '    Dim EdgeValue_x = findEdge(data_new_x)
    '    'Define range of x-axis according to data range
    '    xAxis.Minimum = EdgeValue_x(1)
    '    xAxis.Maximum = EdgeValue_x(0)


    '    '''''''''''''''''''
    '    '' Adjust y axis ''
    '    '''''''''''''''''''

    '    'Find range of data value
    '    Dim EdgeValue_y = findEdge(data_new_y)
    '    'Define range of x-axis according to data range
    '    yAxis.Minimum = EdgeValue_y(1) * 1.3
    '    yAxis.Maximum = EdgeValue_y(0) * 1.3

    '    '''''''''''''''''''''
    '    '' Add to the form ''
    '    '''''''''''''''''''''

    '    'ourPlotView.Model = ourModel
    '    'Me.Controls.Add(ourPlotView)


    'End Sub


    '' ''''''''' ''
    '' Functions ''
    '' ''''''''' ''

    'Functions used in the project
    Public Function findEdge(dataset As Double()) As Double()
        'Define array to store required data
        Dim EdgeValue(0 To 1) As Double
        'Let the first index to be the maximum number in dataset
        EdgeValue(0) = dataset(0)
        'Let the second index to be the minimum numer in dataset
        EdgeValue(1) = dataset(0)
        'Find max value and store it
        For i As Long = 0 To dataset.Length - 1
            If dataset(i) > EdgeValue(0) Then
                EdgeValue(0) = dataset(i)
            End If
        Next
        'Find min value and store it
        For i As Long = 0 To dataset.Length - 1
            If dataset(i) < EdgeValue(1) Then
                EdgeValue(1) = dataset(i)
            End If
        Next
        'Return the desired array
        Return EdgeValue
    End Function
End Class
