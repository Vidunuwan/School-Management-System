Public Class Form2
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCoursecode.Clear()
        txtFree.Clear()
        txtStudentID.Clear()

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtStudentID.Text = "" Or txtCoursecode.Text = "" Or txtFree.Text = "" Then
            MsgBox("Enter data", MsgBoxStyle.Exclamation, "Erro")
        Else
            xSaveDATA("Profile", "Student_ID,course_code,fee_paid", New String() {txtStudentID.Text, txtCoursecode.Text, txtFree.Text})

            MsgBox("Save Successfuly", MsgBoxStyle.Information, "Save")

            txtCoursecode.Clear()
            txtFree.Clear()
            txtStudentID.Clear()


        End If

    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub btnCourse_Click(sender As Object, e As EventArgs) Handles btnCourse.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Me.Hide()
        Form5.Show()

    End Sub
End Class