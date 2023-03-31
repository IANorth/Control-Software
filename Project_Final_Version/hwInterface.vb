Imports System.Threading
Imports NationalInstruments.VisaNS
Public Class hwInterface
    Private Resources As String()
    Private mbsessionScope As MessageBasedSession
    Private mbsessionGenerator As MessageBasedSession


    Public Function exeQueryScope(inCommand As String) As String

        Try
            Dim cmdString As String = mbsessionScope.Query(inCommand)
            Return cmdString
        Catch ex As NullReferenceException
            MessageBox.Show("Message Based Session is not set with correct oscilloscope address")
            Return Nothing
        End Try

    End Function

    Public Function exeQueryGen(inCommand As String) As String

        Try
            Dim cmdString As String = mbsessionGenerator.Query(inCommand)
            Return cmdString
        Catch ex As NullReferenceException
            MessageBox.Show("Message Based Session is not set with correct oscilloscope address")
            Return Nothing
        End Try

    End Function

    Public Sub sendCommandScope(inComand As String)

        Try
            mbsessionScope.Write(inComand)
        Catch ex As NullReferenceException
            MessageBox.Show("Message Based Session is not set with correct oscilloscope address")
        End Try

    End Sub
    Public Sub sendCommandGen(inComand As String)

        Try
            mbsessionGenerator.Write(inComand)
        Catch ex As NullReferenceException
            MessageBox.Show("Message Based Session is not set with correct oscilloscope address")
        End Try

    End Sub

    Public Function getScopeAdress()
        Dim j As Integer
        Dim scopeID_prefix As String = "USB0::0x1AB1::0x04B1::*::*"
        Try

            Resources = ResourceManager.GetLocalManager().FindResources("USB?*")

            For j = 0 To Resources.Length - 1
                If Resources(j) Like scopeID_prefix Then
                    Return Resources(j)
                End If
            Next

            Return Nothing

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function getGeneratorAddress()
        Dim j As Integer
        Dim generatorID_prefix As String = "USB0::0x1AB1::0x0642::*::*"
        Try
            Dim resources As String()
            resources = ResourceManager.GetLocalManager().FindResources("USB?*")

            For j = 0 To resources.Length - 1
                If resources(j) Like generatorID_prefix Then
                    Return resources(j)
                End If
            Next

            Return Nothing

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function getAllScope()
        Dim j As Integer
        Dim scopeID_prefix As String = "USB0::0x1AB1::0x04B1::*::*"
        Dim scopeAdrresses As New List(Of String)()
        Try

            Resources = ResourceManager.GetLocalManager().FindResources("USB?*")

            For j = 0 To Resources.Length - 1
                If Resources(j) Like scopeID_prefix Then
                    scopeAdrresses.Add(Resources(j))
                End If
            Next

            Return scopeAdrresses

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function getAllGen()
        Dim j As Integer
        Dim genID_prefix As String = "USB0::0x1AB1::0x0642::*::*"
        Dim genAdrresses As New List(Of String)()
        Try

            Resources = ResourceManager.GetLocalManager().FindResources("USB?*")

            For j = 0 To Resources.Length - 1
                If Resources(j) Like genID_prefix Then
                    genAdrresses.Add(Resources(j))
                End If
            Next

            Return genAdrresses

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function getCurrentScope()
        If mbsessionScope IsNot Nothing Then
            Return exeQueryScope("*IDN?")
        Else
            Return Nothing
        End If
    End Function
    Public Function getCurrentGen()
        If mbsessionGenerator IsNot Nothing Then
            Return exeQueryGen(":SYSTem:COMMunicate:USB:INFormation?")
        Else
            Return Nothing
        End If
    End Function

    Public Sub connectScope(address)
        Try
            Me.mbsessionScope = CType(ResourceManager.GetLocalManager.Open(address), MessageBasedSession)
            MessageBox.Show("Connected!")
        Catch ex As ArgumentException
            MessageBox.Show("Invalid Address")
        End Try
    End Sub
    Public Sub connectSigGen(address)
        Try
            Me.mbsessionGenerator = CType(ResourceManager.GetLocalManager.Open(address), MessageBasedSession)
            MessageBox.Show("Connected!")
        Catch ArgumentException As Exception
            MessageBox.Show("Invalid Address")
        End Try
    End Sub

    Public Function getWaveFormat()
        Return exeQueryScope(":WAV:FORM?")
    End Function

    Public Sub setWaveFormatAsc()
        'Specify channel?
        'Send Query
        sendCommandScope(":WAV:FORM ASC")
    End Sub

    Public Function readRawData() As String
        sendCommandScope(":WAV:SOUR CHAN1")
        sendCommandScope(":WAV:SOUR NORM")
        'stopScope()
        Return exeQueryScope(":WAV:DATA?")
    End Function

    Public Function readDataWithoutStop() As String
        sendCommandScope(":WAV:SOUR CHAN1")
        sendCommandScope(":WAV:SOUR NORM")
        Return exeQueryScope(":WAV:DATA?")
    End Function

    Public Sub runScope()
        sendCommandScope(":RUN")
    End Sub

    Public Sub stopScope()
        sendCommandScope(":STOP")
    End Sub

    Public Function getXaxisPoint() As Long
        Dim tempString As String = exeQueryScope(":WAV:POIN?")
        Return Long.Parse(tempString)
    End Function

    Public Function getXaxisScale() As Double
        Dim tempString As String = exeQueryScope(":TIM:SCAL?")
        Return Double.Parse(tempString)
    End Function

    Public Function getNumberofDivisions()
        Dim divisions As String = exeQueryScope(":TIMebase:SCALe:DVISion?")
        Return Double.Parse(divisions)
    End Function

    Public Function getTimeStep() As Double
        Dim totalTime As Double = getXaxisScale() * 14
        Dim timeStep As Double = totalTime / getXaxisPoint()
        Return timeStep
    End Function

    Public Sub setTotalTimeSpan(timespan As Integer)
        Dim timeSpanMS = timespan / 1000
        sendCommandScope(":TIM:SCAL " & timeSpanMS.ToString)
    End Sub

    Public Sub setWaveForm(waveform As String)

        If waveform.Equals("Sine") Then
            sendCommandGen(":SOURce1:FUNCtion SINusoid")
        ElseIf waveform.Equals("Square") Then
            sendCommandGen(":SOURce1:FUNCtion SQUare")
        Else
            MessageBox.Show("Illegal Input")
        End If

    End Sub

    Public Sub setFrequency(freq As String)

        Try
            Double.Parse(freq)
            sendCommandGen(":SOURce:FREQuency " & freq)
        Catch ex As Exception
            MessageBox.Show("Illegal Input")
        End Try

    End Sub

    Public Sub setAmplitude(amplitude As String)
        Try
            Double.Parse(amplitude)
            sendCommandGen(":SOURce:VOLTage:AMPLitude " & amplitude)
        Catch ex As Exception
            MessageBox.Show("Illegal Input")
        End Try
    End Sub

    Public Sub startOutput()
        sendCommandGen(":OUTPut:STATe ON")
    End Sub

    Public Sub autoScale()
        sendCommandScope(":AUToscale")
    End Sub

    Public Sub disconnectScope()

        mbsessionScope.Dispose()

    End Sub

    Public Sub disconnectSigGen()
        mbsessionGenerator.Dispose()
    End Sub


End Class
