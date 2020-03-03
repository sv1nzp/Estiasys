<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.mnu_Main = New System.Windows.Forms.MenuStrip()
        Me.ΕπιλογέςToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ΈξοδοςToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.mnu_Main.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnu_Main
        '
        Me.mnu_Main.BackColor = System.Drawing.SystemColors.GrayText
        Me.mnu_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ΕπιλογέςToolStripMenuItem})
        Me.mnu_Main.Location = New System.Drawing.Point(0, 0)
        Me.mnu_Main.Name = "mnu_Main"
        Me.mnu_Main.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnu_Main.Size = New System.Drawing.Size(800, 24)
        Me.mnu_Main.TabIndex = 0
        Me.mnu_Main.Text = "Main"
        '
        'ΕπιλογέςToolStripMenuItem
        '
        Me.ΕπιλογέςToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ΈξοδοςToolStripMenuItem})
        Me.ΕπιλογέςToolStripMenuItem.Name = "ΕπιλογέςToolStripMenuItem"
        Me.ΕπιλογέςToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ΕπιλογέςToolStripMenuItem.Text = "Επιλογές"
        '
        'ΈξοδοςToolStripMenuItem
        '
        Me.ΈξοδοςToolStripMenuItem.Name = "ΈξοδοςToolStripMenuItem"
        Me.ΈξοδοςToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ΈξοδοςToolStripMenuItem.Text = "Έξοδος"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(713, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.mnu_Main)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnu_Main
        Me.Name = "Main"
        Me.Text = "Main"
        Me.mnu_Main.ResumeLayout(False)
        Me.mnu_Main.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnu_Main As Windows.Forms.MenuStrip
    Friend WithEvents ΕπιλογέςToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ΈξοδοςToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As Windows.Forms.Button
End Class
