Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declaration of variables'
        Dim FirstName As String
        Dim SecondName As String
        Dim ThirdName As String
        Dim FirstRunnerTime As Double
        Dim SecondRunnerTime As Double
        Dim ThirdRunnerTime As Double
        'tranfer of textboxex inputs to RunnerTimes'
        Try
            FirstRunnerTime = CDbl(TextBox4.Text)
            SecondRunnerTime = CDbl(TextBox5.Text)
            ThirdRunnerTime = CDbl(TextBox6.Text)
        Catch
            MessageBox.Show("Enter a double number!")

        End Try
        'if statement to detemine diferent conditions. use of AND to mean addition. both condition should br true for the answer to be true.'
        If (FirstRunnerTime < SecondRunnerTime) And (SecondRunnerTime < ThirdRunnerTime) Then
            Lblfirst.Text = TextBox1.Text
            Lblsecond.Text = TextBox2.Text
            Lblthird.Text = TextBox3.Text
        ElseIf (FirstRunnerTime < ThirdRunnerTime) And (ThirdRunnerTime < SecondRunnerTime) Then
            Lblfirst.Text = TextBox1.Text
            Lblsecond.Text = TextBox3.Text
            Lblthird.Text = TextBox2.Text
        ElseIf (SecondRunnerTime < FirstRunnerTime) And (FirstRunnerTime < ThirdRunnerTime) Then
            Lblfirst.Text = TextBox2.Text
            Lblsecond.Text = TextBox1.Text
            Lblthird.Text = TextBox3.Text
        ElseIf (SecondRunnerTime < ThirdRunnerTime) And (ThirdRunnerTime < FirstRunnerTime) Then
            Lblfirst.Text = TextBox2.Text
            Lblsecond.Text = TextBox3.Text
            Lblthird.Text = TextBox1.Text
        ElseIf (ThirdRunnerTime < FirstRunnerTime) And (FirstRunnerTime < SecondRunnerTime) Then
            Lblfirst.Text = TextBox3.Text
            Lblsecond.Text = TextBox1.Text
            Lblthird.Text = TextBox2.Text
        ElseIf (ThirdRunnerTime < SecondRunnerTime) And (SecondRunnerTime < FirstRunnerTime) Then
            Lblfirst.Text = TextBox3.Text
            Lblsecond.Text = TextBox2.Text
            Lblthird.Text = TextBox1.Text
        Else
            Lblfirst.Text = ("invalid")
            Lblsecond.Text = ("invalid")
            Lblthird.Text = ("invalid")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' clearance of the textboxes and display labels for new calculation'
        TextBox1.ResetText()
        TextBox2.ResetText()
        TextBox3.ResetText()
        TextBox4.ResetText()
        TextBox5.ResetText()
        TextBox6.ResetText()
        Lblfirst.ResetText()
        Lblsecond.ResetText()
        Lblthird.ResetText()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'exit the application'
        Me.Close()

    End Sub
End Class
