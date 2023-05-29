<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastro
    Inherits System.Windows.Forms.Form


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


    Private components As System.ComponentModel.IContainer


    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Cadastro))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()



        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(143, 221)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 28)
        Label1.TabIndex = 0
        Label1.Text = "Email"

        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(128, 286)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 28)
        Label2.TabIndex = 1
        Label2.Text = "Usuário"

        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(138, 358)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 28)
        Label3.TabIndex = 2
        Label3.Text = "Senha"

        TextBox1.Location = New Point(239, 222)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(236, 27)
        TextBox1.TabIndex = 3

        TextBox2.Location = New Point(239, 286)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(236, 27)
        TextBox2.TabIndex = 4

        TextBox3.Location = New Point(239, 358)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(236, 27)
        TextBox3.TabIndex = 5

        Button1.Location = New Point(602, 390)
        Button1.Name = "Button1"
        Button1.Size = New Size(157, 39)
        Button1.TabIndex = 6
        Button1.Text = "Registrar-se"
        Button1.UseVisualStyleBackColor = True

        PictureBox1.BackColor = SystemColors.ButtonFace
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(285, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(190, 166)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False


        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "Cadastro"
        Text = "Cadastro"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
