Public Class Form5
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub btnCourse_Click(sender As Object, e As EventArgs) Handles btnCourse.Click
        Me.Hide()
        Form4.Show()

    End Sub

    Private Sub comTable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comTable.SelectedIndexChanged
        Dim tableName As String
        tableName = comTable.Text
        If tableName = "Profile" Then
            Label4.Text = "Enter Student ID"
            comStudent.Hide()
            comCourse.Hide()
            comProfile.Show()
            Label4.Show()
            txtID1.Show()



        ElseIf tableName = "Course" Then
            Label4.Text = "Enter Course_code"
            comProfile.Hide()
            comStudent.Hide()
            comCourse.Show()
            Label4.Show()
            txtID1.Show()





        ElseIf tableName = "Student" Then
            Label4.Text = "Enter Student_ID"
            comProfile.Hide()
            comCourse.Hide()
            comStudent.Show()
            Label4.Show()
            txtID1.Show()


        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtID1.Clear()

        txtNewVal.Clear()

    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click

        Dim tableName As String
        Dim field As String
        Dim id As String
        tableName = comTable.Text

        If tableName = "Profile" Then
            field = comProfile.Text
            id = "Student_ID"
        ElseIf tableName = "Course" Then
            field = comCourse.Text
            id = "Course_code"
        ElseIf tableName = "Student" Then
            field = comStudent.Text
            id = "Student_ID"
        End If

        If txtID1.Text = "" Or txtNewVal.Text = "" Or tableName = "" Or field = "" Then
            MsgBox("Enter Data", MsgBoxStyle.Exclamation, "Erro")

        Else
            xUpdateDATA(tableName, New String() {field}, New String() {txtNewVal.Text}, id + "=" + txtID1.Text)
            MsgBox("Successfully updated", MsgBoxStyle.Information, "Information")
        End If





    End Sub
End Class