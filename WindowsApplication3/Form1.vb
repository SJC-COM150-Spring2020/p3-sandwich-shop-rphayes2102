Public Class Form1
    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GrpBoxEggs.Enter


    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBoxHam.CheckedChanged

    End Sub

    Private Sub GrpBoxDrink_Enter(sender As Object, e As EventArgs) Handles GrpBoxDrink.Enter
        'declare variables 
        Dim drink As String
        Dim Total As Double
        Total = 0

        drink = "Your beverage is "
        If (ChkBoxCoffee.Checked = True) Then
            lstBoxOrder.Items.Add("Coffee - $2.25")
            Total = Total + 2.25
        End If
        If (ChkBoxJuice.Checked = True) Then
            lstBoxOrder.Items.Add("Juice - $2.25")
            Total = Total + 2.25
        End If
        If (ChkBoxHot.Checked = True) Then
            lstBoxOrder.Items.Add("Hot Chocolate - $2.25")
            Total = Total + 2.25
        End If
        If (ChkBoxMilk.Checked = True) Then
            lstBoxOrder.Items.Add("Milk - $2.25")
            Total = Total + 2.25
        End If
        If (ChkBoxTea.Checked = True) Then
            lstBoxOrder.Items.Add("Tea - $2.25")
            Total = Total + 2.25
        End If

    End Sub

    Private Sub Extras_Enter(sender As Object, e As EventArgs) Handles GrpBoxExtra.Enter
        'declare variables 
        Dim Extras As String
        Dim total As Double
        total = 0

        Extras = "Your extras are "
        If (ChkBoxHam.Checked = True) Then
            lstBoxOrder.Items.Add("Ham - $1.50")
            total = total + 1.5
        End If
        If (ChkBoxBacon.Checked = True) Then
            lstBoxOrder.Items.Add("Bacon - $1.50")
            total = total + 1.5
        End If
        If (ChkBoxSausage.Checked = True) Then
            lstBoxOrder.Items.Add("Sausage - $1.50")
            total = total + 1.5
        End If
        If (ChkBoxCheese.Checked = True) Then
            lstBoxOrder.Items.Add("Cheese - $1.50")
            total = total + 1.5
        End If
        If (ChkBoxVeggie.Checked = True) Then
            lstBoxOrder.Items.Add("Veggies - $1.50")
            total = total + 1.5
        End If
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click

    End Sub
End Class
