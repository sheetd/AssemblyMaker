
Imports INFITF
Imports MECMOD
Imports ProductStructureTypeLib



Public Module MainModule

    Public Filepath(0)
    Public InstanceUpdateCount As Integer
    Public CATIA As INFITF.Application
    Public MyProduct As Product
    Public MyProducts As Products
    Public AxisSystems As Selection

    Sub StartCATIA()

        'Set-up CATIA object
        CATIA = GetObject(, "CATIA.Application")

        'Debug.WriteLineIf(CATIA Is Nothing, "Launching CATIA/DP. Create geometry support environment")
        'Debug.WriteLineIf(CATIA IsNot Nothing, "CATIA/DP already open")

        If CATIA Is Nothing Then
            CATIA = CreateObject("CATIA.Application")
            CATIA.Visible = True
            MessageBox.Show("Starting CATIA")
            Exit Sub
        End If

    End Sub

    Sub Main()

        Call ProcessUserform()

        Call CreateConstraint()

    End Sub

    Sub ProcessUserform()

        'Pull settings from userform
        Filepath(0) = MainForm.TextBoxFilePath.Text
        InstanceUpdateCount = MainForm.NumericUpDownInstanceUpdateCount.Value

        'Check for valid filepath
        If Filepath(0) = "<No Selection>" Then
            MessageBox.Show("No Part/Product Selected")
            'Go back to user selection?
        End If

        'Check for valid Axis System selection
        AxisSystems = CATIA.ActiveDocument.Selection

        If AxisSystems Is Nothing Then
            MessageBox.Show("No Axis Systems Selected")
        End If

    End Sub


    Sub CreateConstraint()

        MyProduct = CATIA.ActiveDocument.Product

        MyProducts = MyProduct.Products

        'Load product in to Design Mode
        'MyProduct.ApplyWorkMode(CatWorkModeType.DESIGN_MODE)

        'Loop for # of Axis Systems
        For i = 1 To AxisSystems.Count

            'Insert Part
            MyProducts.AddComponentsFromFiles(Filepath, "All")

            'Count to find new part position in assembly
            Dim PartCount As Integer
            PartCount = MyProducts.Count()

            'Load inserted Part in Design Mode
            If i = 1 Then
                'MyProducts.Item(i + 1).ApplyWorkMode(CatWorkModeType.DESIGN_MODE)
                MyProducts.Item(PartCount).ApplyWorkMode(CatWorkModeType.DESIGN_MODE)
            End If

            'Select Axis Systems of Driver part
            Dim AxisRefName
            AxisRefName = AxisSystems.Item(i).Value.Name

            Dim RefPub1
            RefPub1 = MyProducts.Item(1).Publications.Item(AxisRefName)

            Dim Ref1 As Reference
            Ref1 = RefPub1.Valuation

            'Select Axis System of Inserted Assembly
            Dim RefPub2
            RefPub2 = MyProducts.Item(PartCount).Publications.Item(1) 'Select 1st Publication in new part
            'Set RefPub2 = MyProducts.Item(PartCount).Publications.Item("Absolute Axis System") 'Alternate: Select named Axis System in new part

            Dim Ref2 As Reference
            Ref2 = RefPub2.Valuation

            'Create Axis to Axis Constraint
            Dim MyConstraints As Constraints
            MyConstraints = MyProduct.Connections("CATIAConstraints")

            Dim MyConstraint As Constraint
            MyConstraint = MyConstraints.AddBiEltCst(CatConstraintType.catCstTypeOn, Ref1, Ref2)

            'Option to name constraint feature based on Axis System name
            If MainForm.CheckBoxName.CheckState = CheckState.Checked Then
                MyConstraint.Name = AxisRefName
            End If

            'Option to update during instantiation every XX loops (clears memory)
            If MainForm.CheckBoxInstanceCount.CheckState = CheckState.Checked Then
                If (i Mod InstanceUpdateCount) = 0 Then
                    MyProduct.Update()
                End If
            End If

            'Display progress in the status bar
            CATIA.StatusBar = "Instantiating " & i & " of " & AxisSystems.Count

        Next i

        'Option to update assembly
        If MainForm.CheckBoxUpdate.CheckState = CheckState.Checked Then
            MyProduct.Update()
        End If

        'Option to Save assembly (must already be saved once)
        If MainForm.CheckBoxSave.CheckState = CheckState.Checked Then
            CATIA.ActiveDocument.Save()
        End If


    End Sub



End Module


