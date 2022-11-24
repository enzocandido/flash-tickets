Public Class frm_clientes
    Private Sub frm_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        carregar_dados()
        carregar_tipo()
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            sql = "SELECT * FROM tb_usuario WHERE cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "update tb_usuario set data_nasc='" & txt_data.Value & "', " &
                          "nome='" & txt_nome.Text & "', cep='" & txt_cep.Text & "', " &
                          "endereco='" & txt_endereco.Text & "', bairro='" & txt_bairro.Text & "', " &
                          "uf='" & txt_uf.Text & "', fone='" & txt_fone.Text & "', " &
                          "email='" & txt_email.Text & "', foto='" & diretorio & "' where cpf='" & txt_cpf.Text & "'"

                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                sql = "INSERT INTO tb_usuario (cpf, data_nasc, nome, cep, endereco, bairro, cidade, uf, fone, email, foto) 
                           VALUES ('" & txt_cpf.Text & "', " &
                           "'" & txt_data.Value & "', '" & txt_nome.Text & "', " &
                           "'" & txt_cep.Text & "', '" & txt_endereco.Text & "', " &
                           "'" & txt_bairro.Text & "', '" & txt_cidade.Text & "', " &
                           "'" & txt_uf.Text & "', '" & txt_fone.Text & "', " &
                           "'" & txt_email.Text & "', '" & diretorio & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
            carregar_dados()
            txt_cpf.Clear()
            txt_data.Value = Now
            txt_nome.Clear()
            txt_cep.Clear()
            txt_endereco.Clear()
            txt_bairro.Clear()
            txt_cidade.Clear()
            txt_uf.Clear()
            txt_fone.Clear()
            txt_email.Clear()
            txt_cpf.Focus()
            img_foto.Load(Application.StartupPath & "\fotos\nova_foto.png")
        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub img_foto_Click_1(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto"
                .ShowDialog()
                diretorio = .SafeFileName
                img_foto.Load(diretorio_imagem & diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            sql = "SELECT id_conta,nome,cpf from tb_usuario where " & cmb_tipo.Text & " LIKE '" & txt_busca.Text & "%'"
            rs = db.Execute(sql)
            With dgv_dados
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Private Sub txt_cep_LostFocus(sender As Object, e As EventArgs) Handles txt_cep.LostFocus
        Try
            sql = "SELECT * FROM tb_cep WHERE cep='" & txt_cep.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_endereco.Text = rs.Fields(1).Value
                txt_bairro.Text = rs.Fields(3).Value
                txt_cidade.Text = rs.Fields(2).Value
                txt_uf.Text = rs.Fields(4).Value
            Else
                MsgBox("CEP não localizado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                If .CurrentRow.Cells(3).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(2).Value
                    sql = "SELECT * FROM tb_usuario WHERE cpf='" & aux_cpf & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        TabControl1.SelectTab(0) 'Explore aba dados pessoais
                        txt_cpf.Text = rs.Fields(14).Value
                        txt_data.Value = rs.Fields(5).Value
                        txt_nome.Text = rs.Fields(6).Value
                        txt_cep.Text = rs.Fields(7).Value
                        txt_endereco.Text = rs.Fields(8).Value
                        txt_bairro.Text = rs.Fields(9).Value
                        txt_cidade.Text = rs.Fields(10).Value
                        txt_uf.Text = rs.Fields(11).Value
                        txt_fone.Text = rs.Fields(12).Value
                        txt_email.Text = rs.Fields(2).Value
                        img_foto.Load(diretorio_imagem & rs.Fields(13).Value)
                    End If
                ElseIf .CurrentRow.Cells(5).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(2).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                 "CPF: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "DELETE * FROM tb_usuario where cpf='" & aux_cpf & "'"
                        rs = db.Execute(sql)
                        carregar_dados()
                    End If
                ElseIf .CurrentRow.Cells(4).Selected Then
                    Try
                        aux_cpf = .CurrentRow.Cells(2).Value
                        sql = "SELECT status_conta FROM tb_usuario WHERE cpf='" & aux_cpf & "'"
                        rs = db.Execute(sql)
                        status_conta = rs.Fields(0).Value
                        If status_conta = "ATIVA" Then
                            resp = MsgBox("Deseja realmente bloquear o acesso do CPF " & aux_cpf & "?" + vbNewLine &
                                "CPF: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                            If resp = MsgBoxResult.Yes Then
                                sql = "update tb_usuario set status_conta='BLOQUEADA' where cpf='" & aux_cpf & "'"
                                rs = db.Execute(sql)
                                carregar_dados()
                            End If
                        Else
                            resp = MsgBox("Deseja realmente desbloquear o acesso do CPF " & aux_cpf & "?" + vbNewLine &
                                "CPF: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                            If resp = MsgBoxResult.Yes Then
                                sql = "update tb_usuario set status_conta='ATIVA' where cpf='" & aux_cpf & "'"
                                rs = db.Execute(sql)
                                carregar_dados()
                            End If
                        End If
                    Catch ex As Exception
                        MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    End Try
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs)
        Try
            frm_menu.Show()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            frm_adm.Show()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub
End Class