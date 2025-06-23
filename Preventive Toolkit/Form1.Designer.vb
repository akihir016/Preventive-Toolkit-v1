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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ToggleNightModeToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        GrpToolBox = New GroupBox()
        BtnDismTools = New Button()
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
        Label1 = New Label()
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
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(720, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToggleNightModeToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' ToggleNightModeToolStripMenuItem
        ' 
        ToggleNightModeToolStripMenuItem.Name = "ToggleNightModeToolStripMenuItem"
        ToggleNightModeToolStripMenuItem.Size = New Size(177, 22)
        ToggleNightModeToolStripMenuItem.Text = "Toggle &Night Mode"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(177, 22)
        ExitToolStripMenuItem.Text = "E&xit"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "&Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(107, 22)
        AboutToolStripMenuItem.Text = "&About"
        ' 
        ' GrpToolBox
        ' 
        GrpToolBox.Controls.Add(BtnDismTools)
        GrpToolBox.Controls.Add(BtnUninstallFiles)
        GrpToolBox.Controls.Add(BtnDiskDefragmenter)
        GrpToolBox.Controls.Add(BtnTaskManager)
        GrpToolBox.Controls.Add(BtnWindowsUpdate)
        GrpToolBox.Controls.Add(BtnWindowsSecurity)
        GrpToolBox.Controls.Add(BtnSystemRestore)
        GrpToolBox.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        GrpToolBox.Location = New Point(10, 34)
        GrpToolBox.Margin = New Padding(3, 2, 3, 2)
        GrpToolBox.Name = "GrpToolBox"
        GrpToolBox.Padding = New Padding(3, 2, 3, 2)
        GrpToolBox.Size = New Size(332, 218)
        GrpToolBox.TabIndex = 1
        GrpToolBox.TabStop = False
        GrpToolBox.Text = "ToolBox"
        ' 
        ' BtnDismTools
        ' 
        BtnDismTools.Font = New Font("Segoe UI", 9.0F)
        BtnDismTools.Location = New Point(184, 68)
        BtnDismTools.Margin = New Padding(3, 2, 3, 2)
        BtnDismTools.Name = "BtnDismTools"
        BtnDismTools.Size = New Size(130, 30)
        BtnDismTools.TabIndex = 6
        BtnDismTools.Text = " DISM and Other TOOLS"
        BtnDismTools.TextAlign = ContentAlignment.MiddleLeft
        BtnDismTools.UseVisualStyleBackColor = True
        ' 
        ' BtnUninstallFiles
        ' 
        BtnUninstallFiles.Font = New Font("Segoe UI", 9.0F)
        BtnUninstallFiles.Location = New Point(184, 29)
        BtnUninstallFiles.Margin = New Padding(3, 2, 3, 2)
        BtnUninstallFiles.Name = "BtnUninstallFiles"
        BtnUninstallFiles.Size = New Size(130, 30)
        BtnUninstallFiles.TabIndex = 5
        BtnUninstallFiles.Text = "Uninstall Files"
        BtnUninstallFiles.TextAlign = ContentAlignment.MiddleLeft
        BtnUninstallFiles.UseVisualStyleBackColor = True
        ' 
        ' BtnDiskDefragmenter
        ' 
        BtnDiskDefragmenter.Font = New Font("Segoe UI", 9.0F)
        BtnDiskDefragmenter.Location = New Point(18, 181)
        BtnDiskDefragmenter.Margin = New Padding(3, 2, 3, 2)
        BtnDiskDefragmenter.Name = "BtnDiskDefragmenter"
        BtnDiskDefragmenter.Size = New Size(130, 30)
        BtnDiskDefragmenter.TabIndex = 4
        BtnDiskDefragmenter.Text = " Disk Defragmenter"
        BtnDiskDefragmenter.TextAlign = ContentAlignment.MiddleLeft
        BtnDiskDefragmenter.UseVisualStyleBackColor = True
        ' 
        ' BtnTaskManager
        ' 
        BtnTaskManager.Font = New Font("Segoe UI", 9.0F)
        BtnTaskManager.Location = New Point(18, 143)
        BtnTaskManager.Margin = New Padding(3, 2, 3, 2)
        BtnTaskManager.Name = "BtnTaskManager"
        BtnTaskManager.Size = New Size(130, 30)
        BtnTaskManager.TabIndex = 3
        BtnTaskManager.Text = "Task Manager"
        BtnTaskManager.TextAlign = ContentAlignment.MiddleLeft
        BtnTaskManager.UseVisualStyleBackColor = True
        ' 
        ' BtnWindowsUpdate
        ' 
        BtnWindowsUpdate.Font = New Font("Segoe UI", 9.0F)
        BtnWindowsUpdate.Location = New Point(18, 106)
        BtnWindowsUpdate.Margin = New Padding(3, 2, 3, 2)
        BtnWindowsUpdate.Name = "BtnWindowsUpdate"
        BtnWindowsUpdate.Size = New Size(130, 30)
        BtnWindowsUpdate.TabIndex = 2
        BtnWindowsUpdate.Text = " Windows Update"
        BtnWindowsUpdate.TextAlign = ContentAlignment.MiddleLeft
        BtnWindowsUpdate.UseVisualStyleBackColor = True
        ' 
        ' BtnWindowsSecurity
        ' 
        BtnWindowsSecurity.Font = New Font("Segoe UI", 9.0F)
        BtnWindowsSecurity.Location = New Point(18, 68)
        BtnWindowsSecurity.Margin = New Padding(3, 2, 3, 2)
        BtnWindowsSecurity.Name = "BtnWindowsSecurity"
        BtnWindowsSecurity.Size = New Size(130, 30)
        BtnWindowsSecurity.TabIndex = 1
        BtnWindowsSecurity.Text = "Windows Security"
        BtnWindowsSecurity.TextAlign = ContentAlignment.MiddleLeft
        BtnWindowsSecurity.UseVisualStyleBackColor = True
        ' 
        ' BtnSystemRestore
        ' 
        BtnSystemRestore.Font = New Font("Segoe UI", 9.0F)
        BtnSystemRestore.Location = New Point(18, 29)
        BtnSystemRestore.Margin = New Padding(3, 2, 3, 2)
        BtnSystemRestore.Name = "BtnSystemRestore"
        BtnSystemRestore.Size = New Size(130, 30)
        BtnSystemRestore.TabIndex = 0
        BtnSystemRestore.Text = " System Restore"
        BtnSystemRestore.TextAlign = ContentAlignment.MiddleLeft
        BtnSystemRestore.UseVisualStyleBackColor = True
        ' 
        ' RtbPingOutput
        ' 
        RtbPingOutput.Location = New Point(368, 34)
        RtbPingOutput.Margin = New Padding(3, 2, 3, 2)
        RtbPingOutput.Name = "RtbPingOutput"
        RtbPingOutput.ReadOnly = True
        RtbPingOutput.Size = New Size(341, 166)
        RtbPingOutput.TabIndex = 2
        RtbPingOutput.Text = ""
        ' 
        ' TxtPingTarget
        ' 
        TxtPingTarget.Location = New Point(442, 232)
        TxtPingTarget.Margin = New Padding(3, 2, 3, 2)
        TxtPingTarget.Name = "TxtPingTarget"
        TxtPingTarget.Size = New Size(175, 23)
        TxtPingTarget.TabIndex = 3
        TxtPingTarget.Text = "google.com"
        ' 
        ' BtnPing
        ' 
        BtnPing.Location = New Point(366, 230)
        BtnPing.Margin = New Padding(3, 2, 3, 2)
        BtnPing.Name = "BtnPing"
        BtnPing.Size = New Size(70, 25)
        BtnPing.TabIndex = 4
        BtnPing.Text = "Ping"
        BtnPing.UseVisualStyleBackColor = True
        ' 
        ' GrpSystemInfo
        ' 
        GrpSystemInfo.Controls.Add(TrvSystemInfo)
        GrpSystemInfo.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        GrpSystemInfo.Location = New Point(10, 259)
        GrpSystemInfo.Margin = New Padding(3, 2, 3, 2)
        GrpSystemInfo.Name = "GrpSystemInfo"
        GrpSystemInfo.Padding = New Padding(3, 2, 3, 2)
        GrpSystemInfo.Size = New Size(699, 313)
        GrpSystemInfo.TabIndex = 5
        GrpSystemInfo.TabStop = False
        GrpSystemInfo.Text = "System Info Scan"
        ' 
        ' TrvSystemInfo
        ' 
        TrvSystemInfo.Location = New Point(9, 20)
        TrvSystemInfo.Margin = New Padding(3, 2, 3, 2)
        TrvSystemInfo.Name = "TrvSystemInfo"
        TrvSystemInfo.Size = New Size(674, 281)
        TrvSystemInfo.TabIndex = 0
        ' 
        ' BtnSystemInformation
        ' 
        BtnSystemInformation.Location = New Point(19, 576)
        BtnSystemInformation.Margin = New Padding(3, 2, 3, 2)
        BtnSystemInformation.Name = "BtnSystemInformation"
        BtnSystemInformation.Size = New Size(131, 22)
        BtnSystemInformation.TabIndex = 6
        BtnSystemInformation.Text = "System Information"
        BtnSystemInformation.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(368, 209)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 15)
        Label1.TabIndex = 7
        Label1.Text = "Host:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(720, 604)
        Controls.Add(Label1)
        Controls.Add(BtnSystemInformation)
        Controls.Add(GrpSystemInfo)
        Controls.Add(BtnPing)
        Controls.Add(TxtPingTarget)
        Controls.Add(RtbPingOutput)
        Controls.Add(GrpToolBox)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Preventive Maintenance Toolkit"
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
    Friend WithEvents BtnDismTools As Button
    Friend WithEvents BtnUninstallFiles As Button
    Friend WithEvents RtbPingOutput As RichTextBox
    Friend WithEvents TxtPingTarget As TextBox
    Friend WithEvents BtnPing As Button
    Friend WithEvents GrpSystemInfo As GroupBox
    Friend WithEvents TrvSystemInfo As TreeView
    Friend WithEvents BtnSystemInformation As Button
    Friend WithEvents Label1 As Label
End Class
