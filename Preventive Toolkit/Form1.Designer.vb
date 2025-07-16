' Form1.Designer.vb - Auto-generated code for form design
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ToggleNightModeToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        GrpToolBox = New GroupBox()
        BtnSmartTest = New Button()
        Button2 = New Button()
        Button1 = New Button()
        BtnTools = New Button()
        BtnUninstallFiles = New Button()
        BtnDiskDefragmenter = New Button()
        BtnTaskManager = New Button()
        BtnWindowsUpdate = New Button()
        BtnWindowsSecurity = New Button()
        BtnSystemRestore = New Button()
        RtbPingOutput = New RichTextBox()
        TxtPingTarget = New TextBox()
        BtnPing = New Button()
        GrpSystemInfo = New GroupBox()
        TrvSystemInfo = New TreeView()
        BtnSystemInformation = New Button()
        txtDate = New Label()
        Label1 = New Label()
        BtnSaveXml = New Button()
        Button3 = New Button()
        MenuStrip1.SuspendLayout()
        GrpToolBox.SuspendLayout()
        GrpSystemInfo.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(6, 3, 0, 3)
        MenuStrip1.Size = New Size(823, 30)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToggleNightModeToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' ToggleNightModeToolStripMenuItem
        ' 
        ToggleNightModeToolStripMenuItem.Checked = True
        ToggleNightModeToolStripMenuItem.CheckState = CheckState.Checked
        ToggleNightModeToolStripMenuItem.Name = "ToggleNightModeToolStripMenuItem"
        ToggleNightModeToolStripMenuItem.Size = New Size(224, 26)
        ToggleNightModeToolStripMenuItem.Text = "Toggle &Night Mode"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(224, 26)
        ExitToolStripMenuItem.Text = "E&xit"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(55, 24)
        HelpToolStripMenuItem.Text = "&Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(133, 26)
        AboutToolStripMenuItem.Text = "&About"
        ' 
        ' GrpToolBox
        ' 
        GrpToolBox.Controls.Add(BtnSmartTest)
        GrpToolBox.Controls.Add(Button2)
        GrpToolBox.Controls.Add(Button1)
        GrpToolBox.Controls.Add(BtnTools)
        GrpToolBox.Controls.Add(BtnUninstallFiles)
        GrpToolBox.Controls.Add(BtnDiskDefragmenter)
        GrpToolBox.Controls.Add(BtnTaskManager)
        GrpToolBox.Controls.Add(BtnWindowsUpdate)
        GrpToolBox.Controls.Add(BtnWindowsSecurity)
        GrpToolBox.Controls.Add(BtnSystemRestore)
        GrpToolBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        GrpToolBox.Location = New Point(11, 45)
        GrpToolBox.Name = "GrpToolBox"
        GrpToolBox.Size = New Size(359, 277)
        GrpToolBox.TabIndex = 1
        GrpToolBox.TabStop = False
        GrpToolBox.Text = "ToolBox"
        ' 
        ' BtnSmartTest
        ' 
        BtnSmartTest.Font = New Font("Segoe UI", 9F)
        BtnSmartTest.Location = New Point(200, 179)
        BtnSmartTest.Name = "BtnSmartTest"
        BtnSmartTest.Size = New Size(135, 40)
        BtnSmartTest.TabIndex = 9
        BtnSmartTest.Text = "Hard Disk Smart Test"
        BtnSmartTest.TextAlign = ContentAlignment.MiddleLeft
        BtnSmartTest.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 9F)
        Button2.Location = New Point(277, 129)
        Button2.Name = "Button2"
        Button2.Size = New Size(58, 40)
        Button2.TabIndex = 8
        Button2.Text = "Repair"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F)
        Button1.Location = New Point(200, 129)
        Button1.Name = "Button1"
        Button1.Size = New Size(81, 40)
        Button1.TabIndex = 7
        Button1.Text = "DISM Scan"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = True
        ' 
        ' BtnTools
        ' 
        BtnTools.Font = New Font("Segoe UI", 9F)
        BtnTools.Location = New Point(200, 79)
        BtnTools.Name = "BtnTools"
        BtnTools.Size = New Size(135, 40)
        BtnTools.TabIndex = 6
        BtnTools.Text = "Other Tools"
        BtnTools.TextAlign = ContentAlignment.MiddleLeft
        BtnTools.UseVisualStyleBackColor = True
        ' 
        ' BtnUninstallFiles
        ' 
        BtnUninstallFiles.Font = New Font("Segoe UI", 9F)
        BtnUninstallFiles.Location = New Point(200, 27)
        BtnUninstallFiles.Name = "BtnUninstallFiles"
        BtnUninstallFiles.Size = New Size(135, 40)
        BtnUninstallFiles.TabIndex = 5
        BtnUninstallFiles.Text = "Uninstall Files"
        BtnUninstallFiles.TextAlign = ContentAlignment.MiddleLeft
        BtnUninstallFiles.UseVisualStyleBackColor = True
        ' 
        ' BtnDiskDefragmenter
        ' 
        BtnDiskDefragmenter.Font = New Font("Segoe UI", 9F)
        BtnDiskDefragmenter.Location = New Point(22, 229)
        BtnDiskDefragmenter.Name = "BtnDiskDefragmenter"
        BtnDiskDefragmenter.Size = New Size(147, 40)
        BtnDiskDefragmenter.TabIndex = 4
        BtnDiskDefragmenter.Text = " Disk Defragmenter"
        BtnDiskDefragmenter.TextAlign = ContentAlignment.MiddleLeft
        BtnDiskDefragmenter.UseVisualStyleBackColor = True
        ' 
        ' BtnTaskManager
        ' 
        BtnTaskManager.Font = New Font("Segoe UI", 9F)
        BtnTaskManager.Location = New Point(22, 179)
        BtnTaskManager.Name = "BtnTaskManager"
        BtnTaskManager.Size = New Size(147, 40)
        BtnTaskManager.TabIndex = 3
        BtnTaskManager.Text = "Task Manager"
        BtnTaskManager.TextAlign = ContentAlignment.MiddleLeft
        BtnTaskManager.UseVisualStyleBackColor = True
        ' 
        ' BtnWindowsUpdate
        ' 
        BtnWindowsUpdate.Font = New Font("Segoe UI", 9F)
        BtnWindowsUpdate.Location = New Point(22, 129)
        BtnWindowsUpdate.Name = "BtnWindowsUpdate"
        BtnWindowsUpdate.Size = New Size(147, 40)
        BtnWindowsUpdate.TabIndex = 2
        BtnWindowsUpdate.Text = " Windows Update"
        BtnWindowsUpdate.TextAlign = ContentAlignment.MiddleLeft
        BtnWindowsUpdate.UseVisualStyleBackColor = True
        ' 
        ' BtnWindowsSecurity
        ' 
        BtnWindowsSecurity.Font = New Font("Segoe UI", 9F)
        BtnWindowsSecurity.Location = New Point(22, 79)
        BtnWindowsSecurity.Name = "BtnWindowsSecurity"
        BtnWindowsSecurity.Size = New Size(147, 40)
        BtnWindowsSecurity.TabIndex = 1
        BtnWindowsSecurity.Text = "Windows Security"
        BtnWindowsSecurity.TextAlign = ContentAlignment.MiddleLeft
        BtnWindowsSecurity.UseVisualStyleBackColor = True
        ' 
        ' BtnSystemRestore
        ' 
        BtnSystemRestore.Font = New Font("Segoe UI", 9F)
        BtnSystemRestore.Location = New Point(22, 27)
        BtnSystemRestore.Name = "BtnSystemRestore"
        BtnSystemRestore.Size = New Size(147, 40)
        BtnSystemRestore.TabIndex = 0
        BtnSystemRestore.Text = " System Restore"
        BtnSystemRestore.TextAlign = ContentAlignment.MiddleLeft
        BtnSystemRestore.UseVisualStyleBackColor = True
        ' 
        ' RtbPingOutput
        ' 
        RtbPingOutput.Location = New Point(387, 97)
        RtbPingOutput.Name = "RtbPingOutput"
        RtbPingOutput.ReadOnly = True
        RtbPingOutput.Size = New Size(421, 185)
        RtbPingOutput.TabIndex = 2
        RtbPingOutput.Text = ""
        ' 
        ' TxtPingTarget
        ' 
        TxtPingTarget.Location = New Point(474, 292)
        TxtPingTarget.Name = "TxtPingTarget"
        TxtPingTarget.Size = New Size(199, 27)
        TxtPingTarget.TabIndex = 3
        TxtPingTarget.Text = "google.com"
        ' 
        ' BtnPing
        ' 
        BtnPing.Location = New Point(387, 289)
        BtnPing.Name = "BtnPing"
        BtnPing.Size = New Size(80, 33)
        BtnPing.TabIndex = 4
        BtnPing.Text = "Ping"
        BtnPing.UseVisualStyleBackColor = True
        ' 
        ' GrpSystemInfo
        ' 
        GrpSystemInfo.Controls.Add(TrvSystemInfo)
        GrpSystemInfo.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        GrpSystemInfo.Location = New Point(11, 328)
        GrpSystemInfo.Name = "GrpSystemInfo"
        GrpSystemInfo.Size = New Size(799, 415)
        GrpSystemInfo.TabIndex = 5
        GrpSystemInfo.TabStop = False
        GrpSystemInfo.Text = "System Information"
        ' 
        ' TrvSystemInfo
        ' 
        TrvSystemInfo.Location = New Point(22, 27)
        TrvSystemInfo.Name = "TrvSystemInfo"
        TrvSystemInfo.Size = New Size(755, 373)
        TrvSystemInfo.TabIndex = 0
        ' 
        ' BtnSystemInformation
        ' 
        BtnSystemInformation.Location = New Point(11, 748)
        BtnSystemInformation.Name = "BtnSystemInformation"
        BtnSystemInformation.Size = New Size(50, 43)
        BtnSystemInformation.TabIndex = 6
        BtnSystemInformation.Text = "Scan"
        BtnSystemInformation.UseVisualStyleBackColor = True
        ' 
        ' txtDate
        ' 
        txtDate.Location = New Point(0, 0)
        txtDate.Name = "txtDate"
        txtDate.Size = New Size(100, 23)
        txtDate.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(470, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(309, 26)
        Label1.TabIndex = 7
        Label1.Text = "Thursday, December 25, 2025"
        ' 
        ' BtnSaveXml
        ' 
        BtnSaveXml.Location = New Point(69, 748)
        BtnSaveXml.Name = "BtnSaveXml"
        BtnSaveXml.Size = New Size(50, 43)
        BtnSaveXml.TabIndex = 8
        BtnSaveXml.Text = "Save"
        BtnSaveXml.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(125, 748)
        Button3.Name = "Button3"
        Button3.Size = New Size(57, 43)
        Button3.TabIndex = 9
        Button3.Text = "Clear"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(823, 805)
        Controls.Add(Button3)
        Controls.Add(BtnSaveXml)
        Controls.Add(Label1)
        Controls.Add(BtnSystemInformation)
        Controls.Add(GrpSystemInfo)
        Controls.Add(BtnPing)
        Controls.Add(TxtPingTarget)
        Controls.Add(RtbPingOutput)
        Controls.Add(GrpToolBox)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Preventive Maintenance Toolkit v1.5"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GrpToolBox.ResumeLayout(False)
        GrpSystemInfo.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToggleNightModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrpToolBox As GroupBox
    Friend WithEvents BtnSystemRestore As Button
    Friend WithEvents BtnWindowsSecurity As Button
    Friend WithEvents BtnDiskDefragmenter As Button
    Friend WithEvents BtnTaskManager As Button
    Friend WithEvents BtnWindowsUpdate As Button
    Friend WithEvents BtnTools As Button
    Friend WithEvents BtnUninstallFiles As Button
    Friend WithEvents RtbPingOutput As RichTextBox
    Friend WithEvents TxtPingTarget As TextBox
    Friend WithEvents BtnPing As Button
    Friend WithEvents GrpSystemInfo As GroupBox
    Friend WithEvents TrvSystemInfo As TreeView
    Friend WithEvents BtnSystemInformation As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSaveXml As Button
    Friend WithEvents BtnSmartTest As Button
    Friend WithEvents BtnClearTree As Button
    Friend WithEvents Button3 As Button
End Class
