Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nilai1 As Double
        nilai1 = TextBox2.Text

        If RadioButton5.Checked = True Then
            TextBox3.Text = (nilai1 * 22000) + 4200000
        End If
        If RadioButton6.Checked = True Then
            TextBox3.Text = (nilai1 * 25000) + 4200000
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pesanan() As String = {"Red Velvet", "Backforest", "Cupcake", "Ding Tea", "Matcha Coffee", "Terigu", "Margarin", "Dark Chocolate", "White Chocolate", "Telur"}
        MsgBox("Pesanan anda adalah : " & pesanan(Val(TextBox4.Text) - 1) & vbNewLine & "Jumlah pesanan : " & TextBox5.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub
End Class
