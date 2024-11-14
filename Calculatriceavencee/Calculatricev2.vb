Public Class Form1
    Dim firstNumber As Double
    Dim secondNumber As Double
    Dim operation As String

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles B0.Click, B1.Click, B2.Click, B3.Click, B4.Click, B5.Click, B6.Click, B7.Click, B8.Click, B9.Click
        TextBox1.Text &= DirectCast(sender, Button).Text
    End Sub

    Private Sub ButtonC_Click(sender As Object, e As EventArgs) Handles B_Clear.Click
        TextBox1.Clear()
    End Sub

    Private Sub ButtonOperation_Click(sender As Object, e As EventArgs) Handles B_plus.Click, B_Minus.Click, B_Multi.Click, B_Div.Click
        firstNumber = Double.Parse(TextBox1.Text)
        operation = DirectCast(sender, Button).Text
        TextBox1.Clear()
    End Sub

    Private Sub ButtonEqual_Click(sender As Object, e As EventArgs) Handles B_equal.Click
        secondNumber = Double.Parse(TextBox1.Text)

        Select Case operation
            Case "+"
                TextBox1.Text = (firstNumber + secondNumber).ToString()
            Case "-"
                TextBox1.Text = (firstNumber - secondNumber).ToString()
            Case "*"
                TextBox1.Text = (firstNumber * secondNumber).ToString()
            Case "/"
                If secondNumber <> 0 Then
                    TextBox1.Text = (firstNumber / secondNumber).ToString()
                Else
                    TextBox1.Text = "Erreur"
                End If
        End Select
    End Sub
End Class