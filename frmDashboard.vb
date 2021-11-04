'=============================================================================
Imports System.IO, MadMilkman, MadMilkman.Ini
Imports System.Threading.Tasks
Imports System.Threading
Imports System.Diagnostics
Imports System.ComponentModel
Imports System.Windows.Forms
'=============================================================================
Public Class frmDashboard

    '=================================================
    '      This is for INI file READ and WRITE
    Dim options As New IniOptions()
    Dim file As New IniFile(options)
    Dim poolsetup As New IniFile(options)
    Dim startpath As String = Application.StartupPath
    ''// threads
    Public thread1 As Thread 'thread for miner
    Public thread2 As Thread
    '=================================================
    Public Sub IniHandler()
        '// ========================= CONFIGURATION FOR LOADING INI FILE TO DASHBOARD WALLET =======================
        '// INI FILES
        Dim WorkerText As String
        Dim WalletText As String
        Dim PoolHostText As String
        Dim PoolPortText As String
        Dim Threads As String

        '/// Load file from path.
        file.Load(startpath & "\configs\user.ini")
        poolsetup.Load(startpath & "\configs\poolsetup.ini")
        '/// Read file's specific value.
        WorkerText = file.Sections("CPU").Keys("WorkerName").Value
        WalletText = file.Sections("CPU").Keys("WalletAddress").Value
        PoolHostText = poolsetup.Sections("POOL").Keys("PoolHost").Value
        PoolPortText = poolsetup.Sections("POOL").Keys("PoolPort").Value
        Threads = file.Sections("CPU").Keys("Threads").Value

        '/// FOR WALLET DISPLAY ON DASHBOARD
        txtWorkerName.Text = WorkerText
        txtWorkerWallet.Text = WalletText
        txtThreads.Text = Threads



    End Sub
    Private Sub BtnWallet_Click(sender As Object, e As EventArgs) Handles btnWallet.Click
        '// ========================= CONNECTION TO WALLET FORM =======================

        splitAbout.Visible = False

        With btnWallet

            splitWallet.Visible = True
            .BringToFront()
            .Show()

        End With

        '//=============================== color control
        'dashboard

        Me.btnDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDashboard.IconColor = System.Drawing.SystemColors.ButtonHighlight

        'wallet
        Me.btnWallet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnWallet.IconColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(248, Byte), Integer))

        'about
        Me.btnAbout.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAbout.IconColor = System.Drawing.SystemColors.ButtonHighlight
    End Sub
    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        '//========================= CONNECTION TO ABOUT FORM   =======================
        splitWallet.Visible = False
        '// color control


        With btnAbout

            splitAbout.Visible = True
            .BringToFront()
            .Show()

        End With

        '// =============================== color control
        'dashboard
        Me.btnDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDashboard.IconColor = System.Drawing.SystemColors.ButtonHighlight

        'wallet
        Me.btnWallet.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnWallet.IconColor = System.Drawing.SystemColors.ButtonHighlight

        'about
        Me.btnAbout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnAbout.IconColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(248, Byte), Integer))

    End Sub
    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        '// ========================= MINIMIZE =======================
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        '// ========================= END BUTTON =======================
        Dim response As Integer
        If pnlMining.Visible = False Then
            response = MessageBox.Show("Mining still in progress, are you sure you want to end the application?", "Exit PVCMiner",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = vbYes Then
                Dim pList() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName("minerd")
                For Each proc1 As System.Diagnostics.Process In pList
                    proc1.Kill()
                Next
                Dim pList1() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName("PVCMiner")
                For Each proc2 As System.Diagnostics.Process In pList1
                    proc2.Kill()
                Next
                Dim pList2() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName("PVCMiner-v1.01")
                For Each proc3 As System.Diagnostics.Process In pList2
                    proc3.Kill()
                Next
                Application.ExitThread()
                'PVCMiner-v1.01
            End If
        Else
            response = MessageBox.Show("Are you sure you want to end the application?", "Exit PVCMiner",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = vbYes Then
                Dim pList() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName("minerd")
                For Each proc1 As System.Diagnostics.Process In pList
                    proc1.Kill()
                Next
                Dim pList1() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName("PVCMiner")
                For Each proc2 As System.Diagnostics.Process In pList1
                    proc2.Kill()
                Next
                Dim pList2() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName("PVCMiner-v1.01")
                For Each proc3 As System.Diagnostics.Process In pList2
                    proc3.Kill()
                Next
                Application.ExitThread()

            End If
        End If
    End Sub
    Private Sub PicLogo_Click(sender As Object, e As EventArgs) Handles PicLogo.Click
        '//============================================================================
        '// this will open a web browser and will direct to PVC Website
        Dim webAddress As String = "http://pvccrypto.com/"
        Process.Start(webAddress)
    End Sub
    Public Sub DisableControl()
        ' //this function will disable to textboxes and save config button
        '//Textboxes
        txtWorkerName.Enabled = False
        txtWorkerWallet.Enabled = False
        txtThreads.Enabled = False
        'Worker Name
        txtWorkerName.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(34, Byte), Integer))
        txtWorkerName.ForeColor = System.Drawing.SystemColors.ButtonFace
        txtWorkerName.BorderStyle = BorderStyle.None
        txtWorkerName.Font = New System.Drawing.Font("Poppins SemiBold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'wallet Addresss
        txtWorkerWallet.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(34, Byte), Integer))
        txtWorkerWallet.ForeColor = System.Drawing.SystemColors.ButtonFace
        txtWorkerWallet.BorderStyle = BorderStyle.None
        txtWorkerWallet.Font = New System.Drawing.Font("Poppins SemiBold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'threads Addresss
        txtThreads.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(34, Byte), Integer))
        txtThreads.ForeColor = System.Drawing.SystemColors.ButtonFace
        txtThreads.BorderStyle = BorderStyle.None
        txtThreads.Font = New System.Drawing.Font("Poppins SemiBold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'buttons
        btnCancel.Visible = False
        btnCancel.Enabled = False
        btnSaveConfig.Visible = False
        btnSaveConfig.Enabled = False
        btnSaveConfig.ForeColor = System.Drawing.SystemColors.ButtonFace
        btnEditConfig.Enabled = True
        btnEditConfig.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(248, Byte), Integer))
    End Sub
    Public Sub EnableControl()
        ' this function will disable to textboxes and save config button
        'textboxes
        txtWorkerName.Enabled = True
        txtWorkerWallet.Enabled = True
        txtThreads.Enabled = True
        'Worker Name
        txtWorkerName.BackColor = System.Drawing.SystemColors.ButtonFace
        txtWorkerName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        txtWorkerName.BorderStyle = BorderStyle.FixedSingle
        txtWorkerName.Font = New System.Drawing.Font("Poppins SemiBold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'wallet Addresss
        txtWorkerWallet.BackColor = System.Drawing.SystemColors.ButtonFace
        txtWorkerWallet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        txtWorkerWallet.BorderStyle = BorderStyle.FixedSingle
        txtWorkerWallet.Font = New System.Drawing.Font("Poppins SemiBold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'threads Addresss
        txtThreads.BackColor = System.Drawing.SystemColors.ButtonFace
        txtThreads.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        txtThreads.BorderStyle = BorderStyle.FixedSingle
        txtThreads.Font = New System.Drawing.Font("Poppins SemiBold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'buttons
        btnSaveConfig.Visible = True
        btnSaveConfig.Enabled = True
        btnCancel.Visible = True
        btnCancel.Enabled = True
        btnSaveConfig.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(248, Byte), Integer))

        btnEditConfig.Enabled = False
        btnEditConfig.ForeColor = System.Drawing.SystemColors.ButtonFace

    End Sub
    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ===============================================================================
        ' ============================= DASHBOARD LOADER ================================
        ' ===============================================================================
        '// btnStopMining
        pnlStopMining.Visible = False
        Me.pnlStopMining.Location = New System.Drawing.Point(324, 260)
        ''// Label Controls
        lblproc.Visible = False
        '// Handlers
        IniHandler()
        DisableControl()

        'unconventional way to end erorrs lol
        Control.CheckForIllegalCrossThreadCalls = False

        'progressbar declaration
        ProgressBar1.Visible = False
        ProgressBar1.Style = ProgressBarStyle.Marquee
        ProgressBar1.MarqueeAnimationSpeed = 0.9
        ProgressBar1.Refresh()
        'Size and Location
        Me.ClientSize = New System.Drawing.Size(883, 629)
        Me.splitWallet.Location = New System.Drawing.Point(6, 75)
        Me.splitAbout.Location = New System.Drawing.Point(6, 75)

        '============================split about ===============================================
        '//                          splitabout
        splitAbout.Visible = False 'load splitabout false when the application is open
        '// this will display the text file about.text
        Dim abouttext As String

        Using reader As StreamReader = New StreamReader(startpath & "\configs\about.txt")
            abouttext = reader.ReadToEnd()
        End Using
        txtAbout.Text = abouttext

        '===========================split wallet ================================================
        '                           splitwallet
        splitWallet.Visible = False

    End Sub
    Private Sub BtnEditConfig_Click(sender As Object, e As EventArgs) Handles btnEditConfig.Click
        EnableControl()
        btnStartMining.Visible = False
        btnStartMining.Enabled = False
        pnlMenu.Visible = False
        Me.PicLogo.Location = New System.Drawing.Point(157, 150)
    End Sub
    Private Sub BtnSaveConfig_Click(sender As Object, e As EventArgs) Handles btnSaveConfig.Click
        file.Sections("CPU").Keys("WorkerName").Value = txtWorkerName.Text
        file.Sections("CPU").Keys("WalletAddress").Value = txtWorkerWallet.Text
        file.Sections("CPU").Keys("Threads").Value = txtThreads.Text
        file.Save(startpath & "\configs\user.ini")
        '///controls
        DisableControl()
        MessageBox.Show("Your Configuration has been saved", "Saving Configuration", MessageBoxButtons.OK, MessageBoxIcon.Information)
        btnStartMining.Visible = True
        btnStartMining.Enabled = True
        pnlMenu.Visible = True
        Me.PicLogo.Location = New System.Drawing.Point(168, 95)
    End Sub
    Private Sub BtnStartMining_Click(sender As Object, e As EventArgs) Handles btnStartMining.Click
        '// controls
        DisableControl()
        '// thread
        thread1 = New Thread(AddressOf StartMining)
        thread1.Start()
    End Sub
    '// MINING PROCESS
    Dim proc As New Process
    Private Async Sub StartMining()
        ' ===============================================================================
        ' ============================= START MINING =================================
        ' ===============================================================================
        '// this btn will start the mining process
        If Not worker.IsBusy Then
            worker.WorkerReportsProgress = True
            worker.WorkerSupportsCancellation = True
            worker.RunWorkerAsync()
        End If
        '// process status
        lblproc.Visible = True
        ProgressBar1.Visible = True

        '// visibility and location for btnStopMining
        Me.pnlStopMining.Location = New System.Drawing.Point(324, 260)
        Me.lblproc.Font = New System.Drawing.Font("Poppins SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnStopMining.Visible = True
        btnStopMining.Enabled = True
        pnlStopMining.Visible = True
        '// this will hide the btnStartMining
        btnStartMining.Visible = False
        btnStartMining.Enabled = False
        pnlMining.Visible = False
        '//  btnSetup controls
        btnEditConfig.Visible = True
        btnEditConfig.Enabled = False
        ' ==========================================================
        ' This function will run the miner in background 
        ' and notify when a block Is accepted
        ' ==========================================================
        Dim workIsCompleted As Boolean = False
        While (Not worker.CancellationPending) AndAlso (Not workIsCompleted)
            Control.CheckForIllegalCrossThreadCalls = False
            worker.WorkerSupportsCancellation = True
            '/// ini files value for minerd
            Dim workertext As String = file.Sections("cpu").Keys("workername").Value
            Dim wallettext As String = file.Sections("cpu").Keys("walletaddress").Value
            Dim threadstext As String = file.Sections("CPU").Keys("Threads").Value
            '///[cpu] constant var
            Dim poolhosttext As String = poolsetup.Sections("POOL").Keys("PoolHost").Value
            Dim poolporttext As String = poolsetup.Sections("POOL").Keys("PoolPort").Value
            Dim MinerConfig As String = "-a scrypt -o " + poolhosttext + ":" + poolporttext + " -t " + threadstext + " -u" + " " + wallettext
            Dim sOutput As String

            Dim info As New ProcessStartInfo("minerd.exe", MinerConfig)
            info.UseShellExecute = False
            info.RedirectStandardOutput = True
            info.CreateNoWindow = True
            proc.StartInfo = info
            proc.Start()
            'System.Threading.Thread.Sleep(5)
            Using oStreamReader As StreamReader = proc.StandardOutput
                While True
                    Try
                        sOutput = oStreamReader.ReadLine()
                        'lblProcess.Invoke(Sub()
                        'lblProcess.Text = oStreamReader.ReadLine.ToString()
                        'End Sub)
                        If sOutput.Contains("accept") Then
                            Dim notif As New System.Windows.Forms.NotifyIcon()
                            notif.Visible = True
                            notif.Icon = System.Drawing.SystemIcons.Information
                            notif.BalloonTipTitle = "Information"
                            notif.BalloonTipText = "Yaaay a block share was accepted!" + Environment.NewLine + "Happy farming!"
                            notif.ShowBalloonTip(5000)
                            Thread.Sleep(10000)
                            notif.Dispose()
                        End If
                    Catch ex As Exception
                        Console.WriteLine()
                    End Try
                End While
            End Using
        End While
        Await Task.Run(Sub() proc.WaitForExit())
        ProgressBar1.Visible = False

    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'this btn will end/cancel the edit function
        'controls
        DisableControl()
        btnStartMining.Visible = True
        btnStartMining.Enabled = True
        pnlMenu.Visible = True
        Me.PicLogo.Location = New System.Drawing.Point(168, 95)
    End Sub
    Private Sub BtnStopMining_Click(sender As Object, e As EventArgs) Handles btnStopMining.Click
        '// This Button will end the mining processs
        proc.Kill()
        Me.pnlStopMining.Location = New System.Drawing.Point(324, 260)
        btnStopMining.Visible = False
        btnStopMining.Enabled = False
        pnlStopMining.Visible = False
        '//  btnStartMining controls
        btnStartMining.Visible = True
        btnStartMining.Enabled = True
        pnlMining.Visible = True
        '//  btnSetup controls
        btnEditConfig.Visible = True
        btnEditConfig.Enabled = True
        '// Label Controls
        lblproc.Visible = False
        ProgressBar1.Visible = False
        '// this will kill the minerd process to catch the
        '// any errors of backgroundworker

    End Sub
    Private Sub Worker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles worker.ProgressChanged
        lblproc.Text = e.ProgressPercentage.ToString
    End Sub
    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        splitAbout.Visible = False
        splitWallet.Visible = False
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnDashboard.IconColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(248, Byte), Integer))
        'wallet
        Me.btnWallet.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnWallet.IconColor = System.Drawing.SystemColors.ButtonHighlight
        'about
        Me.btnAbout.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAbout.IconColor = System.Drawing.SystemColors.ButtonHighlight
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblWalletSoon.Click

    End Sub



    ' ===============================================================================
    ' ============================= CLASS ENDS HERE =================================
    ' ===============================================================================
End Class


