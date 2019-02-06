Option Explicit On
Option Strict On
Option Infer On

Imports System.Runtime.InteropServices

Namespace QP

  Public NotInheritable Class Video

    <DllImport("kernel32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)>
    Private Shared Function ReadConsoleOutputCharacter(hConsoleOutput As IntPtr,
                                                       <Out()> lpCharacter As Text.StringBuilder,
                                                       length As UInteger,
                                                       bufferCoord As Coord,
                                                       ByRef lpNumberOfCharactersRead As UInteger) As Boolean
    End Function

    <DllImport("kernel32.dll")>
    Private Shared Function ReadConsoleOutputAttribute(hConsoleOutput As IntPtr,
                                                       <Out()> ByVal lpAttribute() As UShort,
                                                       length As UInteger,
                                                       bufferCoord As Coord,
                                                       <System.Runtime.InteropServices.Out()> ByRef lpNumberOfAttrsRead As UInteger) As Boolean
    End Function

    Private Sub New()
    End Sub

    Public Shared Sub APrint(array$(), first%, numEls%, firstChar%, numChars%, colr%, page%)

    End Sub

    Public Shared Sub APrint0(array$(), first%, numEls%, firstChar%, numChars%, colr%)

    End Sub

    Public Shared Sub APrintT(array$(), first%, elSize%, numEls%, firstChar%, numChars%, colr%, page%)

    End Sub

    Public Shared Sub APrintT0(array$(), first%, elSize%, numEls%, firstChar%, numChars%, colr%)

    End Sub

    Public Shared Function ArraySize%(ULRow%, ULCol%, LRRow%, LRCol%)
      ' ArraySize will quickly calculate how many elements are needed in an integer array that Is intended to hold a portion of the display screen. 
      ' ULRow%, ULCol%, LRRow%, And LRCol% describe the area Of the screen To be saved, And Size receives the number of elements that are needed. 
      Return (LRRow% - ULRow% + 1) * (LRCol% - ULCol% + 1)
    End Function

    Public Shared Sub BlinkOff()

    End Sub

    Public Shared Sub BlinkOn()

    End Sub

    Public Shared Sub Box(ulRow%, ulCol%, lrRow%, lrCol%, char%, colr%, page%)

    End Sub

    Public Shared Sub Box0(ulRow%, ulCol%, lrRow%, lrCol%, char%, colr%)

      Dim C1$ = ""
      Dim C2$
      Dim C3$
      Select Case char%
        Case 1
          C1$ = QB.QBChr(218) + QB.QBChr(196) + QB.QBChr(191)
          C2$ = QB.QBChr(179) + QB.QBChr(32) + QB.QBChr(179)
          C3$ = QB.QBChr(192) + QB.QBChr(196) + QB.QBChr(217)
        Case 2
          C1$ = QB.QBChr(201) + QB.QBChr(205) + QB.QBChr(187)
          C2$ = QB.QBChr(186) + QB.QBChr(32) + QB.QBChr(186)
          C3$ = QB.QBChr(200) + QB.QBChr(205) + QB.QBChr(188)
        Case 3
          C1$ = QB.QBChr(213) + QB.QBChr(205) + QB.QBChr(184)
          C2$ = QB.QBChr(179) + QB.QBChr(32) + QB.QBChr(179)
          C3$ = QB.QBChr(212) + QB.QBChr(205) + QB.QBChr(190)
        Case 4
          C1$ = QB.QBChr(214) + QB.QBChr(196) + QB.QBChr(183)
          C2$ = QB.QBChr(186) + QB.QBChr(32) + QB.QBChr(186)
          C3$ = QB.QBChr(211) + QB.QBChr(196) + QB.QBChr(189)
        Case Else
          C1$ = QB.QBString(3, char%)
          C2$ = C1$
          C3$ = C1$
      End Select
      Dim W = lrCol - ulCol
      Dim H = lrRow - ulRow
      Call QPrintRC(Left(C1$, 1) + QB.QBString(W - 1, Mid(C1$, 2, 1)) + Right(C1$, 1), ulRow, ulCol, colr)
      For X = 1 To H
        Call QPrintRC(Left(C2$, 1), ulRow + X, ulCol, colr)
        Call QPrintRC(Right(C2$, 1), ulRow + X, lrCol, colr)
      Next

      Call QPrintRC(Left(C3$, 1) + QB.QBString(W - 1, Mid(C3$, 2, 1)) + Right(C3$, 1), lrRow, ulCol, colr)

    End Sub

    Public Shared Sub BPrint(x$)

    End Sub

    Public Shared Sub ClearEOL(colr%)

    End Sub

    Public Shared Sub ClearScr(ulRow%, ulCol%, lrRow%, lrCol%, colr%, page%)

    End Sub

    Public Shared Sub ClearScr0(ulRow%, ulCol%, lrRow%, lrCol%, colr%)
      For r% = ulRow% To lrRow%
        For c% = ulCol% To lrCol%
          QPrintRC(" ", r%, c%, colr%)
        Next
      Next
    End Sub

    Public Shared Sub CsrSize(top%, bottom%)

    End Sub

    Public Shared Sub EGABLoad(filename$)

    End Sub

    Public Shared Sub EGABSve(filename$)

    End Sub

    Public Shared Function EGAMem%()
      Return 0
    End Function

    Public Shared Sub FillScrn(ulRow%, ulCol%, lrRow%, lrCol%, colr%, char%, page%)

    End Sub

    Public Shared Sub FillScrn0(ulRow%, ulCol%, lrRow%, lrCol%, colr%, char%)

    End Sub

    Public Shared Sub GetVMode(mode%, page%, pageSize&, rows%, columns%)

      ' GetVMode will report the current video mode, the currently active display page, the page size, And the number of rows And columns. 
      ' Mode% Is the equivalent BIOS screen mode, And Page% Is the currently active page. The first page Is Page 0, And Not 1.PageSize& Is the number Of bytes Of display memory being used To hold the current screen. Rows% And Columns% also indicate the size Of the screen, but in terms of characters

    End Sub

    Public Shared Sub HCopy(fromPage%, toPage%)

    End Sub

    Public Shared Function HercThere%()
      Return 0
    End Function

    Public Shared Sub MakeMono(array%(), element%, size%)

    End Sub

    Public Shared Sub MakeMon2(array%(), start%, numEls%, code%)

    End Sub

    Public Shared Function Monitor%()
      Return 7 ' VGA adapter with a color monitor
    End Function

    Public Shared Sub MPaintBox(ulRow%, ulCol%, lrRow%, lrCol%, colr%)

      'MPaintBox is similar to PaintBox, except it always turns off the mouse cursor before painting the screen. When it is finished the cursor is turned back on. 
      ' ULRow%, ULCol%, LRRow%, And LRCol% describe the area Of the screen To be painted, And Colr% specifies the color to use.

      REM Dim FG%, BG%
      REM QuickPak.SplitColor(Colr, FG, BG)
      REM QB.COLOR(FG, BG)

      For c = ulCol To lrCol
        For r = ulRow To lrRow
          Dim s = QB.SCREEN(r, c)
          REM QB.LOCATE(R, C) : QB.PRINT(QB.QBChr(S), True)
          QPrintRC(QB.QBChr(S), r, c, colr)
        Next
      Next

    End Sub

    Public Shared Sub MPRestore(ulRow%, ulCol%, lrRow%, lrCol%, originalWidth%, array%(), start%)

    End Sub

    Public Shared Sub MQPrint(x$, colr%)

      If colr > -1 Then
        '  Split Colr into FG and BG; 16fg 8bg QuikPak style.
        Dim fg = (colr And 128) \ 8 + (colr And 15)
        Dim bg = (colr And 112) \ 16
        If fg > 15 Then fg = 15
        Console.ForegroundColor = CType(fg, ConsoleColor)
        Console.BackgroundColor = CType(bg, ConsoleColor)
      End If

      Console.Write(x$)

    End Sub

    Public Shared Sub MScrnSave(ulRow%, ulCol%, lrRow%, lrCol%, ByRef a%())
      ' MScrnSave And MScrnRest are similar To ScrnSave And ScrnRest, except they always turn off the mouse cursor while they are working. 
      ' ULRow%, ULCol%, LRRow%, And LRCol% describe the area Of the screen To consider, And A% O Is an integer array that Is used to hold the portion of the screen
      ScrnSave(ulRow, ulCol, lrRow, lrCol, a%, -1)
    End Sub

    Public Shared Sub MScrnRest(ulRow%, ulCol%, lrRow%, lrCol%, a%())
      ' MScrnSave And MScrnRest are similar To ScrnSave And ScrnRest, except they always turn off the mouse cursor while they are working. 
      ' ULRow%, ULCol%, LRRow%, And LRCol% describe the area Of the screen To consider, And A% O Is an integer array that Is used to hold the portion of the screen
      ScrnRest(ulRow, ulCol, lrRow, lrCol, a%, -1)
    End Sub

    Public Shared Function OneColor%(fg%, bg%)
      Return (fg And 16) * 8 + ((bg And 7) * 16) + (fg And 15)
    End Function

    Public Shared Sub PaintBox(ulRow%, ulCol%, lrRow%, lrCol%, colr%, page%)

    End Sub

    Public Shared Sub PaintBox0(ulRow%, ulCol%, lrRow%, lrCol%, colr%)

    End Sub

    Public Shared Sub PrtSc(lptNumber%, page%)

    End Sub

    Public Shared Sub PrtSc0(lptNumber%)

    End Sub

    Public Shared Sub PUsing(number$, image$, color1%, color2%, page%, row%, column%)

    End Sub

    Public Shared Sub QPrint(x$, colr%, page%)

    End Sub

    Public Shared Sub QPrint0(output$, colr%)

      If colr% > -1 Then
        '  Split Colr into FG and BG; 16fg 8bg QuikPak style.
        Dim fg = (colr And 128) \ 8 + (colr And 15)
        Dim bg = (colr And 112) \ 16
        If fg > 15 Then fg = 15
        Console.ForegroundColor = CType(fg, ConsoleColor)
        Console.BackgroundColor = CType(bg, ConsoleColor)
      End If

      Console.Write(output$)

    End Sub

    Public Shared Sub QPrintAny(x$, colr%, monCode%, row%, column%)

    End Sub

#Region "QPrintRC"

    <DllImport("kernel32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)>
    Private Shared Function WriteConsoleOutput(hConsoleOutput As IntPtr, lpBuffer() As CharInfo, dwBufferSize As Coord, dwBufferCoord As Coord, ByRef lpWriteRegion As SmallRect) As Boolean
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Public Structure Coord
      Public X As Short
      Public Y As Short

      Public Sub New(ByVal X As Short, ByVal Y As Short)
        Me.X = X
        Me.Y = Y
      End Sub
    End Structure

    <StructLayout(LayoutKind.Explicit, CharSet:=CharSet.Unicode)>
    Public Structure CharUnion
      <FieldOffset(0)>
      Public UnicodeChar As Char
      <FieldOffset(0)>
      Public AsciiChar As Byte
    End Structure

    <StructLayout(LayoutKind.Explicit, CharSet:=CharSet.Unicode)>
    Public Structure CharInfo
      <FieldOffset(0)>
      Public [Char] As CharUnion
      <FieldOffset(2)>
      Public Attributes As Short
    End Structure

    <StructLayout(LayoutKind.Sequential)>
    Public Structure SmallRect
      Public Left As Short
      Public Top As Short
      Public Right As Short
      Public Bottom As Short
    End Structure

    <DllImport("kernel32.dll", SetLastError:=True)>
    Private Shared Function GetStdHandle(nStdHandle As Integer) As IntPtr
    End Function

    Private Shared ConsoleHandle As IntPtr

    Public Shared Sub QPrintRC(output$, r%, c%, colr%)

      ' "Direct" buffer writing (aka Fast).
      ' Doesn't modify the current cursor position...
      ' Doesn't modify the current FG or BG color...

      If output$ = vbNullChar OrElse
       String.IsNullOrEmpty(output$) Then
        Return
      End If

      If ConsoleHandle = IntPtr.Zero Then
        ConsoleHandle = GetStdHandle(-11)
      End If

      If ConsoleHandle <> IntPtr.Zero Then

        Dim ln = CShort(Len(output$))
        Dim lt = CShort(c% - 1)
        Dim rt = lt + ln
        Dim tp = CShort(r% - 1)

        '  Split Colr into FG and BG; 16fg 8bg QuikPak style.
        Dim fg = (colr And 128) \ 8 + (colr And 15)
        Dim bg = (colr And 112) \ 16
        If fg > 15 Then fg = 15

        If colr% = -1 Then
          fg = Console.ForegroundColor
          bg = Console.BackgroundColor
        End If

        Dim attribute = CShort(fg Or (bg << 4))

        Dim buf(ln - 1) As CharInfo

        For ch% = 0 To ln - 1
          buf(ch%).Attributes = attribute
          'buf(ch%).Char.AsciiChar = CByte(Asc(output$(ch%)))
          buf(ch%).Char.UnicodeChar = output$(ch%)
        Next

        ' The temporary buffer size is 1 row x N columns.

        Dim bufSize = New Coord() With {.X = ln, .Y = 1}

        ' The top left destination cell of the temporary buffer is row 0, col 0.

        Dim bufCoord = New Coord() With {.X = 0, .Y = 0}

        ' Set the destination rectangle.

        Dim writeRect = New SmallRect() With {.Left = lt, .Top = tp, .Right = rt, .Bottom = tp}

        Dim success = WriteConsoleOutput(ConsoleHandle,
                                       buf,
                                       bufSize,
                                       bufCoord,
                                       writeRect)

      End If

    End Sub

#End Region

    Public Shared Sub QPWindowInit(ulRow%, ulCol%, lrRow%, lrCol%)

    End Sub

    Public Shared Sub QPWindowPrint(text$, colr%)

    End Sub

    Public Shared Sub QPWindowCLS(colr%)

    End Sub

    Public Shared Sub QPWindowLocate(row%, column%)

    End Sub

    Public Shared Sub ReadScrn(row%, column%, x$, page%)

    End Sub

    Public Shared Sub ReadScrn0(row%, column%, x$)

    End Sub

    Public Shared Sub ScrnDump(dpi$, lptnumber%, translate%)

    End Sub

    Public Shared Sub ScrnRest(ulRow%, ulCol%, lrRow%, lrCol%, array%(), page%)

      ' Note: This routine is UNICODE-based; works with UTF-8 Encoding.

      ' ScrnRest will restore a screen that had previously been saved with ScrnSave Or ScrnSave0. 
      ' ULRow%, ULCol%, LRRow%, And LRCol% describe the area Of the screen, Array%() Is an Integer array used To hold the screen, And Page% indicates the page To restore To. 
      ' If Page% Is -1 the current screen Is restored. Notice that a screen may be restored To any legal text page, regardless of which page it had been saved from.

      Dim width = (lrCol - ulCol) + 1

      For r As Short = CShort(ulRow) To CShort(lrRow)
        Console.SetCursorPosition(ulCol - 1, r - 1)
        For c As Short = CShort(ulCol) To CShort(lrCol)
          If r = Console.WindowHeight - 1 AndAlso c = Console.WindowWidth - 1 Then
            ' skip
          Else

            Dim index% = ((r - ulRow) * width) + (c - ulCol)

            Dim combined As Integer = array(index)

            Dim character = ChrW(combined And &HFFFF)
            Dim attribute = ((combined >> 16) And &HFFFF)

            Dim f = CType(attribute And &HF, ConsoleColor)
            Dim b = CType((((attribute And &HF0) >> 4) And &HF), ConsoleColor)

            If Console.ForegroundColor <> f Then Console.ForegroundColor = f
            If Console.BackgroundColor <> b Then Console.BackgroundColor = b

            Console.Write(character)

          End If
        Next
      Next

    End Sub

    Public Shared Sub ScrnRest0(ulRow%, ulCol%, lrRow%, lrCol%, array%())

      ' ScrnRest0 will restore a screen that had previously been saved with ScrnSave Or ScrnSave0. 
      ' ULRow%, ULCol%, LRRow%, And LRCol% describe the area Of the screen being restored, And Array%O Is an integer array used to hold the screen. 
      ScrnRest(ulRow, ulCol, lrRow, lrCol, array, -1)

    End Sub

    Public Shared Sub ScrnSave(ulRow%, ulCol%, lrRow%, lrCol%, array%(), page%)

      ' Note: This routine is UNICODE-based; works with UTF-8 Encoding.

      ' ScrnSave will save all Or part Of a text screen into an Integer array, to allow restoring it again at a later time. 
      ' ULRow%, ULCol%, LRRow%, And LRCol% describe the area Of the screen To be saved, Array%() Is an Integer array used To hold the screen, And Page% indicates which text page To save from. If Page% Is -1, the current screen Is saved. 

      'If Action% = 0 Then
      '  ConsoleEx.Snapshot(False)
      'Else
      '  ConsoleEx.Snapshot(True)
      'End If

      If ConsoleHandle = IntPtr.Zero Then
        ConsoleHandle = GetStdHandle(-11)
      End If

      If ConsoleHandle = IntPtr.Zero Then
        Return
      End If

      'Dim consoleHandle = GetStdHandle(-11)
      'If consoleHandle = IntPtr.Zero Then
      '  Return
      'End If

      Dim width As Short = CShort((lrCol - ulCol) + 1)

      For r As Short = CShort(ulRow) To CShort(lrRow)

        Dim position = New Coord(CShort(ulCol - 1), r - CShort(1))

        Dim attributes(width - 1) As UShort
        Dim read As UInteger = 0
        Dim success = ReadConsoleOutputAttribute(ConsoleHandle, attributes, Convert.ToUInt32(width), position, read)

        If Not success OrElse
         read <> width Then
          Stop
        End If

        Dim characters = New Text.StringBuilder(width - 1)
        read = 0
        success = ReadConsoleOutputCharacter(ConsoleHandle, characters, Convert.ToUInt32(width), position, read)

        If Not success OrElse
         read <> width Then
          Stop
        End If

        For c As Short = 0 To width - CShort(1) ' CShort(attributes.Length - 1)

          'Try
          Dim a As Integer = 0
          If c < characters.Length Then
            Dim ch As Char = characters(c)
            a = AscW(ch)
          Else
            Debug.WriteLine("Char buffer < expected...")
          End If
          Dim character = CShort(a)
          'Catch ex As Exception
          'character = 0
          'End Try
          Dim attribute As Short = CShort(attributes(c))

          If character < 0 Then
            Stop
          End If

          If attribute < 0 Then
            Stop
          End If

          Dim combined As Integer = (CInt(attribute) << 16) Or CShort(character)

          Dim index% = ((r - ulRow) * width) + c

          array(index) = combined

        Next

      Next

      'Console.WriteLine($"a={a}")
      'Console.WriteLine($"b={b}")

      'Dim c As Short = a Or (b << 8)
      'Dim d As Short = (b << 8) + a

      'Console.WriteLine()
      'Console.WriteLine($"c={c}")
      'Console.WriteLine()

      'Dim lowByte = c And &HFF
      'Dim highByte = ((c >> 8) And &HFF)

      'Console.WriteLine($"a={lowByte}")
      'Console.WriteLine($"b={highByte}")

      'Console.ReadLine()

      'End

    End Sub

    Public Shared Sub ScrnSave0(ulRow%, ulCol%, lrRow%, lrCol%, array%())
      ' ScrnSave0 will save all or a portion of a text screen into an integer array, to allow restoring it again at a later time. 
      ' ULRow%, ULCol % , LRRow%, And LRCol % describe the area Of the screen To be saved, And Array%O Is an integer array used to hold the screen. 
      ScrnSave(ulRow, ulCol, lrRow, lrCol, array, -1)
    End Sub

    Public Shared Sub ScrollD(ulRow%, ulCol%, lrRow%, lrCol%, lines%, page%)

    End Sub

    Public Shared Sub ScrollL(ulRow%, ulCol%, lrRow%, lrCol%, lines%, page%)

    End Sub

    Public Shared Sub ScrollR(ulRow%, ulCol%, lrRow%, lrCol%, lines%, page%)

    End Sub

    Public Shared Sub ScrollU(ulRow%, ulCol%, lrRow%, lrCol%, lines%, page%)

    End Sub

    Public Shared Sub SetMonSeg(newSegment%)

    End Sub

    Public Shared Sub SplitColor(colr%, ByRef fg%, ByRef bg%)
      fg = (colr And 128) \ 8 + (colr And 15)
      bg = (colr And 112) \ 16
    End Sub

  End Class

End Namespace