<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddHome))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAnimal = New System.Windows.Forms.Button()
        Me.btnDonation = New System.Windows.Forms.Button()
        Me.btnRescuer = New System.Windows.Forms.Button()
        Me.btnVet = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(140, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Saving Stray"
        '
        'btnAnimal
        '
        Me.btnAnimal.BackgroundImage = CType(resources.GetObject("btnAnimal.BackgroundImage"), System.Drawing.Image)
        Me.btnAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAnimal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnimal.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnimal.Location = New System.Drawing.Point(100, 111)
        Me.btnAnimal.Name = "btnAnimal"
        Me.btnAnimal.Size = New System.Drawing.Size(120, 120)
        Me.btnAnimal.TabIndex = 1
        Me.btnAnimal.UseVisualStyleBackColor = True
        '
        'btnDonation
        '
        Me.btnDonation.BackgroundImage = CType(resources.GetObject("btnDonation.BackgroundImage"), System.Drawing.Image)
        Me.btnDonation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDonation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDonation.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDonation.Location = New System.Drawing.Point(265, 111)
        Me.btnDonation.Name = "btnDonation"
        Me.btnDonation.Size = New System.Drawing.Size(120, 120)
        Me.btnDonation.TabIndex = 2
        Me.btnDonation.UseVisualStyleBackColor = True
        '
        'btnRescuer
        '
        Me.btnRescuer.BackgroundImage = CType(resources.GetObject("btnRescuer.BackgroundImage"), System.Drawing.Image)
        Me.btnRescuer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRescuer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRescuer.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRescuer.Location = New System.Drawing.Point(100, 276)
        Me.btnRescuer.Name = "btnRescuer"
        Me.btnRescuer.Size = New System.Drawing.Size(120, 120)
        Me.btnRescuer.TabIndex = 3
        Me.btnRescuer.UseVisualStyleBackColor = True
        '
        'btnVet
        '
        Me.btnVet.BackgroundImage = CType(resources.GetObject("btnVet.BackgroundImage"), System.Drawing.Image)
        Me.btnVet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVet.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVet.Location = New System.Drawing.Point(265, 276)
        Me.btnVet.Name = "btnVet"
        Me.btnVet.Size = New System.Drawing.Size(120, 120)
        Me.btnVet.TabIndex = 4
        Me.btnVet.UseVisualStyleBackColor = True
        '
        'frmAddHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.btnVet)
        Me.Controls.Add(Me.btnRescuer)
        Me.Controls.Add(Me.btnDonation)
        Me.Controls.Add(Me.btnAnimal)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saving Stray"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnAnimal As Button
    Friend WithEvents btnDonation As Button
    Friend WithEvents btnRescuer As Button
    Friend WithEvents btnVet As Button
End Class
