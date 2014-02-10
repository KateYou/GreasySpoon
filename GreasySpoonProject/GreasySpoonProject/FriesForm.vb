Public Class FriesForm
    Public SidePrice As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stringVar As String = "    "
        Dim SidePriceFries As Double

        If CheckBox1.Checked = True Then
            stringVar &= CheckBox1.Text
            stringVar &= "  "
            SidePriceFries = SidePriceFries + 0.5
        End If
        If CheckBox2.Checked = True Then
            stringVar &= CheckBox2.Text
            stringVar &= "  "
            SidePriceFries = SidePriceFries + 0.5
        End If
        If stringVar <> Nothing Then
            SidePrice = SidePriceFries
            Main.ListBox1.Items.Add(stringVar)
            CheckBox1.Checked = False
            CheckBox2.Checked = False
        End If
    End Sub

End Class