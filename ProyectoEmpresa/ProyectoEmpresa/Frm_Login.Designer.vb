<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
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
        Me.Lab_user = New System.Windows.Forms.Label()
        Me.Lab_password = New System.Windows.Forms.Label()
        Me.Text_user = New System.Windows.Forms.TextBox()
        Me.Text_password = New System.Windows.Forms.TextBox()
        Me.Btn_login = New System.Windows.Forms.Button()
        Me.Btn_canceled = New System.Windows.Forms.Button()
        Me.lab_connectionState = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lab_user
        '
        Me.Lab_user.AutoSize = True
        Me.Lab_user.Location = New System.Drawing.Point(89, 74)
        Me.Lab_user.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_user.Name = "Lab_user"
        Me.Lab_user.Size = New System.Drawing.Size(38, 17)
        Me.Lab_user.TabIndex = 0
        Me.Lab_user.Text = "User"
        '
        'Lab_password
        '
        Me.Lab_password.AutoSize = True
        Me.Lab_password.Location = New System.Drawing.Point(89, 135)
        Me.Lab_password.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab_password.Name = "Lab_password"
        Me.Lab_password.Size = New System.Drawing.Size(69, 17)
        Me.Lab_password.TabIndex = 1
        Me.Lab_password.Text = "Password"
        '
        'Text_user
        '
        Me.Text_user.Location = New System.Drawing.Point(93, 94)
        Me.Text_user.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Text_user.Name = "Text_user"
        Me.Text_user.Size = New System.Drawing.Size(215, 22)
        Me.Text_user.TabIndex = 2
        '
        'Text_password
        '
        Me.Text_password.Location = New System.Drawing.Point(93, 155)
        Me.Text_password.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Text_password.Name = "Text_password"
        Me.Text_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Text_password.Size = New System.Drawing.Size(215, 22)
        Me.Text_password.TabIndex = 3
        '
        'Btn_login
        '
        Me.Btn_login.Location = New System.Drawing.Point(89, 229)
        Me.Btn_login.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_login.Name = "Btn_login"
        Me.Btn_login.Size = New System.Drawing.Size(100, 28)
        Me.Btn_login.TabIndex = 4
        Me.Btn_login.Text = "Iniciar"
        Me.Btn_login.UseVisualStyleBackColor = True
        '
        'Btn_canceled
        '
        Me.Btn_canceled.Location = New System.Drawing.Point(209, 229)
        Me.Btn_canceled.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_canceled.Name = "Btn_canceled"
        Me.Btn_canceled.Size = New System.Drawing.Size(100, 28)
        Me.Btn_canceled.TabIndex = 5
        Me.Btn_canceled.Text = "Cancelar"
        Me.Btn_canceled.UseVisualStyleBackColor = True
        '
        'lab_connectionState
        '
        Me.lab_connectionState.AutoSize = True
        Me.lab_connectionState.Location = New System.Drawing.Point(89, 26)
        Me.lab_connectionState.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lab_connectionState.Name = "lab_connectionState"
        Me.lab_connectionState.Size = New System.Drawing.Size(0, 17)
        Me.lab_connectionState.TabIndex = 6
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 325)
        Me.Controls.Add(Me.lab_connectionState)
        Me.Controls.Add(Me.Btn_canceled)
        Me.Controls.Add(Me.Btn_login)
        Me.Controls.Add(Me.Text_password)
        Me.Controls.Add(Me.Text_user)
        Me.Controls.Add(Me.Lab_password)
        Me.Controls.Add(Me.Lab_user)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lab_user As Label
    Friend WithEvents Lab_password As Label
    Friend WithEvents Text_user As TextBox
    Friend WithEvents Text_password As TextBox
    Friend WithEvents Btn_login As Button
    Friend WithEvents Btn_canceled As Button
    Friend WithEvents lab_connectionState As Label
End Class
