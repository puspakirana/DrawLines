Public Class Form1
    Dim x1 As Integer
    Dim y1 As Integer
    Dim x2 As Integer
    Dim y2 As Integer
    Dim dy, dx, r, ur, d, x, y As Integer

    Dim grp As Graphics
    Dim img As New Bitmap(1, 1)

    Dim a, b As Double

    Dim newcolor As Color

#Region "Function"

    Public Function intial()
        a = drawingBox.Width / 2
        b = drawingBox.Height / 2
        grp = drawingBox.CreateGraphics()
        grp.TranslateTransform(a, b)
        grp.ScaleTransform(1, -1)

        dx = Math.Abs(x2 - x1)
        dy = Math.Abs(y2 - y1)

        d = 2 * dy - dx
        r = 2 * dy
        ur = 2 * (dy - dx)

    End Function


    Public Function steep()
        d = 2 * dx - dy
        r = 2 * dx
        ur = 2 * (dx - dy)
    End Function

    Public Function midpoint()
        intial()
        If (x1 < x2) Then
            x = x1
            y = y1

            If (y1 = y2) Then 'case 1
                For x = x1 To x2
                    grp.DrawImage(img, x, y)
                Next
            ElseIf (y1 < y2) Then
                If (dx = dy) Then 'case 5
                    For x = x1 To x2
                        grp.DrawImage(img, x, y)
                        y += 1
                    Next
                ElseIf (dx > dy) Then 'case 9
                    grp.DrawImage(img, x, y)
                    For x = x1 + 1 To x2
                        If (d >= 0) Then
                            y += 1
                            d += ur
                        Else
                            d += r
                        End If

                        grp.DrawImage(img, x, y)
                    Next
                Else 'dx<dy 'case 10
                    grp.DrawImage(img, x, y)
                    steep()
                    For y = y1 + 1 To y2
                        If (d >= 0) Then
                            x += 1
                            d += ur
                        Else
                            d += r
                        End If

                        grp.DrawImage(img, x, y)
                    Next
                End If
            Else 'y1>y2
                If (dx = dy) Then 'case 8
                    For x = x1 To x2
                        grp.DrawImage(img, x, y)
                        y -= 1
                    Next
                ElseIf (dx > dy) Then 'case 16
                    grp.DrawImage(img, x, y)
                    For x = x1 + 1 To x2
                        If (d >= 0) Then
                            y -= 1
                            d += ur
                        Else
                            d += r
                        End If

                        grp.DrawImage(img, x, y)
                    Next
                Else 'dx<dy 'case 15
                    steep()
                    x = x2
                    y = y2
                    grp.DrawImage(img, x, y)
                    For y = y2 + 1 To y1
                        If (d >= 0) Then
                            x -= 1
                            d += ur
                        Else
                            d += r
                        End If

                        grp.DrawImage(img, x, y)
                    Next
                End If
            End If

        ElseIf (x1 > x2) Then
            x = x2
            y = y2
            If (y1 = y2) Then
                For x = x2 To x1 'case 2
                    grp.DrawImage(img, x, y)
                Next
            ElseIf (y1 < y2) Then
                If (dx = dy) Then 'case 6
                    For x = x2 To x1
                        grp.DrawImage(img, x, y)
                        y -= 1
                    Next
                ElseIf (dx > dy) Then 'case 12
                    grp.DrawImage(img, x, y)
                    For x = x2 + 1 To x1
                        If (d >= 0) Then
                            y -= 1
                            d += ur
                        Else
                            d += r
                        End If

                        grp.DrawImage(img, x, y)
                    Next
                Else 'dx < dy 'case 11
                    steep()
                    x = x1
                    y = y1
                    grp.DrawImage(img, x, y)
                    For y = y1 + 1 To y2
                        If (d >= 0) Then
                            x -= 1
                            d += ur
                        Else
                            d += r
                        End If

                        grp.DrawImage(img, x, y)
                    Next
                End If
            Else 'y1>y2
                If (dx = dy) Then 'case 7
                    For x = x2 To x1
                        grp.DrawImage(img, x, y)
                        y += 1
                    Next
                ElseIf (dx > dy) Then 'case13
                    grp.DrawImage(img, x, y)
                    For x = x2 + 1 To x1
                        If (d >= 0) Then
                            y += 1
                            d += ur
                        Else
                            d += r
                        End If

                        grp.DrawImage(img, x, y)
                    Next
                Else 'dx<dy 'case14
                    steep()
                    grp.DrawImage(img, x, y)
                    For y = y2 + 1 To y1
                        If (d >= 0) Then
                            x += 1
                            d += ur
                        Else
                            d += r
                        End If

                        grp.DrawImage(img, x, y)
                    Next
                End If
            End If

        Else 'x1=x2
            x = x1

            If (y1 < y2) Then 'case 3
                For y = y1 To y2
                    grp.DrawImage(img, x, y)
                Next
            ElseIf (y1 > y2) Then 'case 4
                For y = y2 To y1
                    grp.DrawImage(img, x, y)
                Next
            End If

        End If

    End Function

    Public Function dotted()
        intial()
        If (x1 < x2) Then
            x = x1
            y = y1

            If (y1 = y2) Then 'case 1
                For x = x1 To x2
                    grp.DrawImage(img, x, y)
                    x += 1
                Next
            ElseIf (y1 < y2) Then 'case 5
                For x = x1 To x2
                    grp.DrawImage(img, x, y)
                    y += 2
                    x += 1
                Next
            Else 'y1>y2 'case 8
                For x = x1 To x2
                    grp.DrawImage(img, x, y)
                    y -= 2
                    x += 1
                Next
            End If

        ElseIf (x1 > x2) Then
            x = x2
            y = y2
            If (y1 = y2) Then
                For x = x2 To x1 'case 2
                    grp.DrawImage(img, x, y)
                    x += 1
                Next
            ElseIf (y1 < y2) Then 'case 6
                For x = x2 To x1
                    grp.DrawImage(img, x, y)
                    y -= 2
                    x += 1
                Next
            Else 'y1>y2 'case 7
                For x = x2 To x1
                    grp.DrawImage(img, x, y)
                    y += 2
                    x += 1
                Next
            End If

        Else 'x1=x2
            x = x1

            If (y1 < y2) Then 'case 3
                For y = y1 To y2
                    grp.DrawImage(img, x, y)
                    y += 1
                Next
            ElseIf (y1 > y2) Then 'case 4
                For y = y2 To y1
                    grp.DrawImage(img, x, y)
                    y += 1
                Next
            End If

        End If
    End Function

#End Region

#Region "Button"
    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click

        panelOnButton.Height = btnDot.Height
        panelOnButton.Top = btnDot.Top

        If tbX1.Text = "" Or tbY1.Text = "" Then
            MsgBox("Please fill the data correctly!")
        Else
            x1 = tbX1.Text
            y1 = tbY1.Text

            a = drawingBox.Width / 2
            b = drawingBox.Height / 2
            grp = drawingBox.CreateGraphics()
            grp.TranslateTransform(a, b)
            grp.ScaleTransform(1, -1)

            If newcolor = Color.Empty Then
                img.SetPixel(0, 0, Color.Black)
            Else
                img.SetPixel(0, 0, newcolor)
            End If
            grp.DrawImage(img, x1, y1)

            tbX1.Clear()
            tbY1.Clear()
        End If
    End Sub

    Private Sub btnLine_Click(sender As Object, e As EventArgs) Handles btnLine.Click

        panelOnButton.Height = btnLine.Height
        panelOnButton.Top = btnLine.Top

        If tbX1.Text = "" Or tbY1.Text = "" Or tbX2.Text = "" Or tbY2.Text = "" Then
            MsgBox("Please fill the data correctly!")
        Else
            x1 = tbX1.Text
            y1 = tbY1.Text
            x2 = tbX2.Text
            y2 = tbY2.Text

            If newcolor = Color.Empty Then
                img.SetPixel(0, 0, Color.Black)
            Else
                img.SetPixel(0, 0, newcolor)
            End If

            midpoint()

            tbX1.Clear()
            tbY1.Clear()
            tbX2.Clear()
            tbY2.Clear()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        panelOnButton.Height = btnClear.Height
        panelOnButton.Top = btnClear.Top
        drawingBox.Image = Nothing
    End Sub

    Public Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click

        panelOnButton.Height = btnColor.Height
        panelOnButton.Top = btnColor.Top

        Dim colors As DialogResult

        colors = colorDialog.ShowDialog()
        If colors = Windows.Forms.DialogResult.OK Then
            newcolor = colorDialog.Color
        End If

    End Sub

    Private Sub btnDotted_Click(sender As Object, e As EventArgs) Handles btnDotted.Click

        panelOnButton.Height = btnDotted.Height
        panelOnButton.Top = btnDotted.Top

        If tbX1.Text = "" Or tbY1.Text = "" Or tbX2.Text = "" Or tbY2.Text = "" Then
            MsgBox("Please fill the data correctly!")
        Else
            x1 = tbX1.Text
            y1 = tbY1.Text
            x2 = tbX2.Text
            y2 = tbY2.Text

            If newcolor = Color.Empty Then
                img.SetPixel(0, 0, Color.Black)
            Else
                img.SetPixel(0, 0, newcolor)
            End If

            dotted()

            tbX1.Clear()
            tbY1.Clear()
            tbX2.Clear()
            tbY2.Clear()
        End If
    End Sub
#End Region

End Class
