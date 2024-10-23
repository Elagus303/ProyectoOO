<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventario
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
        Me.Hojas = New System.Windows.Forms.Label()
        Me.Tinta = New System.Windows.Forms.Label()
        Me.Anillos = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Addhojas = New System.Windows.Forms.Button()
        Me.addtinta = New System.Windows.Forms.Button()
        Me.addAnillos = New System.Windows.Forms.Button()
        Me.Addtaptrans = New System.Windows.Forms.Button()
        Me.Addtapaosc = New System.Windows.Forms.Button()
        Me.Cantaddtinta = New System.Windows.Forms.TextBox()
        Me.Cantaddhojas = New System.Windows.Forms.TextBox()
        Me.Cantaddtaptrans = New System.Windows.Forms.TextBox()
        Me.Cantaddtaposcu = New System.Windows.Forms.TextBox()
        Me.Cantaddanillos = New System.Windows.Forms.TextBox()
        Me.TapTrans = New System.Windows.Forms.Label()
        Me.TapOsc = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Hojas
        '
        Me.Hojas.AutoSize = True
        Me.Hojas.Location = New System.Drawing.Point(12, 67)
        Me.Hojas.Name = "Hojas"
        Me.Hojas.Size = New System.Drawing.Size(37, 13)
        Me.Hojas.TabIndex = 0
        Me.Hojas.Text = "Hojas:"
        '
        'Tinta
        '
        Me.Tinta.AutoSize = True
        Me.Tinta.Location = New System.Drawing.Point(12, 94)
        Me.Tinta.Name = "Tinta"
        Me.Tinta.Size = New System.Drawing.Size(78, 13)
        Me.Tinta.TabIndex = 1
        Me.Tinta.Text = "Tarros de tinta:"
        '
        'Anillos
        '
        Me.Anillos.AutoSize = True
        Me.Anillos.Location = New System.Drawing.Point(12, 118)
        Me.Anillos.Name = "Anillos"
        Me.Anillos.Size = New System.Drawing.Size(40, 13)
        Me.Anillos.TabIndex = 2
        Me.Anillos.Text = "Anillos:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(132, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 37)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Inventario"
        '
        'Addhojas
        '
        Me.Addhojas.Location = New System.Drawing.Point(216, 62)
        Me.Addhojas.Name = "Addhojas"
        Me.Addhojas.Size = New System.Drawing.Size(75, 23)
        Me.Addhojas.TabIndex = 4
        Me.Addhojas.Text = "Añadir"
        Me.Addhojas.UseVisualStyleBackColor = True
        '
        'addtinta
        '
        Me.addtinta.Location = New System.Drawing.Point(216, 94)
        Me.addtinta.Name = "addtinta"
        Me.addtinta.Size = New System.Drawing.Size(75, 23)
        Me.addtinta.TabIndex = 5
        Me.addtinta.Text = "Añadir"
        Me.addtinta.UseVisualStyleBackColor = True
        '
        'addAnillos
        '
        Me.addAnillos.Location = New System.Drawing.Point(216, 118)
        Me.addAnillos.Name = "addAnillos"
        Me.addAnillos.Size = New System.Drawing.Size(75, 23)
        Me.addAnillos.TabIndex = 6
        Me.addAnillos.Text = "Añadir"
        Me.addAnillos.UseVisualStyleBackColor = True
        '
        'Addtaptrans
        '
        Me.Addtaptrans.Location = New System.Drawing.Point(216, 142)
        Me.Addtaptrans.Name = "Addtaptrans"
        Me.Addtaptrans.Size = New System.Drawing.Size(75, 23)
        Me.Addtaptrans.TabIndex = 7
        Me.Addtaptrans.Text = "Añadir"
        Me.Addtaptrans.UseVisualStyleBackColor = True
        '
        'Addtapaosc
        '
        Me.Addtapaosc.Location = New System.Drawing.Point(216, 168)
        Me.Addtapaosc.Name = "Addtapaosc"
        Me.Addtapaosc.Size = New System.Drawing.Size(75, 23)
        Me.Addtapaosc.TabIndex = 8
        Me.Addtapaosc.Text = "Añadir"
        Me.Addtapaosc.UseVisualStyleBackColor = True
        '
        'Cantaddtinta
        '
        Me.Cantaddtinta.Location = New System.Drawing.Point(110, 90)
        Me.Cantaddtinta.Name = "Cantaddtinta"
        Me.Cantaddtinta.Size = New System.Drawing.Size(100, 20)
        Me.Cantaddtinta.TabIndex = 9
        '
        'Cantaddhojas
        '
        Me.Cantaddhojas.Location = New System.Drawing.Point(110, 67)
        Me.Cantaddhojas.Name = "Cantaddhojas"
        Me.Cantaddhojas.Size = New System.Drawing.Size(100, 20)
        Me.Cantaddhojas.TabIndex = 10
        '
        'Cantaddtaptrans
        '
        Me.Cantaddtaptrans.Location = New System.Drawing.Point(110, 142)
        Me.Cantaddtaptrans.Name = "Cantaddtaptrans"
        Me.Cantaddtaptrans.Size = New System.Drawing.Size(100, 20)
        Me.Cantaddtaptrans.TabIndex = 11
        '
        'Cantaddtaposcu
        '
        Me.Cantaddtaposcu.Location = New System.Drawing.Point(110, 170)
        Me.Cantaddtaposcu.Name = "Cantaddtaposcu"
        Me.Cantaddtaposcu.Size = New System.Drawing.Size(100, 20)
        Me.Cantaddtaposcu.TabIndex = 12
        '
        'Cantaddanillos
        '
        Me.Cantaddanillos.Location = New System.Drawing.Point(110, 116)
        Me.Cantaddanillos.Name = "Cantaddanillos"
        Me.Cantaddanillos.Size = New System.Drawing.Size(100, 20)
        Me.Cantaddanillos.TabIndex = 13
        '
        'TapTrans
        '
        Me.TapTrans.AutoSize = True
        Me.TapTrans.Location = New System.Drawing.Point(12, 145)
        Me.TapTrans.Name = "TapTrans"
        Me.TapTrans.Size = New System.Drawing.Size(101, 13)
        Me.TapTrans.TabIndex = 14
        Me.TapTrans.Text = "Tapa Transparente:"
        '
        'TapOsc
        '
        Me.TapOsc.AutoSize = True
        Me.TapOsc.Location = New System.Drawing.Point(12, 173)
        Me.TapOsc.Name = "TapOsc"
        Me.TapOsc.Size = New System.Drawing.Size(72, 13)
        Me.TapOsc.TabIndex = 15
        Me.TapOsc.Text = "Tapa Oscura:"
        '
        'inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(400, 261)
        Me.Controls.Add(Me.TapOsc)
        Me.Controls.Add(Me.TapTrans)
        Me.Controls.Add(Me.Cantaddanillos)
        Me.Controls.Add(Me.Cantaddtaposcu)
        Me.Controls.Add(Me.Cantaddtaptrans)
        Me.Controls.Add(Me.Cantaddhojas)
        Me.Controls.Add(Me.Cantaddtinta)
        Me.Controls.Add(Me.Addtapaosc)
        Me.Controls.Add(Me.Addtaptrans)
        Me.Controls.Add(Me.addAnillos)
        Me.Controls.Add(Me.addtinta)
        Me.Controls.Add(Me.Addhojas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Anillos)
        Me.Controls.Add(Me.Tinta)
        Me.Controls.Add(Me.Hojas)
        Me.Name = "inventario"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Hojas As System.Windows.Forms.Label
    Friend WithEvents Tinta As System.Windows.Forms.Label
    Friend WithEvents Anillos As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Addhojas As System.Windows.Forms.Button
    Friend WithEvents addtinta As System.Windows.Forms.Button
    Friend WithEvents addAnillos As System.Windows.Forms.Button
    Friend WithEvents Addtaptrans As System.Windows.Forms.Button
    Friend WithEvents Addtapaosc As System.Windows.Forms.Button
    Friend WithEvents Cantaddtinta As System.Windows.Forms.TextBox
    Friend WithEvents Cantaddhojas As System.Windows.Forms.TextBox
    Friend WithEvents Cantaddtaptrans As System.Windows.Forms.TextBox
    Friend WithEvents Cantaddtaposcu As System.Windows.Forms.TextBox
    Friend WithEvents Cantaddanillos As System.Windows.Forms.TextBox
    Friend WithEvents TapTrans As System.Windows.Forms.Label
    Friend WithEvents TapOsc As System.Windows.Forms.Label
End Class
