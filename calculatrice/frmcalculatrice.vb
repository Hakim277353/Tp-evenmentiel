Imports System.Diagnostics.Eventing.Reader

Public Class frmcalculatrice
    Dim op As Char
    Private Sub btn_plus_Click(sender As Object, e As EventArgs) Handles btn_plus.Click
        op = "+"
    End Sub

    Private Sub btn_minus_Click(sender As Object, e As EventArgs) Handles btn_minus.Click
        op = "-"
    End Sub

    Private Sub btn_mult_Click(sender As Object, e As EventArgs) Handles btn_mult.Click
        op = "*"
    End Sub

    Private Sub btn_Div_Click(sender As Object, e As EventArgs) Handles btn_Div.Click
        op = "/"
    End Sub

    Private Sub btn_equal_Click(sender As Object, e As EventArgs) Handles btn_equal.Click
        If IsNumeric(Text_A.Text) And IsNumeric(Text_B.Text) Then
            Dim a = Integer.Parse(Text_A.Text)
            Dim b = Integer.Parse(Text_B.Text)
            Dim test = True
            Dim res As Double
            If op = "+" Then
                res = a + b
            ElseIf op = "-" Then
                res = a - b
            ElseIf op = "*" Then
                res = a * b
            ElseIf op = "/" Then
                res = a / b

            Else
                MessageBox.Show("Veuillez verifier si b!=0 et que v avez choisit l opérateur")
                test = False
            End If
            If test Then
                lbl_res.Text = a.ToString + " " + op + " " + b.ToString + " = " + res.ToString
            End If
        Else
            MessageBox.Show("A et B doivent etre des entiers")
        End If
    End Sub
End Class
