Option Explicit On
Option Strict On
Option Infer On

Namespace QP

  Public NotInheritable Class Dos

    Private Sub New()
    End Sub

    Public Shared Sub CDir(path As String)
      IO.Directory.SetCurrentDirectory(path)
    End Sub

    Public Shared Sub ClipFile(filename$, newLength&)

    End Sub

    Public Shared Function DCount%(path$)
      ' DCount will report the number of directory names that match a particular specification.
      Return IO.Directory.GetFiles(path$).Count
    End Function

    Public Shared Sub DiskInfo(drive$, byte%, sectors%, freeClusters&, totalClusters&)

    End Sub

    Public Shared Function DiskRoom&(drive$)
      Return 0
    End Function

    Public Shared Function DiskSize&(drive$)
      Return 0
    End Function

    Public Shared Function DOSError%()
      Return 0
    End Function

    Public Shared Function DOSVer%()
      Return 620
    End Function

    Public Shared Function ErrorMsg$(errorNumber%)
      Return Nothing
    End Function

    Public Shared Function EXEName$()
      Return Reflection.Assembly.GetExecutingAssembly().Location
    End Function

    Public Shared Function Exist(filename As String) As Boolean
      If filename.StartsWith("\") Then
        filename = IO.Path.Combine(IO.Directory.GetCurrentDirectory(), filename.Substring(1))
      ElseIf Not filename.Contains("\") Then
        filename = IO.Path.Combine(IO.Directory.GetCurrentDirectory(), filename)
      End If
      Return IO.File.Exists(filename)
    End Function

    Public Shared Function FastLoadInt%(filename$)
      Return 0
    End Function

    Public Shared Sub FastLoadStr(a$())

    End Sub

    Public Shared Sub FastSave(filename$, text$())

    End Sub

    Public Shared Sub FClose(handle As Integer)
      FileSystem.FileClose(handle)
    End Sub

    Public Shared Sub FCopy(source$, dest$, buffer$, errCode%)

    End Sub

    Public Shared Function FCount%(path$)
      ' FCount will report the number of file names that match a particular specification.
      Dim directory As String = path$
      Dim pattern As String = Nothing
      If directory.Contains("\") AndAlso (directory.Contains("*") OrElse directory.Contains("?")) Then
        ' path and pattern
        pattern = directory.Substring(directory.LastIndexOf("\") + 1)
        directory = directory.Substring(0, directory.LastIndexOf("\"))
      ElseIf Not directory.Contains("\") AndAlso (directory.Contains("*") OrElse directory.Contains("?")) Then
        ' pattern only?
        pattern = directory
        directory = IO.Directory.GetCurrentDirectory()
      End If
      If IO.Directory.Exists(directory) Then
        Dim f = IO.Directory.GetFiles(directory, pattern)
        Return f.Count
      Else
        Return -1
      End If
    End Function

    Public Shared Sub FCreate(filename As String)
      Dim fileNumber = FileSystem.FreeFile
      FileSystem.FileOpen(fileNumber, filename, OpenMode.Output, OpenAccess.Default, OpenShare.Default)
      FileSystem.FileClose(fileNumber)
    End Sub

    Public Shared Function FEof%(handle%)
      Return 0
    End Function

    Public Shared Sub FFlush(handle%)

    End Sub

    Public Shared Function FGet(handle As Integer, ByRef value As String) As Integer
      Try
        FileSystem.FileGet(handle, value)
      Catch ex As Exception
        Return 1 ' ???? Not sure what to return.
      End Try
      Return 0 ' ??? Not sure what to return.
    End Function

    Public Shared Sub FGetA(handle%, a() As Object, element%, numBytes%)

    End Sub

    Public Shared Sub FGetAH(filename$, a() As Object, start%, elSize%, numEls%)

    End Sub

    Public Shared Sub FGetR(handle%, destination%, recNumber&)

    End Sub

    Public Shared Sub FGetRT(handle%, destination As Object, recNumber&, recSize%)

    End Sub

    Public Shared Sub FGetRTA(handle%, destination() As Object, recNumber&, recSize%)

    End Sub

    Public Shared Sub FGetT(handle%, destination As Object, numBytes%)

    End Sub

    Public Shared Function FileComp%(file1$, file2$, errCode%)
      Return 0
    End Function

    Public Shared Sub FileCopy(source$, dest$, copied%, errCode%)
      IO.File.Copy(source, dest)
    End Sub

    Public Shared Sub FileCrypt(filename$, password$)

    End Sub

    Public Structure FInfo
      Public Year As Integer
      Public Month As Integer
      Public Day As Integer
      Public Hour As Integer
      Public Minute As Integer
      Public Second As Integer
      Public Size As Long
      Public Attrib As Integer
    End Structure

    Public Shared Sub FileInfo(fileName$, ByRef typeVar As FInfo)
      Dim fi = New IO.FileInfo(fileName)
      typeVar.Year = fi.LastWriteTime.Year
      typeVar.Month = fi.LastWriteTime.Month
      typeVar.Day = fi.LastWriteTime.Day
      typeVar.Hour = fi.LastWriteTime.Hour
      typeVar.Minute = fi.LastWriteTime.Minute
      typeVar.Second = fi.LastWriteTime.Second
      typeVar.Size = fi.Length
      typeVar.Attrib = fi.Attributes
    End Sub

    Public Shared Function FileSize(path As String) As Long
      If IO.File.Exists(path) Then
        Dim fi As New IO.FileInfo(path)
        Return fi.Length
      Else
        Return -1
      End If
    End Function

    Public Shared Sub FileSort(dataFile$, indexFile$, first&, last&, table%(), recLength%)

    End Sub

    Public Shared Function FLInput$(handle%, buffer$)
      Return Nothing
    End Function

    Public Shared Function FLoc&(handle%)
      Return 0
    End Function

    Public Shared Function FLof&(handle%)
      Return 0
    End Function

    Public Shared Sub FOpen(filename As String, ByRef handle As Integer)
      ' QuickPAK
      If IO.File.Exists(filename) Then
        handle = FileSystem.FreeFile()
        FileSystem.FileOpen(handle, filename, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
      Else
        handle = -1
      End If
    End Sub

    Public Shared Sub FileOpenS(filename$, handle%)

    End Sub

    Public Shared Sub FOpenAll(FileName$, AccessMode%, SharedMode%, ByRef Handle%)

      Dim access As OpenAccess
      Dim share As OpenShare

      Select Case AccessMode%
        Case 0 ' Read
          access = OpenAccess.Read
        Case 1 ' Write
          access = OpenAccess.Write
        Case 2 ' Read Write
          access = OpenAccess.ReadWrite
      End Select

      Select Case SharedMode%
        Case 0 ' Deny sharing access (compatibility mode)
          share = OpenShare.Default
        Case 1 ' Deny read/write access
          share = OpenShare.LockReadWrite
        Case 2 ' Deny write access
          share = OpenShare.LockWrite
        Case 3 ' Deny read access
          share = OpenShare.LockRead
        Case 4 ' Deny none (full share mode)
          share = OpenShare.Shared
      End Select

      Handle% = FileSystem.FreeFile
      FileSystem.FileOpen(Handle%, FileName$, OpenMode.Binary, access, share)

    End Sub

    Public Shared Function FormatDiskette%(driveNumber%, capacity%, bufArray%())
      Return 0
    End Function

    Public Shared Sub FPut(handle As Integer, source As String)
      ' QuickPAK
      Try
        FileSystem.FilePut(handle, source)
      Catch ex As Exception
        ' Not sure what should take place here...
      End Try
    End Sub

    Public Shared Sub FPutA(handle%, a() As Object, start%, numBytes%)

    End Sub

    Public Shared Sub FPutAH(filename$, a() As Object, start%, elSize%, numEls%)

    End Sub

    Public Shared Sub FPutR(handle%, source$, recNumber&)

    End Sub

    Public Shared Sub FPutRT(handle%, source As Object, recNumber&, recSize%)

    End Sub

    Public Shared Sub FPutRTA(handle%, source() As Object, recNumber&, recSize%)

    End Sub

    Public Shared Sub FPutT(handle%, source As Object, numBytes%)

    End Sub

    Public Shared Sub FSeek(handle%, location&)

    End Sub

    Public Shared Sub FStamp(filename$, newTime$, newDate$)

    End Sub

    Public Shared Function FullName$(partName$)
      Return Nothing
    End Function

    Public Shared Function GetAttr%(filename$)
      Return 0
    End Function

    Public Shared Function GetDir(drive As String) As String
      ' QuickPAK
      Return IO.Path.GetFullPath(My.Application.Info.DirectoryPath).Substring(2)
    End Function

    Public Shared Function GetDisketteType%(driveNumber%)
      Return 0
    End Function

    Public Shared Function GetDrive() As Integer
      ' QuickPAK
      Return Asc(IO.Path.GetPathRoot(My.Application.Info.DirectoryPath).Substring(0, 1))
    End Function

    Public Shared Function GetVol$(Drive$)
      Return Dir("C:\", FileAttribute.Volume)
    End Function

    Public Shared Function GoodDrive(drive As String) As Boolean
      ' QuickPAK
      If IO.Directory.Exists($"{drive}:\") Then
        Return True
      Else
        Return False
      End If
    End Function

    Public Structure FName
      Public FileName As String
      Public Extension As String
    End Structure

    Public Shared Sub Handle2Name(handle%, filename As FName)

    End Sub

    Public Shared Sub KillDir(dirName$)

    End Sub

    Public Shared Sub KillFile(filename As String)
      If filename Is Nothing Then Return
      If filename.StartsWith("\") Then
        filename = IO.Path.Combine(IO.Directory.GetCurrentDirectory(), filename.Substring(1))
      ElseIf Not filename.Contains("\") Then
        filename = IO.Path.Combine(IO.Directory.GetCurrentDirectory(), filename)
      End If
      If IO.File.Exists(filename) Then
        IO.File.Delete(filename)
      End If
    End Sub

    Public Shared Function LastDrive%()
      Return 0
    End Function

    Public Shared Function LineCount%(filename$, buffer$)
      Return 0
    End Function

    Public Shared Function LoadExec%(program$, cmdLine$)
      Return 0
    End Function

    Public Shared Sub LockFile(handle%, offset&, length&)

    End Sub

    Public Shared Sub MakeDir(directory As String)
      IO.Directory.CreateDirectory(directory)
    End Sub

    Public Shared Sub NameDir(oldName$, newName$)

    End Sub

    Public Shared Sub NameFile(oldName$, newName$)

    End Sub

    Public Shared Function NetDrive%(drive$)
      Return 0
    End Function

    Public Shared Sub PutVol(drive$, label$)

    End Sub

    Public Shared Sub QBLoad(filename$, array%(), element%)

    End Sub

    Public Shared Sub QBLoad(filename$, segment%, address%)

    End Sub

    Public Shared Sub QBSave(filename$, array%(), element%, numBytes%)

    End Sub

    Public Shared Sub QBSave(filename$, segment%, address%, numBytes%)

    End Sub

    Public Shared Sub ReadDir(array$())

    End Sub

    Public Shared Sub ReadDirT(spec$, array$())

    End Sub

    Public Shared Sub ReadDirT(spec$, array() As Object)

    End Sub

    Public Shared Sub ReadFile(ByRef arry$())

      ' ReadFile obtains a list of file names from disk, and loads them into a conventional (not fixed-length) string array in one operatio

      Dim directory As String = arry$(0)
      Dim pattern As String = Nothing
      If (directory.Contains("*") OrElse directory.Contains("?")) Then
        pattern = directory.Substring(directory.LastIndexOf("\") + 1)
        directory = directory.Substring(0, directory.LastIndexOf("\"))
      End If

      Dim result = IO.Directory.GetFiles(directory, pattern)
      ReDim arry(result.Count)
      Dim index = 1
      For Each value In result
        arry(index) = IO.Path.GetFileName(value).PadRight(12)
        index += 1
      Next

    End Sub

    Public Shared Sub ReadFileI(array$())

    End Sub

    Public Shared Sub ReadFileT(spec$, array() As Object)

    End Sub

    Public Shared Sub REadFileX(spec$, dirSize&, array() As Object)

    End Sub

    Public Shared Sub ReadSect(drive$, info$, sector%)

    End Sub

    Public Shared Function ReadTest%(drive$)
      Return 0
    End Function

    Public Shared Function Removable%(drive$)
      Return 0
    End Function

    Public Shared Function ScanFile&(filename$, text$, start&)
      Return 0
    End Function

    Public Shared Function SearchPath$(filename$)
      Return Nothing
    End Function

    Public Shared Sub SetAttr(filename$, attribute%)

    End Sub

    Public Shared Sub SetCmd(newCommand$)

    End Sub

    Public Shared Sub SetDrive(drive As String)
      ' QuickPAK
      IO.Directory.SetCurrentDirectory(drive & ":")
    End Sub

    Public Shared Sub SetError(errCode%)

    End Sub

    Public Shared Sub SetLevel(errValue%)

    End Sub

    Public Shared Function ShareThere%()
      Return 0
    End Function

    Public Shared Sub SplitName(workName As String, ByRef drive As String, ByRef path As String, ByRef filename As String, ByRef ext As String)
      ' QuickPAK
      'NOTES: WorkName$ is a complete file name such as "C: \MYPATH\ YOURPATH\MYFILE.EXT". 
      '       SplitName then returns Drive$ as "C:", Path$ as "\MYPATH\YOURPATH\", 
      '       FileName$ as "MYFILE", and Extension$ as ".EXT". 
      If workName.Contains(":") Then
        drive = IO.Path.GetPathRoot(workName).Substring(0, 2)
      End If
      If workName.Contains("\") Then
        path = "\" & IO.Path.GetDirectoryName(workName).Substring(3) & "\"
      End If
      filename = IO.Path.GetFileNameWithoutExtension(workName)
      ext = IO.Path.GetExtension(workName)
    End Sub

    Public Shared Function Unique$(path$)
      Return Nothing
    End Function

    Public Shared Sub UnLockFile(handle%, offset%, length&)

    End Sub

    Public Shared Function Valid%(filename$)
      Return 0
    End Function

    Public Shared Function WhichError%()
      Return 0
    End Function

    Public Shared Sub WriteSect(drive$, info$, sector%)

    End Sub

    Public Shared Sub WriteSect2(drive$, info$, sector%)

    End Sub

    Public Shared Function WriteTest%(drive$)
      Return 0
    End Function

  End Class

End Namespace