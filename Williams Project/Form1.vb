Public Class frmMain
    'Constants
    Const BASIC_CHARGE As Double = 24.99
    Const SILVER_CHARGE As Double = 42.99
    Const GOLD_CHARGE As Double = 84.99
    Const DIAMOND_CHARGE As Double = 99.99

    Const CINEMA_CHARGE As Double = 9.5
    Const HBI_CHARGE As Double = 9.5
    Const SHOW_CHARGE As Double = 10.5
    Const LOCAL_CHARGE As Double = 6.0

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'This is where all the code goes for onClick
        Dim dblTotal As Double = 0

        If radBasic.Checked = True Then
            dblTotal += BASIC_CHARGE
        ElseIf radSilver.Checked = True Then
            dblTotal += SILVER_CHARGE
        ElseIf radGold.Checked = True Then
            dblTotal += GOLD_CHARGE
        ElseIf radDiamond.Checked = True Then
            dblTotal += DIAMOND_CHARGE
        End If

        txtTotal.Text = dblTotal.ToString("C2")
    End Sub

End Class
