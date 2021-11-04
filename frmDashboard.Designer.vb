<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnAbout = New FontAwesome.Sharp.IconButton()
        Me.btnWallet = New FontAwesome.Sharp.IconButton()
        Me.btnDashboard = New FontAwesome.Sharp.IconButton()
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.btnMin = New FontAwesome.Sharp.IconButton()
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.pnlMining = New System.Windows.Forms.Panel()
        Me.btnStartMining = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtWorkerName = New System.Windows.Forms.TextBox()
        Me.txtWorkerWallet = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtThreads = New System.Windows.Forms.TextBox()
        Me.worker = New System.ComponentModel.BackgroundWorker()
        Me.notif = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.pnlStopMining = New System.Windows.Forms.Panel()
        Me.btnStopMining = New FontAwesome.Sharp.IconButton()
        Me.lblproc = New System.Windows.Forms.Label()
        Me.splitAbout = New System.Windows.Forms.SplitContainer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtAbout = New System.Windows.Forms.TextBox()
        Me.splitWallet = New System.Windows.Forms.SplitContainer()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblWalletSoon = New System.Windows.Forms.Label()
        Me.btnCancel = New FontAwesome.Sharp.IconButton()
        Me.btnSaveConfig = New FontAwesome.Sharp.IconButton()
        Me.btnEditConfig = New FontAwesome.Sharp.IconButton()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.pnlMenu.SuspendLayout()
        Me.pnlControl.SuspendLayout()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMining.SuspendLayout()
        Me.pnlStopMining.SuspendLayout()
        CType(Me.splitAbout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitAbout.Panel1.SuspendLayout()
        Me.splitAbout.Panel2.SuspendLayout()
        Me.splitAbout.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitWallet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitWallet.Panel1.SuspendLayout()
        Me.splitWallet.Panel2.SuspendLayout()
        Me.splitWallet.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.Controls.Add(Me.btnAbout)
        Me.pnlMenu.Controls.Add(Me.btnWallet)
        Me.pnlMenu.Controls.Add(Me.btnDashboard)
        Me.pnlMenu.Location = New System.Drawing.Point(81, 16)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(560, 60)
        Me.pnlMenu.TabIndex = 0
        '
        'btnAbout
        '
        Me.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbout.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Poppins SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAbout.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle
        Me.btnAbout.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAbout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAbout.IconSize = 45
        Me.btnAbout.Location = New System.Drawing.Point(312, 0)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(156, 60)
        Me.btnAbout.TabIndex = 3
        Me.btnAbout.Text = "About"
        Me.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnWallet
        '
        Me.btnWallet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWallet.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnWallet.FlatAppearance.BorderSize = 0
        Me.btnWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWallet.Font = New System.Drawing.Font("Poppins SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWallet.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnWallet.IconChar = FontAwesome.Sharp.IconChar.Wallet
        Me.btnWallet.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnWallet.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnWallet.IconSize = 45
        Me.btnWallet.Location = New System.Drawing.Point(156, 0)
        Me.btnWallet.Name = "btnWallet"
        Me.btnWallet.Size = New System.Drawing.Size(156, 60)
        Me.btnWallet.TabIndex = 1
        Me.btnWallet.Text = "Wallet"
        Me.btnWallet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnWallet.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Poppins SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.btnDashboard.IconColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDashboard.IconSize = 45
        Me.btnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(156, 60)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'pnlControl
        '
        Me.pnlControl.Controls.Add(Me.btnExit)
        Me.pnlControl.Controls.Add(Me.btnMin)
        Me.pnlControl.Location = New System.Drawing.Point(729, 13)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(124, 59)
        Me.pnlControl.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnExit.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExit.IconSize = 40
        Me.btnExit.Location = New System.Drawing.Point(58, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(53, 53)
        Me.btnExit.TabIndex = 1
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnMin
        '
        Me.btnMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.btnMin.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMin.IconSize = 40
        Me.btnMin.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMin.Location = New System.Drawing.Point(4, 5)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(53, 53)
        Me.btnMin.TabIndex = 0
        Me.btnMin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'PicLogo
        '
        Me.PicLogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicLogo.Image = Global.PVCMiner.My.Resources.Resources.logo_white2
        Me.PicLogo.Location = New System.Drawing.Point(168, 95)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(536, 146)
        Me.PicLogo.TabIndex = 2
        Me.PicLogo.TabStop = False
        '
        'pnlMining
        '
        Me.pnlMining.Controls.Add(Me.btnStartMining)
        Me.pnlMining.Location = New System.Drawing.Point(324, 260)
        Me.pnlMining.Name = "pnlMining"
        Me.pnlMining.Size = New System.Drawing.Size(179, 126)
        Me.pnlMining.TabIndex = 3
        '
        'btnStartMining
        '
        Me.btnStartMining.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStartMining.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStartMining.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnStartMining.FlatAppearance.BorderSize = 0
        Me.btnStartMining.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartMining.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnStartMining.IconChar = FontAwesome.Sharp.IconChar.PlayCircle
        Me.btnStartMining.IconColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnStartMining.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnStartMining.IconSize = 70
        Me.btnStartMining.Location = New System.Drawing.Point(0, 0)
        Me.btnStartMining.Name = "btnStartMining"
        Me.btnStartMining.Size = New System.Drawing.Size(179, 126)
        Me.btnStartMining.TabIndex = 0
        Me.btnStartMining.Text = "Start Mining"
        Me.btnStartMining.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnStartMining.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Poppins SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(47, 436)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Worker Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Poppins SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(47, 469)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Worker Wallet:"
        '
        'txtWorkerName
        '
        Me.txtWorkerName.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtWorkerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWorkerName.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtWorkerName.Enabled = False
        Me.txtWorkerName.Font = New System.Drawing.Font("Poppins SemiBold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWorkerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txtWorkerName.Location = New System.Drawing.Point(168, 436)
        Me.txtWorkerName.Name = "txtWorkerName"
        Me.txtWorkerName.Size = New System.Drawing.Size(404, 27)
        Me.txtWorkerName.TabIndex = 6
        Me.txtWorkerName.Text = "Test"
        '
        'txtWorkerWallet
        '
        Me.txtWorkerWallet.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtWorkerWallet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWorkerWallet.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtWorkerWallet.Enabled = False
        Me.txtWorkerWallet.Font = New System.Drawing.Font("Poppins SemiBold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWorkerWallet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txtWorkerWallet.Location = New System.Drawing.Point(168, 469)
        Me.txtWorkerWallet.Name = "txtWorkerWallet"
        Me.txtWorkerWallet.Size = New System.Drawing.Size(404, 27)
        Me.txtWorkerWallet.TabIndex = 7
        Me.txtWorkerWallet.Text = "Test"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Poppins SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(47, 503)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 26)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Threads:"
        '
        'txtThreads
        '
        Me.txtThreads.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtThreads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtThreads.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtThreads.Enabled = False
        Me.txtThreads.Font = New System.Drawing.Font("Poppins SemiBold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThreads.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txtThreads.Location = New System.Drawing.Point(131, 503)
        Me.txtThreads.Name = "txtThreads"
        Me.txtThreads.Size = New System.Drawing.Size(27, 27)
        Me.txtThreads.TabIndex = 12
        Me.txtThreads.Text = "2"
        '
        'worker
        '
        Me.worker.WorkerReportsProgress = True
        Me.worker.WorkerSupportsCancellation = True
        '
        'notif
        '
        Me.notif.Text = "NotifyIcon1"
        Me.notif.Visible = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'pnlStopMining
        '
        Me.pnlStopMining.Controls.Add(Me.btnStopMining)
        Me.pnlStopMining.Location = New System.Drawing.Point(525, 260)
        Me.pnlStopMining.Name = "pnlStopMining"
        Me.pnlStopMining.Size = New System.Drawing.Size(179, 126)
        Me.pnlStopMining.TabIndex = 14
        '
        'btnStopMining
        '
        Me.btnStopMining.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStopMining.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStopMining.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnStopMining.FlatAppearance.BorderSize = 0
        Me.btnStopMining.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStopMining.ForeColor = System.Drawing.Color.Red
        Me.btnStopMining.IconChar = FontAwesome.Sharp.IconChar.StopCircle
        Me.btnStopMining.IconColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnStopMining.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnStopMining.IconSize = 70
        Me.btnStopMining.Location = New System.Drawing.Point(0, 0)
        Me.btnStopMining.Name = "btnStopMining"
        Me.btnStopMining.Size = New System.Drawing.Size(179, 126)
        Me.btnStopMining.TabIndex = 1
        Me.btnStopMining.Text = "Stop Mining"
        Me.btnStopMining.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnStopMining.UseVisualStyleBackColor = True
        '
        'lblproc
        '
        Me.lblproc.AutoSize = True
        Me.lblproc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblproc.Font = New System.Drawing.Font("Poppins SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproc.ForeColor = System.Drawing.Color.GreenYellow
        Me.lblproc.Location = New System.Drawing.Point(49, 382)
        Me.lblproc.Name = "lblproc"
        Me.lblproc.Size = New System.Drawing.Size(88, 30)
        Me.lblproc.TabIndex = 16
        Me.lblproc.Text = "Mining...."
        '
        'splitAbout
        '
        Me.splitAbout.Location = New System.Drawing.Point(854, 75)
        Me.splitAbout.Name = "splitAbout"
        '
        'splitAbout.Panel1
        '
        Me.splitAbout.Panel1.Controls.Add(Me.PictureBox1)
        '
        'splitAbout.Panel2
        '
        Me.splitAbout.Panel2.Controls.Add(Me.txtAbout)
        Me.splitAbout.Size = New System.Drawing.Size(857, 495)
        Me.splitAbout.SplitterDistance = 285
        Me.splitAbout.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.PVCMiner.My.Resources.Resources.logo_white2
        Me.PictureBox1.Location = New System.Drawing.Point(40, 132)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 146)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'txtAbout
        '
        Me.txtAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtAbout.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAbout.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtAbout.Font = New System.Drawing.Font("Poppins SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txtAbout.Location = New System.Drawing.Point(19, 20)
        Me.txtAbout.Multiline = True
        Me.txtAbout.Name = "txtAbout"
        Me.txtAbout.ReadOnly = True
        Me.txtAbout.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAbout.Size = New System.Drawing.Size(542, 462)
        Me.txtAbout.TabIndex = 10
        Me.txtAbout.Text = "Test"
        '
        'splitWallet
        '
        Me.splitWallet.Location = New System.Drawing.Point(6, 576)
        Me.splitWallet.Name = "splitWallet"
        '
        'splitWallet.Panel1
        '
        Me.splitWallet.Panel1.Controls.Add(Me.PictureBox2)
        '
        'splitWallet.Panel2
        '
        Me.splitWallet.Panel2.Controls.Add(Me.lblWalletSoon)
        Me.splitWallet.Size = New System.Drawing.Size(866, 506)
        Me.splitWallet.SplitterDistance = 288
        Me.splitWallet.TabIndex = 18
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.PVCMiner.My.Resources.Resources.logo_white2
        Me.PictureBox2.Location = New System.Drawing.Point(49, 132)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(165, 146)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'lblWalletSoon
        '
        Me.lblWalletSoon.AutoSize = True
        Me.lblWalletSoon.Font = New System.Drawing.Font("Poppins SemiBold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWalletSoon.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblWalletSoon.Location = New System.Drawing.Point(135, 185)
        Me.lblWalletSoon.Name = "lblWalletSoon"
        Me.lblWalletSoon.Size = New System.Drawing.Size(268, 58)
        Me.lblWalletSoon.TabIndex = 0
        Me.lblWalletSoon.Text = "COMING SOON"
        '
        'btnCancel
        '
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Poppins SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Brown
        Me.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Slash
        Me.btnCancel.IconColor = System.Drawing.Color.Red
        Me.btnCancel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCancel.IconSize = 70
        Me.btnCancel.Location = New System.Drawing.Point(697, 435)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 60)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSaveConfig
        '
        Me.btnSaveConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveConfig.FlatAppearance.BorderSize = 0
        Me.btnSaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveConfig.Font = New System.Drawing.Font("Poppins SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveConfig.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSaveConfig.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.btnSaveConfig.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSaveConfig.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSaveConfig.IconSize = 30
        Me.btnSaveConfig.Location = New System.Drawing.Point(590, 435)
        Me.btnSaveConfig.Name = "btnSaveConfig"
        Me.btnSaveConfig.Size = New System.Drawing.Size(101, 60)
        Me.btnSaveConfig.TabIndex = 9
        Me.btnSaveConfig.Text = "Save Setup"
        Me.btnSaveConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveConfig.UseVisualStyleBackColor = True
        '
        'btnEditConfig
        '
        Me.btnEditConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditConfig.FlatAppearance.BorderSize = 0
        Me.btnEditConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditConfig.Font = New System.Drawing.Font("Poppins SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditConfig.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEditConfig.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btnEditConfig.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEditConfig.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEditConfig.IconSize = 30
        Me.btnEditConfig.Location = New System.Drawing.Point(697, 435)
        Me.btnEditConfig.Name = "btnEditConfig"
        Me.btnEditConfig.Size = New System.Drawing.Size(101, 60)
        Me.btnEditConfig.TabIndex = 8
        Me.btnEditConfig.Text = "Edit Setup"
        Me.btnEditConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditConfig.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Red
        Me.ProgressBar1.Location = New System.Drawing.Point(53, 410)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(719, 19)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 19
        '
        'frmDashboard
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1710, 1055)
        Me.ControlBox = False
        Me.Controls.Add(Me.splitWallet)
        Me.Controls.Add(Me.splitAbout)
        Me.Controls.Add(Me.lblproc)
        Me.Controls.Add(Me.pnlStopMining)
        Me.Controls.Add(Me.txtThreads)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSaveConfig)
        Me.Controls.Add(Me.btnEditConfig)
        Me.Controls.Add(Me.txtWorkerWallet)
        Me.Controls.Add(Me.txtWorkerName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlMining)
        Me.Controls.Add(Me.PicLogo)
        Me.Controls.Add(Me.pnlControl)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Font = New System.Drawing.Font("Poppins SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PVC Miner "
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlControl.ResumeLayout(False)
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMining.ResumeLayout(False)
        Me.pnlStopMining.ResumeLayout(False)
        Me.splitAbout.Panel1.ResumeLayout(False)
        Me.splitAbout.Panel2.ResumeLayout(False)
        Me.splitAbout.Panel2.PerformLayout()
        CType(Me.splitAbout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitAbout.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitWallet.Panel1.ResumeLayout(False)
        Me.splitWallet.Panel2.ResumeLayout(False)
        Me.splitWallet.Panel2.PerformLayout()
        CType(Me.splitWallet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitWallet.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btnAbout As FontAwesome.Sharp.IconButton
    Friend WithEvents btnWallet As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlControl As Panel
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMin As FontAwesome.Sharp.IconButton
    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents pnlMining As Panel
    Friend WithEvents btnStartMining As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtWorkerName As TextBox
    Friend WithEvents txtWorkerWallet As TextBox
    Friend WithEvents btnEditConfig As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSaveConfig As FontAwesome.Sharp.IconButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnCancel As FontAwesome.Sharp.IconButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txtThreads As TextBox
    Friend WithEvents worker As System.ComponentModel.BackgroundWorker
    Friend WithEvents notif As NotifyIcon
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents pnlStopMining As Panel
    Friend WithEvents btnStopMining As FontAwesome.Sharp.IconButton
    Friend WithEvents lblproc As Label
    Friend WithEvents splitAbout As SplitContainer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtAbout As TextBox
    Friend WithEvents splitWallet As SplitContainer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblWalletSoon As Label
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
