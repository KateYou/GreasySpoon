Public Class CustomerInfo

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CustomerName As String
        Dim TableNumber As Integer
        Dim s As String = ""

        CustomerName = TextBox1.Text
        TableNumber = CInt(TextBox2.Text)------------------
        'End Sub

        If String.IsNullOrEmpty(s) Then
            MessageBox.Show("You must enter a customer name or table number")
        Else

            'If CustomerName = Nothing Then

            'Main.ListBox1.Items.Add("Customer Name: " + CustomerName + "   " + "Table Number: " + CStr(TableNumber))
            'End If

            'If CustomerName <> Nothing Then
            Main.ListBox1.Items.Add("Customer Name: " + CustomerName + "   " + "Table Number: " + CStr(TableNumber))
            TextBox1.Text = ""
            TextBox2.Text = CStr("")
        End If

    End Sub
End Class