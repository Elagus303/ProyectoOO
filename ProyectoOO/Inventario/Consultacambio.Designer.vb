<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultacambio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Changquest = New System.Windows.Forms.Label()
        Me.Confchange = New System.Windows.Forms.Button()
        Me.Canchange = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Changquest
        '
        Me.Changquest.AutoSize = True
        Me.Changquest.Location = New System.Drawing.Point(21, 18)
        Me.Changquest.Name = "Changquest"
        Me.Changquest.Size = New System.Drawing.Size(158, 13)
        Me.Changquest.TabIndex = 0
        Me.Changquest.Text = "¿Desea conservar los cambios?"
        '
        'Confchange
        '
        Me.Confchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Confchange.Location = New System.Drawing.Point(24, 81)
        Me.Confchange.Name = "Confchange"
        Me.Confchange.Size = New System.Drawing.Size(75, 23)
        Me.Confchange.TabIndex = 1
        Me.Confchange.Text = "Aceptar"
        Me.Confchange.UseVisualStyleBackColor = True
        '
        'Canchange
        '
        Me.Canchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Canchange.Location = New System.Drawing.Point(158, 81)
        Me.Canchange.Name = "Canchange"
        Me.Canchange.Size = New System.Drawing.Size(75, 23)
        Me.Canchange.TabIndex = 2
        Me.Canchange.Text = "Cancelar"
        Me.Canchange.UseVisualStyleBackColor = True
        '
        'Consultacambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(271, 114)
        Me.Controls.Add(Me.Canchange)
        Me.Controls.Add(Me.Confchange)
        Me.Controls.Add(Me.Changquest)
        Me.Name = "Consultacambio"
        Me.Text = "Cambios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Changquest As System.Windows.Forms.Label
    Friend WithEvents Confchange As System.Windows.Forms.Button
    Friend WithEvents Canchange As System.Windows.Forms.Button
End Class
