<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtDB = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtDOB = New System.Windows.Forms.TextBox()
        Me.txtCbp = New System.Windows.Forms.TextBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.txtQuery = New System.Windows.Forms.TextBox()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIDReturned = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtDB
        '
        Me.txtDB.Location = New System.Drawing.Point(128, 176)
        Me.txtDB.Name = "txtDB"
        Me.txtDB.Size = New System.Drawing.Size(100, 20)
        Me.txtDB.TabIndex = 0
        Me.txtDB.Text = "other"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(364, 67)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(128, 20)
        Me.txtFirstName.TabIndex = 1
        Me.txtFirstName.Text = "Tom"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(364, 93)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(128, 20)
        Me.txtLastName.TabIndex = 1
        Me.txtLastName.Text = "Jones"
        '
        'txtDOB
        '
        Me.txtDOB.Location = New System.Drawing.Point(364, 119)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(128, 20)
        Me.txtDOB.TabIndex = 1
        Me.txtDOB.Text = "1988-12-22"
        '
        'txtCbp
        '
        Me.txtCbp.Location = New System.Drawing.Point(364, 145)
        Me.txtCbp.Name = "txtCbp"
        Me.txtCbp.Size = New System.Drawing.Size(128, 20)
        Me.txtCbp.TabIndex = 1
        Me.txtCbp.Text = "0"
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(378, 203)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 2
        Me.btnInsert.Text = "&Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'txtQuery
        '
        Me.txtQuery.Location = New System.Drawing.Point(203, 262)
        Me.txtQuery.Name = "txtQuery"
        Me.txtQuery.Size = New System.Drawing.Size(289, 20)
        Me.txtQuery.TabIndex = 3
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(378, 320)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 23)
        Me.btnRun.TabIndex = 4
        Me.btnRun.Text = "&Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Query"
        '
        'txtIDReturned
        '
        Me.txtIDReturned.Location = New System.Drawing.Point(487, 382)
        Me.txtIDReturned.Name = "txtIDReturned"
        Me.txtIDReturned.Size = New System.Drawing.Size(128, 20)
        Me.txtIDReturned.TabIndex = 6
        Me.txtIDReturned.Text = "IDReturned"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtIDReturned)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.txtQuery)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.txtCbp)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtDB)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDB As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtDOB As TextBox
    Friend WithEvents txtCbp As TextBox
    Friend WithEvents btnInsert As Button
    Friend WithEvents txtIDReturned As TextBox

End Class
