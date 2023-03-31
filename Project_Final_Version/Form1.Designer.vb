Imports System.Threading
Imports System.IO
Imports OxyPlot
Imports OxyPlot.Series
Imports OxyPlot.WindowsForms
Imports System.Windows.Forms.Design
Imports System.Security.Cryptography.X509Certificates
Imports System.Reflection

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tabAll = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.gpbxSig = New System.Windows.Forms.GroupBox()
        Me.cmdDisconnectSig = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCurrentSig = New System.Windows.Forms.TextBox()
        Me.gpbxSigManual = New System.Windows.Forms.GroupBox()
        Me.cmdManualSigCnct = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSigManualInput = New System.Windows.Forms.TextBox()
        Me.gpbxSigAuto = New System.Windows.Forms.GroupBox()
        Me.cmdFindSig = New System.Windows.Forms.Button()
        Me.cmdAutoSigCnct = New System.Windows.Forms.Button()
        Me.cbAllSig = New System.Windows.Forms.ComboBox()
        Me.gpbxOsc = New System.Windows.Forms.GroupBox()
        Me.cmdDisconnectOsc = New System.Windows.Forms.Button()
        Me.lblConnectedDevice = New System.Windows.Forms.Label()
        Me.txtCurrentOsc = New System.Windows.Forms.TextBox()
        Me.gpbxOscManual = New System.Windows.Forms.GroupBox()
        Me.cmdManualOscCnct = New System.Windows.Forms.Button()
        Me.labelEA = New System.Windows.Forms.Label()
        Me.txtOscManualInput = New System.Windows.Forms.TextBox()
        Me.gpbxOscAuto = New System.Windows.Forms.GroupBox()
        Me.cmdFindOsc = New System.Windows.Forms.Button()
        Me.cmdAutoOscCnct = New System.Windows.Forms.Button()
        Me.cbAllOsc = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gpbxAnalysis = New System.Windows.Forms.GroupBox()
        Me.txttauOFF = New System.Windows.Forms.TextBox()
        Me.txttauON = New System.Windows.Forms.TextBox()
        Me.txtPeakOFF = New System.Windows.Forms.TextBox()
        Me.txtPeakON = New System.Windows.Forms.TextBox()
        Me.lblTauLEDoff = New System.Windows.Forms.Label()
        Me.lblTauLEDon = New System.Windows.Forms.Label()
        Me.lblPkLEDoff = New System.Windows.Forms.Label()
        Me.lblPkLEDon = New System.Windows.Forms.Label()
        Me.cmdSetPara = New System.Windows.Forms.Button()
        Me.gpbxSigSettings = New System.Windows.Forms.GroupBox()
        Me.txtAmplitude = New System.Windows.Forms.TextBox()
        Me.labelVolt = New System.Windows.Forms.Label()
        Me.cbWaveform = New System.Windows.Forms.ComboBox()
        Me.txtFrequency = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gpbxDisplaySettings = New System.Windows.Forms.GroupBox()
        Me.cmdSetTimespan = New System.Windows.Forms.Button()
        Me.txtTimespan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gpbxGraph = New System.Windows.Forms.GroupBox()
        Me.checkbxAutoScale = New System.Windows.Forms.CheckBox()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.gpbxSaving = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkbxAnalysis = New System.Windows.Forms.CheckBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFilename = New System.Windows.Forms.TextBox()
        Me.txtDirectory = New System.Windows.Forms.TextBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.labelProgress = New System.Windows.Forms.Label()
        Me.pgbarSingleMeasure = New System.Windows.Forms.ProgressBar()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.gpbxIWSettings = New System.Windows.Forms.GroupBox()
        Me.cmdIWSetPara = New System.Windows.Forms.Button()
        Me.txtSweepFreq = New System.Windows.Forms.TextBox()
        Me.lblSweepFreq = New System.Windows.Forms.Label()
        Me.cbSweepType = New System.Windows.Forms.ComboBox()
        Me.lblSweepType = New System.Windows.Forms.Label()
        Me.txtStepVolt = New System.Windows.Forms.TextBox()
        Me.lblGap = New System.Windows.Forms.Label()
        Me.txtEndVolt = New System.Windows.Forms.TextBox()
        Me.lblEndVolt = New System.Windows.Forms.Label()
        Me.txtStartVolt = New System.Windows.Forms.TextBox()
        Me.lblStartVolt = New System.Windows.Forms.Label()
        Me.gpbxIWSaving = New System.Windows.Forms.GroupBox()
        Me.ckbxIWSettings = New System.Windows.Forms.CheckBox()
        Me.cmdIWSave = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtIWFilename = New System.Windows.Forms.TextBox()
        Me.txtIWDirectory = New System.Windows.Forms.TextBox()
        Me.cmdIWBrowse = New System.Windows.Forms.Button()
        Me.gpbxIntensitySweep = New System.Windows.Forms.GroupBox()
        Me.lblIWStatus = New System.Windows.Forms.Label()
        Me.pgbarIW = New System.Windows.Forms.ProgressBar()
        Me.cmdIWReset = New System.Windows.Forms.Button()
        Me.cmdIWStop = New System.Windows.Forms.Button()
        Me.cmdIWStart = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.tmrGlobal = New System.Windows.Forms.Timer(Me.components)
        Me.tabAll.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gpbxSig.SuspendLayout()
        Me.gpbxSigManual.SuspendLayout()
        Me.gpbxSigAuto.SuspendLayout()
        Me.gpbxOsc.SuspendLayout()
        Me.gpbxOscManual.SuspendLayout()
        Me.gpbxOscAuto.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gpbxAnalysis.SuspendLayout()
        Me.gpbxSigSettings.SuspendLayout()
        Me.gpbxDisplaySettings.SuspendLayout()
        Me.gpbxGraph.SuspendLayout()
        Me.gpbxSaving.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.gpbxIWSettings.SuspendLayout()
        Me.gpbxIWSaving.SuspendLayout()
        Me.gpbxIntensitySweep.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabAll
        '
        Me.tabAll.Controls.Add(Me.TabPage1)
        Me.tabAll.Controls.Add(Me.TabPage2)
        Me.tabAll.Controls.Add(Me.TabPage3)
        Me.tabAll.Controls.Add(Me.TabPage4)
        Me.tabAll.Location = New System.Drawing.Point(12, 12)
        Me.tabAll.Name = "tabAll"
        Me.tabAll.SelectedIndex = 0
        Me.tabAll.Size = New System.Drawing.Size(776, 376)
        Me.tabAll.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gpbxSig)
        Me.TabPage1.Controls.Add(Me.gpbxOsc)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(768, 348)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'gpbxSig
        '
        Me.gpbxSig.Controls.Add(Me.cmdDisconnectSig)
        Me.gpbxSig.Controls.Add(Me.Label1)
        Me.gpbxSig.Controls.Add(Me.txtCurrentSig)
        Me.gpbxSig.Controls.Add(Me.gpbxSigManual)
        Me.gpbxSig.Controls.Add(Me.gpbxSigAuto)
        Me.gpbxSig.Location = New System.Drawing.Point(394, 10)
        Me.gpbxSig.Name = "gpbxSig"
        Me.gpbxSig.Size = New System.Drawing.Size(368, 334)
        Me.gpbxSig.TabIndex = 9
        Me.gpbxSig.TabStop = False
        Me.gpbxSig.Text = "Signal Generator"
        '
        'cmdDisconnectSig
        '
        Me.cmdDisconnectSig.Location = New System.Drawing.Point(268, 60)
        Me.cmdDisconnectSig.Name = "cmdDisconnectSig"
        Me.cmdDisconnectSig.Size = New System.Drawing.Size(81, 22)
        Me.cmdDisconnectSig.TabIndex = 12
        Me.cmdDisconnectSig.Text = "Disconnect"
        Me.cmdDisconnectSig.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Current connected device:"
        '
        'txtCurrentSig
        '
        Me.txtCurrentSig.Location = New System.Drawing.Point(22, 60)
        Me.txtCurrentSig.Name = "txtCurrentSig"
        Me.txtCurrentSig.Size = New System.Drawing.Size(240, 23)
        Me.txtCurrentSig.TabIndex = 2
        '
        'gpbxSigManual
        '
        Me.gpbxSigManual.Controls.Add(Me.cmdManualSigCnct)
        Me.gpbxSigManual.Controls.Add(Me.Label2)
        Me.gpbxSigManual.Controls.Add(Me.txtSigManualInput)
        Me.gpbxSigManual.Location = New System.Drawing.Point(6, 213)
        Me.gpbxSigManual.Name = "gpbxSigManual"
        Me.gpbxSigManual.Size = New System.Drawing.Size(354, 116)
        Me.gpbxSigManual.TabIndex = 1
        Me.gpbxSigManual.TabStop = False
        Me.gpbxSigManual.Text = "Manual Connection"
        '
        'cmdManualSigCnct
        '
        Me.cmdManualSigCnct.Location = New System.Drawing.Point(262, 63)
        Me.cmdManualSigCnct.Name = "cmdManualSigCnct"
        Me.cmdManualSigCnct.Size = New System.Drawing.Size(81, 20)
        Me.cmdManualSigCnct.TabIndex = 3
        Me.cmdManualSigCnct.Text = "Connect"
        Me.cmdManualSigCnct.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Enter Adress:"
        '
        'txtSigManualInput
        '
        Me.txtSigManualInput.Location = New System.Drawing.Point(16, 63)
        Me.txtSigManualInput.Name = "txtSigManualInput"
        Me.txtSigManualInput.Size = New System.Drawing.Size(240, 23)
        Me.txtSigManualInput.TabIndex = 1
        '
        'gpbxSigAuto
        '
        Me.gpbxSigAuto.Controls.Add(Me.cmdFindSig)
        Me.gpbxSigAuto.Controls.Add(Me.cmdAutoSigCnct)
        Me.gpbxSigAuto.Controls.Add(Me.cbAllSig)
        Me.gpbxSigAuto.Location = New System.Drawing.Point(6, 101)
        Me.gpbxSigAuto.Name = "gpbxSigAuto"
        Me.gpbxSigAuto.Size = New System.Drawing.Size(354, 104)
        Me.gpbxSigAuto.TabIndex = 0
        Me.gpbxSigAuto.TabStop = False
        Me.gpbxSigAuto.Text = "Auto Connection"
        '
        'cmdFindSig
        '
        Me.cmdFindSig.Location = New System.Drawing.Point(16, 19)
        Me.cmdFindSig.Name = "cmdFindSig"
        Me.cmdFindSig.Size = New System.Drawing.Size(327, 22)
        Me.cmdFindSig.TabIndex = 9
        Me.cmdFindSig.Text = "Find Devices"
        Me.cmdFindSig.UseVisualStyleBackColor = True
        '
        'cmdAutoSigCnct
        '
        Me.cmdAutoSigCnct.Location = New System.Drawing.Point(262, 56)
        Me.cmdAutoSigCnct.Name = "cmdAutoSigCnct"
        Me.cmdAutoSigCnct.Size = New System.Drawing.Size(81, 22)
        Me.cmdAutoSigCnct.TabIndex = 10
        Me.cmdAutoSigCnct.Text = "Connect"
        Me.cmdAutoSigCnct.UseVisualStyleBackColor = True
        '
        'cbAllSig
        '
        Me.cbAllSig.FormattingEnabled = True
        Me.cbAllSig.Location = New System.Drawing.Point(16, 56)
        Me.cbAllSig.Name = "cbAllSig"
        Me.cbAllSig.Size = New System.Drawing.Size(240, 23)
        Me.cbAllSig.TabIndex = 8
        '
        'gpbxOsc
        '
        Me.gpbxOsc.Controls.Add(Me.cmdDisconnectOsc)
        Me.gpbxOsc.Controls.Add(Me.lblConnectedDevice)
        Me.gpbxOsc.Controls.Add(Me.txtCurrentOsc)
        Me.gpbxOsc.Controls.Add(Me.gpbxOscManual)
        Me.gpbxOsc.Controls.Add(Me.gpbxOscAuto)
        Me.gpbxOsc.Location = New System.Drawing.Point(6, 10)
        Me.gpbxOsc.Name = "gpbxOsc"
        Me.gpbxOsc.Size = New System.Drawing.Size(368, 334)
        Me.gpbxOsc.TabIndex = 8
        Me.gpbxOsc.TabStop = False
        Me.gpbxOsc.Text = "Oscilloscope"
        '
        'cmdDisconnectOsc
        '
        Me.cmdDisconnectOsc.Location = New System.Drawing.Point(270, 60)
        Me.cmdDisconnectOsc.Name = "cmdDisconnectOsc"
        Me.cmdDisconnectOsc.Size = New System.Drawing.Size(80, 22)
        Me.cmdDisconnectOsc.TabIndex = 11
        Me.cmdDisconnectOsc.Text = "Disconnect"
        Me.cmdDisconnectOsc.UseVisualStyleBackColor = True
        '
        'lblConnectedDevice
        '
        Me.lblConnectedDevice.AutoSize = True
        Me.lblConnectedDevice.Location = New System.Drawing.Point(23, 34)
        Me.lblConnectedDevice.Name = "lblConnectedDevice"
        Me.lblConnectedDevice.Size = New System.Drawing.Size(146, 15)
        Me.lblConnectedDevice.TabIndex = 3
        Me.lblConnectedDevice.Text = "Current connected device:"
        '
        'txtCurrentOsc
        '
        Me.txtCurrentOsc.Location = New System.Drawing.Point(22, 60)
        Me.txtCurrentOsc.Name = "txtCurrentOsc"
        Me.txtCurrentOsc.Size = New System.Drawing.Size(242, 23)
        Me.txtCurrentOsc.TabIndex = 2
        '
        'gpbxOscManual
        '
        Me.gpbxOscManual.Controls.Add(Me.cmdManualOscCnct)
        Me.gpbxOscManual.Controls.Add(Me.labelEA)
        Me.gpbxOscManual.Controls.Add(Me.txtOscManualInput)
        Me.gpbxOscManual.Location = New System.Drawing.Point(6, 213)
        Me.gpbxOscManual.Name = "gpbxOscManual"
        Me.gpbxOscManual.Size = New System.Drawing.Size(354, 116)
        Me.gpbxOscManual.TabIndex = 1
        Me.gpbxOscManual.TabStop = False
        Me.gpbxOscManual.Text = "Manual Connection"
        '
        'cmdManualOscCnct
        '
        Me.cmdManualOscCnct.Location = New System.Drawing.Point(263, 63)
        Me.cmdManualOscCnct.Name = "cmdManualOscCnct"
        Me.cmdManualOscCnct.Size = New System.Drawing.Size(80, 20)
        Me.cmdManualOscCnct.TabIndex = 3
        Me.cmdManualOscCnct.Text = "Connect"
        Me.cmdManualOscCnct.UseVisualStyleBackColor = True
        '
        'labelEA
        '
        Me.labelEA.AutoSize = True
        Me.labelEA.Location = New System.Drawing.Point(16, 28)
        Me.labelEA.Name = "labelEA"
        Me.labelEA.Size = New System.Drawing.Size(75, 15)
        Me.labelEA.TabIndex = 7
        Me.labelEA.Text = "Enter Adress:"
        '
        'txtOscManualInput
        '
        Me.txtOscManualInput.Location = New System.Drawing.Point(15, 63)
        Me.txtOscManualInput.Name = "txtOscManualInput"
        Me.txtOscManualInput.Size = New System.Drawing.Size(242, 23)
        Me.txtOscManualInput.TabIndex = 1
        '
        'gpbxOscAuto
        '
        Me.gpbxOscAuto.Controls.Add(Me.cmdFindOsc)
        Me.gpbxOscAuto.Controls.Add(Me.cmdAutoOscCnct)
        Me.gpbxOscAuto.Controls.Add(Me.cbAllOsc)
        Me.gpbxOscAuto.Location = New System.Drawing.Point(6, 101)
        Me.gpbxOscAuto.Name = "gpbxOscAuto"
        Me.gpbxOscAuto.Size = New System.Drawing.Size(354, 104)
        Me.gpbxOscAuto.TabIndex = 0
        Me.gpbxOscAuto.TabStop = False
        Me.gpbxOscAuto.Text = "Auto Connection"
        '
        'cmdFindOsc
        '
        Me.cmdFindOsc.Location = New System.Drawing.Point(16, 19)
        Me.cmdFindOsc.Name = "cmdFindOsc"
        Me.cmdFindOsc.Size = New System.Drawing.Size(327, 22)
        Me.cmdFindOsc.TabIndex = 9
        Me.cmdFindOsc.Text = "Find Devices"
        Me.cmdFindOsc.UseVisualStyleBackColor = True
        '
        'cmdAutoOscCnct
        '
        Me.cmdAutoOscCnct.Location = New System.Drawing.Point(264, 56)
        Me.cmdAutoOscCnct.Name = "cmdAutoOscCnct"
        Me.cmdAutoOscCnct.Size = New System.Drawing.Size(79, 22)
        Me.cmdAutoOscCnct.TabIndex = 10
        Me.cmdAutoOscCnct.Text = "Connect"
        Me.cmdAutoOscCnct.UseVisualStyleBackColor = True
        '
        'cbAllOsc
        '
        Me.cbAllOsc.FormattingEnabled = True
        Me.cbAllOsc.Location = New System.Drawing.Point(16, 56)
        Me.cbAllOsc.Name = "cbAllOsc"
        Me.cbAllOsc.Size = New System.Drawing.Size(242, 23)
        Me.cbAllOsc.TabIndex = 8
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gpbxAnalysis)
        Me.TabPage2.Controls.Add(Me.cmdSetPara)
        Me.TabPage2.Controls.Add(Me.gpbxSigSettings)
        Me.TabPage2.Controls.Add(Me.gpbxDisplaySettings)
        Me.TabPage2.Controls.Add(Me.gpbxGraph)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(768, 348)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gpbxAnalysis
        '
        Me.gpbxAnalysis.Controls.Add(Me.txttauOFF)
        Me.gpbxAnalysis.Controls.Add(Me.txttauON)
        Me.gpbxAnalysis.Controls.Add(Me.txtPeakOFF)
        Me.gpbxAnalysis.Controls.Add(Me.txtPeakON)
        Me.gpbxAnalysis.Controls.Add(Me.lblTauLEDoff)
        Me.gpbxAnalysis.Controls.Add(Me.lblTauLEDon)
        Me.gpbxAnalysis.Controls.Add(Me.lblPkLEDoff)
        Me.gpbxAnalysis.Controls.Add(Me.lblPkLEDon)
        Me.gpbxAnalysis.Location = New System.Drawing.Point(549, 213)
        Me.gpbxAnalysis.Name = "gpbxAnalysis"
        Me.gpbxAnalysis.Size = New System.Drawing.Size(213, 131)
        Me.gpbxAnalysis.TabIndex = 3
        Me.gpbxAnalysis.TabStop = False
        Me.gpbxAnalysis.Text = "Analysis"
        '
        'txttauOFF
        '
        Me.txttauOFF.Location = New System.Drawing.Point(99, 106)
        Me.txttauOFF.Name = "txttauOFF"
        Me.txttauOFF.Size = New System.Drawing.Size(108, 23)
        Me.txttauOFF.TabIndex = 7
        '
        'txttauON
        '
        Me.txttauON.Location = New System.Drawing.Point(99, 78)
        Me.txttauON.Name = "txttauON"
        Me.txttauON.Size = New System.Drawing.Size(108, 23)
        Me.txttauON.TabIndex = 6
        '
        'txtPeakOFF
        '
        Me.txtPeakOFF.Location = New System.Drawing.Point(99, 51)
        Me.txtPeakOFF.Name = "txtPeakOFF"
        Me.txtPeakOFF.Size = New System.Drawing.Size(108, 23)
        Me.txtPeakOFF.TabIndex = 5
        '
        'txtPeakON
        '
        Me.txtPeakON.Location = New System.Drawing.Point(99, 26)
        Me.txtPeakON.Name = "txtPeakON"
        Me.txtPeakON.Size = New System.Drawing.Size(108, 23)
        Me.txtPeakON.TabIndex = 4
        '
        'lblTauLEDoff
        '
        Me.lblTauLEDoff.AutoSize = True
        Me.lblTauLEDoff.Location = New System.Drawing.Point(6, 106)
        Me.lblTauLEDoff.Name = "lblTauLEDoff"
        Me.lblTauLEDoff.Size = New System.Drawing.Size(73, 15)
        Me.lblTauLEDoff.TabIndex = 3
        Me.lblTauLEDoff.Text = "tau(LED off):"
        '
        'lblTauLEDon
        '
        Me.lblTauLEDon.AutoSize = True
        Me.lblTauLEDon.Location = New System.Drawing.Point(6, 80)
        Me.lblTauLEDon.Name = "lblTauLEDon"
        Me.lblTauLEDon.Size = New System.Drawing.Size(72, 15)
        Me.lblTauLEDon.TabIndex = 2
        Me.lblTauLEDon.Text = "tau(LED on):"
        '
        'lblPkLEDoff
        '
        Me.lblPkLEDoff.AutoSize = True
        Me.lblPkLEDoff.Location = New System.Drawing.Point(6, 54)
        Me.lblPkLEDoff.Name = "lblPkLEDoff"
        Me.lblPkLEDoff.Size = New System.Drawing.Size(81, 15)
        Me.lblPkLEDoff.TabIndex = 1
        Me.lblPkLEDoff.Text = "Peak(LED off):"
        '
        'lblPkLEDon
        '
        Me.lblPkLEDon.AutoSize = True
        Me.lblPkLEDon.Location = New System.Drawing.Point(5, 28)
        Me.lblPkLEDon.Name = "lblPkLEDon"
        Me.lblPkLEDon.Size = New System.Drawing.Size(80, 15)
        Me.lblPkLEDon.TabIndex = 0
        Me.lblPkLEDon.Text = "Peak(LED on):"
        '
        'cmdSetPara
        '
        Me.cmdSetPara.Location = New System.Drawing.Point(549, 187)
        Me.cmdSetPara.Name = "cmdSetPara"
        Me.cmdSetPara.Size = New System.Drawing.Size(213, 20)
        Me.cmdSetPara.TabIndex = 5
        Me.cmdSetPara.Text = "Set Parameters"
        Me.cmdSetPara.UseVisualStyleBackColor = True
        '
        'gpbxSigSettings
        '
        Me.gpbxSigSettings.Controls.Add(Me.txtAmplitude)
        Me.gpbxSigSettings.Controls.Add(Me.labelVolt)
        Me.gpbxSigSettings.Controls.Add(Me.cbWaveform)
        Me.gpbxSigSettings.Controls.Add(Me.txtFrequency)
        Me.gpbxSigSettings.Controls.Add(Me.Label5)
        Me.gpbxSigSettings.Controls.Add(Me.Label4)
        Me.gpbxSigSettings.Location = New System.Drawing.Point(549, 75)
        Me.gpbxSigSettings.Name = "gpbxSigSettings"
        Me.gpbxSigSettings.Size = New System.Drawing.Size(213, 107)
        Me.gpbxSigSettings.TabIndex = 2
        Me.gpbxSigSettings.TabStop = False
        Me.gpbxSigSettings.Text = "Signal Generator Settings"
        '
        'txtAmplitude
        '
        Me.txtAmplitude.Location = New System.Drawing.Point(129, 79)
        Me.txtAmplitude.Name = "txtAmplitude"
        Me.txtAmplitude.Size = New System.Drawing.Size(66, 23)
        Me.txtAmplitude.TabIndex = 6
        '
        'labelVolt
        '
        Me.labelVolt.AutoSize = True
        Me.labelVolt.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelVolt.Location = New System.Drawing.Point(6, 81)
        Me.labelVolt.Name = "labelVolt"
        Me.labelVolt.Size = New System.Drawing.Size(104, 17)
        Me.labelVolt.TabIndex = 5
        Me.labelVolt.Text = "Peak Voltage(V):"
        '
        'cbWaveform
        '
        Me.cbWaveform.FormattingEnabled = True
        Me.cbWaveform.Location = New System.Drawing.Point(129, 53)
        Me.cbWaveform.Name = "cbWaveform"
        Me.cbWaveform.Size = New System.Drawing.Size(66, 23)
        Me.cbWaveform.TabIndex = 4
        '
        'txtFrequency
        '
        Me.txtFrequency.Location = New System.Drawing.Point(129, 26)
        Me.txtFrequency.Name = "txtFrequency"
        Me.txtFrequency.Size = New System.Drawing.Size(66, 23)
        Me.txtFrequency.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(5, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Waveform:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(5, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Frequency(Hz):"
        '
        'gpbxDisplaySettings
        '
        Me.gpbxDisplaySettings.Controls.Add(Me.cmdSetTimespan)
        Me.gpbxDisplaySettings.Controls.Add(Me.txtTimespan)
        Me.gpbxDisplaySettings.Controls.Add(Me.Label3)
        Me.gpbxDisplaySettings.Location = New System.Drawing.Point(549, 5)
        Me.gpbxDisplaySettings.Name = "gpbxDisplaySettings"
        Me.gpbxDisplaySettings.Size = New System.Drawing.Size(213, 64)
        Me.gpbxDisplaySettings.TabIndex = 1
        Me.gpbxDisplaySettings.TabStop = False
        Me.gpbxDisplaySettings.Text = "Display Settings"
        '
        'cmdSetTimespan
        '
        Me.cmdSetTimespan.Location = New System.Drawing.Point(153, 34)
        Me.cmdSetTimespan.Name = "cmdSetTimespan"
        Me.cmdSetTimespan.Size = New System.Drawing.Size(54, 24)
        Me.cmdSetTimespan.TabIndex = 15
        Me.cmdSetTimespan.Text = "SET"
        Me.cmdSetTimespan.UseVisualStyleBackColor = True
        '
        'txtTimespan
        '
        Me.txtTimespan.Location = New System.Drawing.Point(6, 34)
        Me.txtTimespan.Name = "txtTimespan"
        Me.txtTimespan.Size = New System.Drawing.Size(141, 23)
        Me.txtTimespan.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(5, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Timespan (ms):"
        '
        'gpbxGraph
        '
        Me.gpbxGraph.Controls.Add(Me.checkbxAutoScale)
        Me.gpbxGraph.Controls.Add(Me.cmdReset)
        Me.gpbxGraph.Controls.Add(Me.gpbxSaving)
        Me.gpbxGraph.Controls.Add(Me.cmdStop)
        Me.gpbxGraph.Controls.Add(Me.cmdStart)
        Me.gpbxGraph.Controls.Add(Me.labelProgress)
        Me.gpbxGraph.Controls.Add(Me.pgbarSingleMeasure)
        Me.gpbxGraph.Location = New System.Drawing.Point(6, 5)
        Me.gpbxGraph.Name = "gpbxGraph"
        Me.gpbxGraph.Size = New System.Drawing.Size(532, 339)
        Me.gpbxGraph.TabIndex = 0
        Me.gpbxGraph.TabStop = False
        Me.gpbxGraph.Text = "Graph Display"
        '
        'checkbxAutoScale
        '
        Me.checkbxAutoScale.AutoSize = True
        Me.checkbxAutoScale.Location = New System.Drawing.Point(442, 236)
        Me.checkbxAutoScale.Name = "checkbxAutoScale"
        Me.checkbxAutoScale.Size = New System.Drawing.Size(79, 19)
        Me.checkbxAutoScale.TabIndex = 8
        Me.checkbxAutoScale.Text = "AutoScale"
        Me.checkbxAutoScale.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(200, 234)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(75, 20)
        Me.cmdReset.TabIndex = 7
        Me.cmdReset.Text = "RESET"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'gpbxSaving
        '
        Me.gpbxSaving.Controls.Add(Me.GroupBox1)
        Me.gpbxSaving.Controls.Add(Me.cmdSave)
        Me.gpbxSaving.Controls.Add(Me.Label12)
        Me.gpbxSaving.Controls.Add(Me.Label11)
        Me.gpbxSaving.Controls.Add(Me.txtFilename)
        Me.gpbxSaving.Controls.Add(Me.txtDirectory)
        Me.gpbxSaving.Controls.Add(Me.cmdBrowse)
        Me.gpbxSaving.Location = New System.Drawing.Point(6, 259)
        Me.gpbxSaving.Name = "gpbxSaving"
        Me.gpbxSaving.Size = New System.Drawing.Size(520, 75)
        Me.gpbxSaving.TabIndex = 6
        Me.gpbxSaving.TabStop = False
        Me.gpbxSaving.Text = "Savings"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.checkbxAnalysis)
        Me.GroupBox1.Location = New System.Drawing.Point(434, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(80, 55)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Include"
        '
        'checkbxAnalysis
        '
        Me.checkbxAnalysis.AutoSize = True
        Me.checkbxAnalysis.Location = New System.Drawing.Point(6, 29)
        Me.checkbxAnalysis.Name = "checkbxAnalysis"
        Me.checkbxAnalysis.Size = New System.Drawing.Size(69, 19)
        Me.checkbxAnalysis.TabIndex = 1
        Me.checkbxAnalysis.Text = "Analysis"
        Me.checkbxAnalysis.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(353, 49)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 20)
        Me.cmdSave.TabIndex = 9
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(0, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 15)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Filename:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(0, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 15)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Directory:"
        '
        'txtFilename
        '
        Me.txtFilename.Location = New System.Drawing.Point(70, 49)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.Size = New System.Drawing.Size(277, 23)
        Me.txtFilename.TabIndex = 6
        '
        'txtDirectory
        '
        Me.txtDirectory.Location = New System.Drawing.Point(70, 26)
        Me.txtDirectory.Name = "txtDirectory"
        Me.txtDirectory.Size = New System.Drawing.Size(277, 23)
        Me.txtDirectory.TabIndex = 4
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(353, 26)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(75, 20)
        Me.cmdBrowse.TabIndex = 5
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'cmdStop
        '
        Me.cmdStop.Location = New System.Drawing.Point(281, 234)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(75, 20)
        Me.cmdStop.TabIndex = 3
        Me.cmdStop.Text = "STOP"
        Me.cmdStop.UseVisualStyleBackColor = True
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(362, 234)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(75, 20)
        Me.cmdStart.TabIndex = 2
        Me.cmdStart.Text = "START"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'labelProgress
        '
        Me.labelProgress.AutoSize = True
        Me.labelProgress.Location = New System.Drawing.Point(6, 233)
        Me.labelProgress.Name = "labelProgress"
        Me.labelProgress.Size = New System.Drawing.Size(39, 15)
        Me.labelProgress.TabIndex = 1
        Me.labelProgress.Text = "Status"
        '
        'pgbarSingleMeasure
        '
        Me.pgbarSingleMeasure.Location = New System.Drawing.Point(6, 207)
        Me.pgbarSingleMeasure.Name = "pgbarSingleMeasure"
        Me.pgbarSingleMeasure.Size = New System.Drawing.Size(520, 20)
        Me.pgbarSingleMeasure.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.gpbxIWSettings)
        Me.TabPage3.Controls.Add(Me.gpbxIWSaving)
        Me.TabPage3.Controls.Add(Me.gpbxIntensitySweep)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(768, 348)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'gpbxIWSettings
        '
        Me.gpbxIWSettings.Controls.Add(Me.cmdIWSetPara)
        Me.gpbxIWSettings.Controls.Add(Me.txtSweepFreq)
        Me.gpbxIWSettings.Controls.Add(Me.lblSweepFreq)
        Me.gpbxIWSettings.Controls.Add(Me.cbSweepType)
        Me.gpbxIWSettings.Controls.Add(Me.lblSweepType)
        Me.gpbxIWSettings.Controls.Add(Me.txtStepVolt)
        Me.gpbxIWSettings.Controls.Add(Me.lblGap)
        Me.gpbxIWSettings.Controls.Add(Me.txtEndVolt)
        Me.gpbxIWSettings.Controls.Add(Me.lblEndVolt)
        Me.gpbxIWSettings.Controls.Add(Me.txtStartVolt)
        Me.gpbxIWSettings.Controls.Add(Me.lblStartVolt)
        Me.gpbxIWSettings.Location = New System.Drawing.Point(623, 5)
        Me.gpbxIWSettings.Name = "gpbxIWSettings"
        Me.gpbxIWSettings.Size = New System.Drawing.Size(139, 263)
        Me.gpbxIWSettings.TabIndex = 2
        Me.gpbxIWSettings.TabStop = False
        Me.gpbxIWSettings.Text = "Sweep Settings"
        '
        'cmdIWSetPara
        '
        Me.cmdIWSetPara.Location = New System.Drawing.Point(6, 224)
        Me.cmdIWSetPara.Name = "cmdIWSetPara"
        Me.cmdIWSetPara.Size = New System.Drawing.Size(127, 31)
        Me.cmdIWSetPara.TabIndex = 24
        Me.cmdIWSetPara.Text = "Set Parameters"
        Me.cmdIWSetPara.UseVisualStyleBackColor = True
        '
        'txtSweepFreq
        '
        Me.txtSweepFreq.Location = New System.Drawing.Point(6, 199)
        Me.txtSweepFreq.Name = "txtSweepFreq"
        Me.txtSweepFreq.Size = New System.Drawing.Size(127, 23)
        Me.txtSweepFreq.TabIndex = 23
        '
        'lblSweepFreq
        '
        Me.lblSweepFreq.AutoSize = True
        Me.lblSweepFreq.Location = New System.Drawing.Point(6, 181)
        Me.lblSweepFreq.Name = "lblSweepFreq"
        Me.lblSweepFreq.Size = New System.Drawing.Size(102, 15)
        Me.lblSweepFreq.TabIndex = 22
        Me.lblSweepFreq.Text = "Sweep Frequency:"
        '
        'cbSweepType
        '
        Me.cbSweepType.FormattingEnabled = True
        Me.cbSweepType.Location = New System.Drawing.Point(6, 156)
        Me.cbSweepType.Name = "cbSweepType"
        Me.cbSweepType.Size = New System.Drawing.Size(127, 23)
        Me.cbSweepType.TabIndex = 21
        '
        'lblSweepType
        '
        Me.lblSweepType.AutoSize = True
        Me.lblSweepType.Location = New System.Drawing.Point(6, 139)
        Me.lblSweepType.Name = "lblSweepType"
        Me.lblSweepType.Size = New System.Drawing.Size(71, 15)
        Me.lblSweepType.TabIndex = 20
        Me.lblSweepType.Text = "Sweep Type:"
        '
        'txtStepVolt
        '
        Me.txtStepVolt.Location = New System.Drawing.Point(6, 116)
        Me.txtStepVolt.Name = "txtStepVolt"
        Me.txtStepVolt.Size = New System.Drawing.Size(127, 23)
        Me.txtStepVolt.TabIndex = 19
        '
        'lblGap
        '
        Me.lblGap.AutoSize = True
        Me.lblGap.Location = New System.Drawing.Point(6, 98)
        Me.lblGap.Name = "lblGap"
        Me.lblGap.Size = New System.Drawing.Size(31, 15)
        Me.lblGap.TabIndex = 18
        Me.lblGap.Text = "Gap:"
        '
        'txtEndVolt
        '
        Me.txtEndVolt.Location = New System.Drawing.Point(6, 75)
        Me.txtEndVolt.Name = "txtEndVolt"
        Me.txtEndVolt.Size = New System.Drawing.Size(127, 23)
        Me.txtEndVolt.TabIndex = 17
        '
        'lblEndVolt
        '
        Me.lblEndVolt.AutoSize = True
        Me.lblEndVolt.Location = New System.Drawing.Point(6, 57)
        Me.lblEndVolt.Name = "lblEndVolt"
        Me.lblEndVolt.Size = New System.Drawing.Size(77, 15)
        Me.lblEndVolt.TabIndex = 16
        Me.lblEndVolt.Text = "Voltage(End):"
        '
        'txtStartVolt
        '
        Me.txtStartVolt.Location = New System.Drawing.Point(6, 34)
        Me.txtStartVolt.Name = "txtStartVolt"
        Me.txtStartVolt.Size = New System.Drawing.Size(127, 23)
        Me.txtStartVolt.TabIndex = 15
        '
        'lblStartVolt
        '
        Me.lblStartVolt.AutoSize = True
        Me.lblStartVolt.Location = New System.Drawing.Point(6, 17)
        Me.lblStartVolt.Name = "lblStartVolt"
        Me.lblStartVolt.Size = New System.Drawing.Size(81, 15)
        Me.lblStartVolt.TabIndex = 14
        Me.lblStartVolt.Text = "Voltage(Start):"
        '
        'gpbxIWSaving
        '
        Me.gpbxIWSaving.Controls.Add(Me.ckbxIWSettings)
        Me.gpbxIWSaving.Controls.Add(Me.cmdIWSave)
        Me.gpbxIWSaving.Controls.Add(Me.Label14)
        Me.gpbxIWSaving.Controls.Add(Me.Label15)
        Me.gpbxIWSaving.Controls.Add(Me.txtIWFilename)
        Me.gpbxIWSaving.Controls.Add(Me.txtIWDirectory)
        Me.gpbxIWSaving.Controls.Add(Me.cmdIWBrowse)
        Me.gpbxIWSaving.Location = New System.Drawing.Point(6, 274)
        Me.gpbxIWSaving.Name = "gpbxIWSaving"
        Me.gpbxIWSaving.Size = New System.Drawing.Size(756, 71)
        Me.gpbxIWSaving.TabIndex = 1
        Me.gpbxIWSaving.TabStop = False
        Me.gpbxIWSaving.Text = "Saving"
        '
        'ckbxIWSettings
        '
        Me.ckbxIWSettings.AutoSize = True
        Me.ckbxIWSettings.Location = New System.Drawing.Point(617, 41)
        Me.ckbxIWSettings.Name = "ckbxIWSettings"
        Me.ckbxIWSettings.Size = New System.Drawing.Size(110, 19)
        Me.ckbxIWSettings.TabIndex = 16
        Me.ckbxIWSettings.Text = "Include Settings"
        Me.ckbxIWSettings.UseVisualStyleBackColor = True
        '
        'cmdIWSave
        '
        Me.cmdIWSave.Location = New System.Drawing.Point(530, 40)
        Me.cmdIWSave.Name = "cmdIWSave"
        Me.cmdIWSave.Size = New System.Drawing.Size(75, 20)
        Me.cmdIWSave.TabIndex = 15
        Me.cmdIWSave.Text = "Save"
        Me.cmdIWSave.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 15)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Filename:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 15)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Directory:"
        '
        'txtIWFilename
        '
        Me.txtIWFilename.Location = New System.Drawing.Point(76, 40)
        Me.txtIWFilename.Name = "txtIWFilename"
        Me.txtIWFilename.Size = New System.Drawing.Size(448, 23)
        Me.txtIWFilename.TabIndex = 12
        '
        'txtIWDirectory
        '
        Me.txtIWDirectory.Location = New System.Drawing.Point(76, 16)
        Me.txtIWDirectory.Name = "txtIWDirectory"
        Me.txtIWDirectory.Size = New System.Drawing.Size(448, 23)
        Me.txtIWDirectory.TabIndex = 10
        '
        'cmdIWBrowse
        '
        Me.cmdIWBrowse.Location = New System.Drawing.Point(530, 14)
        Me.cmdIWBrowse.Name = "cmdIWBrowse"
        Me.cmdIWBrowse.Size = New System.Drawing.Size(75, 20)
        Me.cmdIWBrowse.TabIndex = 11
        Me.cmdIWBrowse.Text = "Browse"
        Me.cmdIWBrowse.UseVisualStyleBackColor = True
        '
        'gpbxIntensitySweep
        '
        Me.gpbxIntensitySweep.Controls.Add(Me.lblIWStatus)
        Me.gpbxIntensitySweep.Controls.Add(Me.pgbarIW)
        Me.gpbxIntensitySweep.Controls.Add(Me.cmdIWReset)
        Me.gpbxIntensitySweep.Controls.Add(Me.cmdIWStop)
        Me.gpbxIntensitySweep.Controls.Add(Me.cmdIWStart)
        Me.gpbxIntensitySweep.Location = New System.Drawing.Point(6, 5)
        Me.gpbxIntensitySweep.Name = "gpbxIntensitySweep"
        Me.gpbxIntensitySweep.Size = New System.Drawing.Size(611, 263)
        Me.gpbxIntensitySweep.TabIndex = 0
        Me.gpbxIntensitySweep.TabStop = False
        Me.gpbxIntensitySweep.Text = "Intensity Sweep Plot"
        '
        'lblIWStatus
        '
        Me.lblIWStatus.AutoSize = True
        Me.lblIWStatus.Location = New System.Drawing.Point(6, 230)
        Me.lblIWStatus.Name = "lblIWStatus"
        Me.lblIWStatus.Size = New System.Drawing.Size(39, 15)
        Me.lblIWStatus.TabIndex = 15
        Me.lblIWStatus.Text = "Status"
        '
        'pgbarIW
        '
        Me.pgbarIW.Location = New System.Drawing.Point(6, 204)
        Me.pgbarIW.Name = "pgbarIW"
        Me.pgbarIW.Size = New System.Drawing.Size(599, 23)
        Me.pgbarIW.TabIndex = 8
        '
        'cmdIWReset
        '
        Me.cmdIWReset.Location = New System.Drawing.Point(368, 230)
        Me.cmdIWReset.Name = "cmdIWReset"
        Me.cmdIWReset.Size = New System.Drawing.Size(75, 27)
        Me.cmdIWReset.TabIndex = 7
        Me.cmdIWReset.Text = "RESET"
        Me.cmdIWReset.UseVisualStyleBackColor = True
        '
        'cmdIWStop
        '
        Me.cmdIWStop.Location = New System.Drawing.Point(449, 230)
        Me.cmdIWStop.Name = "cmdIWStop"
        Me.cmdIWStop.Size = New System.Drawing.Size(75, 27)
        Me.cmdIWStop.TabIndex = 6
        Me.cmdIWStop.Text = "STOP"
        Me.cmdIWStop.UseVisualStyleBackColor = True
        '
        'cmdIWStart
        '
        Me.cmdIWStart.Location = New System.Drawing.Point(530, 230)
        Me.cmdIWStart.Name = "cmdIWStart"
        Me.cmdIWStart.Size = New System.Drawing.Size(75, 27)
        Me.cmdIWStart.TabIndex = 5
        Me.cmdIWStart.Text = "START"
        Me.cmdIWStart.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 24)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(768, 348)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'tmrGlobal
        '
        Me.tmrGlobal.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 397)
        Me.Controls.Add(Me.tabAll)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.tabAll.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.gpbxSig.ResumeLayout(False)
        Me.gpbxSig.PerformLayout()
        Me.gpbxSigManual.ResumeLayout(False)
        Me.gpbxSigManual.PerformLayout()
        Me.gpbxSigAuto.ResumeLayout(False)
        Me.gpbxOsc.ResumeLayout(False)
        Me.gpbxOsc.PerformLayout()
        Me.gpbxOscManual.ResumeLayout(False)
        Me.gpbxOscManual.PerformLayout()
        Me.gpbxOscAuto.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.gpbxAnalysis.ResumeLayout(False)
        Me.gpbxAnalysis.PerformLayout()
        Me.gpbxSigSettings.ResumeLayout(False)
        Me.gpbxSigSettings.PerformLayout()
        Me.gpbxDisplaySettings.ResumeLayout(False)
        Me.gpbxDisplaySettings.PerformLayout()
        Me.gpbxGraph.ResumeLayout(False)
        Me.gpbxGraph.PerformLayout()
        Me.gpbxSaving.ResumeLayout(False)
        Me.gpbxSaving.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.gpbxIWSettings.ResumeLayout(False)
        Me.gpbxIWSettings.PerformLayout()
        Me.gpbxIWSaving.ResumeLayout(False)
        Me.gpbxIWSaving.PerformLayout()
        Me.gpbxIntensitySweep.ResumeLayout(False)
        Me.gpbxIntensitySweep.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabAll As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cmdManualOscCnct As Button
    Friend WithEvents txtOscManualInput As TextBox
    Friend WithEvents gpbxOsc As GroupBox
    Friend WithEvents labelEA As Label
    Friend WithEvents gpbxOscManual As GroupBox
    Friend WithEvents gpbxOscAuto As GroupBox
    Friend WithEvents cmdFindOsc As Button
    Friend WithEvents cmdAutoOscCnct As Button
    Friend WithEvents cbAllOsc As ComboBox
    Friend WithEvents gpbxSig As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCurrentSig As TextBox
    Friend WithEvents gpbxSigManual As GroupBox
    Friend WithEvents cmdManualSigCnct As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSigManualInput As TextBox
    Friend WithEvents gpbxSigAuto As GroupBox
    Friend WithEvents cmdFindSig As Button
    Friend WithEvents cmdAutoSigCnct As Button
    Friend WithEvents cbAllSig As ComboBox
    Friend WithEvents lblConnectedDevice As Label
    Friend WithEvents txtCurrentOsc As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents cmdDisconnectSig As Button
    Friend WithEvents cmdDisconnectOsc As Button
    Friend WithEvents gpbxAnalysis As GroupBox
    Friend WithEvents txttauOFF As TextBox
    Friend WithEvents txttauON As TextBox
    Friend WithEvents txtPeakOFF As TextBox
    Friend WithEvents txtPeakON As TextBox
    Friend WithEvents lblTauLEDoff As Label
    Friend WithEvents lblTauLEDon As Label
    Friend WithEvents lblPkLEDoff As Label
    Friend WithEvents lblPkLEDon As Label
    Friend WithEvents gpbxSigSettings As GroupBox
    Friend WithEvents txtFrequency As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents gpbxDisplaySettings As GroupBox
    Friend WithEvents gpbxGraph As GroupBox
    Friend WithEvents pgbarSingleMeasure As ProgressBar
    Friend WithEvents gpbxSaving As GroupBox
    Friend WithEvents cmdSave As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtFilename As TextBox
    Friend WithEvents txtDirectory As TextBox
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents cmdStop As Button
    Friend WithEvents cmdStart As Button
    Friend WithEvents labelProgress As Label
    Friend WithEvents gpbxIWSettings As GroupBox
    Friend WithEvents cbSweepType As ComboBox
    Friend WithEvents lblSweepType As Label
    Friend WithEvents txtStepVolt As TextBox
    Friend WithEvents lblGap As Label
    Friend WithEvents txtEndVolt As TextBox
    Friend WithEvents lblEndVolt As Label
    Friend WithEvents txtStartVolt As TextBox
    Friend WithEvents lblStartVolt As Label
    Friend WithEvents gpbxIWSaving As GroupBox
    Friend WithEvents ckbxIWSettings As CheckBox
    Friend WithEvents cmdIWSave As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtIWFilename As TextBox
    Friend WithEvents txtIWDirectory As TextBox
    Friend WithEvents cmdIWBrowse As Button
    Friend WithEvents gpbxIntensitySweep As GroupBox
    Friend WithEvents cmdIWStart As Button
    Friend WithEvents cbWaveform As ComboBox
    Friend WithEvents tmrGlobal As Windows.Forms.Timer
    Friend WithEvents cmdSetPara As Button
    Friend WithEvents cmdReset As Button
    Friend WithEvents txtAmplitude As TextBox
    Friend WithEvents labelVolt As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents checkbxAnalysis As CheckBox
    Friend WithEvents cmdIWSetPara As Button
    Friend WithEvents txtSweepFreq As TextBox
    Friend WithEvents lblSweepFreq As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTimespan As TextBox
    Friend WithEvents checkbxAutoScale As CheckBox
    Friend WithEvents lblIWStatus As Label
    Friend WithEvents pgbarIW As ProgressBar
    Friend WithEvents cmdIWReset As Button
    Friend WithEvents cmdIWStop As Button
    Friend WithEvents cmdSetTimespan As Button

    '' '''''''''''''' '''''''''''''''
    '' Global Parameters Declaring ''
    '' '''''''''''''' '''''''''''''''

    'For hardware control
    Public allOsc As New List(Of String)()
    Public allSig As New List(Of String)()
    Private Shared oscControl As New hwInterface
    Private Shared sigGenControl As New hwInterface

    'For saving
    Private Shared readerwriter As New readwrite

    'For plotting
    Private Shared smPlotView As New PlotView()
    Private Shared iwPlotView As New PlotView()
    Private Shared smOxyplotHandler As New OxyplotHandler(smPlotView)
    Private Shared iwOxyplotHandler As New OxyplotHandler(iwPlotView)

    'For single measurement and signal averaging
    Public Shared SAParameters As New signalAveraging()
    Private Shared progressFlag As Boolean = False
    Private Shared stopIndicator As Boolean = False
    Private Shared _cancellationToken As New Threading.CancellationTokenSource() 'Token to cancel the loop
    Private Shared resultVoltage As Double()
    Private Shared resultTime As Double()


    'For intensity sweep
    Private Shared IWprogressFlag As Boolean = False
    Private Shared IWStopIndicator As Boolean = False
    Private Shared _IWcancellationToken As New Threading.CancellationTokenSource() 'Token to cancel the loop
    Public Shared IWParameters As New IntensitySweep()
    Dim startvolt_to_save As Double
    Dim endvolt_to_save As Double
    Dim stepvolt_to_save As Double
    Dim sweepFreq_to_save As Double
    Dim sweepType_to_save As String

    'reader writer lock - used to prevent errors in multithreading
    Private Shared rwLock As New ReaderWriterLockSlim()

    'Custom exception to interupt running loop
    Private Class LoopCanceledException
        Inherits Exception
    End Class

    'Used for preserving data between sessions
    Dim appPath As String = Application.StartupPath






    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load the preserved information
        Try
            Dim sm_Frequency As String = My.Computer.FileSystem.ReadAllText(appPath & "\smfrequency.txt")
            txtFrequency.Text = sm_Frequency
        Catch ex As System.IO.FileNotFoundException
            'Assign null if no preserved info found
            txtFrequency.Text = ""
        End Try

        Try
            Dim sm_PkVoltage As String = My.Computer.FileSystem.ReadAllText(appPath & "\smPkVoltage.txt")
            txtAmplitude.Text = sm_PkVoltage
        Catch ex As System.IO.FileNotFoundException
            'Assign null if no preserved info found
            txtAmplitude.Text = ""
        End Try

        Try
            Dim iw_StartVolt As String = My.Computer.FileSystem.ReadAllText(appPath & "\iwStartVolt.txt")
            txtStartVolt.Text = iw_StartVolt
        Catch ex As System.IO.FileNotFoundException
            'Assign null if no preserved info found
            txtStartVolt.Text = ""
        End Try

        Try
            Dim iw_EndVolt As String = My.Computer.FileSystem.ReadAllText(appPath & "\iwEndVolt.txt")
            txtEndVolt.Text = iw_EndVolt
        Catch ex As System.IO.FileNotFoundException
            'Assign null if no preserved info found
            txtEndVolt.Text = ""
        End Try

        Try
            Dim iw_StepVolt As String = My.Computer.FileSystem.ReadAllText(appPath & "\iwStepVolt.txt")
            txtStepVolt.Text = iw_StepVolt
        Catch ex As System.IO.FileNotFoundException
            'Assign null if no preserved info found
            txtStepVolt.Text = ""
        End Try

        Try
            Dim iw_SweepFreq As String = My.Computer.FileSystem.ReadAllText(appPath & "\iw_SweepFreq.txt")
            txtSweepFreq.Text = iw_SweepFreq
        Catch ex As System.IO.FileNotFoundException
            'Assign null if no preserved info found
            txtSweepFreq.Text = ""
        End Try
        txtDirectory.Text = appPath


        'Initialize button status
        tmrGlobal.Enabled = True
        cmdStop.Enabled = False

        'Initialize tabcontrol
        Me.Text = "Control Software to Measure Retinomorphic Sensors"
        TabPage1.Text = "Connection"
        TabPage2.Text = "Single Measurement"
        TabPage3.Text = "Intensity Sweep"
        tabAll.TabPages.Remove(TabPage4)

        'Initialize comboBoxes
        cbWaveform.Items.Add("Sine")
        cbWaveform.Items.Add("Square")
        cbWaveform.SelectedIndex = 0
        cbAllOsc.Items.Add("Select a device")
        cbSweepType.Items.Add("Sine")
        cbSweepType.Items.Add("Square")
        cbSweepType.SelectedIndex = 0
        cbAllOsc.SelectedIndex = 0
        cbAllSig.Items.Add("Select a device")
        cbAllSig.SelectedIndex = 0


        'Initialize plots
        'smOxyplotHandler.DataSeries(time, voltage)
        smOxyplotHandler.setPlotViewSize(500, 190)
        smOxyplotHandler.setupAxis("Time", "s", "Voltage", "V")
        smOxyplotHandler.setupLegends()
        smOxyplotHandler.addToPlotView()
        'smOxyplotHandler.autoScale(voltage)
        gpbxGraph.Controls.Add(smPlotView)

        'iwOxyplotHandler.DataSeries(time, voltage)
        iwOxyplotHandler.setPlotViewSize(580, 170)
        iwOxyplotHandler.setupAxis("Sweep Intensity", "V", "Measured Voltage", "V")
        iwOxyplotHandler.setupLegends()
        iwOxyplotHandler.addToPlotView()
        'smOxyplotHandler.autoScale(voltage)
        gpbxIntensitySweep.Controls.Add(iwPlotView)
    End Sub


    '' '''''''''''''''' ''''''''''''''''''''''
    '' ''''''''''Connection Tab'' ''''''''''''
    '' '''''''''''''''' ''''''''''''''''''''''

    '' '''''' ''
    '' Update ''
    '' '''''' ''
    Private Sub tmrGlobal_Tick(sender As Object, e As EventArgs) Handles tmrGlobal.Tick
        txtCurrentOsc.Text = oscControl.getCurrentScope()
        txtCurrentSig.Text = sigGenControl.getCurrentGen()
    End Sub

    '' ''''' ''
    '' Event ''
    '' ''''' ''
    ' Find all the osc plugged in
    Private Sub cmdFindDevice_Click(sender As Object, e As EventArgs) Handles cmdFindOsc.Click
        allOsc = oscControl.getAllScope()
        Try
            If allOsc IsNot Nothing Then
                For Each item As String In allOsc
                    cbAllOsc.Items.Add(item)
                Next
            Else
                MessageBox.Show("No device found")
            End If


        Catch ex As NullReferenceException
            MessageBox.Show("No device found")
        End Try
    End Sub
    ' Find all the signal generator plugged in
    Private Sub cmdFindSig_Click(sender As Object, e As EventArgs) Handles cmdFindSig.Click
        allSig = sigGenControl.getAllGen()
        Try
            If allSig IsNot Nothing Then
                For Each item As String In allSig
                    cbAllSig.Items.Add(item)
                Next
            Else
                MessageBox.Show("No device found")
            End If

        Catch ex As NullReferenceException
            MessageBox.Show("No device found")
        End Try
    End Sub

    '' Connect to selected device ''
    Private Sub cmdCncttoSeclected_Click(sender As Object, e As EventArgs) Handles cmdAutoOscCnct.Click
        Dim selectedDevice As String
        selectedDevice = cbAllOsc.SelectedItem.ToString()
        oscControl.connectScope(selectedDevice)
    End Sub
    Private Sub cmdAutoSigCnct_Click(sender As Object, e As EventArgs) Handles cmdAutoSigCnct.Click
        Dim selectedDevice As String
        selectedDevice = cbAllSig.SelectedItem.ToString()
        sigGenControl.connectSigGen(selectedDevice)
    End Sub

    '' Disconnect current Device ''
    Private Sub cmdDisconnectOsc_Click(sender As Object, e As EventArgs) Handles cmdDisconnectOsc.Click
        oscControl.disconnectScope()
    End Sub
    Private Sub cmdDisconnectSig_Click(sender As Object, e As EventArgs) Handles cmdDisconnectSig.Click
        sigGenControl.disconnectSigGen()
    End Sub

    '' Connect to the manually input address ''
    Private Sub cmdCnctManual_Click(sender As Object, e As EventArgs) Handles cmdManualOscCnct.Click
        oscControl.connectScope(txtOscManualInput.Text)
    End Sub
    Private Sub cmdManualSigCnct_Click(sender As Object, e As EventArgs) Handles cmdManualSigCnct.Click
        sigGenControl.connectSigGen(txtSigManualInput.Text)
    End Sub



    '' '''''''''''''''' ''''''''''''''''''''''
    '' '''''''Single Measument'' '''''''''''''
    '' '''''''''''''''' ''''''''''''''''''''''

    '' ''''''''' ''
    '' Functions ''
    '' ''''''''' ''
    'calculate the tau for LED turned on
    Private Function calculateTauON()
        Dim minVal As Double = Double.MaxValue
        Dim minIdx As Integer
        Dim tauON As Double = 0
        If SAParameters.averageVoltage IsNot Nothing Then
            For i As Integer = 0 To SAParameters.averageVoltage.Length - 1
                If SAParameters.averageVoltage(i) < minVal Then
                    minVal = SAParameters.averageVoltage(i)
                    minIdx = i
                End If
            Next
            Dim limitON As Integer = minIdx
            While SAParameters.averageVoltage(limitON) < minVal * (1 / Math.E) And limitON < SAParameters.averageVoltage.Length - 1
                limitON = limitON + 1
            End While
            tauON = SAParameters.currentTime(minIdx) - SAParameters.currentTime(limitON)
            Return tauON.ToString
        Else
            Return "No data"
        End If
    End Function
    'calculate the tau for LED turned off
    Private Function calculateTauOFF()
        Dim maxVal As Double = Double.MinValue
        Dim maxIdx As Integer
        Dim tauOFF As Double
        If SAParameters.averageVoltage IsNot Nothing Then
            For i As Integer = 0 To SAParameters.averageVoltage.Length - 1
                If SAParameters.averageVoltage(i) > maxVal Then
                    maxVal = SAParameters.averageVoltage(i)
                    maxIdx = i
                End If
            Next
            Dim limitOFF As Integer = maxIdx
            While SAParameters.averageVoltage(limitOFF) > maxVal * (1 / Math.E) And limitOFF < SAParameters.averageVoltage.Length - 1
                limitOFF = limitOFF + 1
            End While
            tauOFF = SAParameters.currentTime(limitOFF) - SAParameters.currentTime(maxIdx)
            Return tauOFF.ToString
        Else
            Return "No data"
        End If
    End Function
    'calculate peak voltage for LED turned on
    Private Function calculatePeakON()
        Dim minVal As Double = Double.MaxValue
        Dim minIdx As Integer
        If SAParameters.averageVoltage IsNot Nothing Then
            For i As Integer = 0 To SAParameters.averageVoltage.Length - 1
                If SAParameters.averageVoltage(i) < minVal Then
                    minVal = SAParameters.averageVoltage(i)
                    minIdx = i
                End If
            Next
            Return minVal.ToString
        End If
        Return "No data"
    End Function
    'calculate peak voltage for LED turned off
    Private Function calculatePeakOFF()
        Dim maxVal As Double = Double.MinValue
        Dim maxIdx As Integer
        If SAParameters.averageVoltage IsNot Nothing Then
            For i As Integer = 0 To SAParameters.averageVoltage.Length - 1
                If SAParameters.averageVoltage(i) > maxVal Then
                    maxVal = SAParameters.averageVoltage(i)
                    maxIdx = i
                End If
            Next
            Return maxVal.ToString
        End If
        Return "No data"
    End Function

    'acquire data from oscilloscope
    Public Function acquireData() As (Double(), Double())
        Dim datastring As String
        Dim timeStep As Double = oscControl.getTimeStep()


        oscControl.autoScale()
        Thread.Sleep(2000)

        datastring = oscControl.readRawData()
        'datastring = oscControl.readRawData()
        Thread.Sleep(1000)
        oscControl.runScope()

        Dim dataStringArray As String() = datastring.Split(",")
        Dim dataArray(dataStringArray.Length - 1) As Double
        Dim timeArray(dataStringArray.Length - 1) As Double
        For i As Integer = 0 To dataStringArray.Length - 1
            Double.TryParse(dataStringArray(i), dataArray(i))
            timeArray(i) = i * timeStep
        Next
        Return (timeArray, dataArray)
    End Function

    'conduct signal averaging and plotting
    Public Function signalAveraging() As (Double(), Double())

        If stopIndicator = True And progressFlag = True Then
            stopIndicator = False
            For i As Integer = SAParameters._loopIndex To 100
                If _cancellationToken.IsCancellationRequested Then
                    'If the loop should be stopped, throw an OperationCanceledException to exit the loop
                    Try
                        Throw New LoopCanceledException()
                    Catch ex As LoopCanceledException
                        MessageBox.Show("Progress Stopped")
                        _cancellationToken.Dispose()
                        _cancellationToken = New Threading.CancellationTokenSource()
                        tmrGlobal.Enabled = True
                        Return (SAParameters.currentTime, SAParameters.averageVoltage)
                    End Try

                End If

                Dim tempData = acquireData()
                Dim tempVolt As Double() = tempData.Item2
                Dim tempTime As Double() = tempData.Item1


                For j As Integer = 0 To SAParameters.datalength
                    SAParameters.currentVolt(j) = SAParameters.currentVolt(j) + tempVolt(j)
                    SAParameters.currentTime(j) = tempTime(j)
                    SAParameters.averageVoltage(j) = SAParameters.currentVolt(j) / i + 1
                Next
                UpdateUI(i, SAParameters.averageVoltage, tempTime)
                SAParameters._loopIndex = i

            Next
            progressFlag = False
            'Re-enable the start button AND parameter setting button when the loop has finished/stopped



            Invoke(Sub() cmdStart.Enabled = True)
            Invoke(Sub() cmdSetPara.Enabled = True)
            Invoke(Sub() checkbxAnalysis.Enabled = True)
            Return (SAParameters.currentTime, SAParameters.averageVoltage)
        End If

        If stopIndicator = False And progressFlag = True Then
            SAParameters.sampleData = acquireData()
            SAParameters.datalength = SAParameters.sampleData.Item1.Length - 1
            ReDim SAParameters.currentVolt(SAParameters.datalength)
            ReDim SAParameters.averageVoltage(SAParameters.datalength)
            ReDim SAParameters.currentTime(SAParameters.datalength)

            For i As Integer = SAParameters._loopIndex To 100
                If _cancellationToken.IsCancellationRequested Then
                    'If the loop should be stopped, throw an OperationCanceledException to exit the loop
                    Try
                        Throw New LoopCanceledException()
                    Catch ex As LoopCanceledException
                        MessageBox.Show("Progress Stopped")
                        _cancellationToken.Dispose()
                        _cancellationToken = New Threading.CancellationTokenSource()
                        tmrGlobal.Enabled = True

                        Return (SAParameters.currentTime, SAParameters.averageVoltage)
                    End Try

                End If

                Dim tempData = acquireData()
                Dim tempVolt As Double() = tempData.Item2
                Dim tempTime As Double() = tempData.Item1

                For j As Integer = 0 To SAParameters.datalength
                    SAParameters.currentVolt(j) = SAParameters.currentVolt(j) + tempVolt(j)
                    SAParameters.currentTime(j) = tempTime(j)
                    SAParameters.averageVoltage(j) = SAParameters.currentVolt(j) / (i + 1)
                Next
                UpdateUI(i, SAParameters.averageVoltage, tempTime)
                SAParameters._loopIndex = i

            Next
            progressFlag = False
            'Re-enable the start button AND parameter setting button when the loop has finished/stopped
            Invoke(Sub() cmdStart.Enabled = True)
            Invoke(Sub() cmdSetPara.Enabled = True)
            Invoke(Sub() checkbxAnalysis.Enabled = True)
            Return (SAParameters.currentTime, SAParameters.averageVoltage)

        Else
            Return (SAParameters.currentTime, SAParameters.averageVoltage)
        End If
    End Function

    'plotting / updating function called by signal averaging
    Private Sub UpdateUI(ByVal i As Integer, ByVal averageVoltage As Double(), ByVal tempTime As Double())
        'Invoke the UI update on the main thread to prevent cross-threading exceptions
        Invoke(Sub()
                   'Update the UI here
                   smOxyplotHandler.plot_autoScale(averageVoltage, tempTime)

                   smOxyplotHandler.UpdateDataSeries(tempTime, averageVoltage)
                   smOxyplotHandler.addToPlotView()
                   gpbxGraph.Controls.Add(smPlotView)
                   pgbarSingleMeasure.Value = i
                   labelProgress.Text = "Measuring " & i.ToString() & " out of 100..."
                   txttauOFF.Text = calculateTauOFF().ToString
                   txttauON.Text = calculateTauON().ToString
                   txtPeakON.Text = calculatePeakON().ToString
                   txtPeakOFF.Text = calculatePeakOFF().ToString
               End Sub)
    End Sub


    '' '''''' ''
    '' Events ''
    '' '''''' ''
    'Browse for file path(saving path)
    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        Dim fpSingleMeasurement As String
        fpSingleMeasurement = readerwriter.getFilePath()
        txtDirectory.Text = fpSingleMeasurement
    End Sub
    'Save data to csv/txt files
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        'check filename availability

        If File.Exists(txtDirectory.Text & "\" & txtFilename.Text & ".csv") Then
            MessageBox.Show("Filename Existed")
            Return
        End If

        If resultVoltage IsNot Nothing And resultTime IsNot Nothing Then
            readerwriter.writeData(txtDirectory.Text & "/" & txtFilename.Text & ".csv", resultTime, resultVoltage)
            If checkbxAnalysis.Checked Then
                Dim filePath As String = txtDirectory.Text & "/" & txtFilename.Text & "_Analysis.txt"
                Dim fileContent As String = lblPkLEDon.Text & txtPeakON.Text & "," & lblPkLEDoff.Text & txtPeakOFF.Text & "," & lblTauLEDon.Text & txttauON.Text & "," & lblTauLEDoff.Text & txttauOFF.Text
                File.WriteAllText(filePath, fileContent)
            End If
            MessageBox.Show("File saved")
        Else
            MessageBox.Show("Data is empty, file is not saved")
        End If

    End Sub

    'Set the time span of the plot
    Private Sub cmdSetTimespan_Click(sender As Object, e As EventArgs) Handles cmdSetTimespan.Click
        smOxyplotHandler.plot_customScale(txtTimespan.Text)
        smOxyplotHandler._plotView.InvalidatePlot(True)
    End Sub

    'Start single measuremtn (signal averaging)
    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        'Disable the start button to prevent multiple instances of the loop from running simultaneously
        cmdStart.Enabled = False
        cmdSetPara.Enabled = False
        tmrGlobal.Enabled = False
        checkbxAutoScale.Enabled = False
        progressFlag = True
        cmdStop.Enabled = True
        oscControl.setWaveFormatAsc()
        'Start the signalgenerator
        'sigGenControl.startOutput()

        'Start the loop on a separate thread
        Dim SAthread As New Threading.Thread(AddressOf SAloop)
        SAthread.Start()
    End Sub

    'loop called by start, being addressed to a new thread
    Public Sub SAloop()
        'rwLock.EnterWriteLock()
        Dim resultData = signalAveraging()
        resultVoltage = resultData.Item2
        resultTime = resultData.Item1
        tmrGlobal.Enabled = True
        'rwLock.ExitWriteLock()
    End Sub

    ''Stop the single measurement
    Private Sub cmdStop_Click(sender As Object, e As EventArgs) Handles cmdStop.Click
        cmdStop.Enabled = False
        stopIndicator = True
        progressFlag = False
        labelProgress.Text = "Progress stopped at " & SAParameters._loopIndex.ToString & " out of 100"
        cmdStart.Enabled = True
        _cancellationToken.Cancel()
    End Sub

    'Reset the single measurement
    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        'Reset the loop index variable
        SAParameters.Reset()
        stopIndicator = False
        labelProgress.Text = "Status"
        pgbarSingleMeasure.Value = 0
        'Create a new cancellation token to cancel the existing loop
        _cancellationToken.Dispose()
        _cancellationToken = New Threading.CancellationTokenSource()

        'Re-enable the start button
        cmdStart.Enabled = True
        checkbxAutoScale.Enabled = True
    End Sub

    'Set signal generator output
    Private Sub cmdSetPara_Click(sender As Object, e As EventArgs) Handles cmdSetPara.Click
        sigGenControl.setWaveForm(cbWaveform.Text)
        sigGenControl.setFrequency(txtFrequency.Text)
        sigGenControl.setAmplitude(txtAmplitude.Text)
    End Sub



    '' '''''''''''''''''''''''' '''''''''''''''''''''' ''
    '' ''''''''''''intensity sweep tab '' ''''''''''''''
    ' '''''''''''''''''''''' '''''''''''''''''''''''''''''

    '' '''''''' ''
    '' Function ''
    '' '''''''' ''

    'main loop for intensity sweep
    Public Sub getsweepdata()
        Dim tempdata As Double()

        If IWStopIndicator = False And IWprogressFlag = True Then

            Try
                IWParameters.startvolt = Double.Parse(txtStartVolt.Text)
                IWParameters.endvolt = Double.Parse(txtEndVolt.Text)
                IWParameters.stepvolt = Double.Parse(txtStepVolt.Text)
                IWParameters.sweepFreq = Double.Parse(txtSweepFreq.Text)
                IWParameters._loopIndex = IWParameters.startvolt


                For i As Double = IWParameters._loopIndex To IWParameters.endvolt Step IWParameters.stepvolt
                    If _IWcancellationToken.IsCancellationRequested Then
                        'If the loop should be stopped, throw an OperationCanceledException to exit the loop
                        Try
                            Throw New LoopCanceledException()
                        Catch ex As LoopCanceledException
                            MessageBox.Show("Progress Stopped")
                            _IWcancellationToken.Dispose()
                            _IWcancellationToken = New Threading.CancellationTokenSource()
                            tmrGlobal.Enabled = True
                            cmdIWStop.Enabled = False
                            Return
                        End Try

                    End If

                    sigGenControl.setAmplitude(i.ToString)
                    Thread.Sleep(1000)

                    If IWprogressFlag = False Then
                        Return
                    End If

                    tempdata = IWacquireData()

                    If IWprogressFlag = False Then
                        Return
                    End If

                    IWParameters.sweepData.Add(tempdata)
                    IWParameters._loopIndex = i
                    IW_UpdateUI(i, IWParameters.sweepData, IWParameters.startvolt, IWParameters.endvolt, IWParameters.stepvolt)

                Next

            Catch ex As FormatException
                MessageBox.Show("invalid parameter")
                Return
            End Try
        End If

        If IWStopIndicator = True And IWprogressFlag = True Then
            IWStopIndicator = False
            Try

                For i As Double = IWParameters._loopIndex To IWParameters.endvolt Step IWParameters.stepvolt
                    If _IWcancellationToken.IsCancellationRequested Then
                        'If the loop should be stopped, throw an OperationCanceledException to exit the loop
                        Try
                            Throw New LoopCanceledException()
                        Catch ex As LoopCanceledException
                            MessageBox.Show("Progress Stopped")
                            _IWcancellationToken.Dispose()
                            _IWcancellationToken = New Threading.CancellationTokenSource()
                            tmrGlobal.Enabled = True

                            Return
                        End Try

                    End If

                    sigGenControl.setAmplitude(i.ToString)
                    Thread.Sleep(1000)
                    If IWprogressFlag = False Then
                        Return
                    End If
                    tempdata = IWacquireData()
                    If IWprogressFlag = False Then
                        Return
                    End If
                    IWParameters.sweepData.Add(tempdata)
                    IWParameters._loopIndex = i
                    IW_UpdateUI(i, IWParameters.sweepData, IWParameters.startvolt, IWParameters.endvolt, IWParameters.stepvolt)
                Next

            Catch ex As FormatException
                MessageBox.Show("invalid parameter")
                Return
            End Try
        End If
        progressFlag = False
        'Re-enable the start button AND parameter setting button when the loop has finished/stopped
        Invoke(Sub() cmdIWStart.Enabled = True)
        Invoke(Sub() cmdIWSetPara.Enabled = True)
        Return

    End Sub

    'plotting / updating function called by intensity sweep
    Public Sub IW_UpdateUI(ByVal i, ByVal sweepData, ByVal startvolt, ByVal endvolt, ByVal stepvolt)
        Invoke(Sub()
                   iwOxyplotHandler.IW_plot_autoScale(sweepData, startvolt, endvolt)
                   iwOxyplotHandler.boxSeries(sweepData, startvolt, stepvolt)
                   iwOxyplotHandler.addToPlotView()
                   gpbxIntensitySweep.Controls.Add(iwPlotView)
                   lblIWStatus.Text = "Current measuing data at " & i.ToString & " V"
               End Sub)
    End Sub

    'acquire data from oscilloscope, for intensity sweep only
    Public Function IWacquireData() As Double()
        Dim datastring As String
        oscControl.setWaveFormatAsc()

        oscControl.autoScale()
        Thread.Sleep(3000)


        datastring = oscControl.readRawData()
        'datastring = oscControl.readRawData()
        Thread.Sleep(1000)
        oscControl.runScope()

        Dim dataStringArray As String() = datastring.Split(",")
        Dim dataArray(dataStringArray.Length - 1) As Double
        For i As Integer = 0 To dataStringArray.Length - 1
            Double.TryParse(dataStringArray(i), dataArray(i))
        Next
        Return (dataArray)
    End Function





    '' ''''' ''
    '' Event ''
    '' ''''' ''

    'Start the intensity sweep
    Private Sub cmdIWStart_Click(sender As Object, e As EventArgs) Handles cmdIWStart.Click
        'sweepData.Clear()
        'getsweepdata()

        'Disable the start button to prevent multiple instances of the loop from running simultaneously
        cmdIWStart.Enabled = False
        cmdIWSetPara.Enabled = False
        tmrGlobal.Enabled = False
        IWprogressFlag = True
        cmdIWStop.Enabled = True

        'Start the signalgenerator
        'sigGenControl.startOutput()

        'Start the loop on a separate thread
        Dim IWthread As New Threading.Thread(AddressOf IWloop)
        IWthread.Start()
    End Sub
    'loop called by start, addressed by a new thread
    Public Sub IWloop()
        getsweepdata()
        tmrGlobal.Enabled = True
    End Sub
    'conduct the STOP function for intensity sweep
    Private Sub cmdIWStop_Click(sender As Object, e As EventArgs) Handles cmdIWStop.Click
        cmdIWStop.Enabled = False
        IWStopIndicator = True
        IWprogressFlag = False

        cmdIWStart.Enabled = True
        _IWcancellationToken.Cancel()
        lblIWStatus.Text = "Progress stopped at " & IWParameters._loopIndex.ToString & "V"
    End Sub

    'Reset the intensity sweep status
    Private Sub cmdIWReset_Click(sender As Object, e As EventArgs) Handles cmdIWReset.Click
        'Reset the loop index variable
        IWParameters.Reset()
        IWStopIndicator = False
        lblIWStatus.Text = "Status"
        pgbarIW.Value = 0
        'Create a new cancellation token to cancel the existing loop
        _IWcancellationToken.Dispose()
        _IWcancellationToken = New Threading.CancellationTokenSource()

        'Re-enable the start button
        cmdIWStart.Enabled = True
    End Sub

    'Set signal generator output
    Private Sub cmdIWSetPara_Click(sender As Object, e As EventArgs) Handles cmdIWSetPara.Click
        sigGenControl.setWaveForm(cbSweepType.Text)
        sigGenControl.setFrequency(txtSweepFreq.Text)

    End Sub

    'Browse the saving path
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles cmdIWBrowse.Click
        Dim fpIntensitySweep As String
        fpIntensitySweep = readerwriter.getFilePath()
        txtIWDirectory.Text = fpIntensitySweep
    End Sub

    'Save files and settings for intensity sweep
    Private Sub cmdIWSave_Click(sender As Object, e As EventArgs) Handles cmdIWSave.Click
        If File.Exists(txtIWDirectory.Text & "\" & txtIWFilename.Text & ".csv") Then
            MessageBox.Show("Filename Existed")
            Return
        End If

        If IWParameters.sweepData IsNot Nothing Then
            readerwriter.writeDataIW(txtIWDirectory.Text & "/" & txtIWFilename.Text & ".csv", IWParameters.sweepData)
            If ckbxIWSettings.Checked Then
                Dim filePath As String = txtIWDirectory.Text & "/" & txtIWFilename.Text & "_Parameters.txt"
                Dim fileContent As String = lblStartVolt.Text & IWParameters.startvolt.ToString & "," & lblEndVolt.Text & IWParameters.endvolt.ToString & "," & lblGap.Text & IWParameters.stepvolt.ToString & "," & lblSweepFreq.Text & IWParameters.sweepFreq.ToString & "," & lblSweepType.Text & cbSweepType.Text
                File.WriteAllText(filePath, fileContent)
            End If
            MessageBox.Show("File saved")
        Else
            MessageBox.Show("Data is empty, file is not saved")
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Save info in text box to txt files
        My.Computer.FileSystem.WriteAllText(appPath & "\smfrequency.txt", txtFrequency.Text, False)
        My.Computer.FileSystem.WriteAllText(appPath & "\smPkVoltage.txt", txtAmplitude.Text, False)
        My.Computer.FileSystem.WriteAllText(appPath & "\iwStartVolt.txt", txtStartVolt.Text, False)
        My.Computer.FileSystem.WriteAllText(appPath & "\iwEndVolt.txt", txtEndVolt.Text, False)
        My.Computer.FileSystem.WriteAllText(appPath & "\iwStepVolt.txt", txtStepVolt.Text, False)
        My.Computer.FileSystem.WriteAllText(appPath & "\iwSweepFreq.txt", txtSweepFreq.Text, False)
    End Sub
End Class
