Imports System.Management ' Required for WMI (Windows Management Instrumentation)
Imports System.Net.NetworkInformation ' Required for Ping functionality
Imports System.Diagnostics ' Required for launching processes
Imports System.IO
Imports System.Xml

Public Class Form1

    Private IsNightMode As Boolean = False ' Flag to track current theme mode
    Private currentMonth As Integer ' Variable to track the current month for date display

    ' --- Form Initialization and Event Handlers ---

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set initial form properties to fix the window as requested
        Me.Text = "Preventive Maintenance Toolkit"
        Me.FormBorderStyle = FormBorderStyle.FixedSingle ' Make the window non-resizable
        Me.MaximizeBox = False ' Disable maximize button
        Me.StartPosition = FormStartPosition.CenterScreen ' Center the form on screen
        Me.Size = New Size(736, 643) ' Set a fixed size for the form, adjust as needed based on control layout

        ' Initialize current month
        currentMonth = DateTime.Now.Month

        UpdateDate()

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

    Private Sub BtnSystemRestore_Click(sender As Object, e As EventArgs) Handles BtnSystemRestore.Click
        Try
            RunSystemPropertiesProtection()
        Catch ex As Exception
            MessageBox.Show("Error launching System Restore: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnWindowsSecurity_Click(sender As Object, e As EventArgs) Handles BtnWindowsSecurity.Click
        Try
            Process.Start("cmd.exe", "/c start windowsdefender:")
        Catch ex As Exception
            MessageBox.Show("Error launching Windows Security: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub BtnWindowsUpdate_Click(sender As Object, e As EventArgs) Handles BtnWindowsUpdate.Click
        Try
            ' This command opens Windows Update settings
            Process.Start("cmd.exe", "/c start ms-settings:windowsupdate")
        Catch ex As Exception
            MessageBox.Show("Error launching Windows Update: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnTaskManager_Click(sender As Object, e As EventArgs) Handles BtnTaskManager.Click
        Try
            Process.Start("taskmgr.exe")
        Catch ex As Exception
            MessageBox.Show("Error launching Task Manager: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnDiskDefragmenter_Click(sender As Object, e As EventArgs) Handles BtnDiskDefragmenter.Click
        Try
            Process.Start("dfrgui.exe")
        Catch ex As Exception
            MessageBox.Show("Error launching Disk Defragmenter: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnUninstallFiles_Click(sender As Object, e As EventArgs) Handles BtnUninstallFiles.Click
        Try
            RunAppwizCpl() ' Opens Programs and Features (Add/Remove Programs)
        Catch ex As Exception
            MessageBox.Show("Error launching Uninstall Files: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '--- Hard Disk SMART Test Functionality ---
    Private Sub BtnSmartTest_Click(sender As Object, e As EventArgs) Handles BtnSmartTest.Click
        Try
            Dim psi As New ProcessStartInfo
            psi.FileName = "cmd.exe"
            psi.Arguments = "cmd /c wmic diskdrive get Caption, DeviceID, Model, Size, Status & pause"
            psi.Verb = "runas" ' Request administrator privileges
            psi.UseShellExecute = True ' Required for Verb="runas"

            Process.Start(psi)
        Catch ex As ComponentModel.Win32Exception
            ' Handle case where user cancels UAC prompt or other admin rights issues
            MessageBox.Show("Operation cancelled or administrator privileges denied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Error HDD Smart Test: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '--- DISM Commands Functionality ---
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
    '--- DISM RestoreHealth Functionality ---
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

    Private Async Sub BtnPing_Click(sender As Object, e As EventArgs) Handles BtnPing.Click
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
            Dim gpuNode As New TreeNode("GPU")
            Dim gpuName As String = "N/A"
            Dim vramBytes As ULong = 0
            Dim vramReported As Boolean = False
            Dim primaryGpuFoundWmiModern As Boolean = False

            ' Try modern WMI approach first (MSFT_PhysicalGPU)
            Try
                ' Connect to the StandardCimv2 namespace for MSFT_PhysicalGPU
                Dim scope As New ManagementScope("\\.\root\StandardCimv2")
                scope.Connect()
                Dim queryModern As New ObjectQuery("SELECT AdapterCompatibility, DedicatedVideoMemory FROM MSFT_PhysicalGPU WHERE PrimaryAdapter = True") ' Assuming PrimaryAdapter property exists or filter as needed
                Using modernGpuSearcher As New ManagementObjectSearcher(scope, queryModern)
                    Dim modernGpus As ManagementObjectCollection = modernGpuSearcher.Get()
                    If modernGpus.Count > 0 Then
                        For Each gpu As ManagementObject In modernGpus
                            gpuName = gpu("AdapterCompatibility")?.ToString() ' Or another property for name if available
                            If gpu("DedicatedVideoMemory") IsNot Nothing AndAlso ULong.TryParse(gpu("DedicatedVideoMemory").ToString(), vramBytes) Then
                                vramReported = True
                                primaryGpuFoundWmiModern = True
                            End If
                            ' Assuming we only want the primary GPU from this modern query
                            Exit For
                        Next
                    End If
                End Using
            Catch exModern As Exception
                ' Failed to get info using MSFT_PhysicalGPU, will fall back to Win32_VideoController
                ' This catch block can be used for logging if needed, but for now, we just proceed to fallback
            End Try

            ' Fallback to Win32_VideoController if modern approach failed or didn't report VRAM
            If Not primaryGpuFoundWmiModern OrElse Not vramReported Then
                Dim gpuSearcher As New ManagementObjectSearcher("SELECT Name, AdapterRAM FROM Win32_VideoController")
                For Each gpu As ManagementObject In gpuSearcher.Get()
                    If Not primaryGpuFoundWmiModern Then ' Only update name if not already found by modern method
                        gpuName = gpu("Name").ToString()
                    End If
                    If Not vramReported Then ' Only update VRAM if not already found by modern method
                        Dim adapterRAMObj As Object = gpu("AdapterRAM")
                        If adapterRAMObj IsNot Nothing AndAlso ULong.TryParse(adapterRAMObj.ToString(), vramBytes) Then
                            vramReported = True
                        End If
                    End If
                    ' Typically, the first one is the primary, or if MSFT_PhysicalGPU didn't specify, take the first one with VRAM
                    If vramReported OrElse Not primaryGpuFoundWmiModern Then Exit For
                Next
            End If

            If String.IsNullOrWhiteSpace(gpuName) OrElse gpuName = "N/A" Then
                gpuName = "Unknown GPU" ' Default if name couldn't be determined
            End If

            Dim ramSizeDisplay As String
            If vramReported Then
                If vramBytes > 0 Then
                    Dim vramGB As Double = Math.Round(CDbl(vramBytes) / (1024 * 1024 * 1024), 2)
                    ramSizeDisplay = $" ({vramGB} GB)"
                Else
                    ramSizeDisplay = " (VRAM not reported or 0 MB)"
                End If
            Else
                ' Attempt to use the original AdapterRAM from Win32_VideoController if MSFT_PhysicalGPU failed completely
                ' This part is mostly redundant if the fallback logic above works, but as a safeguard:
                Try
                    Dim fallbackSearcher As New ManagementObjectSearcher("SELECT Name, AdapterRAM FROM Win32_VideoController")
                    For Each gpu As ManagementObject In fallbackSearcher.Get()
                        gpuName = gpu("Name").ToString() ' Overwrite name if we are in complete fallback
                        Dim adapterRAMFallback As Object = gpu("AdapterRAM")
                        If adapterRAMFallback IsNot Nothing Then
                            Dim fallbackVramBytes As ULong = CULng(adapterRAMFallback)
                            Dim fallbackVramMB As Double = Math.Round(CDbl(fallbackVramBytes / (1024 * 1024)), 0)
                            ramSizeDisplay = $" ({fallbackVramMB} MB - legacy)"
                            vramReported = True ' Mark as reported for display logic
                        Else
                            ramSizeDisplay = " (VRAM not available - legacy)"
                        End If
                        Exit For ' Take the first one
                    Next
                Catch exFallback As Exception
                    ramSizeDisplay = " (Error retrieving VRAM - legacy)"
                End Try
                If Not vramReported Then ramSizeDisplay = " (VRAM information not available)"
            End If

            gpuNode.Nodes.Add($"Name: {gpuName}{ramSizeDisplay}")
            rootNode.Nodes.Add(gpuNode)

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
    ' --- System Properties Protection Functionality ---
    Private Sub RunSystemPropertiesProtection()
        Try
            Dim system32Path As String = Environment.GetFolderPath(Environment.SpecialFolder.System)
            Dim systemPropertiesProtectionPath As String = Path.Combine(system32Path, "SystemPropertiesProtection.exe")

            If File.Exists(systemPropertiesProtectionPath) Then
                Process.Start(systemPropertiesProtectionPath)
            Else
                MessageBox.Show("SystemPropertiesProtection.exe not found in System32 folder.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    ' --- Uninstall Files Functionality ---
    Private Sub RunAppwizCpl()
        Try
            ' Use the Shell function to run appwiz.cpl
            Shell("appwiz.cpl", AppWinStyle.NormalFocus)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
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
        MessageBox.Show("Preventive Maintenance Toolkit" & Environment.NewLine & "Version 1.1" & Environment.NewLine & "Created by NIA R3 IT STAFF", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    ' --- XML Saving Functionality ---
    Private Sub BtnSaveXml_Click(sender As Object, e As EventArgs) Handles BtnSaveXml.Click
        Try
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "XML Files (*.xml)|*.xml" ' Set filter to XML files
            saveDialog.Title = "Save System Information as XML"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                Dim xmlPath As String = saveDialog.FileName

                ' Check if the file already exists
                If System.IO.File.Exists(xmlPath) Then
                    Dim overwriteResult As DialogResult = MessageBox.Show("The file already exists. Do you want to overwrite it?", "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If overwriteResult = DialogResult.No Then
                        Return ' Exit if the user chooses not to overwrite
                    End If
                End If

                ' Get XML content from the TreeView
                ' We use TrvSystemInfo as that's where your system info is displayed
                Dim xmlContent As String = GetXmlStringFromTreeView(TrvSystemInfo)

                If Not String.IsNullOrEmpty(xmlContent) Then
                    ' Save XML content as XML file with line breaks for readability
                    System.IO.File.WriteAllText(xmlPath, FormatXml(xmlContent), System.Text.Encoding.UTF8)
                    MessageBox.Show("XML file saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("XML content is empty or invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("No file selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving the XML file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function FormatXml(xmlContent As String) As String
        Dim doc As New XmlDocument()
        Try
            doc.LoadXml(xmlContent)
        Catch ex As XmlException
            ' Handle case where xmlContent is not well-formed XML
            MessageBox.Show("The generated XML content is not valid XML and cannot be formatted. " & ex.Message, "XML Formatting Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return xmlContent ' Return original unformatted content or throw
        End Try

        Using stringWriter As New StringWriter()
            Using xmlWriter As XmlWriter = xmlWriter.Create(stringWriter, New XmlWriterSettings() With {.Indent = True, .NewLineOnAttributes = False, .OmitXmlDeclaration = False})
                doc.Save(xmlWriter)
                Return stringWriter.ToString()
            End Using
        End Using
    End Function

    ' This function iterates through the TreeView nodes and builds an XDocument.
    ' It assumes the first level node is the "rootNode" (e.g., "System Information")
    ' and subsequent nodes represent categories and their details (Name: Value).
    Private Function GetXmlStringFromTreeView(ByVal tv As TreeView) As String
        If tv Is Nothing OrElse tv.Nodes.Count = 0 Then
            Return ""
        End If

        Dim xmlDoc As New XDocument()
        ' Assuming the first node in TrvSystemInfo is the overall root (e.g., "System Information")
        ' We'll make the first node's text the root element name.
        Dim rootNodeText As String = SanitizeXmlName(tv.Nodes(0).Text)
        If String.IsNullOrWhiteSpace(rootNodeText) Then rootNodeText = "SystemInformation"

        Dim rootElement As New XElement(rootNodeText)

        ' Start processing from the children of the first node (e.g., "Operating System", "CPU", etc.)
        For Each topLevelNode As TreeNode In tv.Nodes(0).Nodes
            rootElement.Add(CreateXmlElementFromTreeNode(topLevelNode))
        Next

        xmlDoc.Add(rootElement)
        Return xmlDoc.ToString()
    End Function

    Private Function CreateXmlElementFromTreeNode(ByVal node As TreeNode) As XElement
        Dim elementName As String = SanitizeXmlName(node.Text)
        If String.IsNullOrWhiteSpace(elementName) Then
            elementName = "Node" ' Fallback for empty/invalid names
        End If

        Dim element As New XElement(elementName)

        ' If a node is a "category" node (like "Operating System", "CPU"), its children are properties.
        ' If a node is a "property" node (like "Name: Windows 10"), extract name and value.
        If node.Nodes.Count = 0 Then
            ' This is likely a leaf node containing "Key: Value"
            Dim parts() As String = node.Text.Split(New Char() {":"}, 2) ' Split by first colon only
            If parts.Length = 2 Then
                Dim key As String = SanitizeXmlName(parts(0).Trim())
                Dim value As String = parts(1).Trim()
                If Not String.IsNullOrWhiteSpace(key) Then
                    element.Name = key ' Use the key as the element name for properties
                    element.Value = value
                Else
                    element.Value = node.Text ' Fallback if key is empty
                End If
            Else
                ' If it's not "Key: Value" format, just use its text as content
                element.Value = node.Text
            End If
        Else
            ' This is a parent node (e.g., "Operating System", "GPU")
            ' Recursively add child elements
            For Each childNode As TreeNode In node.Nodes
                element.Add(CreateXmlElementFromTreeNode(childNode))
            Next
        End If

        Return element
    End Function

    ' Helper function to sanitize strings for XML element/attribute names
    Private Function SanitizeXmlName(ByVal input As String) As String
        If String.IsNullOrWhiteSpace(input) Then Return ""

        ' Remove invalid XML name characters (e.g., spaces, colons, hyphens are common)
        ' A more comprehensive regex might be needed for extremely varied input
        Dim sanitized As String = System.Text.RegularExpressions.Regex.Replace(input, "[^\w\.-]", "") ' Keep alphanumeric, underscore, dot, hyphen

        ' Ensure it starts with a letter or underscore (XML naming rule)
        If sanitized.Length > 0 AndAlso Not Char.IsLetter(sanitized(0)) AndAlso sanitized(0) <> "_" Then
            sanitized = "_" & sanitized
        End If

        ' Trim to a reasonable length if names can be very long
        If sanitized.Length > 64 Then sanitized = sanitized.Substring(0, 64)

        Return sanitized
    End Function
    Private Sub UpdateDate()
        Label1.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy") ' Update the date label
    End Sub

    Private Sub BtnTools_Click(sender As Object, e As EventArgs) Handles BtnTools.Click
        Form2.Show() ' Show the second form for Other tools
    End Sub


End Class