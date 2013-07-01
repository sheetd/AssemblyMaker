Public Class MainForm

    Private Sub ButtonGenerate_Click(sender As Object, e As EventArgs) Handles ButtonGenerate.Click

        Me.Hide()

        Call Main()

        Me.Show()

    End Sub

 
    Private Sub ButtonAxisSystems_Click(sender As Object, e As EventArgs) Handles ButtomAxisSystems.Click

        Dim CATIA As INFITF.Application
        CATIA = GetObject(, "CATIA.Application")

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

        Dim dialog As New OpenFileDialog()
        If DialogResult.OK = dialog.ShowDialog Then
            TextBoxFilePath.Text = dialog.FileName
        End If

    End Sub


End Class