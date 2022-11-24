Imports System.Net.Mime.MediaTypeNames

Public Class frm_explorar
    Private Sub frm_explorar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        btn_jogo_anterior.Visible = False
        Try
            sql = "SELECT COUNT(id) FROM tb_jogos"
            rs = db.Execute(sql)
            qntd_jogos = rs.Fields(0).Value
            sql = $"SELECT * from tb_jogos WHERE id={id_jogos}"
            rs = db.Execute(sql)
            time_casa = rs.Fields(2).Value
            time_visitante = rs.Fields(3).Value
            If rs.EOF = False Then
                lbl_time_casa.Text = time_casa
                lbl_time_visitante.Text = time_visitante
                lbl_nome_campeonato.Text = rs.Fields(1).Value
                data_jogos = DateTime.Parse(rs.Fields(4).Value)
                horario_jogos = DateTime.Parse(rs.Fields(5).Value)
                lbl_estadio.Text = rs.Fields(6).Value
                If horario_jogos.Minute = "0" Then
                    lbl_data.Text = $"Data: {data_jogos.Day}/{data_jogos.Month} | Horario: {horario_jogos.Hour}:{horario_jogos.Minute}0"
                Else
                    lbl_data.Text = $"Data: {data_jogos.Day}/{data_jogos.Month} | Horario: {horario_jogos.Hour}:{horario_jogos.Minute}"
                End If
                sql = $"SELECT * from tb_times WHERE nome_time = '{time_casa}'"
                rs = db.Execute(sql)
                img_time_casa.Load(diretorio_logo_time & rs.Fields(2).Value)
                sql = $"SELECT * from tb_times WHERE nome_time = '{time_visitante}'"
                rs = db.Execute(sql)
                img_time_visitante.Load(diretorio_logo_time & rs.Fields(2).Value)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_prox_jogo_Click(sender As Object, e As EventArgs) Handles btn_prox_jogo.Click
        If id_jogos = 2 Then
            btn_jogo_anterior.Visible = True
        ElseIf id_jogos = qntd_jogos - 1 Then
            btn_prox_jogo.Visible = False
        ElseIf id_jogos < qntd_jogos Then
            btn_prox_jogo.Visible = True
        End If
        If id_jogos < qntd_jogos Then
            btn_jogo_anterior.Visible = True
            id_jogos = id_jogos + 1
            sql = $"SELECT * from tb_jogos WHERE id={id_jogos}"
            rs = db.Execute(sql)
            time_casa = rs.Fields(2).Value
            time_visitante = rs.Fields(3).Value
            If rs.EOF = False Then
                lbl_time_casa.Text = time_casa
                lbl_time_visitante.Text = time_visitante
                lbl_nome_campeonato.Text = rs.Fields(1).Value
                data_jogos = DateTime.Parse(rs.Fields(4).Value)
                horario_jogos = DateTime.Parse(rs.Fields(5).Value)
                lbl_estadio.Text = rs.Fields(6).Value
                If horario_jogos.Minute = "0" Then
                    lbl_data.Text = $"Data: {data_jogos.Day}/{data_jogos.Month} | Horario: {horario_jogos.Hour}:{horario_jogos.Minute}0"
                Else
                    lbl_data.Text = $"Data: {data_jogos.Day}/{data_jogos.Month} | Horario: {horario_jogos.Hour}:{horario_jogos.Minute}"
                End If
                sql = $"SELECT * from tb_times WHERE nome_time = '{time_casa}'"
                rs = db.Execute(sql)
                img_time_casa.Load(diretorio_logo_time & rs.Fields(2).Value)
                sql = $"SELECT * from tb_times WHERE nome_time = '{time_visitante}'"
                rs = db.Execute(sql)
                img_time_visitante.Load(diretorio_logo_time & rs.Fields(2).Value)
            End If
        End If
    End Sub

    Private Sub btn_jogo_anterior_Click(sender As Object, e As EventArgs) Handles btn_jogo_anterior.Click
        If id_jogos = 2 Then
            btn_jogo_anterior.Visible = False
        ElseIf id_jogos < qntd_jogos Then
            btn_prox_jogo.Visible = True
        End If
        If id_jogos > 1 Then
            btn_prox_jogo.Visible = True
            id_jogos = id_jogos - 1
            sql = $"SELECT * from tb_jogos WHERE id={id_jogos}"
            rs = db.Execute(sql)
            time_casa = rs.Fields(2).Value
            time_visitante = rs.Fields(3).Value
            If rs.EOF = False Then
                lbl_time_casa.Text = time_casa
                lbl_time_visitante.Text = time_visitante
                lbl_nome_campeonato.Text = rs.Fields(1).Value
                data_jogos = DateTime.Parse(rs.Fields(4).Value)
                horario_jogos = DateTime.Parse(rs.Fields(5).Value)
                lbl_estadio.Text = rs.Fields(6).Value
                If horario_jogos.Minute = "0" Then
                    lbl_data.Text = $"Data: {data_jogos.Day}/{data_jogos.Month} | Horario: {horario_jogos.Hour}:{horario_jogos.Minute}0"
                Else
                    lbl_data.Text = $"Data: {data_jogos.Day}/{data_jogos.Month} | Horario: {horario_jogos.Hour}:{horario_jogos.Minute}"
                End If
                sql = $"SELECT * from tb_times WHERE nome_time = '{time_casa}'"
                rs = db.Execute(sql)
                img_time_casa.Load(diretorio_logo_time & rs.Fields(2).Value)
                sql = $"SELECT * from tb_times WHERE nome_time = '{time_visitante}'"
                rs = db.Execute(sql)
                img_time_visitante.Load(diretorio_logo_time & rs.Fields(2).Value)
            End If
        End If
    End Sub

    Private Sub btn_comprar_Click(sender As Object, e As EventArgs) Handles btn_comprar.Click
        frm_comprar.Show()
        Me.Close()
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            id_jogos = 1
            frm_menu.Show()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        id_jogos = 1
        frm_menu.Show()
        Me.Close()
    End Sub
End Class