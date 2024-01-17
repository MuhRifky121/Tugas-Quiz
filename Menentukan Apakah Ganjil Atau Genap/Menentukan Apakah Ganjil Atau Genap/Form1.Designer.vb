<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.txtInputNumber = New System.Windows.Forms.TextBox()
        Me.btnCek = New System.Windows.Forms.Button()
        Me.lblHasil = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtInputNumber
        '
        Me.txtInputNumber.Location = New System.Drawing.Point(24, 41)
        Me.txtInputNumber.Name = "txtInputNumber"
        Me.txtInputNumber.Size = New System.Drawing.Size(128, 26)
        Me.txtInputNumber.TabIndex = 0
        '
        'btnCek
        '
        Me.btnCek.Location = New System.Drawing.Point(24, 87)
        Me.btnCek.Name = "btnCek"
        Me.btnCek.Size = New System.Drawing.Size(78, 26)
        Me.btnCek.TabIndex = 1
        Me.btnCek.Text = "Button1"
        Me.btnCek.UseVisualStyleBackColor = True
        '
        'lblHasil
        '
        Me.lblHasil.AutoSize = True
        Me.lblHasil.Location = New System.Drawing.Point(30, 148)
        Me.lblHasil.Name = "lblHasil"
        Me.lblHasil.Size = New System.Drawing.Size(57, 20)
        Me.lblHasil.TabIndex = 2
        Me.lblHasil.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 434)
        Me.Controls.Add(Me.lblHasil)
        Me.Controls.Add(Me.btnCek)
        Me.Controls.Add(Me.txtInputNumber)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInputNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnCek As System.Windows.Forms.Button
    Friend WithEvents lblHasil As System.Windows.Forms.Label

End Class
