Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frm_login
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
    End Sub
    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            If txt_usuario.Text = "admin" And txt_senha.Text = "admin" Then
                sessao_usuario = "admin"
                MsgBox("Logado como administrador.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                frm_adm.Show()
                Me.Close()
                Exit Sub
            End If
            If txt_usuario.Text = "sup" And txt_senha.Text = "sup" Then
                sessao_usuario = "suporte"
                MsgBox("Logado como suporte.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                frm_suporte.Show()
                Me.Close()
                Exit Sub
            End If

            sql = "SELECT * FROM tb_usuario WHERE (usuario='" & txt_usuario.Text & "' or email='" & txt_usuario.Text & "') AND senha='" & txt_senha.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                If txt_usuario.Text = "" And txt_senha.Text = "" Then
                    MsgBox("Digite seu login e senha!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If
                sql = "SELECT status_conta FROM tb_usuario WHERE usuario='" & txt_usuario.Text & "' or email='" & txt_usuario.Text & "'"
                rs = db.Execute(sql)
                If (rs.Fields(0).Value <> "BLOQUEADA") Then
                    sessao_usuario = txt_usuario.Text
                    frm_menu.Show()
                    Me.Close()
                Else
                    MsgBox("Conta Bloqueada! Contate um administrador.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    txt_usuario.Clear()
                    txt_senha.Clear()
                    txt_usuario.Focus()
                End If

            Else
                MsgBox("Conta Inválida!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                txt_usuario.Clear()
                txt_senha.Clear()
                txt_usuario.Focus()
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub lbl_rsenha_Click(sender As Object, e As EventArgs) Handles lbl_rsenha.Click
        Call frm_senha.Show()
        Me.Close()
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Call frm_cadastro_contas.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub
End Class