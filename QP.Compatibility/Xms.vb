Option Explicit On
Option Strict On
Option Infer On

Namespace Global.QP

  Public NotInheritable Class Xms

    Private Sub New()
    End Sub

    Public Shared Function XMSError%()
      Return 0
    End Function

    Public Shared Function XMSLoaded%()
      Return 0
    End Function

    Public Shared Sub XMSAllocMem(numK%, handle%)

    End Sub

    Public Shared Sub XMSRelMem(handle%)

    End Sub

    Public Shared Sub Array2XMS(array() As Object, start%, elSize%, numEls%, handle%)

    End Sub

    Public Shared Sub Array2XMS(segment%, address%, numBytes%, dummy%, handle%)

    End Sub

    Public Shared Sub XMS2Array(array() As Object, start%, elSize%, numEls%, handle%)

    End Sub

    Public Shared Sub XMS2Array(segment%, address%, numBytes%, dummy%, handle%)

    End Sub

    Public Shared Sub XMSGet1El(value As Object, elSize%, elNum%, handle%)

    End Sub

    Public Shared Sub XMSSet1El(value As Object, elSize%, elNum%, handle%)

    End Sub

    Public Structure XMSInfoType
      Public XMSVersion As Integer
      Public DriverVersion As Integer
      Public NumHandles As Integer
      Public FreeMem As Integer
      Public Largest As Integer
      Public HMAAvail As Integer
      Public LargestUMB As Long
    End Structure

    Public Shared Sub XMSInfo(info As XMSInfoType)

    End Sub

    Public Shared Sub XMSSetError(value%)

    End Sub

    Public Shared Sub KeepXMSHandle(handle%)

    End Sub

    Public Shared Sub UMBAllocMem(numBytes%, segment%)

    End Sub

    Public Shared Sub UMPRelMem(segment%)

    End Sub

  End Class

End Namespace