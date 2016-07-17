Public Class Form1

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
        NotifyIcon1.ShowBalloonTip(400)

    End Sub


 
End Class
