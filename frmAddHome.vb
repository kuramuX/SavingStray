
Public Class frmAddHome
    Private Sub btnAnimal_Click(sender As Object, e As EventArgs) Handles btnAnimal.Click
        frmAnimalList.Show()
        Me.Hide()
    End Sub

    Private Sub btnDonation_Click(sender As Object, e As EventArgs) Handles btnDonation.Click
        frmDonationList.Show()
        Me.Hide()
    End Sub

    Private Sub btnRescuer_Click(sender As Object, e As EventArgs) Handles btnRescuer.Click
        frmRescuerList.Show()
        Me.Hide()
    End Sub

    Private Sub btnVet_Click(sender As Object, e As EventArgs) Handles btnVet.Click
        frmVetList.Show()
        Me.Hide()
    End Sub

    Private Sub frmAddHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
    End Sub
End Class
