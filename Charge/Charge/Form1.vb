Public Class Form1
    Dim power As SystemInformation

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Label3.Text = "5" And Label21.Text = "9" Then
            Label3.Text = "0"
            Label21.Text = "0"
            If Label2.Text = "9" And Label4.Text = "5" Then
                Label2.Text = "0"
                Label4.Text = "0"
                If Label1.Text = "3" And Label5.Text = "2" Then
                    Label1.Text = "0"
                    Label5.Text = "0"
                    Label6.Text = Val(Label6.Text) + 1
                ElseIf Label1.Text = "9" Then
                    Label1.Text = "0"
                    Label5.Text = Val(Label5.Text) + 1
                Else
                    Label1.Text = Val(Label1.Text) + 1

                End If
            ElseIf Label2.Text = "9" Then
                Label2.Text = "0"
                Label4.Text = Val(Label4.Text) + 1
            Else
                Label2.Text = Val(Label2.Text) + 1

            End If
        ElseIf Label21.Text = "9" Then
            Label21.Text = "0"
            Label3.Text = Val(Label3.Text) + 1
        Else
            Label21.Text = Val(Label21.Text) + 1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Start" Then
            Timer3.Enabled = True
            Button1.Text = "Stop"
        Else
            Timer3.Enabled = False
            Button1.Text = "Start"
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NotifyIcon1.BalloonTipText = "Charge Notifier Started"
        NotifyIcon1.ShowBalloonTip(70)
        ContextMenuStrip1.Enabled = False
        If SystemInformation.PowerStatus.BatteryChargeStatus = BatteryChargeStatus.Charging Then
            NotifyIcon1.BalloonTipText = "Battery Is Charging"
            NotifyIcon1.ShowBalloonTip(30)
        End If
    End Sub
    Private Sub Form1_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        e.Cancel = True
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
        ContextMenuStrip1.Enabled = True
        NotifyIcon1.BalloonTipText = "Charge_Notifier Still Running"
        NotifyIcon1.ShowBalloonTip(50)
    End Sub
    Private Sub menusteip_show(sender As Object, e As EventArgs) Handles Show.Click
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
        ContextMenuStrip1.Enabled = False

    End Sub
    Private Sub menustrup_exit(sender As Object, e As EventArgs) Handles Exit_1.Click
        End
    End Sub





    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If SystemInformation.PowerStatus.BatteryChargeStatus = 0 Then
            Timer3.Enabled = True
            Timer1.Enabled = False
            Timer2.Enabled = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If SystemInformation.PowerStatus.BatteryChargeStatus = 1 Then
            Timer3.Enabled = False
            Timer2.Enabled = False
            Timer1.Enabled = True

        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        If Timer3.Enabled = True Then
            NotifyIcon1.BalloonTipText = Label5.Text + Label1.Text + ":" + Label4.Text + Label2.Text + ":" + Label3.Text + Label21.Text

        Else
            NotifyIcon1.BalloonTipText = "Timer Stopped"
        End If
        NotifyIcon1.ShowBalloonTip(10)

    End Sub
End Class
