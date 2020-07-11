Imports System.Data.Odbc

Public MustInherit Class Conexion

    Public Driver As String = "Mysql ODBC 8.0 Unicode Driver"
    Public Uid As String = "root"
    Public Pwd As String = "root"
    Public Port As String = "3306"
    Public NombreBBDD As String = "practico_3"
    Public Host As String = "localhost"

    Public Connect As New OdbcConnection(
        "DRIVER=" + Me.Driver +
        ";UID=" + Me.Uid +
        ";PWD=" + Me.Pwd +
        ";PORT=" + Me.Port +
        ";DATABASE=" + Me.NombreBBDD +
        ";SERVER=" + Me.Host
    )

    Public Command As New OdbcCommand
    Public Reader As OdbcDataReader

    Public Sub New()
        Me.Connect.Open()
        Me.Command.Connection = Me.Connect
    End Sub



End Class
