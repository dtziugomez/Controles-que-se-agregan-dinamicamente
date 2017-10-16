Public Class Form1
    Dim inttope As Integer
    Dim intinicial As Integer


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inttope = 0
        intinicial = Me.Controls.Count 'numero de elementos de la coleccion

    End Sub

    Private Sub Form1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim grfx As Graphics = e.Graphics
        grfx.DrawLine(Pens.Black, 0, Me.lblpila.Location.Y - 5, Me.Width, Me.lblpila.Location.Y - 5)


    End Sub
    Private Sub button_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim btnsender As Button = CType(sender, Button)
        Me.labelestatus.Text = "estatus " & btnsender.Text & "ha sido apretado"

    End Sub


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If inttope < 8 Then
            Dim btnsender As Button = CType(sender, Button) 'que hace esta linea
            Dim btnnuevo As Button = New Button()
            btnnuevo.Name = "elemento" & inttope
            btnnuevo.Text = "elemento" & inttope
            btnnuevo.Location = New Point((Me.Width - btnnuevo.Width) / 2, btnsender.Location.Y - btnsender.Height * inttope)
            AddHandler btnnuevo.Click, AddressOf Me.button_click


            Me.Controls.Add(btnnuevo)
            Me.labelestatus.Text = "estatus: elemento " & inttope & "ha sido agregado"
            inttope += 1
        Else
            Me.labelestatus.Text = "estatus: la pila esta llena"
        End If


    End Sub

    Private Sub btnRemover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemover.Click
        Dim btnsender As Button = CType(sender, Button)
        Dim intcontrolesactuales As Integer = Me.Controls.Count
        If (intcontrolesactuales > intinicial) Then
            Me.Controls.Remove(Me.Controls(Me.Controls.Count - 1))
            inttope -= 1
            Me.labelestatus.Text = "estatus: elemento " & inttope & "ha sido quitado"
        Else
            Me.labelestatus.Text = "estatus: la pila esta vacia"

        End If
    End Sub
End Class
