Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports DevExpress.Data

Public Class conexion
    Dim cone As New SqlConnection
    Dim cnn As New MySqlConnection


    'CONEXION X MYSQL A LA BD
    Public Sub conet()

        Dim DatabaseName As String = "Database NAme"

        Dim server As String = "ip address here"

        Dim userName As String = "sarmasar here"

        Dim password As String = "password here"

        If Not cnn() Is Nothing Then conet.Close()

        cnn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)

        Try

            cnn.Open()
            MsgBox("Connected")

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        cnn.Close()

    End Sub


    'ESTO VA DENTRO DEL BOTON AGREGAR
    Try

            conn.Open()

        Catch ex As Exception

    End Try

    Dim cmd As New MySqlCommand(String.Format("INSERT INTO `Products` (`upc` , `qty`) VALUES ('{0}' , '{1}')", "upc Value", "Quantity"))

        cmd.ExecuteNonQuery()

        conn.Close()




End Class
