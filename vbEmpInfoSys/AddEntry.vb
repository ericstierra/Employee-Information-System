Public Class AddEntry
    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        Dim GIncome, NIncome, Deductions, Incentives, Philhealth, GIncome4P, PwtPlus, PwtPlus2, DailyRate As Double
        Incentives = Val(txtIncentives.Text)
        DailyRate = Val(txtDailyRate.Text)
        GIncome = Val(txtNoOfWorkDays.Text * txtDailyRate.Text)

        'Condition to get Philhealth Deduction
        GIncome4P = GIncome * 0.04
        Philhealth = GIncome4P

        'Condition to get the Prescribed Withholding Tax plus Additional deductions
        If DailyRate <= 685 Then
            PwtPlus = 0
        ElseIf DailyRate > 685 AndAlso DailyRate < 1095 Then
            PwtPlus2 = 685 * 0.2
            PwtPlus = 0 + PwtPlus2
        ElseIf DailyRate > 1096 AndAlso DailyRate < 2191 Then
            PwtPlus2 = 1096 * 0.25
            PwtPlus = 82.19 + PwtPlus2
        ElseIf DailyRate > 2192 AndAlso DailyRate < 5478 Then
            PwtPlus2 = 2192 * 0.3
            PwtPlus = 356.16 + PwtPlus2
        ElseIf DailyRate > 5479 AndAlso DailyRate < 21917 Then
            PwtPlus2 = 5479 * 0.32
            PwtPlus = 1342.47 + PwtPlus2
        ElseIf DailyRate >= 21918 Then
            PwtPlus2 = 21918 * 0.35
            PwtPlus = 6602.74 + PwtPlus2
        End If

        Deductions = Val(txtSSS.Text) + Val(txtPagIBIG.Text) + Philhealth + PwtPlus
        NIncome = GIncome - Deductions + Incentives

        If String.IsNullOrEmpty(txtFName.Text) Then
            MsgBox("Invalid entry!", MsgBoxStyle.Information, "Opps!")
        Else
            'Output for Basic Informations
            lblFullName.Text = txtLName.Text & ", " & txtFName.Text & " " & txtMI.Text & "."
            lblGender.Text = txtGender.Text
            lblAge.Text = txtAge.Text
            lblAdd.Text = txtHomeAdd.Text
            lblMobileNum.Text = txtMobileNum.Text
            lblEadd.Text = txtEmailAdd.Text

            'Output for Emergency Contact
            lblEName.Text = txtEName.Text
            lblRelationship.Text = txtERelationship.Text
            lblEHomeAdd.Text = txtEAdd.Text
            lblEMobileNum.Text = txtEMobileNum.Text

            'Output for Personal Informations
            lblGrossSal.Text = "₱" & Format$(GIncome, "#,##0.00")
            lblIncentive.Text = "₱" & Format$(Incentives, "#,##0.00")
            lblDeduct.Text = "₱" & Format$(Deductions, "#,##0.00")
            lblNetSal.Text = "₱" & Format$(NIncome, "#,##0.00")
            lblWtax.Text = "₱" & Format$(PwtPlus, "#,##0.00")
            lblPhilhealth.Text = "₱" & Format$(Philhealth, "#,##0.00")
        End If
    End Sub

    Private Sub dtBday_LostFocus(sender As Object, e As EventArgs) Handles dtBday.LostFocus
        Dim Age As Integer
        Age = DateDiff(DateInterval.Year, dtBday.Value, Now())

        If Age > 1 Then
            txtAge.Text = Age & " years old"
        Else
            txtAge.Text = Age & " year old"
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Controls.Clear()
        InitializeComponent()
    End Sub

    Private Sub ClearEntry()
        'Clear all Textboxes
        txtFName.Clear()
        txtMI.Clear()
        txtLName.Clear()

    End Sub
End Class
