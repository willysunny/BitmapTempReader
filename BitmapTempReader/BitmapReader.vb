Imports System.IO

Public Class BitmapReader
    Const BYTE_255 As Byte = 255
    Dim sampleX As Integer
    Dim sampleY As Integer
    Dim origLocation As String
    Dim origPicture As Bitmap
    Dim displayPicture As Bitmap
    Dim modifiedPicture As Bitmap

    Dim imgWidth As Integer
    Dim imgHeight As Integer
    Dim picXY As Integer

    Private Sub BitmapReader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 開啟圖片
        With ofDlg
            .DefaultExt = ".bmp"
            .Filter = "All Supported Types|*.bmp;*.jpg;*.jpeg;*.png|Bitmap Files|*.bmp|JPEG Files|*.jpg;*.jpeg|PNG Files|*.png"
            .FileName = ""
            .Multiselect = False
            .Title = "請開啟圖片"
            .InitialDirectory = "%USERPROFILE%\Desktop"
            If .ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
                Me.Close()
                Return
            Else
                origLocation = ofDlg.FileName
            End If
        End With

        loadPic()

    End Sub

    Private Sub origPic_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles origPic.MouseDown
        xCoordText.Text = CInt(e.X.ToString / origPic.Width * imgWidth)
        yCoordText.Text = CInt(e.Y.ToString / origPic.Height * imgHeight)

        ' 更新變更
        refreshPic()
    End Sub

    Private Sub colorDiff_ValueChanged(sender As Object, e As EventArgs) Handles colorDiff.ValueChanged
        ' 更新變更
        refreshPic()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        ' 開啟圖片
        With ofDlg
            .DefaultExt = ".bmp"
            .Filter = "All Supported Types|*.bmp;*.jpg;*.jpeg;*.png|Bitmap Files|*.bmp|JPEG Files|*.jpg;*.jpeg|PNG Files|*.png"
            .FileName = ""
            .Multiselect = False
            .Title = "請開啟圖片"
            .InitialDirectory = "%USERPROFILE%\Desktop"
            If .ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
                Return
            Else
                origLocation = ofDlg.FileName
                xCoordText.Text = "0"
                yCoordText.Text = "0"
            End If
        End With

        ' 載入圖片
        loadPic()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub loadPic()
        ' 載入原始圖片
        origPicture = New Bitmap(origLocation)
        imgHeight = origPicture.Height
        imgWidth = origPicture.Width
        refreshPic()
    End Sub

    Private Sub refreshPic(Optional ByVal checkColor As Boolean = True)
        If Not origLocation = "" Then

            ' 定義筆刷
            Dim averageBrush As SolidBrush

            ' 刷新圖片
            displayPicture = New Bitmap(origPicture)
            Dim displayGraphic As Graphics = Graphics.FromImage(displayPicture)

            ' 定義顏色
            If checkColor Then
                ' 取得樣本顏色
                Dim pixelColor As Color = origPicture.GetPixel(xCoordText.Text, yCoordText.Text)
                r.Text = pixelColor.R
                g.Text = pixelColor.G
                b.Text = pixelColor.B
            Else
                r.Text = 128
                g.Text = 128
                b.Text = 128
            End If

            sampleColor.BackColor = Color.FromArgb(r.Text, g.Text, b.Text)
            Application.DoEvents()

            ' 框起選擇區域
            Dim counter As Integer = 0
            Dim sum As Integer = 0
            Dim baseAvg As Integer = 0
            For Y As Integer = -(dotRange.Value - 1) To (dotRange.Value - 1)
                If (yCoordText.Text + Y) < 0 Then
                    Exit For
                ElseIf (yCoordText.Text + Y) >= imgHeight Then
                    Exit For
                Else
                    For X As Integer = -(dotRange.Value - 1) To (dotRange.Value - 1)
                        If (xCoordText.Text + X) < 0 Then
                            Exit For
                        ElseIf (xCoordText.Text + X) >= imgWidth Then
                            Exit For
                        Else
                            counter += 1
                            Dim pixelColor As Color = origPicture.GetPixel(xCoordText.Text + X, yCoordText.Text + Y)
                            sum += (CInt(pixelColor.R) + CInt(pixelColor.G) + CInt(pixelColor.B))
                        End If
                        Application.DoEvents()
                    Next X
                End If
            Next Y
            If counter = 0 Then
                averageBrush = New SolidBrush(Color.FromArgb(sum / 3, sum / 3, sum / 3))
                baseAvg = sum / 3
            Else
                averageBrush = New SolidBrush(Color.FromArgb(sum / (counter * 3), sum / (counter * 3), sum / (counter * 3)))
                baseAvg = sum / (counter * 3)
            End If
            displayGraphic.FillRectangle(averageBrush, CInt(xCoordText.Text - dotRange.Value), CInt(yCoordText.Text - dotRange.Value), dotRange.Value * 2 + 1, dotRange.Value * 2 + 1)
            displayGraphic.DrawRectangle(Pens.Green, CInt(xCoordText.Text - dotRange.Value), CInt(yCoordText.Text - dotRange.Value), dotRange.Value * 2 + 1, dotRange.Value * 2 + 1)

            Application.DoEvents()

            ' 載入原始(可修改)圖片
            modifiedPicture = New Bitmap(origPicture)
            Dim modifiedGraphics As Graphics = Graphics.FromImage(modifiedPicture)

            For x As Integer = 0 To imgWidth - 1
                For y As Integer = 0 To imgHeight - 1
                    Dim avg As Integer = 0
                    Dim pixelColor As Color = modifiedPicture.GetPixel(x, y)
                    avg = (CInt(pixelColor.R) + CInt(pixelColor.G) + CInt(pixelColor.B)) / 3
                    If Math.Abs(avg - baseAvg) <= colorDiff.Value Then
                        ' 彩色模式專用
                        If ColorToolStripMenuItem.Checked Then
                            Dim diff As Byte
                            If avg < baseAvg Then
                                diff = baseAvg - avg
                                modifiedPicture.SetPixel(x, y, Color.FromArgb(128 - (diff / colorDiff.Value * 128), 128 - (diff / colorDiff.Value * 128), 127 + (diff / colorDiff.Value * 128)))
                            ElseIf avg > baseAvg Then
                                diff = avg - baseAvg
                                modifiedPicture.SetPixel(x, y, Color.FromArgb(127 + (diff / colorDiff.Value * 128), 128 - (diff / colorDiff.Value * 128), 128 - (diff / colorDiff.Value * 128)))
                            Else
                                diff = avg - baseAvg
                                modifiedPicture.SetPixel(x, y, Color.FromArgb(128, 128, 128))
                            End If
                        Else
                            modifiedPicture.SetPixel(x, y, Color.FromArgb(avg, avg, avg))
                        End If
                    ElseIf avg < baseAvg Then
                        modifiedPicture.SetPixel(x, y, Color.FromArgb(0, 0, 0))
                    ElseIf avg > baseAvg Then
                        modifiedPicture.SetPixel(x, y, Color.FromArgb(255, 255, 255))
                    Else
                        modifiedPicture.SetPixel(x, y, Color.FromArgb(0, 0, 0))
                    End If
                    Application.DoEvents()
                Next y
            Next x

            modifiedGraphics.DrawRectangle(Pens.Green, CInt(xCoordText.Text - dotRange.Value), CInt(yCoordText.Text - dotRange.Value), dotRange.Value * 2 + 1, dotRange.Value * 2 + 1)

            ' 載入修改過後的圖片
            origPic.Image = displayPicture
            modifiedPic.Image = modifiedPicture
        End If
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        GrayscaleToolStripMenuItem.Checked = Not GrayscaleToolStripMenuItem.Checked
        refreshPic()
    End Sub

    Private Sub GrayscaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrayscaleToolStripMenuItem.Click
        ColorToolStripMenuItem.Checked = Not ColorToolStripMenuItem.Checked
        refreshPic()
    End Sub

    Private Sub origPic_MouseMove(sender As Object, e As MouseEventArgs) Handles origPic.MouseMove
        coordLabel.Text = CInt(e.X.ToString / origPic.Width * imgWidth) & ", " & CInt(e.Y.ToString / origPic.Height * imgHeight)
    End Sub

    Private Sub middleGray_Click(sender As Object, e As EventArgs) Handles middleGray.Click
        refreshPic(False)
    End Sub

    Private Sub ScreenCapture_Click(sender As Object, e As EventArgs) Handles ScreenCapture.Click
        Dim bounds As Rectangle = Me.Bounds
        Dim pt As Point = Me.PointToScreen(bounds.Location)
        Dim bitmap As New Bitmap(bounds.Width, bounds.Height)
        Using g As Graphics = Graphics.FromImage(bitmap)
            g.CopyFromScreen(New Point(pt.X - Me.Location.X, pt.Y - Me.Location.Y), Point.Empty, bounds.Size)
        End Using
        'Using fs As FileStream = New FileStream("Screenshot.bmp"
        bitmap.Save("Screenshot.bmp", Drawing.Imaging.ImageFormat.Bmp)
        With printDlg
            .AllowSomePages = True
            .ShowHelp = True
            .Document = printDoc
            If .ShowDialog = DialogResult.OK Then
                printDoc.Print()
            End If
        End With

    End Sub

    Private Sub ResultOnlyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResultOnlyToolStripMenuItem.Click
        ' 另存新檔
        With sfDlg
            .DefaultExt = "bmp"
            .Filter = "Bitmap Files|*.bmp"
            .Title = "另存檔案至..."
            .InitialDirectory = "%USERPROFILE%\Desktop"
            If .ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
                Return
            Else
                modifiedPicture.Save(sfDlg.FileName)
            End If
        End With
    End Sub

    Private Sub FullSettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullSettingToolStripMenuItem.Click
        ' 另存新檔
        Dim bounds As Rectangle = Me.Bounds
        Dim pt As Point = Me.PointToScreen(bounds.Location)
        Dim bitmap As New Bitmap(bounds.Width, bounds.Height)
        Using g As Graphics = Graphics.FromImage(bitmap)
            g.CopyFromScreen(New Point(pt.X - Me.Location.X, pt.Y - Me.Location.Y), Point.Empty, bounds.Size)
        End Using
        With sfDlg
            .DefaultExt = "png"
            .Filter = "PNG Files|*.png"
            .Title = "另存檔案至..."
            .InitialDirectory = "%USERPROFILE%\Desktop"
            If .ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
                Return
            Else
                bitmap.Save(sfDlg.FileName, Imaging.ImageFormat.Png)
            End If
        End With
    End Sub

    Private Sub printDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printDoc.PrintPage
        Dim pic2prt As New PictureBox
        Dim bounds As Rectangle = Me.Bounds
        Dim ssFile As System.IO.FileStream = New System.IO.FileStream("Screenshot.bmp", IO.FileMode.Open, IO.FileAccess.Read)
        Dim screenshot As New Bitmap(ssFile)
        Dim pHeight As Integer
        Dim pWidth As Integer
        Dim sHeight As Double
        Dim sWidth As Double
        Dim scale As Double


        ' 取得紙張大小
        pHeight = printDoc.DefaultPageSettings.PaperSize.Height
        pWidth = printDoc.DefaultPageSettings.PaperSize.Width

        ' 將尺寸與圖片做比例調整
        If printDoc.DefaultPageSettings.Landscape Then
            sHeight = pHeight / bounds.Height
            sWidth = pWidth / bounds.Width
        Else
            screenshot.RotateFlip(RotateFlipType.Rotate90FlipNone)
            sHeight = pHeight / bounds.Width
            sWidth = pWidth / bounds.Height
        End If

        ' 取得最小比例
        If sHeight < sWidth Then
            scale = sHeight
        Else
            scale = sWidth
        End If

        ' 套回尺寸大小
        Dim printBound As New Rectangle(0, 0, screenshot.Width, screenshot.Height)
        printBound.Width = screenshot.Width * scale
        printBound.Height = screenshot.Height * scale

        e.Graphics.DrawImage(screenshot, printBound)
        ssFile.Close()

    End Sub

    Private Sub dotRange_ValueChanged(sender As Object, e As EventArgs) Handles dotRange.ValueChanged
        refreshPic()
    End Sub
End Class