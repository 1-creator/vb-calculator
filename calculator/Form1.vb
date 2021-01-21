Public Class Form1
    Dim Num1 As Single
    Dim Num2 As Single
    Dim Answer As Single
   

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Num1 = Val(TextBoxnum1.Text)
        Num2 = Val(TextBoxnum2.Text)
        Answer = Num1 - Num2
        Labelanswer.Text = Str(Answer)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Num1 = Val(TextBoxnum1.Text)
        Num2 = Val(TextBoxnum2.Text)
        Answer = Num1 / Num2
        Labelanswer.Text = Str(Answer)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Num1 = Val(TextBoxnum1.Text)
        Num2 = Val(TextBoxnum2.Text)
        Answer = Num1 + Num2
        Labelanswer.Text = Str(Answer)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Num1 = Val(TextBoxnum1.Text)
        Num2 = Val(TextBoxnum2.Text)
        Answer = Num1 * Num2
        Labelanswer.Text = Str(Answer)
    End Sub
End Class
