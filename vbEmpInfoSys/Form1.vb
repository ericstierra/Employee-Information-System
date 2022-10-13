Public Class Form1
    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        Dim GIncome, NIncome, Deductions, Incentives As Double
        Incentives = Val(txtIncentives.Text)
        GIncome = Val(txtNoOfWorkDays.Text * txtDailyRate.Text)
        Deductions = Val(txtSSS.Text) + Val(txtPagIBIG.Text) + Val(txtPhilHealth.Text) + Val(txtTIN.Text)
        NIncome = GIncome - Deductions + Incentives

        MsgBox("Name : " & UCase(txtLName.Text) & ", " & txtFName.Text & " " & txtMI.Text & vbCrLf &
               "Gender : " & txtGender.Text & vbCrLf &
               "Pronoun : " & txtPronoun.Text & vbCrLf &
               "Birthday : " & dtBday.Value & vbCrLf &
               "Home Address : " & txtHomeAdd.Text & vbCrLf &
               "Mobile Number : " & txtMobileNum.Text & vbCrLf &
               "Email Address : " & txtEmailAdd.Text & vbCrLf & vbCrLf &
               "Emergency Contact" & vbCrLf &
               "Name : " & txtEName.Text & vbCrLf &
               "Relationship : " & txtERelationship.Text & vbCrLf &
               "Mobile Number : " & txtEMobileNum.Text & vbCrLf &
               "Address : " & txtEAdd.Text & vbCrLf & vbCrLf &
               "Gross Income : ₱" & Format$(GIncome, "#,#00.00") & vbCrLf &
               "Deductions : ₱" & Format$(Deductions, "#,#00.00") & vbCrLf &
               "Incentives : ₱" & Format$(Incentives, "#,#00.00") & vbCrLf &
               "Net Income : ₱" & Format$(NIncome, "#,#00.00"),
               MsgBoxStyle.Information, "Employee's Information System")
    End Sub
End Class
