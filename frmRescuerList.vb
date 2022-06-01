Imports MySql.Data.MySqlClient

Public Class frmRescuerList
    Public id As Integer
    Public fname As String
    Public lname As String
    Public mname As String
    Public sex As String
    Public bday As String
    Public address As String
    Private Sub frmRescuerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        retrieve()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmAddHome.Show()
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddRescuer.lblRescuer.Text = "Add Rescuer"
        frmAddRescuer.Text = "Add Rescuer"
        frmAddRescuer.Show()
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If fname = "" Then
            MessageBox.Show("Please select a rescuer to update.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            frmAddRescuer.lblRescuer.Text = "Edit Rescuer"
            frmAddRescuer.Text = "Edit Rescuer"
            frmAddRescuer.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If fname = "" Then
            MessageBox.Show("Please select a rescuer to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim dialog As DialogResult
            dialog = MessageBox.Show("Do you want to remove " & fname & " " & lname & " as rescuer?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If dialog = DialogResult.Yes Then
                del()
            End If
        End If
    End Sub

    Sub retrieve()
        Try
            RescuerTable.Clear()
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM rescuer"
            Command = New MySqlCommand(Query, MySqlConn)
            Command.ExecuteNonQuery()

            Adapter.SelectCommand = Command
            Adapter.Fill(RescuerTable)
            dtgRescuers.DataSource = RescuerTable
            MySqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub del()
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "DELETE FROM `rescuer` WHERE `rescuer_id`='" & id & "'"
            Command = New MySqlCommand(Query, MySqlConn)
            Command.ExecuteNonQuery()

            MsgBox("Deleted Successfully!")
            MySqlConn.Close()
            retrieve()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub getData()
        id = dtgRescuers.CurrentRow.Cells(0).Value
        fname = dtgRescuers.CurrentRow.Cells(1).Value
        lname = dtgRescuers.CurrentRow.Cells(2).Value
        mname = dtgRescuers.CurrentRow.Cells(3).Value
        sex = dtgRescuers.CurrentRow.Cells(4).Value
        bday = dtgRescuers.CurrentRow.Cells(5).Value
        address = dtgRescuers.CurrentRow.Cells(6).Value
    End Sub

    Private Sub dtgAnimals_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgRescuers.CellClick
        getData()
    End Sub

    Sub searchRes()
        Try
            RescuerTable.Clear()
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM rescuer WHERE rescuer_id='" & txtSearch.Text & "'"
            Command = New MySqlCommand(Query, MySqlConn)
            Command.ExecuteNonQuery()

            Adapter.SelectCommand = Command
            Adapter.Fill(RescuerTable)
            dtgRescuers.DataSource = RescuerTable
            MySqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        searchRes()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        retrieve()
    End Sub
End Class