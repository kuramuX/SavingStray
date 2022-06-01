Imports MySql.Data.MySqlClient

Public Class frmViewAnimal

    Dim sex As String

    Private Sub frmViewAnimal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rescuerName()
        vetName()
        lblID.Text = frmAnimalList.animal_id
        cmbAnimalType.Text = frmAnimalList.animal_type
        txtName.Text = frmAnimalList.animal_name
        txtBreed.Text = frmAnimalList.animal_breed
        cmbHealth.Text = frmAnimalList.animal_health
        cmbRescuer.Text = frmAnimalList.animal_rescuer
        dtpDateRescued.Text = frmAnimalList.animal_drescued

        If frmAnimalList.animal_sex = "M" Then
            rbtnMale.Checked = True
        ElseIf frmAnimalList.animal_sex = "F" Then
            rbtnFemale.Checked = True
        End If
    End Sub

    Sub updateAnimal()
        If rbtnFemale.Checked = True Then
            sex = "F"
        ElseIf rbtnMale.Checked = True Then
            sex = "M"
        End If
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "UPDATE `new_animal` SET `animal_type`='" & cmbAnimalType.Text & "',`name`='" & txtName.Text & "',`sex`='" & sex & "',`breed`='" & txtBreed.Text & "',`health`='" & cmbHealth.Text & "',`vet_name`='" & cmbVet.Text & "',`rescuer`='" & cmbRescuer.Text & "',`date_rescued`='" & dtpDateRescued.Text & "' WHERE `animal_id`='" & lblID.Text & "'"
            Command = New MySqlCommand(Query, MySqlConn)
            Command.ExecuteNonQuery()

            MsgBox("Updated Successfully!")
            MySqlConn.Close()
            frmAnimalList.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmAnimalList.Show()
        Me.Close()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you want to update " & txtName.Text & "'s information?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            updateAnimal()
            frmAnimalList.Show()
            Me.Close()
        End If
    End Sub

    Sub rescuerName()
        Try
            RName.Clear()
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT `rescuer_id`, CONCAT(`firstname`,' ', `lastname`,' ', `middlename`) AS `rname` FROM `rescuer`"
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