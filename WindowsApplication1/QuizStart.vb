Public Class QuizStart
    Public Property QuesCor As Integer
    Public Property QuesAns As Integer

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        QuesAns = 0
        QuesCor = 0
        RestartQuiz()
        My.Forms.Quiz1.Show()
        Button1.Text = "Progress: " & QuesAns & " out of 10 Completed"
        ProgressBar1.Value = 0
    End Sub
    Public Sub RestartQuiz()
        My.Forms.Quiz1.Close()
        My.Forms.Quiz2.Close()
        My.Forms.Quiz3.Close()
        My.Forms.Quiz4.Close()
        My.Forms.Quiz5.Close()
        My.Forms.Quiz6.Close()
        My.Forms.Quiz7.Close()
        My.Forms.Quiz8.Close()
        My.Forms.Quiz9.Close()
        My.Forms.Quiz10.Close()
    End Sub
End Class
