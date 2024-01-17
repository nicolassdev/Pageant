Imports MySql.Data.MySqlClient
Module dbConnection
    Public newrecord As Boolean
    Public MyAdapter As New MySqlDataAdapter
    Public dt As New DataTable
    Public num As Integer
    Public MyCommand As New MySqlCommand
    Public MyCon As MySqlConnection = New MySqlConnection("datasource=localhost;uid=root;database=pageantdb;")

    Public Sub ExecButton(ByVal query)
        Try
            If (MyCon.State = ConnectionState.Open) Then
                MyCon.Close()
            End If
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = query
            MyAdapter.SelectCommand = MyCommand
            Dim MyData As MySqlDataReader = MyCommand.ExecuteReader
            MyCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Get Max num of candidate Table
    Public Function getMaxCan()
        Try

            If (MyCon.State = ConnectionState.Open) Then
                MyCon.Close()
            End If
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = "SELECT COALESCE(MAX(CAN_NUM), 0) AS MAX_NUM FROM candidate"
            MyAdapter.SelectCommand = MyCommand
            Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader
            MySQLData.Read()
            num = MySQLData("MAX_NUM") '3


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        getMaxCan = num '3
        MyCon.Close()
    End Function

    'Get Max num of judge Table
    Public Function getMaxJudge()
        Try

            If (MyCon.State = ConnectionState.Open) Then
                MyCon.Close()
            End If
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = "SELECT COALESCE(MAX(J_NUM), 0) AS MAX_NUM FROM judge"
            MyAdapter.SelectCommand = MyCommand
            Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader
            MySQLData.Read()
            num = MySQLData("MAX_NUM") '3


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        getMaxJudge = num '3
        MyCon.Close()
    End Function

    'Get Max num of attainmetn Table
    Public Function getMaxAttain()
        Try

            If (MyCon.State = ConnectionState.Open) Then
                MyCon.Close()
            End If
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = "SELECT COALESCE(MAX(STUD_NUM), 0) AS MAX_NUM FROM attainment"
            MyAdapter.SelectCommand = MyCommand
            Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader
            MySQLData.Read()
            num = MySQLData("MAX_NUM") '3


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        getMaxAttain = num '3
        MyCon.Close()
    End Function

End Module
