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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(128, 176)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "other"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(364, 67)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(128, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "Tom"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(364, 93)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(128, 20)
        Me.TextBox3.TabIndex = 1
        Me.TextBox3.Text = "Jones"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(364, 119)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(128, 20)
        Me.TextBox4.TabIndex = 1
        Me.TextBox4.Text = "1988-12-22"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(364, 145)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(128, 20)
        Me.TextBox5.TabIndex = 1
        Me.TextBox5.Text = "0"
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
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(203, 262)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(289, 20)
        Me.TextBox6.TabIndex = 3
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents btnInsert As Button

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        'this is my query builder. "qs" is the query
        Dim db, fn, ln, dob, qs As String
        Dim cbp As String

        TextBox6.Text = ""
        db = TextBox1.Text
        fn = TextBox2.Text
        ln = TextBox3.Text
        dob = TextBox4.Text
        cbp = TextBox5.Text
        TextBox6.Text =
            "USE " + db + "  DECLARE @ContactIDOut INT;  EXEC dbo.InsertContact   
    @FirstName	=   '" + fn + "', @LastName	=	'" + ln + "', @DateOfBirth =  '" + dob + "',  @AllowCBP	=	
" + cbp + ",  @ContactID = @ContactIDOut OUTPUT;"
        qs = TextBox6.Text
        'Return qs   send query string out of the function
    End Sub

    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents btnRun As Button
    Friend WithEvents Label1 As Label

    Private Sub BtnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        'this is my first attempt at a connection string builder. "cs" is the connection string. 
        'can you help me wiht some usage here?
        Dim cs, svr, db, un, pass As String
        svr = "(local)"
        db = TextBox1.Text
        un = "sa"
        pass = "Password1"
        cs = "Server=" + svr + ";Database=" + db + ";User Id=" + un + "; Password=" + pass + ";"

    End Sub
End Class
