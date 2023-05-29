<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Textusuario = New Label()
        Textsenha = New Label()
        button1 = New Button()
        Textuser = New TextBox()
        Textsh = New TextBox()
        PictureBox1 = New PictureBox()
        Button2 = New Button()
        Button3 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Textusuario
        ' 
        Textusuario.AutoSize = True
        Textusuario.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Textusuario.Location = New Point(197, 198)
        Textusuario.Name = "Textusuario"
        Textusuario.Size = New Size(90, 28)
        Textusuario.TabIndex = 0
        Textusuario.Text = "Usuário "
        ' 
        ' Textsenha
        ' 
        Textsenha.AutoSize = True
        Textsenha.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Textsenha.Location = New Point(197, 288)
        Textsenha.Name = "Textsenha"
        Textsenha.Size = New Size(69, 28)
        Textsenha.TabIndex = 1
        Textsenha.Text = "Senha"
        ' 
        ' button1
        ' 
        button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        button1.Location = New Point(197, 367)
        button1.Name = "button1"
        button1.Size = New Size(94, 36)
        button1.TabIndex = 2
        button1.Text = "Entrar"
        button1.UseVisualStyleBackColor = True
        ' 
        ' Textuser
        ' 
        Textuser.Location = New Point(293, 198)
        Textuser.Name = "Textuser"
        Textuser.Size = New Size(223, 27)
        Textuser.TabIndex = 3
        ' 
        ' Textsh
        ' 
        Textsh.Location = New Point(293, 288)
        Textsh.Name = "Textsh"
        Textsh.Size = New Size(223, 27)
        Textsh.TabIndex = 4
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(319, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(179, 162)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(662, 402)
        Button2.Name = "Button2"
        Button2.Size = New Size(111, 36)
        Button2.TabIndex = 6
        Button2.Text = "Sair"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(402, 367)
        Button3.Name = "Button3"
        Button3.Size = New Size(140, 36)
        Button3.TabIndex = 7
        Button3.Text = "Cadastre-se"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(PictureBox1)
        Controls.Add(Textsh)
        Controls.Add(Textuser)
        Controls.Add(button1)
        Controls.Add(Textsenha)
        Controls.Add(Textusuario)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Textusuario As Label
    Friend WithEvents Textsenha As Label
    Friend WithEvents button1 As Button
    Friend WithEvents Textuser As TextBox
    Friend WithEvents Textsh As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
