Option Explicit On
Option Strict On
Option Infer On

Namespace QP

  Public NotInheritable Class MenuInput

    Private Sub New()
    End Sub

    Public Shared Sub AMenu(array$(), start%, startItem%, count%, scanCode%, normColor%, HiLiteColor%, numRows%, numCols%, gap%, ulRow%, ulCol%)

    End Sub

    Public Shared Sub AMenuT(array$(), start%, startItem%, length%, count%, scanCode%, normColor%, HiLiteColor%, numRows%, numCols%, gap%, ulRow%, ulCol%)

    End Sub

    Public Shared Sub ASCIIPick(char%, color1%, color2%, exitCode%)

    End Sub

    Public Shared Sub MASCIIPick(char%, color1%, color2%, exitCode%)

    End Sub

    Public Shared Sub ColorPick(colr%, boxColor%, exitCode%)

    End Sub

    Public Shared Sub MColorPick(colr%, boxColor%, exitCode%)

    End Sub

    Public Shared Sub DirFile(array$(), count%, scanCode%, msgColor%, fileColor%, hiLiteColor%, boxColor%)

    End Sub

    Public Shared Sub Editor(ed$, activeLength%, scanCode%, numOnly%, capsOn%, normalColor%, editColor%, row%, column%)

    End Sub

    Public Shared Sub MAMenu(array$(), selection%, start%, count%, scanCode%, normalColor%, hilight%, numRows%, numCols%, gap%, row%, column%)

    End Sub

    Public Shared Sub MAMenuT(array$(), selection%, start%, length%, count%, scanCode%, normalColor%, hilight%, numRows%, numCols%, gap%, row%, column%)

    End Sub

    Public Shared Sub MEditor(ed$, activeLength%, scanCode%, numOnly%, capsOn%, normalColor%, editColor%, row%, column%, currentColumn%)

    End Sub

    Public Shared Sub MenuVert(array$, numLines%, scanCode%, choice%, normalColor%, hiLiteColor%, row%, column%)

    End Sub

    Public Shared Function MGetKey%(row%, column%)
      Return 0
    End Function

    Public Shared Sub MMenuVert(array$, selection%, start%, scanCode%, normalColor%, highlight%, numRows%, row%, column%)

    End Sub

    Public Shared Sub YesNo(yn$, prompt$, scanCode%, normalColor%, editColor%, row%, column%)

    End Sub

    Public Shared Sub YesNoB(yn$, exitCode%, colr%)

    End Sub


  End Class

End Namespace