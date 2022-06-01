Imports MySql.Data.MySqlClient

Public Class frmAddRescuer
    Dim sex As String
    Private Sub frmAddRescuer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lblRescuer.Text = "Edit Rescuer" Then
            retrieve()
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmRescuerList.Show()
        Me.Close()
    End Sub
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If lblRescuer.Text = "Add Rescuer" Then
            resAdd()
        ElseIf lblRescuer.Text = "Edit Rescuer" Then
            resUpdate()
        End If
    End Sub

    Sub resAdd()
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are you sure you want to add " & txtFName.Text & " " & txtLName.Text & " as rescuer?", "Add Rescuer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            insert()
            Me.Close()
        End If
    End Sub

    Sub resUpdate()
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are you sure you want to update " & txtFName.Text & " " & txtLName.Text & "'s information?", "Update Rescuer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            updateRescuer()
            Me.Close()
        End If
    End Sub

    Sub insert()
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO rescuer (firstname, lastname, middlename, sex, birthday, address) VALUES ('" & txtFName.Text & "','" & txtLName.Text & "','" & txtMName.Text & "','" & sex & "','" & dtpBDay.Text & "','" & txtAddress.Text & "')"
            Command = New MySqlCommand(Query, MySqlConn)
            Command.ExecuteNonQuery()

            MsgBox("Successfully Added!")
            MySqlConn.Close()
            frmRescuerList.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Sub updateRescuer()
        If rbtnFemale.Checked = True Then
            sex = "F"
        ElseIf rbtnMale.Checked = True Then
            sex = "M"
        End If
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "UPDATE `rescuer` SET `firstname`='" & txtFName.Text & "',`lastname`='" & txtLName.Text & "',`middlename`='" & txtMName.Text & "',`sex`='" & sex & "',`birthday`='" & dtpBDay.Text & "',`address`='" & txtAddress.Text & "' WHERE `rescuer_id`='" & lblID.Text & "'"
            Command = New MySqlCommand(Query, MySqlConn)
            Command.ExecuteNonQuery()

            MsgBox("Updated Successfully!")
            MySqlConn.Close()
            frmRescuerList.Show()
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

    Sub retrieve()
        lblID.Text = frmRescuerList.id
        txtFName.Text = frmRescuerList.fname
        txtLName.Text = frmRescuerList.lname
        txtMName.Text = frmRescuerList.mname
        dtpBDay.Text = frmRescuerList.bday
        txtAddress.Text = frmRescuerList.address

        If frmRescuerList.sex = "M" Then
            rbtnMale.Checked = True
        ElseIf frmRescuerList.sex = "F" Then
            rbtnFemale.Checked = True
        End If
    End Sub

End Class