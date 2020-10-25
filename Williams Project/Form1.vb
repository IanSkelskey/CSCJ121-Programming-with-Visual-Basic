Public Class frmMain
    'Defined constants to store the cost of each cable package and additional feature.
    'Constants are helpful when a value could change. 
    Const BASIC_CHARGE As Double = 24.99
    Const SILVER_CHARGE As Double = 42.99
    Const GOLD_CHARGE As Double = 84.99
    Const DIAMOND_CHARGE As Double = 99.99
    'If the cost of any package or feature is changed you only need to change 
    'it here instead of everywhere in your code.
    Const CINEMA_CHARGE As Double = 9.5
    Const HBI_CHARGE As Double = 9.5
    Const SHOW_CHARGE As Double = 10.5
    Const LOCAL_CHARGE As Double = 6.0

    'Variable to store the total.
    Dim dblTotal As Double = 0

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Stuff to do when the form loads. Perhaps a welcome message?
    End Sub

    'The code below determines what happens when you click calculate.
    'Most of this program will be written here.
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        dblTotal = 0 'reset the total to zero for new calculations

        'Check radio buttons using If and ElseIf for cable package
        If radBasic.Checked = True Then
            dblTotal += BASIC_CHARGE
        ElseIf radSilver.Checked = True Then
            dblTotal += SILVER_CHARGE
        ElseIf radGold.Checked = True Then
            dblTotal += GOLD_CHARGE
        ElseIf radDiamond.Checked = True Then
            dblTotal += DIAMOND_CHARGE
        End If

        'Check checkboxes using If statements for additional charges
        If chkCinema.Checked = True Then
            dblTotal += CINEMA_CHARGE
        End If
        If chkHBI.Checked = True Then
            dblTotal += HBI_CHARGE
        End If
        If chkShow.Checked = True Then
            dblTotal += SHOW_CHARGE
        End If
        If chkLocal.Checked = True Then
            dblTotal += LOCAL_CHARGE
        End If

        txtTotal.Text = dblTotal.ToString("C2")
    End Sub

    'Exit button to close form.
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dblTotal = 0
        txtTotal.Text = ""
    End Sub

    'The question asks that I implement the CheckChanged feature for both
    'the radio buttons and check boxes. I want to look into this.
    Private Sub radBasic_CheckedChanged(sender As Object, e As EventArgs) Handles radBasic.CheckedChanged

    End Sub

End Class
