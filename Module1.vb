﻿Imports System.Data.Common
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.Design
Imports K4os.Compression.LZ4.Streams
Imports MySql.Data.MySqlClient

Module Module1

    Dim con As New MySqlConnection
    Dim reader As MySqlDataReader
    Dim mysqlcmd As New MySqlCommand
    Dim host, uname, pwd, dbname As String
    Dim sqlquery As String
    Dim dbTable As New DataTable
    Dim adapter As New MySqlDataAdapter


    Public Sub ConnectDbase()
        host = "127.0.0.1"
        dbname = "csoop"
        uname = "root"
        pwd = "password"

        If Not con Is Nothing Then
            con.Close()
            con.ConnectionString = "server =" & host & "; user id =" & uname & "; password =" & pwd & "; database =" & dbname & ""

            Try
                con.Open()
                ' MessageBox.Show("Connected!")
            Catch ex As Exception

            End Try

        End If
    End Sub

    Public Sub SaveRecord()

        Dim fname = Form1.txtfname.Text
        Dim lname = Form1.txtlname.Text
        Dim course = Form1.txtcourse.Text

        sqlquery = "INSERT INTO students(studFName, studLName, Course) VALUES (@fname, @lname, @course)"

        mysqlcmd = New MySqlCommand(sqlquery, con)

        mysqlcmd.Parameters.AddWithValue("@fname", fname)
        mysqlcmd.Parameters.AddWithValue("@lname", lname)
        mysqlcmd.Parameters.AddWithValue("@course", course)

        Try
            mysqlcmd.ExecuteNonQuery()
            MsgBox("Record Saved Successfully")

        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
        Finally
            Form1.txtfname.Clear()
            Form1.txtlname.Clear()
            Form1.txtcourse.Clear()
        End Try

    End Sub

    Public Sub SearchData()

        Dim uid As String

        sqlquery = "SELECT * FROM students WHERE studID = @uid"
        mysqlcmd = New MySqlCommand(sqlquery, con)
        uid = Form1.txtUserID.Text
        mysqlcmd.Parameters.AddWithValue("@uid", uid)

        Try
            reader = mysqlcmd.ExecuteReader
            If reader.Read Then
                Form1.txtFNameSearch.Text = reader("StudFName").ToString
                Form1.txtLNameSearch.Text = reader("StudLName").ToString
                Form1.txtCourseSearch.Text = reader("Course").ToString
            Else
                MsgBox("No Record")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            reader.Close()

        End Try

    End Sub

    Public Sub LoadAllData()
        sqlquery = "SELECT * FROM students"
        adapter = New MySqlDataAdapter(sqlquery, con)
        Try
            dbTable = New DataTable
            adapter.Fill(dbTable)
            With Form2.dgvData
                .DataSource = dbTable
                .AutoResizeColumns()

            End With


            'display the record data grid view


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub LoadCourse()
        sqlquery = "SELECT * FROM students"
        Try
            mysqlcmd = New MySqlCommand(sqlquery, con)
            reader = mysqlcmd.ExecuteReader
            While reader.Read()
                Form2.cboCourse.Items.Add(reader("course").ToString)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub DisplayData(kurso As String)
        sqlquery = "SELECT * FROM students WHERE course = @kurso"
        adapter = New MySqlDataAdapter(sqlquery, con)
        adapter.SelectCommand.Parameters.AddWithValue("@kurso", kurso)
        Try
            dbTable = New DataTable
            adapter.Fill(dbTable)
            With Form2.dgvData
                .DataSource = dbTable
                .AutoResizeColumns()

            End With


            'display the record data grid view


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Module