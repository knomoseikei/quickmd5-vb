Imports System.IO

Public Class MainForm

    Dim dialog As New FolderBrowserDialog

    Private Sub BtnAddFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddFiles.Click
        If dialog.ShowDialog() = DialogResult.OK Then
            'Dim sr As New System.IO.StreamReader(dialog.SelectedPath)
            'MsgBox(dialog.FileName)
            Dim s = ">>>Files in " & dialog.SelectedPath & "<<<"
            Dim di As New DirectoryInfo(dialog.SelectedPath)
            Dim files As FileInfo() = di.GetFiles()
            Dim dra As IO.FileInfo

            lxtBoxFiles.Items.Add(s)
            For Each dra In files
                lxtBoxFiles.Items.Add(dra.Name)
            Next

            ''lxtBoxFiles.Items.Add(dialog.SelectedPath)
            'sr.Close()
        End If
    End Sub

    Private Sub BtnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCheck.Click
        Dim s As String
        s = Directory.GetCurrentDirectory() + vbCrLf
        For i As Integer = 0 To lxtBoxFiles.Items.Count - 1
            s = s + lxtBoxFiles.Items.Item(i)

        Next


        MsgBox(s)
        Shell("C:\Users\Knomo\Documents\Visual Studio 2010\Projects\QuickMd5\QuickMd5\run.bat")

        'Process.Start("cmd", "pause")
    End Sub

    Private Sub BtnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerate.Click
        MsgBox(TxtMd5List.Text)
        Try
            My.Computer.FileSystem.WriteAllText(".\hashlist.md5", TxtMd5List.Text, False)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        ''correr md5sum contra el haslist.md5

    End Sub

    Private Sub lxtBoxFiles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lxtBoxFiles.SelectedIndexChanged

    End Sub
End Class
