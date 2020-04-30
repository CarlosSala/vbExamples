<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Me.tb_value1 = New System.Windows.Forms.TextBox()
        Me.tb_value2 = New System.Windows.Forms.TextBox()
        Me.LabNombre = New System.Windows.Forms.Label()
        Me.LabEdad = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tb_value1
        '
        Me.tb_value1.Location = New System.Drawing.Point(152, 30)
        Me.tb_value1.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_value1.Name = "tb_value1"
        Me.tb_value1.Size = New System.Drawing.Size(132, 22)
        Me.tb_value1.TabIndex = 1
        '
        'tb_value2
        '
        Me.tb_value2.Location = New System.Drawing.Point(152, 62)
        Me.tb_value2.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_value2.Name = "tb_value2"
        Me.tb_value2.Size = New System.Drawing.Size(132, 22)
        Me.tb_value2.TabIndex = 2
        '
        'LabNombre
        '
        Me.LabNombre.AutoSize = True
        Me.LabNombre.Location = New System.Drawing.Point(37, 33)
        Me.LabNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabNombre.Name = "LabNombre"
        Me.LabNombre.Size = New System.Drawing.Size(51, 17)
        Me.LabNombre.TabIndex = 3
        Me.LabNombre.Text = "valor 1"
        '
        'LabEdad
        '
        Me.LabEdad.AutoSize = True
        Me.LabEdad.Location = New System.Drawing.Point(37, 65)
        Me.LabEdad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabEdad.Name = "LabEdad"
        Me.LabEdad.Size = New System.Drawing.Size(51, 17)
        Me.LabEdad.TabIndex = 4
        Me.LabEdad.Text = "valor 2"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(152, 141)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 28)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Array"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(152, 177)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 28)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Select Case"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(152, 213)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 28)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Ciclos"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(96, 248)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(213, 28)
        Me.Button8.TabIndex = 11
        Me.Button8.Text = "get and set NombreCompleto"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(152, 105)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(100, 28)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "Sumar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(152, 284)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(100, 28)
        Me.Button9.TabIndex = 13
        Me.Button9.Text = "Poliformismo"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(133, 320)
        Me.Button10.Margin = New System.Windows.Forms.Padding(4)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(133, 28)
        Me.Button10.TabIndex = 14
        Me.Button10.Text = "Encapsulación"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(162, 355)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 31)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Herencia"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 429)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.LabEdad)
        Me.Controls.Add(Me.LabNombre)
        Me.Controls.Add(Me.tb_value2)
        Me.Controls.Add(Me.tb_value1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Principal"
        Me.Text = "Principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_value1 As TextBox
    Friend WithEvents tb_value2 As TextBox
    Friend WithEvents LabNombre As Label
    Friend WithEvents LabEdad As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button1 As Button
End Class

