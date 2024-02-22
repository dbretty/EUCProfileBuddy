﻿Imports System.IO
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Threading

Module modProfileGeneral

    Public Function GetProfileSize(ByVal path As String, Optional recurse As Boolean = True) As Long
        Dim totalSize As Long = 0

        Try
            Dim files() As String = Directory.GetFiles(path)
            Parallel.For(0, files.Length,
                   Sub(index As Integer)
                       Dim fi As New FileInfo(files(index))
                       Dim size As Long = fi.Length
                       Interlocked.Add(totalSize, size)
                   End Sub)
        Catch ex As Exception
        End Try

        Try
            If recurse Then
                Dim subDirs() As String = Directory.GetDirectories(path)
                Dim subTotal As Long = 0
                Parallel.For(0, subDirs.Length,
                       Function(index As Integer)
                           If (File.GetAttributes(subDirs(index)) And FileAttributes.ReparsePoint) <> FileAttributes.ReparsePoint Then
                               Interlocked.Add(subTotal, GetProfileSize(subDirs(index), True))
                               Return subTotal
                           End If
                           Return 0
                       End Function)
                Interlocked.Add(totalSize, subTotal)
            End If
        Catch ex As Exception
        End Try

        Return totalSize
    End Function

End Module