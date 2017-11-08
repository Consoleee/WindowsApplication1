Public Class Quiz4

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            QuizStart.QuesCor = QuizStart.QuesCor + 1
        End If
        QuizStart.QuesAns = QuizStart.QuesAns + 1
        My.Forms.QuizStart.Button1.Text = "Progress: " & QuizStart.QuesAns & " out of 10 Completed"
        My.Forms.QuizStart.ProgressBar1.PerformStep()
        Me.Close()
        My.Forms.Quiz5.Show()
    End Sub
End Class