<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncomeTracker
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
        Me.btnSpends = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSpends
        '
        Me.btnSpends.Location = New System.Drawing.Point(113, 33)
        Me.btnSpends.Name = "btnSpends"
        Me.btnSpends.Size = New System.Drawing.Size(203, 39)
        Me.btnSpends.TabIndex = 0
        Me.btnSpends.Text = "Spendings"
        Me.btnSpends.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(113, 108)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(203, 39)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Savings"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBal
        '
        Me.btnBal.Location = New System.Drawing.Point(113, 183)
        Me.btnBal.Name = "btnBal"
        Me.btnBal.Size = New System.Drawing.Size(203, 39)
        Me.btnBal.TabIndex = 2
        Me.btnBal.Text = "Balances"
        Me.btnBal.UseVisualStyleBackColor = True
        '
        'IncomeTracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 292)
        Me.Controls.Add(Me.btnBal)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnSpends)
        Me.Name = "IncomeTracker"
        Me.Text = "Income Tracker"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSpends As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnBal As System.Windows.Forms.Button

End Class
