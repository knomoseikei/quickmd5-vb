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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnGenerate = New System.Windows.Forms.Button()
        Me.BtnCheck = New System.Windows.Forms.Button()
        Me.BtnAddFiles = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TxtMd5List = New System.Windows.Forms.TextBox()
        Me.lxtBoxFiles = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnGenerate)
        Me.Panel1.Controls.Add(Me.BtnCheck)
        Me.Panel1.Controls.Add(Me.BtnAddFiles)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 30)
        Me.Panel1.TabIndex = 0
        '
        'BtnGenerate
        '
        Me.BtnGenerate.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnGenerate.Location = New System.Drawing.Point(399, 0)
        Me.BtnGenerate.Name = "BtnGenerate"
        Me.BtnGenerate.Size = New System.Drawing.Size(110, 30)
        Me.BtnGenerate.TabIndex = 2
        Me.BtnGenerate.Text = "Generate MD5"
        Me.BtnGenerate.UseVisualStyleBackColor = True
        '
        'BtnCheck
        '
        Me.BtnCheck.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnCheck.Location = New System.Drawing.Point(509, 0)
        Me.BtnCheck.Name = "BtnCheck"
        Me.BtnCheck.Size = New System.Drawing.Size(75, 30)
        Me.BtnCheck.TabIndex = 1
        Me.BtnCheck.Text = "Check MD5"
        Me.BtnCheck.UseVisualStyleBackColor = True
        '
        'BtnAddFiles
        '
        Me.BtnAddFiles.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnAddFiles.Location = New System.Drawing.Point(0, 0)
        Me.BtnAddFiles.Name = "BtnAddFiles"
        Me.BtnAddFiles.Size = New System.Drawing.Size(75, 30)
        Me.BtnAddFiles.TabIndex = 0
        Me.BtnAddFiles.Text = "Add files..."
        Me.BtnAddFiles.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 30)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lxtBoxFiles)
        Me.SplitContainer1.Panel1MinSize = 50
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TxtMd5List)
        Me.SplitContainer1.Panel2MinSize = 50
        Me.SplitContainer1.Size = New System.Drawing.Size(584, 332)
        Me.SplitContainer1.SplitterDistance = 280
        Me.SplitContainer1.TabIndex = 4
        '
        'TxtMd5List
        '
        Me.TxtMd5List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtMd5List.Location = New System.Drawing.Point(0, 0)
        Me.TxtMd5List.Multiline = True
        Me.TxtMd5List.Name = "TxtMd5List"
        Me.TxtMd5List.Size = New System.Drawing.Size(300, 332)
        Me.TxtMd5List.TabIndex = 0
        '
        'lxtBoxFiles
        '
        Me.lxtBoxFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lxtBoxFiles.FormattingEnabled = True
        Me.lxtBoxFiles.Location = New System.Drawing.Point(0, 0)
        Me.lxtBoxFiles.Name = "lxtBoxFiles"
        Me.lxtBoxFiles.Size = New System.Drawing.Size(280, 332)
        Me.lxtBoxFiles.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 362)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MainForm"
        Me.Text = "QuickMD5 * by Knomo Seikei"
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnAddFiles As System.Windows.Forms.Button
    Friend WithEvents BtnCheck As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TxtMd5List As System.Windows.Forms.TextBox
    Friend WithEvents BtnGenerate As System.Windows.Forms.Button
    Friend WithEvents lxtBoxFiles As System.Windows.Forms.ListBox

End Class
