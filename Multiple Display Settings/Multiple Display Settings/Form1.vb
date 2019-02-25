Public Class Form1
    'need to use process.start to run command prompt (might help?)
    Private Sub ButtonExt_Click(sender As Object, e As EventArgs) Handles ButtonExt.Click
        'Switches to "Extend" Display Immediately
        Process.Start("C:\Windows\WinSxS\amd64_microsoft-windows-displayswitch_31bf3856ad364e35_10.0.15063.0_none_fdd58a325d4a2de2\DisplaySwitch.exe", "/extend")
        'confirmation message
        MsgBox("the screen has extended")
    End Sub

    Private Sub ButtonDup_Click(sender As Object, e As EventArgs) Handles ButtonDup.Click
        'Switches to "Duplicate" Display Immediately
        Process.Start("C:\Windows\WinSxS\amd64_microsoft-windows-displayswitch_31bf3856ad364e35_10.0.15063.0_none_fdd58a325d4a2de2\DisplaySwitch.exe", "/clone")
        'confirmation message
        MsgBox("the screen has Duplicated")
    End Sub

End Class
