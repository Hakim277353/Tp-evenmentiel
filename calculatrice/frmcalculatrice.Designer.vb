<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcalculatrice
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
        Text_A = New TextBox()
        btn_plus = New Button()
        btn_minus = New Button()
        btn_mult = New Button()
        btn_Div = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Text_B = New TextBox()
        btn_equal = New Button()
        btn_reset = New Button()
        Label3 = New Label()
        lbl_res = New Label()
        SuspendLayout()
        ' 
        ' Text_A
        ' 
        Text_A.Location = New Point(304, 74)
        Text_A.Name = "Text_A"
        Text_A.Size = New Size(203, 27)
        Text_A.TabIndex = 0
        ' 
        ' btn_plus
        ' 
        btn_plus.BackColor = Color.CornflowerBlue
        btn_plus.Location = New Point(304, 163)
        btn_plus.Name = "btn_plus"
        btn_plus.Size = New Size(46, 34)
        btn_plus.TabIndex = 1
        btn_plus.Text = "+"
        btn_plus.UseVisualStyleBackColor = False
        ' 
        ' btn_minus
        ' 
        btn_minus.BackColor = Color.CornflowerBlue
        btn_minus.Location = New Point(356, 163)
        btn_minus.Name = "btn_minus"
        btn_minus.Size = New Size(46, 34)
        btn_minus.TabIndex = 2
        btn_minus.Text = "-"
        btn_minus.UseVisualStyleBackColor = False
        ' 
        ' btn_mult
        ' 
        btn_mult.BackColor = Color.CornflowerBlue
        btn_mult.Location = New Point(408, 163)
        btn_mult.Name = "btn_mult"
        btn_mult.Size = New Size(46, 34)
        btn_mult.TabIndex = 3
        btn_mult.Text = "*"
        btn_mult.UseVisualStyleBackColor = False
        ' 
        ' btn_Div
        ' 
        btn_Div.BackColor = Color.CornflowerBlue
        btn_Div.Location = New Point(460, 163)
        btn_Div.Name = "btn_Div"
        btn_Div.Size = New Size(46, 34)
        btn_Div.TabIndex = 4
        btn_Div.Text = "/"
        btn_Div.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.CornflowerBlue
        Label1.Location = New Point(245, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(17, 18)
        Label1.TabIndex = 5
        Label1.Text = "A"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.CornflowerBlue
        Label2.Location = New Point(245, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(18, 18)
        Label2.TabIndex = 6
        Label2.Text = "B"
        ' 
        ' Text_B
        ' 
        Text_B.Location = New Point(303, 116)
        Text_B.Name = "Text_B"
        Text_B.Size = New Size(203, 27)
        Text_B.TabIndex = 7
        ' 
        ' btn_equal
        ' 
        btn_equal.BackColor = Color.CornflowerBlue
        btn_equal.Location = New Point(304, 208)
        btn_equal.Name = "btn_equal"
        btn_equal.Size = New Size(98, 34)
        btn_equal.TabIndex = 9
        btn_equal.Text = "="
        btn_equal.UseVisualStyleBackColor = False
        ' 
        ' btn_reset
        ' 
        btn_reset.BackColor = Color.CornflowerBlue
        btn_reset.Location = New Point(408, 208)
        btn_reset.Name = "btn_reset"
        btn_reset.Size = New Size(98, 34)
        btn_reset.TabIndex = 10
        btn_reset.Text = "Reset"
        btn_reset.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.CornflowerBlue
        Label3.Location = New Point(227, 268)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 18)
        Label3.TabIndex = 11
        Label3.Text = "Resultat"
        ' 
        ' lbl_res
        ' 
        lbl_res.AutoSize = True
        lbl_res.Location = New Point(333, 267)
        lbl_res.Name = "lbl_res"
        lbl_res.Size = New Size(121, 20)
        lbl_res.TabIndex = 12
        lbl_res.Text = "                            "
        ' 
        ' frmcalculatrice
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lbl_res)
        Controls.Add(Label3)
        Controls.Add(btn_reset)
        Controls.Add(btn_equal)
        Controls.Add(Text_B)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_Div)
        Controls.Add(btn_mult)
        Controls.Add(btn_minus)
        Controls.Add(btn_plus)
        Controls.Add(Text_A)
        Name = "frmcalculatrice"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Text_A As TextBox
    Friend WithEvents btn_plus As Button
    Friend WithEvents btn_minus As Button
    Friend WithEvents btn_mult As Button
    Friend WithEvents btn_Div As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Text_B As TextBox
    Friend WithEvents btn_equal As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_res As Label

End Class
