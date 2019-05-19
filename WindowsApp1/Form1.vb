Partial Class Form1

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        'this is my query builder. "qs" is the query

        txtQuery.Text = ""
        Dim db As String = txtDB.Text
        Dim fn As String = txtFirstName.Text
        Dim ln As String = txtLastName.Text
        Dim dob As String = txtDOB.Text
        Dim cbp As String = txtCbp.Text
        Dim SQL As String = "USE " + db + "  DECLARE @ContactIDOut INT;  EXEC dbo.InsertContact   
            @FirstName	=   '" + fn + "', @LastName	=	'" + ln + "', @DateOfBirth =  '" + dob + "',  @AllowCBP	=	
        " + cbp + ",  @ContactID = @ContactIDOut OUTPUT;"

        txtQuery.Text = SQL
        'Return SQL   send query string out of the function
    End Sub

    Friend WithEvents txtQuery As TextBox
    Friend WithEvents btnRun As Button
    Friend WithEvents Label1 As Label

    Private Sub BtnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click

        Call DoADatabaseThing()

    End Sub

    Private Sub DoADatabaseThing()
        Dim connectionString As String = "Data Source=(local);Initial Catalog=" & txtDB.Text & ";Integrated Security=True"
        Dim connection As New SqlClient.SqlConnection(connectionString)
        connection.Open()
        Dim command As New SqlClient.SqlCommand("dbo.InsertContact", connection)
        command.CommandType = CommandType.StoredProcedure
        Dim parm As SqlClient.SqlParameter = command.Parameters.AddWithValue("FirstName", txtFirstName.Text)
        parm.Size = 50
        parm = command.Parameters.AddWithValue("LastName", txtLastName.Text)
        parm.Size = 50
        parm = command.Parameters.AddWithValue("DateOfBirth", DateTime.Parse(txtDOB.Text))
        parm = command.Parameters.AddWithValue("AllowCBP", Convert.ToBoolean(Int32.Parse(txtCbp.Text)))
        parm.DbType = System.Data.SqlDbType.Bit
        Dim returnValueParm As New SqlClient.SqlParameter
        returnValueParm.Direction = System.Data.ParameterDirection.ReturnValue
        command.Parameters.Add(returnValueParm)
        Dim contactIdParm As New SqlClient.SqlParameter
        contactIdParm.Direction = System.Data.ParameterDirection.Output
        contactIdParm.ParameterName = "ContactID"
        contactIdParm.DbType = System.Data.SqlDbType.Int
        command.Parameters.Add(contactIdParm)
        command.ExecuteNonQuery()

        Dim returnValueObj = returnValueParm.Value
        Dim contactIdObj = contactIdParm.Value
        txtIDReturned.Text = contactIdObj
        command.Dispose()
        connection.Dispose() 'closes connection
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtIDReturned.TextChanged

    End Sub

    'tested: EXEC dbo.InsertContact  @FirstName = 'Boone',  @LastName = 'Smith', @DateOfBirth  = '1999-05-07', @AllowCBP = 0, @ContactID=23;

End Class