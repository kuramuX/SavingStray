Imports MySql.Data.MySqlClient

Public Class frmAddAnimal
    Dim sex As String
    Private Sub frmAddAnimal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rescuerName()
        vetName()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmAnimalList.Show()
        Me.Close()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are you sure you want to add " & txtName.Text & "?", "Add Animal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            insert()
        End If
    End Sub
    Sub insert()
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO new_animal (animal_type, name, sex, breed, health, vet_name, rescuer, date_rescued) VALUES ('" & cmbAnimalType.Text & "','" & txtName.Text & "','" & sex & "','" & txtBreed.Text & "','" & cmbHealth.Text & "','" & cmbVet.Text & "','" & cmbRescuer.Text & "','" & dtpDateRescued.Text & "')"
            Command = New MySqlCommand(Query, MySqlConn)
            Command.ExecuteNonQuery()

            MsgBox("Successfully Added!")
            MySqlConn.Close()
            frmAnimalList.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rbtnMale_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnMale.CheckedChanged
        sex = "M"
    End Sub

    Private Sub rbtnFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnFemale.CheckedChanged
        sex = "F"
    End Sub

    Sub rescuerName()
        Try
            RName.Clear()
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT `rescuer_id`, CONCAT(`firstname`,' ', `middlename`,' ', `lastname`) AS `rname` FROM `rescuer`"
            Command = New MySqlCommand(Query, MySqlConn)
            Command.ExecuteNonQuery()

            Adapter.SelectCommand = Command
            Adapter.Fill(RName)
            cmbRescuer.DataSource = RName

            cmbRescuer.DisplayMember = "rname"
            cmbRescuer.ValueMember = "rescuer_id"
            MySqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub vetName()
        Try
            VName.Clear()
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT `vet_id`, CONCAT(`firstname`,' ', `middlename`,' ', `lastname`) AS `vname` FROM `vet`"
            Command = New MySqlCommand(Query, MySqlConn)
            Command.ExecuteNonQuery()

            Adapter.SelectCommand = Command
            Adapter.Fill(VName)
            cmbVet.DataSource = VName

            cmbVet.DisplayMember = "vname"
            cmbVet.ValueMember = "vet_id"
            MySqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class