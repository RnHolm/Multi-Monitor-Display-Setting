Public Class Form1
    'need to use process.start to run command prompt (might help?)
    Private Sub ButtonExt_Click(sender As Object, e As EventArgs) Handles ButtonExt.Click
        'changes the display to extend 
        'Switches to "Extend" Display Immediately: %windir%\System32\DisplaySwitch.exe /extend
        Process.Start("DisplaySwitch", "/extend")
        MsgBox("the screen has extended")


    End Sub

    Private Sub ButtonDup_Click(sender As Object, e As EventArgs) Handles ButtonDup.Click
        'changes the display to duplicate 
        'Switches to "Duplicate" Display Immediately: %windir%\System32\DisplaySwitch.exe /clone
        Process.Start("DisplaySwitch", "/clone")
        MsgBox("the screen has extended")
    End Sub

    Private Sub ButtonTest_Click(sender As Object, e As EventArgs) Handles ButtonTest.Click
        'Process.Start("ping", "google.com")
        'MsgBox("test worked")
        Dim psi As New ProcessStartInfo() ' Initialize ProcessStartInfo (psi)
        psi.Verb = "runas" ' runas = Run As Administrator
        psi.FileName = "cmd.exe" ' File or exe to run (this cannot take arguments, use ProcessStartInfo.Arguments instead
        psi.Arguments = "/c " ' Arguments for the process that you're going to run
        Try
            Process.Start(psi) ' Run the process (User is required to press Yes to run the program with Administrator access)
        Catch
            MsgBox("User cancelled the operation", 16, "") ' User pressed No
        End Try
    End Sub
End Class
