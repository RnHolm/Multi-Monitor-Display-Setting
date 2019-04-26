Public Class Form1
    'need to use process.start to run command prompt (might help?)
    Private Sub ButtonExt_Click(sender As Object, e As EventArgs) Handles ButtonExt.Click
        'Switches to "Extend" Display Immediately
        Process.Start("C:\Windows\SysNative\DisplaySwitch.exe", "/extend")
        'confirmation message
        MsgBox("the screen has extended")
    End Sub

    Private Sub ButtonDup_Click(sender As Object, e As EventArgs) Handles ButtonDup.Click
        'Switches to "Duplicate" Display Immediately
        Process.Start("C:\Windows\SysNative\DisplaySwitch.exe", "/clone")
        'confirmation message
        MsgBox("the screen has Duplicated")
    End Sub

End Class
