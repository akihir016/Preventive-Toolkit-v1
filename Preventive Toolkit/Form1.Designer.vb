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
        Button2 = New Button()
        Button1 = New Button()
        BtnDismScan = New Button()
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
        GrpToolBox.Controls.Add(Button2)
        GrpToolBox.Controls.Add(Button1)
        GrpToolBox.Controls.Add(BtnDismScan)
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
        GrpToolBox.Size = New Size(314, 208)
        GrpToolBox.TabIndex = 1
        GrpToolBox.TabStop = False
        GrpToolBox.Text = "ToolBox"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 9.0F)
        Button2.Location = New Point(242, 97)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(51, 30)
        Button2.TabIndex = 8
        Button2.Text = "Repair"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9.0F)
        Button1.Location = New Point(175, 97)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(71, 30)
        Button1.TabIndex = 7
        Button1.Text = "DISM Scan"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = True
        ' 
        ' BtnDismScan
        ' 
        BtnDismScan.Font = New Font("Segoe UI", 9.0F)
        BtnDismScan.Location = New Point(175, 59)
        BtnDismScan.Margin = New Padding(3, 2, 3, 2)
        BtnDismScan.Name = "BtnDismScan"
        BtnDismScan.Size = New Size(118, 30)
        BtnDismScan.TabIndex = 6
        BtnDismScan.Text = "Other Tools"
        BtnDismScan.TextAlign = ContentAlignment.MiddleLeft
        BtnDismScan.UseVisualStyleBackColor = True
        ' 
        ' BtnUninstallFiles
        ' 
        BtnUninstallFiles.Font = New Font("Segoe UI", 9.0F)
        BtnUninstallFiles.Location = New Point(175, 20)
        BtnUninstallFiles.Margin = New Padding(3, 2, 3, 2)
        BtnUninstallFiles.Name = "BtnUninstallFiles"
        BtnUninstallFiles.Size = New Size(118, 30)
        BtnUninstallFiles.TabIndex = 5
        BtnUninstallFiles.Text = "Uninstall Files"
        BtnUninstallFiles.TextAlign = ContentAlignment.MiddleLeft
        BtnUninstallFiles.UseVisualStyleBackColor = True
        ' 
        ' BtnDiskDefragmenter
        ' 
        BtnDiskDefragmenter.Font = New Font("Segoe UI", 9.0F)
        BtnDiskDefragmenter.Location = New Point(19, 172)
        BtnDiskDefragmenter.Margin = New Padding(3, 2, 3, 2)
        BtnDiskDefragmenter.Name = "BtnDiskDefragmenter"
        BtnDiskDefragmenter.Size = New Size(121, 30)
        BtnDiskDefragmenter.TabIndex = 4
        BtnDiskDefragmenter.Text = " Disk Defragmenter"
        BtnDiskDefragmenter.TextAlign = ContentAlignment.MiddleLeft
        BtnDiskDefragmenter.UseVisualStyleBackColor = True
        ' 
        ' BtnTaskManager
        ' 
        BtnTaskManager.Font = New Font("Segoe UI", 9.0F)
        BtnTaskManager.Location = New Point(19, 134)
        BtnTaskManager.Margin = New Padding(3, 2, 3, 2)
        BtnTaskManager.Name = "BtnTaskManager"
        BtnTaskManager.Size = New Size(121, 30)
        BtnTaskManager.TabIndex = 3
        BtnTaskManager.Text = "Task Manager"
        BtnTaskManager.TextAlign = ContentAlignment.MiddleLeft
        BtnTaskManager.UseVisualStyleBackColor = True
        ' 
        ' BtnWindowsUpdate
        ' 
        BtnWindowsUpdate.Font = New Font("Segoe UI", 9.0F)
        BtnWindowsUpdate.Location = New Point(19, 97)
        BtnWindowsUpdate.Margin = New Padding(3, 2, 3, 2)
        BtnWindowsUpdate.Name = "BtnWindowsUpdate"
        BtnWindowsUpdate.Size = New Size(121, 30)
        BtnWindowsUpdate.TabIndex = 2
        BtnWindowsUpdate.Text = " Windows Update"
        BtnWindowsUpdate.TextAlign = ContentAlignment.MiddleLeft
        BtnWindowsUpdate.UseVisualStyleBackColor = True
        ' 
        ' BtnWindowsSecurity
        ' 
        BtnWindowsSecurity.Font = New Font("Segoe UI", 9.0F)
        BtnWindowsSecurity.Location = New Point(19, 59)
        BtnWindowsSecurity.Margin = New Padding(3, 2, 3, 2)
        BtnWindowsSecurity.Name = "BtnWindowsSecurity"
        BtnWindowsSecurity.Size = New Size(121, 30)
        BtnWindowsSecurity.TabIndex = 1
        BtnWindowsSecurity.Text = "Windows Security"
        BtnWindowsSecurity.TextAlign = ContentAlignment.MiddleLeft
        BtnWindowsSecurity.UseVisualStyleBackColor = True
        ' 
        ' BtnSystemRestore
        ' 
        BtnSystemRestore.Font = New Font("Segoe UI", 9.0F)
        BtnSystemRestore.Location = New Point(19, 20)
        BtnSystemRestore.Margin = New Padding(3, 2, 3, 2)
        BtnSystemRestore.Name = "BtnSystemRestore"
        BtnSystemRestore.Size = New Size(121, 30)
        BtnSystemRestore.TabIndex = 0
        BtnSystemRestore.Text = " System Restore"
        BtnSystemRestore.TextAlign = ContentAlignment.MiddleLeft
        BtnSystemRestore.UseVisualStyleBackColor = True
        ' 
        ' RtbPingOutput
        ' 
        RtbPingOutput.Location = New Point(339, 73)
        RtbPingOutput.Margin = New Padding(3, 2, 3, 2)
        RtbPingOutput.Name = "RtbPingOutput"
        RtbPingOutput.ReadOnly = True
        RtbPingOutput.Size = New Size(369, 140)
        RtbPingOutput.TabIndex = 2
        RtbPingOutput.Text = ""
        ' 
        ' TxtPingTarget
        ' 
        TxtPingTarget.Location = New Point(415, 219)
        TxtPingTarget.Margin = New Padding(3, 2, 3, 2)
        TxtPingTarget.Name = "TxtPingTarget"
        TxtPingTarget.Size = New Size(175, 23)
        TxtPingTarget.TabIndex = 3
        TxtPingTarget.Text = "google.com"
        ' 
        ' BtnPing
        ' 
        BtnPing.Location = New Point(339, 217)
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
        GrpSystemInfo.Location = New Point(10, 246)
        GrpSystemInfo.Margin = New Padding(3, 2, 3, 2)
        GrpSystemInfo.Name = "GrpSystemInfo"
        GrpSystemInfo.Padding = New Padding(3, 2, 3, 2)
        GrpSystemInfo.Size = New Size(699, 311)
        GrpSystemInfo.TabIndex = 5
        GrpSystemInfo.TabStop = False
        GrpSystemInfo.Text = "System Information"
        ' 
        ' TrvSystemInfo
        ' 
        TrvSystemInfo.Location = New Point(6, 20)
        TrvSystemInfo.Margin = New Padding(3, 2, 3, 2)
        TrvSystemInfo.Name = "TrvSystemInfo"
        TrvSystemInfo.Size = New Size(674, 281)
        TrvSystemInfo.TabIndex = 0
        ' 
        ' BtnSystemInformation
        ' 
        BtnSystemInformation.Location = New Point(10, 561)
        BtnSystemInformation.Margin = New Padding(3, 2, 3, 2)
        BtnSystemInformation.Name = "BtnSystemInformation"
        BtnSystemInformation.Size = New Size(44, 32)
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
        Label1.Font = New Font("MV Boli", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(411, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 21)
        Label1.TabIndex = 7
        Label1.Text = "txtDate"
        ' 
        ' BtnSaveXml
        ' 
        BtnSaveXml.Location = New Point(60, 561)
        BtnSaveXml.Margin = New Padding(3, 2, 3, 2)
        BtnSaveXml.Name = "BtnSaveXml"
        BtnSaveXml.Size = New Size(44, 32)
        BtnSaveXml.TabIndex = 8
        BtnSaveXml.Text = "Save"
        BtnSaveXml.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(720, 604)
        Controls.Add(BtnSaveXml)
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
    Friend WithEvents BtnDismScan As Button
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
End Class
