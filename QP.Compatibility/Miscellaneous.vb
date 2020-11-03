Option Explicit On
Option Strict On
Option Infer On

Imports QB.Core

Imports QP.Video

Namespace Global.QP

  Public NotInheritable Class Miscellaneous

#Disable Warning CA1034 ' Nested types should not be visible
#Disable Warning CA1815 ' Override equals and operator equals on value types

    Public Structure FVInfo
      Public Colr As Integer
      Public ULRow As Integer
      Public ULCol As Integer
      Public LRRow As Integer
      Public LRCol As Integer
      Public HorizOffset As Integer
      Public LoPtr As Integer
      Public FileHandle As Integer
      Public EndOfFile As Integer
      Public LineNumber As Long
      Public TabStop As Integer
      Public FileSeek As Long
      Public FileOffset As Long
    End Structure

#Enable Warning CA1815 ' Override equals and operator equals on value types
#Enable Warning CA1034 ' Nested types should not be visible

    Private Sub New()
    End Sub

    'Public Shared Function AddUSI%(x%, y%)
    '  Return 0
    'End Function

    'Public Shared Sub BCopy(fromSeg%, fromAddr%, toSeg%, toAddr%, numBytes%, direction%)

    'End Sub

    'Public Shared Sub BCopyT(fromEl As Object, toEl As Object, elSize%, numEls%)

    'End Sub

    'Public Shared Sub BCopyT(fromSeg%, fromAdr%, toSeg%, toAdr%, numBytes%, dummy%)

    'End Sub

    'Public Shared Sub BLPrint(lptNumber%, x$, errCount%)

    'End Sub

    'Public Shared Sub Chime(number%)

    '  ' Chime provides five different types of beep tones, and five short attention-getting trill sounds. 

    '  ' Call Chime(Number%)

    '  ' Number% Is between 1 And 10

    'End Sub

    Public Shared Sub Clock(row%, col%, colr%, mode%)

      Static t As Timers.Timer
      Static r%, c%, co%

      If mode% = 1 Then
        If t Is Nothing Then
          t = New Timers.Timer(250)
          r = row%
          c = col%
          co% = colr%
          AddHandler t.Elapsed, Sub() QPrintRC(Now.ToLongTimeString(), r%, c%, co%)
          t.Enabled = True
        End If
      Else
        If t IsNot Nothing Then
          t.Enabled = False
          t = Nothing
        End If
      End If

    End Sub

    'Public Shared Sub Clock24(row%, column%, colr%, mode%)

    'End Sub

    'Public Shared Function Compare%(seg1%, adr%, seg2%, adr2%, numBytes%)
    '  Return 0
    'End Function

    'Public Shared Function CompareT%(type1 As Object, type2 As Object, numBytes%)
    '  Return 0
    'End Function

    'Public Shared Function Date2Day%(d$)
    '  Return 0
    'End Function

    Public Shared Function Date2Num%(value As Date?)
      If value Is Nothing Then
        Return -32768
      Else
        If CDate(value) >= #1/1/1900# AndAlso CDate(value) <= #11/17/2065# Then
          Return CInt(DateDiff(DateInterval.Day, New Date(1979, 12, 31), CDate(value)))
        Else
          Return -32768
        End If
      End If
    End Function

    Public Shared Function Date2Num%(value$)
      If String.IsNullOrWhiteSpace(value$) OrElse
         value$ = "  /  /  " OrElse
         value$ = "T F N" OrElse
         value$?.StartsWith(Chr(0)) Then
        Return -32768
      End If
      Dim pivot = New Date(1979, 12, 31)
      Dim d As Date
      'Try
      If value?.Length = 6 Then
        value = $"{value.Substring(0, 2)}/{value.Substring(2, 2)}/{value.Substring(4, 2)}"
      ElseIf value?.Length = 8 Then
        value = $"{value.Substring(0, 2)}/{value.Substring(3, 2)}/{value.Substring(6, 2)}"
      End If
      Try
        d = CDate(value)
      Catch ex As InvalidCastException
        Return -32768
      End Try
      If d >= #1/1/1900# AndAlso d <= #11/17/2065# Then
        Return CInt(DateDiff(DateInterval.Day, pivot, d))
      Else
        Return -32768
      End If
    End Function

    Public Shared Function DayName$(day%)
      Select Case day%
        Case 1 : Return "Mon"
        Case 2 : Return "Tue"
        Case 3 : Return "Wed"
        Case 4 : Return "Thu"
        Case 5 : Return "Fri"
        Case 6 : Return "Sat"
        Case 7 : Return "Sun"
      End Select
      Return Nothing
    End Function

    'Public Shared Function EDate2Num%(dat$)
    '  Return 0
    'End Function

    'Public Shared Sub Empty(variable As Object)

    'End Sub

    'Public Shared Function ENum2Date$(day%)
    '  Return Nothing
    'End Function

    'Public Shared Sub Extended()

    'End Sub

    'Public Shared Function Factorial#(number%)
    '  Return 0
    'End Function

    'Public Shared Sub FileView(filename$, ky%, action%, info As FVInfo, buffer%())

    'End Sub

    'Public Shared Function FudgeFactor&()
    '  Return 0
    'End Function

    Public Shared Function GetCPU%()
      Return 486
    End Function

    'Public Shared Function GetDS%()
    '  Return 0
    'End Function

    Public Shared Sub GetEquip(ByRef floppies%, ByRef parallels%, ByRef serials%)

      'GetEquip returns several items from the equipment list kept in the low-memory area of a PC. 
      floppies = 1
      parallels = 0
      serials = 0

    End Sub

    'Public Shared Sub Lockup()

    'End Sub

    'Public Shared Function MathChip%()
    '  Return 0
    'End Function

    'Public Shared Function MaxInt%(value1%, value2%)
    '  Return 0
    'End Function

    'Public Shared Function MaxLong&(value1&, value2&)
    '  Return 0
    'End Function

    'Public Shared Function MinInt%(value1%, value2%)
    '  Return 0
    'End Function

    'Public Shared Function MinLong&(value1&, value2&)
    '  Return 0
    'End Function

    Public Shared Function MonthName$(month%)
      Select Case month%
        Case 1 : Return "Jan"
        Case 2 : Return "Feb"
        Case 3 : Return "Mar"
        Case 4 : Return "Apr"
        Case 5 : Return "May"
        Case 6 : Return "Jun"
        Case 7 : Return "Jul"
        Case 8 : Return "Aug"
        Case 9 : Return "Sep"
        Case 10 : Return "Oct"
        Case 11 : Return "Nov"
        Case 12 : Return "Dec"
      End Select
      Return Nothing
    End Function

    Public Shared Function Num2Date$(day As Long)
      Return DateAdd(DateInterval.Day, day, New Date(1979, 12, 31)).ToString("MM-dd-yyyy")
    End Function

    Public Shared Function Num2Day%(d As Long)
      Dim value = CDate(Num2Date(d))
      Return If(value.DayOfWeek = 0, 7, value.DayOfWeek)
    End Function

    Public Shared Function Num2Time$(time%)
      Dim z = New TimeSpan(0, 0, time%)
      Return z.ToString
    End Function

    Public Shared Sub Pause(ticks%)
      Dim dv = 1 / 18 'NOTE: ticks represents 1/18th of a second.
      Dim ms = CInt(1000 * (ticks * dv))
      Threading.Thread.Sleep(ms)
    End Sub

    'Public Shared Sub Pause2(microseconds%)

    'End Sub

    'Public Shared Sub Pause3(milliseconds%, fudge&)

    'End Sub

    Public Shared Function PDQTimer&()
      Return CLng(QBTimer())
    End Function

    'Public Shared Function Peek1%(segment%, address%)
    '  Return 0
    'End Function

    'Public Shared Function Peek2%(segment%, address%)
    '  Return 0
    'End Function

    'Public Shared Sub Poke1(segment%, address%, byte%)

    'End Sub

    'Public Shared Sub Poke2(segment%, address%, work%)

    'End Sub

    'Public Shared Function Power%(y%, n%)
    '  Return 0
    'End Function

    'Public Shared Function Power2%(n%)
    '  Return 0
    'End Function

    Public Shared Function PRNReady%(lptNumber%)
      Select Case lptNumber
        Case 1, 2, 3
          Return 0
        Case Else
          Return 0
      End Select
    End Function

    'Public Shared Sub PSwap()

    'End Sub

    Public Shared Sub QPCli()
      ' This method, literally, has no meaning on Windows (to the best of my knowledge).
    End Sub

    Public Shared Sub QPSti()
      ' This method, literally, has no meaning on Windows (to the best of my knowledge).
    End Sub

    'Public Shared Sub QPPlay(Tune$)

    'End Sub

    'Public Shared Sub QPSound(frequency%, duration%)

    'End Sub

    'Public Shared Function QPSegAdr&(any$)
    '  Return 0
    'End Function

    'Public Shared Function QPSSeg%(any$)
    '  Return 0
    'End Function

    'Public Shared Function QPUSI%(longInt&)
    '  Return 0
    'End Function

    Public Shared Sub Reboot()
      Dim psi = New System.Diagnostics.ProcessStartInfo("shutdown", "/r /t 0") With {
      .RedirectStandardInput = True,
      .RedirectStandardOutput = True,
      .RedirectStandardError = True,
      .UseShellExecute = False,
      .CreateNoWindow = True,
      .WindowStyle = Diagnostics.ProcessWindowStyle.Hidden}
      Dim console = Process.Start(psi)
    End Sub

    'Public Shared Sub ShiftIL(intVar%, numBits%)

    'End Sub

    'Public Shared Sub ShiftIR(intVar%, numBits%)

    'End Sub

    'Public Shared Sub ShiftLL(longInt&, numBits%)

    'End Sub

    'Public Shared Sub ShiftLR(longInt&, numBits%)

    'End Sub

    'Public Shared Function Soundex$(word$)
    '  Return Nothing
    'End Function

#Region "String Manager"

    'Public Shared Function FindLastSM&(array%(), numBytes%)
    '  Return 0
    'End Function

    'Public Shared Sub Get1Str(work$, array%(), stringNumber%)

    'End Sub

    'Public Shared Function Get1String$(array$(), stringNumber%)
    '  Return Nothing
    'End Function

    'Public Shared Function GetNext%(segment%, thisAddress%, lastAddress%)
    '  Return 0
    'End Function

    'Public Shared Sub MidStrSave(array$(), first%, numEls%, firstChar%, numChar%, storage%())

    'End Sub

    'Public Shared Sub MidStrRest(buffer$, strNumber%, storage%())

    'End Sub

    'Public Shared Function NumStrings%(array%, numBytes%)
    '  Return 0
    'End Function

    'Public Shared Sub StringRest(array$(), a%(), numStrings%)

    'End Sub

    'Public Shared Sub StringRestore(array$(), a%())

    'End Sub

    'Public Shared Sub StringSave(array$(), a%(), numStrings%)

    'End Sub

    'Public Shared Function StringSize&(array$(), start%, numStringEls%)
    '  Return 0
    'End Function

    'Public Shared Function StrLength%(array%(), numBytes%, stringNumber%)
    '  Return 0
    'End Function

    'Public Shared Sub Sub1String(new$, array%(), numBytes%, strNumber%)

    'End Sub

#End Region

    Public Shared Sub SysTime(ByRef t$)
      t$ = $"{Now:HH:mm:ss:ff}"
    End Sub

    Public Shared Function Time2Num%(value As Date?)
      If value Is Nothing Then
        Return 0
      Else
        Dim d = New Date(1, 1, 1, CDate(value).Hour, CDate(value).Minute, CDate(value).Second)
        Return CInt(DateDiff(DateInterval.Second, Date.MinValue, d))
      End If
    End Function

    Public Shared Function Time2Num%(t$)
      Dim d = CDate(t$)
      Return CInt(DateDiff(DateInterval.Second, Date.MinValue, d))
    End Function

    'Public Shared Function Times2%(number%)
    '  Return 0
    'End Function

    'Public Shared Function TrapInt%(value%, loLimit%, highLimit%)
    '  Return 0
    'End Function

    'Public Shared Sub VLAdd(value1#, value2#, sum#, errFlag%)

    'End Sub

    'Public Shared Sub VLDiv(dividend#, divisor#, quotient#, remainder#, errFlag%)

    'End Sub

    'Public Shared Sub VLMul(value1#, value2#, product#, errFlag%)

    'End Sub

    'Public Shared Sub VLPack(number$, value#, errFlag%)

    'End Sub

    'Public Shared Sub VLSub(value1#, value2#, difference#, errFlag%)

    'End Sub

    'Public Shared Sub VLUnpack(alias#, number$, errFlag%)

    'End Sub

    'Public Shared Function WeekDay%(d$)
    '  Return 0
    'End Function

    'Public Shared Sub WordWrap(message$, wide%)

    'End Sub

  End Class

End Namespace