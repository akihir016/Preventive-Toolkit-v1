' Form1.vb - Main form code
Imports System.Management ' Required for WMI (Windows Management Instrumentation)
Imports System.Net.NetworkInformation ' Required for Ping functionality
Imports System.Diagnostics ' Required for launching processes

Public Class Form1

    Private IsNightMode As Boolean = False ' Flag to track current theme mode

    ' --- Form Initialization and Event Handlers ---

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set initial form properties to fix the window as requested
        Me.Text = "Preventive Maintenance Toolkit"
        Me.FormBorderStyle = FormBorderStyle.FixedSingle ' Make the window non-resizable
        Me.MaximizeBox = False ' Disable maximize button
        Me.StartPosition = FormStartPosition.CenterScreen ' Center the form on screen
        Me.Size = New Size(736, 643) ' Set a fixed size for the form, adjust as needed based on control layout

        ' Apply the default theme (day mode)
        ApplyTheme(IsNightMode)
    End Sub

    ' --- Theme Management (Night Mode) ---

    Private Sub ToggleNightModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToggleNightModeToolStripMenuItem.Click
        ' Toggle the night mode flag
        IsNightMode = Not IsNightMode
        ' Apply the new theme
        ApplyTheme(IsNightMode)
    End Sub

    Private Sub ApplyTheme(isNight As Boolean)
        If isNight Then
            ' Night Mode Colors
            Me.BackColor = Color.FromArgb(45, 45, 48) ' Dark background
            Me.ForeColor = Color.White ' Light text
            MenuStrip1.BackColor = Color.FromArgb(30, 30, 30)
            MenuStrip1.ForeColor = Color.White

            ' Apply to all controls on the form
            For Each ctrl As Control In Me.Controls
                SetControlTheme(ctrl, True)
            Next
        Else
            ' Day Mode Colors (default)
            Me.BackColor = SystemColors.Control ' Standard Windows background
            Me.ForeColor = SystemColors.ControlText ' Standard Windows text
            MenuStrip1.BackColor = SystemColors.MenuBar
            MenuStrip1.ForeColor = SystemColors.ControlText

            ' Apply to all controls on the form
            For Each ctrl As Control In Me.Controls
                SetControlTheme(ctrl, False)
            Next
        End If
    End Sub

    Private Sub SetControlTheme(ctrl As Control, isNight As Boolean)
        If isNight Then
            ' Apply night mode colors
            ctrl.BackColor = Color.FromArgb(60, 60, 63) ' Slightly lighter dark for controls
            ctrl.ForeColor = Color.White

            ' Specific adjustments for certain control types
            If TypeOf ctrl Is Button Then
                Dim btn As Button = CType(ctrl, Button)
                btn.FlatStyle = FlatStyle.Flat
                btn.FlatAppearance.BorderColor = Color.FromArgb(90, 90, 90)
                btn.FlatAppearance.BorderSize = 1
                btn.BackColor = Color.FromArgb(70, 70, 73)
                btn.ForeColor = Color.White
            ElseIf TypeOf ctrl Is GroupBox Then
                Dim gb As GroupBox = CType(ctrl, GroupBox)
                gb.ForeColor = Color.White
            ElseIf TypeOf ctrl Is RichTextBox Then
                Dim rtb As RichTextBox = CType(ctrl, RichTextBox)
                rtb.BackColor = Color.FromArgb(30, 30, 30)
                rtb.ForeColor = Color.LightGray
            ElseIf TypeOf ctrl Is TextBox Then
                Dim txt As TextBox = CType(ctrl, TextBox)
                txt.BackColor = Color.FromArgb(30, 30, 30)
                txt.ForeColor = Color.LightGray
            ElseIf TypeOf ctrl Is TreeView Then
                Dim tv As TreeView = CType(ctrl, TreeView)
                tv.BackColor = Color.FromArgb(30, 30, 30)
                tv.ForeColor = Color.LightGray
                tv.LineColor = Color.Gray ' For tree view lines
            ElseIf TypeOf ctrl Is Panel Then
                ctrl.BackColor = Color.FromArgb(60, 60, 63)
            End If
        Else
            ' Apply day mode colors
            ctrl.BackColor = SystemColors.Control
            ctrl.ForeColor = SystemColors.ControlText

            If TypeOf ctrl Is Button Then
                Dim btn As Button = CType(ctrl, Button)
                btn.FlatStyle = FlatStyle.Standard
                btn.FlatAppearance.BorderColor = SystemColors.ControlDark
                btn.FlatAppearance.BorderSize = 0
                btn.BackColor = SystemColors.Control
                btn.ForeColor = SystemColors.ControlText
            ElseIf TypeOf ctrl Is GroupBox Then
                Dim gb As GroupBox = CType(ctrl, GroupBox)
                gb.ForeColor = SystemColors.ControlText
            ElseIf TypeOf ctrl Is RichTextBox Then
                Dim rtb As RichTextBox = CType(ctrl, RichTextBox)
                rtb.BackColor = Color.White
                rtb.ForeColor = SystemColors.ControlText
            ElseIf TypeOf ctrl Is TextBox Then
                Dim txt As TextBox = CType(ctrl, TextBox)
                txt.BackColor = Color.White
                txt.ForeColor = SystemColors.ControlText
            ElseIf TypeOf ctrl Is TreeView Then
                Dim tv As TreeView = CType(ctrl, TreeView)
                tv.BackColor = Color.White
                tv.ForeColor = SystemColors.ControlText
                tv.LineColor = SystemColors.ControlDark ' For tree view lines
            ElseIf TypeOf ctrl Is Panel Then
                ctrl.BackColor = SystemColors.Control
            End If
        End If

        ' Recursively apply theme to child controls
        For Each childCtrl As Control In ctrl.Controls
            SetControlTheme(childCtrl, isNight)
        Next
    End Sub

    ' --- Tool Buttons Functionality ---

    Private Sub BtnSystemRestore_Click(sender As Object, e As EventArgs) Handles btnSystemRestore.Click
        Try
            Process.Start("rstrui.exe")
        Catch ex As Exception
            MessageBox.Show("Error launching System Restore: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnWindowsSecurity_Click(sender As Object, e As EventArgs) Handles btnWindowsSecurity.Click
        Try
            ' This command opens Windows Security app
            Process.Start("ms-settings:windowssecurity")
        Catch ex As Exception
            MessageBox.Show("Error launching Windows Security: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnWindowsUpdate_Click(sender As Object, e As EventArgs) Handles btnWindowsUpdate.Click
        Try
            ' This command opens Windows Update settings
            Process.Start("ms-settings:windowsupdate")
        Catch ex As Exception
            MessageBox.Show("Error launching Windows Update: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnTaskManager_Click(sender As Object, e As EventArgs) Handles btnTaskManager.Click
        Try
            Process.Start("taskmgr.exe")
        Catch ex As Exception
            MessageBox.Show("Error launching Task Manager: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnDiskDefragmenter_Click(sender As Object, e As EventArgs) Handles btnDiskDefragmenter.Click
        Try
            Process.Start("dfrgui.exe")
        Catch ex As Exception
            MessageBox.Show("Error launching Disk Defragmenter: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnUninstallFiles_Click(sender As Object, e As EventArgs) Handles btnUninstallFiles.Click
        Try
            Process.Start("appwiz.cpl") ' Opens Programs and Features (Add/Remove Programs)
        Catch ex As Exception
            MessageBox.Show("Error launching Uninstall Files: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim psi As New ProcessStartInfo
            psi.FileName = "cmd.exe"
            psi.Arguments = "/c DISM /Online /Cleanup-Image /ScanHealth & pause"
            psi.Verb = "runas" ' Request administrator privileges
            psi.UseShellExecute = True ' Required for Verb="runas"

            Process.Start(psi)
        Catch ex As ComponentModel.Win32Exception
            ' Handle case where user cancels UAC prompt or other admin rights issues
            MessageBox.Show("Operation cancelled or administrator privileges denied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Error launching DISM ScanHealth: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim psi As New ProcessStartInfo
            psi.FileName = "cmd.exe"
            psi.Arguments = "/c DISM /Online /Cleanup-Image /RestoreHealth & pause"
            psi.Verb = "runas" ' Request administrator privileges
            psi.UseShellExecute = True ' Required for Verb="runas"

            Process.Start(psi)
        Catch ex As ComponentModel.Win32Exception
            ' Handle case where user cancels UAC prompt or other admin rights issues
            MessageBox.Show("Operation cancelled or administrator privileges denied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Error launching DISM RestoreHealth: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' --- Ping Functionality ---

    Private Async Sub BtnPing_Click(sender As Object, e As EventArgs) Handles btnPing.Click
        Dim target As String = TxtPingTarget.Text.Trim()
        If String.IsNullOrEmpty(target) Then
            MessageBox.Show("Please enter a target to ping.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        RtbPingOutput.Clear()
        RtbPingOutput.AppendText($"Pinging {target} with 32 bytes of data:{Environment.NewLine}{Environment.NewLine}")
        RtbPingOutput.ScrollToCaret()

        Dim pingSender As New Ping()
        Dim options As New PingOptions()
        options.DontFragment = True ' Set to True to prevent fragmentation (typical for standard ping)

        Dim data As String = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" ' 32 bytes of data
        Dim buffer() As Byte = System.Text.Encoding.ASCII.GetBytes(data)
        Dim timeout As Integer = 1000 ' 1 second timeout for each ping

        Dim successfulPings As Integer = 0
        Dim lostPings As Integer = 0
        Dim totalTime As Long = 0
        Dim minTime As Long = Long.MaxValue
        Dim maxTime As Long = Long.MinValue
        Dim numPings As Integer = 4 ' Number of pings to send

        For i As Integer = 1 To numPings
            Try
                Dim reply As PingReply = Await pingSender.SendPingAsync(target, timeout, buffer, options)

                If reply.Status = IPStatus.Success Then
                    RtbPingOutput.AppendText($"Reply from {reply.Address}: bytes={reply.Buffer.Length} time={reply.RoundtripTime}ms TTL={reply.Options.Ttl}{Environment.NewLine}")
                    successfulPings += 1
                    totalTime += reply.RoundtripTime
                    If reply.RoundtripTime < minTime Then minTime = reply.RoundtripTime
                    If reply.RoundtripTime > maxTime Then maxTime = reply.RoundtripTime
                Else
                    RtbPingOutput.AppendText($"Request timed out or encountered error: {reply.Status}{Environment.NewLine}")
                    lostPings += 1
                End If
            Catch ex As PingException
                RtbPingOutput.AppendText($"Ping Error: {ex.Message}{Environment.NewLine}")
                lostPings += 1
            Catch ex As Exception
                RtbPingOutput.AppendText($"General Error: {ex.Message}{Environment.NewLine}")
                lostPings += 1
            End Try
            RtbPingOutput.ScrollToCaret()
            Await Task.Delay(100) ' Small delay between pings
        Next

        RtbPingOutput.AppendText($"{Environment.NewLine}--- Ping Statistics for {target} ---{Environment.NewLine}")
        RtbPingOutput.AppendText($"Packets: Sent = {numPings}, Received = {successfulPings}, Lost = {lostPings} ({Math.Round(CDbl(lostPings) / numPings * 100, 0)}% loss){Environment.NewLine}")

        If successfulPings > 0 Then
            RtbPingOutput.AppendText($"Approximate round trip times in milli-seconds:{Environment.NewLine}")
            RtbPingOutput.AppendText($"Minimum = {minTime}ms, Maximum = {maxTime}ms, Average = {Math.Round(CDbl(totalTime) / successfulPings, 0)}ms{Environment.NewLine}")
        Else
            RtbPingOutput.AppendText("No successful replies to calculate round trip times." & Environment.NewLine)
        End If
        RtbPingOutput.ScrollToCaret()
    End Sub

    ' --- System Information Functionality ---

    Private Sub BtnSystemInformation_Click(sender As Object, e As EventArgs) Handles BtnSystemInformation.Click
        TrvSystemInfo.Nodes.Clear() ' Clear previous information

        Dim rootNode As New TreeNode("System Information")
        TrvSystemInfo.Nodes.Add(rootNode)

        ' Operating System Info
        Try
            Dim osSearcher As New ManagementObjectSearcher("SELECT Caption, InstallDate, OSArchitecture FROM Win32_OperatingSystem")
            For Each os As ManagementObject In osSearcher.Get()
                Dim osNode As New TreeNode("Operating System")
                osNode.Nodes.Add("Name: " & os("Caption").ToString())
                ' Format InstallDate to a readable format
                Dim installDateWMI As String = os("InstallDate").ToString()
                Dim installDateFormatted As String = ""
                If installDateWMI.Length >= 14 Then
                    installDateFormatted = DateTime.ParseExact(installDateWMI.Substring(0, 14), "yyyyMMddHHmmss", Nothing).ToString("yyyy-MM-dd HH:mm:ss")
                Else
                    installDateFormatted = installDateWMI
                End If
                osNode.Nodes.Add("Install Date: " & installDateFormatted)
                osNode.Nodes.Add("Architecture: " & os("OSArchitecture").ToString())
                rootNode.Nodes.Add(osNode)
                Exit For ' Only need one OS entry
            Next
        Catch ex As Exception
            rootNode.Nodes.Add("Operating System: Error retrieving information - " & ex.Message)
        End Try


        ' CPU Info
        Try
            Dim cpuSearcher As New ManagementObjectSearcher("SELECT Name FROM Win32_Processor")
            For Each cpu As ManagementObject In cpuSearcher.Get()
                Dim cpuNode As New TreeNode("CPU")
                cpuNode.Nodes.Add("Name: " & cpu("Name").ToString())
                rootNode.Nodes.Add(cpuNode)
                Exit For ' Usually just one primary CPU entry needed
            Next
        Catch ex As Exception
            rootNode.Nodes.Add("CPU: Error retrieving information - " & ex.Message)
        End Try

        ' RAM Info (Installed Physical Memory)
        Try
            Dim ramSearcher As New ManagementObjectSearcher("SELECT TotalPhysicalMemory FROM Win32_ComputerSystem")
            For Each ram As ManagementObject In ramSearcher.Get()
                Dim totalRAMBytes As ULong = CULng(ram("TotalPhysicalMemory"))
                Dim totalRAMGB As Double = Math.Round(CDbl(totalRAMBytes / (1024 * 1024 * 1024)), 2) ' Convert bytes to GB
                Dim ramNode As New TreeNode("RAM")
                ramNode.Nodes.Add($"Installed RAM: {totalRAMGB} GB")
                rootNode.Nodes.Add(ramNode)
                Exit For
            Next
        Catch ex As Exception
            rootNode.Nodes.Add("RAM: Error retrieving information - " & ex.Message)
        End Try

        ' GPU Info (Video Controller)
        Try
            Dim gpuSearcher As New ManagementObjectSearcher("SELECT Name, AdapterRAM FROM Win32_VideoController")
            For Each gpu As ManagementObject In gpuSearcher.Get()
                Dim gpuNode As New TreeNode("GPU")
                Dim adapterRAM As Object = gpu("AdapterRAM")
                Dim ramSize As String = If(adapterRAM IsNot Nothing, $" ({Math.Round(CDbl(CULng(adapterRAM) / (1024 * 1024)), 0)} MB)", "")
                gpuNode.Nodes.Add($"Name: {gpu("Name").ToString()}{ramSize}")
                rootNode.Nodes.Add(gpuNode)
            Next
        Catch ex As Exception
            rootNode.Nodes.Add("GPU: Error retrieving information - " & ex.Message)
        End Try

        ' Computer Name
        Try
            Dim compNameNode As New TreeNode("Computer Name")
            compNameNode.Nodes.Add("Name: " & Environment.MachineName)
            rootNode.Nodes.Add(compNameNode)
        Catch ex As Exception
            rootNode.Nodes.Add("Computer Name: Error retrieving information - " & ex.Message)
        End Try


        ' Storage Info (Logical Disks - C: D: etc. and Physical Disks)
        Try
            Dim storageNode As New TreeNode("Storage")
            ' Logical Disks
            Dim logicalDiskSearcher As New ManagementObjectSearcher("SELECT Caption, Size, FreeSpace FROM Win32_LogicalDisk WHERE DriveType = 3") ' DriveType 3 for Local Disk
            For Each logicalDisk As ManagementObject In logicalDiskSearcher.Get()
                Dim caption As String = logicalDisk("Caption").ToString()
                Dim totalSize As ULong = CULng(logicalDisk("Size"))
                Dim freeSpace As ULong = CULng(logicalDisk("FreeSpace"))
                Dim totalGB As Double = Math.Round(CDbl(totalSize / (1024 * 1024 * 1024)), 2)
                Dim freeGB As Double = Math.Round(CDbl(freeSpace / (1024 * 1024 * 1024)), 2)
                storageNode.Nodes.Add($"Logical Disk: {caption} - {totalGB} GB ({freeGB} GB free)")
            Next

            ' Physical Disks
            Dim physicalDiskSearcher As New ManagementObjectSearcher("SELECT Caption, Size FROM Win32_DiskDrive")
            For Each physicalDisk As ManagementObject In physicalDiskSearcher.Get()
                Dim caption As String = physicalDisk("Caption").ToString()
                Dim size As ULong = CULng(physicalDisk("Size"))
                Dim sizeGB As Double = Math.Round(CDbl(size / (1024 * 1024 * 1024)), 2)
                storageNode.Nodes.Add($"Physical Disk: {caption} ({sizeGB} GB)")
            Next
            rootNode.Nodes.Add(storageNode)
        Catch ex As Exception
            rootNode.Nodes.Add("Storage: Error retrieving information - " & ex.Message)
        End Try

        rootNode.ExpandAll() ' Expand all nodes for better visibility
    End Sub

    ' --- Menu Strip Items ---
    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        ' Placeholder for File menu item click
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        ' Placeholder for Help menu item click
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close() ' Closes the application
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Preventive Maintenance Toolkit" & Environment.NewLine & "Version 1.0" & Environment.NewLine & "Created by Gemini", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


End Class
