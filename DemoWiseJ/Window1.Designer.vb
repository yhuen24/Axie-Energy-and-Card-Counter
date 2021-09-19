<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnergyCounterApp
    Inherits Wisej.Web.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Wisej Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Wisej Designer
    'It can be modified using the Wisej Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnergyCounterApp))
        Me.Label1 = New Wisej.Web.Label()
        Me.energyText = New Wisej.Web.Label()
        Me.backBtn1 = New Wisej.Web.Button()
        Me.plusBtn = New Wisej.Web.Button()
        Me.minusBtn = New Wisej.Web.Button()
        Me.mouthBtn1 = New Wisej.Web.Button()
        Me.tailBtn1 = New Wisej.Web.Button()
        Me.hornBtn1 = New Wisej.Web.Button()
        Me.backCost1 = New Wisej.Web.CheckBox()
        Me.mouthCost1 = New Wisej.Web.CheckBox()
        Me.tailCost1 = New Wisej.Web.CheckBox()
        Me.hornCost1 = New Wisej.Web.CheckBox()
        Me.tailCost2 = New Wisej.Web.CheckBox()
        Me.hornCost2 = New Wisej.Web.CheckBox()
        Me.mouthCost2 = New Wisej.Web.CheckBox()
        Me.backCost2 = New Wisej.Web.CheckBox()
        Me.tailBtn2 = New Wisej.Web.Button()
        Me.hornBtn2 = New Wisej.Web.Button()
        Me.mouthBtn2 = New Wisej.Web.Button()
        Me.backBtn2 = New Wisej.Web.Button()
        Me.tailCost3 = New Wisej.Web.CheckBox()
        Me.hornCost3 = New Wisej.Web.CheckBox()
        Me.mouthCost3 = New Wisej.Web.CheckBox()
        Me.backCost3 = New Wisej.Web.CheckBox()
        Me.tailBtn3 = New Wisej.Web.Button()
        Me.hornBtn3 = New Wisej.Web.Button()
        Me.mouthBtn3 = New Wisej.Web.Button()
        Me.backBtn3 = New Wisej.Web.Button()
        Me.deadBtn1 = New Wisej.Web.Button()
        Me.deadBtn2 = New Wisej.Web.Button()
        Me.deadBtn3 = New Wisej.Web.Button()
        Me.Label2 = New Wisej.Web.Label()
        Me.Label3 = New Wisej.Web.Label()
        Me.Label4 = New Wisej.Web.Label()
        Me.Label5 = New Wisej.Web.Label()
        Me.backCount1 = New Wisej.Web.Label()
        Me.hornCount1 = New Wisej.Web.Label()
        Me.Label7 = New Wisej.Web.Label()
        Me.backCount2 = New Wisej.Web.Label()
        Me.Label9 = New Wisej.Web.Label()
        Me.hornCount2 = New Wisej.Web.Label()
        Me.Label11 = New Wisej.Web.Label()
        Me.hornCount3 = New Wisej.Web.Label()
        Me.Label13 = New Wisej.Web.Label()
        Me.backCount3 = New Wisej.Web.Label()
        Me.Label15 = New Wisej.Web.Label()
        Me.mouthCount1 = New Wisej.Web.Label()
        Me.Label17 = New Wisej.Web.Label()
        Me.tailCount1 = New Wisej.Web.Label()
        Me.Label19 = New Wisej.Web.Label()
        Me.tailCount2 = New Wisej.Web.Label()
        Me.Label21 = New Wisej.Web.Label()
        Me.mouthCount2 = New Wisej.Web.Label()
        Me.Label23 = New Wisej.Web.Label()
        Me.tailCount3 = New Wisej.Web.Label()
        Me.Label25 = New Wisej.Web.Label()
        Me.mouthCount3 = New Wisej.Web.Label()
        Me.Label27 = New Wisej.Web.Label()
        Me.mouthBtnMin1 = New Wisej.Web.Button()
        Me.backBtnMin1 = New Wisej.Web.Button()
        Me.hornBtnMin1 = New Wisej.Web.Button()
        Me.tailBtnMin1 = New Wisej.Web.Button()
        Me.hornBtnMin2 = New Wisej.Web.Button()
        Me.tailBtnMin2 = New Wisej.Web.Button()
        Me.backBtnMin2 = New Wisej.Web.Button()
        Me.mouthBtnMin2 = New Wisej.Web.Button()
        Me.hornBtnMin3 = New Wisej.Web.Button()
        Me.tailBtnMin3 = New Wisej.Web.Button()
        Me.backBtnMin3 = New Wisej.Web.Button()
        Me.mouthBtnMin3 = New Wisej.Web.Button()
        Me.Button3 = New Wisej.Web.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.Label1.Location = New System.Drawing.Point(6, 562)
        Me.Label1.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Energy:"
        '
        'energyText
        '
        Me.energyText.AutoSize = True
        Me.energyText.Font = New System.Drawing.Font("Helvetica", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.energyText.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.energyText.Location = New System.Drawing.Point(110, 562)
        Me.energyText.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.energyText.Name = "energyText"
        Me.energyText.Size = New System.Drawing.Size(18, 29)
        Me.energyText.TabIndex = 1
        Me.energyText.Text = "0"
        '
        'backBtn1
        '
        Me.backBtn1.AutoSize = True
        Me.backBtn1.BackColor = System.Drawing.Color.FromName("@buttonText")
        Me.backBtn1.BackgroundImage = CType(resources.GetObject("backBtn1.BackgroundImage"), System.Drawing.Image)
        Me.backBtn1.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        Me.backBtn1.Location = New System.Drawing.Point(30, 98)
        Me.backBtn1.Name = "backBtn1"
        Me.backBtn1.Size = New System.Drawing.Size(113, 116)
        Me.backBtn1.TabIndex = 2
        '
        'plusBtn
        '
        Me.plusBtn.AutoSize = True
        Me.plusBtn.BackColor = System.Drawing.Color.FromName("@buttonSelectedText")
        Me.plusBtn.BorderStyle = Wisej.Web.BorderStyle.[Double]
        Me.plusBtn.Font = New System.Drawing.Font("Helvetica", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.plusBtn.ForeColor = System.Drawing.Color.FromName("@window")
        Me.plusBtn.Location = New System.Drawing.Point(220, 559)
        Me.plusBtn.Name = "plusBtn"
        Me.plusBtn.Size = New System.Drawing.Size(47, 34)
        Me.plusBtn.TabIndex = 4
        Me.plusBtn.Text = "+1"
        '
        'minusBtn
        '
        Me.minusBtn.AutoSize = True
        Me.minusBtn.BackColor = System.Drawing.Color.FromName("@buttonSelectedText")
        Me.minusBtn.BorderStyle = Wisej.Web.BorderStyle.[Double]
        Me.minusBtn.Font = New System.Drawing.Font("Helvetica", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.minusBtn.Location = New System.Drawing.Point(169, 559)
        Me.minusBtn.Name = "minusBtn"
        Me.minusBtn.Size = New System.Drawing.Size(45, 34)
        Me.minusBtn.TabIndex = 5
        Me.minusBtn.Text = "-1"
        '
        'mouthBtn1
        '
        Me.mouthBtn1.AutoSize = True
        Me.mouthBtn1.BackColor = System.Drawing.Color.FromName("@buttonText")
        Me.mouthBtn1.BackgroundImage = CType(resources.GetObject("mouthBtn1.BackgroundImage"), System.Drawing.Image)
        Me.mouthBtn1.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        Me.mouthBtn1.Location = New System.Drawing.Point(194, 98)
        Me.mouthBtn1.Name = "mouthBtn1"
        Me.mouthBtn1.Size = New System.Drawing.Size(113, 116)
        Me.mouthBtn1.TabIndex = 7
        '
        'tailBtn1
        '
        Me.tailBtn1.AutoSize = True
        Me.tailBtn1.BackColor = System.Drawing.Color.FromName("@buttonText")
        Me.tailBtn1.BackgroundImage = CType(resources.GetObject("tailBtn1.BackgroundImage"), System.Drawing.Image)
        Me.tailBtn1.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        Me.tailBtn1.Location = New System.Drawing.Point(194, 292)
        Me.tailBtn1.Name = "tailBtn1"
        Me.tailBtn1.Size = New System.Drawing.Size(113, 116)
        Me.tailBtn1.TabIndex = 13
        '
        'hornBtn1
        '
        Me.hornBtn1.AutoSize = True
        Me.hornBtn1.BackColor = System.Drawing.Color.FromName("@buttonText")
        Me.hornBtn1.BackgroundImage = CType(resources.GetObject("hornBtn1.BackgroundImage"), System.Drawing.Image)
        Me.hornBtn1.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        Me.hornBtn1.Location = New System.Drawing.Point(30, 292)
        Me.hornBtn1.Name = "hornBtn1"
        Me.hornBtn1.Size = New System.Drawing.Size(113, 116)
        Me.hornBtn1.TabIndex = 10
        '
        'backCost1
        '
        Me.backCost1.BackColor = System.Drawing.Color.FromName("@toolbarText")
        Me.backCost1.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.backCost1.ForeColor = System.Drawing.Color.FromName("@window")
        Me.backCost1.Location = New System.Drawing.Point(30, 220)
        Me.backCost1.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.backCost1.Name = "backCost1"
        Me.backCost1.Size = New System.Drawing.Size(73, 25)
        Me.backCost1.TabIndex = 14
        Me.backCost1.Text = "0 cost"
        '
        'mouthCost1
        '
        Me.mouthCost1.BackColor = System.Drawing.Color.FromName("@toolbarText")
        Me.mouthCost1.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mouthCost1.ForeColor = System.Drawing.Color.FromName("@window")
        Me.mouthCost1.Location = New System.Drawing.Point(194, 220)
        Me.mouthCost1.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.mouthCost1.Name = "mouthCost1"
        Me.mouthCost1.Size = New System.Drawing.Size(73, 25)
        Me.mouthCost1.TabIndex = 15
        Me.mouthCost1.Text = "0 cost"
        '
        'tailCost1
        '
        Me.tailCost1.BackColor = System.Drawing.Color.FromName("@toolbarText")
        Me.tailCost1.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tailCost1.ForeColor = System.Drawing.Color.FromName("@window")
        Me.tailCost1.Location = New System.Drawing.Point(194, 414)
        Me.tailCost1.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.tailCost1.Name = "tailCost1"
        Me.tailCost1.Size = New System.Drawing.Size(73, 25)
        Me.tailCost1.TabIndex = 17
        Me.tailCost1.Text = "0 cost"
        '
        'hornCost1
        '
        Me.hornCost1.BackColor = System.Drawing.Color.FromName("@toolbarText")
        Me.hornCost1.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.hornCost1.ForeColor = System.Drawing.Color.FromName("@window")
        Me.hornCost1.Location = New System.Drawing.Point(30, 414)
        Me.hornCost1.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.hornCost1.Name = "hornCost1"
        Me.hornCost1.Size = New System.Drawing.Size(73, 25)
        Me.hornCost1.TabIndex = 16
        Me.hornCost1.Text = "0 cost"
        '
        'tailCost2
        '
        Me.tailCost2.BackColor = System.Drawing.Color.FromName("@toolbarText")
        Me.tailCost2.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tailCost2.ForeColor = System.Drawing.Color.FromName("@window")
        Me.tailCost2.Location = New System.Drawing.Point(657, 414)
        Me.tailCost2.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.tailCost2.Name = "tailCost2"
        Me.tailCost2.Size = New System.Drawing.Size(73, 25)
        Me.tailCost2.TabIndex = 25
        Me.tailCost2.Text = "0 cost"
        '
        'hornCost2
        '
        Me.hornCost2.BackColor = System.Drawing.Color.FromName("@toolbarText")
        Me.hornCost2.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.hornCost2.ForeColor = System.Drawing.Color.FromName("@window")
        Me.hornCost2.Location = New System.Drawing.Point(493, 414)
        Me.hornCost2.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.hornCost2.Name = "hornCost2"
        Me.hornCost2.Size = New System.Drawing.Size(73, 25)
        Me.hornCost2.TabIndex = 24
        Me.hornCost2.Text = "0 cost"
        '
        'mouthCost2
        '
        Me.mouthCost2.BackColor = System.Drawing.Color.FromName("@toolbarText")
        Me.mouthCost2.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mouthCost2.ForeColor = System.Drawing.Color.FromName("@window")
        Me.mouthCost2.Location = New System.Drawing.Point(657, 220)
        Me.mouthCost2.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.mouthCost2.Name = "mouthCost2"
        Me.mouthCost2.Size = New System.Drawing.Size(73, 25)
        Me.mouthCost2.TabIndex = 23
        Me.mouthCost2.Text = "0 cost"
        '
        'backCost2
        '
        Me.backCost2.BackColor = System.Drawing.Color.FromName("@toolbarText")
        Me.backCost2.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.backCost2.ForeColor = System.Drawing.Color.FromName("@window")
        Me.backCost2.Location = New System.Drawing.Point(493, 220)
        Me.backCost2.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.backCost2.Name = "backCost2"
        Me.backCost2.Size = New System.Drawing.Size(73, 25)
        Me.backCost2.TabIndex = 22
        Me.backCost2.Text = "0 cost"
        '
        'tailBtn2
        '
        Me.tailBtn2.AutoSize = True
        Me.tailBtn2.BackColor = System.Drawing.Color.FromName("@buttonText")
        Me.tailBtn2.BackgroundImage = CType(resources.GetObject("tailBtn2.BackgroundImage"), System.Drawing.Image)
        Me.tailBtn2.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        Me.tailBtn2.Location = New System.Drawing.Point(657, 292)
        Me.tailBtn2.Name = "tailBtn2"
        Me.tailBtn2.Size = New System.Drawing.Size(113, 116)
        Me.tailBtn2.TabIndex = 21
        '
        'hornBtn2
        '
        Me.hornBtn2.AutoSize = True
        Me.hornBtn2.BackColor = System.Drawing.Color.FromName("@buttonText")
        Me.hornBtn2.BackgroundImage = CType(resources.GetObject("hornBtn2.BackgroundImage"), System.Drawing.Image)
        Me.hornBtn2.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        Me.hornBtn2.Location = New System.Drawing.Point(493, 292)
        Me.hornBtn2.Name = "hornBtn2"
        Me.hornBtn2.Size = New System.Drawing.Size(113, 116)
        Me.hornBtn2.TabIndex = 20
        '
        'mouthBtn2
        '
        Me.mouthBtn2.AutoSize = True
        Me.mouthBtn2.BackColor = System.Drawing.Color.FromName("@buttonText")
        Me.mouthBtn2.BackgroundImage = CType(resources.GetObject("mouthBtn2.BackgroundImage"), System.Drawing.Image)
        Me.mouthBtn2.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        Me.mouthBtn2.Location = New System.Drawing.Point(657, 98)
        Me.mouthBtn2.Name = "mouthBtn2"
        Me.mouthBtn2.Size = New System.Drawing.Size(113, 116)
        Me.mouthBtn2.TabIndex = 19
        '
        'backBtn2
        '
        Me.backBtn2.Anchor = Wisej.Web.AnchorStyles.Left
        Me.backBtn2.AutoSize = True
        Me.backBtn2.BackColor = System.Drawing.Color.FromName("@buttonText")
        Me.backBtn2.BackgroundImage = CType(resources.GetObject("backBtn2.BackgroundImage"), System.Drawing.Image)
        Me.backBtn2.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        Me.backBtn2.Location = New System.Drawing.Point(493, 98)
        Me.backBtn2.Name = "backBtn2"
        Me.backBtn2.Size = New System.Drawing.Size(113, 116)
        Me.backBtn2.TabIndex = 18
        '
        'tailCost3
        '
        Me.tailCost3.BackColor = System.Drawing.Color.FromName("@toolbarText")
        Me.tailCost3.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tailCost3.ForeColor = System.Drawing.Color.FromName("@window")
        Me.tailCost3.Location = New System.Drawing.Point(1113, 414)
        Me.tailCost3.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.tailCost3.Name = "tailCost3"
        Me.tailCost3.Size = New System.Drawing.Size(73, 25)
        Me.tailCost3.TabIndex = 33
        Me.tailCost3.Text = "0 cost"
        '
        'hornCost3
        '
        Me.hornCost3.BackColor = System.Drawing.Color.FromName("@toolbarText")
        Me.hornCost3.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.hornCost3.ForeColor = System.Drawing.Color.FromName("@window")
        Me.hornCost3.Location = New System.Drawing.Point(949, 414)
        Me.hornCost3.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.hornCost3.Name = "hornCost3"
        Me.hornCost3.Size = New System.Drawing.Size(73, 25)
        Me.hornCost3.TabIndex = 32
        Me.hornCost3.Text = "0 cost"
        '
        'mouthCost3
        '
        Me.mouthCost3.BackColor = System.Drawing.Color.FromName("@toolbarText")
        Me.mouthCost3.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mouthCost3.ForeColor = System.Drawing.Color.FromName("@window")
        Me.mouthCost3.Location = New System.Drawing.Point(1113, 220)
        Me.mouthCost3.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.mouthCost3.Name = "mouthCost3"
        Me.mouthCost3.Size = New System.Drawing.Size(73, 25)
        Me.mouthCost3.TabIndex = 31
        Me.mouthCost3.Text = "0 cost"
        '
        'backCost3
        '
        Me.backCost3.BackColor = System.Drawing.Color.FromName("@toolbarText")
        Me.backCost3.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.backCost3.ForeColor = System.Drawing.Color.FromName("@window")
        Me.backCost3.Location = New System.Drawing.Point(949, 220)
        Me.backCost3.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.backCost3.Name = "backCost3"
        Me.backCost3.Size = New System.Drawing.Size(73, 25)
        Me.backCost3.TabIndex = 30
        Me.backCost3.Text = "0 cost"
        '
        'tailBtn3
        '
        Me.tailBtn3.AutoSize = True
        Me.tailBtn3.BackColor = System.Drawing.Color.FromName("@buttonText")
        Me.tailBtn3.BackgroundImage = CType(resources.GetObject("tailBtn3.BackgroundImage"), System.Drawing.Image)
        Me.tailBtn3.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        Me.tailBtn3.Location = New System.Drawing.Point(1113, 292)
        Me.tailBtn3.Name = "tailBtn3"
        Me.tailBtn3.Size = New System.Drawing.Size(113, 116)
        Me.tailBtn3.TabIndex = 29
        '
        'hornBtn3
        '
        Me.hornBtn3.AutoSize = True
        Me.hornBtn3.BackColor = System.Drawing.Color.FromName("@buttonText")
        Me.hornBtn3.BackgroundImage = CType(resources.GetObject("hornBtn3.BackgroundImage"), System.Drawing.Image)
        Me.hornBtn3.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        Me.hornBtn3.Location = New System.Drawing.Point(949, 292)
        Me.hornBtn3.Name = "hornBtn3"
        Me.hornBtn3.Size = New System.Drawing.Size(113, 116)
        Me.hornBtn3.TabIndex = 28
        '
        'mouthBtn3
        '
        Me.mouthBtn3.AutoSize = True
        Me.mouthBtn3.BackColor = System.Drawing.Color.FromName("@buttonText")
        Me.mouthBtn3.BackgroundImage = CType(resources.GetObject("mouthBtn3.BackgroundImage"), System.Drawing.Image)
        Me.mouthBtn3.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        Me.mouthBtn3.Location = New System.Drawing.Point(1113, 98)
        Me.mouthBtn3.Name = "mouthBtn3"
        Me.mouthBtn3.Size = New System.Drawing.Size(113, 116)
        Me.mouthBtn3.TabIndex = 27
        '
        'backBtn3
        '
        Me.backBtn3.AutoSize = True
        Me.backBtn3.BackColor = System.Drawing.Color.FromName("@buttonText")
        Me.backBtn3.BackgroundImage = CType(resources.GetObject("backBtn3.BackgroundImage"), System.Drawing.Image)
        Me.backBtn3.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch
        Me.backBtn3.Location = New System.Drawing.Point(949, 98)
        Me.backBtn3.Name = "backBtn3"
        Me.backBtn3.Size = New System.Drawing.Size(113, 116)
        Me.backBtn3.TabIndex = 26
        '
        'deadBtn1
        '
        Me.deadBtn1.BackColor = System.Drawing.Color.FromName("@buttonSelectedText")
        Me.deadBtn1.Font = New System.Drawing.Font("Helvetica", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.deadBtn1.Location = New System.Drawing.Point(107, 459)
        Me.deadBtn1.Name = "deadBtn1"
        Me.deadBtn1.Size = New System.Drawing.Size(123, 43)
        Me.deadBtn1.TabIndex = 34
        Me.deadBtn1.Text = "Dead"
        '
        'deadBtn2
        '
        Me.deadBtn2.BackColor = System.Drawing.Color.FromName("@buttonSelectedText")
        Me.deadBtn2.Font = New System.Drawing.Font("Helvetica", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.deadBtn2.Location = New System.Drawing.Point(574, 459)
        Me.deadBtn2.Name = "deadBtn2"
        Me.deadBtn2.Size = New System.Drawing.Size(123, 43)
        Me.deadBtn2.TabIndex = 35
        Me.deadBtn2.Text = "Dead"
        '
        'deadBtn3
        '
        Me.deadBtn3.BackColor = System.Drawing.Color.FromName("@buttonSelectedText")
        Me.deadBtn3.Font = New System.Drawing.Font("Helvetica", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.deadBtn3.Location = New System.Drawing.Point(1030, 459)
        Me.deadBtn3.Name = "deadBtn3"
        Me.deadBtn3.Size = New System.Drawing.Size(123, 43)
        Me.deadBtn3.TabIndex = 36
        Me.deadBtn3.Text = "Dead"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label2.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.Label2.Location = New System.Drawing.Point(107, 24)
        Me.Label2.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 29)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Backline"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.Label3.Location = New System.Drawing.Point(576, 24)
        Me.Label3.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 29)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Midline"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Helvetica", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label4.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.Label4.Location = New System.Drawing.Point(1033, 24)
        Me.Label4.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 29)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Frontline"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label5.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.Label5.Location = New System.Drawing.Point(30, 75)
        Me.Label5.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 18)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Count:"
        '
        'backCount1
        '
        Me.backCount1.AutoSize = True
        Me.backCount1.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.backCount1.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.backCount1.Location = New System.Drawing.Point(83, 74)
        Me.backCount1.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.backCount1.Name = "backCount1"
        Me.backCount1.Size = New System.Drawing.Size(13, 18)
        Me.backCount1.TabIndex = 41
        Me.backCount1.Text = "0"
        Me.backCount1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hornCount1
        '
        Me.hornCount1.AutoSize = True
        Me.hornCount1.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.hornCount1.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.hornCount1.Location = New System.Drawing.Point(83, 270)
        Me.hornCount1.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.hornCount1.Name = "hornCount1"
        Me.hornCount1.Size = New System.Drawing.Size(13, 18)
        Me.hornCount1.TabIndex = 43
        Me.hornCount1.Text = "0"
        Me.hornCount1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label7.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.Label7.Location = New System.Drawing.Point(30, 270)
        Me.Label7.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 18)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Count:"
        '
        'backCount2
        '
        Me.backCount2.AutoSize = True
        Me.backCount2.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.backCount2.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.backCount2.Location = New System.Drawing.Point(546, 77)
        Me.backCount2.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.backCount2.Name = "backCount2"
        Me.backCount2.Size = New System.Drawing.Size(13, 18)
        Me.backCount2.TabIndex = 45
        Me.backCount2.Text = "0"
        Me.backCount2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label9.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.Label9.Location = New System.Drawing.Point(493, 77)
        Me.Label9.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 18)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Count:"
        '
        'hornCount2
        '
        Me.hornCount2.AutoSize = True
        Me.hornCount2.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.hornCount2.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.hornCount2.Location = New System.Drawing.Point(546, 269)
        Me.hornCount2.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.hornCount2.Name = "hornCount2"
        Me.hornCount2.Size = New System.Drawing.Size(13, 18)
        Me.hornCount2.TabIndex = 47
        Me.hornCount2.Text = "0"
        Me.hornCount2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label11.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.Label11.Location = New System.Drawing.Point(493, 269)
        Me.Label11.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 18)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Count:"
        '
        'hornCount3
        '
        Me.hornCount3.AutoSize = True
        Me.hornCount3.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.hornCount3.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.hornCount3.Location = New System.Drawing.Point(1002, 270)
        Me.hornCount3.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.hornCount3.Name = "hornCount3"
        Me.hornCount3.Size = New System.Drawing.Size(13, 18)
        Me.hornCount3.TabIndex = 49
        Me.hornCount3.Text = "0"
        Me.hornCount3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label13.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.Label13.Location = New System.Drawing.Point(949, 270)
        Me.Label13.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 18)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Count:"
        '
        'backCount3
        '
        Me.backCount3.AutoSize = True
        Me.backCount3.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.backCount3.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.backCount3.Location = New System.Drawing.Point(1002, 76)
        Me.backCount3.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.backCount3.Name = "backCount3"
        Me.backCount3.Size = New System.Drawing.Size(13, 18)
        Me.backCount3.TabIndex = 51
        Me.backCount3.Text = "0"
        Me.backCount3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label15.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.Label15.Location = New System.Drawing.Point(949, 76)
        Me.Label15.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 18)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "Count:"
        '
        'mouthCount1
        '
        Me.mouthCount1.AutoSize = True
        Me.mouthCount1.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mouthCount1.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.mouthCount1.Location = New System.Drawing.Point(247, 76)
        Me.mouthCount1.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.mouthCount1.Name = "mouthCount1"
        Me.mouthCount1.Size = New System.Drawing.Size(13, 18)
        Me.mouthCount1.TabIndex = 53
        Me.mouthCount1.Text = "0"
        Me.mouthCount1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label17.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.Label17.Location = New System.Drawing.Point(194, 76)
        Me.Label17.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 18)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "Count:"
        '
        'tailCount1
        '
        Me.tailCount1.AutoSize = True
        Me.tailCount1.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tailCount1.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.tailCount1.Location = New System.Drawing.Point(247, 271)
        Me.tailCount1.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.tailCount1.Name = "tailCount1"
        Me.tailCount1.Size = New System.Drawing.Size(13, 18)
        Me.tailCount1.TabIndex = 55
        Me.tailCount1.Text = "0"
        Me.tailCount1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label19.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.Label19.Location = New System.Drawing.Point(194, 271)
        Me.Label19.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 18)
        Me.Label19.TabIndex = 54
        Me.Label19.Text = "Count:"
        '
        'tailCount2
        '
        Me.tailCount2.AutoSize = True
        Me.tailCount2.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tailCount2.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.tailCount2.Location = New System.Drawing.Point(710, 270)
        Me.tailCount2.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.tailCount2.Name = "tailCount2"
        Me.tailCount2.Size = New System.Drawing.Size(13, 18)
        Me.tailCount2.TabIndex = 57
        Me.tailCount2.Text = "0"
        Me.tailCount2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label21.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.Label21.Location = New System.Drawing.Point(657, 270)
        Me.Label21.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 18)
        Me.Label21.TabIndex = 56
        Me.Label21.Text = "Count:"
        '
        'mouthCount2
        '
        Me.mouthCount2.AutoSize = True
        Me.mouthCount2.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mouthCount2.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.mouthCount2.Location = New System.Drawing.Point(710, 78)
        Me.mouthCount2.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.mouthCount2.Name = "mouthCount2"
        Me.mouthCount2.Size = New System.Drawing.Size(13, 18)
        Me.mouthCount2.TabIndex = 59
        Me.mouthCount2.Text = "0"
        Me.mouthCount2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label23.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.Label23.Location = New System.Drawing.Point(657, 78)
        Me.Label23.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(49, 18)
        Me.Label23.TabIndex = 58
        Me.Label23.Text = "Count:"
        '
        'tailCount3
        '
        Me.tailCount3.AutoSize = True
        Me.tailCount3.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tailCount3.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.tailCount3.Location = New System.Drawing.Point(1166, 271)
        Me.tailCount3.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.tailCount3.Name = "tailCount3"
        Me.tailCount3.Size = New System.Drawing.Size(13, 18)
        Me.tailCount3.TabIndex = 61
        Me.tailCount3.Text = "0"
        Me.tailCount3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label25.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.Label25.Location = New System.Drawing.Point(1113, 271)
        Me.Label25.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(49, 18)
        Me.Label25.TabIndex = 60
        Me.Label25.Text = "Count:"
        '
        'mouthCount3
        '
        Me.mouthCount3.AutoSize = True
        Me.mouthCount3.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mouthCount3.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.mouthCount3.Location = New System.Drawing.Point(1166, 75)
        Me.mouthCount3.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.mouthCount3.Name = "mouthCount3"
        Me.mouthCount3.Size = New System.Drawing.Size(13, 18)
        Me.mouthCount3.TabIndex = 63
        Me.mouthCount3.Text = "0"
        Me.mouthCount3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label27.ForeColor = System.Drawing.Color.FromName("@activeCaptionText")
        Me.Label27.Location = New System.Drawing.Point(1113, 75)
        Me.Label27.Margin = New Wisej.Web.Padding(2, 3, 2, 3)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(49, 18)
        Me.Label27.TabIndex = 62
        Me.Label27.Text = "Count:"
        '
        'mouthBtnMin1
        '
        Me.mouthBtnMin1.AutoSize = True
        Me.mouthBtnMin1.BackColor = System.Drawing.Color.FromName("@buttonSelectedText")
        Me.mouthBtnMin1.BorderStyle = Wisej.Web.BorderStyle.[Double]
        Me.mouthBtnMin1.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mouthBtnMin1.Location = New System.Drawing.Point(275, 70)
        Me.mouthBtnMin1.Name = "mouthBtnMin1"
        Me.mouthBtnMin1.Size = New System.Drawing.Size(32, 27)
        Me.mouthBtnMin1.TabIndex = 64
        Me.mouthBtnMin1.Text = "-1"
        '
        'backBtnMin1
        '
        Me.backBtnMin1.AutoSize = True
        Me.backBtnMin1.BackColor = System.Drawing.Color.FromName("@buttonSelectedText")
        Me.backBtnMin1.BorderStyle = Wisej.Web.BorderStyle.[Double]
        Me.backBtnMin1.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.backBtnMin1.Location = New System.Drawing.Point(111, 70)
        Me.backBtnMin1.Name = "backBtnMin1"
        Me.backBtnMin1.Size = New System.Drawing.Size(32, 27)
        Me.backBtnMin1.TabIndex = 65
        Me.backBtnMin1.Text = "-1"
        '
        'hornBtnMin1
        '
        Me.hornBtnMin1.AutoSize = True
        Me.hornBtnMin1.BackColor = System.Drawing.Color.FromName("@buttonSelectedText")
        Me.hornBtnMin1.BorderStyle = Wisej.Web.BorderStyle.[Double]
        Me.hornBtnMin1.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.hornBtnMin1.Location = New System.Drawing.Point(111, 263)
        Me.hornBtnMin1.Name = "hornBtnMin1"
        Me.hornBtnMin1.Size = New System.Drawing.Size(32, 27)
        Me.hornBtnMin1.TabIndex = 67
        Me.hornBtnMin1.Text = "-1"
        '
        'tailBtnMin1
        '
        Me.tailBtnMin1.AutoSize = True
        Me.tailBtnMin1.BackColor = System.Drawing.Color.FromName("@buttonSelectedText")
        Me.tailBtnMin1.BorderStyle = Wisej.Web.BorderStyle.[Double]
        Me.tailBtnMin1.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tailBtnMin1.Location = New System.Drawing.Point(275, 263)
        Me.tailBtnMin1.Name = "tailBtnMin1"
        Me.tailBtnMin1.Size = New System.Drawing.Size(32, 27)
        Me.tailBtnMin1.TabIndex = 66
        Me.tailBtnMin1.Text = "-1"
        '
        'hornBtnMin2
        '
        Me.hornBtnMin2.AutoSize = True
        Me.hornBtnMin2.BackColor = System.Drawing.Color.FromName("@buttonSelectedText")
        Me.hornBtnMin2.BorderStyle = Wisej.Web.BorderStyle.[Double]
        Me.hornBtnMin2.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.hornBtnMin2.Location = New System.Drawing.Point(574, 263)
        Me.hornBtnMin2.Name = "hornBtnMin2"
        Me.hornBtnMin2.Size = New System.Drawing.Size(32, 27)
        Me.hornBtnMin2.TabIndex = 71
        Me.hornBtnMin2.Text = "-1"
        '
        'tailBtnMin2
        '
        Me.tailBtnMin2.AutoSize = True
        Me.tailBtnMin2.BackColor = System.Drawing.Color.FromName("@buttonSelectedText")
        Me.tailBtnMin2.BorderStyle = Wisej.Web.BorderStyle.[Double]
        Me.tailBtnMin2.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tailBtnMin2.Location = New System.Drawing.Point(738, 263)
        Me.tailBtnMin2.Name = "tailBtnMin2"
        Me.tailBtnMin2.Size = New System.Drawing.Size(32, 27)
        Me.tailBtnMin2.TabIndex = 70
        Me.tailBtnMin2.Text = "-1"
        '
        'backBtnMin2
        '
        Me.backBtnMin2.AutoSize = True
        Me.backBtnMin2.BackColor = System.Drawing.Color.FromName("@buttonSelectedText")
        Me.backBtnMin2.BorderStyle = Wisej.Web.BorderStyle.[Double]
        Me.backBtnMin2.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.backBtnMin2.Location = New System.Drawing.Point(574, 70)
        Me.backBtnMin2.Name = "backBtnMin2"
        Me.backBtnMin2.Size = New System.Drawing.Size(32, 27)
        Me.backBtnMin2.TabIndex = 69
        Me.backBtnMin2.Text = "-1"
        '
        'mouthBtnMin2
        '
        Me.mouthBtnMin2.AutoSize = True
        Me.mouthBtnMin2.BackColor = System.Drawing.Color.FromName("@buttonSelectedText")
        Me.mouthBtnMin2.BorderStyle = Wisej.Web.BorderStyle.[Double]
        Me.mouthBtnMin2.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mouthBtnMin2.Location = New System.Drawing.Point(738, 70)
        Me.mouthBtnMin2.Name = "mouthBtnMin2"
        Me.mouthBtnMin2.Size = New System.Drawing.Size(32, 27)
        Me.mouthBtnMin2.TabIndex = 68
        Me.mouthBtnMin2.Text = "-1"
        '
        'hornBtnMin3
        '
        Me.hornBtnMin3.AutoSize = True
        Me.hornBtnMin3.BackColor = System.Drawing.Color.FromName("@buttonSelectedText")
        Me.hornBtnMin3.BorderStyle = Wisej.Web.BorderStyle.[Double]
        Me.hornBtnMin3.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.hornBtnMin3.Location = New System.Drawing.Point(1030, 263)
        Me.hornBtnMin3.Name = "hornBtnMin3"
        Me.hornBtnMin3.Size = New System.Drawing.Size(32, 27)
        Me.hornBtnMin3.TabIndex = 75
        Me.hornBtnMin3.Text = "-1"
        '
        'tailBtnMin3
        '
        Me.tailBtnMin3.AutoSize = True
        Me.tailBtnMin3.BackColor = System.Drawing.Color.FromName("@buttonSelectedText")
        Me.tailBtnMin3.BorderStyle = Wisej.Web.BorderStyle.[Double]
        Me.tailBtnMin3.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tailBtnMin3.Location = New System.Drawing.Point(1194, 263)
        Me.tailBtnMin3.Name = "tailBtnMin3"
        Me.tailBtnMin3.Size = New System.Drawing.Size(32, 27)
        Me.tailBtnMin3.TabIndex = 74
        Me.tailBtnMin3.Text = "-1"
        '
        'backBtnMin3
        '
        Me.backBtnMin3.AutoSize = True
        Me.backBtnMin3.BackColor = System.Drawing.Color.FromName("@buttonSelectedText")
        Me.backBtnMin3.BorderStyle = Wisej.Web.BorderStyle.[Double]
        Me.backBtnMin3.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.backBtnMin3.Location = New System.Drawing.Point(1030, 70)
        Me.backBtnMin3.Name = "backBtnMin3"
        Me.backBtnMin3.Size = New System.Drawing.Size(32, 27)
        Me.backBtnMin3.TabIndex = 73
        Me.backBtnMin3.Text = "-1"
        '
        'mouthBtnMin3
        '
        Me.mouthBtnMin3.AutoSize = True
        Me.mouthBtnMin3.BackColor = System.Drawing.Color.FromName("@buttonSelectedText")
        Me.mouthBtnMin3.BorderStyle = Wisej.Web.BorderStyle.[Double]
        Me.mouthBtnMin3.Font = New System.Drawing.Font("Helvetica", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mouthBtnMin3.Location = New System.Drawing.Point(1194, 70)
        Me.mouthBtnMin3.Name = "mouthBtnMin3"
        Me.mouthBtnMin3.Size = New System.Drawing.Size(32, 27)
        Me.mouthBtnMin3.TabIndex = 72
        Me.mouthBtnMin3.Text = "-1"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromName("@buttonSelectedText")
        Me.Button3.Font = New System.Drawing.Font("Helvetica", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Button3.Location = New System.Drawing.Point(1166, 548)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 43)
        Me.Button3.TabIndex = 78
        Me.Button3.Text = "Reset"
        '
        'EnergyCounterApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromName("@toolbarText")
        Me.ClientSize = New System.Drawing.Size(1288, 596)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.hornBtnMin3)
        Me.Controls.Add(Me.tailBtnMin3)
        Me.Controls.Add(Me.backBtnMin3)
        Me.Controls.Add(Me.mouthBtnMin3)
        Me.Controls.Add(Me.hornBtnMin2)
        Me.Controls.Add(Me.tailBtnMin2)
        Me.Controls.Add(Me.backBtnMin2)
        Me.Controls.Add(Me.mouthBtnMin2)
        Me.Controls.Add(Me.hornBtnMin1)
        Me.Controls.Add(Me.tailBtnMin1)
        Me.Controls.Add(Me.backBtnMin1)
        Me.Controls.Add(Me.mouthBtnMin1)
        Me.Controls.Add(Me.mouthCount3)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.tailCount3)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.mouthCount2)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.tailCount2)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.tailCount1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.mouthCount1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.backCount3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.hornCount3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.hornCount2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.backCount2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.hornCount1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.backCount1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.deadBtn3)
        Me.Controls.Add(Me.deadBtn2)
        Me.Controls.Add(Me.deadBtn1)
        Me.Controls.Add(Me.tailCost3)
        Me.Controls.Add(Me.hornCost3)
        Me.Controls.Add(Me.mouthCost3)
        Me.Controls.Add(Me.backCost3)
        Me.Controls.Add(Me.tailBtn3)
        Me.Controls.Add(Me.hornBtn3)
        Me.Controls.Add(Me.mouthBtn3)
        Me.Controls.Add(Me.backBtn3)
        Me.Controls.Add(Me.tailCost2)
        Me.Controls.Add(Me.hornCost2)
        Me.Controls.Add(Me.mouthCost2)
        Me.Controls.Add(Me.backCost2)
        Me.Controls.Add(Me.tailBtn2)
        Me.Controls.Add(Me.hornBtn2)
        Me.Controls.Add(Me.mouthBtn2)
        Me.Controls.Add(Me.backBtn2)
        Me.Controls.Add(Me.tailCost1)
        Me.Controls.Add(Me.hornCost1)
        Me.Controls.Add(Me.mouthCost1)
        Me.Controls.Add(Me.backCost1)
        Me.Controls.Add(Me.tailBtn1)
        Me.Controls.Add(Me.hornBtn1)
        Me.Controls.Add(Me.mouthBtn1)
        Me.Controls.Add(Me.minusBtn)
        Me.Controls.Add(Me.plusBtn)
        Me.Controls.Add(Me.backBtn1)
        Me.Controls.Add(Me.energyText)
        Me.Controls.Add(Me.Label1)
        Me.HeaderBackColor = System.Drawing.Color.FromName("@controlText")
        Me.Name = "EnergyCounterApp"
        Me.Text = "Energy and Card counter app"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents energyText As Label
    Friend WithEvents backBtn1 As Button
    Friend WithEvents plusBtn As Button
    Friend WithEvents minusBtn As Button
    Friend WithEvents mouthBtn1 As Button
    Friend WithEvents tailBtn1 As Button
    Friend WithEvents hornBtn1 As Button
    Friend WithEvents backCost1 As CheckBox
    Friend WithEvents mouthCost1 As CheckBox
    Friend WithEvents tailCost1 As CheckBox
    Friend WithEvents hornCost1 As CheckBox
    Friend WithEvents tailCost2 As CheckBox
    Friend WithEvents hornCost2 As CheckBox
    Friend WithEvents mouthCost2 As CheckBox
    Friend WithEvents backCost2 As CheckBox
    Friend WithEvents tailBtn2 As Button
    Friend WithEvents hornBtn2 As Button
    Friend WithEvents mouthBtn2 As Button
    Friend WithEvents backBtn2 As Button
    Friend WithEvents tailCost3 As CheckBox
    Friend WithEvents hornCost3 As CheckBox
    Friend WithEvents mouthCost3 As CheckBox
    Friend WithEvents backCost3 As CheckBox
    Friend WithEvents tailBtn3 As Button
    Friend WithEvents hornBtn3 As Button
    Friend WithEvents mouthBtn3 As Button
    Friend WithEvents backBtn3 As Button
    Friend WithEvents deadBtn1 As Button
    Friend WithEvents deadBtn2 As Button
    Friend WithEvents deadBtn3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents backCount1 As Label
    Friend WithEvents hornCount1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents backCount2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents hornCount2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents hornCount3 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents backCount3 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents mouthCount1 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents tailCount1 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents tailCount2 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents mouthCount2 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents tailCount3 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents mouthCount3 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents mouthBtnMin1 As Button
    Friend WithEvents backBtnMin1 As Button
    Friend WithEvents hornBtnMin1 As Button
    Friend WithEvents tailBtnMin1 As Button
    Friend WithEvents hornBtnMin2 As Button
    Friend WithEvents tailBtnMin2 As Button
    Friend WithEvents backBtnMin2 As Button
    Friend WithEvents mouthBtnMin2 As Button
    Friend WithEvents hornBtnMin3 As Button
    Friend WithEvents tailBtnMin3 As Button
    Friend WithEvents backBtnMin3 As Button
    Friend WithEvents mouthBtnMin3 As Button
    Friend WithEvents Button3 As Button
End Class
