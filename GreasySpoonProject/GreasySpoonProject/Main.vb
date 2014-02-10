Public Class Main
    Public SidePrice As Double
    Dim Total As Double
    Dim Qty As Double = 0
    Dim Discount As Double

    Private Sub Hamburger(sender As Object, e As EventArgs) Handles Button1.Click, Button10.Click

        Dim stringVar As String
        Dim ItemTotal As String = CStr("$4.99")
        Total = Total + 4.99
        Qty = Qty + 1
        ListBox1.Items.Add("1 Hamburger" + "   " + CStr(ItemTotal) + Space(55) + Total.ToString("C2"))
        stringVar = CStr(HamburgerForm.ShowDialog())
        Total = Total + CDbl(HamburgerForm.SidePrice)
        ListBox1.Items.Add("    Toppings charge: " + CStr(HamburgerForm.SidePrice.ToString("c2") + Space(46) + Total.ToString("C2")))
    End Sub

    Private Sub HotDog(sender As Object, e As EventArgs) Handles Button2.Click, Button11.Click
        Dim stringVar As String
        Dim ItemTotal As String = CStr("$1.75")
        Total = Total + 1.75
        Qty = Qty + 1
        ListBox1.Items.Add("1 Hot Dog " + "   " + CStr(ItemTotal) + Space(59) + Total.ToString("C2"))
        stringVar = CStr(HotDogForm.ShowDialog())
        Total = Total + CDbl(HotDogForm.SidePrice)
        ListBox1.Items.Add("    Toppings charge: " + CStr(HotDogForm.SidePrice.ToString("c2") + Space(46) + Total.ToString("C2")))
    End Sub

    Private Sub Fries(sender As Object, e As EventArgs) Handles Button3.Click, Button12.Click
        Dim stringVar As String
        Dim ItemTotal As String = CStr("$1.50")
        Total = Total + 1.5
        Qty = Qty + 1
        ListBox1.Items.Add("1 Fries " + "   " + CStr(ItemTotal) + Space(65) + Total.ToString("C2"))
        stringVar = CStr(FriesForm.ShowDialog())
        Total = Total + CDbl(FriesForm.SidePrice)
        ListBox1.Items.Add("    Toppings charge: " + CStr(FriesForm.SidePrice.ToString("c2") + Space(46) + Total.ToString("C2")))
    End Sub

    Private Sub Pie(sender As Object, e As EventArgs) Handles Button4.Click, Button13.Click
        Dim stringVar As String
        Dim ItemTotal As String = CStr("$2.00")
        Total = Total + 2.0
        Qty = Qty + 1
        ListBox1.Items.Add("1 Slice of Pie " + "   " + CStr(ItemTotal) + Space(55) + Total.ToString("C2"))
        stringVar = CStr(PieForm.ShowDialog())
    End Sub

    Private Sub Drink(sender As Object, e As EventArgs) Handles Button5.Click
        Dim stringVar As String
        Dim ItemTotal As String = CStr("$1.00")
        Total = Total + 1.0
        Qty = Qty + 1
        ListBox1.Items.Add("1 Drink " + "   " + CStr(ItemTotal) + Space(65) + Total.ToString("C2"))
        stringVar = CStr(DrinksForm.ShowDialog())
    End Sub

    Private Sub DiscountButton(sender As Object, e As EventArgs) Handles Button9.Click
        Discount = CDbl(InputBox("Enter customer discount as a percent:", "Discount"))
        Discount = Discount * 0.01
    End Sub

    Private Sub Mustard(sender As Object, e As EventArgs) Handles Button15.Click
        'Adds mustard to Listbox1
        ListBox1.Items.Add("Extra Mustard")
    End Sub

    Private Sub Ketchup(sender As Object, e As EventArgs) Handles Button14.Click
        'Adds ketchup to Listbox1
        ListBox1.Items.Add("Extra Ketchup")
    End Sub

    Private Sub Water(sender As Object, e As EventArgs) Handles Button16.Click
        'Adds glass of water to Listbox1
        ListBox1.Items.Add("Glass of water")
    End Sub

    Private Sub CalculateTax(sender As Object, e As EventArgs) Handles Button7.Click
        'Declare internal variables for holding taxed value, holding customer name and table number, and holding discount
        Dim Tax As Double = 0.115
        Dim Customer As String
        Dim DiscountTotal As Double

        'Display Subtotal, calculate Total and Tax
        ListBox1.Items.Add("-----------------------------------------------------------")
        ListBox1.Items.Add("Subtotal: " + CStr(Total.ToString("C2")))
        ListBox1.Items.Add("Total items ordered: " + CStr(Qty))
        DiscountTotal = Total * Discount
        Total = Total - DiscountTotal
        Tax = Total * Tax
        Total += Tax

        'Display quantity of dishes ordered, discount, tax and total
        ListBox1.Items.Add("")
        ListBox1.Items.Add("Discount: " + CStr(Discount * 100) + "%")
        ListBox1.Items.Add("Tax: " + CStr(Tax.ToString("C2")))
        ListBox1.Items.Add("Total Due: " + CStr(Total.ToString("C2")))

        'Calls custom dialog box, "CustomerInfo", for inputting customer name and table number, then displays that info and also current date and time
        ListBox1.Items.Add("-----------------------------------------------------------")
        Customer = CStr(CustomerInfo.ShowDialog())
        ListBox1.Items.Add("Today's Date: " + CStr(Today) + "   " + CStr(TimeOfDay))

        'Displays message
        ListBox1.Items.Add("")
        ListBox1.Items.Add("Thanks for stopping by The Greasy Spoon!")
        ListBox1.Items.Add("")
    End Sub

    Private Sub PrintReceipt(sender As Object, e As EventArgs) Handles Button6.Click
        'button calls "Private Sub PrintDocument1_PrintPage" and prints the receipt on default printer
        PrintDocument1.PrinterSettings.Copies = 1
        PrintDocument1.Print()
    End Sub

    Private Sub CancelOrder(sender As Object, e As EventArgs) Handles Button8.Click
        'Clears ListBox1, empties all global/public variables
        ListBox1.Items.Clear()
        Total = 0
        Qty = 0
        Discount = 0
        SidePrice = 0
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Print method (currently prints blank pages)
        e.Graphics.DrawString(ListBox1.Text, ListBox1.Font, Brushes.Blue, 100, 100)
    End Sub
End Class
