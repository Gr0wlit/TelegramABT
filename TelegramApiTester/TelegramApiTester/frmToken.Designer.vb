<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmToken
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmToken))
        Me.txtToken = New System.Windows.Forms.TextBox()
        Me.lblInfoToken = New System.Windows.Forms.Label()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtToken
        '
        Me.txtToken.Location = New System.Drawing.Point(12, 46)
        Me.txtToken.Name = "txtToken"
        Me.txtToken.Size = New System.Drawing.Size(328, 23)
        Me.txtToken.TabIndex = 0
        '
        'lblInfoToken
        '
        Me.lblInfoToken.AutoSize = True
        Me.lblInfoToken.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblInfoToken.Location = New System.Drawing.Point(107, 28)
        Me.lblInfoToken.Name = "lblInfoToken"
        Me.lblInfoToken.Size = New System.Drawing.Size(139, 15)
        Me.lblInfoToken.TabIndex = 10
        Me.lblInfoToken.Text = "Set the token of your bot"
        '
        'btnSet
        '
        Me.btnSet.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSet.Location = New System.Drawing.Point(129, 75)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(94, 44)
        Me.btnSet.TabIndex = 11
        Me.btnSet.Text = "Set"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'frmToken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 127)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.lblInfoToken)
        Me.Controls.Add(Me.txtToken)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmToken"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Set Token"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtToken As System.Windows.Forms.TextBox
    Friend WithEvents lblInfoToken As System.Windows.Forms.Label
    Friend WithEvents btnSet As System.Windows.Forms.Button
End Class
