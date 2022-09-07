Public Class Form1
    Dim first As Decimal
    Dim second As Decimal
    Dim opper As String
    Dim mem As Decimal



    Private Sub Plus_Click(sender As Object, e As EventArgs) Handles Button13.Click

    End Sub

    Private Sub Equals_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Decimal.TryParse(displayTextBox.Text, second)
        If opper = "+" Then
            displayTextBox.Text = first + second
        End If
        If opper = "-" Then
            displayTextBox.Text = first + second
        End If
        If opper = "/" Then
            displayTextBox.Text = first + second
        End If
        If opper = "*" Then
            displayTextBox.Text = first + second
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Decimal.TryParse(displayTextBox.Text, first)
        displayTextBox.Text = Math.Sqrt(first)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Decimal.TryParse(displayTextBox.Text, first)
        displayTextBox.Text = Math.Sin(first)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Decimal.TryParse(displayTextBox.Text, first)
        displayTextBox.Text = Math.Tan(first)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        displayTextBox.Clear()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        displayTextBox.Text = Math.PI
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click
        Decimal.TryParse(displayTextBox.Text, first)
        displayTextBox.Clear()
        opper = sender.text
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Decimal.TryParse(displayTextBox.Text, mem)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        mem = 0
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        displayTextBox.Text = mem
    End Sub
End Class
