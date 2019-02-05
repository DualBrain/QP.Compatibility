Option Explicit On
Option Strict On
Option Infer On

Namespace QP

  Public NotInheritable Class Video

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
      Return 0
    End Function

    Public Shared Sub BlinkOff()

    End Sub

    Public Shared Sub BlinkOn()

    End Sub

    Public Shared Sub Box(ulRow%, ulCol%, lrRow%, lrCol%, char%, colr%, page%)

    End Sub

    Public Shared Sub Box0(ulRow%, ulCol%, lrRow%, lrCol%, char%, colr%)

    End Sub

    Public Shared Sub BPrint(x$)

    End Sub

    Public Shared Sub ClearEOL(colr%)

    End Sub

    Public Shared Sub ClearScr(ulRow%, ulCol%, lrRow%, lrCol%, colr%, page%)

    End Sub

    Public Shared Sub ClearScr0(ulRow%, ulCol%, lrRow%, lrCol%, colr%)

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
      Return 0
    End Function

    Public Shared Sub MPaintBox(ulRow%, ulCol%, lrRow%, lrCol%, colr%)

    End Sub

    Public Shared Sub MPRestore(ulRow%, ulCol%, lrRow%, lrCol%, originalWidth%, array%(), start%)

    End Sub

    Public Shared Sub MQPrint(x$, colr%)

    End Sub

    Public Shared Sub MScrnSave(ulRow%, ulCol%, lrRow%, lrCol%, a%())

    End Sub

    Public Shared Sub MScrnRest(ulRow%, ulCol%, lrRow%, lrCol%, a%())

    End Sub

    Public Shared Function OneColor%(fg%, bg%)
      Return 0
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

    Public Shared Sub QPrint0(x$, colr%)

    End Sub

    Public Shared Sub QPrintAny(x$, colr%, monCode%, row%, column%)

    End Sub

    Public Shared Sub QPrintRC(work$, row%, column%, colr%)

    End Sub

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

    End Sub

    Public Shared Sub ScrnRest0(ulRow%, ulCol%, lrRow%, lrCol%, array%())

    End Sub

    Public Shared Sub ScrnSave(ulRow%, ulCol%, lrRow%, lrCol%, array%(), page%)

    End Sub

    Public Shared Sub ScrnSave0(ulRow%, ulCol%, lrRow%, lrCol%, array%())

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

    Public Shared Sub SplitColor(colr%, fg%, bg%)

    End Sub

  End Class

End Namespace