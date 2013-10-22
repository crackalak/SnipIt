Public Class app_capture

    'Create a context menu for controlling the application

    Private mCtxMnu As New ContextMenu

    'Create a panel to serve as the selection area

    Private mSelPanel As New Panel

    'Create a double to store the opacity of the application

    Private mOpacity As Double = 0.3

    'start position of cursor
    Dim startPos As Point

    'Program initialization

    Private Sub app_capture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Configure the form as a full screen, semi-transparent,
        'top most, borderless form and hide before applying styles
        Dim totWidth As Integer
        Dim totHeight As Integer
        Dim leftX As Integer

        Me.Hide()

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        'get the total width of all screens
        'and the biggest height of any screen
        'and the leftmost x position
        For Each s As Screen In Screen.AllScreens

            totWidth += s.Bounds.Width

            If s.Bounds.Height > totHeight Then

                totHeight = s.Bounds.Height

            End If

            If s.Bounds.X < leftX Then

                leftX = s.Bounds.X

            End If

        Next

        'position on the screen that the main form is located on
        'Me.Bounds = Screen.FromControl(app_main).Bounds

        'use the X position of first screen
        Me.SetBounds(leftX, 0, totWidth, totHeight)

        Me.BackColor = Color.DimGray

        Me.Opacity = Me.mOpacity

        Me.ShowInTaskbar = False

        Me.Show()

        Me.TopMost = True

        Me.ContextMenu = Me.mCtxMnu

        'Configure the context menu with close menu item

        Me.ContextMenu.MenuItems.Add("Close", AddressOf CloseEventHandler)

        'Set the selection area color and set the transparency so
        'that accurate colour is displayed before capture
        Me.TransparencyKey = Color.White
        Me.mSelPanel.BackColor = Color.White

        'show crosshair cursor
        Cursor = Cursors.Cross

    End Sub

    Private Sub CloseEventHandler(ByVal sender As Object, ByVal e As EventArgs)

        Cursor = Cursors.Default
        'Close the application
        Me.Close()
        app_main.Show()

    End Sub

    Private Sub app_capture_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        'Show the selection panel if its not already shown

        If Me.Controls.Contains(Me.mSelPanel) Then

            Me.Controls.Remove(Me.mSelPanel)

        End If

        'Reset the seleciton panel size and position

        If e.Button = Windows.Forms.MouseButtons.Left Then

            Me.mSelPanel.Size = New Size(0, 0)

            Me.mSelPanel.Location = e.Location

            startPos = e.Location

            Me.Controls.Add(Me.mSelPanel)

        End If

    End Sub

    Private Sub app_capture_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        'If the selection is being made in a positive direction, resize

        'the panel to fit the selection

        If e.Button = Windows.Forms.MouseButtons.Left Then

            If e.X > startPos.X And e.Y > startPos.Y Then
                'right and down
                Me.mSelPanel.Width = e.X - Me.mSelPanel.Location.X
                Me.mSelPanel.Height = e.Y - Me.mSelPanel.Location.Y

            ElseIf e.X > startPos.X And e.Y < startPos.Y Then
                'right and up
                Me.mSelPanel.Location = New Point(startPos.X, e.Y)
                Me.mSelPanel.Width = e.X - startPos.X
                Me.mSelPanel.Height = startPos.Y - e.Y

            ElseIf e.X < startPos.X And e.Y > startPos.Y Then
                'left and down
                Me.mSelPanel.Location = New Point(e.X, startPos.Y)
                Me.mSelPanel.Width = startPos.X - e.X
                Me.mSelPanel.Height = e.Y - startPos.Y

            ElseIf e.X < startPos.X And e.Y < startPos.Y Then
                'left and up
                Me.mSelPanel.Location = e.Location
                Me.mSelPanel.Width = startPos.X - e.X
                Me.mSelPanel.Height = startPos.Y - e.Y

            End If

        End If

        'Me.mSelPanel.Refresh()

    End Sub

    Private Sub app_capture_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        If e.Button = Windows.Forms.MouseButtons.Left Then

            'Ensure the selection panel is being displayed

            If Me.Controls.Contains(Me.mSelPanel) Then

                If Me.mSelPanel.Size.Width > 0 And Me.mSelPanel.Size.Height > 0 Then
                    'Create a bitmap and graphics object for capturing the selection area

                    Using bmp As New Bitmap(Me.mSelPanel.Size.Width, Me.mSelPanel.Size.Height)
                        Using gfx As Graphics = System.Drawing.Graphics.FromImage(bmp)

                            'point for correct position of panel with multiple screens
                            Dim panelpoint As New Point(Me.mSelPanel.Location.X + Me.Bounds.X, Me.mSelPanel.Location.Y + Me.Bounds.Y)

                            'Make sure this application will not be visible
                            Me.Opacity = 0

                            'Copy the selection area to the screen, then clean up the graphics object
                            gfx.CopyFromScreen(panelpoint, New Point(0, 0), Me.mSelPanel.Size, CopyPixelOperation.SourceCopy)

                            'Reset the transparency of this application
                            'Me.Opacity = Me.mOpacity

                            'if multisnip is true create new instance of main form
                            'and use current snip to fill its picturebox
                            Dim multiform As New app_main

                            If multisnip = True Then

                                With multiform

                                    .PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize

                                    'load picturebox with captured image
                                    .PictureBox1.Image = Image.FromHbitmap(bmp.GetHbitmap)
                                    .PictureBox1.Visible = True

                                    'save a copy of the original image 
                                    'to reset to if required after editing
                                    .originalImage = Image.FromHbitmap(bmp.GetHbitmap)

                                    'remove the previous copy of the image (used for undo)
                                    If .previousImage IsNot Nothing Then
                                        .previousImage.Dispose()
                                    End If

                                    'change main form dimensions for new capture
                                    .Height = .Height + .PictureBox1.Height + 5
                                    .Width = .PictureBox1.Width + 12

                                    'change panel container dimensions for border around piturebox
                                    .Panel1.Width = .Width - 6
                                    .Panel1.Height = .Height - 32

                                    .Name = "multisnip"

                                    'set position to top left of current snip
                                    .StartPosition = Windows.Forms.FormStartPosition.Manual
                                    .Location = panelpoint

                                End With

                            Else

                                With app_main

                                    'load picturebox with captured image
                                    .PictureBox1.Image = Image.FromHbitmap(bmp.GetHbitmap)
                                    .PictureBox1.Visible = True

                                    'save a copy of the original image 
                                    'to reset to if required after editing
                                    .originalImage = Image.FromHbitmap(bmp.GetHbitmap)

                                    'remove the previous copy of the image (used for undo)
                                    If .previousImage IsNot Nothing Then
                                        .previousImage.Dispose()
                                    End If

                                    'change main form dimensions for new capture
                                    .Height = .Height + .PictureBox1.Height + 5
                                    .Width = .PictureBox1.Width + 12

                                    'change panel container dimensions for border around piturebox
                                    .Panel1.Width = .Width - 6
                                    .Panel1.Height = .Height - 32

                                    'set position to top left of current snip
                                    .Location = panelpoint

                                End With

                            End If

                            'Remove the selection panel
                            Me.Controls.Remove(Me.mSelPanel)

                            'reset cursor to default
                            Cursor = Cursors.Default

                            Me.Hide()

                            If multisnip = True Then

                                'show as main snip
                                app_main.Text = "SnipIt - Main"

                                'show each snip and set non main settings
                                For Each showform As Form In My.Application.OpenForms
                                    showform.Show()
                                Next
                                multiform.ShowInTaskbar = False
                                multiform.cmdnew.Enabled = False
                                multiform.Show()

                            Else
                                multiform.Dispose()
                                app_main.Show()
                            End If

                        End Using
                    End Using

                    'Close the application
                    Me.Close()

                End If

            End If

        End If

    End Sub
End Class