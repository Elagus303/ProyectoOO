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
        Me.PrecHoja = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Titlprec = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Prichangehoj = New System.Windows.Forms.Button()
        Me.Changeprictinta = New System.Windows.Forms.Button()
        Me.Changepricani = New System.Windows.Forms.Button()
        Me.Pricchangetaposc = New System.Windows.Forms.Button()
        Me.Prichangetaposc = New System.Windows.Forms.Button()
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
        Me.addtinta.Location = New System.Drawing.Point(216, 90)
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
        'PrecHoja
        '
        Me.PrecHoja.AutoSize = True
        Me.PrecHoja.Location = New System.Drawing.Point(341, 70)
        Me.PrecHoja.Name = "PrecHoja"
        Me.PrecHoja.Size = New System.Drawing.Size(40, 13)
        Me.PrecHoja.TabIndex = 16
        Me.PrecHoja.Text = "Actual:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(341, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(341, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Label3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(341, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(341, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Label6"
        '
        'Titlprec
        '
        Me.Titlprec.AutoSize = True
        Me.Titlprec.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titlprec.Location = New System.Drawing.Point(440, 9)
        Me.Titlprec.Name = "Titlprec"
        Me.Titlprec.Size = New System.Drawing.Size(95, 29)
        Me.Titlprec.TabIndex = 21
        Me.Titlprec.Text = "Precios"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(395, 70)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 22
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(395, 97)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 23
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(395, 121)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 24
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(395, 146)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 25
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(395, 171)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 26
        '
        'Prichangehoj
        '
        Me.Prichangehoj.Location = New System.Drawing.Point(501, 67)
        Me.Prichangehoj.Name = "Prichangehoj"
        Me.Prichangehoj.Size = New System.Drawing.Size(75, 23)
        Me.Prichangehoj.TabIndex = 27
        Me.Prichangehoj.Text = "Cambiar"
        Me.Prichangehoj.UseVisualStyleBackColor = True
        '
        'Changeprictinta
        '
        Me.Changeprictinta.Location = New System.Drawing.Point(501, 94)
        Me.Changeprictinta.Name = "Changeprictinta"
        Me.Changeprictinta.Size = New System.Drawing.Size(75, 23)
        Me.Changeprictinta.TabIndex = 28
        Me.Changeprictinta.Text = "Cambiar"
        Me.Changeprictinta.UseVisualStyleBackColor = True
        '
        'Changepricani
        '
        Me.Changepricani.Location = New System.Drawing.Point(501, 119)
        Me.Changepricani.Name = "Changepricani"
        Me.Changepricani.Size = New System.Drawing.Size(75, 23)
        Me.Changepricani.TabIndex = 29
        Me.Changepricani.Text = "Cambiar"
        Me.Changepricani.UseVisualStyleBackColor = True
        '
        'Pricchangetaposc
        '
        Me.Pricchangetaposc.Location = New System.Drawing.Point(501, 144)
        Me.Pricchangetaposc.Name = "Pricchangetaposc"
        Me.Pricchangetaposc.Size = New System.Drawing.Size(75, 23)
        Me.Pricchangetaposc.TabIndex = 30
        Me.Pricchangetaposc.Text = "Cambiar"
        Me.Pricchangetaposc.UseVisualStyleBackColor = True
        '
        'Prichangetaposc
        '
        Me.Prichangetaposc.Location = New System.Drawing.Point(501, 169)
        Me.Prichangetaposc.Name = "Prichangetaposc"
        Me.Prichangetaposc.Size = New System.Drawing.Size(75, 23)
        Me.Prichangetaposc.TabIndex = 31
        Me.Prichangetaposc.Text = "Cambiar"
        Me.Prichangetaposc.UseVisualStyleBackColor = True
        '
        'inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(719, 258)
        Me.Controls.Add(Me.Prichangetaposc)
        Me.Controls.Add(Me.Pricchangetaposc)
        Me.Controls.Add(Me.Changepricani)
        Me.Controls.Add(Me.Changeprictinta)
        Me.Controls.Add(Me.Prichangehoj)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Titlprec)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PrecHoja)
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
    Friend WithEvents PrecHoja As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Titlprec As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Prichangehoj As System.Windows.Forms.Button
    Friend WithEvents Changeprictinta As System.Windows.Forms.Button
    Friend WithEvents Changepricani As System.Windows.Forms.Button
    Friend WithEvents Pricchangetaposc As System.Windows.Forms.Button
    Friend WithEvents Prichangetaposc As System.Windows.Forms.Button
End Class
