Option Explicit On
Option Strict On
Option Infer On

Namespace QP

  Public NotInheritable Class Miscellaneous

    Private Sub New()
    End Sub

    Public Shared Function AddUSI%(x%, y%)
      Return 0
    End Function

    Public Shared Sub BCopy(fromSeg%, fromAddr%, toSeg%, toAddr%, numBytes%, direction%)

    End Sub

    Public Shared Sub BCopyT(fromEl As Object, toEl As Object, elSize%, numEls%)

    End Sub

    Public Shared Sub BCopyT(fromSeg%, fromAdr%, toSeg%, toAdr%, numBytes%, dummy%)

    End Sub

    Public Shared Sub BLPrint(lptNumber%, x$, errCount%)

    End Sub

    Public Shared Sub Chime(number%)

    End Sub

    Public Shared Sub Clock(row%, column%, colr%, mode%)

    End Sub

    Public Shared Sub Clock24(row%, column%, colr%, mode%)

    End Sub

    Public Shared Function Compare%(seg1%, adr%, seg2%, adr2%, numBytes%)
      Return 0
    End Function

    Public Shared Function CompareT%(type1 As Object, type2 As Object, numBytes%)
      Return 0
    End Function

    Public Shared Function Date2Day%(d$)
      Return 0
    End Function

    Public Shared Function Date2Num%(d$)
      Return 0
    End Function

    Public Shared Function DayName$(day%)
      Return Nothing
    End Function

    Public Shared Function EDate2Num%(dat$)
      Return 0
    End Function

    Public Shared Sub Empty(variable As Object)

    End Sub

    Public Shared Function ENum2Date$(day%)
      Return Nothing
    End Function

    Public Shared Sub Extended()

    End Sub

    Public Shared Function Factorial#(number%)
      Return 0
    End Function

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


    Public Shared Sub FileView(filename$, ky%, action%, info As FVInfo, buffer%())

    End Sub

    Public Shared Function FudgeFactor&()
      Return 0
    End Function

    Public Shared Function GetCPU%()
      Return 0
    End Function

    Public Shared Function GetDS%()
      Return 0
    End Function

    Public Shared Sub GetEquip(floppies%, parallels%, serials%)

    End Sub

    Public Shared Sub Lockup()

    End Sub

    Public Shared Function MathChip%()
      Return 0
    End Function

    Public Shared Function MaxInt%(value1%, value2%)
      Return 0
    End Function

    Public Shared Function MaxLong&(value1&, value2&)
      Return 0
    End Function

    Public Shared Function MinInt%(value1%, value2%)
      Return 0
    End Function

    Public Shared Function MinLong&(value1&, value2&)
      Return 0
    End Function

    Public Shared Function MonthName$(month%)
      Return Nothing
    End Function

    Public Shared Function Num2Date$(day%)
      Return Nothing
    End Function

    Public Shared Function Num2Day%(d%)
      Return 0
    End Function

    Public Shared Function Num2Time$(time&)
      Return Nothing
    End Function

    Public Shared Sub Pause(ticks%)

    End Sub

    Public Shared Sub Pause2(microseconds%)

    End Sub

    Public Shared Sub Pause3(milliseconds%, fudge&)

    End Sub

    Public Shared Function PDQTimer&()
      Return 0
    End Function

    Public Shared Function Peek1%(segment%, address%)
      Return 0
    End Function

    Public Shared Function Peek2%(segment%, address%)
      Return 0
    End Function

    Public Shared Sub Poke1(segment%, address%, byte%)

    End Sub

    Public Shared Sub Poke2(segment%, address%, work%)

    End Sub

    Public Shared Function Power%(y%, n%)
      Return 0
    End Function

    Public Shared Function Power2%(n%)
      Return 0
    End Function

    Public Shared Function PRNReady%(lptNumber%)
      Return 0
    End Function

    Public Shared Sub PSwap()

    End Sub

    Public Shared Sub QPCli()

    End Sub

    Public Shared Sub QPSti()

    End Sub

    Public Shared Sub QPPlay(Tune$)

    End Sub

    Public Shared Sub QPSound(frequency%, duration%)

    End Sub

    Public Shared Function QPSegAdr&(any$)
      Return 0
    End Function

    Public Shared Function QPSSeg%(any$)
      Return 0
    End Function

    Public Shared Function QPUSI%(longInt&)
      Return 0
    End Function

    Public Shared Sub Reboot()

    End Sub

    Public Shared Sub ShiftIL(intVar%, numBits%)

    End Sub

    Public Shared Sub ShiftIR(intVar%, numBits%)

    End Sub

    Public Shared Sub ShiftLL(longInt&, numBits%)

    End Sub

    Public Shared Sub ShiftLR(longInt&, numBits%)

    End Sub

    Public Shared Function Soundex$(word$)
      Return Nothing
    End Function

#Region "String Manager"

    Public Shared Function FindLastSM&(array%(), numBytes%)
      Return 0
    End Function

    Public Shared Sub Get1Str(work$, array%(), stringNumber%)

    End Sub

    Public Shared Function Get1String$(array$(), stringNumber%)
      Return Nothing
    End Function

    Public Shared Function GetNext%(segment%, thisAddress%, lastAddress%)
      Return 0
    End Function

    Public Shared Sub MidStrSave(array$(), first%, numEls%, firstChar%, numChar%, storage%())

    End Sub

    Public Shared Sub MidStrRest(buffer$, strNumber%, storage%())

    End Sub

    Public Shared Function NumStrings%(array%, numBytes%)
      Return 0
    End Function

    Public Shared Sub StringRest(array$(), a%(), numStrings%)

    End Sub

    Public Shared Sub StringRestore(array$(), a%())

    End Sub

    Public Shared Sub StringSave(array$(), a%(), numStrings%)

    End Sub

    Public Shared Function StringSize&(array$(), start%, numStringEls%)
      Return 0
    End Function

    Public Shared Function StrLength%(array%(), numBytes%, stringNumber%)
      Return 0
    End Function

    Public Shared Sub Sub1String(new$, array%(), numBytes%, strNumber%)

    End Sub

#End Region

    Public Shared Sub SysTime(t$)

    End Sub

    Public Shared Function Time2Num&(t$)
      Return 0
    End Function

    Public Shared Function Times2%(number%)
      Return 0
    End Function

    Public Shared Function TrapInt%(value%, loLimit%, highLimit%)
      Return 0
    End Function

    Public Shared Sub VLAdd(value1#, value2#, sum#, errFlag%)

    End Sub

    Public Shared Sub VLDiv(dividend#, divisor#, quotient#, remainder#, errFlag%)

    End Sub

    Public Shared Sub VLMul(value1#, value2#, product#, errFlag%)

    End Sub

    Public Shared Sub VLPack(number$, value#, errFlag%)

    End Sub

    Public Shared Sub VLSub(value1#, value2#, difference#, errFlag%)

    End Sub

    Public Shared Sub VLUnpack(alias#, number$, errFlag%)

    End Sub

    Public Shared Function WeekDay%(d$)
      Return 0
    End Function

    Public Shared Sub WordWrap(message$, wide%)

    End Sub

  End Class

End Namespace