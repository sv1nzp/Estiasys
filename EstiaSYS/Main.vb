Imports System.Drawing
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Windows.Forms

Public Class Main
    'The color and the width of the border.
    Private borderColor As Color = Color.Gray 'Border Color
    Private borderWidth As Integer = 10
    Private formRegion As Rectangle
    Private Sub Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Sets the location of the form w.r.t the position
        Me.CenterToScreen()
        formRegion = New Rectangle(0, 0, 800, 450) 'Here 800 and 450 is form's Size
    End Sub
    Private Sub Form1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        'Draws the border.
        ControlPaint.DrawBorder(e.Graphics, formRegion, borderColor,
        borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth,
        ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid,
        borderColor, borderWidth, ButtonBorderStyle.Solid)
    End Sub

    Private Sub ΈξοδοςToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΈξοδοςToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    End Sub

End Class