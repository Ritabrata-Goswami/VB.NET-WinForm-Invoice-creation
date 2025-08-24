<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        Panel2 = New Panel()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Button2 = New Button()
        Label11 = New Label()
        DateTimePicker1 = New DateTimePicker()
        TextBox3 = New TextBox()
        Label10 = New Label()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        Label9 = New Label()
        RadioButton1 = New RadioButton()
        TextBox2 = New TextBox()
        Label8 = New Label()
        TextBox1 = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        TabPage2 = New TabPage()
        DataGridView1 = New DataGridView()
        TextBox4 = New TextBox()
        Label13 = New Label()
        Label12 = New Label()
        Panel2.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(356, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(337, 31)
        Label1.TabIndex = 0
        Label1.Text = "Welcome to billing dashboard"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(120, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 23)
        Label2.TabIndex = 1
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(91, 62)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 23)
        Label3.TabIndex = 2
        Label3.Text = "Label3"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(4, 37)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 24)
        Label4.TabIndex = 3
        Label4.Text = "Shop Name: "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(5, 62)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 24)
        Label5.TabIndex = 4
        Label5.Text = "Shop Id: "
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.FromArgb(CByte(230), CByte(0), CByte(0))
        Button1.Cursor = Cursors.Hand
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(968, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(81, 31)
        Button1.TabIndex = 5
        Button1.Text = "Logout"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label3)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1052, 96)
        Panel2.TabIndex = 9
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 96)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1052, 518)
        TabControl1.TabIndex = 10
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Gainsboro
        TabPage1.Controls.Add(Button2)
        TabPage1.Controls.Add(Label11)
        TabPage1.Controls.Add(DateTimePicker1)
        TabPage1.Controls.Add(TextBox3)
        TabPage1.Controls.Add(Label10)
        TabPage1.Controls.Add(RadioButton3)
        TabPage1.Controls.Add(RadioButton2)
        TabPage1.Controls.Add(Label9)
        TabPage1.Controls.Add(RadioButton1)
        TabPage1.Controls.Add(TextBox2)
        TabPage1.Controls.Add(Label8)
        TabPage1.Controls.Add(TextBox1)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(Label6)
        TabPage1.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1044, 485)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Create Invoice"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(26), CByte(163), CByte(255))
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonFace
        Button2.Location = New Point(13, 312)
        Button2.Name = "Button2"
        Button2.Size = New Size(185, 43)
        Button2.TabIndex = 13
        Button2.Text = "Click to Invoice"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(13, 232)
        Label11.Name = "Label11"
        Label11.Size = New Size(94, 22)
        Label11.TabIndex = 12
        Label11.Text = "Billing Date:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(114, 228)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 11
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(71, 143)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Enter Price..."
        TextBox3.Size = New Size(270, 27)
        TextBox3.TabIndex = 10
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(12, 144)
        Label10.Name = "Label10"
        Label10.Size = New Size(50, 22)
        Label10.TabIndex = 9
        Label10.Text = "Price:"
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton3.Location = New Point(302, 189)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(62, 23)
        RadioButton3.TabIndex = 8
        RadioButton3.TabStop = True
        RadioButton3.Text = "Liter"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton2.Location = New Point(229, 189)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(70, 23)
        RadioButton2.TabIndex = 7
        RadioButton2.TabStop = True
        RadioButton2.Text = "Gram"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(13, 189)
        Label9.Name = "Label9"
        Label9.Size = New Size(159, 22)
        Label9.TabIndex = 6
        Label9.Text = "Unit of Measurement:"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton1.Location = New Point(176, 189)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(50, 23)
        RadioButton1.TabIndex = 5
        RadioButton1.TabStop = True
        RadioButton1.Text = "Kg"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(131, 102)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Product Name...."
        TextBox2.Size = New Size(421, 27)
        TextBox2.TabIndex = 4
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(12, 103)
        Label8.Name = "Label8"
        Label8.Size = New Size(112, 22)
        Label8.TabIndex = 3
        Label8.Text = "Product Name:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(131, 67)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Customer Name..."
        TextBox1.Size = New Size(421, 27)
        TextBox1.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(10, 70)
        Label7.Name = "Label7"
        Label7.Size = New Size(124, 22)
        Label7.TabIndex = 1
        Label7.Text = "Customer Name:"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(403, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(162, 27)
        Label6.TabIndex = 0
        Label6.Text = "Generate Invoice"
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.FromArgb(CByte(128), CByte(204), CByte(255))
        TabPage2.Controls.Add(DataGridView1)
        TabPage2.Controls.Add(TextBox4)
        TabPage2.Controls.Add(Label13)
        TabPage2.Controls.Add(Label12)
        TabPage2.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1044, 485)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Invoice History"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(3, 105)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1082, 377)
        DataGridView1.TabIndex = 3
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(151, 59)
        TextBox4.Name = "TextBox4"
        TextBox4.PlaceholderText = "Enter Invoice Id..."
        TextBox4.Size = New Size(376, 28)
        TextBox4.TabIndex = 2
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(11, 60)
        Label13.Name = "Label13"
        Label13.Size = New Size(134, 22)
        Label13.TabIndex = 1
        Label13.Text = "Search Invoice Id:"
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top
        Label12.AutoSize = True
        Label12.Font = New Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = SystemColors.ControlText
        Label12.Location = New Point(437, 12)
        Label12.Name = "Label12"
        Label12.Size = New Size(146, 27)
        Label12.TabIndex = 0
        Label12.Text = "Invoice History"
        Label12.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1052, 614)
        Controls.Add(TabControl1)
        Controls.Add(Panel2)
        Name = "Form2"
        Text = "Billing Application"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
