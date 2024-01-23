Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports CustomControls.RJControls


Public Class Form1

    Dim vistaMenu As Boolean = False

    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(LR As Integer, TR As Integer, RR As Integer, BR As Integer, WE As Integer, HE As Integer) As IntPtr
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width - 2, Height - 2, 20, 20))
        menu_close.Visible = False
        PersonalizarBoton(btnbarandales, 15)
        PersonalizarBoton(btnventanas, 15)
        PersonalizarBoton(btndomo, 15)
        PersonalizarBoton(btncanceles, 15)
        PersonalizarBoton(btnfachada, 15)
        PersonalizarBoton(btnespejo, 15)
    End Sub
    Private Sub PersonalizarBoton(boton As Button, radioEsquinas As Integer)
        Dim path As New GraphicsPath()

        ' Crear un rectángulo redondeado para las esquinas
        path.AddArc(0, 0, radioEsquinas * 2, radioEsquinas * 2, 180, 90)
        path.AddArc(boton.Width - radioEsquinas * 2, 0, radioEsquinas * 2, radioEsquinas * 2, 270, 90)
        path.AddArc(boton.Width - radioEsquinas * 2, boton.Height - radioEsquinas * 2, radioEsquinas * 2, radioEsquinas * 2, 0, 90)
        path.AddArc(0, boton.Height - radioEsquinas * 2, radioEsquinas * 2, radioEsquinas * 2, 90, 90)
        path.CloseAllFigures()

        ' Asigna el path al botón
        boton.Region = New Region(path)
    End Sub

    Private Sub abrir()
        Pperfil.Size = New Size(154, 112)
        Pperfil.Location = New Point(25, 25)

        GroupBox1.Location = New Point(0, 161)
        Panel2.Width = 200
        posionVertical(Panel2, 176)
    End Sub

    Private Sub cerrar()
        Pperfil.Size = New Size(50, 50)
        Pperfil.Location = New Point(5, 6)

        GroupBox1.Location = New Point(0, 65)
        Panel2.Width = 65
        posionVertical(Panel2, 80)
    End Sub

    Private Sub Pmenu_Click(sender As Object, e As EventArgs) Handles Pmenu.Click
        If vistaMenu = False Then
            abrir()
            vistaMenu = True
            menu_close.Visible = False
            Pmenu.Visible = True
        Else
            cerrar()
            menu_close.Visible = True
            Pmenu.Visible = False
            vistaMenu = False
        End If
    End Sub

    Private Sub posionVertical(ct As Control, posicion As Integer)
        Dim posY As Integer = posicion

        For i = ct.Controls.Count - 1 To 0 Step -1
            Dim btn As Control = ct.Controls(i)
            If TypeOf (btn) Is Button Then
                btn.Location = New Point(btn.Location.X, posicion)
                posicion += btn.Height
                posicion += 10
            End If
        Next
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        ' Puedes poner código adicional aquí si es necesario
    End Sub

    Private Sub menu_close_Click(sender As Object, e As EventArgs) Handles menu_close.Click
        If vistaMenu = False Then
            abrir()
            vistaMenu = True
            menu_close.Visible = False
            Pmenu.Visible = True
        Else
            cerrar()
            menu_close.Visible = True
            Pmenu.Visible = False
            vistaMenu = False
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnbarandales.Click
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width - 2, Height - 2, 20, 20))
    End Sub



End Class


