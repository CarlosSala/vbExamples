Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = True
        TextBox1.Text = 0
        TextBox2.Text = 0
        TextBox3.Text = 0
        TextBox4.Text = 0
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Button1.Visible = False

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            PictureBox1.Visible = True
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            TextBox1.Text = 300
            TextBox3.Text = TextBox1.Text * TextBox2.Text * 0.1
            TextBox4.Text = (TextBox1.Text * TextBox2.Text) + TextBox3.Text
            TextBox6.Text = 0
            TextBox5.Text = 0
            ComboBox2.Text = ""

        ElseIf ComboBox1.SelectedIndex = 1 Then
            PictureBox1.Visible = False
            PictureBox2.Visible = True
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            TextBox1.Text = 380
            TextBox3.Text = TextBox1.Text * TextBox2.Text * 0.1
            TextBox4.Text = (TextBox1.Text * TextBox2.Text) + TextBox3.Text
            TextBox6.Text = 0
            TextBox5.Text = 0
            ComboBox2.Text = ""

        ElseIf ComboBox1.SelectedIndex = 2 Then
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = True
            PictureBox4.Visible = False
            TextBox1.Text = 250
            TextBox3.Text = TextBox1.Text * TextBox2.Text * 0.1
            TextBox4.Text = (TextBox1.Text * TextBox2.Text) + TextBox3.Text
            TextBox6.Text = 0
            TextBox5.Text = 0
            ComboBox2.Text = ""

        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim precio, cantidad As Double

        precio = TextBox1.Text
        cantidad = TextBox2.Text

        TextBox3.Text = precio * cantidad * 0.1
        TextBox4.Text = (precio * cantidad) + TextBox3.Text

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedIndex = 0 Then
            TextBox5.Text = TextBox4.Text * 0.05
            Button1.Visible = True
        ElseIf ComboBox2.SelectedIndex = 1 Then
            TextBox5.Text = TextBox4.Text * 0.1
            Button1.Visible = True
        ElseIf ComboBox2.SelectedIndex = 2 Then
            TextBox5.Text = TextBox4.Text * 0.15
            Button1.Visible = True
        End If


        TextBox6.Text = TextBox4.Text - TextBox5.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim total As Double
        total = TextBox6.Text

        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = True
        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label10.Text = total

        Select Case MsgBox("Usted debe pagar : $ " & total, MsgBoxStyle.YesNo, "¿Quiere hacer otra compra?")

            Case MsgBoxResult.Yes
                TextBox1.Text = 0
                TextBox2.Text = 0
                TextBox3.Text = 0
                TextBox4.Text = 0
                TextBox5.Text = 0
                TextBox6.Text = 0
                ComboBox1.Text = ""
                ComboBox2.Text = ""
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                Button1.Visible = False
                Label9.Visible = False
                Label10.Visible = False
                Label11.Visible = False

            Case MsgBoxResult.No
                Me.Close()

        End Select
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class
