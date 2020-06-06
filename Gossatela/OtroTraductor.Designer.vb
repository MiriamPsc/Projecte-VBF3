<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OtroTraductor
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnVolver2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Gold
        Me.Label10.Font = New System.Drawing.Font("Itty Bitty Notebook", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(175, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(183, 50)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "OBRIR"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVolver2
        '
        Me.btnVolver2.BackColor = System.Drawing.Color.Gold
        Me.btnVolver2.Font = New System.Drawing.Font("Itty Bitty Notebook", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver2.Location = New System.Drawing.Point(13, 37)
        Me.btnVolver2.Name = "btnVolver2"
        Me.btnVolver2.Size = New System.Drawing.Size(118, 39)
        Me.btnVolver2.TabIndex = 40
        Me.btnVolver2.Text = "TORNAR"
        Me.btnVolver2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Itty Bitty Notebook", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(194, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 39)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "TRADUCTOR"
        '
        'OtroTraductor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 137)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnVolver2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "OtroTraductor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OtroTraductor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents btnVolver2 As Button
    Friend WithEvents Label1 As Label
End Class
