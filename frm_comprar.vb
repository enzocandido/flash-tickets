Imports System.Linq.Expressions

Public Class frm_comprar
    Private Sub frm_comprar_Load(sender As Object, e As EventArgs) Handles Me.Load
        conecta_banco()
        qntd_ingresso = 1
    End Sub
    Private Sub btn_voltar_Click(sender As Object, e As EventArgs)
        Try
            frm_explorar.Show()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub drop_tipo_ingresso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drop_tipo_ingresso.SelectedIndexChanged
        If txt_qtde.Text <> "" Or txt_qtde.Text <> "1" Then
            qntd_ingresso = Val(txt_qtde.Text)
        End If
        If drop_tipo_ingresso.SelectedIndex = 0 Then
            valor_ingresso = 15
            valor_total = 15
            valor_total = valor_total * qntd_ingresso
            lbl_total.Text = $"Valor total: R${valor_total},00"
        ElseIf drop_tipo_ingresso.SelectedIndex = 1 Then
            valor_ingresso = 25
            valor_total = 25
            valor_total = valor_total * qntd_ingresso
            lbl_total.Text = $"Valor total: R${valor_total},00"
        ElseIf drop_tipo_ingresso.SelectedIndex = 2 Then
            valor_ingresso = 50
            valor_total = 50
            valor_total = valor_total * qntd_ingresso
            lbl_total.Text = $"Valor total: R${valor_total},00"
        ElseIf drop_tipo_ingresso.SelectedIndex = 3 Then
            valor_ingresso = 65
            valor_total = 65
            valor_total = valor_total * qntd_ingresso
            lbl_total.Text = $"Valor total: R${valor_total},00"
        ElseIf drop_tipo_ingresso.SelectedIndex = 4 Then
            valor_ingresso = 80
            valor_total = 80
            valor_total = valor_total * qntd_ingresso
            lbl_total.Text = $"Valor total: R${valor_total},00"
        ElseIf drop_tipo_ingresso.SelectedIndex = 5 Then
            valor_ingresso = 300
            valor_total = 300
            valor_total = valor_total * qntd_ingresso
            lbl_total.Text = $"Valor total: R${valor_total},00"
        End If
    End Sub

    Private Sub txt_qtde_TextChanged(sender As Object, e As EventArgs) Handles txt_qtde.TextChanged
        If txt_qtde.Text <> "" Or txt_qtde.Text <> "1" Then
            qntd_ingresso = Val(txt_qtde.Text)
        End If
        valor_total = qntd_ingresso * valor_ingresso
        lbl_total.Text = $"Valor total: R${valor_total},00"
    End Sub

    Private Sub btn_comprar_Click(sender As Object, e As EventArgs) Handles btn_comprar.Click
        If drop_metodo.SelectedIndex = 0 Then
            metodo_pagamento = "Pix"
        ElseIf drop_metodo.SelectedIndex = 1 Then
            metodo_pagamento = "Boleto"
        ElseIf drop_metodo.SelectedIndex = 2 Then
            metodo_pagamento = "Cartao de Débito"
        End If
        Try
            sql = $"INSERT INTO tb_compra (usuario_comprador, id_jogo, data_compra, metodo_pagamento, valor_compra, jogo_comprado) VALUES ('{sessao_usuario}', '{id_jogos}', '{data_atual}', '{metodo_pagamento}', '{valor_total}', '{time_casa} X {time_visitante}')"
            rs = db.Execute(sql)
            MsgBox($"{time_casa} X {time_visitante} comprado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            frm_explorar.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro ao comprar, contacte um administrador.")
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            frm_explorar.Show()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub
End Class