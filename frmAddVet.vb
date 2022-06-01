Imports MySql.Data.MySqlClient

Public Class frmAddVet
    Dim sex As String
    Private Sub frmAddVet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lblVet.Text = "Edit Vet" Then
            retrieve()
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmVetList.Show()
        Me.Close()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If lblVet.Text = "Add Vet" Then
            vetAdd()
        ElseIf lblVet.Text = "Edit Vet" Then
            vetUpdate()
        End If
    End Sub

    Sub vetAdd()
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are you sure you want to add " & txtFName.Text & " " & txtLName.Text & " as vet?", "Add Vet", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            insert()
            Me.Close()
        End If
    End Sub

    Sub vetUpdate()
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are you sure you want to update " & txtFName.Text & " " & txtLName.Text & "'s information?", "Update Vet", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            updateVet()
            Me.Close()
        End If
    End Sub

    Sub retrieve()
        lblID.Text = frmVetList.id
        txtFName.Text = frmVetList.fname
        txtLName.Text = frmVetList.lname
        txtMName.Text = frmVetList.mname
        dtpBDay.Text = frmVetList.bday
        txtAddress.Text = frmVetList.clinic

        If frmVetList.sex = "M" Then
            rbtnMale.Checked = True
        ElseIf frmVetList.sex = "F" Then
            rbtnFemale.Checked = True
        End If
    End Sub

    Sub updateVet()
        If rbtnFemale.Checked = True Then
            sex = "F"
        ElseIf rbtnMale.Checked = True Then
            sex = "M"
        End If
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "UPDATE `vet` SET `firstname`='" & txtFName.Text & "',`lastname`='" & txtLName.Text & "',`middlename`='" & txtMName.Text & "',`sex`='" & sex & "',`birthday`='" & dtpBDay.Text & "',`clinic_address`='" & txtAddress.Text & "' WHERE `vet_id`='" & lblID.Text & "'"
            Command = New MySqlCommand(Query, MySqlConn)
            Command.ExecuteNonQuery()

            MsgBox("Updated Successfully!")
            MySqlConn.Close()
            frmVetList.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub insert()
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO vet (firstname, lastname, middlename, sex, birthday, clinic_address) VALUES ('" & txtFName.Text & "','" & txtLName.Text & "','" & txtMName.Text & "','" & sex & "','" & dtpBDay.Text & "','" & txtAddress.Text & "')"
            Command = New MySqlCommand(Query, MySqlConn)
            Command.ExecuteNonQuery()

            MsgBox("Successfully Added!")
            MySqlConn.Close()
            frmVetList.Show()
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
End Class