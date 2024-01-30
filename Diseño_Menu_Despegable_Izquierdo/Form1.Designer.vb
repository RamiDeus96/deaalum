<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.menu_close = New System.Windows.Forms.PictureBox()
        Me.Pmenu = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Pperfil = New System.Windows.Forms.PictureBox()
        Me.btnventanas = New System.Windows.Forms.Button()
        Me.btnfachada = New System.Windows.Forms.Button()
        Me.btncanceles = New System.Windows.Forms.Button()
        Me.btnespejo = New System.Windows.Forms.Button()
        Me.btndomo = New System.Windows.Forms.Button()
        Me.btnbarandales = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.menu_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Pperfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.menu_close)
        Me.Panel1.Controls.Add(Me.Pmenu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1105, 40)
        Me.Panel1.TabIndex = 0
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
        Me.Panel2.Size = New System.Drawing.Size(200, 692)
        Me.Panel2.TabIndex = 1
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
        'btnventanas
        '
        Me.btnventanas.BackColor = System.Drawing.Color.LightCyan
        Me.btnventanas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnventanas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnventanas.FlatAppearance.BorderSize = 0
        Me.btnventanas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnventanas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnventanas.ForeColor = System.Drawing.Color.Black
        Me.btnventanas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnventanas.Location = New System.Drawing.Point(509, 333)
        Me.btnventanas.Margin = New System.Windows.Forms.Padding(5)
        Me.btnventanas.Name = "btnventanas"
        Me.btnventanas.Padding = New System.Windows.Forms.Padding(5)
        Me.btnventanas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnventanas.Size = New System.Drawing.Size(211, 167)
        Me.btnventanas.TabIndex = 11
        Me.btnventanas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnventanas.UseVisualStyleBackColor = False
        '
        'btnfachada
        '
        Me.btnfachada.BackColor = System.Drawing.Color.LightCyan
        Me.btnfachada.BackgroundImage = Global.Diseño_Menu_Despegable_Izquierdo.My.Resources.Resources.cubiertas
        Me.btnfachada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnfachada.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnfachada.FlatAppearance.BorderSize = 0
        Me.btnfachada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfachada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfachada.ForeColor = System.Drawing.Color.Black
        Me.btnfachada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnfachada.Location = New System.Drawing.Point(779, 122)
        Me.btnfachada.Margin = New System.Windows.Forms.Padding(5)
        Me.btnfachada.Name = "btnfachada"
        Me.btnfachada.Padding = New System.Windows.Forms.Padding(5)
        Me.btnfachada.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnfachada.Size = New System.Drawing.Size(211, 167)
        Me.btnfachada.TabIndex = 15
        Me.btnfachada.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnfachada.UseVisualStyleBackColor = False
        '
        'btncanceles
        '
        Me.btncanceles.BackColor = System.Drawing.Color.LightCyan
        Me.btncanceles.BackgroundImage = Global.Diseño_Menu_Despegable_Izquierdo.My.Resources.Resources.canceles
        Me.btncanceles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncanceles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btncanceles.FlatAppearance.BorderSize = 0
        Me.btncanceles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncanceles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncanceles.ForeColor = System.Drawing.Color.Black
        Me.btncanceles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncanceles.Location = New System.Drawing.Point(509, 122)
        Me.btncanceles.Margin = New System.Windows.Forms.Padding(5)
        Me.btncanceles.Name = "btncanceles"
        Me.btncanceles.Padding = New System.Windows.Forms.Padding(5)
        Me.btncanceles.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btncanceles.Size = New System.Drawing.Size(211, 167)
        Me.btncanceles.TabIndex = 14
        Me.btncanceles.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncanceles.UseVisualStyleBackColor = False
        '
        'btnespejo
        '
        Me.btnespejo.BackColor = System.Drawing.Color.LightCyan
        Me.btnespejo.BackgroundImage = Global.Diseño_Menu_Despegable_Izquierdo.My.Resources.Resources.espejos
        Me.btnespejo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnespejo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnespejo.FlatAppearance.BorderSize = 0
        Me.btnespejo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnespejo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnespejo.ForeColor = System.Drawing.Color.Black
        Me.btnespejo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnespejo.Location = New System.Drawing.Point(251, 333)
        Me.btnespejo.Margin = New System.Windows.Forms.Padding(5)
        Me.btnespejo.Name = "btnespejo"
        Me.btnespejo.Padding = New System.Windows.Forms.Padding(5)
        Me.btnespejo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnespejo.Size = New System.Drawing.Size(199, 165)
        Me.btnespejo.TabIndex = 13
        Me.btnespejo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnespejo.UseVisualStyleBackColor = False
        '
        'btndomo
        '
        Me.btndomo.BackColor = System.Drawing.Color.LightCyan
        Me.btndomo.BackgroundImage = Global.Diseño_Menu_Despegable_Izquierdo.My.Resources.Resources.domos
        Me.btndomo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btndomo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btndomo.FlatAppearance.BorderSize = 0
        Me.btndomo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndomo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndomo.ForeColor = System.Drawing.Color.Black
        Me.btndomo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndomo.Location = New System.Drawing.Point(779, 333)
        Me.btndomo.Margin = New System.Windows.Forms.Padding(5)
        Me.btndomo.Name = "btndomo"
        Me.btndomo.Padding = New System.Windows.Forms.Padding(5)
        Me.btndomo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btndomo.Size = New System.Drawing.Size(211, 167)
        Me.btndomo.TabIndex = 12
        Me.btndomo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndomo.UseVisualStyleBackColor = False
        '
        'btnbarandales
        '
        Me.btnbarandales.BackColor = System.Drawing.Color.LightCyan
        Me.btnbarandales.BackgroundImage = Global.Diseño_Menu_Despegable_Izquierdo.My.Resources.Resources.arandales
        Me.btnbarandales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbarandales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnbarandales.FlatAppearance.BorderSize = 0
        Me.btnbarandales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbarandales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbarandales.ForeColor = System.Drawing.Color.Black
        Me.btnbarandales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbarandales.Location = New System.Drawing.Point(251, 124)
        Me.btnbarandales.Margin = New System.Windows.Forms.Padding(5)
        Me.btnbarandales.Name = "btnbarandales"
        Me.btnbarandales.Padding = New System.Windows.Forms.Padding(5)
        Me.btnbarandales.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnbarandales.Size = New System.Drawing.Size(199, 165)
        Me.btnbarandales.TabIndex = 11
        Me.btnbarandales.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnbarandales.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1105, 732)
        Me.Controls.Add(Me.btnfachada)
        Me.Controls.Add(Me.btncanceles)
        Me.Controls.Add(Me.btnespejo)
        Me.Controls.Add(Me.btndomo)
        Me.Controls.Add(Me.btnventanas)
        Me.Controls.Add(Me.btnbarandales)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DISEÑO DE FORMULARIO"
        Me.Panel1.ResumeLayout(False)
        CType(Me.menu_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pmenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Pperfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Pmenu As System.Windows.Forms.PictureBox
    Friend WithEvents Pperfil As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents menu_close As PictureBox
    Friend WithEvents btnbarandales As Button
    Friend WithEvents btnventanas As Button
    Friend WithEvents btndomo As Button
    Friend WithEvents btnespejo As Button
    Friend WithEvents btncanceles As Button
    Friend WithEvents btnfachada As Button
End Class
