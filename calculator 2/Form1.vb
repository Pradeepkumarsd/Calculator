Public Class Calculator
    Private Sub ButtonClick(sender As Object, e As EventArgs) Handles Btn1.Click, Btn2.Click, Btn3.Click, Btn4.Click, Btn5.Click, Btn6.Click, Btn7.Click, Btn8.Click, Btn9.Click, Btn0.Click, BtnA.Click, BtnS.Click, BtnC.Click, BtnM.Click, BtnE.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "Btn1" Then
            TextBox1.Text = TextBox1.Text + "1"
        End If
        If button.Name = "Btn2" Then
            TextBox1.Text = TextBox1.Text + "2"
        End If
        If button.Name = "Btn3" Then
            TextBox1.Text = TextBox1.Text + "3"
        End If
        If button.Name = "Btn4" Then
            TextBox1.Text = TextBox1.Text + "4"
        End If
        If button.Name = "Btn5" Then
            TextBox1.Text = TextBox1.Text + "5"
        End If
        If button.Name = "Btn6" Then
            TextBox1.Text = TextBox1.Text + "6"
        End If
        If button.Name = "Btn7" Then
            TextBox1.Text = TextBox1.Text + "7"
        End If
        If button.Name = "Btn8" Then
            TextBox1.Text = TextBox1.Text + "8"
        End If
        If button.Name = "Btn9" Then
            TextBox1.Text = TextBox1.Text + "9"
        End If
        If button.Name = "Btn0" Then
            TextBox1.Text = TextBox1.Text + "0"
        End If
        If button.Name = "BtnA" Then
            TextBox1.Text = TextBox1.Text + "+"
        End If
        If button.Name = "BtnS" Then
            TextBox1.Text = TextBox1.Text + "-"
        End If
        If button.Name = "BtnDec" Then
            TextBox1.Text = TextBox1.Text + "."
        End If
        If button.Name = "BtnM" Then
            TextBox1.Text = TextBox1.Text + "*"
        End If
        If button.Name = "BtnE" Then
            Dim str As String = TextBox1.Text
            Dim Result = New Calculation
            TextBox1.Text = Result.WriteGetResult(str)
        End If
        If button.Name = "BtnC" Then
            TextBox1.Text = ""
        End If

    End Sub

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnM.Click

    End Sub
End Class
