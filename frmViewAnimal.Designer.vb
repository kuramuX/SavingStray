<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewAnimal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewAnimal))
        Me.dtpDateRescued = New System.Windows.Forms.DateTimePicker()
        Me.txtBreed = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.rbtnFemale = New System.Windows.Forms.RadioButton()
        Me.rbtnMale = New System.Windows.Forms.RadioButton()
        Me.cmbRescuer = New System.Windows.Forms.ComboBox()
        Me.cmbHealth = New System.Windows.Forms.ComboBox()
        Me.cmbAnimalType = New System.Windows.Forms.ComboBox()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAnimalName = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.cmbVet = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtpDateRescued
        '
        Me.dtpDateRescued.Location = New System.Drawing.Point(216, 332)
        Me.dtpDateRescued.Name = "dtpDateRescued"
        Me.dtpDateRescued.Size = New System.Drawing.Size(191, 20)
        Me.dtpDateRescued.TabIndex = 40
        '
        'txtBreed
        '
        Me.txtBreed.Location = New System.Drawing.Point(216, 196)
        Me.txtBreed.Name = "txtBreed"
        Me.txtBreed.Size = New System.Drawing.Size(191, 20)
        Me.txtBreed.TabIndex = 39
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(216, 130)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(191, 20)
        Me.txtName.TabIndex = 38
        '
        'rbtnFemale
        '
        Me.rbtnFemale.AutoSize = True
        Me.rbtnFemale.BackColor = System.Drawing.Color.Transparent
        Me.rbtnFemale.Location = New System.Drawing.Point(290, 167)
        Me.rbtnFemale.Name = "rbtnFemale"
        Me.rbtnFemale.Size = New System.Drawing.Size(59, 17)
        Me.rbtnFemale.TabIndex = 37
        Me.rbtnFemale.TabStop = True
        Me.rbtnFemale.Text = "Female"
        Me.rbtnFemale.UseVisualStyleBackColor = False
        '
        'rbtnMale
        '
        Me.rbtnMale.AutoSize = True
        Me.rbtnMale.BackColor = System.Drawing.Color.Transparent
        Me.rbtnMale.Location = New System.Drawing.Point(216, 166)
        Me.rbtnMale.Name = "rbtnMale"
        Me.rbtnMale.Size = New System.Drawing.Size(48, 17)
        Me.rbtnMale.TabIndex = 36
        Me.rbtnMale.TabStop = True
        Me.rbtnMale.Text = "Male"
        Me.rbtnMale.UseVisualStyleBackColor = False
        '
        'cmbRescuer
        '
        Me.cmbRescuer.FormattingEnabled = True
        Me.cmbRescuer.Items.AddRange(New Object() {"Kuramu", "Marc", "Cram"})
        Me.cmbRescuer.Location = New System.Drawing.Point(216, 263)
        Me.cmbRescuer.Name = "cmbRescuer"
        Me.cmbRescuer.Size = New System.Drawing.Size(191, 21)
        Me.cmbRescuer.TabIndex = 35
        '
        'cmbHealth
        '
        Me.cmbHealth.FormattingEnabled = True
        Me.cmbHealth.Items.AddRange(New Object() {"Healthy", "Sick", "Injured"})
        Me.cmbHealth.Location = New System.Drawing.Point(216, 228)
        Me.cmbHealth.Name = "cmbHealth"
        Me.cmbHealth.Size = New System.Drawing.Size(191, 21)
        Me.cmbHealth.TabIndex = 34
        '
        'cmbAnimalType
        '
        Me.cmbAnimalType.FormattingEnabled = True
        Me.cmbAnimalType.Items.AddRange(New Object() {"Cat", "Dog"})
        Me.cmbAnimalType.Location = New System.Drawing.Point(216, 97)
        Me.cmbAnimalType.Name = "cmbAnimalType"
        Me.cmbAnimalType.Size = New System.Drawing.Size(191, 21)
        Me.cmbAnimalType.TabIndex = 33
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.Transparent
        Me.btnDone.BackgroundImage = CType(resources.GetObject("btnDone.BackgroundImage"), System.Drawing.Image)
        Me.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDone.Location = New System.Drawing.Point(357, 385)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(50, 50)
        Me.btnDone.TabIndex = 32
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Location = New System.Drawing.Point(273, 385)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(50, 50)
        Me.btnCancel.TabIndex = 31
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(72, 332)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 22)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Date Rescued"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(72, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 22)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Breed"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(72, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 22)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Health"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(72, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 22)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Sex"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 22)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Rescuer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 22)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 22)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Animal Type"
        '
        'lblAnimalName
        '
        Me.lblAnimalName.AutoSize = True
        Me.lblAnimalName.BackColor = System.Drawing.Color.Transparent
        Me.lblAnimalName.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnimalName.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblAnimalName.Location = New System.Drawing.Point(153, 33)
        Me.lblAnimalName.Name = "lblAnimalName"
        Me.lblAnimalName.Size = New System.Drawing.Size(166, 32)
        Me.lblAnimalName.TabIndex = 23
        Me.lblAnimalName.Text = "Edit Animal"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Location = New System.Drawing.Point(12, 9)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 22
        Me.lblID.Text = "ID"
        Me.lblID.Visible = False
        '
        'cmbVet
        '
        Me.cmbVet.FormattingEnabled = True
        Me.cmbVet.Location = New System.Drawing.Point(216, 298)
        Me.cmbVet.Name = "cmbVet"
        Me.cmbVet.Size = New System.Drawing.Size(191, 21)
        Me.cmbVet.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 297)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 22)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Vet"
        '
        'frmViewAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.cmbVet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDateRescued)
        Me.Controls.Add(Me.txtBreed)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.rbtnFemale)
        Me.Controls.Add(Me.rbtnMale)
        Me.Controls.Add(Me.cmbRescuer)
        Me.Controls.Add(Me.cmbHealth)
        Me.Controls.Add(Me.cmbAnimalType)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblAnimalName)
        Me.Controls.Add(Me.lblID)
        Me.Name = "frmViewAnimal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Animal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpDateRescued As DateTimePicker
    Friend WithEvents txtBreed As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents rbtnFemale As RadioButton
    Friend WithEvents rbtnMale As RadioButton
    Friend WithEvents cmbRescuer As ComboBox
    Friend WithEvents cmbHealth As ComboBox
    Friend WithEvents cmbAnimalType As ComboBox
    Friend WithEvents btnDone As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAnimalName As Label
    Friend WithEvents lblID As Label
    Friend WithEvents cmbVet As ComboBox
    Friend WithEvents Label1 As Label
End Class
