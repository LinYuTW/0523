Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim A(1, 2) As Integer
        Dim B(1, 2) As Integer
        Dim C(1, 2) As Integer
        For i As Integer = 0 To 1
            For j As Integer = 0 To 2
                A(i, j) = 2
                B(i, j) = 3
            Next
        Next
        For i As Integer = 0 To 1
            For j As Integer = 0 To 2
                C(i, j) = A(i, j) + B(i, j)
                TextBox1.Text = TextBox1.Text & C(i, j) & ","
            Next
            TextBox1.Text = TextBox1.Text & vbNewLine
        Next
    End Sub
End Class
