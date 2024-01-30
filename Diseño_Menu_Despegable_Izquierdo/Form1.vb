Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Windows
Imports CustomControls.RJControls


Public Class Form1

    Dim vistaMenu As Boolean = True

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
    Private Sub btnbarandales_MouseEnter(sender As Object, e As EventArgs) Handles btnbarandales.MouseEnter
        ' Cambia la apariencia cuando el mouse entra al botón
        btnbarandales.Size = New Size(230, 190)
        btnbarandales.BackgroundImageLayout = ImageLayout.Stretch ' O el diseño que desees
        btnbarandales.Location = New Point(239, 110)
        PersonalizarBoton(btnbarandales, 15)

    End Sub

    Private Sub btnbarandales_MouseLeave(sender As Object, e As EventArgs) Handles btnbarandales.MouseLeave
        ' Restaura la apariencia original cuando el mouse sale del botón
        btnbarandales.Size = New Size(211, 165)
        btnbarandales.BackgroundImageLayout = ImageLayout.Stretch
        btnbarandales.Location = New Point(251, 124)
        PersonalizarBoton(btnbarandales, 15)
    End Sub



    Private Sub btnbarandales_Click_1(sender As Object, e As EventArgs) Handles btnbarandales.Click
        btnbarandales.BackgroundImageLayout = ImageLayout.Stretch ' O el diseño que desees
        btnbarandales.Location = New Point(251, 124)
        btnbarandales.Size = New Size(211, 165)

        PersonalizarBoton(btnbarandales, 15)

        If Application.OpenForms.OfType(Of Cotizacion).Any() Then
            ' Si ya está abierto, enfocar en él
            Application.OpenForms.OfType(Of Cotizacion).First().Focus()
        Else
            ' Si no está abierto, crear una instancia y mostrarlo
            Dim form2 As New Cotizacion()
            form2.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub btncanceles_MouseEnter(sender As Object, e As EventArgs) Handles btncanceles.MouseEnter
        ' Cambia la apariencia cuando el mouse entra al botón
        btncanceles.Size = New Size(230, 190)
        btncanceles.BackgroundImageLayout = ImageLayout.Stretch ' O el diseño que desees
        btncanceles.Location = New Point(509, 110)
        PersonalizarBoton(btncanceles, 15)

    End Sub

    Private Sub btncanceles_MouseLeave(sender As Object, e As EventArgs) Handles btncanceles.MouseLeave
        ' Restaura la apariencia original cuando el mouse sale del botón
        btncanceles.Size = New Size(211, 165)
        btncanceles.BackgroundImageLayout = ImageLayout.Stretch
        btncanceles.Location = New Point(509, 122)
        PersonalizarBoton(btncanceles, 15)
    End Sub
    Private Sub btncanceles_Click(sender As Object, e As EventArgs) Handles btncanceles.Click
        btncanceles.BackgroundImageLayout = ImageLayout.Stretch ' O el diseño que desees
        btncanceles.Size = New Size(211, 165)
        btncanceles.Location = New Point(509, 122)
        PersonalizarBoton(btncanceles, 15)
    End Sub

    Private Sub btnespejo_MouseEnter(sender As Object, e As EventArgs) Handles btnespejo.MouseEnter
        ' Cambia la apariencia cuando el mouse entra al botón
        btnespejo.Size = New Size(218, 190)
        btnespejo.BackgroundImageLayout = ImageLayout.Stretch ' O el diseño que desees
        btnespejo.Location = New Point(251, 333)
        PersonalizarBoton(btnespejo, 15)

    End Sub

    Private Sub bbtnespejo_MouseLeave(sender As Object, e As EventArgs) Handles btnespejo.MouseLeave
        ' Restaura la apariencia original cuando el mouse sale del botón
        btnespejo.Size = New Size(199, 165)
        btnespejo.BackgroundImageLayout = ImageLayout.Stretch
        btnespejo.Location = New Point(251, 333)
        PersonalizarBoton(btnespejo, 15)
    End Sub
    Private Sub btnespejo_Click(sender As Object, e As EventArgs) Handles btnespejo.Click
        btnespejo.BackgroundImageLayout = ImageLayout.Stretch ' O el diseño que desees
        btnespejo.Size = New Size(199, 165)
        btnespejo.Location = New Point(251, 333)
        PersonalizarBoton(btnespejo, 15)
    End Sub

    Private Sub Pperfil_Click(sender As Object, e As EventArgs) Handles Pperfil.Click
        If Application.OpenForms.OfType(Of Form1).Any() Then
            ' Si ya está abierto, enfocar en él
            Application.OpenForms.OfType(Of Form1).First().Focus()
        Else
            ' Si no está abierto, crear una instancia y mostrarlo
            Dim form1 As New Form1()
            form1.Show()
            Me.Hide()
        End If
    End Sub


End Class


