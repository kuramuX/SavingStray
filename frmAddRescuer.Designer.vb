<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddRescuer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddRescuer))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRescuer = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.rbtnFemale = New System.Windows.Forms.RadioButton()
        Me.rbtnMale = New System.Windows.Forms.RadioButton()
        Me.txtMName = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dtpBDay = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(72, 250)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 22)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Birthday"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(72, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 22)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Sex"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(72, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 22)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(72, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 22)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Middle Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 22)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 22)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "First Name"
        '
        'lblRescuer
        '
        Me.lblRescuer.AutoSize = True
        Me.lblRescuer.BackColor = System.Drawing.Color.Transparent
        Me.lblRescuer.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRescuer.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblRescuer.Location = New System.Drawing.Point(156, 53)
        Me.lblRescuer.Name = "lblRescuer"
        Me.lblRescuer.Size = New System.Drawing.Size(183, 32)
        Me.lblRescuer.TabIndex = 19
        Me.lblRescuer.Text = "Add Rescuer"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Location = New System.Drawing.Point(12, 9)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 18
        Me.lblID.Text = "ID"
        Me.lblID.Visible = False
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(206, 286)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(191, 20)
        Me.txtAddress.TabIndex = 24
        '
        'rbtnFemale
        '
        Me.rbtnFemale.AutoSize = True
        Me.rbtnFemale.BackColor = System.Drawing.Color.Transparent
        Me.rbtnFemale.Location = New System.Drawing.Point(280, 222)
        Me.rbtnFemale.Name = "rbtnFemale"
        Me.rbtnFemale.Size = New System.Drawing.Size(59, 17)
        Me.rbtnFemale.TabIndex = 22
        Me.rbtnFemale.TabStop = True
        Me.rbtnFemale.Text = "Female"
        Me.rbtnFemale.UseVisualStyleBackColor = False
        '
        'rbtnMale
        '
        Me.rbtnMale.AutoSize = True
        Me.rbtnMale.BackColor = System.Drawing.Color.Transparent
        Me.rbtnMale.Location = New System.Drawing.Point(206, 221)
        Me.rbtnMale.Name = "rbtnMale"
        Me.rbtnMale.Size = New System.Drawing.Size(48, 17)
        Me.rbtnMale.TabIndex = 21
        Me.rbtnMale.TabStop = True
        Me.rbtnMale.Text = "Male"
        Me.rbtnMale.UseVisualStyleBackColor = False
        '
        'txtMName
        '
        Me.txtMName.Location = New System.Drawing.Point(206, 188)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(191, 20)
        Me.txtMName.TabIndex = 25
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(206, 155)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(191, 20)
        Me.txtLName.TabIndex = 26
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(206, 120)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(191, 20)
        Me.txtFName.TabIndex = 27
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.Transparent
        Me.btnDone.BackgroundImage = CType(resources.GetObject("btnDone.BackgroundImage"), System.Drawing.Image)
        Me.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDone.Location = New System.Drawing.Point(347, 343)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(50, 50)
        Me.btnDone.TabIndex = 29
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Location = New System.Drawing.Point(265, 343)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(50, 50)
        Me.btnCancel.TabIndex = 28
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'dtpBDay
        '
        Me.dtpBDay.Location = New System.Drawing.Point(206, 254)
        Me.dtpBDay.Name = "dtpBDay"
        Me.dtpBDay.Size = New System.Drawing.Size(191, 20)
        Me.dtpBDay.TabIndex = 30
        '
        'frmAddRescuer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.dtpBDay)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtMName)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.rbtnFemale)
        Me.Controls.Add(Me.rbtnMale)
        Me.Controls.Add(Me.lblRescuer)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddRescuer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddRescuer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblRescuer As Label
    Friend WithEvents lblID As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents rbtnFemale As RadioButton
    Friend WithEvents rbtnMale As RadioButton
    Friend WithEvents txtMName As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents btnDone As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents dtpBDay As DateTimePicker
End Class
