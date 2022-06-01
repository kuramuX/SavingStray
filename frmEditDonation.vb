Imports MySql.Data.MySqlClient

Public Class frmEditDonation
    Private Sub frmEditDonation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblID.Text = frmDonationList.trans_no
        txtFName.Text = frmDonationList.fname
        txtLName.Text = frmDonationList.lname
        txtMName.Text = frmDonationList.mname
        txtEName.Text = frmDonationList.ename
        dtpTDate.Text = frmDonationList.date_tans
        txtAmount.Text = frmDonationList.amount
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmDonationList.Show()
        Me.Close()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you want to update " & txtFName.Text & " " & txtLName.Text & "'s donation?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            updateDonation()
            frmDonationList.Show()
            Me.Close()
        End If
    End Sub

    Sub updateDonation()
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "UPDATE `donations` SET `firstname`='" & txtFName.Text & "',`lastname`='" & txtLName.Text & "',`middlename`='" & txtMName.Text & "',`extname`='" & txtEName.Text & "',`date`='" & dtpTDate.Text & "',`amount`='" & txtAmount.Text & "' WHERE trans_no='" & lblID.Text & "'"
            Command = New MySqlCommand(Query, MySqlConn)
            Command.ExecuteNonQuery()

            MsgBox("Updated Successfully!")
            frmAddHome.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySqlConn.Close()
        End Try
    End Sub
End Class