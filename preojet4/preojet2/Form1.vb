Public Class Form1
    Private Sub init()
        txt_Nom_Utilisateur.Clear()
        txt_Motdepass.Clear()
    End Sub
    Private Sub btn_A_Click_1(sender As Object, e As EventArgs) Handles btn_Annuler.Click
        init()
    End Sub

    Private Sub btn_V_Click_1(sender As Object, e As EventArgs) Handles btn_Valider.Click
        Dim login As String
        Dim MP As String
        login = txt_Nom_Utilisateur.Text
        MP = txt_Motdepass.Text
        If ((login = "admin") And (MP = "1234")) Then
            Me.Hide()
            Form2.Show()
        Else
            init()
        End If
    End Sub


End Class