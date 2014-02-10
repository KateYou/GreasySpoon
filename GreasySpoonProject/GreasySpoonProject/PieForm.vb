Public Class PieForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stringVar As String = "    "

        If RadioButton1.Checked = True Then
            stringVar &= RadioButton1.Text
        End If
        If RadioButton2.Checked = True Then
            stringVar &= RadioButton2.Text
        End If
        If RadioButton3.Checked = True Then
            stringVar &= RadioButton3.Text
        End If
        If stringVar <> Nothing Then
            Main.ListBox1.Items.Add(stringVar)
        End If
    End Sub
End Class