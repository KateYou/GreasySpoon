﻿Public Class DrinksForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stringVar As String = "    "

        If RadioButton1.Checked = True Then
            stringVar &= RadioButton1.Text
            stringVar &= " "
        End If
        If RadioButton2.Checked = True Then
            stringVar &= RadioButton2.Text
            stringVar &= " "
        End If
        If RadioButton3.Checked = True Then
            stringVar &= RadioButton3.Text
            stringVar &= " "
        End If
        If CheckBox4.Checked = True Then
            stringVar &= CheckBox4.Text
            stringVar &= " "
        End If
        If CheckBox5.Checked = True Then
            stringVar &= CheckBox5.Text
            stringVar &= " "
        End If
        If stringVar <> Nothing Then
            Main.ListBox1.Items.Add(stringVar)
        End If
    End Sub

End Class