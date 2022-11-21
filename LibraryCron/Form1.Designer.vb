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
        Me.cbRunBG = New System.Windows.Forms.CheckBox()
        Me.btnSaveSetting = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbRunBG
        '
        Me.cbRunBG.AutoSize = True
        Me.cbRunBG.Location = New System.Drawing.Point(43, 42)
        Me.cbRunBG.Name = "cbRunBG"
        Me.cbRunBG.Size = New System.Drawing.Size(127, 19)
        Me.cbRunBG.TabIndex = 0
        Me.cbRunBG.Text = "Run In Background"
        Me.cbRunBG.UseVisualStyleBackColor = True
        '
        'btnSaveSetting
        '
        Me.btnSaveSetting.Location = New System.Drawing.Point(29, 98)
        Me.btnSaveSetting.Name = "btnSaveSetting"
        Me.btnSaveSetting.Size = New System.Drawing.Size(164, 32)
        Me.btnSaveSetting.TabIndex = 1
        Me.btnSaveSetting.Text = "Save Setting"
        Me.btnSaveSetting.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(210, 142)
        Me.Controls.Add(Me.btnSaveSetting)
        Me.Controls.Add(Me.cbRunBG)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbRunBG As CheckBox
    Friend WithEvents btnSaveSetting As Button
End Class
