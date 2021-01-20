Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LabelResultado.Text = "Las necesidades totales de combustible son de " & CInt(TextBox1.Text * TextBox3.Text) + CInt(TextBox2.Text * TextBox4.Text) & " litros"
    End Sub
End Class
