Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim A(2, 3) As Integer
        Dim B(3, 2) As Integer
        Dim C(2, 2) As Integer
        A(0, 0) = 1
        A(0, 1) = 2
        A(0, 2) = 3
        A(1, 0) = 2
        A(1, 1) = 2
        A(1, 2) = 2
        B(0, 0) = 1
        B(0, 1) = 2
        B(1, 0) = 2
        B(1, 1) = 2
        B(2, 0) = 3
        B(2, 1) = 2
        For i As Integer = 0 To 1
            For j As Integer = 0 To 1
                C(i, j) = 0
                For k As Integer = 0 To 2
                    C(i, j) = C(i, j) + A(i, k) * B(k, j)
                Next
                TextBox1.Text = TextBox1.Text & C(i, j) & ","
            Next
            TextBox1.Text = TextBox1.Text & vbNewLine
        Next
    End Sub
End Class
