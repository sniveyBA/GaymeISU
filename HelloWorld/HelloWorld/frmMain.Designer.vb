﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExplore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExplore))
        Me.lblTitle = New System.Windows.Forms.Label
        Me.btnExplore = New System.Windows.Forms.Button
        Me.btnPlay = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Abel", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(214, 57)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(502, 167)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Hello World"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExplore
        '
        Me.btnExplore.BackColor = System.Drawing.Color.Black
        Me.btnExplore.Font = New System.Drawing.Font("Abel", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExplore.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExplore.Location = New System.Drawing.Point(366, 227)
        Me.btnExplore.Name = "btnExplore"
        Me.btnExplore.Size = New System.Drawing.Size(145, 73)
        Me.btnExplore.TabIndex = 2
        Me.btnExplore.Text = "Explore "
        Me.btnExplore.UseVisualStyleBackColor = False
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.Black
        Me.btnPlay.Font = New System.Drawing.Font("Abel", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPlay.Location = New System.Drawing.Point(366, 315)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(145, 73)
        Me.btnPlay.TabIndex = 3
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'frmExplore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(919, 522)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.btnExplore)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmExplore"
        Me.Text = "Hello World"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnExplore As System.Windows.Forms.Button
    Friend WithEvents btnPlay As System.Windows.Forms.Button

End Class
