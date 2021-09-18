Public Class Form4
    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCoursecode.Clear()
        txtDepartment.Clear()
        txtFee.Clear()
        txtLevel.Clear()
        txtSubject.Clear()
        txtWeek.Clear()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Me.Hide()
        Form5.Show()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtCoursecode.Text = "" Or txtSubject.Text = "" Or txtDepartment.Text = "" Or txtLevel.Text = "" Or txtFee.Text = "" Or txtWeek.Text = "" Then
            MsgBox("Enter Data", MsgBoxStyle.Exclamation, "Erro")
        Else
            xSaveDATA("Course", "Course_code,Subject,Department,Levelc,Fee,Duration_weeks", New String() {txtCoursecode.Text, txtSubject.Text, txtDepartment.Text, txtLevel.Text, txtFee.Text, txtWeek.Text})

            MsgBox("Save Successfuly", MsgBoxStyle.Information, "Save")


            txtCoursecode.Clear()
            txtDepartment.Clear()
            txtFee.Clear()
            txtLevel.Clear()
            txtSubject.Clear()
            txtWeek.Clear()
        End If

    End Sub
End Class