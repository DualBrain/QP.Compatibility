Option Explicit On
Option Strict On
Option Infer On

Namespace QP

  Public NotInheritable Class KeyboardMouse

    Private Sub New()
    End Sub

    Public Shared Function AltKey%()
      Return 0
    End Function

    Public Shared Sub ButtonPress(button%, status%, count%, x%, y%)

    End Sub

    Public Shared Function CapsLock%()
      Return 0
    End Function

    Public Shared Sub CapsOff()

    End Sub

    Public Shared Sub CapsOn()

    End Sub

    Public Shared Sub ClearBuf()

    End Sub

    Public Shared Function CtrlKey%()
      Return 0
    End Function

    Public Shared Sub GetCursor(x%, y%, button%)

    End Sub

    Public Shared Sub GetCursorT(col%, row%, button%)

    End Sub

    Public Shared Sub GrafCursor(x%, y%, cursor$)

    End Sub

    Public Shared Sub HideCursor()

    End Sub

    Public Shared Sub InitMouse(there%)

    End Sub

    Public Shared Function InStat%()
      Return 0
    End Function

    Public Shared Sub Keyboard(row%, column%, color1%, color2%, mode%)

    End Sub

    Public Shared Function KeyDown%()
      Return 0
    End Function

    Public Shared Sub Motion(value%)

    End Sub

    Public Shared Sub Mouse(ax%, bx%, cx%, dx%)

    End Sub

    Public Structure Area
      Public ULRow As Integer
      Public ULCol As Integer
      Public LRRow As Integer
      Public LRCol As Integer
      Public [Alias] As Integer
    End Structure

    Public Shared Sub MouseRange(array() As Area, start%, numEls%, row%, col%, button%, rangeNum%)

    End Sub

    Public Shared Sub MouseRange1(array() As Area, start%, numEls%, row%, col%, button%, rangeNum%)

    End Sub

    Public Shared Sub MouseRangeG(array() As Area, start%, numEls%, row%, col%, button%, rangeNum%)

    End Sub

    Public Shared Sub MouseRangeG1(array() As Area, start%, numEls%, row%, col%, button%, rangeNum%)

    End Sub

    Public Shared Sub MouseState(buffer$)

    End Sub

    Public Shared Sub MouseTrap(ulRow%, ulCol%, lrRow%, lrCol%)

    End Sub

    Public Shared Function NumLock%()
      Return 0
    End Function

    Public Shared Sub NumOff()

    End Sub

    Public Shared Sub NumOn()

    End Sub

    Public Shared Function PeekBuf%()
      Return 0
    End Function

    Public Shared Sub RptKey(char%, count%)

    End Sub

    Public Shared Function ScrlLock%()
      Return 0
    End Function

    Public Shared Sub SetCursor(x%, y%)

    End Sub

    Public Shared Function ShiftKey%()
      Return 0
    End Function

    Public Shared Sub ShowCursor()

    End Sub

    Public Shared Sub StuffBuf(x$)

    End Sub

    Public Shared Sub TextCursor(FG%, BG%)

    End Sub

    Public Shared Function WaitKey%()
      Return 0
    End Function

    Public Shared Function WaitScan%()
      Return 0
    End Function

    Public Shared Sub WaitUp()

    End Sub

  End Class

End Namespace