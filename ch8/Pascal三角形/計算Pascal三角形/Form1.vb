Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim A(7, 7) As Integer
        For i As Integer = 0 To 7
            A(i, 0) = 1
            A(i, i) = 1
        Next
        For i As Integer = 2 To 7
            For j As Integer = 1 To (i - 1)
                A(i, j) = A(i - 1, j - 1) + A(i - 1, j)
            Next
        Next
        For i As Integer = 0 To 7
            For j As Integer = 0 To i
                TextBox1.Text = TextBox1.Text & A(i, j) & ","
            Next
            TextBox1.Text = TextBox1.Text & vbNewLine
        Next
    End Sub
End Class
