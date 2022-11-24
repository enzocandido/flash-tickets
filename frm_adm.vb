Public Class frm_adm

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Call frm_clientes.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Try
            resp = MsgBox("Deseja realmente sair da conta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
            If resp = MsgBoxResult.Yes Then
                frm_login.Show()
                Me.Close()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        frm_suporte.ShowDialog()
        Me.Close()
    End Sub
End Class