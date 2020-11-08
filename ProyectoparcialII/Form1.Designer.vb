<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Administracion))
        Me.Btn_aceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Text_usuario = New System.Windows.Forms.TextBox()
        Me.Text_contraseña = New System.Windows.Forms.TextBox()
        Me.txt_salir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_aceptar
        '
        Me.Btn_aceptar.Image = CType(resources.GetObject("Btn_aceptar.Image"), System.Drawing.Image)
        Me.Btn_aceptar.Location = New System.Drawing.Point(155, 188)
        Me.Btn_aceptar.Name = "Btn_aceptar"
        Me.Btn_aceptar.Size = New System.Drawing.Size(125, 56)
        Me.Btn_aceptar.TabIndex = 0
        Me.Btn_aceptar.Text = "Aceptar"
        Me.Btn_aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_aceptar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(316, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ADMINITRACION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label2.Location = New System.Drawing.Point(196, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Usuario"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contraseña"
        '
        'Text_usuario
        '
        Me.Text_usuario.Location = New System.Drawing.Point(267, 51)
        Me.Text_usuario.Name = "Text_usuario"
        Me.Text_usuario.Size = New System.Drawing.Size(193, 20)
        Me.Text_usuario.TabIndex = 5
        '
        'Text_contraseña
        '
        Me.Text_contraseña.Location = New System.Drawing.Point(267, 116)
        Me.Text_contraseña.Name = "Text_contraseña"
        Me.Text_contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Text_contraseña.Size = New System.Drawing.Size(193, 20)
        Me.Text_contraseña.TabIndex = 6
        '
        'txt_salir
        '
        Me.txt_salir.Image = CType(resources.GetObject("txt_salir.Image"), System.Drawing.Image)
        Me.txt_salir.Location = New System.Drawing.Point(344, 188)
        Me.txt_salir.Name = "txt_salir"
        Me.txt_salir.Size = New System.Drawing.Size(105, 54)
        Me.txt_salir.TabIndex = 7
        Me.txt_salir.Text = "Salir"
        Me.txt_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.txt_salir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(202, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 30)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(208, 106)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 30)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'Administracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(622, 306)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_salir)
        Me.Controls.Add(Me.Text_contraseña)
        Me.Controls.Add(Me.Text_usuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_aceptar)
        Me.Name = "Administracion"
        Me.Text = "Departamento Tecnico"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Text_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Text_contraseña As System.Windows.Forms.TextBox
    Friend WithEvents txt_salir As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
