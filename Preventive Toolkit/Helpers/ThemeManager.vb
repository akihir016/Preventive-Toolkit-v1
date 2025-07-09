Imports System.Windows.Forms
Imports System.Drawing

Imports System.Configuration

Public Class ThemeManager
    Public Property IsNightMode As Boolean = False

    Public Sub New()
        LoadThemePreference()
    End Sub

    Private Sub LoadThemePreference()
        Try
            IsNightMode = My.Settings.LastThemeIsNightMode
        Catch ex As Configuration.SettingsPropertyNotFoundException
            ' Setting doesn't exist, default to false (Day Mode)
            IsNightMode = False
            ' Optionally, save the default setting now
            SaveThemePreference()
        Catch ex As Exception
            ' Handle other potential errors (e.g., file corruption)
            System.Diagnostics.Debug.WriteLine("Error loading theme preference: " & ex.Message)
            IsNightMode = False ' Default to Day Mode on error
        End Try
    End Sub

    Public Sub SaveThemePreference()
        Try
            My.Settings.LastThemeIsNightMode = IsNightMode
            My.Settings.Save()
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error saving theme preference: " & ex.Message)
        End Try
    End Sub

    Public Sub ApplyTheme(form As Form)
        If IsNightMode Then
            ' Night Mode Colors
            form.BackColor = Color.FromArgb(45, 45, 48) ' Dark background
            form.ForeColor = Color.White ' Light text
            If TypeOf form.MainMenuStrip Is MenuStrip Then
                form.MainMenuStrip.BackColor = Color.FromArgb(30, 30, 30)
                form.MainMenuStrip.ForeColor = Color.White
            End If

            ' Apply to all controls on the form
            For Each ctrl As Control In form.Controls
                SetControlTheme(ctrl, True)
            Next
        Else
            ' Day Mode Colors (default)
            form.BackColor = SystemColors.Control ' Standard Windows background
            form.ForeColor = SystemColors.ControlText ' Standard Windows text
            If TypeOf form.MainMenuStrip Is MenuStrip Then
                form.MainMenuStrip.BackColor = SystemColors.MenuBar
                form.MainMenuStrip.ForeColor = SystemColors.ControlText
            End If

            ' Apply to all controls on the form
            For Each ctrl As Control In form.Controls
                SetControlTheme(ctrl, False)
            Next
        End If
    End Sub

    Public Sub SetControlTheme(ctrl As Control, isNight As Boolean)
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
            ElseIf TypeOf ctrl Is MenuStrip Then
                Dim ms As MenuStrip = CType(ctrl, MenuStrip)
                ms.BackColor = Color.FromArgb(30, 30, 30)
                ms.ForeColor = Color.White
                For Each item As ToolStripMenuItem In ms.Items
                    SetToolStripItemTheme(item, True)
                Next
            ElseIf TypeOf ctrl Is Label Then
                ' Ensure labels inherit background color correctly
                ctrl.BackColor = Color.Transparent
            End If
        Else
            ' Apply day mode colors
            ctrl.BackColor = SystemColors.Control
            ctrl.ForeColor = SystemColors.ControlText

            If TypeOf ctrl Is Button Then
                Dim btn As Button = CType(ctrl, Button)
                btn.FlatStyle = FlatStyle.Standard
                btn.FlatAppearance.BorderColor = SystemColors.ControlDark
                btn.FlatAppearance.BorderSize = 0 ' Or 1 if you prefer a border in day mode too
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
            ElseIf TypeOf ctrl Is MenuStrip Then
                Dim ms As MenuStrip = CType(ctrl, MenuStrip)
                ms.BackColor = SystemColors.MenuBar
                ms.ForeColor = SystemColors.ControlText
                For Each item As ToolStripMenuItem In ms.Items
                    SetToolStripItemTheme(item, False)
                Next
            ElseIf TypeOf ctrl Is Label Then
                ctrl.BackColor = Color.Transparent
            End If
        End If

        ' Recursively apply theme to child controls
        For Each childCtrl As Control In ctrl.Controls
            SetControlTheme(childCtrl, isNight)
        Next
    End Sub

    Private Sub SetToolStripItemTheme(item As ToolStripMenuItem, isNight As Boolean)
        If isNight Then
            item.ForeColor = Color.White
            item.BackColor = Color.FromArgb(30, 30, 30) ' Match MenuStrip background
            For Each dropDownItem As ToolStripDropDownItem In item.DropDownItems
                SetToolStripItemTheme(dropDownItem, True)
            Next
        Else
            item.ForeColor = SystemColors.ControlText
            item.BackColor = SystemColors.MenuBar ' Match MenuStrip background
             For Each dropDownItem As ToolStripDropDownItem In item.DropDownItems
                SetToolStripItemTheme(dropDownItem, False)
            Next
        End If
    End Sub

End Class
