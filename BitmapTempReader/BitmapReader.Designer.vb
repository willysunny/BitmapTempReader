<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BitmapReader
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
        Me.ofDlg = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultOnlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullSettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.影像模式IToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrayscaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.coordLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MainLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.modifiedPic = New System.Windows.Forms.PictureBox()
        Me.origPic = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.hID = New System.Windows.Forms.TextBox()
        Me.ScreenCapture = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.b = New System.Windows.Forms.TextBox()
        Me.g = New System.Windows.Forms.TextBox()
        Me.r = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.yCoordText = New System.Windows.Forms.TextBox()
        Me.xCoordText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sampleColor = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dotRange = New System.Windows.Forms.NumericUpDown()
        Me.colorDiff = New System.Windows.Forms.NumericUpDown()
        Me.middleGray = New System.Windows.Forms.Button()
        Me.pID = New System.Windows.Forms.TextBox()
        Me.partID = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.colorDlg = New System.Windows.Forms.ColorDialog()
        Me.sfDlg = New System.Windows.Forms.SaveFileDialog()
        Me.printDlg = New System.Windows.Forms.PrintDialog()
        Me.printDoc = New System.Drawing.Printing.PrintDocument()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MainLayout.SuspendLayout()
        CType(Me.modifiedPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.origPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuLayout.SuspendLayout()
        CType(Me.sampleColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dotRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorDiff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ofDlg
        '
        Me.ofDlg.DefaultExt = "bmp"
        Me.ofDlg.FileName = "OpenFileDialog1"
        Me.ofDlg.Filter = "Bitmap Files|*.bmp"
        Me.ofDlg.InitialDirectory = "%USERPROFILE%\Pictures"
        Me.ofDlg.Title = "請開啟圖片"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.影像模式IToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(865, 32)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(87, 28)
        Me.FileToolStripMenuItem.Text = "檔案 (&F)"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 28)
        Me.OpenToolStripMenuItem.Text = "開啟 (&O)"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResultOnlyToolStripMenuItem, Me.FullSettingToolStripMenuItem})
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(152, 28)
        Me.SaveAsToolStripMenuItem.Text = "儲存 (&S)"
        '
        'ResultOnlyToolStripMenuItem
        '
        Me.ResultOnlyToolStripMenuItem.Name = "ResultOnlyToolStripMenuItem"
        Me.ResultOnlyToolStripMenuItem.Size = New System.Drawing.Size(204, 28)
        Me.ResultOnlyToolStripMenuItem.Text = "只存結果圖 (&R)"
        '
        'FullSettingToolStripMenuItem
        '
        Me.FullSettingToolStripMenuItem.Name = "FullSettingToolStripMenuItem"
        Me.FullSettingToolStripMenuItem.Size = New System.Drawing.Size(204, 28)
        Me.FullSettingToolStripMenuItem.Text = "完整儲存 (&F)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 28)
        Me.ExitToolStripMenuItem.Text = "離開 (&X)"
        '
        '影像模式IToolStripMenuItem
        '
        Me.影像模式IToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GrayscaleToolStripMenuItem, Me.ColorToolStripMenuItem})
        Me.影像模式IToolStripMenuItem.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!)
        Me.影像模式IToolStripMenuItem.Name = "影像模式IToolStripMenuItem"
        Me.影像模式IToolStripMenuItem.Size = New System.Drawing.Size(120, 28)
        Me.影像模式IToolStripMenuItem.Text = "影像模式 (&I)"
        '
        'GrayscaleToolStripMenuItem
        '
        Me.GrayscaleToolStripMenuItem.CheckOnClick = True
        Me.GrayscaleToolStripMenuItem.Name = "GrayscaleToolStripMenuItem"
        Me.GrayscaleToolStripMenuItem.Size = New System.Drawing.Size(187, 28)
        Me.GrayscaleToolStripMenuItem.Text = "灰階對比 (&G)"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Checked = True
        Me.ColorToolStripMenuItem.CheckOnClick = True
        Me.ColorToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(187, 28)
        Me.ColorToolStripMenuItem.Text = "彩色對比 (&C)"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.coordLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 422)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(865, 29)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'coordLabel
        '
        Me.coordLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.coordLabel.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!)
        Me.coordLabel.Name = "coordLabel"
        Me.coordLabel.Size = New System.Drawing.Size(36, 24)
        Me.coordLabel.Text = "0,0"
        '
        'MainLayout
        '
        Me.MainLayout.ColumnCount = 3
        Me.MainLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MainLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.MainLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MainLayout.Controls.Add(Me.Label4, 2, 1)
        Me.MainLayout.Controls.Add(Me.modifiedPic, 2, 2)
        Me.MainLayout.Controls.Add(Me.origPic, 0, 2)
        Me.MainLayout.Controls.Add(Me.Label1, 0, 1)
        Me.MainLayout.Controls.Add(Me.MenuLayout, 0, 0)
        Me.MainLayout.Controls.Add(Me.PictureBox1, 1, 3)
        Me.MainLayout.Controls.Add(Me.Label6, 1, 2)
        Me.MainLayout.Controls.Add(Me.Label15, 1, 4)
        Me.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainLayout.Location = New System.Drawing.Point(0, 32)
        Me.MainLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.MainLayout.Name = "MainLayout"
        Me.MainLayout.RowCount = 5
        Me.MainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.MainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.MainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.MainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.MainLayout.Size = New System.Drawing.Size(865, 390)
        Me.MainLayout.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(450, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(412, 30)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "校正圖片 (紅=熱, 藍=冷)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'modifiedPic
        '
        Me.modifiedPic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.modifiedPic.Location = New System.Drawing.Point(450, 133)
        Me.modifiedPic.Name = "modifiedPic"
        Me.MainLayout.SetRowSpan(Me.modifiedPic, 3)
        Me.modifiedPic.Size = New System.Drawing.Size(412, 254)
        Me.modifiedPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.modifiedPic.TabIndex = 3
        Me.modifiedPic.TabStop = False
        '
        'origPic
        '
        Me.origPic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.origPic.Location = New System.Drawing.Point(3, 133)
        Me.origPic.Name = "origPic"
        Me.MainLayout.SetRowSpan(Me.origPic, 3)
        Me.origPic.Size = New System.Drawing.Size(411, 254)
        Me.origPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.origPic.TabIndex = 2
        Me.origPic.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(411, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "原始圖片"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'MenuLayout
        '
        Me.MenuLayout.ColumnCount = 10
        Me.MainLayout.SetColumnSpan(Me.MenuLayout, 3)
        Me.MenuLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.MenuLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.MenuLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.MenuLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.MenuLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.MenuLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.MenuLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.MenuLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.MenuLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MenuLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194.0!))
        Me.MenuLayout.Controls.Add(Me.hID, 9, 2)
        Me.MenuLayout.Controls.Add(Me.ScreenCapture, 8, 2)
        Me.MenuLayout.Controls.Add(Me.Label14, 6, 2)
        Me.MenuLayout.Controls.Add(Me.Label13, 6, 1)
        Me.MenuLayout.Controls.Add(Me.Label12, 4, 0)
        Me.MenuLayout.Controls.Add(Me.Label11, 5, 1)
        Me.MenuLayout.Controls.Add(Me.Label10, 4, 1)
        Me.MenuLayout.Controls.Add(Me.Label9, 3, 1)
        Me.MenuLayout.Controls.Add(Me.Label8, 3, 0)
        Me.MenuLayout.Controls.Add(Me.b, 5, 2)
        Me.MenuLayout.Controls.Add(Me.g, 4, 2)
        Me.MenuLayout.Controls.Add(Me.r, 3, 2)
        Me.MenuLayout.Controls.Add(Me.Label5, 0, 0)
        Me.MenuLayout.Controls.Add(Me.yCoordText, 1, 2)
        Me.MenuLayout.Controls.Add(Me.xCoordText, 1, 1)
        Me.MenuLayout.Controls.Add(Me.Label2, 0, 1)
        Me.MenuLayout.Controls.Add(Me.Label3, 0, 2)
        Me.MenuLayout.Controls.Add(Me.sampleColor, 2, 1)
        Me.MenuLayout.Controls.Add(Me.Label7, 2, 0)
        Me.MenuLayout.Controls.Add(Me.dotRange, 7, 2)
        Me.MenuLayout.Controls.Add(Me.colorDiff, 7, 1)
        Me.MenuLayout.Controls.Add(Me.middleGray, 8, 1)
        Me.MenuLayout.Controls.Add(Me.pID, 9, 0)
        Me.MenuLayout.Controls.Add(Me.partID, 9, 1)
        Me.MenuLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuLayout.Location = New System.Drawing.Point(0, 0)
        Me.MenuLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.MenuLayout.Name = "MenuLayout"
        Me.MenuLayout.RowCount = 3
        Me.MenuLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.MenuLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.MenuLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.MenuLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.MenuLayout.Size = New System.Drawing.Size(865, 100)
        Me.MenuLayout.TabIndex = 8
        '
        'hID
        '
        Me.hID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hID.Location = New System.Drawing.Point(674, 68)
        Me.hID.Name = "hID"
        Me.hID.Size = New System.Drawing.Size(188, 22)
        Me.hID.TabIndex = 27
        Me.hID.Text = "37"
        '
        'ScreenCapture
        '
        Me.ScreenCapture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScreenCapture.FlatAppearance.BorderSize = 0
        Me.ScreenCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ScreenCapture.Location = New System.Drawing.Point(560, 65)
        Me.ScreenCapture.Margin = New System.Windows.Forms.Padding(0)
        Me.ScreenCapture.Name = "ScreenCapture"
        Me.ScreenCapture.Size = New System.Drawing.Size(111, 35)
        Me.ScreenCapture.TabIndex = 23
        Me.ScreenCapture.Text = "擷取螢幕"
        Me.ScreenCapture.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.Location = New System.Drawing.Point(343, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 35)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "選取大小"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.Location = New System.Drawing.Point(343, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 35)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "溫差設定"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.MenuLayout.SetColumnSpan(Me.Label12, 2)
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.Location = New System.Drawing.Point(343, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(214, 30)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "參數設定"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.Location = New System.Drawing.Point(303, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 35)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "B"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(263, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 35)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "G"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(223, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 35)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "R"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.MenuLayout.SetColumnSpan(Me.Label8, 3)
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(223, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 30)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "顏色數值"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'b
        '
        Me.b.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.b.Dock = System.Windows.Forms.DockStyle.Fill
        Me.b.Enabled = False
        Me.b.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.b.Location = New System.Drawing.Point(303, 68)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(34, 26)
        Me.b.TabIndex = 12
        Me.b.Text = "0"
        Me.b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'g
        '
        Me.g.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.g.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g.Enabled = False
        Me.g.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.g.Location = New System.Drawing.Point(263, 68)
        Me.g.Name = "g"
        Me.g.Size = New System.Drawing.Size(34, 26)
        Me.g.TabIndex = 11
        Me.g.Text = "0"
        Me.g.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'r
        '
        Me.r.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.r.Dock = System.Windows.Forms.DockStyle.Fill
        Me.r.Enabled = False
        Me.r.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.r.Location = New System.Drawing.Point(223, 68)
        Me.r.Name = "r"
        Me.r.Size = New System.Drawing.Size(34, 26)
        Me.r.TabIndex = 10
        Me.r.Text = "0"
        Me.r.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.MenuLayout.SetColumnSpan(Me.Label5, 2)
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 30)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "校準座標"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'yCoordText
        '
        Me.yCoordText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.yCoordText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.yCoordText.Enabled = False
        Me.yCoordText.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.yCoordText.Location = New System.Drawing.Point(43, 68)
        Me.yCoordText.Name = "yCoordText"
        Me.yCoordText.Size = New System.Drawing.Size(74, 26)
        Me.yCoordText.TabIndex = 0
        Me.yCoordText.Text = "0"
        '
        'xCoordText
        '
        Me.xCoordText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.xCoordText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xCoordText.Enabled = False
        Me.xCoordText.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.xCoordText.Location = New System.Drawing.Point(43, 33)
        Me.xCoordText.Name = "xCoordText"
        Me.xCoordText.Size = New System.Drawing.Size(74, 26)
        Me.xCoordText.TabIndex = 1
        Me.xCoordText.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 35)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "X"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 35)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Y"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'sampleColor
        '
        Me.sampleColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sampleColor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sampleColor.Location = New System.Drawing.Point(120, 30)
        Me.sampleColor.Margin = New System.Windows.Forms.Padding(0)
        Me.sampleColor.Name = "sampleColor"
        Me.MenuLayout.SetRowSpan(Me.sampleColor, 2)
        Me.sampleColor.Size = New System.Drawing.Size(100, 70)
        Me.sampleColor.TabIndex = 8
        Me.sampleColor.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(123, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 30)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "樣本顏色"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'dotRange
        '
        Me.dotRange.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dotRange.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dotRange.Location = New System.Drawing.Point(463, 68)
        Me.dotRange.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.dotRange.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.dotRange.Name = "dotRange"
        Me.dotRange.Size = New System.Drawing.Size(94, 29)
        Me.dotRange.TabIndex = 18
        Me.dotRange.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'colorDiff
        '
        Me.colorDiff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.colorDiff.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.colorDiff.Location = New System.Drawing.Point(463, 33)
        Me.colorDiff.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.colorDiff.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.colorDiff.Name = "colorDiff"
        Me.colorDiff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.colorDiff.Size = New System.Drawing.Size(94, 29)
        Me.colorDiff.TabIndex = 19
        Me.colorDiff.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'middleGray
        '
        Me.middleGray.Dock = System.Windows.Forms.DockStyle.Fill
        Me.middleGray.FlatAppearance.BorderSize = 0
        Me.middleGray.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.middleGray.Location = New System.Drawing.Point(560, 30)
        Me.middleGray.Margin = New System.Windows.Forms.Padding(0)
        Me.middleGray.Name = "middleGray"
        Me.middleGray.Size = New System.Drawing.Size(111, 35)
        Me.middleGray.TabIndex = 22
        Me.middleGray.Text = "中間灰階"
        Me.middleGray.UseVisualStyleBackColor = True
        '
        'pID
        '
        Me.pID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pID.Location = New System.Drawing.Point(674, 3)
        Me.pID.Name = "pID"
        Me.pID.Size = New System.Drawing.Size(188, 22)
        Me.pID.TabIndex = 24
        Me.pID.Text = "1"
        '
        'partID
        '
        Me.partID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.partID.Location = New System.Drawing.Point(674, 33)
        Me.partID.Name = "partID"
        Me.partID.Size = New System.Drawing.Size(188, 22)
        Me.partID.TabIndex = 25
        Me.partID.Text = "50"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(417, 160)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 210)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(420, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "熱"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label15.Location = New System.Drawing.Point(420, 370)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 20)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "冷"
        '
        'sfDlg
        '
        Me.sfDlg.DefaultExt = "bmp"
        Me.sfDlg.Filter = "Bitmap Files|*.bmp"
        Me.sfDlg.InitialDirectory = "%USERPROFILE%\Pictures"
        Me.sfDlg.Title = "另存圖片至..."
        '
        'printDlg
        '
        Me.printDlg.UseEXDialog = True
        '
        'printDoc
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(865, 451)
        Me.Controls.Add(Me.MainLayout)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "BitmapReader"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MainLayout.ResumeLayout(False)
        Me.MainLayout.PerformLayout()
        CType(Me.modifiedPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.origPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuLayout.ResumeLayout(False)
        Me.MenuLayout.PerformLayout()
        CType(Me.sampleColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dotRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorDiff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ofDlg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MainLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents modifiedPic As System.Windows.Forms.PictureBox
    Public WithEvents origPic As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents b As System.Windows.Forms.TextBox
    Friend WithEvents g As System.Windows.Forms.TextBox
    Friend WithEvents r As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents yCoordText As System.Windows.Forms.TextBox
    Friend WithEvents xCoordText As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents sampleColor As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dotRange As System.Windows.Forms.NumericUpDown
    Friend WithEvents colorDiff As System.Windows.Forms.NumericUpDown
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colorDlg As System.Windows.Forms.ColorDialog
    Friend WithEvents sfDlg As System.Windows.Forms.SaveFileDialog
    Friend WithEvents 影像模式IToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrayscaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents coordLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents middleGray As System.Windows.Forms.Button
    Friend WithEvents ScreenCapture As System.Windows.Forms.Button
    Friend WithEvents ResultOnlyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FullSettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents printDlg As System.Windows.Forms.PrintDialog
    Friend WithEvents printDoc As System.Drawing.Printing.PrintDocument
    Friend WithEvents hID As System.Windows.Forms.TextBox
    Friend WithEvents pID As System.Windows.Forms.TextBox
    Friend WithEvents partID As System.Windows.Forms.TextBox
End Class
