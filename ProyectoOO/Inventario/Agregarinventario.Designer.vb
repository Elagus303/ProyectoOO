<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregarinventario
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
        Me.prodlab = New System.Windows.Forms.Label()
        Me.preclab = New System.Windows.Forms.Label()
        Me.cantlab = New System.Windows.Forms.Label()
        Me.proovlab = New System.Windows.Forms.Label()
        Me.prodtext = New System.Windows.Forms.TextBox()
        Me.prectext = New System.Windows.Forms.TextBox()
        Me.cantprec = New System.Windows.Forms.TextBox()
        Me.proovcant = New System.Windows.Forms.TextBox()
        Me.Aceptbutton = New System.Windows.Forms.Button()
        Me.Canbutton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'prodlab
        '
        Me.prodlab.AutoSize = True
        Me.prodlab.Location = New System.Drawing.Point(7, 36)
        Me.prodlab.Name = "prodlab"
        Me.prodlab.Size = New System.Drawing.Size(50, 13)
        Me.prodlab.TabIndex = 0
        Me.prodlab.Text = "Producto"
        '
        'preclab
        '
        Me.preclab.AutoSize = True
        Me.preclab.Location = New System.Drawing.Point(7, 65)
        Me.preclab.Name = "preclab"
        Me.preclab.Size = New System.Drawing.Size(37, 13)
        Me.preclab.TabIndex = 1
        Me.preclab.Text = "Precio"
        '
        'cantlab
        '
        Me.cantlab.AutoSize = True
        Me.cantlab.Location = New System.Drawing.Point(7, 89)
        Me.cantlab.Name = "cantlab"
        Me.cantlab.Size = New System.Drawing.Size(49, 13)
        Me.cantlab.TabIndex = 2
        Me.cantlab.Text = "Cantidad"
        '
        'proovlab
        '
        Me.proovlab.AutoSize = True
        Me.proovlab.Location = New System.Drawing.Point(6, 118)
        Me.proovlab.Name = "proovlab"
        Me.proovlab.Size = New System.Drawing.Size(56, 13)
        Me.proovlab.TabIndex = 3
        Me.proovlab.Text = "Proovedor"
        '
        'prodtext
        '
        Me.prodtext.Location = New System.Drawing.Point(88, 28)
        Me.prodtext.Name = "prodtext"
        Me.prodtext.Size = New System.Drawing.Size(100, 20)
        Me.prodtext.TabIndex = 4
        '
        'prectext
        '
        Me.prectext.Location = New System.Drawing.Point(88, 58)
        Me.prectext.Name = "prectext"
        Me.prectext.Size = New System.Drawing.Size(100, 20)
        Me.prectext.TabIndex = 5
        '
        'cantprec
        '
        Me.cantprec.Location = New System.Drawing.Point(88, 85)
        Me.cantprec.Name = "cantprec"
        Me.cantprec.Size = New System.Drawing.Size(100, 20)
        Me.cantprec.TabIndex = 6
        '
        'proovcant
        '
        Me.proovcant.Location = New System.Drawing.Point(88, 111)
        Me.proovcant.Name = "proovcant"
        Me.proovcant.Size = New System.Drawing.Size(100, 20)
        Me.proovcant.TabIndex = 7
        '
        'Aceptbutton
        '
        Me.Aceptbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Aceptbutton.Location = New System.Drawing.Point(113, 179)
        Me.Aceptbutton.Name = "Aceptbutton"
        Me.Aceptbutton.Size = New System.Drawing.Size(75, 23)
        Me.Aceptbutton.TabIndex = 8
        Me.Aceptbutton.Text = "Aceptar"
        Me.Aceptbutton.UseVisualStyleBackColor = True
        '
        'Canbutton
        '
        Me.Canbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Canbutton.Location = New System.Drawing.Point(225, 179)
        Me.Canbutton.Name = "Canbutton"
        Me.Canbutton.Size = New System.Drawing.Size(75, 23)
        Me.Canbutton.TabIndex = 9
        Me.Canbutton.Text = "Cancelar"
        Me.Canbutton.UseVisualStyleBackColor = True
        '
        'Agregarinventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(444, 214)
        Me.Controls.Add(Me.Canbutton)
        Me.Controls.Add(Me.Aceptbutton)
        Me.Controls.Add(Me.proovcant)
        Me.Controls.Add(Me.cantprec)
        Me.Controls.Add(Me.prectext)
        Me.Controls.Add(Me.prodtext)
        Me.Controls.Add(Me.proovlab)
        Me.Controls.Add(Me.cantlab)
        Me.Controls.Add(Me.preclab)
        Me.Controls.Add(Me.prodlab)
        Me.Name = "Agregarinventario"
        Me.Text = "Agregar nuevo producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents prodlab As System.Windows.Forms.Label
    Friend WithEvents preclab As System.Windows.Forms.Label
    Friend WithEvents cantlab As System.Windows.Forms.Label
    Friend WithEvents proovlab As System.Windows.Forms.Label
    Friend WithEvents prodtext As System.Windows.Forms.TextBox
    Friend WithEvents prectext As System.Windows.Forms.TextBox
    Friend WithEvents cantprec As System.Windows.Forms.TextBox
    Friend WithEvents proovcant As System.Windows.Forms.TextBox
    Friend WithEvents Aceptbutton As System.Windows.Forms.Button
    Friend WithEvents Canbutton As System.Windows.Forms.Button
End Class
