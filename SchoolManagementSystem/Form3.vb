Public Class Form3
    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub btnCourse_Click(sender As Object, e As EventArgs) Handles btnCourse.Click
        Me.Hide()
        Form4.Show()

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtConcession.Clear()
        txtFirst.Clear()
        txtLast.Clear()
        txtStudentID.Clear()
        txtGender.Clear()


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Me.Hide()
        Form5.Show()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtStudentID.Text = "" Or txtFirst.Text = "" Or txtLast.Text = "" Or txtGender.Text = "" Or txtConcession.Text = "" Or DateTimePicker.Text = "" Then
            MsgBox("Enter Data", MsgBoxStyle.Exclamation, "Erro")
        Else
            xSaveDATA("Student", "Student_ID,Last_name,First_name,DOB,Gender,Concession", New String() {txtStudentID.Text, txtLast.Text, txtFirst.Text, DateTimePicker.Text, txtGender.Text, txtConcession.Text})

            MsgBox("Save Successfuly", MsgBoxStyle.Information, "Save")

            txtConcession.Clear()
            txtFirst.Clear()
            txtLast.Clear()
            txtStudentID.Clear()
            txtGender.Clear()


        End If
    End Sub
End Class