Imports System.Data.SqlClient
Public Class payment
    Dim con As New SqlConnection("Server=ANUPAM\SQLEXPRESS; Database=Billing; Integrated Security=true")
    Public Sub connection()


    End Sub

    Private Sub payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim p As Object
        Dim obj As New Form1()
        Dim edate As Date = CDate("15.05.2019")
        TextBox3.Text = Form1.r2
        TextBox1.Text = Form1.t
        TextBox5.Text = Form1.r3
        TextBox4.Text = Form1.r4


        TextBox1.Text = Form1.TextBox33.Text
        TextBox7.Text = Form1.TextBox33.Text
        recipt.Items.Add("*********Welcome to BRAND MALL*********")
        recipt.Items.Add("Date" & vbTab & vbTab + edate)
        recipt.Items.Add("Customer Id: " & Form1.id)
        recipt.Items.Add("name of customer :" & vbTab & Form1.name)
        recipt.Items.Add("")
        recipt.Items.Add("Contect no" & Form1.con)
        recipt.Items.Add("Total Cost of Products")

        recipt.Items.Add("")

        recipt.Items.Add("Total Cost of Grocerys" & vbTab & Form1.t)

        recipt.Items.Add("Total Cost of Oil" & vbTab & vbTab & Form1.r2)

        recipt.Items.Add("Total Cost of Vegetables" & vbTab & Form1.r3)

        recipt.Items.Add("Total Cost of Cold Drinks" & vbTab & Form1.r4)
        recipt.Items.Add("")

        recipt.Items.Add("Sub Total" & vbTab & vbTab + Form1.TextBox31.Text)

        recipt.Items.Add("CGST and SGST" & vbTab & vbTab + Form1.TextBox32.Text)

        recipt.Items.Add("Total Amount" & vbTab & vbTab + Form1.TextBox33.Text)
        recipt.Items.Add("")
        recipt.Items.Add("")
        recipt.Items.Add("*******THANK YOU***VISIT AGAIN********")
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim atn As Integer = TabControl1.SelectedTab.Tag

        If TabControl1.SelectedTab Is TabPage1 Then
            MsgBox("Amount Paid Successfully of Rs" + TextBox1.Text)

        End If
        If TabControl1.SelectedTab Is TabPage2 Then
            MsgBox("Amount Paid Successfully of Rs" + TextBox7.Text)

        End If
        Dim Cid As Integer
        Dim custName As String
        Dim amount As Decimal
        Dim Phno As String
        Cid = Form1.id
        custName = Form1.cname
        amount = TextBox1.Text
        Phno = Form1.con
        Dim query As String = ("insert into Customer(CustId,Name,TotalAmount,Ph) values(" & Cid & ",'" & custName & "'," & amount & ",'" & Phno & "')")
        Dim cmd As New SqlCommand(query, con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        TextBox1.Text = ""

        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        TextBox3.PasswordChar = "*"
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        TextBox4.PasswordChar = "*"
    End Sub
End Class