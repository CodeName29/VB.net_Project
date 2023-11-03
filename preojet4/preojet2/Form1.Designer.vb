<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Nom_Utilisateur = New System.Windows.Forms.TextBox()
        Me.txt_Motdepass = New System.Windows.Forms.TextBox()
        Me.btn_Annuler = New System.Windows.Forms.Button()
        Me.btn_Valider = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(482, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom Utilisateur :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label2.Location = New System.Drawing.Point(482, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mot de Pasee :"
        '
        'txt_Nom_Utilisateur
        '
        Me.txt_Nom_Utilisateur.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txt_Nom_Utilisateur.Location = New System.Drawing.Point(671, 143)
        Me.txt_Nom_Utilisateur.Name = "txt_Nom_Utilisateur"
        Me.txt_Nom_Utilisateur.Size = New System.Drawing.Size(213, 32)
        Me.txt_Nom_Utilisateur.TabIndex = 2
        '
        'txt_Motdepass
        '
        Me.txt_Motdepass.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txt_Motdepass.Location = New System.Drawing.Point(671, 215)
        Me.txt_Motdepass.Name = "txt_Motdepass"
        Me.txt_Motdepass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Motdepass.Size = New System.Drawing.Size(213, 32)
        Me.txt_Motdepass.TabIndex = 3
        '
        'btn_Annuler
        '
        Me.btn_Annuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btn_Annuler.Location = New System.Drawing.Point(513, 312)
        Me.btn_Annuler.Name = "btn_Annuler"
        Me.btn_Annuler.Size = New System.Drawing.Size(157, 47)
        Me.btn_Annuler.TabIndex = 4
        Me.btn_Annuler.Text = "Annuler"
        Me.btn_Annuler.UseVisualStyleBackColor = True
        '
        'btn_Valider
        '
        Me.btn_Valider.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btn_Valider.Location = New System.Drawing.Point(707, 312)
        Me.btn_Valider.Name = "btn_Valider"
        Me.btn_Valider.Size = New System.Drawing.Size(157, 47)
        Me.btn_Valider.TabIndex = 5
        Me.btn_Valider.Text = "Valider"
        Me.btn_Valider.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(962, 426)
        Me.Controls.Add(Me.btn_Valider)
        Me.Controls.Add(Me.btn_Annuler)
        Me.Controls.Add(Me.txt_Motdepass)
        Me.Controls.Add(Me.txt_Nom_Utilisateur)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Name = "Form1"
        Me.Text = "Authentification"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Nom_Utilisateur As TextBox
    Friend WithEvents txt_Motdepass As TextBox
    Friend WithEvents btn_Annuler As Button
    Friend WithEvents btn_Valider As Button
End Class
