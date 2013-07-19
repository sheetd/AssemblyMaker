Public Class MainForm

    Private Sub ButtonAxisSystems_Click(sender As Object, e As EventArgs) Handles ButtomAxisSystems.Click

        Me.Hide()

        Call StartCATIA()

        Call ListSelection()

        Me.Show()

    End Sub

    Private Sub ButtonFilePath_Click(sender As Object, e As EventArgs) Handles ButtonFilePath.Click

        'Set file path with dialog box
        Dim FileDialog As New OpenFileDialog()
        If DialogResult.OK = FileDialog.ShowDialog Then
            TextBoxFilePath.Text = FileDialog.FileName
        End If

    End Sub

    Private Sub ButtonGenerate_Click(sender As Object, e As EventArgs) Handles ButtonGenerate.Click

        Me.Hide()

        Call Main()

        Me.Show()

    End Sub

End Class