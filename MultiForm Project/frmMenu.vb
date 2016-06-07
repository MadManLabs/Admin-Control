Public Class frmMenu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub cmbList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbList.SelectedIndexChanged
        If cmbList.SelectedItem = "Display Properties" Then
            Process.Start("C:\Windows\System32\cmd.exe", String.Format("/c  control desk.cpl"))

        ElseIf cmbList.SelectedItem = "Accessibility Options" Then
            Process.Start("C:\Windows\System32\cmd.exe", String.Format("/c  control access.cpl"))

        ElseIf cmbList.SelectedItem = "Add/Remove Programs" Then
            Process.Start("C:\Windows\System32\cmd.exe", String.Format("/c  control appwiz.cpl"))

        ElseIf cmbList.SelectedItem = "Date/Time Properties" Then
            Process.Start("C:\Windows\System32\cmd.exe", String.Format("/c  control timedate.cpl"))

        ElseIf cmbList.SelectedItem = "Internet Properties" Then
            Process.Start("C:\Windows\System32\cmd.exe", String.Format("/c  control inetcpl.cpl"))

        ElseIf cmbList.SelectedItem = "Mouse Properties" Then
            Process.Start("C:\Windows\System32\cmd.exe", String.Format("/c  control main.cpl"))

        ElseIf cmbList.SelectedItem = "Network Properties" Then
            Process.Start("C:\Windows\System32\cmd.exe", String.Format("/c  control Ncpa.cpl"))

        ElseIf cmbList.SelectedItem = "Sound Properties" Then
            Process.Start("C:\Windows\System32\cmd.exe", String.Format("/c  control mmsys.cpl sounds"))

        ElseIf cmbList.SelectedItem = "System Properties" Then
            Process.Start("C:\Windows\System32\cmd.exe", String.Format("/c  control sysdm.cpl"))


        ElseIf cmbList.SelectedItem = "Printers Folder" Then
            Process.Start("C:\Windows\System32\cmd.exe", String.Format("/c  control printers"))

        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub btnCMD_Click(sender As Object, e As EventArgs) Handles btnCMD.Click
        Process.Start("CMD.exe", String.Format("/k cd c:\"))
    End Sub

    Private Sub btnMSTSC_Click(sender As Object, e As EventArgs) Handles btnMSTSC.Click
        Process.Start("mstsc.exe")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class