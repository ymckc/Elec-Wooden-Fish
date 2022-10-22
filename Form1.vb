Public Class Form1

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim Gongde_Num As Decimal = Label2.Text
        If DomainUpDown1.Text = 1 Then
            Label2.Text = Gongde_Num + 2
        Else
            Label2.Text = Gongde_Num + 1
        End If
        My.Computer.Audio.Play(My.Resources.knock, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        PictureBox1.Image = (My.Resources.img_small)
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        PictureBox1.Image = (My.Resources.img_large)
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked = True Then
            Me.TopMost = True
        End If
        If CheckBox1.Checked = False Then
            Me.TopMost = False
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        MessageBox.Show(text:="仅图一乐，请勿当真。" & Chr(13) & "Code by ymckc", caption:="关于本软件", buttons:=vbOKOnly, icon:=vbInformation)
    End Sub
End Class