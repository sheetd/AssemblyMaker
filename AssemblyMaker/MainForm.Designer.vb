<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDownInstanceUpdateCount = New System.Windows.Forms.NumericUpDown()
        Me.CheckBoxInstanceCount = New System.Windows.Forms.CheckBox()
        Me.CheckBoxName = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSave = New System.Windows.Forms.CheckBox()
        Me.CheckBoxUpdate = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxFilePath = New System.Windows.Forms.TextBox()
        Me.ButtonGenerate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtomAxisSystems = New System.Windows.Forms.Button()
        Me.ButtonFilePath = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDownInstanceUpdateCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NumericUpDownInstanceUpdateCount)
        Me.GroupBox1.Controls.Add(Me.CheckBoxInstanceCount)
        Me.GroupBox1.Controls.Add(Me.CheckBoxName)
        Me.GroupBox1.Controls.Add(Me.CheckBoxSave)
        Me.GroupBox1.Controls.Add(Me.CheckBoxUpdate)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 175)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 110)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'NumericUpDownInstanceUpdateCount
        '
        Me.NumericUpDownInstanceUpdateCount.Location = New System.Drawing.Point(242, 85)
        Me.NumericUpDownInstanceUpdateCount.Name = "NumericUpDownInstanceUpdateCount"
        Me.NumericUpDownInstanceUpdateCount.Size = New System.Drawing.Size(57, 20)
        Me.NumericUpDownInstanceUpdateCount.TabIndex = 4
        Me.NumericUpDownInstanceUpdateCount.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'CheckBoxInstanceCount
        '
        Me.CheckBoxInstanceCount.AutoSize = True
        Me.CheckBoxInstanceCount.Location = New System.Drawing.Point(6, 88)
        Me.CheckBoxInstanceCount.Name = "CheckBoxInstanceCount"
        Me.CheckBoxInstanceCount.Size = New System.Drawing.Size(239, 17)
        Me.CheckBoxInstanceCount.TabIndex = 3
        Me.CheckBoxInstanceCount.Text = "Update assembly after X number of instances"
        Me.CheckBoxInstanceCount.UseVisualStyleBackColor = True
        '
        'CheckBoxName
        '
        Me.CheckBoxName.AutoSize = True
        Me.CheckBoxName.Checked = True
        Me.CheckBoxName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxName.Location = New System.Drawing.Point(6, 65)
        Me.CheckBoxName.Name = "CheckBoxName"
        Me.CheckBoxName.Size = New System.Drawing.Size(209, 17)
        Me.CheckBoxName.TabIndex = 2
        Me.CheckBoxName.Text = "Name constraint based on Axis System"
        Me.CheckBoxName.UseVisualStyleBackColor = True
        '
        'CheckBoxSave
        '
        Me.CheckBoxSave.AutoSize = True
        Me.CheckBoxSave.Checked = True
        Me.CheckBoxSave.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxSave.Location = New System.Drawing.Point(6, 42)
        Me.CheckBoxSave.Name = "CheckBoxSave"
        Me.CheckBoxSave.Size = New System.Drawing.Size(166, 17)
        Me.CheckBoxSave.TabIndex = 1
        Me.CheckBoxSave.Text = "Save assembly on completion"
        Me.CheckBoxSave.UseVisualStyleBackColor = True
        '
        'CheckBoxUpdate
        '
        Me.CheckBoxUpdate.AutoSize = True
        Me.CheckBoxUpdate.Checked = True
        Me.CheckBoxUpdate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxUpdate.Location = New System.Drawing.Point(6, 19)
        Me.CheckBoxUpdate.Name = "CheckBoxUpdate"
        Me.CheckBoxUpdate.Size = New System.Drawing.Size(176, 17)
        Me.CheckBoxUpdate.TabIndex = 0
        Me.CheckBoxUpdate.Text = "Update assembly on completion"
        Me.CheckBoxUpdate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Part/Product to Instantiate"
        '
        'TextBoxFilePath
        '
        Me.TextBoxFilePath.Location = New System.Drawing.Point(15, 133)
        Me.TextBoxFilePath.Name = "TextBoxFilePath"
        Me.TextBoxFilePath.ReadOnly = True
        Me.TextBoxFilePath.Size = New System.Drawing.Size(513, 20)
        Me.TextBoxFilePath.TabIndex = 3
        Me.TextBoxFilePath.Text = "<No Selection>"
        '
        'ButtonGenerate
        '
        Me.ButtonGenerate.Location = New System.Drawing.Point(431, 254)
        Me.ButtonGenerate.Name = "ButtonGenerate"
        Me.ButtonGenerate.Size = New System.Drawing.Size(97, 33)
        Me.ButtonGenerate.TabIndex = 8
        Me.ButtonGenerate.Text = "Execute"
        Me.ButtonGenerate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Axis Systems"
        '
        'ButtomAxisSystems
        '
        Me.ButtomAxisSystems.Location = New System.Drawing.Point(12, 36)
        Me.ButtomAxisSystems.Name = "ButtomAxisSystems"
        Me.ButtomAxisSystems.Size = New System.Drawing.Size(104, 27)
        Me.ButtomAxisSystems.TabIndex = 9
        Me.ButtomAxisSystems.Text = "Click to Select"
        Me.ButtomAxisSystems.UseVisualStyleBackColor = True
        '
        'ButtonFilePath
        '
        Me.ButtonFilePath.Location = New System.Drawing.Point(12, 100)
        Me.ButtonFilePath.Name = "ButtonFilePath"
        Me.ButtonFilePath.Size = New System.Drawing.Size(104, 27)
        Me.ButtonFilePath.TabIndex = 10
        Me.ButtonFilePath.Text = "Click to Select"
        Me.ButtonFilePath.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 298)
        Me.Controls.Add(Me.ButtonFilePath)
        Me.Controls.Add(Me.ButtomAxisSystems)
        Me.Controls.Add(Me.ButtonGenerate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxFilePath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MainForm"
        Me.Text = "Assembly Maker v1.0"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDownInstanceUpdateCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxFilePath As System.Windows.Forms.TextBox
    Friend WithEvents ButtonGenerate As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtomAxisSystems As System.Windows.Forms.Button
    Friend WithEvents ButtonFilePath As System.Windows.Forms.Button
    Friend WithEvents CheckBoxName As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSave As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents NumericUpDownInstanceUpdateCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents CheckBoxInstanceCount As System.Windows.Forms.CheckBox
End Class
