Module gestion_livre
    Public Structure Livre
        Dim isbn As Integer
        Dim titre As String
        Dim auteur As String
    End Structure

    Public bibliotheque(100) As Livre
    Dim nb As Integer = 0

    Function Ajouterlivre(l As Livre) As Boolean
        If nb < bibliotheque.Length Then
            bibliotheque(nb) = l
            nb += 1
            Return True
        Else
            Return False
        End If
    End Function

    Sub afficher_Livre(l1 As ListBox, l2 As ListBox, l3 As ListBox)
        For i As Integer = 0 To nb - 1
            l1.Items.Add(bibliotheque(i).isbn)
            l2.Items.Add(bibliotheque(i).titre)
            l3.Items.Add(bibliotheque(i).auteur)
        Next
    End Sub

    Sub afficher2_Livres(dgv_livre As DataGridView)
        For i As Integer = 0 To nb - 1
            Dim livre As Livre = bibliotheque(i)
            dgv_livre.Rows.Add(livre.isbn, livre.titre, livre.auteur)
        Next
    End Sub
End Module
