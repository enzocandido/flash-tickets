Imports System.Runtime.ConstrainedExecution

Public Class frm_cadastro_contas
    Private Sub frm_cadastro_contas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
    End Sub

    Private Sub chk_visual_CheckedChanged(sender As Object, e As EventArgs) Handles chk_visual.CheckedChanged
        Try
            If chk_visual.Checked = True Then
                txt_senha.PasswordChar = ""
                txt_rsenha.PasswordChar = ""
            Else
                txt_senha.PasswordChar = "•"
                txt_rsenha.PasswordChar = "•"
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            frm_login.Show()
            Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_senha_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_senha.MouseClick
        txt_senha.PasswordChar = "•"
        txt_rsenha.PasswordChar = "•"
    End Sub

    Private Sub btn_criar_Click_1(sender As Object, e As EventArgs) Handles btn_criar.Click
        Try
            If txt_usuario.Text = "" Or
                    txt_data.Text = "" Or
                    txt_endereco.Text = "" Or
                    txt_nome.Text = "" Or
                    txt_cep.Text = "" Or
                    txt_cidade.Text = "" Or
                    txt_bairro.Text = "" Or
                    txt_uf.Text = "" Or
                    txt_email.Text = "" Or
                    txt_senha.Text = "" Or
                    txt_cpf.Text = "" Or
                    txt_rsenha.Text = "" Then
                MsgBox("Preencha todos os campos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            ElseIf txt_senha.Text <> txt_rsenha.Text Then
                MsgBox("Senhas não conferem", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            Else
                sql = "SELECT * FROM tb_usuario WHERE usuario='" & txt_usuario.Text & "' or email='" & txt_email.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    MsgBox("Usuário ou email já existe!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Else
                    sql = $"INSERT INTO tb_usuario (cpf, usuario, email, senha, status_conta, data_nasc, nome, cep, endereco, bairro, cidade, uf, fone, foto) VALUES
                        ('{txt_cpf.Text}', '{txt_usuario.Text}', '{txt_email.Text}', '{txt_senha.Text}',
                        'ATIVA', '{txt_data.Value}', '{txt_nome.Text}', '{txt_cep.Text}', '{txt_endereco.Text}',
                        '{txt_bairro.Text}', '{txt_cidade.Text}', '{txt_uf.Text}', '{txt_fone.Text}', '{diretorio}')"
                    rs = db.Execute(sql)
                    MsgBox("Conta criada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If
                txt_usuario.Clear()
                txt_email.Clear()
                txt_senha.Clear()
                txt_rsenha.Clear()
                txt_cpf.Clear()
                txt_cep.Clear()
                txt_cidade.Clear()
                txt_bairro.Clear()
                txt_uf.Clear()
                txt_fone.Clear()
                txt_endereco.Clear()
                txt_usuario.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End Try
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs)
        Try
            frm_login.Show()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            frm_login.Show()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_cep_LostFocus(sender As Object, e As EventArgs) Handles txt_cep.LostFocus
        If txt_cep.Text.Length >= 7 Then
            primeira_parte_cep = txt_cep.Text.Substring(0, 5)
            segunda_parte_cep = txt_cep.Text.Substring(5, 3)
        End If
        sql = $"SELECT * FROM tb_cep where cep='{primeira_parte_cep}-{segunda_parte_cep}'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            txt_endereco.Text = rs.Fields(1).Value
            txt_bairro.Text = rs.Fields(3).Value
            txt_cidade.Text = rs.Fields(2).Value
            txt_uf.Text = rs.Fields(4).Value
        End If
    End Sub

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto"
                .InitialDirectory = diretorio_imagem
                .ShowDialog()
                diretorio = .SafeFileName
                img_foto.Load(diretorio_imagem & diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

End Class