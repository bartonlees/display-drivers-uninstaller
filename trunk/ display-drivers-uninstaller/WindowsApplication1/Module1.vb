﻿Module Module1
    Public userpth As String = System.Environment.GetEnvironmentVariable("userprofile")
    Dim time As String = DateAndTime.Now
    Public location As String = Nothing
    Dim sysdrv As String = System.Environment.GetEnvironmentVariable("systemdrive")


    Public Sub log(ByVal value As String)
        If Form1.CheckBox2.Checked = True Then
            Dim wlog As New IO.StreamWriter(location, True)
            wlog.WriteLine(DateTime.Now & " >> " & value)
            wlog.Flush()
            wlog.Dispose()
            System.Threading.Thread.Sleep(50)  '50 millisecond stall (0.05 Seconds) just to be sure its really released.
        Else

        End If
    End Sub
    'It may be possible to clean up the time code to be a simple PM/AM system, by getting system time.
End Module
