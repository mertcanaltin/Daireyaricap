﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rTextBox = New System.Windows.Forms.TextBox()
        Me.HesaplaButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AlanTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Yarıçap (r)"
        '
        'rTextBox
        '
        Me.rTextBox.Location = New System.Drawing.Point(84, 35)
        Me.rTextBox.Name = "rTextBox"
        Me.rTextBox.Size = New System.Drawing.Size(100, 20)
        Me.rTextBox.TabIndex = 1
        '
        'HesaplaButton
        '
        Me.HesaplaButton.Location = New System.Drawing.Point(16, 75)
        Me.HesaplaButton.Name = "HesaplaButton"
        Me.HesaplaButton.Size = New System.Drawing.Size(168, 39)
        Me.HesaplaButton.TabIndex = 2
        Me.HesaplaButton.Text = "Alanı Hesapla"
        Me.HesaplaButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Alan"
        '
        'AlanTextBox
        '
        Me.AlanTextBox.Location = New System.Drawing.Point(75, 133)
        Me.AlanTextBox.Name = "AlanTextBox"
        Me.AlanTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AlanTextBox.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(208, 184)
        Me.Controls.Add(Me.AlanTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.HesaplaButton)
        Me.Controls.Add(Me.rTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Daire Alan Hesabı"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HesaplaButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AlanTextBox As System.Windows.Forms.TextBox

End Class
