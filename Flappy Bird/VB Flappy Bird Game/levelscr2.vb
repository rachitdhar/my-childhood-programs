﻿Public Class levelscr2

    Dim time As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time += 1
        If time > 2 Then
            Level2.Show()
            Me.Close()
        End If
    End Sub

    Private Sub levelscr2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True
        Label4.Text = My.Settings.lives
    End Sub
End Class