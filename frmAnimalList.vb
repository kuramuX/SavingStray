Imports MySql.Data.MySqlClient
Public Class frmAnimalList

    Public animal_id As Integer
    Public animal_type As String
    Public animal_name As String
    Public animal_sex As String
    Public animal_breed As String
    Public animal_health As String
    Public animal_vet As String
    Public animal_rescuer As String
    Public animal_drescued As String

    Private Sub frmAnimalList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        retrieve()
    End Sub

    Sub retrieve()

        Try
            AnimalTable.Clear()
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM new_animal"
            Command = New MySqlCommand(Query, MySqlConn)
            Command.ExecuteNonQuery()

            Adapter.SelectCommand = Command
            Adapter.Fill(AnimalTable)
            dtgAnimals.DataSource = AnimalTable
            MySqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub del()
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "DELETE FROM `new_animal` WHERE `animal_id`='" & animal_id & "'"
            Command = New MySqlCommand(Query, MySqlConn)
            Command.ExecuteNonQuery()

            MsgBox("Deleted Successfully!")
            MySqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub getData()
        animal_id = dtgAnimals.CurrentRow.Cells(0).Value
        animal_type = dtgAnimals.CurrentRow.Cells(1).Value
        animal_name = dtgAnimals.CurrentRow.Cells(2).Value
        animal_sex = dtgAnimals.CurrentRow.Cells(3).Value
        animal_breed = dtgAnimals.CurrentRow.Cells(4).Value
        animal_health = dtgAnimals.CurrentRow.Cells(5).Value
        animal_vet = dtgAnimals.CurrentRow.Cells(6).Value
        animal_rescuer = dtgAnimals.CurrentRow.Cells(7).Value
        animal_drescued = dtgAnimals.CurrentRow.Cells(8).Value
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If animal_name = "" Then
            MessageBox.Show("There is no selected animal to be deleted.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim dialog As DialogResult
            dialog = MessageBox.Show("Do you want to delete " & animal_name & "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If dialog = DialogResult.Yes Then
                del()
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If animal_name = "" Then
            MessageBox.Show("Please select an animal to update.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            frmViewAnimal.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmAddHome.Show()
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddAnimal.Show()
        Me.Close()
    End Sub

    Private Sub dtgAnimals_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgAnimals.CellClick
        getData()
    End Sub

    Sub searchAnimal()
        Try
            AnimalTable.Clear()
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM new_animal WHERE animal_id='" & txtSearch.Text & "'"
            Command = New MySqlCommand(Query, MySqlConn)
            Command.ExecuteNonQuery()

            Adapter.SelectCommand = Command
            Adapter.Fill(AnimalTable)
            dtgAnimals.DataSource = AnimalTable
            MySqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        searchAnimal()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        retrieve()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

End Class