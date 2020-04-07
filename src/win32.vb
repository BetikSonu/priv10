Imports System.Runtime.InteropServices

Public Class win32
    <DllImport("kernel32.dll")> Public Shared Function AllocConsole() As Boolean ' Start The Console

    End Function
    <DllImport("kernel32.dll")> Public Shared Function FreeConsole() As Boolean ' Stop The Console

    End Function

End Class
