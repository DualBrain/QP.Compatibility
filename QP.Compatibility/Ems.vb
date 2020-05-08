Option Explicit On
Option Strict On
Option Infer On

Namespace Global.QP

  Public NotInheritable Class Ems

    Private Sub New()
    End Sub

    Public Shared Function EmsError%()
      Return 0
    End Function

    Public Shared Function EmsLoaded%()
      Return 0
    End Function

    Public Shared Function EmsNumPages%(handle%)
      Return 0
    End Function

    Public Shared Function EmsPageCount%()
      Return 0
    End Function

    Public Shared Function EmsPagesFree%()
      Return 0
    End Function

    Public Shared Function EmsVersion%()
      Return 0
    End Function

    Public Shared Sub Array2Ems(array() As Long, start%, elSize%, numEls%, handle%)

    End Sub

    Public Shared Sub Array2Ems(array() As Integer, start%, elSize%, numEls%, handle%)

    End Sub

    Public Shared Sub Array2Ems(array() As Object, start%, elSize%, numEls%, handle%)

    End Sub

    Public Shared Sub Array2Ems(segment%, address%, numBytes%, dumm%, handle%)

    End Sub

    Public Shared Sub Ems2Array(array() As Long, start%, elSize%, numEls%, handle%)

    End Sub

    Public Shared Sub Ems2Array(array() As Integer, start%, elSize%, numEls%, handle%)

    End Sub

    Public Shared Sub Ems2Array(array() As Object, start%, elSize%, numEls%, handle%)

    End Sub

    Public Shared Sub Ems2Array(segment%, address%, numBytes%, dummy%, handle%)

    End Sub

    Public Shared Sub EmsGet1El(value As Object, elSize%, elNum%, handle%)

    End Sub

    Public Shared Sub EmsRelMem(handle%)

    End Sub

    Public Shared Sub EmsSetError(value%)

    End Sub

    Public Shared Sub EmsSetPage(page%, handle%)

    End Sub

    Public Shared Sub EmsSet1El(value As Object, elSize%, elNum%, handle%)

    End Sub

  End Class

End Namespace