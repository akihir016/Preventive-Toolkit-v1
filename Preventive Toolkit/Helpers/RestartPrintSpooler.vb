Imports System.ServiceProcess
Imports System.Windows.Forms

Module RestartPrintSpooler
    Public Sub RestartPrintSpooler()
        Try
            ' Create a ServiceController instance for the Print Spooler service
            Dim spoolerService As New ServiceController("Spooler")

            ' Check if the service is running
            If spoolerService.Status = ServiceControllerStatus.Running Then
                ' MessageBox.Show("Stopping the Print Spooler service...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                spoolerService.Stop()
                spoolerService.WaitForStatus(ServiceControllerStatus.Stopped)
                ' MessageBox.Show("Print Spooler service stopped.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' Start the service
            ' MessageBox.Show("Starting the Print Spooler service...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            spoolerService.Start()
            spoolerService.WaitForStatus(ServiceControllerStatus.Running)
            MessageBox.Show("Print Spooler service restarted successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module