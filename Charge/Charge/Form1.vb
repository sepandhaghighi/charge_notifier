Public Class Form1
    Dim power As SystemInformation

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label8.Text = Str((SystemInformation.PowerStatus.BatteryLifePercent * 100))
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
                NotifyIcon1.BalloonTipText = Label6.Text + "Days " + Label5.Text + Label1.Text + "Hour" + vbCr + "System Is Up" + vbCr + Label24.Text + "Days " + Label12.Text + Label16.Text + "Hour" + vbCr + "Network Is On"
                NotifyIcon1.ShowBalloonTip(40)
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
            Timer4.Enabled = True
            Button1.Text = "Stop"
        Else
            Timer3.Enabled = False
            Timer4.Enabled = False
            Button1.Text = "Start"
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContextMenuStrip1.Enabled = False
        Timer3.Enabled = True
        Label8.Text = SystemInformation.PowerStatus.BatteryLifePercent * 100
        If My.Computer.Network.IsAvailable Then
            Timer4.Enabled = True
        End If
        If SystemInformation.PowerStatus.BatteryChargeStatus = 9 Or SystemInformation.PowerStatus.BatteryChargeStatus = 10 Or SystemInformation.PowerStatus.BatteryChargeStatus = 8 Then
            NotifyIcon1.BalloonTipText = "Battery Is Charging" + vbCr + "Percentage :" + Str(SystemInformation.PowerStatus.BatteryLifePercent * 100)
            NotifyIcon1.ShowBalloonTip(30)
        Else
            NotifyIcon1.BalloonTipText = "Battery Is Ready"
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
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
        ContextMenuStrip1.Enabled = True
        NotifyIcon1.BalloonTipText = "Charge_Notifier Still Running"
        NotifyIcon1.ShowBalloonTip(50)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'If SystemInformation.PowerStatus.BatteryChargeStatus = 10 Or SystemInformation.PowerStatus.BatteryChargeStatus = 9 Or SystemInformation.PowerStatus.BatteryChargeStatus = 8 Then
        'Timer3.Enabled = True
        'Timer1.Enabled = False
        'Timer2.Enabled = True
        ' End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        '  If SystemInformation.PowerStatus.BatteryChargeStatus = BatteryChargeStatus.High Then
        'Timer3.Enabled = False
        ' NotifyIcon1.BalloonTipText = "Battery Is Fully Charged"
        ' NotifyIcon1.ShowBalloonTip(30)
        ' Timer2.Enabled = False
        'Timer1.Enabled = True


        'End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.DoubleClick
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
        ContextMenuStrip1.Enabled = False

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Label8.Text = Str((SystemInformation.PowerStatus.BatteryLifePercent * 100))
        If Label14.Text = "5" And Label17.Text = "9" Then
            Label14.Text = "0"
            Label17.Text = "0"
            If Label15.Text = "9" And Label13.Text = "5" Then
                Label15.Text = "0"
                Label13.Text = "0"
                If Label16.Text = "3" And Label12.Text = "2" Then
                    Label16.Text = "0"
                    Label12.Text = "0"
                    Label24.Text = Val(Label24.Text) + 1
                ElseIf Label16.Text = "9" Then
                    Label16.Text = "0"
                    Label12.Text = Val(Label12.Text) + 1
                Else
                    Label16.Text = Val(Label16.Text) + 1

                End If
            ElseIf Label15.Text = "9" Then
                Label15.Text = "0"
                Label13.Text = Val(Label13.Text) + 1
            Else
                Label15.Text = Val(Label15.Text) + 1

            End If
        ElseIf Label17.Text = "9" Then
            Label17.Text = "0"
            Label14.Text = Val(Label14.Text) + 1
        Else
            Label17.Text = Val(Label17.Text) + 1
        End If
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub


End Class
