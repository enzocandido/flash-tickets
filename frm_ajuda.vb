Public Class frm_ajuda
    Private Sub frm_ajuda_Load(sender As Object, e As EventArgs) Handles Me.Load
        conecta_banco()

    End Sub

    Private Sub btn_enviar_Click(sender As Object, e As EventArgs) Handles btn_enviar.Click
        Try
            sql = $"INSERT INTO tb_suporte (usuario_suporte, email_usuario, problema, data_suporte) VALUES ('{sessao_usuario}', '{txt_email.Text}', '{txt_problema.Text}', '{data_atual}')"
            rs = db.Execute(sql)
            MsgBox("Mensagem enviada com sucesso, obrigado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro! contacte um administrador.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_menu.Show()
        Me.Close()
    End Sub
End Class