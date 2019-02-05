Public NotInheritable Class Array

  Private Sub New()
  End Sub

  Public Shared Sub Addlnt(ByRef a%(), start%, value%, numEls%)

  End Sub

  Public Shared Sub DeleteStr(ByRef a$(), element%, numEls%)

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

  Public Shared Function Findlast%(a$(), numEls%)
    Return 0
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

  Public Shared Sub InsertStr(a$(), element%, ins$, numEls%)

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


End Class