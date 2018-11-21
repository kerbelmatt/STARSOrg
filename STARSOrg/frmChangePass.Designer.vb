<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePass
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
        Me.lblCurPass = New System.Windows.Forms.Label()
        Me.lblNewPass = New System.Windows.Forms.Label()
        Me.lblConfirmPass = New System.Windows.Forms.Label()
        Me.txtCurrPassword = New System.Windows.Forms.TextBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCurPass
        '
        Me.lblCurPass.AutoSize = True
        Me.lblCurPass.Location = New System.Drawing.Point(12, 21)
        Me.lblCurPass.Name = "lblCurPass"
        Me.lblCurPass.Size = New System.Drawing.Size(101, 13)
        Me.lblCurPass.TabIndex = 0
        Me.lblCurPass.Text = "Current Password:"
        '
        'lblNewPass
        '
        Me.lblNewPass.AutoSize = True
        Me.lblNewPass.Location = New System.Drawing.Point(12, 53)
        Me.lblNewPass.Name = "lblNewPass"
        Me.lblNewPass.Size = New System.Drawing.Size(85, 13)
        Me.lblNewPass.TabIndex = 1
        Me.lblNewPass.Text = "New Password:"
        '
        'lblConfirmPass
        '
        Me.lblConfirmPass.AutoSize = True
        Me.lblConfirmPass.Location = New System.Drawing.Point(12, 85)
        Me.lblConfirmPass.Name = "lblConfirmPass"
        Me.lblConfirmPass.Size = New System.Drawing.Size(103, 13)
        Me.lblConfirmPass.TabIndex = 2
        Me.lblConfirmPass.Text = "Confirm Password:"
        '
        'txtCurrPassword
        '
        Me.txtCurrPassword.Location = New System.Drawing.Point(119, 18)
        Me.txtCurrPassword.Name = "txtCurrPassword"
        Me.txtCurrPassword.Size = New System.Drawing.Size(162, 22)
        Me.txtCurrPassword.TabIndex = 3
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(119, 50)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(162, 22)
        Me.txtNewPassword.TabIndex = 4
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(119, 82)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(162, 22)
        Me.txtConfirmPassword.TabIndex = 5
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(206, 119)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(119, 119)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 7
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'frmChangePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 156)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.txtCurrPassword)
        Me.Controls.Add(Me.lblConfirmPass)
        Me.Controls.Add(Me.lblNewPass)
        Me.Controls.Add(Me.lblCurPass)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangePass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Change Password"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCurPass As Label
    Friend WithEvents lblNewPass As Label
    Friend WithEvents lblConfirmPass As Label
    Friend WithEvents txtCurrPassword As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
End Class
