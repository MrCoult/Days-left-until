Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case ComboBox1.Text
            Case "Zile"
                TextBox1.Text = "Intre cele doua dati sunt " & Math.Abs(DateDiff(DateInterval.Day, DateTimePicker1.Value, DateTimePicker2.Value)) & " " & ComboBox1.Text
            Case "Saptamani"
                TextBox1.Text = "Intre cele doua dati sunt " & Math.Abs(Math.Floor(DateDiff(DateInterval.Day, DateTimePicker1.Value, DateTimePicker2.Value) / 7)) & " " & ComboBox1.Text
            Case Else
                MsgBox("Nu ati ales ""zile"" sau ""saptamani""", vbCritical)
        End Select
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub
End Class
