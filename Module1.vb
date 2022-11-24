Imports System.IO
Imports System.Security.Policy

Module Module1
    Public diretorio, sql, aux_cpf, resp, status_conta, sessao_usuario As String
    Public primeira_parte_cep, segunda_parte_cep As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public dirbanco = Application.StartupPath & "\Banco_Dados\cadastro.mdb"
    Public cont, qntd_jogos As Integer
    Public id_jogos = 1
    Public diretorio_imagem As String = Application.StartupPath() & "\Fotos\"
    Public diretorio_logo_time As String = Application.StartupPath & "\Fotos\Times\"
    Public time_visitante, time_casa As String
    Public data_jogos, horario_jogos As DateTime
    Public valor_total, valor_ingresso As Integer
    Public qntd_ingresso As Integer
    Public data_atual = Now
    Public tipo_ingresso, metodo_pagamento As String

    Sub conecta_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & dirbanco)
        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_dados()
        Try
            sql = "select id_conta,nome,cpf from tb_usuario order by nome asc"
            rs = db.Execute(sql)
            With frm_clientes.dgv_dados
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

    Sub carregar_tipo()
        Try
            With frm_clientes.cmb_tipo.Items
                .Add("NOME")
                .Add("CPF")
            End With
            frm_clientes.cmb_tipo.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

End Module
