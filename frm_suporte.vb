Public Class frm_suporte
    Private Sub frm_suporte_Load(sender As Object, e As EventArgs) Handles Me.Load
        conecta_banco()
        sql = $"SELECT * FROM tb_suporte"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            While rs.EOF = False
                drop_id_mensagem.Items.Add(rs.Fields(0).Value)
                rs.MoveNext()
            End While
        Else
            drop_id_mensagem.Items.Add("Sem mensagens.")
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Try
            frm_menu.Show()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub drop_id_mensagem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drop_id_mensagem.SelectedIndexChanged
        sql = $"SELECT * FROM tb_suporte WHERE id_suporte = {drop_id_mensagem.SelectedItem}"
        rs = db.Execute(sql)
        txt_usuario.Text = rs.Fields(1).Value
        txt_email.Text = rs.Fields(2).Value
        txt_mensagem.Text = rs.Fields(3).Value
        txt_data.Text = rs.Fields(4).Value
    End Sub
End Class