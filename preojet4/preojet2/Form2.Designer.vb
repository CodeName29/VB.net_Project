<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_Produit = New System.Windows.Forms.ComboBox()
        Me.txt_Montant_HT = New System.Windows.Forms.TextBox()
        Me.btn_Ajouter = New System.Windows.Forms.Button()
        Me.btn_Supprimer = New System.Windows.Forms.Button()
        Me.btn_Vider = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LB_Prix_Untaire = New System.Windows.Forms.ListBox()
        Me.LB_Quantité = New System.Windows.Forms.ListBox()
        Me.LB_Montant_HT = New System.Windows.Forms.ListBox()
        Me.txt_Total_Prix_Untaire = New System.Windows.Forms.TextBox()
        Me.txt_Total_Quantité = New System.Windows.Forms.TextBox()
        Me.txt_Total_Montant_HT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_TVA = New System.Windows.Forms.TextBox()
        Me.txt_Remise = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_Calcul = New System.Windows.Forms.Button()
        Me.btn_Quitter = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_TTC = New System.Windows.Forms.TextBox()
        Me.txt_Prix_Untaire = New System.Windows.Forms.TextBox()
        Me.txt_Quantité = New System.Windows.Forms.TextBox()
        Me.LB_Produit = New System.Windows.Forms.ListBox()
        Me.LB_Modify = New System.Windows.Forms.ListBox()
        Me.LB_Delete = New System.Windows.Forms.ListBox()
        Me.btn_Modifier = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(162, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Produit :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label2.Location = New System.Drawing.Point(162, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prix Untaire :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label3.Location = New System.Drawing.Point(162, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Quantité :"
        '
        'CB_Produit
        '
        Me.CB_Produit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.CB_Produit.FormattingEnabled = True
        Me.CB_Produit.Items.AddRange(New Object() {"Clavier", "Sourie", "Imprimante", "Ordinateur"})
        Me.CB_Produit.Location = New System.Drawing.Point(330, 60)
        Me.CB_Produit.Name = "CB_Produit"
        Me.CB_Produit.Size = New System.Drawing.Size(207, 33)
        Me.CB_Produit.TabIndex = 4
        '
        'txt_Montant_HT
        '
        Me.txt_Montant_HT.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txt_Montant_HT.Location = New System.Drawing.Point(330, 210)
        Me.txt_Montant_HT.Name = "txt_Montant_HT"
        Me.txt_Montant_HT.Size = New System.Drawing.Size(207, 32)
        Me.txt_Montant_HT.TabIndex = 7
        '
        'btn_Ajouter
        '
        Me.btn_Ajouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_Ajouter.Location = New System.Drawing.Point(631, 58)
        Me.btn_Ajouter.Name = "btn_Ajouter"
        Me.btn_Ajouter.Size = New System.Drawing.Size(109, 35)
        Me.btn_Ajouter.TabIndex = 8
        Me.btn_Ajouter.Text = "Ajouter"
        Me.btn_Ajouter.UseVisualStyleBackColor = True
        '
        'btn_Supprimer
        '
        Me.btn_Supprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_Supprimer.Location = New System.Drawing.Point(631, 156)
        Me.btn_Supprimer.Name = "btn_Supprimer"
        Me.btn_Supprimer.Size = New System.Drawing.Size(109, 32)
        Me.btn_Supprimer.TabIndex = 9
        Me.btn_Supprimer.Text = "Suprimer tout"
        Me.btn_Supprimer.UseVisualStyleBackColor = True
        '
        'btn_Vider
        '
        Me.btn_Vider.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_Vider.Location = New System.Drawing.Point(631, 105)
        Me.btn_Vider.Name = "btn_Vider"
        Me.btn_Vider.Size = New System.Drawing.Size(109, 35)
        Me.btn_Vider.TabIndex = 10
        Me.btn_Vider.Text = "Vider"
        Me.btn_Vider.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label4.Location = New System.Drawing.Point(162, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 26)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Montant HT :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label5.Location = New System.Drawing.Point(221, 293)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 26)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Produit "
        '
        'LB_Prix_Untaire
        '
        Me.LB_Prix_Untaire.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LB_Prix_Untaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.LB_Prix_Untaire.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LB_Prix_Untaire.FormattingEnabled = True
        Me.LB_Prix_Untaire.ItemHeight = 25
        Me.LB_Prix_Untaire.Location = New System.Drawing.Point(368, 337)
        Me.LB_Prix_Untaire.Name = "LB_Prix_Untaire"
        Me.LB_Prix_Untaire.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LB_Prix_Untaire.Size = New System.Drawing.Size(144, 200)
        Me.LB_Prix_Untaire.TabIndex = 13
        '
        'LB_Quantité
        '
        Me.LB_Quantité.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LB_Quantité.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.LB_Quantité.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LB_Quantité.FormattingEnabled = True
        Me.LB_Quantité.ItemHeight = 25
        Me.LB_Quantité.Location = New System.Drawing.Point(552, 337)
        Me.LB_Quantité.Name = "LB_Quantité"
        Me.LB_Quantité.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LB_Quantité.Size = New System.Drawing.Size(144, 200)
        Me.LB_Quantité.TabIndex = 14
        '
        'LB_Montant_HT
        '
        Me.LB_Montant_HT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LB_Montant_HT.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.LB_Montant_HT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LB_Montant_HT.FormattingEnabled = True
        Me.LB_Montant_HT.ItemHeight = 25
        Me.LB_Montant_HT.Location = New System.Drawing.Point(734, 337)
        Me.LB_Montant_HT.Name = "LB_Montant_HT"
        Me.LB_Montant_HT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LB_Montant_HT.Size = New System.Drawing.Size(144, 200)
        Me.LB_Montant_HT.TabIndex = 15
        '
        'txt_Total_Prix_Untaire
        '
        Me.txt_Total_Prix_Untaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txt_Total_Prix_Untaire.Location = New System.Drawing.Point(368, 560)
        Me.txt_Total_Prix_Untaire.Name = "txt_Total_Prix_Untaire"
        Me.txt_Total_Prix_Untaire.Size = New System.Drawing.Size(144, 32)
        Me.txt_Total_Prix_Untaire.TabIndex = 16
        '
        'txt_Total_Quantité
        '
        Me.txt_Total_Quantité.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txt_Total_Quantité.Location = New System.Drawing.Point(552, 560)
        Me.txt_Total_Quantité.Name = "txt_Total_Quantité"
        Me.txt_Total_Quantité.Size = New System.Drawing.Size(144, 32)
        Me.txt_Total_Quantité.TabIndex = 17
        '
        'txt_Total_Montant_HT
        '
        Me.txt_Total_Montant_HT.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txt_Total_Montant_HT.Location = New System.Drawing.Point(734, 560)
        Me.txt_Total_Montant_HT.Name = "txt_Total_Montant_HT"
        Me.txt_Total_Montant_HT.Size = New System.Drawing.Size(144, 32)
        Me.txt_Total_Montant_HT.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label6.Location = New System.Drawing.Point(268, 563)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 26)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Total :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label7.Location = New System.Drawing.Point(372, 293)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 26)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Prix Unitaire"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label8.Location = New System.Drawing.Point(570, 293)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 26)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Quantité"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label9.Location = New System.Drawing.Point(738, 293)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 26)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Montant HT "
        '
        'txt_TVA
        '
        Me.txt_TVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txt_TVA.Location = New System.Drawing.Point(552, 617)
        Me.txt_TVA.Name = "txt_TVA"
        Me.txt_TVA.Size = New System.Drawing.Size(326, 32)
        Me.txt_TVA.TabIndex = 23
        '
        'txt_Remise
        '
        Me.txt_Remise.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txt_Remise.Location = New System.Drawing.Point(552, 666)
        Me.txt_Remise.Name = "txt_Remise"
        Me.txt_Remise.Size = New System.Drawing.Size(326, 32)
        Me.txt_Remise.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label10.Location = New System.Drawing.Point(388, 620)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 26)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "TVA(20%) :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label11.Location = New System.Drawing.Point(413, 669)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 26)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Remise :"
        '
        'btn_Calcul
        '
        Me.btn_Calcul.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_Calcul.Location = New System.Drawing.Point(895, 337)
        Me.btn_Calcul.Name = "btn_Calcul"
        Me.btn_Calcul.Size = New System.Drawing.Size(107, 37)
        Me.btn_Calcul.TabIndex = 27
        Me.btn_Calcul.Text = "Calculer"
        Me.btn_Calcul.UseVisualStyleBackColor = True
        '
        'btn_Quitter
        '
        Me.btn_Quitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_Quitter.Location = New System.Drawing.Point(895, 398)
        Me.btn_Quitter.Name = "btn_Quitter"
        Me.btn_Quitter.Size = New System.Drawing.Size(107, 37)
        Me.btn_Quitter.TabIndex = 28
        Me.btn_Quitter.Text = "Quitter"
        Me.btn_Quitter.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label12.Location = New System.Drawing.Point(448, 715)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 26)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "TTC :"
        '
        'txt_TTC
        '
        Me.txt_TTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txt_TTC.Location = New System.Drawing.Point(552, 715)
        Me.txt_TTC.Name = "txt_TTC"
        Me.txt_TTC.Size = New System.Drawing.Size(326, 32)
        Me.txt_TTC.TabIndex = 31
        '
        'txt_Prix_Untaire
        '
        Me.txt_Prix_Untaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txt_Prix_Untaire.Location = New System.Drawing.Point(330, 106)
        Me.txt_Prix_Untaire.Name = "txt_Prix_Untaire"
        Me.txt_Prix_Untaire.Size = New System.Drawing.Size(207, 32)
        Me.txt_Prix_Untaire.TabIndex = 32
        '
        'txt_Quantité
        '
        Me.txt_Quantité.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txt_Quantité.Location = New System.Drawing.Point(330, 156)
        Me.txt_Quantité.Name = "txt_Quantité"
        Me.txt_Quantité.Size = New System.Drawing.Size(207, 32)
        Me.txt_Quantité.TabIndex = 33
        '
        'LB_Produit
        '
        Me.LB_Produit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LB_Produit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.LB_Produit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LB_Produit.FormattingEnabled = True
        Me.LB_Produit.ItemHeight = 25
        Me.LB_Produit.Location = New System.Drawing.Point(195, 337)
        Me.LB_Produit.Name = "LB_Produit"
        Me.LB_Produit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LB_Produit.Size = New System.Drawing.Size(144, 200)
        Me.LB_Produit.TabIndex = 11
        '
        'LB_Modify
        '
        Me.LB_Modify.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LB_Modify.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LB_Modify.Cursor = System.Windows.Forms.Cursors.Default
        Me.LB_Modify.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.LB_Modify.ForeColor = System.Drawing.Color.DarkGreen
        Me.LB_Modify.FormattingEnabled = True
        Me.LB_Modify.ItemHeight = 25
        Me.LB_Modify.Location = New System.Drawing.Point(106, 337)
        Me.LB_Modify.Name = "LB_Modify"
        Me.LB_Modify.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LB_Modify.Size = New System.Drawing.Size(83, 200)
        Me.LB_Modify.TabIndex = 34
        '
        'LB_Delete
        '
        Me.LB_Delete.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LB_Delete.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LB_Delete.Cursor = System.Windows.Forms.Cursors.Default
        Me.LB_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.LB_Delete.ForeColor = System.Drawing.Color.Red
        Me.LB_Delete.FormattingEnabled = True
        Me.LB_Delete.ItemHeight = 25
        Me.LB_Delete.Location = New System.Drawing.Point(12, 337)
        Me.LB_Delete.Name = "LB_Delete"
        Me.LB_Delete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LB_Delete.Size = New System.Drawing.Size(88, 200)
        Me.LB_Delete.TabIndex = 35
        '
        'btn_Modifier
        '
        Me.btn_Modifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_Modifier.Location = New System.Drawing.Point(631, 210)
        Me.btn_Modifier.Name = "btn_Modifier"
        Me.btn_Modifier.Size = New System.Drawing.Size(109, 35)
        Me.btn_Modifier.TabIndex = 36
        Me.btn_Modifier.Text = "Modifier"
        Me.btn_Modifier.UseVisualStyleBackColor = True
        Me.btn_Modifier.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1023, 762)
        Me.Controls.Add(Me.btn_Modifier)
        Me.Controls.Add(Me.LB_Delete)
        Me.Controls.Add(Me.LB_Modify)
        Me.Controls.Add(Me.txt_Quantité)
        Me.Controls.Add(Me.txt_Prix_Untaire)
        Me.Controls.Add(Me.txt_TTC)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btn_Quitter)
        Me.Controls.Add(Me.btn_Calcul)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_Remise)
        Me.Controls.Add(Me.txt_TVA)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_Total_Montant_HT)
        Me.Controls.Add(Me.txt_Total_Quantité)
        Me.Controls.Add(Me.txt_Total_Prix_Untaire)
        Me.Controls.Add(Me.LB_Montant_HT)
        Me.Controls.Add(Me.LB_Quantité)
        Me.Controls.Add(Me.LB_Prix_Untaire)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LB_Produit)
        Me.Controls.Add(Me.btn_Vider)
        Me.Controls.Add(Me.btn_Supprimer)
        Me.Controls.Add(Me.btn_Ajouter)
        Me.Controls.Add(Me.txt_Montant_HT)
        Me.Controls.Add(Me.CB_Produit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form2"
        Me.Text = "Frm_Gestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CB_Produit As ComboBox
    Friend WithEvents txt_Montant_HT As TextBox
    Friend WithEvents btn_Ajouter As Button
    Friend WithEvents btn_Supprimer As Button
    Friend WithEvents btn_Vider As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Friend WithEvents LB_Prix_Untaire As ListBox
    Friend WithEvents LB_Quantité As ListBox
    Friend WithEvents LB_Montant_HT As ListBox
    Friend WithEvents txt_Total_Prix_Untaire As TextBox
    Friend WithEvents txt_Total_Quantité As TextBox
    Friend WithEvents txt_Total_Montant_HT As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_TVA As TextBox
    Friend WithEvents txt_Remise As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_Calcul As Button
    Friend WithEvents btn_Quitter As Button
    Private Sub btn_Ajouter_Click(sender As Object, e As EventArgs) Handles btn_Ajouter.Click
        If (CB_Produit.SelectedIndex = -1) Then
            MsgBox("Select un Produit")
        Else
            If (txt_Quantité.TextLength = 0) Then
                MsgBox("Quantité Vide")
            Else
                Dim test As Boolean = False
                For index As Integer = 0 To LB_Produit.Items.Count - 1
                    Dim item As String = LB_Produit.Items(index).ToString()
                    If item = CB_Produit.SelectedItem Then
                        LB_Quantité.Items(index) += CSng(txt_Quantité.Text)
                        LB_Montant_HT.Items(index) = (LB_Prix_Untaire.Items(index) * LB_Quantité.Items(index))
                        test = True
                    End If
                Next
                If (test = False) Then
                    LB_Delete.Items.Add("Suprimer")
                    LB_Modify.Items.Add("Modifier")
                    LB_Produit.Items.Add(CB_Produit.SelectedItem)
                    LB_Prix_Untaire.Items.Add(txt_Prix_Untaire.Text)
                    LB_Quantité.Items.Add(txt_Quantité.Text)
                    LB_Montant_HT.Items.Add(txt_Prix_Untaire.Text * txt_Quantité.Text)
                End If


            End If
        End If
        init()
    End Sub

    Private Sub CB_P_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Produit.SelectedIndexChanged

        If (CB_Produit.SelectedIndex = 0) Then
            txt_Prix_Untaire.Text = 30
        ElseIf (CB_Produit.SelectedIndex = 1) Then
            txt_Prix_Untaire.Text = 15
        ElseIf (CB_Produit.SelectedIndex = 2) Then
            txt_Prix_Untaire.Text = 500
        Else
            txt_Prix_Untaire.Text = 1000
        End If
        If String.IsNullOrEmpty(txt_Quantité.Text) = False Then
            txt_Montant_HT.Text = txt_Prix_Untaire.Text * txt_Quantité.Text
        End If

    End Sub
    Private Sub init()
        CB_Produit.SelectedIndex = -1
        txt_Quantité.Clear()
        txt_Prix_Untaire.Clear()
        txt_Montant_HT.Clear()
    End Sub
    Private Sub btn_Supprimer_Click(sender As Object, e As EventArgs) Handles btn_Supprimer.Click
        init()
        LB_Delete.Items.Clear()
        LB_Modify.Items.Clear()
        LB_Produit.Items.Clear()
        LB_Montant_HT.Items.Clear()
        LB_Prix_Untaire.Items.Clear()
        LB_Quantité.Items.Clear()
        txt_TTC.Clear()
        txt_Total_Montant_HT.Clear()
        txt_TVA.Clear()
        txt_Remise.Clear()
        txt_Total_Quantité.Clear()
        txt_Total_Prix_Untaire.Clear()

    End Sub

    Private Sub btn_Vider_Click(sender As Object, e As EventArgs) Handles btn_Vider.Click
        init()
    End Sub

    Private Sub btn_Quitter_Click(sender As Object, e As EventArgs) Handles btn_Quitter.Click
        End
    End Sub
    Public Sub calcul()
        Dim S_Prix_Untaire As Double = 0
        Dim S_MHT As Double = 0
        Dim S_Quantité As Double = 0

        If (LB_Prix_Untaire.Items.Count = 0) Then
            MsgBox("No Panier Ajouter")
        Else
            For Each item As Object In LB_Prix_Untaire.Items
                S_Prix_Untaire += CSng(item)
            Next
            txt_Total_Prix_Untaire.Text = S_Prix_Untaire
            For Each item As Object In LB_Quantité.Items
                S_Quantité += CSng(item)
            Next
            txt_Total_Quantité.Text = S_Quantité
            For Each item As Object In LB_Montant_HT.Items
                S_MHT += CSng(item)
            Next
            txt_Total_Montant_HT.Text = S_MHT
            txt_TVA.Text = S_MHT * 0.2
            If (S_MHT >= 1000) Then
                txt_Remise.Text = S_MHT * 0.01
                txt_TTC.Text = (S_MHT * 1.2) - (S_MHT * 0.01)
            Else
                txt_Remise.Text = 0
                txt_TTC.Text = S_MHT * 1.2
            End If
        End If
    End Sub
    Private Sub Bbtn_Calcul_Click(sender As Object, e As EventArgs) Handles btn_Calcul.Click
        calcul()
    End Sub

    Friend WithEvents Label12 As Label
    Friend WithEvents txt_TTC As TextBox
    Friend WithEvents txt_Prix_Untaire As TextBox
    Friend WithEvents txt_Quantité As TextBox

    Private Sub txt_Quantité_TextChanged(sender As Object, e As EventArgs) Handles txt_Quantité.TextChanged

        For Each c As Char In txt_Quantité.Text
            If (CB_Produit.SelectedIndex = -1) Then
                MsgBox("Select un Produit")
                txt_Quantité.Clear()
            Else
                If Not Char.IsDigit(c) Then
                    MsgBox("Quantité Invalide")
                    txt_Quantité.Clear()
                Else
                    txt_Montant_HT.Text = CSng(txt_Prix_Untaire.Text) * CSng(txt_Quantité.Text)
                End If
            End If
        Next
    End Sub

    Friend WithEvents LB_Produit As ListBox


    Friend WithEvents LB_Modify As ListBox
    Friend WithEvents LB_Delete As ListBox

    Private Sub LB_Delete_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Delete.SelectedIndexChanged
        If (LB_Delete.SelectedIndex <> -1) Then
            Dim result As DialogResult = MessageBox.Show("voulez-vous supprimer ce produit?", "Choose Action", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                LB_Prix_Untaire.Items.RemoveAt(LB_Delete.SelectedIndex)
                LB_Quantité.Items.RemoveAt(LB_Delete.SelectedIndex)
                LB_Montant_HT.Items.RemoveAt(LB_Delete.SelectedIndex)
                LB_Produit.Items.RemoveAt(LB_Delete.SelectedIndex)
                LB_Modify.Items.RemoveAt(LB_Delete.SelectedIndex)
                LB_Delete.Items.RemoveAt(LB_Delete.SelectedIndex)
            Else
                Console.WriteLine("Annuler")
            End If
        End If
    End Sub
    Dim indice_M As Integer
    Private Sub LB_Modify_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Modify.SelectedIndexChanged
        If (LB_Modify.SelectedIndex <> -1) Then
            indice_M = LB_Modify.SelectedIndex
            Dim result2 As DialogResult = MessageBox.Show("voulez-vous modifier la Quantité de ce produit?", "Choose Action", MessageBoxButtons.YesNo)
            Dim indice1 As Integer = -1
            If result2 = DialogResult.Yes Then
                If LB_Produit.Items(indice_M) = "Clavier" Then
                    CB_Produit.SelectedIndex = 0
                    indice1 = 0
                ElseIf LB_Produit.Items(indice_M) = "Sourie" Then
                    CB_Produit.SelectedIndex = 1
                    indice1 = 1
                ElseIf LB_Produit.Items(indice_M) = "Imprimante" Then
                    CB_Produit.SelectedIndex = 2
                    indice1 = 2
                Else
                    CB_Produit.SelectedIndex = 3
                    indice1 = 3
                End If
                CB_Produit.Enabled = False
                btn_Modifier.Visible = True
                btn_Ajouter.Visible = False
                LB_Modify.SelectedIndex = -1
            End If
        End If
    End Sub

    Friend WithEvents btn_Modifier As Button

    Private Sub btn_Modifier_Click(sender As Object, e As EventArgs) Handles btn_Modifier.Click
        If (txt_Quantité.TextLength = 0) Then
            MsgBox("Quantité Vide")
        Else
            LB_Quantité.Items(indice_M) = txt_Quantité.Text
            LB_Montant_HT.Items(indice_M) = txt_Montant_HT.Text
        End If

        CB_Produit.Enabled = True
        btn_Modifier.Visible = False
        btn_Ajouter.Visible = True
        init()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_Prix_Untaire.Enabled = False
        txt_Montant_HT.Enabled = False
        txt_Total_Montant_HT.Enabled = False
        txt_Total_Prix_Untaire.Enabled = False
        txt_Total_Quantité.Enabled = False
        txt_TTC.Enabled = False
        txt_TVA.Enabled = False
        txt_Remise.Enabled = False
    End Sub
End Class
