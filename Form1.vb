Public Class Form1
    Public t, id As Integer
    Public r2 As Integer
    Public r3 As Integer
    Public re As Integer
    Public r4 As Integer
    Public r, d, w, g, p, r1, d1, w1, g1, p1 As Integer
    Public m, c, pe, sun, po, m1, c1, pe1, sun1, po1 As Integer
    Public pot, col, tom, lad, oni, pot1, col1, tom1, lad1, oni1 As Integer
    Public sp, mi, co, sl, pep, sp1, mi1, co1, sl1, pep1 As Integer
    Public cname, con As String



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button4.Enabled = False
        listBox1.Items.Add("Prize list")
        listBox1.Items.Add("")
        listBox1.Items.Add("GST................14%")
        listBox1.Items.Add("")
        listBox1.Items.Add("Grocery Products")

        listBox1.Items.Add("Rice................................Rs. 42")
        listBox1.Items.Add("Dal..................................Rs. 90")
        listBox1.Items.Add("Wheat.............................Rs. 36")
        listBox1.Items.Add("Grain...............................Rs. 60")
        listBox1.Items.Add("Peanut............................Rs. 80")
        listBox1.Items.Add("")
        listBox1.Items.Add("Oil Products")
        listBox1.Items.Add("Musterd Oil....................Rs. 100")
        listBox1.Items.Add("Coconut Oil.....................Rs. 86")
        listBox1.Items.Add("Peanut Oil.......................Rs. 58")
        listBox1.Items.Add("Sunflower Oil.................Rs. 110")
        listBox1.Items.Add("Pomolin Oil......................Rs. 75")
        listBox1.Items.Add("")
        listBox1.Items.Add("Vagetable")
        listBox1.Items.Add("Potato.............................Rs. 20")
        listBox1.Items.Add("Tomato...........................Rs. 60")
        listBox1.Items.Add("Coliflower........................Rs. 40")
        listBox1.Items.Add("Lady Finger.....................Rs. 50")
        listBox1.Items.Add("Onion..............................Rs. 30")
        listBox1.Items.Add("")
        listBox1.Items.Add("Cold Drinks")
        listBox1.Items.Add("Sprit................................Rs. 55")
        listBox1.Items.Add("Mirinda............................Rs. 50")
        listBox1.Items.Add("Cocacola........................Rs. 60")
        listBox1.Items.Add("Slice................................Rs. 64")
        listBox1.Items.Add("Pepsi..............................Rs. 58")

    End Sub

    Public Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Button4.Enabled = True
        'grocery product'
        r = 42
        d = 90
        w = 36
        g = 60
        p = 80
        id = Val(textBox1.Text)
        cname = textBox2.Text
        con = textBox3.Text
        r1 = Val(textBox3.Text)
        d1 = Val(textBox4.Text)
        w1 = Val(textBox5.Text)
        g1 = Val(textBox6.Text)
        p1 = Val(textBox7.Text)
        t = r * r1 + d * d1 + w * w1 + g * g1 + p * p1
        textBox18.Text = +t



        'oil product'
        m = 100
        c = 86
        pe = 58
        sun = 110
        po = 75
        m1 = Val(textBox8.Text)
        c1 = Val(textBox9.Text)
        pe1 = Val(textBox10.Text)
        sun1 = Val(textBox11.Text)
        po1 = Val(textBox12.Text)
        r2 = m * m1 + c * c1 + pe * pe1 + sun * sun1 + po * po1
        textBox19.Text = +r2


        'vegetable'
        pot = 20
        tom = 60
        col = 40
        lad = 50
        oni = 30
        pot1 = Val(textBox13.Text)
        tom1 = Val(textBox14.Text)
        col1 = Val(textBox15.Text)
        lad1 = Val(textBox16.Text)
        oni1 = Val(textBox17.Text)
        r3 = pot * pot1 + tom * tom1 + col * col1 + lad * lad1 + oni * oni1
        textBox20.Text = +r3


        'cold drink'
        sp = 55
        mi = 50
        co = 60
        sl = 64
        pep = 58
        sp1 = Val(textBox23.Text)
        mi1 = Val(textBox24.Text)
        co1 = Val(textBox25.Text)
        sl1 = Val(textBox26.Text)
        pep1 = Val(textBox27.Text)
        r4 = sp * sp1 + mi * mi1 + co * co1 + sl * sl1 + pep * pep1
        textBox21.Text = +r4


        Dim j, sb, gst, ta As Integer
        j = t + r2 + r3 + r4
        TextBox31.Text = +j
        TextBox32.Text = (j * 14 / 100)
        sb = Val(TextBox31.Text)
        gst = Val(TextBox32.Text)
        ta = sb + gst
        TextBox33.Text = +ta

        DataGridView1.ColumnCount = 10
        DataGridView1.Columns(0).Name = "Cust Id"
        DataGridView1.Columns(1).Name = "Name"
        DataGridView1.Columns(2).Name = "Contact"
        DataGridView1.Columns(3).Name = "Total Cost of Grosarys"
        DataGridView1.Columns(4).Name = "Total Cost of Oils"
        DataGridView1.Columns(5).Name = "Total Cost of Vegetables"
        DataGridView1.Columns(6).Name = "Total Cost of Cold Drink"
        DataGridView1.Columns(7).Name = "Sub Total"
        DataGridView1.Columns(8).Name = "Cgst & Sgst"
        DataGridView1.Columns(9).Name = "Total Amount"

        Dim row As String() = New String() {textBox1.Text, textBox2.Text, textBox30.Text, textBox18.Text, textBox19.Text, textBox20.Text, textBox21.Text, TextBox31.Text, TextBox32.Text, TextBox33.Text}

        DataGridView1.Rows.Add(row)
        DataGridView1.Update()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        id = textBox1.Text
        name = textBox2.Text
        con = textBox30.Text
        payment.Show()
        Me.Hide()

    End Sub

    Private Sub listBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBox1.SelectedIndexChanged

    End Sub

    Private Sub button3_Click(sender As Object, e As System.EventArgs) Handles button3.Click
        Application.Exit()


    End Sub

    Private Sub textBox2_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox2.KeyPress

        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And
            Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
            MessageBox.Show("You can only input Character!")
        End If

    End Sub

    Private Sub textBox1_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox1.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        textBox1.Text = ""
        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
        textBox5.Text = ""
        textBox6.Text = ""
        textBox7.Text = ""
        textBox8.Text = ""
        textBox9.Text = ""
        textBox10.Text = ""
        textBox11.Text = ""
        textBox12.Text = ""
        textBox13.Text = ""
        textBox14.Text = ""
        textBox15.Text = ""
        textBox16.Text = ""
        textBox17.Text = ""
        textBox18.Text = ""
        textBox19.Text = ""
        textBox20.Text = ""
        textBox21.Text = ""
        textBox22.Text = ""
        textBox23.Text = ""
        textBox24.Text = ""
        textBox25.Text = ""
        textBox26.Text = ""
        textBox27.Text = ""
        textBox28.Text = ""
        textBox29.Text = ""
        textBox30.Text = ""
        TextBox31.Text = ""
        TextBox32.Text = ""
        TextBox33.Text = ""

        DataGridView1.Rows.Clear()
    End Sub

    Private Sub textBox30_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox30.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If

    End Sub

    Private Sub textBox3_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox3.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub textBox4_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox4.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub textBox5_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox5.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub textBox6_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox6.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub textBox7_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox7.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub textBox8_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox8.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub textBox9_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox9.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub textBox10_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox10.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub textBox11_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox11.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub textBox12_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox12.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub textBox13_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox13.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub textBox14_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox14.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub textBox15_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox15.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub textBox16_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox16.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub textBox17_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox17.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub textBox18_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox18.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub textBox19_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox19.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub textBox20_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox20.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub textBox21_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox21.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub textBox23_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox23.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub textBox24_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox24.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub textBox25_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox25.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub textBox26_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox26.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub

    Private Sub textBox27_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textBox27.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input number!")
        End If
    End Sub


End Class
