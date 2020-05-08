Option Explicit On
Option Strict On
Option Infer On

Namespace Global.QP

  Public NotInheritable Class Functions

    Private Sub New()
    End Sub

    Public Shared Function Bin2Num%(binary$)
      Return 0
    End Function

    Public Shared Function C2F!(ctemp!)
      Return 0
    End Function

    Public Shared Function Delimit%(work$, table$)
      Return 0
    End Function

    Public Shared Function Eval#(number$)
      Return 0
    End Function

    Public Shared Function ExpandTab$(original$, numspaces%)
      Return Nothing
    End Function

    Public Shared Function F2C!(FTemp!)
      Return 0
    End Function

    Public Shared Function LastFirst$(oldName$)
      Return Nothing
    End Function

    Public Shared Function LastLast$(oldName$)
      Return Nothing
    End Function

    Public Shared Function Num2Bin$(number%)

      Dim result = ""
      For index = 8 To 1 Step -1
        If (number% And CInt(2 ^ (index - 1))) <> 0 Then
          result &= "1"
        Else
          result &= "0"
        End If
      Next
      Return result

    End Function

    Public Shared Function Num2Bin2$(number%)
      Return Nothing
    End Function

    Public Shared Function Pad$(number!, digits%)
      Return Nothing
    End Function

    Public Shared Sub Parse(work$, deliMM$, array$())

    End Sub

    Public Shared Function ParseStr$(list$)
      Return Nothing
    End Function

    Public Shared Function QPHex$(value%, numDigits%)
      Return Nothing
    End Function

    Public Shared Function Rand!(lower!, upper!)
      Return 0
    End Function

    Public Shared Function ShrinkTab$(orignal$, numSpaces%)
      Return Nothing
    End Function

    Public Shared Function Signed%(US&)
      Return 0
    End Function

    Public Shared Function UnParseStr$(code$)
      Return Nothing
    End Function

    Public Shared Function UnSigned&(s%)
      Return 0
    End Function

  End Class

End Namespace