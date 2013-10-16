﻿Imports System.Drawing.Imaging

Public Class app_main

    Dim selPrinter As String
    Dim autoclear As Boolean
    Dim debugmode As Boolean

    'used to hold the position of the last printed page
    'of the image when it is bigger than the page size
    Dim lastImagePrintPos As Point

    Private Sub cmdnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnew.Click

        'start capture

        'hide snip forms if in multisnip mode, otherwise close them
        If multisnip = True Then

            For Each hideform As Form In My.Application.OpenForms
                hideform.Hide()
            Next

            If autoclear = True Then

                Me.Size = Me.MinimumSize

            End If

        Else

            'close the sub forms after switching from multi to single
            'can't use for each here because the collection gets modified
            'with the close method
            For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1

                If My.Application.OpenForms.Item(i).Tag Is Nothing OrElse My.Application.OpenForms.Item(i).Tag.ToString <> "*" Then
                    My.Application.OpenForms.Item(i).Close()
                End If

            Next

            Me.Hide()

            Me.Size = Me.MinimumSize

        End If

        app_capture.Show()

    End Sub

    Private Sub cmdcopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcopy.Click

        If Not PictureBox1.Image Is Nothing Then

            'add image to clipboard
            Clipboard.Clear()
            Clipboard.SetImage(PictureBox1.Image)

            autoclear_check()

        End If

    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click

        Dim fileExt As String
        Dim selectedFormat As ImageFormat

        If Not PictureBox1.Image Is Nothing Then

            Try

                With SaveFileDialog1
                    'setup dialog for image save
                    .CheckPathExists = True
                    .Filter = "Bitmap Images (*.bmp)|*.bmp|JPEG Images (*.jpg)|*.jpg|PNG Images (*.png)|*.png"
                    .InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
                    .ShowDialog()

                    If .FileName <> vbNullString Then

                        'save to selected location and filename if exists

                        fileExt = IO.Path.GetExtension(.FileName)

                        Select Case fileExt

                            Case ".bmp"

                                selectedFormat = ImageFormat.Bmp

                            Case ".jpg"

                                selectedFormat = ImageFormat.Jpeg

                            Case ".png"

                                selectedFormat = ImageFormat.Png

                            Case Else

                                selectedFormat = ImageFormat.Bmp

                        End Select

                        'save the image in the requested format
                        PictureBox1.Image.Save(.FileName, selectedFormat)

                        autoclear_check()

                    End If

                End With

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

        End If

    End Sub

    Private Sub app_main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'set the debug option
        For Each commandString As String In My.Application.CommandLineArgs
            If commandString = "/debug" Then
                debugmode = True
            End If
        Next

        Dim findprn As String

        'add installed printers to menustrip
        'set the default printer to be checked in the menu strip
        For i As Integer = 0 To Printing.PrinterSettings.InstalledPrinters.Count - 1

            findprn = Printing.PrinterSettings.InstalledPrinters.Item(i)
            ctxtmenuPrint.Items.Add(findprn)
            If PrintDocument1.PrinterSettings.PrinterName = findprn Then
                Dim defaultPrinter As ToolStripMenuItem = DirectCast(ctxtmenuPrint.Items(ctxtmenuPrint.Items.Count - 1), ToolStripMenuItem)
                defaultPrinter.Checked = True
            End If

        Next

        'Dim itemdefault As ToolStripMenuItem

        'check the default printer and set to app printer
        'For Each itemdefault As ToolStripMenuItem In ctxtmenuPrint.Items
        '    If PrintDocument1.PrinterSettings.PrinterName = itemdefault.Text Then
        '        itemdefault.Checked = True
        '        selPrinter = itemdefault.Text
        '    End If
        'Next

        'set the picturebox to change size with loaded image
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        Me.TopMost = True

        If Me.Name = "app_main" Then
            Me.Tag = "*"
        End If

    End Sub

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click

        If Not PictureBox1.Image Is Nothing Then

            'print to selected printer from menustrip
            Try

                With PrintDocument1

                    'if a printer hasn't been selected then the default printer is used
                    .PrinterSettings.PrinterName = lastPrinterName

                    'change orientation depending on size of picture
                    If PictureBox1.Image.Width >= (.PrinterSettings.DefaultPageSettings.PaperSize.Width - .PrinterSettings.DefaultPageSettings.Margins.Left - .PrinterSettings.DefaultPageSettings.Margins.Right) Then
                        .DefaultPageSettings.Landscape = True
                    Else
                        .DefaultPageSettings.Landscape = False
                    End If

                    If debugmode = True Then

                        MsgBox("Image Width: " & Format(PictureBox1.Image.Width) & vbCrLf & "Page Width: " & Format(.PrinterSettings.DefaultPageSettings.PaperSize.Width - .PrinterSettings.DefaultPageSettings.Margins.Left - .PrinterSettings.DefaultPageSettings.Margins.Right), vbInformation, "Debug")

                    End If

                    'make sure the held values are set to zero before printing
                    lastImagePrintPos.X = 0
                    lastImagePrintPos.Y = 0

                    'make sure that dialog boxes can be seen while printing (e.g. Win2PDF)
                    Me.TopMost = False
                    .Print()
                    Me.TopMost = True

                    autoclear_check()

                End With

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        'margin around the printed image
        Dim imageMargin As Integer = 10

        'take the left and right image margin off the pageWidth
        'convert the value from hundreds of an inch to pixels
        Dim pageWidth As Integer = CInt((e.PageBounds.Width - imageMargin * 2) / 100 * PictureBox1.Image.HorizontalResolution)
        Dim pageHeight As Integer = CInt((e.PageBounds.Height - imageMargin * 2) / 100 * PictureBox1.Image.VerticalResolution)

        'check if the image is bigger than can fit on the page
        If pageWidth < PictureBox1.Image.Width Or pageHeight < PictureBox1.Image.Height Then

            'get a rectangle indicating the portion of the image we want to print
            Dim imageRect As New Rectangle(lastImagePrintPos, New Size(pageWidth, pageHeight))

            'print the required portion of the image
            e.Graphics.DrawImage(PictureBox1.Image, e.PageBounds.X + imageMargin, e.PageBounds.Y + imageMargin, imageRect, GraphicsUnit.Pixel)

            'move to the next page to the right
            lastImagePrintPos.X += pageWidth

            'if the image width is less than printed width
            If PictureBox1.Image.Width < lastImagePrintPos.X Then

                'if the height of the image is more than the currently printed height
                If PictureBox1.Image.Height > lastImagePrintPos.Y + pageHeight Then
                    'reset the x value to zero and increment the y value to print the next row of pages
                    lastImagePrintPos.X = 0
                    lastImagePrintPos.Y += pageHeight
                    e.HasMorePages = True
                Else
                    'the whole width and height of the image have been printed
                    'stop the printing
                    lastImagePrintPos.X = 0
                    lastImagePrintPos.Y = 0
                    e.HasMorePages = False
                End If

            Else

                e.HasMorePages = True

            End If

        Else
            'print the whole image on one page
            e.Graphics.DrawImage(PictureBox1.Image, New Point(imageMargin, imageMargin))
        End If

    End Sub

    Private Sub MultiSnipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MultiSnipToolStripMenuItem.Click

        'check and uncheck after corresponding click
        If MultiSnipToolStripMenuItem.Checked = False Then
            multisnip = True
            MultiSnipToolStripMenuItem.Checked = True
        Else
            multisnip = False
            MultiSnipToolStripMenuItem.Checked = False
        End If

    End Sub

    Private Sub cmdprint_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles cmdprint.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then

            'if a printer has previously been printed with 
            'then select that printer in the list for this form
            If lastPrinterName <> vbNullString Then

                'not checked so uncheck others before checking required menuitem
                For Each findLastPrinter As ToolStripMenuItem In ctxtmenuPrint.Items

                    If findLastPrinter.Text = lastPrinterName Then

                        findLastPrinter.Checked = True

                    Else

                        findLastPrinter.Checked = False

                    End If

                Next

            End If

        End If

    End Sub

    Private Sub ctxtmenuPrint_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ctxtmenuPrint.ItemClicked

        'set the checked state of the menu items according to the selection
        For Each findclicked As ToolStripMenuItem In ctxtmenuPrint.Items

            If findclicked.Text = e.ClickedItem.Text Then

                findclicked.Checked = True
                lastPrinterName = findclicked.Text

            Else

                findclicked.Checked = False

            End If

        Next

    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click

        clearAll()

    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click

        If Clipboard.ContainsImage = True Then

            With Me

                'reset form before picture load
                .Size = .MinimumSize

                'get image from clipboard and load
                .PictureBox1.Image = Clipboard.GetImage
                .PictureBox1.Visible = True

                'change main form dimensions for new capture
                .Height = .Height + .PictureBox1.Height + 5
                .Width = .PictureBox1.Width + 12

                'change panel container dimensions for border around piturebox
                .Panel1.Width = .Width - 6
                .Panel1.Height = .Height - 32

            End With

        End If

    End Sub

    Private Sub AutoClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoClearToolStripMenuItem.Click

        'check and uncheck after corresponding click
        If AutoClearToolStripMenuItem.Checked = False Then
            autoclear = True
            AutoClearToolStripMenuItem.Checked = True
        Else
            autoclear = False
            AutoClearToolStripMenuItem.Checked = False
        End If

    End Sub

    Private Sub autoclear_check()

        If autoclear = True Then

            clearAll()

        End If

    End Sub

    Private Sub clearAll()

        Me.Size = Me.MinimumSize
        PictureBox1.Image = Nothing
        PictureBox1.BackColor = Color.Empty
        PictureBox1.Invalidate()
        PictureBox1.Visible = False

    End Sub

    Private Sub app_main_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'need to check the tag as nothing first
        If Me.Tag IsNot Nothing AndAlso Me.Tag.ToString = "*" Then

            'minimise each open form at the same time
            For Each minimiseall As Form In My.Application.OpenForms

                'if the tag is nothing then set invisible
                'if the tag not equal to an asterisk then set invisible
                If minimiseall.Tag Is Nothing OrElse minimiseall.Tag.ToString <> "*" Then
                    minimiseall.Visible = Not minimiseall.Visible
                End If

            Next

        End If

    End Sub

End Class