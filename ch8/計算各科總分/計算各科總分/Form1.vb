Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim score(4, 39) As Integer
        Dim total As Integer
        For i As Integer = 0 To 4
            For j As Integer = 0 To 39
                score(i, j) = CInt(Int(101 * Rnd()))
            Next
        Next
        For i As Integer = 0 To 4
            total = 0
            For j As Integer = 0 To 39
                total = total + score(i, j)
                TextBox1.Text = TextBox1.Text & score(i, j) & ","
            Next
            TextBox1.Text = TextBox1.Text & "總分為" & total & vbNewLine
        Next
    End Sub
End Class
