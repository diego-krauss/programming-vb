Public Class Form1
    Dim operador As String
    Dim num1 As Double
    Dim num2 As Double

    Private Sub TxtPainel_TextChanged(sender As Object, e As EventArgs) Handles txtPainel.TextChanged

    End Sub

    Private Sub BtnAdicao_Click(sender As Object, e As EventArgs) Handles btnAdicao.Click
        If txtPainel.Text = "" Then
            MessageBox.Show("Ação inválida, insira um número!")
        Else
            num1 = txtPainel.Text
            operador = "+"
            txtPainel.Text = ""
        End If
    End Sub
    Private Sub BtnSubtrair_Click(sender As Object, e As EventArgs) Handles btnSubtrair.Click
        If txtPainel.Text = "" Then
            MessageBox.Show("Ação inválida, insira um número!")
        Else
            num1 = txtPainel.Text
            operador = "-"
            txtPainel.Text = ""
        End If
    End Sub
    Private Sub BtnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        If txtPainel.Text = "" Then
            MessageBox.Show("Ação inválida, insira um número!")
        Else
            num1 = txtPainel.Text
            operador = "x"
            txtPainel.Text = ""
        End If
    End Sub
    Private Sub BtnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        If txtPainel.Text = "" Then
            MessageBox.Show("Ação inválida, insira um número!")
        Else
            num1 = txtPainel.Text
            operador = "/"
            txtPainel.Text = ""
        End If
    End Sub
    Private Sub BtnPorcentagem_Click(sender As Object, e As EventArgs) Handles btnPorcentagem.Click
        If txtPainel.Text = "" Then
            MessageBox.Show("Ação inválida, insira um número!")
        Else
            num1 = txtPainel.Text
            operador = "%"
            txtPainel.Text = ""
        End If
    End Sub

    Private Sub BtnResultado_Click(sender As Object, e As EventArgs) Handles btnResultado.Click
        If txtPainel.Text = "" Then
            MessageBox.Show("Ação inválida, insira um número!")
        Else
            num2 = txtPainel.Text
            If operador = "x" Then
                txtPainel.Text = num1 * num2
            End If
            If operador = "+" Then
                txtPainel.Text = num1 + num2
            End If
            If operador = "-" Then
                txtPainel.Text = num1 - num2
            End If
            If operador = "/" Then
                txtPainel.Text = num1 / num2
            End If
            If operador = "%" Then
                txtPainel.Text = (num1 / 100) * num2
            End If
        End If
    End Sub
    Private Sub BtnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        txtPainel.Text += "0"
    End Sub
    Private Sub BtnUm_Click(sender As Object, e As EventArgs) Handles btnUm.Click
        txtPainel.Text += "1"
    End Sub
    Private Sub BtnDois_Click(sender As Object, e As EventArgs) Handles btnDois.Click
        txtPainel.Text += "2"
    End Sub
    Private Sub BtnTres_Click(sender As Object, e As EventArgs) Handles btnTres.Click
        txtPainel.Text += "3"
    End Sub
    Private Sub BtnQuatro_Click(sender As Object, e As EventArgs) Handles btnQuatro.Click
        txtPainel.Text += "4"
    End Sub
    Private Sub BtnCinco_Click(sender As Object, e As EventArgs) Handles btnCinco.Click
        txtPainel.Text += "5"
    End Sub
    Private Sub BtnSeis_Click(sender As Object, e As EventArgs) Handles btnSeis.Click
        txtPainel.Text += "6"
    End Sub
    Private Sub BtnSete_Click(sender As Object, e As EventArgs) Handles btnSete.Click
        txtPainel.Text += "7"
    End Sub
    Private Sub BtnOito_Click(sender As Object, e As EventArgs) Handles btnOito.Click
        txtPainel.Text += "8"
    End Sub
    Private Sub BtnNove_Click(sender As Object, e As EventArgs) Handles btnNove.Click
        txtPainel.Text += "9"
    End Sub
    Private Sub BtnVirgula_Click(sender As Object, e As EventArgs) Handles btnVirgula.Click
        txtPainel.Text += ","
    End Sub
    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtPainel.Text = ""
    End Sub
    Private Sub BtnBackspace_Click(sender As Object, e As EventArgs) Handles btnBackspace.Click
        txtPainel.Text = txtPainel.Text.Substring(0, txtPainel.Text.Length - 1)
    End Sub


End Class
