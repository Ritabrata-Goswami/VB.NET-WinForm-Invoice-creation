Imports System.Data.SqlClient
Imports Windows.Win32.System

Public Class Form2
    Public ShopId As String
    Public ShopName As String
    Private Const SqlConnString As String = "Database=Demo;Server=DESKTOP-7H6L3KN;Integrated Security=SSPI;"

    Public Sub New(ByVal Id As String, ByVal Name As String)

        ' This call is required by the designer.
        InitializeComponent()

        ShopId = Id
        ShopName = Name
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Conn As SqlConnection = Nothing   'Equivalent to null in C#
        Try
            Conn = New SqlConnection(SqlConnString)
            Conn.Open()

            Label2.Text = ShopName
            Label3.Text = ShopId

            Dim SqlTxt = "SELECT * FROM ShopBillInvoice WHERE [ShopId]='" + ShopId + "'"
            'Dim Cmd As SqlCommand = New SqlCommand(SqlTxt, Conn)
            Dim DataAdp = New SqlDataAdapter(SqlTxt, Conn)
            Dim DataTable = New DataTable
            DataAdp.Fill(DataTable)

            DataGridView1.DataSource = DataTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception")
        Finally
            Conn.Close()
        End Try

    End Sub

    Private Sub Logout(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Dim Form1 As New Form1
        Form1.Show()
    End Sub

    Private Sub Save_Invoice(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Conn As SqlConnection = Nothing   'Equivalent to null in C#
        Dim SqlTxt = ""

        Try
            Conn = New SqlConnection(SqlConnString)
            Conn.Open()

            Dim CustName = TextBox1.Text.Trim
            Dim ProductName = TextBox2.Text.Trim
            Dim Price = ""
            If TextBox3.Text = "" Then
                Price = 0
            ElseIf Not IsNumeric(TextBox3.Text.Trim) Then
                MessageBox.Show("Please enter valid number!", "Error")
                Exit Sub
            Else
                Price = Convert.ToDecimal(TextBox3.Text.Trim)
            End If


            Dim UoM = ""

            If RadioButton1.Checked Then
                UoM = RadioButton1.Text.Trim
            End If
            If RadioButton2.Checked Then
                UoM = RadioButton2.Text.Trim
            End If
            If RadioButton3.Checked Then
                UoM = RadioButton3.Text.Trim
            End If

            Dim BillDate = DateTimePicker1.Value

            If CustName = "" Or ProductName = "" Or Price = 0 Or UoM = "" Or BillDate = Date.MinValue Then
                MessageBox.Show("Bill can't be saved!", "Error")
                Exit Sub
            End If

            SqlTxt = "INSERT INTO ShopBillInvoice (ShopId,InvoiceId,CustomerName,ProductName,ProductPrice,UoM,BillDate)
                        VALUES(@ShopId,@InvId,@CustNm,@ProdNm,@ProdPrice,@Uom,@BDate)"
            Dim SqlCmd = New SqlCommand(SqlTxt, Conn)

            Dim InvId As String = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds
            SqlCmd.Parameters.AddWithValue("@ShopId", ShopId)
            SqlCmd.Parameters.AddWithValue("@InvId", InvId)
            SqlCmd.Parameters.AddWithValue("@CustNm", CustName)
            SqlCmd.Parameters.AddWithValue("@ProdNm", ProductName)
            SqlCmd.Parameters.AddWithValue("@ProdPrice", Price)
            SqlCmd.Parameters.AddWithValue("@Uom", UoM)
            SqlCmd.Parameters.AddWithValue("@BDate", BillDate)

            If SqlCmd.ExecuteNonQuery Then
                MessageBox.Show($"Invoice Id: {InvId} has been saved successfully", "Success")

                Dim renderer As New IronPdf.ChromePdfRenderer
                Dim pdf = renderer.RenderHtmlAsPdf("<h1>ABC Company Ltd</h1><hr style='width:100%; height:1px; color:#000000;'/><div style='margin-bottom:8px'><b>Shop Name:</b> " + ShopName + "</div><div><b>" + CustName + "</b> you have brought <b>" + ProductName + "</b> of <b>Rs." + Price + ".<b></div><div style='margin-bottom:15px;'>Date: " + BillDate + "<br/>Thank you, must come again.</div>")
                pdf.SaveAs("D:\Working\VB.NET\Customer_Invoice_Application\InvoicePDF\Inv_" + InvId + ".pdf")
            Else
                MessageBox.Show("Query did not execute to save into database!", "Error")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception")
        Finally
            Conn.Close()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            If RadioButton1.Checked Then
                RadioButton1.Checked = False
            End If
            If RadioButton2.Checked Then
                RadioButton2.Checked = False
            End If
            If RadioButton3.Checked Then
                RadioButton3.Checked = False
            End If

        End Try

    End Sub

    Private Sub Find_InvId(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        Dim SqlTxt As String = ""

        If e.KeyCode = Keys.Enter Then
            If TextBox4.Text = "" Then
                MessageBox.Show("Please enter a valid invoice id!", "Not Found")
                Exit Sub
            End If

            If TextBox4.Text.Trim().ToLower() = "all" Then
                SqlTxt = "SELECT * FROM ShopBillInvoice WHERE [ShopId]='" + ShopId + "'"
            End If

            If TextBox4.Text <> "" And TextBox4.Text <> "all" Then
                SqlTxt = "SELECT * FROM ShopBillInvoice WHERE [InvoiceId]='" + TextBox4.Text + "'"
            End If

            Dim Conn As SqlConnection = Nothing   'Equivalent to null in C#
            Try
                Conn = New SqlConnection(SqlConnString)
                Conn.Open()

                Dim DataAdp = New SqlDataAdapter(SqlTxt, Conn)
                Dim DataTable = New DataTable
                DataAdp.Fill(DataTable)

                DataGridView1.DataSource = DataTable
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Exception")
            Finally
                Conn.Close()
                TextBox4.Text = ""
            End Try
        End If
    End Sub

End Class