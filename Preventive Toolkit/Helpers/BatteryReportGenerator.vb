Imports System.Diagnostics
Imports System.IO

Public Class BatteryReportGenerator
    ' Method to generate the battery report
    Public Sub GenerateReport()
        ' Define the folder path
        Dim folderPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Battery-Report")

        ' Check if the folder exists, if not, create it
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If

        ' Get the computer name and define the file path for the battery report
        Dim computerName As String = Environment.MachineName
        Dim reportFileName As String = $"{computerName}_battery_report.html"
        Dim reportFilePath As String = Path.Combine(folderPath, reportFileName)

        ' Create the process to run the powercfg command
        Dim process As New Process()
        process.StartInfo.FileName = "cmd.exe"
        process.StartInfo.Arguments = $"/c powercfg /batteryreport /output ""{reportFilePath}"""
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.RedirectStandardError = True
        process.StartInfo.CreateNoWindow = True

        Try
            ' Start the process
            process.Start()
            process.WaitForExit()

            ' Inform the user and provide an option to open the containing folder
            Dim result As DialogResult = MessageBox.Show("Battery report generated successfully at: " & reportFilePath & vbCrLf & "Do you want to open the containing folder?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            ' Open the containing folder if the user clicks Yes
            If result = DialogResult.Yes Then
                Process.Start("explorer.exe", folderPath)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class