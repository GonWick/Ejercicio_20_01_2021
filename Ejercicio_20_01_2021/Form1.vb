Public Class Form1

    Dim Turismos, Todoterrenos As Integer
    Dim Capturismos, Captodot As Single
    Dim Necesidadescom As Single

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Turismos = Val(TextBox1.Text)
        Todoterrenos = Val(TextBox2.Text)
        Capturismos = Val(TextBox3.Text)
        Captodot = Val(TextBox4.Text)
        Necesidadescom = (Turismos * Capturismos) + (Todoterrenos * Captodot)

        LabelResultado.ForeColor = Color.Black
        LabelResultado.Font = New Font("Arial", 8, FontStyle.Bold)
        LabelResultado.Text = "Las necesidades totales de combustible son de " & CInt(TextBox1.Text * TextBox3.Text) + CInt(TextBox2.Text * TextBox4.Text) & " litros"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Cálculo de Necesidades de Combustible "
    End Sub
End Class
