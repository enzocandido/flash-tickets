<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_comprar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_comprar))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.elipseBackground = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuGradientPanel2 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.BunifuPanel1 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.drop_metodo = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.txt_qtde = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.drop_tipo_ingresso = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_comprar = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuPanel2 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.lbl_total = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuGradientPanel2.SuspendLayout()
        Me.BunifuPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'elipseBackground
        '
        Me.elipseBackground.ElipseRadius = 20
        Me.elipseBackground.TargetControl = Me
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.BorderRadius = 1
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuPanel1)
        Me.BunifuGradientPanel2.Controls.Add(Me.PictureBox2)
        Me.BunifuGradientPanel2.Controls.Add(Me.PictureBox1)
        Me.BunifuGradientPanel2.Controls.Add(Me.btn_comprar)
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuLabel2)
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuPanel2)
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(-9, -29)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(557, 460)
        Me.BunifuGradientPanel2.TabIndex = 72
        '
        'BunifuPanel1
        '
        Me.BunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuPanel1.BackgroundImage = CType(resources.GetObject("BunifuPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel1.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuPanel1.BorderRadius = 20
        Me.BunifuPanel1.BorderThickness = 1
        Me.BunifuPanel1.Controls.Add(Me.BunifuLabel3)
        Me.BunifuPanel1.Controls.Add(Me.drop_metodo)
        Me.BunifuPanel1.Controls.Add(Me.BunifuLabel1)
        Me.BunifuPanel1.Controls.Add(Me.txt_qtde)
        Me.BunifuPanel1.Controls.Add(Me.drop_tipo_ingresso)
        Me.BunifuPanel1.Location = New System.Drawing.Point(41, 125)
        Me.BunifuPanel1.Name = "BunifuPanel1"
        Me.BunifuPanel1.ShowBorders = True
        Me.BunifuPanel1.Size = New System.Drawing.Size(474, 164)
        Me.BunifuPanel1.TabIndex = 87
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AllowParentOverrides = False
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel3.Location = New System.Drawing.Point(22, 17)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(89, 15)
        Me.BunifuLabel3.TabIndex = 49
        Me.BunifuLabel3.Text = "Tipo de ingresso:"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'drop_metodo
        '
        Me.drop_metodo.BackColor = System.Drawing.Color.Transparent
        Me.drop_metodo.BackgroundColor = System.Drawing.Color.White
        Me.drop_metodo.BorderColor = System.Drawing.Color.Silver
        Me.drop_metodo.BorderRadius = 1
        Me.drop_metodo.Color = System.Drawing.Color.Silver
        Me.drop_metodo.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.drop_metodo.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.drop_metodo.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.drop_metodo.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.drop_metodo.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.drop_metodo.DisabledIndicatorColor = System.Drawing.Color.DarkGray
        Me.drop_metodo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.drop_metodo.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin
        Me.drop_metodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drop_metodo.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.drop_metodo.FillDropDown = True
        Me.drop_metodo.FillIndicator = False
        Me.drop_metodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.drop_metodo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.drop_metodo.ForeColor = System.Drawing.Color.Black
        Me.drop_metodo.FormattingEnabled = True
        Me.drop_metodo.Icon = Nothing
        Me.drop_metodo.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.drop_metodo.IndicatorColor = System.Drawing.Color.Gray
        Me.drop_metodo.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.drop_metodo.ItemBackColor = System.Drawing.Color.White
        Me.drop_metodo.ItemBorderColor = System.Drawing.Color.White
        Me.drop_metodo.ItemForeColor = System.Drawing.Color.Black
        Me.drop_metodo.ItemHeight = 26
        Me.drop_metodo.ItemHighLightColor = System.Drawing.Color.DodgerBlue
        Me.drop_metodo.ItemHighLightForeColor = System.Drawing.Color.White
        Me.drop_metodo.Items.AddRange(New Object() {"Pix", "Boleto", "Cartão de Débito"})
        Me.drop_metodo.ItemTopMargin = 3
        Me.drop_metodo.Location = New System.Drawing.Point(22, 105)
        Me.drop_metodo.Name = "drop_metodo"
        Me.drop_metodo.Size = New System.Drawing.Size(260, 32)
        Me.drop_metodo.TabIndex = 44
        Me.drop_metodo.Text = Nothing
        Me.drop_metodo.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.drop_metodo.TextLeftMargin = 5
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.Location = New System.Drawing.Point(22, 84)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(125, 15)
        Me.BunifuLabel1.TabIndex = 45
        Me.BunifuLabel1.Text = "Método de pagamento:"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'txt_qtde
        '
        Me.txt_qtde.AcceptsReturn = False
        Me.txt_qtde.AcceptsTab = False
        Me.txt_qtde.AnimationSpeed = 200
        Me.txt_qtde.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txt_qtde.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txt_qtde.BackColor = System.Drawing.Color.Transparent
        Me.txt_qtde.BackgroundImage = CType(resources.GetObject("txt_qtde.BackgroundImage"), System.Drawing.Image)
        Me.txt_qtde.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.txt_qtde.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txt_qtde.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_qtde.BorderColorIdle = System.Drawing.Color.Silver
        Me.txt_qtde.BorderRadius = 1
        Me.txt_qtde.BorderThickness = 1
        Me.txt_qtde.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txt_qtde.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_qtde.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txt_qtde.DefaultText = ""
        Me.txt_qtde.FillColor = System.Drawing.Color.White
        Me.txt_qtde.HideSelection = True
        Me.txt_qtde.IconLeft = Nothing
        Me.txt_qtde.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_qtde.IconPadding = 10
        Me.txt_qtde.IconRight = Nothing
        Me.txt_qtde.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_qtde.Lines = New String(-1) {}
        Me.txt_qtde.Location = New System.Drawing.Point(288, 38)
        Me.txt_qtde.MaxLength = 32767
        Me.txt_qtde.MinimumSize = New System.Drawing.Size(1, 1)
        Me.txt_qtde.Modified = False
        Me.txt_qtde.Multiline = False
        Me.txt_qtde.Name = "txt_qtde"
        StateProperties1.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txt_qtde.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txt_qtde.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txt_qtde.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Empty
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txt_qtde.OnIdleState = StateProperties4
        Me.txt_qtde.Padding = New System.Windows.Forms.Padding(3)
        Me.txt_qtde.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_qtde.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txt_qtde.PlaceholderText = "Quantidade"
        Me.txt_qtde.ReadOnly = False
        Me.txt_qtde.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_qtde.SelectedText = ""
        Me.txt_qtde.SelectionLength = 0
        Me.txt_qtde.SelectionStart = 0
        Me.txt_qtde.ShortcutsEnabled = True
        Me.txt_qtde.Size = New System.Drawing.Size(120, 32)
        Me.txt_qtde.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.txt_qtde.TabIndex = 46
        Me.txt_qtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_qtde.TextMarginBottom = 0
        Me.txt_qtde.TextMarginLeft = 3
        Me.txt_qtde.TextMarginTop = 0
        Me.txt_qtde.TextPlaceholder = "Quantidade"
        Me.txt_qtde.UseSystemPasswordChar = False
        Me.txt_qtde.WordWrap = True
        '
        'drop_tipo_ingresso
        '
        Me.drop_tipo_ingresso.BackColor = System.Drawing.Color.Transparent
        Me.drop_tipo_ingresso.BackgroundColor = System.Drawing.Color.White
        Me.drop_tipo_ingresso.BorderColor = System.Drawing.Color.Silver
        Me.drop_tipo_ingresso.BorderRadius = 1
        Me.drop_tipo_ingresso.Color = System.Drawing.Color.Silver
        Me.drop_tipo_ingresso.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.drop_tipo_ingresso.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.drop_tipo_ingresso.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.drop_tipo_ingresso.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.drop_tipo_ingresso.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.drop_tipo_ingresso.DisabledIndicatorColor = System.Drawing.Color.DarkGray
        Me.drop_tipo_ingresso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.drop_tipo_ingresso.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin
        Me.drop_tipo_ingresso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drop_tipo_ingresso.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.drop_tipo_ingresso.FillDropDown = True
        Me.drop_tipo_ingresso.FillIndicator = False
        Me.drop_tipo_ingresso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.drop_tipo_ingresso.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.drop_tipo_ingresso.ForeColor = System.Drawing.Color.Black
        Me.drop_tipo_ingresso.FormattingEnabled = True
        Me.drop_tipo_ingresso.Icon = Nothing
        Me.drop_tipo_ingresso.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.drop_tipo_ingresso.IndicatorColor = System.Drawing.Color.Gray
        Me.drop_tipo_ingresso.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.drop_tipo_ingresso.ItemBackColor = System.Drawing.Color.White
        Me.drop_tipo_ingresso.ItemBorderColor = System.Drawing.Color.White
        Me.drop_tipo_ingresso.ItemForeColor = System.Drawing.Color.Black
        Me.drop_tipo_ingresso.ItemHeight = 26
        Me.drop_tipo_ingresso.ItemHighLightColor = System.Drawing.Color.DodgerBlue
        Me.drop_tipo_ingresso.ItemHighLightForeColor = System.Drawing.Color.White
        Me.drop_tipo_ingresso.Items.AddRange(New Object() {"Arquibancada Amarela: R$15,00", "Arquibancada Laranja: R$25,00", "Arquibancada Azul: R$50,00", "Cadeira Superior: R$65,00", "Cadeira Inferior: R$80,00", "Camarote: R$300,00"})
        Me.drop_tipo_ingresso.ItemTopMargin = 3
        Me.drop_tipo_ingresso.Location = New System.Drawing.Point(22, 38)
        Me.drop_tipo_ingresso.Name = "drop_tipo_ingresso"
        Me.drop_tipo_ingresso.Size = New System.Drawing.Size(260, 32)
        Me.drop_tipo_ingresso.TabIndex = 48
        Me.drop_tipo_ingresso.Text = Nothing
        Me.drop_tipo_ingresso.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.drop_tipo_ingresso.TextLeftMargin = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.prj_si_2022_2S.My.Resources.Resources.icons8_xbox_x_35
        Me.PictureBox2.Location = New System.Drawing.Point(504, 41)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 45)
        Me.PictureBox2.TabIndex = 86
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.prj_si_2022_2S.My.Resources.Resources.icons8_esquerda_25
        Me.PictureBox1.Location = New System.Drawing.Point(471, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 29)
        Me.PictureBox1.TabIndex = 85
        Me.PictureBox1.TabStop = False
        '
        'btn_comprar
        '
        Me.btn_comprar.AllowAnimations = True
        Me.btn_comprar.AllowMouseEffects = True
        Me.btn_comprar.AllowToggling = False
        Me.btn_comprar.AnimationSpeed = 200
        Me.btn_comprar.AutoGenerateColors = False
        Me.btn_comprar.AutoRoundBorders = False
        Me.btn_comprar.AutoSizeLeftIcon = True
        Me.btn_comprar.AutoSizeRightIcon = True
        Me.btn_comprar.BackColor = System.Drawing.Color.Transparent
        Me.btn_comprar.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_comprar.BackgroundImage = CType(resources.GetObject("btn_comprar.BackgroundImage"), System.Drawing.Image)
        Me.btn_comprar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_comprar.ButtonText = "COMPRAR"
        Me.btn_comprar.ButtonTextMarginLeft = 0
        Me.btn_comprar.ColorContrastOnClick = 45
        Me.btn_comprar.ColorContrastOnHover = 45
        Me.btn_comprar.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.btn_comprar.CustomizableEdges = BorderEdges1
        Me.btn_comprar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_comprar.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_comprar.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_comprar.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_comprar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btn_comprar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_comprar.ForeColor = System.Drawing.Color.Black
        Me.btn_comprar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_comprar.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btn_comprar.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btn_comprar.IconMarginLeft = 11
        Me.btn_comprar.IconPadding = 10
        Me.btn_comprar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_comprar.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btn_comprar.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btn_comprar.IconSize = 25
        Me.btn_comprar.IdleBorderColor = System.Drawing.Color.Transparent
        Me.btn_comprar.IdleBorderRadius = 20
        Me.btn_comprar.IdleBorderThickness = 2
        Me.btn_comprar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_comprar.IdleIconLeftImage = Nothing
        Me.btn_comprar.IdleIconRightImage = Nothing
        Me.btn_comprar.IndicateFocus = False
        Me.btn_comprar.Location = New System.Drawing.Point(212, 370)
        Me.btn_comprar.Name = "btn_comprar"
        Me.btn_comprar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_comprar.OnDisabledState.BorderRadius = 20
        Me.btn_comprar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_comprar.OnDisabledState.BorderThickness = 2
        Me.btn_comprar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_comprar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_comprar.OnDisabledState.IconLeftImage = Nothing
        Me.btn_comprar.OnDisabledState.IconRightImage = Nothing
        Me.btn_comprar.onHoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_comprar.onHoverState.BorderRadius = 20
        Me.btn_comprar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_comprar.onHoverState.BorderThickness = 2
        Me.btn_comprar.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_comprar.onHoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_comprar.onHoverState.IconLeftImage = Nothing
        Me.btn_comprar.onHoverState.IconRightImage = Nothing
        Me.btn_comprar.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_comprar.OnIdleState.BorderRadius = 20
        Me.btn_comprar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_comprar.OnIdleState.BorderThickness = 2
        Me.btn_comprar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_comprar.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.btn_comprar.OnIdleState.IconLeftImage = Nothing
        Me.btn_comprar.OnIdleState.IconRightImage = Nothing
        Me.btn_comprar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_comprar.OnPressedState.BorderRadius = 20
        Me.btn_comprar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_comprar.OnPressedState.BorderThickness = 2
        Me.btn_comprar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_comprar.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_comprar.OnPressedState.IconLeftImage = Nothing
        Me.btn_comprar.OnPressedState.IconRightImage = Nothing
        Me.btn_comprar.Size = New System.Drawing.Size(132, 46)
        Me.btn_comprar.TabIndex = 31
        Me.btn_comprar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_comprar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_comprar.TextMarginLeft = 0
        Me.btn_comprar.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btn_comprar.UseDefaultRadiusAndThickness = True
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuLabel2.ForeColor = System.Drawing.Color.Black
        Me.BunifuLabel2.Location = New System.Drawing.Point(182, 74)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(182, 45)
        Me.BunifuLabel2.TabIndex = 22
        Me.BunifuLabel2.Text = "CARRINHO"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuPanel2
        '
        Me.BunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuPanel2.BackgroundImage = CType(resources.GetObject("BunifuPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel2.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuPanel2.BorderRadius = 3
        Me.BunifuPanel2.BorderThickness = 1
        Me.BunifuPanel2.Controls.Add(Me.lbl_total)
        Me.BunifuPanel2.Location = New System.Drawing.Point(62, 289)
        Me.BunifuPanel2.Name = "BunifuPanel2"
        Me.BunifuPanel2.ShowBorders = True
        Me.BunifuPanel2.Size = New System.Drawing.Size(435, 51)
        Me.BunifuPanel2.TabIndex = 88
        '
        'lbl_total
        '
        Me.lbl_total.AllowParentOverrides = False
        Me.lbl_total.AutoEllipsis = False
        Me.lbl_total.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_total.CursorType = System.Windows.Forms.Cursors.Default
        Me.lbl_total.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total.Location = New System.Drawing.Point(36, 13)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_total.Size = New System.Drawing.Size(90, 23)
        Me.lbl_total.TabIndex = 47
        Me.lbl_total.Text = "Valor total:"
        Me.lbl_total.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lbl_total.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'frm_comprar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 429)
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_comprar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        Me.BunifuPanel1.ResumeLayout(False)
        Me.BunifuPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuPanel2.ResumeLayout(False)
        Me.BunifuPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuGradientPanel2 As Bunifu.UI.WinForms.BunifuGradientPanel

    Private Sub btn_jogo_anterior_Click(sender As Object, e As EventArgs)

    End Sub
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents btn_comprar As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents elipseBackground As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lbl_total As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents txt_qtde As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents drop_metodo As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents drop_tipo_ingresso As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BunifuPanel1 As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuPanel2 As Bunifu.UI.WinForms.BunifuPanel
End Class
