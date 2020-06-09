<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registreer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnRegistreer = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtWachtwoord2 = New System.Windows.Forms.TextBox()
        Me.txtWachtwoord1 = New System.Windows.Forms.TextBox()
        Me.txtNaam = New System.Windows.Forms.TextBox()
        Me.txtVoornaam = New System.Windows.Forms.TextBox()
        Me.lblWachtwoord2 = New System.Windows.Forms.Label()
        Me.lblWachtwoord1 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblNaam = New System.Windows.Forms.Label()
        Me.lblVoornaam = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(378, 258)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(232, 70)
        Me.btnLogin.TabIndex = 26
        Me.btnLogin.Text = "login indien al een account"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnRegistreer
        '
        Me.btnRegistreer.Location = New System.Drawing.Point(95, 258)
        Me.btnRegistreer.Name = "btnRegistreer"
        Me.btnRegistreer.Size = New System.Drawing.Size(145, 70)
        Me.btnRegistreer.TabIndex = 25
        Me.btnRegistreer.Text = "registreer"
        Me.btnRegistreer.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(323, 202)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(357, 29)
        Me.txtUsername.TabIndex = 24
        '
        'txtWachtwoord2
        '
        Me.txtWachtwoord2.Location = New System.Drawing.Point(323, 157)
        Me.txtWachtwoord2.Name = "txtWachtwoord2"
        Me.txtWachtwoord2.Size = New System.Drawing.Size(357, 29)
        Me.txtWachtwoord2.TabIndex = 23
        '
        'txtWachtwoord1
        '
        Me.txtWachtwoord1.Location = New System.Drawing.Point(323, 114)
        Me.txtWachtwoord1.Name = "txtWachtwoord1"
        Me.txtWachtwoord1.Size = New System.Drawing.Size(357, 29)
        Me.txtWachtwoord1.TabIndex = 22
        '
        'txtNaam
        '
        Me.txtNaam.Location = New System.Drawing.Point(323, 76)
        Me.txtNaam.Name = "txtNaam"
        Me.txtNaam.Size = New System.Drawing.Size(357, 29)
        Me.txtNaam.TabIndex = 21
        '
        'txtVoornaam
        '
        Me.txtVoornaam.Location = New System.Drawing.Point(323, 41)
        Me.txtVoornaam.Name = "txtVoornaam"
        Me.txtVoornaam.Size = New System.Drawing.Size(357, 29)
        Me.txtVoornaam.TabIndex = 20
        '
        'lblWachtwoord2
        '
        Me.lblWachtwoord2.AutoSize = True
        Me.lblWachtwoord2.Location = New System.Drawing.Point(42, 157)
        Me.lblWachtwoord2.Name = "lblWachtwoord2"
        Me.lblWachtwoord2.Size = New System.Drawing.Size(202, 25)
        Me.lblWachtwoord2.TabIndex = 19
        Me.lblWachtwoord2.Text = "herhaal u wachtwoord"
        '
        'lblWachtwoord1
        '
        Me.lblWachtwoord1.AutoSize = True
        Me.lblWachtwoord1.Location = New System.Drawing.Point(42, 114)
        Me.lblWachtwoord1.Name = "lblWachtwoord1"
        Me.lblWachtwoord1.Size = New System.Drawing.Size(116, 25)
        Me.lblWachtwoord1.TabIndex = 18
        Me.lblWachtwoord1.Text = "wachtwoord"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(42, 202)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(152, 25)
        Me.lblUsername.TabIndex = 17
        Me.lblUsername.Text = "gebruikersnaam"
        '
        'lblNaam
        '
        Me.lblNaam.AutoSize = True
        Me.lblNaam.Location = New System.Drawing.Point(42, 78)
        Me.lblNaam.Name = "lblNaam"
        Me.lblNaam.Size = New System.Drawing.Size(61, 25)
        Me.lblNaam.TabIndex = 16
        Me.lblNaam.Text = "naam"
        '
        'lblVoornaam
        '
        Me.lblVoornaam.AutoSize = True
        Me.lblVoornaam.Location = New System.Drawing.Point(42, 44)
        Me.lblVoornaam.Name = "lblVoornaam"
        Me.lblVoornaam.Size = New System.Drawing.Size(99, 25)
        Me.lblVoornaam.TabIndex = 15
        Me.lblVoornaam.Text = "voornaam"
        '
        'registreer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 372)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnRegistreer)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtWachtwoord2)
        Me.Controls.Add(Me.txtWachtwoord1)
        Me.Controls.Add(Me.txtNaam)
        Me.Controls.Add(Me.txtVoornaam)
        Me.Controls.Add(Me.lblWachtwoord2)
        Me.Controls.Add(Me.lblWachtwoord1)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblNaam)
        Me.Controls.Add(Me.lblVoornaam)
        Me.Name = "registreer"
        Me.Text = "registreer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegistreer As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtWachtwoord2 As TextBox
    Friend WithEvents txtWachtwoord1 As TextBox
    Friend WithEvents txtNaam As TextBox
    Friend WithEvents txtVoornaam As TextBox
    Friend WithEvents lblWachtwoord2 As Label
    Friend WithEvents lblWachtwoord1 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblNaam As Label
    Friend WithEvents lblVoornaam As Label
End Class
