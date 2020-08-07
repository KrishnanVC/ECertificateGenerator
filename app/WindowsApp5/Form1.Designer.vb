<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.excpath = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.temppath = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.expath = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Progress1 = New CircularProgressBar.CircularProgressBar()
        Me.impexcel1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.imptemp = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Button4 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.qrurl = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.CheckBox1 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.Button1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.previewlable = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'excpath
        '
        Me.excpath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.excpath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.excpath.Depth = 0
        Me.excpath.Hint = "Excel path here..."
        Me.excpath.Location = New System.Drawing.Point(27, 104)
        Me.excpath.MouseState = MaterialSkin.MouseState.HOVER
        Me.excpath.Name = "excpath"
        Me.excpath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.excpath.SelectedText = ""
        Me.excpath.SelectionLength = 0
        Me.excpath.SelectionStart = 0
        Me.excpath.Size = New System.Drawing.Size(287, 23)
        Me.excpath.TabIndex = 0
        Me.excpath.UseSystemPasswordChar = False
        '
        'temppath
        '
        Me.temppath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.temppath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.temppath.Depth = 0
        Me.temppath.Hint = "Word path here..."
        Me.temppath.Location = New System.Drawing.Point(23, 378)
        Me.temppath.MouseState = MaterialSkin.MouseState.HOVER
        Me.temppath.Name = "temppath"
        Me.temppath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.temppath.SelectedText = ""
        Me.temppath.SelectionLength = 0
        Me.temppath.SelectionStart = 0
        Me.temppath.Size = New System.Drawing.Size(287, 23)
        Me.temppath.TabIndex = 2
        Me.temppath.UseSystemPasswordChar = False
        '
        'expath
        '
        Me.expath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.expath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.expath.Depth = 0
        Me.expath.Hint = "Path to save here.."
        Me.expath.Location = New System.Drawing.Point(23, 447)
        Me.expath.MouseState = MaterialSkin.MouseState.HOVER
        Me.expath.Name = "expath"
        Me.expath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.expath.SelectedText = ""
        Me.expath.SelectionLength = 0
        Me.expath.SelectionStart = 0
        Me.expath.Size = New System.Drawing.Size(287, 23)
        Me.expath.TabIndex = 3
        Me.expath.UseSystemPasswordChar = False
        '
        'Progress1
        '
        Me.Progress1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.Progress1.AnimationSpeed = 500
        Me.Progress1.BackColor = System.Drawing.Color.Transparent
        Me.Progress1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Progress1.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Bold)
        Me.Progress1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Progress1.InnerColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Progress1.InnerMargin = 2
        Me.Progress1.InnerWidth = -1
        Me.Progress1.Location = New System.Drawing.Point(483, 144)
        Me.Progress1.MarqueeAnimationSpeed = 2000
        Me.Progress1.Name = "Progress1"
        Me.Progress1.OuterColor = System.Drawing.Color.White
        Me.Progress1.OuterMargin = -25
        Me.Progress1.OuterWidth = 26
        Me.Progress1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Progress1.ProgressWidth = 10
        Me.Progress1.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.Progress1.Size = New System.Drawing.Size(155, 154)
        Me.Progress1.StartAngle = 270
        Me.Progress1.SubscriptColor = System.Drawing.Color.White
        Me.Progress1.SubscriptMargin = New System.Windows.Forms.Padding(15, -50, 0, 0)
        Me.Progress1.SubscriptText = "%"
        Me.Progress1.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Progress1.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.Progress1.SuperscriptText = ""
        Me.Progress1.TabIndex = 6
        Me.Progress1.Text = "0"
        Me.Progress1.TextMargin = New System.Windows.Forms.Padding(8, 8, 17, 0)
        Me.Progress1.Value = 68
        Me.Progress1.Visible = False
        '
        'impexcel1
        '
        Me.impexcel1.Depth = 0
        Me.impexcel1.Location = New System.Drawing.Point(341, 104)
        Me.impexcel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.impexcel1.Name = "impexcel1"
        Me.impexcel1.Primary = True
        Me.impexcel1.Size = New System.Drawing.Size(75, 23)
        Me.impexcel1.TabIndex = 7
        Me.impexcel1.Text = "Import"
        Me.impexcel1.UseVisualStyleBackColor = True
        '
        'imptemp
        '
        Me.imptemp.BackColor = System.Drawing.SystemColors.Control
        Me.imptemp.Depth = 0
        Me.imptemp.Location = New System.Drawing.Point(341, 378)
        Me.imptemp.MouseState = MaterialSkin.MouseState.HOVER
        Me.imptemp.Name = "imptemp"
        Me.imptemp.Primary = True
        Me.imptemp.Size = New System.Drawing.Size(75, 23)
        Me.imptemp.TabIndex = 8
        Me.imptemp.Text = "Import"
        Me.imptemp.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Depth = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(341, 447)
        Me.Button4.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button4.Name = "Button4"
        Me.Button4.Primary = True
        Me.Button4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Browse"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button4.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 133)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(374, 196)
        Me.DataGridView1.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.qrurl)
        Me.Panel1.Controls.Add(Me.MaterialLabel2)
        Me.Panel1.Location = New System.Drawing.Point(23, 527)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(615, 64)
        Me.Panel1.TabIndex = 11
        '
        'qrurl
        '
        Me.qrurl.Depth = 0
        Me.qrurl.Hint = "Enter the QR  data here..."
        Me.qrurl.Location = New System.Drawing.Point(29, 24)
        Me.qrurl.MouseState = MaterialSkin.MouseState.HOVER
        Me.qrurl.Name = "qrurl"
        Me.qrurl.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.qrurl.SelectedText = ""
        Me.qrurl.SelectionLength = 0
        Me.qrurl.SelectionStart = 0
        Me.qrurl.Size = New System.Drawing.Size(443, 23)
        Me.qrurl.TabIndex = 0
        Me.qrurl.UseSystemPasswordChar = False
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(25, 2)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(167, 19)
        Me.MaterialLabel2.TabIndex = 15
        Me.MaterialLabel2.Text = "Add data to be encoded"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox1.Depth = 0
        Me.CheckBox1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.CheckBox1.Location = New System.Drawing.Point(23, 488)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.CheckBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Ripple = True
        Me.CheckBox1.Size = New System.Drawing.Size(270, 30)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "Does your certificate contain QR Code?"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Depth = 0
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(442, 406)
        Me.Button1.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button1.Name = "Button1"
        Me.Button1.Primary = True
        Me.Button1.Size = New System.Drawing.Size(243, 50)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Generate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(23, 73)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(121, 19)
        Me.MaterialLabel1.TabIndex = 14
        Me.MaterialLabel1.Text = "Import Excel File"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(23, 414)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(267, 19)
        Me.MaterialLabel3.TabIndex = 16
        Me.MaterialLabel3.Text = "Path to save the generated certificates"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(23, 344)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(120, 19)
        Me.MaterialLabel4.TabIndex = 17
        Me.MaterialLabel4.Text = "Import Word File"
        '
        'previewlable
        '
        Me.previewlable.AutoSize = True
        Me.previewlable.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.previewlable.Depth = 0
        Me.previewlable.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.previewlable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.previewlable.Location = New System.Drawing.Point(92, 217)
        Me.previewlable.MouseState = MaterialSkin.MouseState.HOVER
        Me.previewlable.Name = "previewlable"
        Me.previewlable.Size = New System.Drawing.Size(237, 19)
        Me.previewlable.TabIndex = 18
        Me.previewlable.Text = "Excel File preview will appear here"
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(442, 462)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(243, 49)
        Me.MaterialRaisedButton1.TabIndex = 19
        Me.MaterialRaisedButton1.Text = "Reset"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 522)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.previewlable)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.imptemp)
        Me.Controls.Add(Me.impexcel1)
        Me.Controls.Add(Me.Progress1)
        Me.Controls.Add(Me.expath)
        Me.Controls.Add(Me.temppath)
        Me.Controls.Add(Me.excpath)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E-Certificate Generator"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents excpath As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents temppath As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents expath As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Progress1 As CircularProgressBar.CircularProgressBar
    Friend WithEvents impexcel1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents imptemp As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Button4 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents qrurl As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents CheckBox1 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Button1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents previewlable As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
End Class
