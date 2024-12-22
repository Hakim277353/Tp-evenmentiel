<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_afficher3
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
        dgv_livre = New DataGridView()
        isbn = New DataGridViewTextBoxColumn()
        titre = New DataGridViewTextBoxColumn()
        auteur = New DataGridViewTextBoxColumn()
        CType(dgv_livre, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv_livre
        ' 
        dgv_livre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_livre.Columns.AddRange(New DataGridViewColumn() {isbn, titre, auteur})
        dgv_livre.Location = New Point(96, 43)
        dgv_livre.Name = "dgv_livre"
        dgv_livre.Size = New Size(478, 269)
        dgv_livre.TabIndex = 0
        ' 
        ' isbn
        ' 
        isbn.HeaderText = "ISBN"
        isbn.Name = "isbn"
        ' 
        ' titre
        ' 
        titre.HeaderText = "Titre"
        titre.Name = "titre"
        ' 
        ' auteur
        ' 
        auteur.HeaderText = "AUTEUR"
        auteur.Name = "auteur"
        ' 
        ' frm_afficher3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgv_livre)
        Name = "frm_afficher3"
        Text = "frm_afficher3"
        CType(dgv_livre, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgv_livre As DataGridView
    Friend WithEvents isbn As DataGridViewTextBoxColumn
    Friend WithEvents titre As DataGridViewTextBoxColumn
    Friend WithEvents auteur As DataGridViewTextBoxColumn
End Class
