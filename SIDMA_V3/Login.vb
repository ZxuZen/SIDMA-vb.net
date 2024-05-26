Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Focus()
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" And txtPassword.Text = " " Then
            MsgBox("Username dan Password harus diisi!", MsgBoxStyle.Exclamation, "Isi Username dan Password")
        ElseIf txtUsername.Text = "Admin" And txtPassword.Text = "Admin123" Then
            MsgBox("Login Berhasil!", MsgBoxStyle.Information, "Akses berhasil")
            InputData.Show()
            Me.Hide()
        Else
            MsgBox("Username dan Password salah", MsgBoxStyle.Critical, "Cek Username dan Password")
            clean()
            txtUsername.Focus()
        End If
    End Sub

    Sub clean()
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub cbHide_CheckedChanged(sender As Object, e As EventArgs) Handles cbHide.CheckedChanged
        If cbHide.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
        txtPassword.Focus()
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtUsername.Text = "" And txtPassword.Text = " " Then
                MsgBox("Username dan Password harus diisi!", MsgBoxStyle.Exclamation, "Isi Username dan Password")
            ElseIf txtUsername.Text = "Admin" And txtPassword.Text = "Admin123" Then
                MsgBox("Login Berhasil!", MsgBoxStyle.Information, "Akses berhasil")
                InputData.Show()
                Me.Hide()
            Else
                MsgBox("Username dan Password salah", MsgBoxStyle.Critical, "Cek Username dan Password")
                clean()
                txtUsername.Focus()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clean()
    End Sub
End Class
