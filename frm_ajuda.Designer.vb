<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ajuda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ajuda))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties7 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties8 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Me.elipseBackground = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuGradientPanel1 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.btn_enviar = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuSeparator2 = New Bunifu.UI.WinForms.BunifuSeparator()
        Me.txt_problema = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.txt_email = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BunifuGradientPanel1.Controls.Add(Me.btn_enviar)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuSeparator2)
        Me.BunifuGradientPanel1.Controls.Add(Me.txt_problema)
        Me.BunifuGradientPanel1.Controls.Add(Me.txt_email)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuLabel2)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox3)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox2)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(-1, -2)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(582, 395)
        Me.BunifuGradientPanel1.TabIndex = 5
        '
        'btn_enviar
        '
        Me.btn_enviar.AllowAnimations = True
        Me.btn_enviar.AllowMouseEffects = True
        Me.btn_enviar.AllowToggling = False
        Me.btn_enviar.AnimationSpeed = 200
        Me.btn_enviar.AutoGenerateColors = False
        Me.btn_enviar.AutoRoundBorders = False
        Me.btn_enviar.AutoSizeLeftIcon = True
        Me.btn_enviar.AutoSizeRightIcon = True
        Me.btn_enviar.BackColor = System.Drawing.Color.Transparent
        Me.btn_enviar.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_enviar.BackgroundImage = CType(resources.GetObject("btn_enviar.BackgroundImage"), System.Drawing.Image)
        Me.btn_enviar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_enviar.ButtonText = "ENVIAR"
        Me.btn_enviar.ButtonTextMarginLeft = 0
        Me.btn_enviar.ColorContrastOnClick = 45
        Me.btn_enviar.ColorContrastOnHover = 45
        Me.btn_enviar.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.btn_enviar.CustomizableEdges = BorderEdges1
        Me.btn_enviar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_enviar.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_enviar.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_enviar.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_enviar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btn_enviar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enviar.ForeColor = System.Drawing.Color.Black
        Me.btn_enviar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_enviar.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btn_enviar.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btn_enviar.IconMarginLeft = 11
        Me.btn_enviar.IconPadding = 10
        Me.btn_enviar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_enviar.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btn_enviar.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btn_enviar.IconSize = 25
        Me.btn_enviar.IdleBorderColor = System.Drawing.Color.Transparent
        Me.btn_enviar.IdleBorderRadius = 20
        Me.btn_enviar.IdleBorderThickness = 2
        Me.btn_enviar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_enviar.IdleIconLeftImage = Nothing
        Me.btn_enviar.IdleIconRightImage = Nothing
        Me.btn_enviar.IndicateFocus = False
        Me.btn_enviar.Location = New System.Drawing.Point(281, 289)
        Me.btn_enviar.Name = "btn_enviar"
        Me.btn_enviar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_enviar.OnDisabledState.BorderRadius = 20
        Me.btn_enviar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_enviar.OnDisabledState.BorderThickness = 2
        Me.btn_enviar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_enviar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_enviar.OnDisabledState.IconLeftImage = Nothing
        Me.btn_enviar.OnDisabledState.IconRightImage = Nothing
        Me.btn_enviar.onHoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_enviar.onHoverState.BorderRadius = 20
        Me.btn_enviar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_enviar.onHoverState.BorderThickness = 2
        Me.btn_enviar.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_enviar.onHoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_enviar.onHoverState.IconLeftImage = Nothing
        Me.btn_enviar.onHoverState.IconRightImage = Nothing
        Me.btn_enviar.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_enviar.OnIdleState.BorderRadius = 20
        Me.btn_enviar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_enviar.OnIdleState.BorderThickness = 2
        Me.btn_enviar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_enviar.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.btn_enviar.OnIdleState.IconLeftImage = Nothing
        Me.btn_enviar.OnIdleState.IconRightImage = Nothing
        Me.btn_enviar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_enviar.OnPressedState.BorderRadius = 20
        Me.btn_enviar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btn_enviar.OnPressedState.BorderThickness = 2
        Me.btn_enviar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_enviar.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_enviar.OnPressedState.IconLeftImage = Nothing
        Me.btn_enviar.OnPressedState.IconRightImage = Nothing
        Me.btn_enviar.Size = New System.Drawing.Size(150, 39)
        Me.btn_enviar.TabIndex = 108
        Me.btn_enviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_enviar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_enviar.TextMarginLeft = 0
        Me.btn_enviar.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btn_enviar.UseDefaultRadiusAndThickness = True
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.BackgroundImage = CType(resources.GetObject("BunifuSeparator2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(126, 119)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal
        Me.BunifuSeparator2.Size = New System.Drawing.Size(282, 14)
        Me.BunifuSeparator2.TabIndex = 107
        '
        'txt_problema
        '
        Me.txt_problema.AcceptsReturn = False
        Me.txt_problema.AcceptsTab = False
        Me.txt_problema.AnimationSpeed = 200
        Me.txt_problema.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txt_problema.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txt_problema.BackColor = System.Drawing.Color.White
        Me.txt_problema.BackgroundImage = CType(resources.GetObject("txt_problema.BackgroundImage"), System.Drawing.Image)
        Me.txt_problema.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_problema.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txt_problema.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_problema.BorderColorIdle = System.Drawing.Color.Black
        Me.txt_problema.BorderRadius = 1
        Me.txt_problema.BorderThickness = 1
        Me.txt_problema.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txt_problema.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_problema.DefaultFont = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_problema.DefaultText = ""
        Me.txt_problema.FillColor = System.Drawing.Color.White
        Me.txt_problema.HideSelection = True
        Me.txt_problema.IconLeft = Nothing
        Me.txt_problema.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_problema.IconPadding = 10
        Me.txt_problema.IconRight = Nothing
        Me.txt_problema.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_problema.Lines = New String(-1) {}
        Me.txt_problema.Location = New System.Drawing.Point(109, 193)
        Me.txt_problema.MaxLength = 32767
        Me.txt_problema.MinimumSize = New System.Drawing.Size(1, 1)
        Me.txt_problema.Modified = False
        Me.txt_problema.Multiline = False
        Me.txt_problema.Name = "txt_problema"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txt_problema.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txt_problema.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txt_problema.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Black
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Empty
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txt_problema.OnIdleState = StateProperties4
        Me.txt_problema.Padding = New System.Windows.Forms.Padding(3)
        Me.txt_problema.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_problema.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txt_problema.PlaceholderText = "Relate o problema"
        Me.txt_problema.ReadOnly = False
        Me.txt_problema.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_problema.SelectedText = ""
        Me.txt_problema.SelectionLength = 0
        Me.txt_problema.SelectionStart = 0
        Me.txt_problema.ShortcutsEnabled = True
        Me.txt_problema.Size = New System.Drawing.Size(322, 79)
        Me.txt_problema.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material
        Me.txt_problema.TabIndex = 91
        Me.txt_problema.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_problema.TextMarginBottom = 0
        Me.txt_problema.TextMarginLeft = 3
        Me.txt_problema.TextMarginTop = 0
        Me.txt_problema.TextPlaceholder = "Relate o problema"
        Me.txt_problema.UseSystemPasswordChar = False
        Me.txt_problema.WordWrap = True
        '
        'txt_email
        '
        Me.txt_email.AcceptsReturn = False
        Me.txt_email.AcceptsTab = False
        Me.txt_email.AnimationSpeed = 200
        Me.txt_email.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txt_email.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txt_email.BackColor = System.Drawing.Color.White
        Me.txt_email.BackgroundImage = CType(resources.GetObject("txt_email.BackgroundImage"), System.Drawing.Image)
        Me.txt_email.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_email.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txt_email.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_email.BorderColorIdle = System.Drawing.Color.Black
        Me.txt_email.BorderRadius = 1
        Me.txt_email.BorderThickness = 1
        Me.txt_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_email.DefaultFont = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.DefaultText = ""
        Me.txt_email.FillColor = System.Drawing.Color.White
        Me.txt_email.HideSelection = True
        Me.txt_email.IconLeft = Nothing
        Me.txt_email.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_email.IconPadding = 10
        Me.txt_email.IconRight = Nothing
        Me.txt_email.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_email.Lines = New String(-1) {}
        Me.txt_email.Location = New System.Drawing.Point(109, 149)
        Me.txt_email.MaxLength = 32767
        Me.txt_email.MinimumSize = New System.Drawing.Size(1, 1)
        Me.txt_email.Modified = False
        Me.txt_email.Multiline = False
        Me.txt_email.Name = "txt_email"
        StateProperties5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        StateProperties5.FillColor = System.Drawing.Color.Empty
        StateProperties5.ForeColor = System.Drawing.Color.Empty
        StateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txt_email.OnActiveState = StateProperties5
        StateProperties6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties6.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txt_email.OnDisabledState = StateProperties6
        StateProperties7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties7.FillColor = System.Drawing.Color.Empty
        StateProperties7.ForeColor = System.Drawing.Color.Empty
        StateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txt_email.OnHoverState = StateProperties7
        StateProperties8.BorderColor = System.Drawing.Color.Black
        StateProperties8.FillColor = System.Drawing.Color.White
        StateProperties8.ForeColor = System.Drawing.Color.Empty
        StateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txt_email.OnIdleState = StateProperties8
        Me.txt_email.Padding = New System.Windows.Forms.Padding(3)
        Me.txt_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_email.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txt_email.PlaceholderText = "Digite seu email"
        Me.txt_email.ReadOnly = False
        Me.txt_email.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_email.SelectedText = ""
        Me.txt_email.SelectionLength = 0
        Me.txt_email.SelectionStart = 0
        Me.txt_email.ShortcutsEnabled = True
        Me.txt_email.Size = New System.Drawing.Size(322, 29)
        Me.txt_email.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material
        Me.txt_email.TabIndex = 90
        Me.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_email.TextMarginBottom = 0
        Me.txt_email.TextMarginLeft = 3
        Me.txt_email.TextMarginTop = 0
        Me.txt_email.TextPlaceholder = "Digite seu email"
        Me.txt_email.UseSystemPasswordChar = False
        Me.txt_email.WordWrap = True
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuLabel2.ForeColor = System.Drawing.Color.Black
        Me.BunifuLabel2.Location = New System.Drawing.Point(126, 17)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(280, 103)
        Me.BunifuLabel2.TabIndex = 89
        Me.BunifuLabel2.Text = "COMO PODEMOS " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         AJUDAR?"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.prj_si_2022_2S.My.Resources.Resources.icons8_xbox_x_35
        Me.PictureBox3.Location = New System.Drawing.Point(527, 17)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 45)
        Me.PictureBox3.TabIndex = 87
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.prj_si_2022_2S.My.Resources.Resources.icons8_esquerda_25
        Me.PictureBox1.Location = New System.Drawing.Point(493, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 29)
        Me.PictureBox1.TabIndex = 86
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.prj_si_2022_2S.My.Resources.Resources.icons8_macos_close_30
        Me.PictureBox2.Location = New System.Drawing.Point(764, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 45)
        Me.PictureBox2.TabIndex = 85
        Me.PictureBox2.TabStop = False
        '
        'frm_ajuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 377)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_ajuda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents elipseBackground As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuGradientPanel1 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents txt_problema As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents txt_email As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents BunifuSeparator2 As Bunifu.UI.WinForms.BunifuSeparator
    Friend WithEvents btn_enviar As Bunifu.UI.WinForms.BunifuButton.BunifuButton
End Class
