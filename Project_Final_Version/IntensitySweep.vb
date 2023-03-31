Imports System.Security.Cryptography.X509Certificates

Public Class IntensitySweep

    Public startvolt As Double
    Public endvolt As Double
    Public stepvolt As Double
    Public sweepFreq As Double

    Public _loopIndex As Double = startvolt
    Public sweepData As New List(Of Double())()

    Public Sub Reset()
        startvolt = Nothing
        endvolt = Nothing
        stepvolt = Nothing
        sweepFreq = Nothing

        _loopIndex = Nothing
        sweepData.Clear()
    End Sub
End Class
