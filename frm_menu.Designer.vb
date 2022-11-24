<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MEUSINGRESSOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUPORTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.elipseBackground = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuGradientPanel1 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuButton1 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btn_entrar = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.lbl_nome = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuPanel1 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.BunifuSeparator1 = New Bunifu.UI.WinForms.BunifuSeparator()
        Me.lbl_boas_vindas = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuPanel2 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.MenuStrip1.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuPanel1.SuspendLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Chocolate
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MEUSINGRESSOSToolStripMenuItem, Me.SUPORTEToolStripMenuItem, Me.SAIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(770, 32)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MEUSINGRESSOSToolStripMenuItem
        '
        Me.MEUSINGRESSOSToolStripMenuItem.Image = Global.prj_si_2022_2S.My.Resources.Resources.icons8_carrinho_de_compras_30
        Me.MEUSINGRESSOSToolStripMenuItem.Name = "MEUSINGRESSOSToolStripMenuItem"
        Me.MEUSINGRESSOSToolStripMenuItem.Size = New System.Drawing.Size(137, 28)
        Me.MEUSINGRESSOSToolStripMenuItem.Text = "MEUS INGRESSOS"
        '
        'SUPORTEToolStripMenuItem
        '
        Me.SUPORTEToolStripMenuItem.Image = Global.prj_si_2022_2S.My.Resources.Resources.icons8_suporte_ao_cliente_24
        Me.SUPORTEToolStripMenuItem.Name = "SUPORTEToolStripMenuItem"
        Me.SUPORTEToolStripMenuItem.Size = New System.Drawing.Size(150, 28)
        Me.SUPORTEToolStripMenuItem.Text = "PRECISA DE AJUDA?"
        '
        'SAIRToolStripMenuItem
        '
        Me.SAIRToolStripMenuItem.Image = Global.prj_si_2022_2S.My.Resources.Resources.icons8_saída_de_emergência_24
        Me.SAIRToolStripMenuItem.Name = "SAIRToolStripMenuItem"
        Me.SAIRToolStripMenuItem.Size = New System.Drawing.Size(89, 28)
        Me.SAIRToolStripMenuItem.Text = "LOGOUT"
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
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuButton1)
        Me.BunifuGradientPanel1.Controls.Add(Me.btn_entrar)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuPanel1)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuSeparator1)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuPanel2)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(-11, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(783, 507)
        Me.BunifuGradientPanel1.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.prj_si_2022_2S.My.Resources.Resources.icons8_xbox_x_35
        Me.PictureBox2.Location = New System.Drawing.Point(723, 45)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 45)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'BunifuButton1
        '
        Me.BunifuButton1.AllowAnimations = True
        Me.BunifuButton1.AllowMouseEffects = True
        Me.BunifuButton1.AllowToggling = False
        Me.BunifuButton1.AnimationSpeed = 200
        Me.BunifuButton1.AutoGenerateColors = False
        Me.BunifuButton1.AutoRoundBorders = False
        Me.BunifuButton1.AutoSizeLeftIcon = True
        Me.BunifuButton1.AutoSizeRightIcon = True
        Me.BunifuButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuButton1.BackgroundImage = CType(resources.GetObject("BunifuButton1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.ButtonText = "MEU PERFIL"
        Me.BunifuButton1.ButtonTextMarginLeft = 0
        Me.BunifuButton1.ColorContrastOnClick = 45
        Me.BunifuButton1.ColorContrastOnHover = 45
        Me.BunifuButton1.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.BunifuButton1.CustomizableEdges = BorderEdges1
        Me.BunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuButton1.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton1.IconMarginLeft = 11
        Me.BunifuButton1.IconPadding = 10
        Me.BunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton1.IconSize = 25
        Me.BunifuButton1.IdleBorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.IdleBorderRadius = 20
        Me.BunifuButton1.IdleBorderThickness = 2
        Me.BunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuButton1.IdleIconLeftImage = Nothing
        Me.BunifuButton1.IdleIconRightImage = Nothing
        Me.BunifuButton1.IndicateFocus = False
        Me.BunifuButton1.Location = New System.Drawing.Point(62, 227)
        Me.BunifuButton1.Name = "BunifuButton1"
        Me.BunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.BorderRadius = 20
        Me.BunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnDisabledState.BorderThickness = 2
        Me.BunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton1.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton1.onHoverState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.onHoverState.BorderRadius = 20
        Me.BunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.onHoverState.BorderThickness = 2
        Me.BunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuButton1.onHoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuButton1.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton1.onHoverState.IconRightImage = Nothing
        Me.BunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.OnIdleState.BorderRadius = 20
        Me.BunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnIdleState.BorderThickness = 2
        Me.BunifuButton1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton1.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton1.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuButton1.OnPressedState.BorderRadius = 20
        Me.BunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnPressedState.BorderThickness = 2
        Me.BunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuButton1.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton1.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton1.Size = New System.Drawing.Size(194, 90)
        Me.BunifuButton1.TabIndex = 10
        Me.BunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton1.TextMarginLeft = 0
        Me.BunifuButton1.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton1.UseDefaultRadiusAndThickness = True
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
        Me.btn_entrar.ButtonText = "EXPLORAR"
        Me.btn_entrar.ButtonTextMarginLeft = 0
        Me.btn_entrar.ColorContrastOnClick = 45
        Me.btn_entrar.ColorContrastOnHover = 45
        Me.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.btn_entrar.CustomizableEdges = BorderEdges2
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
        Me.btn_entrar.Location = New System.Drawing.Point(62, 343)
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
        Me.btn_entrar.Size = New System.Drawing.Size(194, 90)
        Me.btn_entrar.TabIndex = 9
        Me.btn_entrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_entrar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_entrar.TextMarginLeft = 0
        Me.btn_entrar.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btn_entrar.UseDefaultRadiusAndThickness = True
        '
        'lbl_nome
        '
        Me.lbl_nome.AllowParentOverrides = False
        Me.lbl_nome.AutoEllipsis = False
        Me.lbl_nome.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_nome.CursorType = System.Windows.Forms.Cursors.Default
        Me.lbl_nome.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_nome.Location = New System.Drawing.Point(18, 35)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_nome.Size = New System.Drawing.Size(51, 25)
        Me.lbl_nome.TabIndex = 8
        Me.lbl_nome.Text = "nome"
        Me.lbl_nome.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lbl_nome.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuPanel1
        '
        Me.BunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuPanel1.BackgroundImage = CType(resources.GetObject("BunifuPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel1.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuPanel1.BorderRadius = 20
        Me.BunifuPanel1.BorderThickness = 1
        Me.BunifuPanel1.Controls.Add(Me.img_foto)
        Me.BunifuPanel1.Location = New System.Drawing.Point(376, 95)
        Me.BunifuPanel1.Name = "BunifuPanel1"
        Me.BunifuPanel1.ShowBorders = True
        Me.BunifuPanel1.Size = New System.Drawing.Size(309, 335)
        Me.BunifuPanel1.TabIndex = 7
        '
        'img_foto
        '
        Me.img_foto.BackgroundImage = Global.prj_si_2022_2S.My.Resources.Resources.nova_foto
        Me.img_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.img_foto.Location = New System.Drawing.Point(50, 38)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(212, 260)
        Me.img_foto.TabIndex = 5
        Me.img_foto.TabStop = False
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.BackgroundImage = CType(resources.GetObject("BunifuSeparator1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.Firebrick
        Me.BunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(80, 323)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal
        Me.BunifuSeparator1.Size = New System.Drawing.Size(149, 14)
        Me.BunifuSeparator1.TabIndex = 6
        '
        'lbl_boas_vindas
        '
        Me.lbl_boas_vindas.AllowParentOverrides = False
        Me.lbl_boas_vindas.AutoEllipsis = False
        Me.lbl_boas_vindas.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_boas_vindas.CursorType = System.Windows.Forms.Cursors.Default
        Me.lbl_boas_vindas.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_boas_vindas.Location = New System.Drawing.Point(18, 13)
        Me.lbl_boas_vindas.Name = "lbl_boas_vindas"
        Me.lbl_boas_vindas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_boas_vindas.Size = New System.Drawing.Size(195, 25)
        Me.lbl_boas_vindas.TabIndex = 0
        Me.lbl_boas_vindas.Text = "Bem vindo(a) de volta"
        Me.lbl_boas_vindas.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lbl_boas_vindas.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuPanel2
        '
        Me.BunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuPanel2.BackgroundImage = CType(resources.GetObject("BunifuPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel2.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuPanel2.BorderRadius = 20
        Me.BunifuPanel2.BorderThickness = 1
        Me.BunifuPanel2.Controls.Add(Me.lbl_boas_vindas)
        Me.BunifuPanel2.Controls.Add(Me.lbl_nome)
        Me.BunifuPanel2.Location = New System.Drawing.Point(62, 95)
        Me.BunifuPanel2.Name = "BunifuPanel2"
        Me.BunifuPanel2.ShowBorders = True
        Me.BunifuPanel2.Size = New System.Drawing.Size(270, 77)
        Me.BunifuPanel2.TabIndex = 8
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(770, 503)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PROJETO SI"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuPanel1.ResumeLayout(False)
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuPanel2.ResumeLayout(False)
        Me.BunifuPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SAIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BunifuGradientPanel1 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents elipseBackground As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lbl_boas_vindas As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents BunifuSeparator1 As Bunifu.UI.WinForms.BunifuSeparator
    Friend WithEvents BunifuPanel1 As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents lbl_nome As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuButton1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents btn_entrar As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MEUSINGRESSOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SUPORTEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BunifuPanel2 As Bunifu.UI.WinForms.BunifuPanel
End Class
