Imports System.Data.SqlClient
Public Class Form1

    Private Const SqlConnString As String = "Database=Demo;Server=DESKTOP-7H6L3KN;Integrated Security=SSPI;"

    Private Sub Login(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Conn As SqlConnection = Nothing   'Equivalent to null in C#
        Dim SqlTxt As String = ""

        Try
            Dim GetPassword As String = TextBox1.Text.Trim().ToLower()
            Conn = New SqlConnection(SqlConnString)
            Conn.Open()

            If (GetPassword = "") Then
                MessageBox.Show("Please enter your password!", "Warning!")
                Exit Sub
            End If

            SqlTxt = "SELECT * FROM MasterShopInfo WHERE ShopPassword=@Pass"

            Dim SqlCmd As SqlCommand = New SqlCommand(SqlTxt, Conn)
            SqlCmd.Parameters.AddWithValue("@Pass", GetPassword)

            Dim SqlDataReader As SqlDataReader = SqlCmd.ExecuteReader()
            If (SqlDataReader.HasRows) Then
                SqlDataReader.Read()
                Dim U_ShopId As String = SqlDataReader("ShopId").ToString()
                Dim U_ShopName As String = SqlDataReader("ShopName").ToString()

                Dim Form2 As New Form2(U_ShopId, U_ShopName)
                Me.Hide()
                Form2.Show()
            Else
                MessageBox.Show("Wrong Password Entered!", "Error")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub Password_Change(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim psi As New ProcessStartInfo()
        psi.FileName = "https://www.w3schools.com/colors/colors_picker.asp"
        psi.UseShellExecute = True
        Process.Start(psi)
    End Sub
End Class
