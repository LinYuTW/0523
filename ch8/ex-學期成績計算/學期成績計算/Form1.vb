Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim score(9, 2) As Integer
        Dim final(9) As Double
        Randomize()
        For i As Integer = 0 To 9
            TextBox1.Text = TextBox1.Text & "第" & (i + 1) & "位同學的成績為"
            For j As Integer = 0 To 2
                score(i, j) = CInt(Int(101 * Rnd()))
                TextBox1.Text = TextBox1.Text & score(i, j) & ","
            Next
            TextBox1.Text = TextBox1.Text & vbNewLine
        Next
        For i As Integer = 0 To 9
            final(i) = score(i, 0) * 0.3 + score(i, 1) * 0.3 + score(i, 2) * 0.4
            TextBox1.Text = TextBox1.Text & "第" & (i + 1) & "位同學的學期總成績為" & final(i) & vbNewLine
        Next
    End Sub
End Class
