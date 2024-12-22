Public Class Form1
    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Dim l As Livre
        l.isbn = txt_isbn.Text
        l.titre = txt_titre.Text
        l.auteur = txt_auteur.Text

        If Ajouterlivre(l) Then
            MessageBox.Show("Ajout du Livre avec succes")
        Else
            MessageBox.Show("Le tableau bibliothèque est saturé")
        End If
    End Sub

    Private Sub btn_afficher_Click(sender As Object, e As EventArgs) Handles btn_afficher.Click
        frm_afficher2.Show()
        frm_afficher3.Show()
    End Sub



End Class
