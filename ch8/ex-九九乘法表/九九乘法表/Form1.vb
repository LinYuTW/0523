Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim A(9, 9) As Integer
        For i As Integer = 1 To 9
            For j As Integer = 1 To 9
                A(i, j) = i * j
            Next
        Next
        For i As Integer = 1 To 9
            For j As Integer = 1 To 9
                TextBox1.Text = TextBox1.Text & A(i, j) & ","
            Next
            TextBox1.Text = TextBox1.Text & vbNewLine
        Next
    End Sub
End Class
