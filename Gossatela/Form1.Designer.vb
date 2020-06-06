<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNivell4 = New System.Windows.Forms.Button()
        Me.btnNivell3 = New System.Windows.Forms.Button()
        Me.btnNivell2 = New System.Windows.Forms.Button()
        Me.btnNivell1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Itty Bitty Notebook", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(155, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 67)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "CURS DE CATALÀ"
        '
        'btnNivell4
        '
        Me.btnNivell4.BackColor = System.Drawing.Color.Gold
        Me.btnNivell4.Font = New System.Drawing.Font("Itty Bitty Notebook", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNivell4.Location = New System.Drawing.Point(499, 81)
        Me.btnNivell4.Name = "btnNivell4"
        Me.btnNivell4.Size = New System.Drawing.Size(141, 62)
        Me.btnNivell4.TabIndex = 8
        Me.btnNivell4.Text = "CANÇONS"
        Me.btnNivell4.UseVisualStyleBackColor = False
        '
        'btnNivell3
        '
        Me.btnNivell3.BackColor = System.Drawing.Color.Gold
        Me.btnNivell3.Font = New System.Drawing.Font("Itty Bitty Notebook", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNivell3.Location = New System.Drawing.Point(325, 81)
        Me.btnNivell3.Name = "btnNivell3"
        Me.btnNivell3.Size = New System.Drawing.Size(168, 62)
        Me.btnNivell3.TabIndex = 7
        Me.btnNivell3.Text = "TRADUCTOR"
        Me.btnNivell3.UseVisualStyleBackColor = False
        '
        'btnNivell2
        '
        Me.btnNivell2.BackColor = System.Drawing.Color.Gold
        Me.btnNivell2.Font = New System.Drawing.Font("Itty Bitty Notebook", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNivell2.Location = New System.Drawing.Point(167, 81)
        Me.btnNivell2.Name = "btnNivell2"
        Me.btnNivell2.Size = New System.Drawing.Size(146, 62)
        Me.btnNivell2.TabIndex = 6
        Me.btnNivell2.Text = "NIVELL 2"
        Me.btnNivell2.UseVisualStyleBackColor = False
        '
        'btnNivell1
        '
        Me.btnNivell1.BackColor = System.Drawing.Color.Gold
        Me.btnNivell1.Font = New System.Drawing.Font("Itty Bitty Notebook", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNivell1.Location = New System.Drawing.Point(12, 81)
        Me.btnNivell1.Name = "btnNivell1"
        Me.btnNivell1.Size = New System.Drawing.Size(149, 62)
        Me.btnNivell1.TabIndex = 5
        Me.btnNivell1.Text = "NIVELL 1"
        Me.btnNivell1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 157)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNivell4)
        Me.Controls.Add(Me.btnNivell3)
        Me.Controls.Add(Me.btnNivell2)
        Me.Controls.Add(Me.btnNivell1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnNivell4 As Button
    Friend WithEvents btnNivell3 As Button
    Friend WithEvents btnNivell2 As Button
    Friend WithEvents btnNivell1 As Button
End Class
