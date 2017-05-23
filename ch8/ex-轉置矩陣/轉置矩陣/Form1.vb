Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim A(2, 2) As Integer
        Dim B(2, 2) As Integer
        Randomize()
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                A(i, j) = CInt(Int(9 * Rnd() + 1))
                TextBox1.Text = TextBox1.Text & A(i, j) & ","
            Next
            TextBox1.Text = TextBox1.Text & vbNewLine
        Next
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                B(i, j) = A(j, i)
                TextBox1.Text = TextBox1.Text & B(i, j) & ","
            Next
            TextBox1.Text = TextBox1.Text & vbNewLine
        Next
    End Sub
End Class
