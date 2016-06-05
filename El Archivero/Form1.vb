Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As New SqlConnection
        cnn.Open()

    End Sub
End Class
