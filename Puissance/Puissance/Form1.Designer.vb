<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblR = New System.Windows.Forms.Label()
        Me.txtP = New System.Windows.Forms.TextBox()
        Me.txtN = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(102, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblR
        '
        Me.lblR.AutoSize = True
        Me.lblR.Location = New System.Drawing.Point(119, 219)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(39, 13)
        Me.lblR.TabIndex = 1
        Me.lblR.Text = "Label1"
        '
        'txtP
        '
        Me.txtP.Location = New System.Drawing.Point(87, 140)
        Me.txtP.Name = "txtP"
        Me.txtP.Size = New System.Drawing.Size(100, 20)
        Me.txtP.TabIndex = 2
        '
        'txtN
        '
        Me.txtN.Location = New System.Drawing.Point(87, 100)
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New System.Drawing.Size(100, 20)
        Me.txtN.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 352)
        Me.Controls.Add(Me.txtN)
        Me.Controls.Add(Me.txtP)
        Me.Controls.Add(Me.lblR)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblR As System.Windows.Forms.Label
    Friend WithEvents txtP As System.Windows.Forms.TextBox
    Friend WithEvents txtN As System.Windows.Forms.TextBox

End Class
