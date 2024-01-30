<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cotizacion
    Inherits System.Windows.Forms.Form

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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Pmenu = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.menu_close = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Pperfil = New System.Windows.Forms.PictureBox()
        Me.btnmts = New System.Windows.Forms.Button()
        Me.btncm = New System.Windows.Forms.Button()
        CType(Me.Pmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.menu_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Pperfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pmenu
        '
        Me.Pmenu.Image = Global.Diseño_Menu_Despegable_Izquierdo.My.Resources.Resources.flecha_left
        Me.Pmenu.Location = New System.Drawing.Point(163, 4)
        Me.Pmenu.Name = "Pmenu"
        Me.Pmenu.Size = New System.Drawing.Size(37, 33)
        Me.Pmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pmenu.TabIndex = 0
        Me.Pmenu.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.menu_close)
        Me.Panel1.Controls.Add(Me.Pmenu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1107, 40)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(461, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Medidas del Barandal"
        '
        'menu_close
        '
        Me.menu_close.Image = Global.Diseño_Menu_Despegable_Izquierdo.My.Resources.Resources.flecha_down
        Me.menu_close.Location = New System.Drawing.Point(12, 4)
        Me.menu_close.Name = "menu_close"
        Me.menu_close.Size = New System.Drawing.Size(37, 33)
        Me.menu_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.menu_close.TabIndex = 1
        Me.menu_close.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.Pperfil)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 657)
        Me.Panel2.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = Global.Diseño_Menu_Despegable_Izquierdo.My.Resources.Resources.compras
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(3, 320)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(197, 38)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "     Ventas"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = Global.Diseño_Menu_Despegable_Izquierdo.My.Resources.Resources.proveedores
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(3, 272)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(197, 38)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "     Producto"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = Global.Diseño_Menu_Despegable_Izquierdo.My.Resources.Resources.proveedores_camion_blanco
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(3, 224)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(197, 38)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "     Proveedor"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.Diseño_Menu_Despegable_Izquierdo.My.Resources.Resources.clientes
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(3, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(197, 38)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "     Clientes"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(0, 161)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 8)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Pperfil
        '
        Me.Pperfil.Image = Global.Diseño_Menu_Despegable_Izquierdo.My.Resources.Resources.t_logo_deaalum
        Me.Pperfil.Location = New System.Drawing.Point(25, 25)
        Me.Pperfil.Name = "Pperfil"
        Me.Pperfil.Size = New System.Drawing.Size(154, 112)
        Me.Pperfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pperfil.TabIndex = 1
        Me.Pperfil.TabStop = False
        '
        'btnmts
        '
        Me.btnmts.BackColor = System.Drawing.Color.LightCyan
        Me.btnmts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnmts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnmts.FlatAppearance.BorderSize = 0
        Me.btnmts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmts.ForeColor = System.Drawing.Color.Black
        Me.btnmts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmts.Location = New System.Drawing.Point(587, 90)
        Me.btnmts.Margin = New System.Windows.Forms.Padding(5)
        Me.btnmts.Name = "btnmts"
        Me.btnmts.Padding = New System.Windows.Forms.Padding(5)
        Me.btnmts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnmts.Size = New System.Drawing.Size(113, 32)
        Me.btnmts.TabIndex = 12
        Me.btnmts.Text = "Metros"
        Me.btnmts.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnmts.UseVisualStyleBackColor = False
        '
        'btncm
        '
        Me.btncm.BackColor = System.Drawing.Color.LightCyan
        Me.btncm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btncm.FlatAppearance.BorderSize = 0
        Me.btncm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncm.ForeColor = System.Drawing.Color.Black
        Me.btncm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncm.Location = New System.Drawing.Point(457, 89)
        Me.btncm.Margin = New System.Windows.Forms.Padding(5)
        Me.btncm.Name = "btncm"
        Me.btncm.Padding = New System.Windows.Forms.Padding(5)
        Me.btncm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btncm.Size = New System.Drawing.Size(111, 33)
        Me.btncm.TabIndex = 13
        Me.btncm.Text = "Centimetros"
        Me.btncm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncm.UseVisualStyleBackColor = False
        '
        'Cotizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1107, 697)
        Me.Controls.Add(Me.btncm)
        Me.Controls.Add(Me.btnmts)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cotizacion"
        Me.Text = "Cotizacion"
        CType(Me.Pmenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.menu_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Pperfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pmenu As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents menu_close As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Pperfil As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnmts As Button
    Friend WithEvents btncm As Button
End Class
