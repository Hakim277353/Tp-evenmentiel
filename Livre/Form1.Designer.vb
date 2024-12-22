<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txt_isbn = New TextBox()
        txt_titre = New TextBox()
        txt_auteur = New TextBox()
        isbn = New Label()
        titre = New Label()
        auteur = New Label()
        btn_ajouter = New Button()
        btn_afficher = New Button()
        SuspendLayout()
        ' 
        ' txt_isbn
        ' 
        txt_isbn.Location = New Point(281, 135)
        txt_isbn.Name = "txt_isbn"
        txt_isbn.Size = New Size(190, 23)
        txt_isbn.TabIndex = 0
        ' 
        ' txt_titre
        ' 
        txt_titre.Location = New Point(281, 235)
        txt_titre.Name = "txt_titre"
        txt_titre.Size = New Size(190, 23)
        txt_titre.TabIndex = 1
        ' 
        ' txt_auteur
        ' 
        txt_auteur.Location = New Point(281, 339)
        txt_auteur.Name = "txt_auteur"
        txt_auteur.Size = New Size(190, 23)
        txt_auteur.TabIndex = 2
        ' 
        ' isbn
        ' 
        isbn.AutoSize = True
        isbn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        isbn.Location = New Point(197, 137)
        isbn.Name = "isbn"
        isbn.Size = New Size(46, 21)
        isbn.TabIndex = 3
        isbn.Text = "ISBN"
        ' 
        ' titre
        ' 
        titre.AutoSize = True
        titre.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        titre.Location = New Point(197, 237)
        titre.Name = "titre"
        titre.Size = New Size(44, 21)
        titre.TabIndex = 4
        titre.Text = "Titre"
        ' 
        ' auteur
        ' 
        auteur.AutoSize = True
        auteur.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        auteur.Location = New Point(197, 341)
        auteur.Name = "auteur"
        auteur.Size = New Size(60, 21)
        auteur.TabIndex = 5
        auteur.Text = "Auteur"
        ' 
        ' btn_ajouter
        ' 
        btn_ajouter.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_ajouter.Location = New Point(250, 410)
        btn_ajouter.Name = "btn_ajouter"
        btn_ajouter.Size = New Size(75, 36)
        btn_ajouter.TabIndex = 6
        btn_ajouter.Text = "Ajouter"
        btn_ajouter.UseVisualStyleBackColor = True
        ' 
        ' btn_afficher
        ' 
        btn_afficher.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_afficher.Location = New Point(358, 410)
        btn_afficher.Name = "btn_afficher"
        btn_afficher.Size = New Size(75, 36)
        btn_afficher.TabIndex = 7
        btn_afficher.Text = "Afficher"
        btn_afficher.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(832, 525)
        Controls.Add(btn_afficher)
        Controls.Add(btn_ajouter)
        Controls.Add(auteur)
        Controls.Add(titre)
        Controls.Add(isbn)
        Controls.Add(txt_auteur)
        Controls.Add(txt_titre)
        Controls.Add(txt_isbn)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_isbn As TextBox
    Friend WithEvents txt_titre As TextBox
    Friend WithEvents txt_auteur As TextBox
    Friend WithEvents isbn As Label
    Friend WithEvents titre As Label
    Friend WithEvents auteur As Label
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents btn_afficher As Button

End Class
