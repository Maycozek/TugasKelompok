<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Pertemuan1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HellowordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pertemuan2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pertemuan3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pertemuan4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pertemuan5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pertemuan6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(232, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FormUtama"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Pertemuan1ToolStripMenuItem, Me.Pertemuan2ToolStripMenuItem, Me.Pertemuan3ToolStripMenuItem, Me.Pertemuan4ToolStripMenuItem, Me.Pertemuan5ToolStripMenuItem, Me.Pertemuan6ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Pertemuan1ToolStripMenuItem
        '
        Me.Pertemuan1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HellowordToolStripMenuItem})
        Me.Pertemuan1ToolStripMenuItem.Name = "Pertemuan1ToolStripMenuItem"
        Me.Pertemuan1ToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.Pertemuan1ToolStripMenuItem.Text = "Pertemuan 1"
        '
        'HellowordToolStripMenuItem
        '
        Me.HellowordToolStripMenuItem.Name = "HellowordToolStripMenuItem"
        Me.HellowordToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.HellowordToolStripMenuItem.Text = "Helloword"
        '
        'Pertemuan2ToolStripMenuItem
        '
        Me.Pertemuan2ToolStripMenuItem.Name = "Pertemuan2ToolStripMenuItem"
        Me.Pertemuan2ToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.Pertemuan2ToolStripMenuItem.Text = "Pertemuan 2"
        '
        'Pertemuan3ToolStripMenuItem
        '
        Me.Pertemuan3ToolStripMenuItem.Name = "Pertemuan3ToolStripMenuItem"
        Me.Pertemuan3ToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.Pertemuan3ToolStripMenuItem.Text = "Pertemuan 3"
        '
        'Pertemuan4ToolStripMenuItem
        '
        Me.Pertemuan4ToolStripMenuItem.Name = "Pertemuan4ToolStripMenuItem"
        Me.Pertemuan4ToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.Pertemuan4ToolStripMenuItem.Text = "Pertemuan 4"
        '
        'Pertemuan5ToolStripMenuItem
        '
        Me.Pertemuan5ToolStripMenuItem.Name = "Pertemuan5ToolStripMenuItem"
        Me.Pertemuan5ToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.Pertemuan5ToolStripMenuItem.Text = "Pertemuan 5"
        '
        'Pertemuan6ToolStripMenuItem
        '
        Me.Pertemuan6ToolStripMenuItem.Name = "Pertemuan6ToolStripMenuItem"
        Me.Pertemuan6ToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.Pertemuan6ToolStripMenuItem.Text = "Pertemuan 6"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Pertemuan1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HellowordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pertemuan2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pertemuan3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pertemuan4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pertemuan5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pertemuan6ToolStripMenuItem As ToolStripMenuItem
End Class
