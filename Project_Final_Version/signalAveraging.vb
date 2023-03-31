Imports System.Security.Cryptography.X509Certificates

Public Class signalAveraging

    Public currentData As Object
    Public sampleData As Object
    Public currentVolt As Double()
    Public currentTime As Double()
    Public averageVoltage As Double()
    Public datalength As Integer
    Public _loopIndex As Integer = 0


    Public Function getDataLength()
        Return currentData.Length
    End Function

    Public Sub Reset()
        currentData = Nothing
        currentVolt = Nothing
        currentTime = Nothing
        averageVoltage = Nothing
        datalength = Nothing
        _loopIndex = 0
    End Sub



End Class
