<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_explorar
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
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_explorar))
        Me.elipseBackground = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lbl_times = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lbl_data_horario = New Bunifu.UI.WinForms.BunifuLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.img_time_casa = New System.Windows.Forms.PictureBox()
        Me.btn_comprar = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.img_time_visitante = New System.Windows.Forms.PictureBox()
        Me.btn_prox_jogo = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btn_jogo_anterior = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuGradientPanel1 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuPanel3 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.lbl_time_casa = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuPanel4 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.lbl_time_visitante = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuPanel2 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.BunifuPanel1 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.lbl_nome_campeonato = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuPanel5 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.lbl_data = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuPanel6 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.lbl_estadio = New Bunifu.UI.WinForms.BunifuLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_time_casa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_time_visitante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.BunifuPanel3.SuspendLayout()
        Me.BunifuPanel4.SuspendLayout()
        Me.BunifuPanel2.SuspendLayout()
        Me.BunifuPanel1.SuspendLayout()
        Me.BunifuPanel5.SuspendLayout()
        Me.BunifuPanel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'elipseBackground
        '
        Me.elipseBackground.ElipseRadius = 20
        Me.elipseBackground.TargetControl = Me
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.Black
        Me.BunifuLabel1.Location = New System.Drawing.Point(366, 164)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(64, 108)
        Me.BunifuLabel1.TabIndex = 12
        Me.BunifuLabel1.Text = "X"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'lbl_times
        '
        Me.lbl_times.AllowParentOverrides = False
        Me.lbl_times.AutoEllipsis = False
        Me.lbl_times.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_times.CursorType = System.Windows.Forms.Cursors.Default
        Me.lbl_times.Font = New System.Drawing.Font("Impact", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_times.ForeColor = System.Drawing.Color.Black
        Me.lbl_times.Location = New System.Drawing.Point(247, 70)
        Me.lbl_times.Name = "lbl_times"
        Me.lbl_times.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_times.Size = New System.Drawing.Size(150, 41)
        Me.lbl_times.TabIndex = 9
        Me.lbl_times.Text = "TIME x TIME"
        Me.lbl_times.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lbl_times.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'lbl_data_horario
        '
        Me.lbl_data_horario.AllowParentOverrides = False
        Me.lbl_data_horario.AutoEllipsis = False
        Me.lbl_data_horario.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_data_horario.CursorType = System.Windows.Forms.Cursors.Default
        Me.lbl_data_horario.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data_horario.ForeColor = System.Drawing.Color.Black
        Me.lbl_data_horario.Location = New System.Drawing.Point(204, 344)
        Me.lbl_data_horario.Name = "lbl_data_horario"
        Me.lbl_data_horario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_data_horario.Size = New System.Drawing.Size(161, 41)
        Me.lbl_data_horario.TabIndex = 13
        Me.lbl_data_horario.Text = "TIME x TIME"
        Me.lbl_data_horario.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lbl_data_horario.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.prj_si_2022_2S.My.Resources.Resources.icons8_esquerda_25
        Me.PictureBox1.Location = New System.Drawing.Point(835, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 29)
        Me.PictureBox1.TabIndex = 89
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.prj_si_2022_2S.My.Resources.Resources.icons8_xbox_x_35
        Me.PictureBox2.Location = New System.Drawing.Point(868, 29)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 45)
        Me.PictureBox2.TabIndex = 87
        Me.PictureBox2.TabStop = False
        '
        'img_time_casa
        '
        Me.img_time_casa.BackColor = System.Drawing.Color.Transparent
        Me.img_time_casa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.img_time_casa.Image = Global.prj_si_2022_2S.My.Resources.Resources.nova_foto
        Me.img_time_casa.Location = New System.Drawing.Point(189, 186)
        Me.img_time_casa.Name = "img_time_casa"
        Me.img_time_casa.Size = New System.Drawing.Size(197, 198)
        Me.img_time_casa.TabIndex = 10
        Me.img_time_casa.TabStop = False
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
        Me.btn_comprar.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.btn_comprar.CustomizableEdges = BorderEdges2
        Me.btn_comprar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_comprar.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_comprar.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_comprar.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_comprar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btn_comprar.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_comprar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
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
        Me.btn_comprar.Location = New System.Drawing.Point(399, 474)
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
        Me.btn_comprar.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
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
        Me.btn_comprar.Size = New System.Drawing.Size(148, 61)
        Me.btn_comprar.TabIndex = 10
        Me.btn_comprar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_comprar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_comprar.TextMarginLeft = 0
        Me.btn_comprar.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btn_comprar.UseDefaultRadiusAndThickness = True
        '
        'img_time_visitante
        '
        Me.img_time_visitante.BackColor = System.Drawing.Color.Transparent
        Me.img_time_visitante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.img_time_visitante.Image = Global.prj_si_2022_2S.My.Resources.Resources.nova_foto
        Me.img_time_visitante.Location = New System.Drawing.Point(571, 186)
        Me.img_time_visitante.Name = "img_time_visitante"
        Me.img_time_visitante.Size = New System.Drawing.Size(197, 198)
        Me.img_time_visitante.TabIndex = 11
        Me.img_time_visitante.TabStop = False
        '
        'btn_prox_jogo
        '
        Me.btn_prox_jogo.AllowAnimations = True
        Me.btn_prox_jogo.AllowMouseEffects = True
        Me.btn_prox_jogo.AllowToggling = False
        Me.btn_prox_jogo.AnimationSpeed = 200
        Me.btn_prox_jogo.AutoGenerateColors = False
        Me.btn_prox_jogo.AutoRoundBorders = False
        Me.btn_prox_jogo.AutoSizeLeftIcon = True
        Me.btn_prox_jogo.AutoSizeRightIcon = True
        Me.btn_prox_jogo.BackColor = System.Drawing.Color.Transparent
        Me.btn_prox_jogo.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_prox_jogo.BackgroundImage = CType(resources.GetObject("btn_prox_jogo.BackgroundImage"), System.Drawing.Image)
        Me.btn_prox_jogo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_prox_jogo.ButtonText = ">"
        Me.btn_prox_jogo.ButtonTextMarginLeft = 0
        Me.btn_prox_jogo.ColorContrastOnClick = 45
        Me.btn_prox_jogo.ColorContrastOnHover = 45
        Me.btn_prox_jogo.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.btn_prox_jogo.CustomizableEdges = BorderEdges1
        Me.btn_prox_jogo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_prox_jogo.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_prox_jogo.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_prox_jogo.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_prox_jogo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btn_prox_jogo.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_prox_jogo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_prox_jogo.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_prox_jogo.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btn_prox_jogo.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btn_prox_jogo.IconMarginLeft = 11
        Me.btn_prox_jogo.IconPadding = 10
        Me.btn_prox_jogo.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_prox_jogo.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btn_prox_jogo.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btn_prox_jogo.IconSize = 25
        Me.btn_prox_jogo.IdleBorderColor = System.Drawing.Color.Transparent
        Me.btn_prox_jogo.IdleBorderRadius = 20
        Me.btn_prox_jogo.IdleBorderThickness = 2
        Me.btn_prox_jogo.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_prox_jogo.IdleIconLeftImage = Nothing
        Me.btn_prox_jogo.IdleIconRightImage = Nothing
        Me.btn_prox_jogo.IndicateFocus = False
        Me.btn_prox_jogo.Location = New System.Drawing.Point(843, 239)
        Me.btn_prox_jogo.Name = "btn_prox_jogo"
        Me.btn_prox_jogo.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_prox_jogo.OnDisabledState.BorderRadius = 20
        Me.btn_prox_jogo.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_prox_jogo.OnDisabledState.BorderThickness = 2
        Me.btn_prox_jogo.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_prox_jogo.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_prox_jogo.OnDisabledState.IconLeftImage = Nothing
        Me.btn_prox_jogo.OnDisabledState.IconRightImage = Nothing
        Me.btn_prox_jogo.onHoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_prox_jogo.onHoverState.BorderRadius = 20
        Me.btn_prox_jogo.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_prox_jogo.onHoverState.BorderThickness = 2
        Me.btn_prox_jogo.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_prox_jogo.onHoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_prox_jogo.onHoverState.IconLeftImage = Nothing
        Me.btn_prox_jogo.onHoverState.IconRightImage = Nothing
        Me.btn_prox_jogo.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_prox_jogo.OnIdleState.BorderRadius = 20
        Me.btn_prox_jogo.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_prox_jogo.OnIdleState.BorderThickness = 2
        Me.btn_prox_jogo.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_prox_jogo.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_prox_jogo.OnIdleState.IconLeftImage = Nothing
        Me.btn_prox_jogo.OnIdleState.IconRightImage = Nothing
        Me.btn_prox_jogo.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_prox_jogo.OnPressedState.BorderRadius = 20
        Me.btn_prox_jogo.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_prox_jogo.OnPressedState.BorderThickness = 2
        Me.btn_prox_jogo.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_prox_jogo.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_prox_jogo.OnPressedState.IconLeftImage = Nothing
        Me.btn_prox_jogo.OnPressedState.IconRightImage = Nothing
        Me.btn_prox_jogo.Size = New System.Drawing.Size(59, 51)
        Me.btn_prox_jogo.TabIndex = 10
        Me.btn_prox_jogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_prox_jogo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_prox_jogo.TextMarginLeft = 0
        Me.btn_prox_jogo.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btn_prox_jogo.UseDefaultRadiusAndThickness = True
        '
        'btn_jogo_anterior
        '
        Me.btn_jogo_anterior.AllowAnimations = True
        Me.btn_jogo_anterior.AllowMouseEffects = True
        Me.btn_jogo_anterior.AllowToggling = False
        Me.btn_jogo_anterior.AnimationSpeed = 200
        Me.btn_jogo_anterior.AutoGenerateColors = False
        Me.btn_jogo_anterior.AutoRoundBorders = False
        Me.btn_jogo_anterior.AutoSizeLeftIcon = True
        Me.btn_jogo_anterior.AutoSizeRightIcon = True
        Me.btn_jogo_anterior.BackColor = System.Drawing.Color.Transparent
        Me.btn_jogo_anterior.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_jogo_anterior.BackgroundImage = CType(resources.GetObject("btn_jogo_anterior.BackgroundImage"), System.Drawing.Image)
        Me.btn_jogo_anterior.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_jogo_anterior.ButtonText = "<"
        Me.btn_jogo_anterior.ButtonTextMarginLeft = 0
        Me.btn_jogo_anterior.ColorContrastOnClick = 45
        Me.btn_jogo_anterior.ColorContrastOnHover = 45
        Me.btn_jogo_anterior.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges3.BottomLeft = True
        BorderEdges3.BottomRight = True
        BorderEdges3.TopLeft = True
        BorderEdges3.TopRight = True
        Me.btn_jogo_anterior.CustomizableEdges = BorderEdges3
        Me.btn_jogo_anterior.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_jogo_anterior.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_jogo_anterior.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_jogo_anterior.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_jogo_anterior.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btn_jogo_anterior.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_jogo_anterior.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_jogo_anterior.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_jogo_anterior.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btn_jogo_anterior.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btn_jogo_anterior.IconMarginLeft = 11
        Me.btn_jogo_anterior.IconPadding = 10
        Me.btn_jogo_anterior.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_jogo_anterior.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btn_jogo_anterior.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btn_jogo_anterior.IconSize = 25
        Me.btn_jogo_anterior.IdleBorderColor = System.Drawing.Color.Transparent
        Me.btn_jogo_anterior.IdleBorderRadius = 20
        Me.btn_jogo_anterior.IdleBorderThickness = 2
        Me.btn_jogo_anterior.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_jogo_anterior.IdleIconLeftImage = Nothing
        Me.btn_jogo_anterior.IdleIconRightImage = Nothing
        Me.btn_jogo_anterior.IndicateFocus = False
        Me.btn_jogo_anterior.Location = New System.Drawing.Point(32, 239)
        Me.btn_jogo_anterior.Name = "btn_jogo_anterior"
        Me.btn_jogo_anterior.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_jogo_anterior.OnDisabledState.BorderRadius = 20
        Me.btn_jogo_anterior.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_jogo_anterior.OnDisabledState.BorderThickness = 2
        Me.btn_jogo_anterior.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_jogo_anterior.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_jogo_anterior.OnDisabledState.IconLeftImage = Nothing
        Me.btn_jogo_anterior.OnDisabledState.IconRightImage = Nothing
        Me.btn_jogo_anterior.onHoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_jogo_anterior.onHoverState.BorderRadius = 20
        Me.btn_jogo_anterior.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_jogo_anterior.onHoverState.BorderThickness = 2
        Me.btn_jogo_anterior.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_jogo_anterior.onHoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_jogo_anterior.onHoverState.IconLeftImage = Nothing
        Me.btn_jogo_anterior.onHoverState.IconRightImage = Nothing
        Me.btn_jogo_anterior.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_jogo_anterior.OnIdleState.BorderRadius = 20
        Me.btn_jogo_anterior.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_jogo_anterior.OnIdleState.BorderThickness = 2
        Me.btn_jogo_anterior.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_jogo_anterior.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_jogo_anterior.OnIdleState.IconLeftImage = Nothing
        Me.btn_jogo_anterior.OnIdleState.IconRightImage = Nothing
        Me.btn_jogo_anterior.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_jogo_anterior.OnPressedState.BorderRadius = 20
        Me.btn_jogo_anterior.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_jogo_anterior.OnPressedState.BorderThickness = 2
        Me.btn_jogo_anterior.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_jogo_anterior.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_jogo_anterior.OnPressedState.IconLeftImage = Nothing
        Me.btn_jogo_anterior.OnPressedState.IconRightImage = Nothing
        Me.btn_jogo_anterior.Size = New System.Drawing.Size(59, 51)
        Me.btn_jogo_anterior.TabIndex = 11
        Me.btn_jogo_anterior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_jogo_anterior.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_jogo_anterior.TextMarginLeft = 0
        Me.btn_jogo_anterior.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btn_jogo_anterior.UseDefaultRadiusAndThickness = True
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.BorderRadius = 1
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuPanel6)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuPanel5)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuPanel1)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuPanel4)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuPanel3)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox2)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.BunifuGradientPanel1.Controls.Add(Me.btn_prox_jogo)
        Me.BunifuGradientPanel1.Controls.Add(Me.img_time_visitante)
        Me.BunifuGradientPanel1.Controls.Add(Me.img_time_casa)
        Me.BunifuGradientPanel1.Controls.Add(Me.btn_comprar)
        Me.BunifuGradientPanel1.Controls.Add(Me.btn_jogo_anterior)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuPanel2)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(-2, -5)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(929, 576)
        Me.BunifuGradientPanel1.TabIndex = 90
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.Font = New System.Drawing.Font("Segoe UI Black", 60.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuLabel2.Location = New System.Drawing.Point(16, -12)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(56, 106)
        Me.BunifuLabel2.TabIndex = 91
        Me.BunifuLabel2.Text = "X"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuPanel3
        '
        Me.BunifuPanel3.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuPanel3.BackgroundImage = CType(resources.GetObject("BunifuPanel3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuPanel3.BorderRadius = 20
        Me.BunifuPanel3.BorderThickness = 2
        Me.BunifuPanel3.Controls.Add(Me.lbl_time_casa)
        Me.BunifuPanel3.Location = New System.Drawing.Point(168, 123)
        Me.BunifuPanel3.Name = "BunifuPanel3"
        Me.BunifuPanel3.ShowBorders = True
        Me.BunifuPanel3.Size = New System.Drawing.Size(237, 57)
        Me.BunifuPanel3.TabIndex = 91
        '
        'lbl_time_casa
        '
        Me.lbl_time_casa.AllowParentOverrides = False
        Me.lbl_time_casa.AutoEllipsis = False
        Me.lbl_time_casa.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_time_casa.CursorType = System.Windows.Forms.Cursors.Default
        Me.lbl_time_casa.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_time_casa.ForeColor = System.Drawing.Color.Black
        Me.lbl_time_casa.Location = New System.Drawing.Point(21, 11)
        Me.lbl_time_casa.Name = "lbl_time_casa"
        Me.lbl_time_casa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_time_casa.Size = New System.Drawing.Size(115, 32)
        Me.lbl_time_casa.TabIndex = 0
        Me.lbl_time_casa.Text = "Time Casa"
        Me.lbl_time_casa.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lbl_time_casa.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuPanel4
        '
        Me.BunifuPanel4.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuPanel4.BackgroundImage = CType(resources.GetObject("BunifuPanel4.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuPanel4.BorderRadius = 20
        Me.BunifuPanel4.BorderThickness = 2
        Me.BunifuPanel4.Controls.Add(Me.lbl_time_visitante)
        Me.BunifuPanel4.Location = New System.Drawing.Point(551, 123)
        Me.BunifuPanel4.Name = "BunifuPanel4"
        Me.BunifuPanel4.ShowBorders = True
        Me.BunifuPanel4.Size = New System.Drawing.Size(237, 57)
        Me.BunifuPanel4.TabIndex = 92
        '
        'lbl_time_visitante
        '
        Me.lbl_time_visitante.AllowParentOverrides = False
        Me.lbl_time_visitante.AutoEllipsis = False
        Me.lbl_time_visitante.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_time_visitante.CursorType = System.Windows.Forms.Cursors.Default
        Me.lbl_time_visitante.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_time_visitante.ForeColor = System.Drawing.Color.Black
        Me.lbl_time_visitante.Location = New System.Drawing.Point(20, 11)
        Me.lbl_time_visitante.Name = "lbl_time_visitante"
        Me.lbl_time_visitante.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_time_visitante.Size = New System.Drawing.Size(163, 32)
        Me.lbl_time_visitante.TabIndex = 0
        Me.lbl_time_visitante.Text = "Time Visitante"
        Me.lbl_time_visitante.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lbl_time_visitante.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuPanel2
        '
        Me.BunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuPanel2.BackgroundImage = CType(resources.GetObject("BunifuPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel2.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuPanel2.BorderRadius = 20
        Me.BunifuPanel2.BorderThickness = 1
        Me.BunifuPanel2.Controls.Add(Me.BunifuLabel2)
        Me.BunifuPanel2.Location = New System.Drawing.Point(438, 239)
        Me.BunifuPanel2.Name = "BunifuPanel2"
        Me.BunifuPanel2.ShowBorders = True
        Me.BunifuPanel2.Size = New System.Drawing.Size(86, 90)
        Me.BunifuPanel2.TabIndex = 91
        '
        'BunifuPanel1
        '
        Me.BunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuPanel1.BackgroundImage = CType(resources.GetObject("BunifuPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel1.BorderColor = System.Drawing.Color.Red
        Me.BunifuPanel1.BorderRadius = 20
        Me.BunifuPanel1.BorderThickness = 2
        Me.BunifuPanel1.Controls.Add(Me.lbl_nome_campeonato)
        Me.BunifuPanel1.Location = New System.Drawing.Point(292, 60)
        Me.BunifuPanel1.Name = "BunifuPanel1"
        Me.BunifuPanel1.ShowBorders = True
        Me.BunifuPanel1.Size = New System.Drawing.Size(359, 57)
        Me.BunifuPanel1.TabIndex = 92
        '
        'lbl_nome_campeonato
        '
        Me.lbl_nome_campeonato.AllowParentOverrides = False
        Me.lbl_nome_campeonato.AutoEllipsis = False
        Me.lbl_nome_campeonato.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_nome_campeonato.CursorType = System.Windows.Forms.Cursors.Default
        Me.lbl_nome_campeonato.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_nome_campeonato.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_nome_campeonato.Location = New System.Drawing.Point(102, 13)
        Me.lbl_nome_campeonato.Name = "lbl_nome_campeonato"
        Me.lbl_nome_campeonato.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_nome_campeonato.Size = New System.Drawing.Size(145, 32)
        Me.lbl_nome_campeonato.TabIndex = 0
        Me.lbl_nome_campeonato.Text = "Campeonato"
        Me.lbl_nome_campeonato.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lbl_nome_campeonato.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuPanel5
        '
        Me.BunifuPanel5.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuPanel5.BackgroundImage = CType(resources.GetObject("BunifuPanel5.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuPanel5.BorderRadius = 20
        Me.BunifuPanel5.BorderThickness = 1
        Me.BunifuPanel5.Controls.Add(Me.lbl_data)
        Me.BunifuPanel5.Location = New System.Drawing.Point(168, 399)
        Me.BunifuPanel5.Name = "BunifuPanel5"
        Me.BunifuPanel5.ShowBorders = True
        Me.BunifuPanel5.Size = New System.Drawing.Size(620, 57)
        Me.BunifuPanel5.TabIndex = 93
        '
        'lbl_data
        '
        Me.lbl_data.AllowParentOverrides = False
        Me.lbl_data.AutoEllipsis = False
        Me.lbl_data.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_data.CursorType = System.Windows.Forms.Cursors.Default
        Me.lbl_data.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_data.ForeColor = System.Drawing.Color.Black
        Me.lbl_data.Location = New System.Drawing.Point(159, 13)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_data.Size = New System.Drawing.Size(53, 32)
        Me.lbl_data.TabIndex = 0
        Me.lbl_data.Text = "Data"
        Me.lbl_data.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lbl_data.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuPanel6
        '
        Me.BunifuPanel6.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuPanel6.BackgroundImage = CType(resources.GetObject("BunifuPanel6.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel6.BorderColor = System.Drawing.Color.Red
        Me.BunifuPanel6.BorderRadius = 20
        Me.BunifuPanel6.BorderThickness = 2
        Me.BunifuPanel6.Controls.Add(Me.lbl_estadio)
        Me.BunifuPanel6.Location = New System.Drawing.Point(399, 339)
        Me.BunifuPanel6.Name = "BunifuPanel6"
        Me.BunifuPanel6.ShowBorders = True
        Me.BunifuPanel6.Size = New System.Drawing.Size(166, 45)
        Me.BunifuPanel6.TabIndex = 94
        '
        'lbl_estadio
        '
        Me.lbl_estadio.AllowParentOverrides = False
        Me.lbl_estadio.AutoEllipsis = False
        Me.lbl_estadio.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_estadio.CursorType = System.Windows.Forms.Cursors.Default
        Me.lbl_estadio.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_estadio.ForeColor = System.Drawing.Color.Black
        Me.lbl_estadio.Location = New System.Drawing.Point(23, 10)
        Me.lbl_estadio.Name = "lbl_estadio"
        Me.lbl_estadio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_estadio.Size = New System.Drawing.Size(64, 25)
        Me.lbl_estadio.TabIndex = 0
        Me.lbl_estadio.Text = "Estádio"
        Me.lbl_estadio.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lbl_estadio.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'frm_explorar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 567)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_explorar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_explorar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_time_casa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_time_visitante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuPanel3.ResumeLayout(False)
        Me.BunifuPanel3.PerformLayout()
        Me.BunifuPanel4.ResumeLayout(False)
        Me.BunifuPanel4.PerformLayout()
        Me.BunifuPanel2.ResumeLayout(False)
        Me.BunifuPanel2.PerformLayout()
        Me.BunifuPanel1.ResumeLayout(False)
        Me.BunifuPanel1.PerformLayout()
        Me.BunifuPanel5.ResumeLayout(False)
        Me.BunifuPanel5.PerformLayout()
        Me.BunifuPanel6.ResumeLayout(False)
        Me.BunifuPanel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents elipseBackground As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents img_time_casa As PictureBox
    Friend WithEvents btn_comprar As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents img_time_visitante As PictureBox
    Friend WithEvents btn_prox_jogo As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents btn_jogo_anterior As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lbl_times As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lbl_data_horario As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuPanel4 As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents lbl_time_visitante As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuPanel3 As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents lbl_time_casa As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuPanel2 As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents BunifuPanel1 As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents lbl_nome_campeonato As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuPanel5 As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents lbl_data As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuPanel6 As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents lbl_estadio As Bunifu.UI.WinForms.BunifuLabel
End Class
