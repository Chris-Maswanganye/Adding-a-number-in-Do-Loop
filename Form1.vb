Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum
        Dim n As Integer
        ListBox.Items.Add("n" & vbTab & "Sum")
        ListBox.Items.Add("---------------")
        Do
            n += 1
            sum += n
            ListBox1.Items.Add(n & vbTab & sum)
            If n = 10 Then
                Exit Do
            End If
        Loop

    End Sub
End Class
