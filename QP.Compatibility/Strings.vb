﻿Option Explicit On
Option Strict On
Option Infer On

Namespace QP

  Public NotInheritable Class Strings

    Private Sub New()
    End Sub

    Public Shared Function ASCII%(any$)
      Return 0
    End Function

    Public Shared Function Blanks%(work$)
      Return 0
    End Function

    Public Shared Function Compact$(old$)
      Return Nothing
    End Function

    Public Shared Sub Encrypt(x$, password$)

    End Sub

    Public Shared Sub Encrypt2(x$, password$)

    End Sub

    Public Shared Function Far2Str$(segment$, address%)
      Return Nothing
    End Function

    Public Shared Function FUsing$(number$, image$)
      Return Nothing
    End Function

    Public Shared Function InCount%(source$, search$)
      Return 0
    End Function

    Public Shared Function InCount2%(source$, search$)
      Return 0
    End Function

    Public Shared Function InCountTbl%(source$, table$)
      Return 0
    End Function

    Public Shared Function InstrTbl%(start%, source$, table$)
      Return 0
    End Function

    Public Shared Function InstrTbl2%(start%, source$, table$)
      Return 0
    End Function

    Public Shared Function InstrTblB%(start%, source$, table$)
      Return 0
    End Function

    Public Shared Function InstrTblB2%(start%, source$, table$)
      Return 0
    End Function

    Public Shared Function LongestStr%(array$())
      Return 0
    End Function

    Public Shared Sub LowASCII(x$)

    End Sub

    Public Shared Sub Lower(x$)

    End Sub

    Public Shared Sub LowerTbl(work$, table$)

    End Sub

    Public Shared Function MidChar%(work$, position%)
      Return 0
    End Function

    Public Shared Sub MidCharS(work$, position%, char%)

    End Sub

    Public Shared Function NotInstr%(start%, searched$, table$)
      Return 0
    End Function

    Public Shared Function Null%(work$)
      Return 0
    End Function

    Public Shared Function ParseString$(curPos%, work$, delimit$)
      Return Nothing
    End Function

    Public Shared Sub ProperName(work$)

    End Sub

    Public Shared Function QInstr%(startPos%, source$, search$)
      Return 0
    End Function

    Public Shared Function QInstr2%(startPos%, source$, search$)
      Return 0
    End Function

    Public Shared Function QInstrB%(startPos%, source$, search$)
      Return 0
    End Function

    Public Shared Function QInstrB2%(startPos%, source$, search$)
      Return 0
    End Function

    Public Shared Sub QInstrH(segment%, address%, search$, numBytes&)

    End Sub

    Public Shared Function QPLeft$(work$, numChars%)
      Return Nothing
    End Function

    Public Shared Function QPMid$(work$, startChar%, numChars%)
      Return Nothing
    End Function

    Public Shared Function QPRight$(work$, numChars%)
      Return Nothing
    End Function

    Public Shared Function QPLen%(work$)
      Return 0
    End Function

    Public Shared Function QPSadd%(work$)
      Return 0
    End Function

    Public Shared Function QPStrI$(intVar%)
      Return Nothing
    End Function

    Public Shared Function QPStrL$(longInt&)
      Return Nothing
    End Function

    Public Shared Function QPTrim$(text As String)

      If text Is Nothing Then Return Nothing

      Dim offset As Integer = text.IndexOf(Chr(0))

      If offset = 0 Then
        text = ""
      ElseIf offset > 0 Then
        text = text.Substring(0, text.IndexOf(Chr(0)))
      End If

      text = text.Trim

      If text <> "" Then
        Return text
      Else
        Return ""
      End If

    End Function

    Public Shared Function QPLTrim$(work$)
      Return Nothing
    End Function

    Public Shared Function QPRTrim$(work$)
      Return Nothing
    End Function

    Public Shared Function QPValI%(value$)
      Return 0
    End Function

    Public Shared Function QPValL&(value$)
      Return 0
    End Function

    Public Shared Sub RemCtrl(x$, replace$)

    End Sub

    Public Shared Sub ReplaceChar(source$, old$, new$)

    End Sub

    Public Shared Sub ReplaceCharT(typeVar As Object, typeLength%, oldChar%, newChar%)

    End Sub

    Public Shared Sub ReplaceCharT2(typeVar As Object, typeLength%, oldChar%, newChar%)

    End Sub

    Public Shared Sub ReplaceString(source$, old$, new$)

    End Sub

    Public Shared Sub ReplaceTbl(work$, table$)

    End Sub

    Public Shared Sub Sequence(work$)

    End Sub

    Public Shared Function SpellNumber$(number$)
      Return Nothing
    End Function

    Public Shared Sub Translate(x$)

    End Sub

    Public Shared Sub Upper(x$)

    End Sub

    Public Shared Sub UpperTbl(work$, table$)

    End Sub

  End Class

End Namespace