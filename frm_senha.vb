Public Class frm_senha
    Private Sub btn_voltar_Click(sender As Object, e As EventArgs)
        Try
            frm_login.Show()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chk_visual_CheckedChanged(sender As Object, e As EventArgs) Handles chk_visual.CheckedChanged
        Try
            If chk_visual.Checked = True Then
                txt_rsenha.PasswordChar = ""
                txt_rsenha2.PasswordChar = ""
            Else
                txt_rsenha.PasswordChar = "•"
                txt_rsenha2.PasswordChar = "•"
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub txt_rsenha_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_rsenha.MouseClick
        txt_rsenha.PasswordChar = "•"
        txt_rsenha2.PasswordChar = "•"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            frm_login.Show()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub btn_redefinir_Click_1(sender As Object, e As EventArgs) Handles btn_redefinir.Click
        If txt_cpf.Text <> "" And txt_email.Text <> "" Then
            If txt_rsenha.Text <> "" And txt_rsenha2.Text <> "" Then
                sql = "SELECT * from tb_usuario where cpf='" & txt_cpf.Text & "' and email ='" & txt_email.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    sql = "UPDATE tb_usuario SET senha='" & txt_rsenha2.Text & "' WHERE cpf='" & txt_cpf.Text & "'"
                    rs = db.Execute(sql)
                    MsgBox("deu bom!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    MsgBox("Conta Inválida!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    txt_cpf.Clear()
                    txt_email.Clear()
                    txt_rsenha.Clear()
                    txt_rsenha2.Clear()
                    txt_cpf.Focus()
                End If
            End If
        End If
        Exit Sub
    End Sub

End Class
