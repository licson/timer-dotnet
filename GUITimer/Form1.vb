Public Class TimerApp
    Private timeInSecs = 0
    Private timerStarted = False
    Private stopwatch = False
    Private stopwatchTime As TimeSpan

    Private Sub onBlur(sender As Object, e As EventArgs) Handles MyBase.LostFocus
        Try
            Me.Opacity = 0.5
        Catch ex As Exception
        End Try
    End Sub

    Private Sub onFocus(sender As Object, e As EventArgs) Handles MyBase.GotFocus
        Me.Opacity = 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If stopwatch Then
            stopwatchTime = stopwatchTime.Subtract(TimeSpan.FromSeconds(1))
            TimeDisplay.Text = stopwatchTime.ToString()

            If stopwatchTime.TotalSeconds = 0 Then
                Timer1.Stop()
                timerStarted = False

                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                Me.Focus()
            End If
        Else
            timeInSecs += 1
            TimeDisplay.Text = TimeSpan.FromSeconds(timeInSecs).ToString()
        End If
    End Sub

    Private Sub TimeDisplay_Click(sender As Object, e As MouseEventArgs) Handles TimeDisplay.MouseDown
        If Not e.Button = MouseButtons.Left Then
            Return
        End If

        If timerStarted Then
            Timer1.Stop()
            timerStarted = False
            timeInSecs = 0
        Else
            If stopwatch And stopwatchTime.TotalSeconds = 0 Then
                Return
            End If

            Timer1.Start()
            timerStarted = True
        End If
    End Sub

    Private Sub StartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartToolStripMenuItem.Click
        If Not timerStarted Then
            If stopwatch And stopwatchTime.TotalSeconds = 0 Then
                Return
            End If

            Timer1.Start()
            timerStarted = True
        End If
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        If timerStarted Then
            Timer1.Stop()
            timeInSecs = 0
            timerStarted = False
        End If
    End Sub

    Private Sub BackgroundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundToolStripMenuItem.Click
        Dim colour As DialogResult = BackgroundColourDialog.ShowDialog()

        If colour = DialogResult.OK Then
            Me.BackColor = BackgroundColourDialog.Color
            TimeDisplay.ForeColor = SelectColor(BackgroundColourDialog.Color)
        End If
    End Sub

    Private Function SelectColor(colour As Color) As Color
        Dim brightness As Integer = (CInt(colour.R) + CInt(colour.G) + CInt(colour.B)) / 3

        If brightness > 127 Then
            Return Color.Black
        Else
            Return Color.White
        End If
    End Function

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub StopwatchMode_Click(sender As Object, e As EventArgs) Handles StopwatchToolStripMenuItem.Click
        Dim countdown As String = InputBox("Countdown time")

        If countdown = "" Then
            Return
        End If

        Try
            stopwatchTime = TimeSpan.Parse(countdown)
            stopwatch = True
            TimeDisplay.Text = stopwatchTime.ToString()

            StopwatchToolStripMenuItem.Checked = True
            TimerToolStripMenuItem.Checked = False
        Catch ex As Exception
            MsgBox("I can't understand this.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub TimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimerToolStripMenuItem.Click
        stopwatch = False

        StopwatchToolStripMenuItem.Checked = False
        TimerToolStripMenuItem.Checked = True
    End Sub

    Private Sub ResetMenuItem_Click(sender As Object, e As EventArgs) Handles ResetMenuItem.Click
        Timer1.Stop()
        TimeDisplay.Text = "00:00:00"
        TimeDisplay.ForeColor = Color.Black
        stopwatch = False
        stopwatchTime = Nothing
        timeInSecs = 0
        timerStarted = False
        Me.BackColor = Color.White
    End Sub

    Private Sub AlwaysOnTopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlwaysOnTopToolStripMenuItem.Click
        Me.TopMost = Not AlwaysOnTopToolStripMenuItem.Checked
        AlwaysOnTopToolStripMenuItem.Checked = Not AlwaysOnTopToolStripMenuItem.Checked
    End Sub
End Class
