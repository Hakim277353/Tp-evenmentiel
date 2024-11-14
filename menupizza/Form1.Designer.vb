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
        TextBox1 = New TextBox()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox7 = New CheckBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(229, 61)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(348, 27)
        TextBox1.TabIndex = 0
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(229, 115)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(104, 24)
        CheckBox1.TabIndex = 1
        CheckBox1.Text = "Croute fine"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(229, 198)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(71, 24)
        CheckBox2.TabIndex = 2
        CheckBox2.Text = "Olives"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(229, 159)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(120, 24)
        CheckBox3.TabIndex = 3
        CheckBox3.Text = "Champignion"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(513, 115)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(122, 24)
        CheckBox4.TabIndex = 4
        CheckBox4.Text = "Croute epaise"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(349, 115)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(139, 24)
        CheckBox5.TabIndex = 5
        CheckBox5.Text = "Croute classique"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(229, 286)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(186, 24)
        CheckBox6.TabIndex = 6
        CheckBox6.Text = "fromage suplementaire"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(229, 242)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(80, 24)
        CheckBox7.TabIndex = 7
        CheckBox7.Text = "Poivron"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(259, 345)
        Button1.Name = "Button1"
        Button1.Size = New Size(245, 61)
        Button1.TabIndex = 8
        Button1.Text = "Afficher la commande"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(CheckBox7)
        Controls.Add(CheckBox6)
        Controls.Add(CheckBox5)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents Button1 As Button

End Class
