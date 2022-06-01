Imports MySql.Data.MySqlClient

Public Class frmDonationList
    Public trans_no As Integer
    Public fname As String
    Public lname As String
    Public mname As String
    Public ename As String
    Public date_tans As String
    Public amount As Integer
    Public back_button As String

    Private Sub frmDonationList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        retrieve()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmAddHome.Show()
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmNewDonation.Show()
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If fname = "" Then
            MessageBox.Show("Please select a donation to update.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            frmEditDonation.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If fname = "" Then
            MessageBox.Show("Please select a donation to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim dialog As DialogResult
            dialog = MessageBox.Show("Do you want to delete " & fname & " " & lname & "'s donation?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If dialog = DialogResult.Yes Then
                del()
                retrieve()
            End If
        End If

    End Sub

    Sub retrieve()

        Try
            DonationTable.Clear()
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM donations"
            Command = New MySqlCommand(Query, MySqlConn)
            Command.ExecuteNonQuery()

            Adapter.SelectCommand = Command
            Adapter.Fill(DonationTable)
            dtgDonations.DataSource = DonationTable

            MySqlConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub del()
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "DELETE FROM `donations` WHERE `trans_no`='" & trans_no & "'"
            Command = New MySqlCommand(Query, MySqlConn)
            Command.ExecuteNonQuery()

            MsgBox("Deleted Successfully!")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySqlConn.Close()
        End Try
    End Sub

    Sub getData()
        trans_no = dtgDonations.CurrentRow.Cells(0).Value
        fname = dtgDonations.CurrentRow.Cells(1).Value
        lname = dtgDonations.CurrentRow.Cells(2).Value
        mname = dtgDonations.CurrentRow.Cells(3).Value
        ename = dtgDonations.CurrentRow.Cells(4).Value
        date_tans = dtgDonations.CurrentRow.Cells(5).Value
        amount = dtgDonations.CurrentRow.Cells(6).Value
    End Sub

    Private Sub dtgDonations_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgDonations.CellClick
        getData()
    End Sub

    Sub searchDon()

        Try
            DonationTable.Clear()
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM donations WHERE trans_no='" & txtSearch.Text & "'"
            Command = New MySqlCommand(Query, MySqlConn)
            Command.ExecuteNonQuery()

            Adapter.SelectCommand = Command
            Adapter.Fill(DonationTable)
            dtgDonations.DataSource = DonationTable

            MySqlConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        retrieve()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        searchDon()
    End Sub
End Class