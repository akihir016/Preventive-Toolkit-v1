<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        btnBatteryReport = New Button()
        gbMaintenance = New GroupBox()
        btnSecMain = New Button()
        btnPowerOpt = New Button()
        gbRepair = New GroupBox()
        btnUserAcc = New Button()
        btnWinTools = New Button()
        btnTroubleshoot = New Button()
        btnSpooler = New Button()
        gbMaintenance.SuspendLayout()
        gbRepair.SuspendLayout()
        MenuStrip1 = New MenuStrip()
        ThemeToolStripMenuItem = New ToolStripMenuItem()
        ToggleNightModeToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnBatteryReport
        ' 
        btnBatteryReport.Location = New Point(8, 17)
        btnBatteryReport.Name = "btnBatteryReport"
        btnBatteryReport.Size = New Size(103, 28)
        btnBatteryReport.TabIndex = 0
        btnBatteryReport.Text = "Battery Report"
        btnBatteryReport.UseVisualStyleBackColor = True
        ' 
        ' gbMaintenance
        ' 
        gbMaintenance.Controls.Add(btnSecMain)
        gbMaintenance.Controls.Add(btnPowerOpt)
        gbMaintenance.Controls.Add(btnBatteryReport)
        gbMaintenance.Location = New Point(12, 27)
        gbMaintenance.Name = "gbMaintenance"
        gbMaintenance.Size = New Size(125, 189)
        gbMaintenance.TabIndex = 1
        gbMaintenance.TabStop = False
        gbMaintenance.Text = "Maintenance Tools"
        ' 
        ' btnSecMain
        ' 
        btnSecMain.Location = New Point(8, 85)
        btnSecMain.Name = "btnSecMain"
        btnSecMain.Size = New Size(103, 45)
        btnSecMain.TabIndex = 2
        btnSecMain.Text = "Security Maintenance"
        btnSecMain.UseVisualStyleBackColor = True
        ' 
        ' btnPowerOpt
        ' 
        btnPowerOpt.Location = New Point(8, 51)
        btnPowerOpt.Name = "btnPowerOpt"
        btnPowerOpt.Size = New Size(103, 28)
        btnPowerOpt.TabIndex = 1
        btnPowerOpt.Text = "Power Options"
        btnPowerOpt.UseVisualStyleBackColor = True
        ' 
        ' gbRepair
        ' 
        gbRepair.Controls.Add(btnUserAcc)
        gbRepair.Controls.Add(btnWinTools)
        gbRepair.Controls.Add(btnTroubleshoot)
        gbRepair.Controls.Add(btnSpooler)
        gbRepair.Location = New Point(143, 27)
        gbRepair.Name = "gbRepair"
        gbRepair.Size = New Size(147, 189)
        gbRepair.TabIndex = 2
        gbRepair.TabStop = False
        gbRepair.Text = "Repair Tools"
        ' 
        ' btnUserAcc
        ' 
        btnUserAcc.Location = New Point(6, 119)
        btnUserAcc.Name = "btnUserAcc"
        btnUserAcc.Size = New Size(133, 28)
        btnUserAcc.TabIndex = 3
        btnUserAcc.Text = "User Accounts"
        btnUserAcc.UseVisualStyleBackColor = True
        ' 
        ' btnWinTools
        ' 
        btnWinTools.Location = New Point(6, 85)
        btnWinTools.Name = "btnWinTools"
        btnWinTools.Size = New Size(133, 28)
        btnWinTools.TabIndex = 2
        btnWinTools.Text = "Window Tools"
        btnWinTools.UseVisualStyleBackColor = True
        ' 
        ' btnTroubleshoot
        ' 
        btnTroubleshoot.Location = New Point(6, 51)
        btnTroubleshoot.Name = "btnTroubleshoot"
        btnTroubleshoot.Size = New Size(133, 28)
        btnTroubleshoot.TabIndex = 1
        btnTroubleshoot.Text = "Troubleshoot"
        btnTroubleshoot.UseVisualStyleBackColor = True
        ' 
        ' btnSpooler
        ' 
        btnSpooler.Location = New Point(6, 17)
        btnSpooler.Name = "btnSpooler"
        btnSpooler.Size = New Size(133, 28)
        btnSpooler.TabIndex = 0
        btnSpooler.Text = "Restart Print Spooler"
        btnSpooler.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        '
        MenuStrip1.Items.AddRange(New ToolStripItem() {ThemeToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(302, 24)
        MenuStrip1.TabIndex = 3
        MenuStrip1.Text = "MenuStrip1"
        '
        ' ThemeToolStripMenuItem
        '
        ThemeToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToggleNightModeToolStripMenuItem})
        ThemeToolStripMenuItem.Name = "ThemeToolStripMenuItem"
        ThemeToolStripMenuItem.Size = New Size(55, 20)
        ThemeToolStripMenuItem.Text = "Theme"
        '
        ' ToggleNightModeToolStripMenuItem
        '
        ToggleNightModeToolStripMenuItem.Name = "ToggleNightModeToolStripMenuItem"
        ToggleNightModeToolStripMenuItem.Size = New Size(180, 22)
        ToggleNightModeToolStripMenuItem.Text = "Toggle Night Mode"
        '
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(302, 227)
        Controls.Add(gbRepair)
        Controls.Add(gbMaintenance)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form2"
        Text = "Toolkit"
        gbMaintenance.ResumeLayout(False)
        gbRepair.ResumeLayout(False)
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBatteryReport As Button
    Friend WithEvents gbMaintenance As GroupBox
    Friend WithEvents gbRepair As GroupBox
    Friend WithEvents btnSpooler As Button
    Friend WithEvents btnPowerOpt As Button
    Friend WithEvents btnSecMain As Button
    Friend WithEvents btnWinTools As Button
    Friend WithEvents btnTroubleshoot As Button
    Friend WithEvents btnUserAcc As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ThemeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToggleNightModeToolStripMenuItem As ToolStripMenuItem
End Class
