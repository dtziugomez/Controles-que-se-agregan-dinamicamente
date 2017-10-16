<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.labelestatus = New System.Windows.Forms.Label
        Me.lblpila = New System.Windows.Forms.Label
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.btnRemover = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'labelestatus
        '
        Me.labelestatus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.labelestatus.AutoSize = True
        Me.labelestatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelestatus.Location = New System.Drawing.Point(249, 13)
        Me.labelestatus.Name = "labelestatus"
        Me.labelestatus.Size = New System.Drawing.Size(56, 18)
        Me.labelestatus.TabIndex = 0
        Me.labelestatus.Text = "Label1"
        Me.labelestatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblpila
        '
        Me.lblpila.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblpila.AutoSize = True
        Me.lblpila.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpila.Location = New System.Drawing.Point(202, 247)
        Me.lblpila.Name = "lblpila"
        Me.lblpila.Size = New System.Drawing.Size(148, 24)
        Me.lblpila.TabIndex = 1
        Me.lblpila.Text = "Base de la pila"
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Location = New System.Drawing.Point(26, 219)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnRemover
        '
        Me.btnRemover.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemover.Location = New System.Drawing.Point(472, 219)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(75, 23)
        Me.btnRemover.TabIndex = 3
        Me.btnRemover.Text = "&Remover"
        Me.btnRemover.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 280)
        Me.Controls.Add(Me.btnRemover)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblpila)
        Me.Controls.Add(Me.labelestatus)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelestatus As System.Windows.Forms.Label
    Friend WithEvents lblpila As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnRemover As System.Windows.Forms.Button

End Class
