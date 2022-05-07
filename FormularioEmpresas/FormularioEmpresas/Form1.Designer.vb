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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CodigoTxB = New System.Windows.Forms.TextBox()
        Me.NombreTxB = New System.Windows.Forms.TextBox()
        Me.DireccionLabel = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TelefonoTxB = New System.Windows.Forms.TextBox()
        Me.TelefonoLabel = New System.Windows.Forms.Label()
        Me.LogoImage = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.LogoImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(71, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CODIGO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(71, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOMBRE:"
        '
        'CodigoTxB
        '
        Me.CodigoTxB.Location = New System.Drawing.Point(148, 60)
        Me.CodigoTxB.Name = "CodigoTxB"
        Me.CodigoTxB.ReadOnly = True
        Me.CodigoTxB.Size = New System.Drawing.Size(79, 23)
        Me.CodigoTxB.TabIndex = 2
        Me.CodigoTxB.Text = "0"
        Me.CodigoTxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NombreTxB
        '
        Me.NombreTxB.Location = New System.Drawing.Point(148, 99)
        Me.NombreTxB.Name = "NombreTxB"
        Me.NombreTxB.ReadOnly = True
        Me.NombreTxB.Size = New System.Drawing.Size(221, 23)
        Me.NombreTxB.TabIndex = 3
        Me.NombreTxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DireccionLabel
        '
        Me.DireccionLabel.AutoSize = True
        Me.DireccionLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DireccionLabel.Location = New System.Drawing.Point(71, 143)
        Me.DireccionLabel.Name = "DireccionLabel"
        Me.DireccionLabel.Size = New System.Drawing.Size(71, 15)
        Me.DireccionLabel.TabIndex = 4
        Me.DireccionLabel.Text = "DIRECCION:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(148, 135)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(221, 23)
        Me.TextBox1.TabIndex = 5
        '
        'TelefonoTxB
        '
        Me.TelefonoTxB.Location = New System.Drawing.Point(148, 173)
        Me.TelefonoTxB.Name = "TelefonoTxB"
        Me.TelefonoTxB.ReadOnly = True
        Me.TelefonoTxB.Size = New System.Drawing.Size(221, 23)
        Me.TelefonoTxB.TabIndex = 6
        '
        'TelefonoLabel
        '
        Me.TelefonoLabel.AutoSize = True
        Me.TelefonoLabel.Location = New System.Drawing.Point(71, 176)
        Me.TelefonoLabel.Name = "TelefonoLabel"
        Me.TelefonoLabel.Size = New System.Drawing.Size(67, 15)
        Me.TelefonoLabel.TabIndex = 7
        Me.TelefonoLabel.Text = "TELEFONO:"
        '
        'LogoImage
        '
        Me.LogoImage.Image = Global.FormularioEmpresas.My.Resources.Resources.SDLogo
        Me.LogoImage.Location = New System.Drawing.Point(468, 23)
        Me.LogoImage.Name = "LogoImage"
        Me.LogoImage.Size = New System.Drawing.Size(226, 221)
        Me.LogoImage.TabIndex = 8
        Me.LogoImage.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(264, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LogoImage)
        Me.Controls.Add(Me.TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTxB)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DireccionLabel)
        Me.Controls.Add(Me.NombreTxB)
        Me.Controls.Add(Me.CodigoTxB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Busqueda de Empresas"
        CType(Me.LogoImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CodigoTxB As TextBox
    Friend WithEvents NombreTxB As TextBox
    Friend WithEvents DireccionLabel As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TelefonoTxB As TextBox
    Friend WithEvents TelefonoLabel As Label
    Friend WithEvents LogoImage As PictureBox
    Friend WithEvents Button1 As Button
End Class
