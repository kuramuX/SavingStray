Imports MySql.Data.MySqlClient

Public Class frmVetList
    Public id As Integer
    Public fname As String
    Public lname As String
    Public mname As String
    Public sex As String
    Public bday As String
    Public clinic As String
    Private Sub frmVetList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        retrieve()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If fname = "" Then
            MessageBox.Show("Please select a vet to update.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            frmAddVet.lblVet.Text = "Edit Vet"
            frmAddVet.Text = "Edit Vet"
            frmAddVet.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If fname = "" Then
            MessageBox.Show("There is no selected animal to be deleted.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim dialog As DialogResult
            dialog = MessageBox.Show("Do you want to remove Dr. " & lname & " as a vet?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If dialog = DialogResult.Yes Then
                del()
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddVet.lblVet.Text = "Add Vet"
        frmAddVet.Text = "Add Vet"
        frmAddVet.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmAddHome.Show()
        Me.Close()
    End Sub

    Sub retrieve()
        Try
            VetTable.Clear()
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM vet"
            Command = New MySqlCommand(Query, MySqlConn)
            Command.ExecuteNonQuery()

            Adapter.SelectCommand = Command
            Adapter.Fill(VetTable)
            dtgVets.DataSource = VetTable
            MySqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub del()
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "DELETE FROM `vet` WHERE `vet_id`='" & id & "'"
            Command = New MySqlCommand(Query, MySqlConn)
            Command.ExecuteNonQuery()

            MsgBox("Deleted Successfully!")
            MySqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub getData()
        id = dtgVets.CurrentRow.Cells(0).Value
        fname = dtgVets.CurrentRow.Cells(1).Value
        lname = dtgVets.CurrentRow.Cells(2).Value
        mname = dtgVets.CurrentRow.Cells(3).Value
        sex = dtgVets.CurrentRow.Cells(4).Value
        bday = dtgVets.CurrentRow.Cells(5).Value
        clinic = dtgVets.CurrentRow.Cells(6).Value
    End Sub

    Private Sub dtgVets_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgVets.CellClick
        getData()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        searchVet()
    End Sub

    Sub searchVet()
        Try
            VetTable.Clear()
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM vet WHERE vet_id='" & txtSearch.Text & "'"
            Command = New MySqlCommand(Query, MySqlConn)
            Command.ExecuteNonQuery()

            Adapter.SelectCommand = Command
            Adapter.Fill(VetTable)
            dtgVets.DataSource = VetTable
            MySqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        retrieve()
    End Sub
End Class