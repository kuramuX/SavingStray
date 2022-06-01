Imports MySql.Data.MySqlClient
Module Module1
    Public MySqlConn As New MySqlConnection
    Public Command As New MySqlCommand
    Public AnimalTable As New DataTable
    Public DonationTable As New DataTable
    Public RescuerTable As New DataTable
    Public RName As New DataTable
    Public VName As New DataTable
    Public VetTable As New DataTable
    Public Adapter As New MySqlDataAdapter

    Sub connection()
        Try
            MySqlConn = New MySqlConnection("server=localhost; username=root; password=; database=saving_stray")
            MySqlConn.Open()
            MsgBox("Connected to database")
        Catch
            MsgBox("Database connection failed")
        Finally
            MySqlConn.Close()
        End Try
    End Sub

End Module
