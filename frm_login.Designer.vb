<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties7 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties8 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Me.elipseBackground = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuGradientPanel1 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lbl_rsenha = New Bunifu.UI.WinForms.BunifuLabel()
        Me.txt_usuario = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.btn_entrar = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btn_cadastrar = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.txt_senha = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'elipseBackground
        '
        Me.elipseBackground.ElipseRadius = 20
        Me.elipseBackground.TargetControl = Me
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.BorderRadius = 1
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox2)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuLabel2)
        Me.BunifuGradientPanel1.Controls.Add(Me.lbl_rsenha)
        Me.BunifuGradientPanel1.Controls.Add(Me.txt_usuario)
        Me.BunifuGradientPanel1.Controls.Add(Me.btn_entrar)
        Me.BunifuGradientPanel1.Controls.Add(Me.btn_cadastrar)
        Me.BunifuGradientPanel1.Controls.Add(Me.txt_senha)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(-4, -3)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(757, 468)
        Me.BunifuGradientPanel1.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.prj_si_2022_2S.My.Resources.Resources.icons8_xbox_x_35
        Me.PictureBox2.Location = New System.Drawing.Point(707, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 45)
        Me.PictureBox2.TabIndex = 85
        Me.PictureBox2.TabStop = False
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuLabel2.ForeColor = System.Drawing.Color.Black
        Me.BunifuLabel2.Location = New System.Drawing.Point(140, 84)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(101, 45)
        Me.BunifuLabel2.TabIndex = 8
        Me.BunifuLabel2.Text = "LOGIN"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'lbl_rsenha
        '
        Me.lbl_rsenha.AllowParentOverrides = False
        Me.lbl_rsenha.AutoEllipsis = False
        Me.lbl_rsenha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_rsenha.CursorType = System.Windows.Forms.Cursors.Hand
        Me.lbl_rsenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.lbl_rsenha.Location = New System.Drawing.Point(39, 254)
        Me.lbl_rsenha.Name = "lbl_rsenha"
        Me.lbl_rsenha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_rsenha.Size = New System.Drawing.Size(119, 15)
        Me.lbl_rsenha.TabIndex = 7
        Me.lbl_rsenha.Text = "Esqueci minha senha"
        Me.lbl_rsenha.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lbl_rsenha.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'txt_usuario
        '
        Me.txt_usuario.AcceptsReturn = False
        Me.txt_usuario.AcceptsTab = False
        Me.txt_usuario.AnimationSpeed = 200
        Me.txt_usuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txt_usuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txt_usuario.BackColor = System.Drawing.Color.White
        Me.txt_usuario.BackgroundImage = CType(resources.GetObject("txt_usuario.BackgroundImage"), System.Drawing.Image)
        Me.txt_usuario.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_usuario.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txt_usuario.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_usuario.BorderColorIdle = System.Drawing.Color.Black
        Me.txt_usuario.BorderRadius = 1
        Me.txt_usuario.BorderThickness = 1
        Me.txt_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txt_usuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_usuario.DefaultFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.DefaultText = ""
        Me.txt_usuario.FillColor = System.Drawing.Color.White
        Me.txt_usuario.HideSelection = True
        Me.txt_usuario.IconLeft = Nothing
        Me.txt_usuario.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_usuario.IconPadding = 10
        Me.txt_usuario.IconRight = Nothing
        Me.txt_usuario.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_usuario.Lines = New String(-1) {}
        Me.txt_usuario.Location = New System.Drawing.Point(32, 157)
        Me.txt_usuario.MaxLength = 32767
        Me.txt_usuario.MinimumSize = New System.Drawing.Size(1, 1)
        Me.txt_usuario.Modified = False
        Me.txt_usuario.Multiline = False
        Me.txt_usuario.Name = "txt_usuario"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txt_usuario.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txt_usuario.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txt_usuario.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Black
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Empty
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txt_usuario.OnIdleState = StateProperties4
        Me.txt_usuario.Padding = New System.Windows.Forms.Padding(3)
        Me.txt_usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_usuario.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txt_usuario.PlaceholderText = "Digite seu usuário"
        Me.txt_usuario.ReadOnly = False
        Me.txt_usuario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_usuario.SelectedText = ""
        Me.txt_usuario.SelectionLength = 0
        Me.txt_usuario.SelectionStart = 0
        Me.txt_usuario.ShortcutsEnabled = True
        Me.txt_usuario.Size = New System.Drawing.Size(322, 34)
        Me.txt_usuario.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material
        Me.txt_usuario.TabIndex = 2
        Me.txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_usuario.TextMarginBottom = 0
        Me.txt_usuario.TextMarginLeft = 3
        Me.txt_usuario.TextMarginTop = 0
        Me.txt_usuario.TextPlaceholder = "Digite seu usuário"
        Me.txt_usuario.UseSystemPasswordChar = False
        Me.txt_usuario.WordWrap = True
        '
        'btn_entrar
        '
        Me.btn_entrar.AllowAnimations = True
        Me.btn_entrar.AllowMouseEffects = True
        Me.btn_entrar.AllowToggling = False
        Me.btn_entrar.AnimationSpeed = 200
        Me.btn_entrar.AutoGenerateColors = False
        Me.btn_entrar.AutoRoundBorders = False
        Me.btn_entrar.AutoSizeLeftIcon = True
        Me.btn_entrar.AutoSizeRightIcon = True
        Me.btn_entrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_entrar.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_entrar.BackgroundImage = CType(resources.GetObject("btn_entrar.BackgroundImage"), System.Drawing.Image)
        Me.btn_entrar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_entrar.ButtonText = "ENTRAR"
        Me.btn_entrar.ButtonTextMarginLeft = 0
        Me.btn_entrar.ColorContrastOnClick = 45
        Me.btn_entrar.ColorContrastOnHover = 45
        Me.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.btn_entrar.CustomizableEdges = BorderEdges1
        Me.btn_entrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_entrar.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_entrar.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_entrar.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_entrar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btn_entrar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrar.ForeColor = System.Drawing.Color.Black
        Me.btn_entrar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_entrar.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btn_entrar.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btn_entrar.IconMarginLeft = 11
        Me.btn_entrar.IconPadding = 10
        Me.btn_entrar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_entrar.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btn_entrar.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btn_entrar.IconSize = 25
        Me.btn_entrar.IdleBorderColor = System.Drawing.Color.Transparent
        Me.btn_entrar.IdleBorderRadius = 20
        Me.btn_entrar.IdleBorderThickness = 2
        Me.btn_entrar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_entrar.IdleIconLeftImage = Nothing
        Me.btn_entrar.IdleIconRightImage = Nothing
        Me.btn_entrar.IndicateFocus = False
        Me.btn_entrar.Location = New System.Drawing.Point(195, 301)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_entrar.OnDisabledState.BorderRadius = 20
        Me.btn_entrar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_entrar.OnDisabledState.BorderThickness = 2
        Me.btn_entrar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_entrar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_entrar.OnDisabledState.IconLeftImage = Nothing
        Me.btn_entrar.OnDisabledState.IconRightImage = Nothing
        Me.btn_entrar.onHoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_entrar.onHoverState.BorderRadius = 20
        Me.btn_entrar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_entrar.onHoverState.BorderThickness = 2
        Me.btn_entrar.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_entrar.onHoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_entrar.onHoverState.IconLeftImage = Nothing
        Me.btn_entrar.onHoverState.IconRightImage = Nothing
        Me.btn_entrar.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_entrar.OnIdleState.BorderRadius = 20
        Me.btn_entrar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_entrar.OnIdleState.BorderThickness = 2
        Me.btn_entrar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_entrar.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.btn_entrar.OnIdleState.IconLeftImage = Nothing
        Me.btn_entrar.OnIdleState.IconRightImage = Nothing
        Me.btn_entrar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_entrar.OnPressedState.BorderRadius = 20
        Me.btn_entrar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_entrar.OnPressedState.BorderThickness = 2
        Me.btn_entrar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_entrar.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_entrar.OnPressedState.IconLeftImage = Nothing
        Me.btn_entrar.OnPressedState.IconRightImage = Nothing
        Me.btn_entrar.Size = New System.Drawing.Size(150, 39)
        Me.btn_entrar.TabIndex = 6
        Me.btn_entrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_entrar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_entrar.TextMarginLeft = 0
        Me.btn_entrar.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btn_entrar.UseDefaultRadiusAndThickness = True
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.AllowAnimations = True
        Me.btn_cadastrar.AllowMouseEffects = True
        Me.btn_cadastrar.AllowToggling = False
        Me.btn_cadastrar.AnimationSpeed = 200
        Me.btn_cadastrar.AutoGenerateColors = False
        Me.btn_cadastrar.AutoRoundBorders = False
        Me.btn_cadastrar.AutoSizeLeftIcon = True
        Me.btn_cadastrar.AutoSizeRightIcon = True
        Me.btn_cadastrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_cadastrar.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_cadastrar.BackgroundImage = CType(resources.GetObject("btn_cadastrar.BackgroundImage"), System.Drawing.Image)
        Me.btn_cadastrar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_cadastrar.ButtonText = "CADASTRAR"
        Me.btn_cadastrar.ButtonTextMarginLeft = 0
        Me.btn_cadastrar.ColorContrastOnClick = 45
        Me.btn_cadastrar.ColorContrastOnHover = 45
        Me.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.btn_cadastrar.CustomizableEdges = BorderEdges2
        Me.btn_cadastrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_cadastrar.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_cadastrar.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_cadastrar.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_cadastrar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btn_cadastrar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.ForeColor = System.Drawing.Color.Black
        Me.btn_cadastrar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cadastrar.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btn_cadastrar.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btn_cadastrar.IconMarginLeft = 11
        Me.btn_cadastrar.IconPadding = 10
        Me.btn_cadastrar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cadastrar.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btn_cadastrar.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btn_cadastrar.IconSize = 25
        Me.btn_cadastrar.IdleBorderColor = System.Drawing.Color.Transparent
        Me.btn_cadastrar.IdleBorderRadius = 20
        Me.btn_cadastrar.IdleBorderThickness = 2
        Me.btn_cadastrar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_cadastrar.IdleIconLeftImage = Nothing
        Me.btn_cadastrar.IdleIconRightImage = Nothing
        Me.btn_cadastrar.IndicateFocus = False
        Me.btn_cadastrar.Location = New System.Drawing.Point(39, 301)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_cadastrar.OnDisabledState.BorderRadius = 20
        Me.btn_cadastrar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_cadastrar.OnDisabledState.BorderThickness = 2
        Me.btn_cadastrar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_cadastrar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_cadastrar.OnDisabledState.IconLeftImage = Nothing
        Me.btn_cadastrar.OnDisabledState.IconRightImage = Nothing
        Me.btn_cadastrar.onHoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_cadastrar.onHoverState.BorderRadius = 20
        Me.btn_cadastrar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_cadastrar.onHoverState.BorderThickness = 2
        Me.btn_cadastrar.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_cadastrar.onHoverState.ForeColor = System.Drawing.Color.Yellow
        Me.btn_cadastrar.onHoverState.IconLeftImage = Nothing
        Me.btn_cadastrar.onHoverState.IconRightImage = Nothing
        Me.btn_cadastrar.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_cadastrar.OnIdleState.BorderRadius = 20
        Me.btn_cadastrar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_cadastrar.OnIdleState.BorderThickness = 2
        Me.btn_cadastrar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_cadastrar.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.btn_cadastrar.OnIdleState.IconLeftImage = Nothing
        Me.btn_cadastrar.OnIdleState.IconRightImage = Nothing
        Me.btn_cadastrar.OnPressedState.BorderColor = System.Drawing.Color.Yellow
        Me.btn_cadastrar.OnPressedState.BorderRadius = 20
        Me.btn_cadastrar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_cadastrar.OnPressedState.BorderThickness = 2
        Me.btn_cadastrar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_cadastrar.OnPressedState.ForeColor = System.Drawing.Color.Yellow
        Me.btn_cadastrar.OnPressedState.IconLeftImage = Nothing
        Me.btn_cadastrar.OnPressedState.IconRightImage = Nothing
        Me.btn_cadastrar.Size = New System.Drawing.Size(150, 39)
        Me.btn_cadastrar.TabIndex = 5
        Me.btn_cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_cadastrar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_cadastrar.TextMarginLeft = 0
        Me.btn_cadastrar.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btn_cadastrar.UseDefaultRadiusAndThickness = True
        '
        'txt_senha
        '
        Me.txt_senha.AcceptsReturn = False
        Me.txt_senha.AcceptsTab = False
        Me.txt_senha.AnimationSpeed = 200
        Me.txt_senha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txt_senha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txt_senha.BackColor = System.Drawing.Color.White
        Me.txt_senha.BackgroundImage = CType(resources.GetObject("txt_senha.BackgroundImage"), System.Drawing.Image)
        Me.txt_senha.BorderColorActive = System.Drawing.Color.Red
        Me.txt_senha.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txt_senha.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_senha.BorderColorIdle = System.Drawing.Color.Black
        Me.txt_senha.BorderRadius = 1
        Me.txt_senha.BorderThickness = 1
        Me.txt_senha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txt_senha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_senha.DefaultFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.DefaultText = ""
        Me.txt_senha.FillColor = System.Drawing.Color.White
        Me.txt_senha.HideSelection = True
        Me.txt_senha.IconLeft = Nothing
        Me.txt_senha.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_senha.IconPadding = 10
        Me.txt_senha.IconRight = Nothing
        Me.txt_senha.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_senha.Lines = New String(-1) {}
        Me.txt_senha.Location = New System.Drawing.Point(32, 208)
        Me.txt_senha.MaxLength = 32767
        Me.txt_senha.MinimumSize = New System.Drawing.Size(1, 1)
        Me.txt_senha.Modified = False
        Me.txt_senha.Multiline = False
        Me.txt_senha.Name = "txt_senha"
        StateProperties5.BorderColor = System.Drawing.Color.Red
        StateProperties5.FillColor = System.Drawing.Color.Empty
        StateProperties5.ForeColor = System.Drawing.Color.Empty
        StateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txt_senha.OnActiveState = StateProperties5
        StateProperties6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties6.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txt_senha.OnDisabledState = StateProperties6
        StateProperties7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties7.FillColor = System.Drawing.Color.Empty
        StateProperties7.ForeColor = System.Drawing.Color.Empty
        StateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txt_senha.OnHoverState = StateProperties7
        StateProperties8.BorderColor = System.Drawing.Color.Black
        StateProperties8.FillColor = System.Drawing.Color.White
        StateProperties8.ForeColor = System.Drawing.Color.Empty
        StateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txt_senha.OnIdleState = StateProperties8
        Me.txt_senha.Padding = New System.Windows.Forms.Padding(3)
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_senha.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txt_senha.PlaceholderText = "Senha"
        Me.txt_senha.ReadOnly = False
        Me.txt_senha.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_senha.SelectedText = ""
        Me.txt_senha.SelectionLength = 0
        Me.txt_senha.SelectionStart = 0
        Me.txt_senha.ShortcutsEnabled = True
        Me.txt_senha.Size = New System.Drawing.Size(322, 36)
        Me.txt_senha.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material
        Me.txt_senha.TabIndex = 4
        Me.txt_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_senha.TextMarginBottom = 0
        Me.txt_senha.TextMarginLeft = 3
        Me.txt_senha.TextMarginTop = 0
        Me.txt_senha.TextPlaceholder = "Senha"
        Me.txt_senha.UseSystemPasswordChar = True
        Me.txt_senha.WordWrap = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.prj_si_2022_2S.My.Resources.Resources.logo_flashtickets
        Me.PictureBox1.Location = New System.Drawing.Point(304, -14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(487, 421)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(749, 459)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_login"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents elipseBackground As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txt_usuario As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents BunifuGradientPanel1 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents txt_senha As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents btn_cadastrar As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents btn_entrar As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents lbl_rsenha As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
