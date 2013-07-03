Public Class MainForm

    Private Sub ButtonAxisSystems_Click(sender As Object, e As EventArgs) Handles ButtomAxisSystems.Click

        'Check to see if CATIA is running
        Call StartCATIA()

        'Get Axis System selection from Userform
        Dim InputObjectType(0)
        InputObjectType(0) = "AxisSystem"

        Dim MySelection As INFITF.Selection
        MySelection = CATIA.ActiveDocument.Selection
        MySelection.Clear()

        Me.Hide()

        Dim ListSel
        ListSel = MySelection.SelectElement3(InputObjectType, "Select Axis Systems", True, INFITF.CATMultiSelectionMode.CATMultiSelTriggWhenUserValidatesSelection, True)

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