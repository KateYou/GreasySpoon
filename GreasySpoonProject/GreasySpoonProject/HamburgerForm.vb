Public Class HamburgerForm
    Public SidePrice As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stringVar As String = "    "
        Dim SidePriceHam As Double

        If CheckBox1.Checked = True Then
            stringVar &= CheckBox1.Text
            stringVar &= "  "
        End If
        If CheckBox2.Checked = True Then
            stringVar &= CheckBox2.Text
            stringVar &= "  "
        End If
        If CheckBox3.Checked = True Then
            stringVar &= CheckBox3.Text
            stringVar &= "  "
        End If
        If CheckBox4.Checked = True Then
            stringVar &= CheckBox4.Text
            stringVar &= "  "
        End If
        If CheckBox5.Checked = True Then
            stringVar &= CheckBox5.Text
            stringVar &= "  "
            SidePriceHam = 0.25
        End If
        If CheckBox6.Checked = True Then
            stringVar &= CheckBox6.Text
            stringVar &= "  "
        End If
        If stringVar <> Nothing Then
            SidePrice = SidePriceHam
            Main.ListBox1.Items.Add(stringVar)
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is CheckBox Then
                    DirectCast(ctrl, CheckBox).CheckState = CheckState.Unchecked
                End If
            Next
        End If

    End Sub
End Class