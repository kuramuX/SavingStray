Imports MySql.Data.MySqlClient

Public Class frmNewDonation
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmDonationList.Show()
        Me.Close()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are you sure you want to add " & txtFName.Text & " " & txtLName.Text & "'s donation?", "Add Donation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            insert()
        End If
    End Sub

    Private Sub frmNewDonation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub insert()
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO donations (firstname, lastname, middlename, extname, date, amount) VALUES ('" & txtFName.Text & "','" & txtLName.Text & "','" & txtMName.Text & "','" & txtEName.Text & "','" & dtpTDate.Text & "','" & txtAmount.Text & "')"
            Command = New MySqlCommand(Query, MySqlConn)
            Command.ExecuteNonQuery()

            MsgBox("Successfully Added!")
            MySqlConn.Close()
            frmDonationList.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

End Class