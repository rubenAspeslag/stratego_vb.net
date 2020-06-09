Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim A As Integer = InputBox("getal 1")
        Dim B As Integer = InputBox("getal 2")

        MsgBox(ggd(A, B))
    End Sub
    Function ggd(a, b)
        If a = b Then
            Return a
        ElseIf a < b Then
            Return ggd(a, b - a)
        Else
            Return ggd(a - b, b)
        End If
    End Function
End Class
