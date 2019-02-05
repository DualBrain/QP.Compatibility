Option Explicit On
Option Strict On
Option Infer On

Imports QP.Strings

Namespace QP

  Public NotInheritable Class Array

    Private Sub New()
    End Sub

    Public Shared Sub Addlnt(ByRef a%(), start%, value%, numEls%)

    End Sub

    Public Shared Sub DeleteStr(ByRef array$(), element%, numEls%)
      'For X = element To element + numEls
      '  QB.SWAP(array(X), array(X + 1))
      'Next
    End Sub

    Public Shared Sub DeleteT(ByRef a%(), element%, elSize%, numEls%)

    End Sub

    Public Shared Sub DimBits(ByRef array$, numEls%)

    End Sub

    Public Shared Sub Fill2(ByRef ay%(), start%, value%, numEls%)

    End Sub

    Public Shared Sub Fill4(ByRef a() As Single, start%, value%, numEls%)

    End Sub

    Public Shared Sub Fill8(ByRef a() As Double, start%, value%, numEls%)

    End Sub

    Public Shared Sub Find(a$(), start%, ByRef numEls%, search$)

    End Sub

    Public Shared Sub Find2(a$(), start%, ByRef numEls%, search$)

    End Sub

    Public Shared Sub FindB(a$(), ByRef curEl%, search$)

    End Sub

    Public Shared Sub FindB2(a$(), ByRef curEl%, search$)

    End Sub

    Public Shared Sub FindExact(a$(), start%, numEls%, search$)

    End Sub

    Public Shared Sub FindT(a$(), start%, elSize%, numEls%, search$)

    End Sub

    Public Shared Sub FindT2(a$(), start%, elSize%, numEls%, search$)

    End Sub

    Public Shared Sub FindTB(a$(), elSize%, curEl%, search$)

    End Sub

    Public Shared Sub FindTB2(a$(), elSize%, curEl%, search$)

    End Sub

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
      Return 0
    End Function

    Public Shared Function IMaxD%(a#(), start%, numEls%)
      Return 0
    End Function

    Public Shared Function IMaxI%(a() As Short, start%, numEls%)
      Return 0
    End Function

    Public Shared Function IMaxL%(a() As Integer, start%, numEls%)
      Return 0
    End Function

    Public Shared Function IMaxS%(a() As Single, start%, numEls%)
      Return 0
    End Function

    'Public Shared Function IMaxC%(a() As System.Currency, start%, numEls%)
    '  Return 0
    'End Function

    Public Shared Function IMindD%(a#(), start%, numEls%)
      Return 0
    End Function

    Public Shared Function IMindI%(a() As Short, start%, numEls%)
      Return 0
    End Function

    Public Shared Function IMindL%(a() As Integer, start%, numEls%)
      Return 0
    End Function

    Public Shared Function IMindI%(a() As Single, start%, numEls%)
      Return 0
    End Function

    'Public Shared Function IMindI%(a() As Currency, start%, numEls%)
    '  Return 0
    'End Function

    Public Shared Sub InitInt(a%(), start%, value%, numEls%)

    End Sub

    Public Shared Sub InsertStr(ByRef Array$(), Element%, Ins$, NumEls%)
      'For X = (Element% + NumEls%) To (Element% + 1) Step -1
      '  QB.SWAP(Array$(X), Array$(X - 1))
      'Next
      'QB.SWAP(Array$(Element%), Ins$)
    End Sub

    Public Shared Sub InsertT(a() As Object, element%, elSize%, numEls%)

    End Sub

    Public Shared Sub ISortD(a() As Double, start%, ndx%(), numEls%, dir%)

    End Sub

    Public Shared Sub ISortI(a() As Short, start%, ndx%(), numEls%, dir%)

    End Sub

    Public Shared Sub ISortL(a() As Integer, start%, ndx%(), numEls%, dir%)

    End Sub

    Public Shared Sub ISortS(a() As Single, start%, ndx%(), numEls%, dir%)

    End Sub

    'Public Shared Sub ISortC(a() As Currency, start%, ndx%(), numEls%, dir%)

    'End Sub

    Public Shared Sub SortStr(a$(), Start%, Ndx%(), NumEls%, Dir%)

    End Sub

    Public Shared Sub SortStr2(a$(), Start%, Ndx%(), NumEls%, Dir%)

    End Sub

    Public Shared Sub ISortT(a() As Object, start%, ByRef ndx%(), numEls%, dir%, elSize%, member0ffset%, memberSize%)

    End Sub

    Public Shared Sub ISortT2(a() As Object, start%, ByRef ndx%(), numEls%, dir%, elSize%, member0ffset%, memberSize%)

    End Sub

    Public Shared Sub KeySort(a() As Object, start%, elSize%, numEls%, table%(,), numKeys%)

    End Sub

    Public Shared Function MaxD%(a() As Double, start%, numEls%)
      Return 0
    End Function

    Public Shared Function MaxI%(a() As Short, start%, numEls%)
      Return 0
    End Function

    Public Shared Function MaxL%(a() As Integer, start%, numEls%)
      Return 0
    End Function

    Public Shared Function MaxS%(a() As Single, start%, numEls%)
      Return 0
    End Function

    'Public Shared Function MaxC%(a() As Currency, start%, numEls%)
    '  Return 0
    'End Function

    Public Shared Function MinD%(a() As Double, start%, numEls%)
      Return 0
    End Function

    Public Shared Function MinI%(a() As Short, start%, numEls%)
      Return 0
    End Function

    Public Shared Function MinL%(a() As Integer, start%, numEls%)
      Return 0
    End Function

    Public Shared Function MinS%(a() As Single, start%, numEls%)
      Return 0
    End Function

    'Public Shared Function MinC%(a() As Currency, start%, numEls%)
    '  Return 0
    'End Function

    Public Shared Sub SearchT(a() As Object, start%, numEls%, match%, found%, dir%, code%, structSize%, memberDff%, memberSize%)

    End Sub

    Public Shared Sub SearchT2(a() As Object, start%, numEls%, match%, found%, dir%, code%, structSize%, memberDff%, memberSize%)

    End Sub

    Public Shared Sub SetBit(Array$, Element%, Bit%)

    End Sub

    Public Shared Function SortD%(a() As Double, start%, numEls%, dir%)
      Return 0
    End Function

    Public Shared Function SortI%(a() As Short, start%, numEls%, dir%)
      Return 0
    End Function

    Public Shared Function SortL%(a() As Integer, start%, numEls%, dir%)
      Return 0
    End Function

    Public Shared Function SortS%(a() As Single, start%, numEls%, dir%)
      Return 0
    End Function

    'Public Shared Function SortC%(a() As Currency, start%, numEls%, dir%)
    '  Return 0
    'End Function

    Public Shared Sub SortStr(a$(), start%, numEls%, dir%)

    End Sub

    Public Shared Sub SortStr2(a$(), start%, numEls%, dir%)

    End Sub

    Public Shared Sub SortT(a() As Object, start%, numEls%, dir%, elSize%, memberOffset%, memberSize%)

    End Sub

    Public Shared Sub SortT2(a() As Object, start%, numEls%, dir%, elSize%, memberOffset%, memberSize%)

    End Sub

  End Class

End Namespace