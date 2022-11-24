<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_clientes
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_clientes))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_busca = New System.Windows.Forms.ToolStripTextBox()
        Me.cmb_tipo = New System.Windows.Forms.ToolStripComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_fone = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_uf = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_bairro = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_data = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.elipseBackground = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_gravar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.Column10 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.BunifuGradientPanel1 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ConnectionBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConnectionBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConnectionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConnectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConnectionBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConnectionBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConnectionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConnectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Chocolate
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_gravar, Me.ToolStripButton2, Me.ToolStripLabel1, Me.txt_busca, Me.cmb_tipo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(574, 31)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(191, 28)
        Me.ToolStripLabel1.Text = "Digite um parâmetro de pesquisa"
        '
        'txt_busca
        '
        Me.txt_busca.BackColor = System.Drawing.SystemColors.Info
        Me.txt_busca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_busca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(134, 31)
        '
        'cmb_tipo
        '
        Me.cmb_tipo.BackColor = System.Drawing.SystemColors.Info
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(101, 31)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(27, 54)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(451, 274)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txt_email)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txt_fone)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txt_uf)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txt_cidade)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txt_bairro)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txt_endereco)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txt_cep)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txt_nome)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_data)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txt_cpf)
        Me.TabPage1.Controls.Add(Me.img_foto)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(443, 248)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "DADOS PESSOAIS"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(156, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "E-MAIL"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(159, 208)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(245, 20)
        Me.txt_email.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "CONTATO FONE"
        '
        'txt_fone
        '
        Me.txt_fone.Location = New System.Drawing.Point(9, 208)
        Me.txt_fone.Mask = "(99) 99999-9999"
        Me.txt_fone.Name = "txt_fone"
        Me.txt_fone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_fone.Size = New System.Drawing.Size(135, 20)
        Me.txt_fone.TabIndex = 7
        Me.txt_fone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(335, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "UF"
        '
        'txt_uf
        '
        Me.txt_uf.Location = New System.Drawing.Point(338, 161)
        Me.txt_uf.Name = "txt_uf"
        Me.txt_uf.Size = New System.Drawing.Size(66, 20)
        Me.txt_uf.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(156, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "CIDADE"
        '
        'txt_cidade
        '
        Me.txt_cidade.Location = New System.Drawing.Point(159, 161)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(170, 20)
        Me.txt_cidade.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "BAIRRO"
        '
        'txt_bairro
        '
        Me.txt_bairro.Location = New System.Drawing.Point(9, 161)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(135, 20)
        Me.txt_bairro.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(103, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "ENDEREÇO"
        '
        'txt_endereco
        '
        Me.txt_endereco.Location = New System.Drawing.Point(104, 123)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(300, 20)
        Me.txt_endereco.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "CEP"
        '
        'txt_cep
        '
        Me.txt_cep.Location = New System.Drawing.Point(9, 122)
        Me.txt_cep.Mask = "99999-999"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(91, 20)
        Me.txt_cep.TabIndex = 2
        Me.txt_cep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "NOME DO CLIENTE"
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(6, 83)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(273, 20)
        Me.txt_nome.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(134, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "DATA NASCIMENTO"
        '
        'txt_data
        '
        Me.txt_data.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_data.Location = New System.Drawing.Point(137, 41)
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(145, 20)
        Me.txt_data.TabIndex = 11
        Me.txt_data.Value = New Date(2022, 9, 8, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "CPF DO CLIENTE"
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(9, 44)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(91, 20)
        Me.txt_cpf.TabIndex = 0
        Me.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_dados)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(443, 248)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "LISTAGEM CADASTRO"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_dados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column12, Me.Column11})
        Me.dgv_dados.Location = New System.Drawing.Point(6, 6)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.ReadOnly = True
        Me.dgv_dados.Size = New System.Drawing.Size(412, 175)
        Me.dgv_dados.TabIndex = 0
        '
        'Column7
        '
        Me.Column7.HeaderText = "ID"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 43
        '
        'Column8
        '
        Me.Column8.HeaderText = "NOME"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 64
        '
        'Column9
        '
        Me.Column9.HeaderText = "CPF"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column9.Width = 33
        '
        'elipseBackground
        '
        Me.elipseBackground.ElipseRadius = 20
        Me.elipseBackground.TargetControl = Me
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "EDITAR"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Width = 53
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "BLOQUEAR"
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Width = 72
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.HeaderText = "EXCLUIR"
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.ReadOnly = True
        Me.DataGridViewImageColumn3.Width = 59
        '
        'DataGridViewImageColumn4
        '
        Me.DataGridViewImageColumn4.HeaderText = "EDITAR"
        Me.DataGridViewImageColumn4.Image = Global.prj_si_2022_2S.My.Resources.Resources.edit_icon
        Me.DataGridViewImageColumn4.Name = "DataGridViewImageColumn4"
        Me.DataGridViewImageColumn4.ReadOnly = True
        Me.DataGridViewImageColumn4.Width = 53
        '
        'DataGridViewImageColumn5
        '
        Me.DataGridViewImageColumn5.HeaderText = "BLOQUEAR"
        Me.DataGridViewImageColumn5.Image = Global.prj_si_2022_2S.My.Resources.Resources.block_user
        Me.DataGridViewImageColumn5.Name = "DataGridViewImageColumn5"
        Me.DataGridViewImageColumn5.ReadOnly = True
        Me.DataGridViewImageColumn5.Width = 72
        '
        'DataGridViewImageColumn6
        '
        Me.DataGridViewImageColumn6.HeaderText = "EXCLUIR"
        Me.DataGridViewImageColumn6.Image = Global.prj_si_2022_2S.My.Resources.Resources.Delete_icon
        Me.DataGridViewImageColumn6.Name = "DataGridViewImageColumn6"
        Me.DataGridViewImageColumn6.ReadOnly = True
        Me.DataGridViewImageColumn6.Width = 59
        '
        'btn_gravar
        '
        Me.btn_gravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_gravar.Image = CType(resources.GetObject("btn_gravar.Image"), System.Drawing.Image)
        Me.btn_gravar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(28, 28)
        Me.btn_gravar.Text = "ToolStripButton1"
        Me.btn_gravar.ToolTipText = "Gravar"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.ToolTipText = "Consultar"
        '
        'img_foto
        '
        Me.img_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(315, 6)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(89, 108)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 8
        Me.img_foto.TabStop = False
        '
        'Column10
        '
        Me.Column10.HeaderText = "EDITAR"
        Me.Column10.Image = Global.prj_si_2022_2S.My.Resources.Resources.edit_icon
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 53
        '
        'Column12
        '
        Me.Column12.HeaderText = "BLOQUEAR"
        Me.Column12.Image = Global.prj_si_2022_2S.My.Resources.Resources.block_user
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 72
        '
        'Column11
        '
        Me.Column11.HeaderText = "EXCLUIR"
        Me.Column11.Image = Global.prj_si_2022_2S.My.Resources.Resources.Delete_icon
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 59
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.BorderRadius = 1
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox2)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(-9, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(589, 387)
        Me.BunifuGradientPanel1.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.prj_si_2022_2S.My.Resources.Resources.icons8_xbox_x_35
        Me.PictureBox2.Location = New System.Drawing.Point(537, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 45)
        Me.PictureBox2.TabIndex = 87
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.prj_si_2022_2S.My.Resources.Resources.icons8_esquerda_25
        Me.PictureBox1.Location = New System.Drawing.Point(520, 322)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 29)
        Me.PictureBox1.TabIndex = 84
        Me.PictureBox1.TabStop = False
        '
        'ConnectionBindingSource3
        '
        Me.ConnectionBindingSource3.DataSource = GetType(ADODB.Connection)
        '
        'ConnectionBindingSource2
        '
        Me.ConnectionBindingSource2.DataSource = GetType(ADODB.Connection)
        '
        'ConnectionBindingSource1
        '
        Me.ConnectionBindingSource1.DataSource = GetType(ADODB.Connection)
        '
        'ConnectionBindingSource
        '
        Me.ConnectionBindingSource.DataSource = GetType(ADODB.Connection)
        '
        'frm_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(574, 373)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO DE CLIENTES"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConnectionBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConnectionBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConnectionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConnectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_gravar As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_fone As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_uf As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_cidade As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_data As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_busca As ToolStripTextBox
    Friend WithEvents cmb_tipo As ToolStripComboBox
    Friend WithEvents ConnectionBindingSource1 As BindingSource
    Friend WithEvents ConnectionBindingSource As BindingSource
    Friend WithEvents ConnectionBindingSource2 As BindingSource
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents ConnectionBindingSource3 As BindingSource
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents BunifuGradientPanel1 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents elipseBackground As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewImageColumn
    Friend WithEvents Column12 As DataGridViewImageColumn
    Friend WithEvents Column11 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn4 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn5 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn6 As DataGridViewImageColumn
End Class
