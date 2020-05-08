Option Explicit On
Option Strict On
Option Infer On

Imports QB.Core

Imports QP.Strings

Namespace Global.QP

  Public NotInheritable Class Array

    Private Sub New()
    End Sub

    'Public Shared Sub Addlnt(ByRef a%(), start%, value%, numEls%)

    'End Sub

    Public Shared Sub DeleteStr(ByRef array$(), element%, numEls%)
      For X = element To element + numEls
        SWAP(array(X), array(X + 1))
      Next
    End Sub

    'Public Shared Sub DeleteT(ByRef a%(), element%, elSize%, numEls%)

    'End Sub

    Public Shared Sub DimBits(ByRef array$, numEls%)
      array = New String(Chr(0), numEls \ 8 + 1)
    End Sub

    'Public Shared Sub Fill2(ByRef ay%(), start%, value%, numEls%)

    'End Sub

    'Public Shared Sub Fill4(ByRef a() As Single, start%, value%, numEls%)

    'End Sub

    'Public Shared Sub Fill8(ByRef a() As Double, start%, value%, numEls%)

    'End Sub

    'Public Shared Sub Find(a$(), start%, ByRef numEls%, search$)

    'End Sub

    'Public Shared Sub Find2(a$(), start%, ByRef numEls%, search$)

    'End Sub

    'Public Shared Sub FindB(a$(), ByRef curEl%, search$)

    'End Sub

    'Public Shared Sub FindB2(a$(), ByRef curEl%, search$)

    'End Sub

    'Public Shared Sub FindExact(a$(), start%, numEls%, search$)

    'End Sub

    'Public Shared Sub FindT(a$(), start%, elSize%, numEls%, search$)

    'End Sub

    'Public Shared Sub FindT2(a$(), start%, elSize%, numEls%, search$)

    'End Sub

    'Public Shared Sub FindTB(a$(), elSize%, curEl%, search$)

    'End Sub

    'Public Shared Sub FindTB2(a$(), elSize%, curEl%, search$)

    'End Sub

    Public Shared Function FindLast%(Arry$(), NumEls%)
      ' FindLast scans a conventional (not fixed-length) string array backwards looking for the last non-blank element. 
      For index = NumEls% - 1 To 0 Step -1
        If Not String.IsNullOrEmpty(QPTrim$(Arry$(index))) Then
          Return index
        End If
      Next
      Return -1
    End Function

    Public Shared Function GetBit%(array$, element%)

      ' returns a -1 if element is set (not a 1)
      Dim index = (element \ 8)

      If array.Length < index + 1 Then
        Stop
      End If

      Dim v = Asc(array(index))

      Dim mask = 1 << (element Mod 8)
      Return CInt((v And mask) <> 0)

      'Return (v And ((2 ^ (element Mod 8)) - 1) <> 0)

    End Function

    'Public Shared Function IMaxD%(a#(), start%, numEls%)
    '  Return 0
    'End Function

    'Public Shared Function IMaxI%(a() As Short, start%, numEls%)
    '  Return 0
    'End Function

    'Public Shared Function IMaxL%(a() As Integer, start%, numEls%)
    '  Return 0
    'End Function

    'Public Shared Function IMaxS%(a() As Single, start%, numEls%)
    '  Return 0
    'End Function

    'Public Shared Function IMaxC%(a() As System.Currency, start%, numEls%)
    '  Return 0
    'End Function

    'Public Shared Function IMindD%(a#(), start%, numEls%)
    '  Return 0
    'End Function

    'Public Shared Function IMindI%(a() As Short, start%, numEls%)
    '  Return 0
    'End Function

    'Public Shared Function IMindL%(a() As Integer, start%, numEls%)
    '  Return 0
    'End Function

    'Public Shared Function IMindI%(a() As Single, start%, numEls%)
    '  Return 0
    'End Function

    'Public Shared Function IMindI%(a() As Currency, start%, numEls%)
    '  Return 0
    'End Function

    'Public Shared Sub InitInt(a%(), start%, value%, numEls%)

    'End Sub

    Public Shared Sub InsertStr(ByRef array$(), element%, ins$, numEls%)
      For x = (element + numEls) To (element + 1) Step -1
        SWAP(array(x), array(x - 1))
      Next
      SWAP(array(element), ins)
    End Sub

    'Public Shared Sub InsertT(a() As Object, element%, elSize%, numEls%)

    'End Sub

    'Public Shared Sub ISortD(a() As Double, start%, ndx%(), numEls%, dir%)

    'End Sub

    'Public Shared Sub ISortI(a() As Short, start%, ndx%(), numEls%, dir%)

    'End Sub

    'Public Shared Sub ISortL(a() As Integer, start%, ndx%(), numEls%, dir%)

    'End Sub

    'Public Shared Sub ISortS(a() As Single, start%, ndx%(), numEls%, dir%)

    'End Sub

    'Public Shared Sub ISortC(a() As Currency, start%, ndx%(), numEls%, dir%)

    'End Sub

    'Public Shared Sub SortStr(a$(), Start%, Ndx%(), NumEls%, Dir%)

    'End Sub

    'Public Shared Sub SortStr2(a$(), Start%, Ndx%(), NumEls%, Dir%)

    'End Sub

    'Public Shared Sub ISortT(a() As Object, start%, ByRef ndx%(), numEls%, dir%, elSize%, member0ffset%, memberSize%)

    'End Sub

    'Public Shared Sub ISortT2(a() As Object, start%, ByRef ndx%(), numEls%, dir%, elSize%, member0ffset%, memberSize%)

    'End Sub

    'Public Shared Sub KeySort(a() As Object, start%, elSize%, numEls%, table%(,), numKeys%)

    'End Sub

    'Public Shared Function MaxD%(a() As Double, start%, numEls%)
    '  Return 0
    'End Function

    'Public Shared Function MaxI%(a() As Short, start%, numEls%)
    '  Return 0
    'End Function

    'Public Shared Function MaxL%(a() As Integer, start%, numEls%)
    '  Return 0
    'End Function

    'Public Shared Function MaxS%(a() As Single, start%, numEls%)
    '  Return 0
    'End Function

    'Public Shared Function MaxC%(a() As Currency, start%, numEls%)
    '  Return 0
    'End Function

    'Public Shared Function MinD%(a() As Double, start%, numEls%)
    '  Return 0
    'End Function

    'Public Shared Function MinI%(a() As Short, start%, numEls%)
    '  Return 0
    'End Function

    'Public Shared Function MinL%(a() As Integer, start%, numEls%)
    '  Return 0
    'End Function

    'Public Shared Function MinS%(a() As Single, start%, numEls%)
    '  Return 0
    'End Function

    'Public Shared Function MinC%(a() As Currency, start%, numEls%)
    '  Return 0
    'End Function

    'Public Shared Sub SearchT(a() As Object, start%, numEls%, match%, found%, dir%, code%, structSize%, memberDff%, memberSize%)

    'End Sub

    'Public Shared Sub SearchT2(a() As Object, start%, numEls%, match%, found%, dir%, code%, structSize%, memberDff%, memberSize%)

    'End Sub

    Public Shared Sub SetBit(ByRef array$, element%, bit%)

      ' bit = 0, clear the bit
      ' bit <> 0, set the bit

      ' Each byte represents 8 bits...

      Dim index = (element \ 8)

      If array Is Nothing OrElse
         array.Length < index + 1 Then
        Return
      End If

      Dim v = Asc(array(index))

      Dim mask = 1 << (element Mod 8)

      If bit = 0 Then
        v = v And Not mask
      Else
        v = v Or mask
      End If

      Dim l = ""
      Dim r = ""

      If index > 0 Then
        l = array.Substring(0, index)
      End If

      If index + 1 < array.Length Then
        r = array.Substring(index + 1)
      End If

      array = l & Chr(v) & r

    End Sub

    'Public Shared Function SortD%(a() As Double, start%, numEls%, dir%)
    '  Return 0
    'End Function

    'Public Shared Function SortI%(a() As Short, start%, numEls%, dir%)
    '  Return 0
    'End Function

    'Public Shared Function SortL%(a() As Integer, start%, numEls%, dir%)
    '  Return 0
    'End Function

    'Public Shared Function SortS%(a() As Single, start%, numEls%, dir%)
    '  Return 0
    'End Function

    'Public Shared Function SortC%(a() As Currency, start%, numEls%, dir%)
    '  Return 0
    'End Function

    Public Shared Sub SortStr(ByRef arry$(), start%, numEls%, dir%)

      ' SortStr will sort all or just a portion of a conventional (not fixed-length) string array into either ascending or descending order. 
      ' SortStr2 is nearly identical, but sorting is performed without regard to capitalization.

      Dim s$(numEls - 1)

      Dim index = 0

      For index = start To start + numEls - 1
        s$(index - 1) = arry$(index)
      Next

      Dim result$()

      If dir = 0 Then
        result = (From p In s$ Order By p Ascending).ToArray()
      Else
        result = (From p In s$ Order By p Descending).ToArray()
      End If

      index = start
      For Each value In result.ToList
        arry(index) = value
        index += 1
      Next

    End Sub

    Public Shared Sub SortStr2(ByRef arry$(), start%, numEls%, dir%)

      ' SortStr will sort all or just a portion of a conventional (not fixed-length) string array into either ascending or descending order. 
      ' SortStr2 is nearly identical, but sorting is performed without regard to capitalization.

      Dim s$(numEls - 1)

      Dim index = 0

      For index = start To start + numEls - 1
        s$(index - 1) = arry$(index)
      Next

      Dim result$()

      If dir = 0 Then
        result = (From p In s$ Order By p.ToLower Ascending).ToArray()
      Else
        result = (From p In s$ Order By p.ToLower Descending).ToArray()
      End If

      index = start
      For Each value In result.ToList
        arry(index) = value
        index += 1
      Next

    End Sub

    Public Shared Sub SortT(ByRef arry$(), start%, numEls%, dir%, elSize%, memberOffset%, memberSize%)

      If start <> 0 OrElse numEls <> 0 OrElse dir <> 0 OrElse elSize <> 0 OrElse memberOffset <> 0 OrElse memberSize <> 0 Then

      End If

      ' SortT will sort all or part of a fixed-length string or TYPE array into either ascending or descending order. 

      Dim result = From p In arry Order By p Ascending

      ReDim arry(result.Count - 1)
      Dim index = 0 '1
      For Each value In result.ToList
        arry(index) = value
        index += 1
      Next

    End Sub

    'Public Shared Sub SortT2(a() As Object, start%, numEls%, dir%, elSize%, memberOffset%, memberSize%)

    '  ' SortT2 is nearly identical, but when considering the string component of a TYPE array, sorting is performed without regard to capitalization. 

    'End Sub

    Public Shared Sub SortT2(ByRef a() As String, start%, NumE1s%, Dir%, E1Size%, Member0ffset%, MemberSize%)

      If start <> 0 OrElse NumE1s <> 0 OrElse Dir <> 0 OrElse E1Size <> 0 OrElse Member0ffset <> 0 OrElse MemberSize <> 0 Then

      End If

      ' SortT2 is nearly identical, but when considering the string component of a TYPE array, sorting is performed without regard to capitalization. 

      Dim result = From p In a Order By p Ascending

      ReDim a(result.Count)
      Dim index = 1
      For Each value In result.ToList
        a(index) = value
        index += 1
      Next

    End Sub

  End Class

End Namespace