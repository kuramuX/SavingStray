<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnimalList
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnimalList))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgAnimals = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBreed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHealth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRescuer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateRescued = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dtgAnimals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(248, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Rescued Animals"
        '
        'dtgAnimals
        '
        Me.dtgAnimals.AllowUserToAddRows = False
        Me.dtgAnimals.AllowUserToDeleteRows = False
        Me.dtgAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgAnimals.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colType, Me.colName, Me.colSex, Me.colBreed, Me.colHealth, Me.Column1, Me.colRescuer, Me.colDateRescued})
        Me.dtgAnimals.GridColor = System.Drawing.SystemColors.Highlight
        Me.dtgAnimals.Location = New System.Drawing.Point(17, 129)
        Me.dtgAnimals.Name = "dtgAnimals"
        Me.dtgAnimals.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgAnimals.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgAnimals.RowHeadersVisible = False
        Me.dtgAnimals.Size = New System.Drawing.Size(542, 288)
        Me.dtgAnimals.TabIndex = 0
        '
        'colID
        '
        Me.colID.DataPropertyName = "animal_id"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Width = 30
        '
        'colType
        '
        Me.colType.DataPropertyName = "animal_type"
        Me.colType.HeaderText = "Animal"
        Me.colType.Name = "colType"
        Me.colType.ReadOnly = True
        Me.colType.Width = 55
        '
        'colName
        '
        Me.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colName.DataPropertyName = "name"
        Me.colName.HeaderText = "Name"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        Me.colName.Width = 60
        '
        'colSex
        '
        Me.colSex.DataPropertyName = "sex"
        Me.colSex.HeaderText = "Sex"
        Me.colSex.Name = "colSex"
        Me.colSex.ReadOnly = True
        Me.colSex.Width = 40
        '
        'colBreed
        '
        Me.colBreed.DataPropertyName = "breed"
        Me.colBreed.HeaderText = "Breed"
        Me.colBreed.Name = "colBreed"
        Me.colBreed.ReadOnly = True
        Me.colBreed.Width = 50
        '
        'colHealth
        '
        Me.colHealth.DataPropertyName = "health"
        Me.colHealth.HeaderText = "Health"
        Me.colHealth.Name = "colHealth"
        Me.colHealth.ReadOnly = True
        Me.colHealth.Width = 55
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.DataPropertyName = "vet_name"
        Me.Column1.HeaderText = "Vet"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'colRescuer
        '
        Me.colRescuer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colRescuer.DataPropertyName = "rescuer"
        Me.colRescuer.HeaderText = "Rescuer"
        Me.colRescuer.Name = "colRescuer"
        Me.colRescuer.ReadOnly = True
        Me.colRescuer.Width = 72
        '
        'colDateRescued
        '
        Me.colDateRescued.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colDateRescued.DataPropertyName = "date_rescued"
        Me.colDateRescued.HeaderText = "Date Rescued"
        Me.colDateRescued.Name = "colDateRescued"
        Me.colDateRescued.ReadOnly = True
        Me.colDateRescued.Width = 101
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(582, 129)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(99, 30)
        Me.txtSearch.TabIndex = 3
        '
        'btnEdit
        '
        Me.btnEdit.BackgroundImage = CType(resources.GetObject("btnEdit.BackgroundImage"), System.Drawing.Image)
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEdit.Location = New System.Drawing.Point(582, 211)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(65, 65)
        Me.btnEdit.TabIndex = 5
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.Location = New System.Drawing.Point(652, 211)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(65, 65)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.Location = New System.Drawing.Point(582, 282)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(135, 135)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Location = New System.Drawing.Point(13, 13)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(50, 50)
        Me.btnBack.TabIndex = 8
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Location = New System.Drawing.Point(687, 129)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(30, 30)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(672, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 50)
        Me.Button2.TabIndex = 25
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(578, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Search by ID"
        '
        'frmAnimalList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 461)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtgAnimals)
        Me.Name = "frmAnimalList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rescued Animals"
        CType(Me.dtgAnimals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents dtgAnimals As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colType As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colSex As DataGridViewTextBoxColumn
    Friend WithEvents colBreed As DataGridViewTextBoxColumn
    Friend WithEvents colHealth As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents colRescuer As DataGridViewTextBoxColumn
    Friend WithEvents colDateRescued As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
End Class
