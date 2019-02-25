Public Class Form1
    'need to use process.start to run command prompt (might help?)
    Private Sub ButtonExt_Click(sender As Object, e As EventArgs) Handles ButtonExt.Click
        'changes the display to extend 
        'Switches to "Extend" Display Immediately: %windir%\System32\DisplaySwitch.exe /extend
    End Sub

    Private Sub ButtonDup_Click(sender As Object, e As EventArgs) Handles ButtonDup.Click
        'changes the display to duplicate 
        'Switches to "Duplicate" Display Immediately: %windir%\System32\DisplaySwitch.exe /clone
    End Sub
End Class
