<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_afficher2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lst_isbn = New ListBox()
        lst_titre = New ListBox()
        lst_auteur = New ListBox()
        btn_afficher = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(113, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 15)
        Label1.TabIndex = 0
        Label1.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(274, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 15)
        Label2.TabIndex = 1
        Label2.Text = "Titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(434, 70)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 15)
        Label3.TabIndex = 2
        Label3.Text = "Auteur"
        ' 
        ' lst_isbn
        ' 
        lst_isbn.FormattingEnabled = True
        lst_isbn.ItemHeight = 15
        lst_isbn.Location = New Point(49, 102)
        lst_isbn.Name = "lst_isbn"
        lst_isbn.Size = New Size(159, 199)
        lst_isbn.TabIndex = 3
        ' 
        ' lst_titre
        ' 
        lst_titre.FormattingEnabled = True
        lst_titre.ItemHeight = 15
        lst_titre.Location = New Point(214, 102)
        lst_titre.Name = "lst_titre"
        lst_titre.Size = New Size(159, 199)
        lst_titre.TabIndex = 4
        ' 
        ' lst_auteur
        ' 
        lst_auteur.FormattingEnabled = True
        lst_auteur.ItemHeight = 15
        lst_auteur.Location = New Point(379, 102)
        lst_auteur.Name = "lst_auteur"
        lst_auteur.Size = New Size(159, 199)
        lst_auteur.TabIndex = 5
        ' 
        ' btn_afficher
        ' 
        btn_afficher.Location = New Point(255, 361)
        btn_afficher.Name = "btn_afficher"
        btn_afficher.Size = New Size(75, 23)
        btn_afficher.TabIndex = 6
        btn_afficher.Text = "Afficher"
        btn_afficher.UseVisualStyleBackColor = True
        ' 
        ' frm_afficher2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1135, 610)
        Controls.Add(btn_afficher)
        Controls.Add(lst_auteur)
        Controls.Add(lst_titre)
        Controls.Add(lst_isbn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frm_afficher2"
        Text = "frm_afficher2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lst_isbn As ListBox
    Friend WithEvents lst_titre As ListBox
    Friend WithEvents lst_auteur As ListBox
    Friend WithEvents btn_afficher As Button
End Class
