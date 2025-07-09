Imports System.Windows.Forms
Imports System.ServiceProcess
Imports System.Diagnostics
Imports System.Security.Principal
Imports Preventive_Toolkit.Helpers

Public Class Form2
    Private themeManager As New ThemeManager()

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        themeManager.ApplyTheme(Me)
    End Sub

    Private Sub ToggleNightModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToggleNightModeToolStripMenuItem.Click
        themeManager.IsNightMode = Not themeManager.IsNightMode
        themeManager.ApplyTheme(Me)
        ' Save the new preference
        themeManager.SaveThemePreference()
    End Sub

    '---- Button to generate battery report for laptops ----
    Private Sub btnBatteryReport_Click(sender As Object, e As EventArgs) Handles btnBatteryReport.Click
        Dim generator As New BatteryReportGenerator
        generator.GenerateReport()
    End Sub

    '---- Button to Launch Windows Maintenance tools ----
    Private Sub btnWinTools_Click(sender As Object, e As EventArgs) Handles btnWinTools.Click
        Try
            ' Launch Windows Tools (Administrative Tools)
            Process.Start("explorer.exe", "shell:::{D20EA4E1-3957-11d2-A40B-0C5020524153}")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '---- Button to launch Windows Troubleshooting tools ----
    Private Sub btnTroubleshoot_Click(sender As Object, e As EventArgs) Handles btnTroubleshoot.Click
        Try
            ' Launch Windows Tools (Administrative Tools)
            Process.Start("explorer.exe", "shell:::{C58C4893-3BE0-4B45-ABB5-A63E4B8C8651}")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '--- Button to launch Windows Security and Maintenance tools ----
    Private Sub btnSecMain_Click(sender As Object, e As EventArgs) Handles btnSecMain.Click
        Try
            ' Launch Windows Tools (Administrative Tools)
            Process.Start("explorer.exe", "shell:::{BB64F8A7-BEE7-4E1A-AB8D-7D8273F7FDB6}")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '--- Button to restart the Print Spooler service ----
    Private Sub btnSpooler_Click(sender As Object, e As EventArgs) Handles btnSpooler.Click
        RestartPrintSpooler.RestartPrintSpooler()
    End Sub

    '--- Button to launch Power Options settings ----
    Private Sub btnPowerOpt_Click(sender As Object, e As EventArgs) Handles btnPowerOpt.Click
        Try
            ' Launch Windows Tools (Administrative Tools)
            Process.Start("explorer.exe", "shell:::{025A5937-A6BE-4686-A844-36FE4BEC8B6D}")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '--- Button to launch User Accounts settings ----
    Private Sub btnUserAcc_Click(sender As Object, e As EventArgs) Handles btnUserAcc.Click
        Try
            ' Launch Windows Tools (Administrative Tools)
            Process.Start("explorer.exe", "shell:::{7A9D77BD-5403-11d2-8785-2E0420524153}")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class