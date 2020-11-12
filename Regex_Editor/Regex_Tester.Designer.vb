<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtRegex = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnHelp = New System.Windows.Forms.Button
        Me.txtOuput = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnOutput = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtOutPutTill = New System.Windows.Forms.TextBox
        Me.txtResult = New System.Windows.Forms.RichTextBox
        Me.txtOrigin = New System.Windows.Forms.RichTextBox
        Me.txtFormat = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtRegex
        '
        Me.txtRegex.AllowDrop = True
        Me.txtRegex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtRegex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txtRegex.BackColor = System.Drawing.SystemColors.Info
        Me.txtRegex.Location = New System.Drawing.Point(78, 13)
        Me.txtRegex.Name = "txtRegex"
        Me.txtRegex.Size = New System.Drawing.Size(443, 20)
        Me.txtRegex.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Regex Text"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 75)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtOrigin)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtResult)
        Me.SplitContainer1.Size = New System.Drawing.Size(840, 360)
        Me.SplitContainer1.SplitterDistance = 122
        Me.SplitContainer1.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Location = New System.Drawing.Point(730, 8)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(71, 28)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search ..."
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(527, 11)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(29, 23)
        Me.btnHelp.TabIndex = 5
        Me.btnHelp.Text = "..."
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'txtOuput
        '
        Me.txtOuput.AllowDrop = True
        Me.txtOuput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtOuput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txtOuput.BackColor = System.Drawing.SystemColors.Info
        Me.txtOuput.Location = New System.Drawing.Point(78, 39)
        Me.txtOuput.Name = "txtOuput"
        Me.txtOuput.Size = New System.Drawing.Size(116, 20)
        Me.txtOuput.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Replace by"
        '
        'btnOutput
        '
        Me.btnOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOutput.Location = New System.Drawing.Point(730, 39)
        Me.btnOutput.Name = "btnOutput"
        Me.btnOutput.Size = New System.Drawing.Size(71, 28)
        Me.btnOutput.TabIndex = 8
        Me.btnOutput.Text = "Replace"
        Me.btnOutput.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnOutput)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtFormat)
        Me.Panel1.Controls.Add(Me.txtOutPutTill)
        Me.Panel1.Controls.Add(Me.txtOuput)
        Me.Panel1.Controls.Add(Me.btnHelp)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtRegex)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(840, 75)
        Me.Panel1.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(213, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "till"
        '
        'txtOutPutTill
        '
        Me.txtOutPutTill.AllowDrop = True
        Me.txtOutPutTill.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtOutPutTill.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txtOutPutTill.BackColor = System.Drawing.SystemColors.Info
        Me.txtOutPutTill.Location = New System.Drawing.Point(253, 39)
        Me.txtOutPutTill.Name = "txtOutPutTill"
        Me.txtOutPutTill.Size = New System.Drawing.Size(131, 20)
        Me.txtOutPutTill.TabIndex = 6
        '
        'txtResult
        '
        Me.txtResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtResult.Location = New System.Drawing.Point(0, 0)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(840, 234)
        Me.txtResult.TabIndex = 0
        Me.txtResult.Text = ""
        '
        'txtOrigin
        '
        Me.txtOrigin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOrigin.Location = New System.Drawing.Point(0, 0)
        Me.txtOrigin.Name = "txtOrigin"
        Me.txtOrigin.Size = New System.Drawing.Size(840, 122)
        Me.txtOrigin.TabIndex = 1
        Me.txtOrigin.Text = ""
        '
        'txtFormat
        '
        Me.txtFormat.AllowDrop = True
        Me.txtFormat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtFormat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txtFormat.BackColor = System.Drawing.SystemColors.Info
        Me.txtFormat.Location = New System.Drawing.Point(462, 39)
        Me.txtFormat.Name = "txtFormat"
        Me.txtFormat.Size = New System.Drawing.Size(131, 20)
        Me.txtFormat.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(400, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "format"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 435)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Regex Tester"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtRegex As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents txtOuput As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnOutput As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOutPutTill As System.Windows.Forms.TextBox
    Friend WithEvents txtOrigin As System.Windows.Forms.RichTextBox
    Friend WithEvents txtResult As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFormat As System.Windows.Forms.TextBox

End Class
