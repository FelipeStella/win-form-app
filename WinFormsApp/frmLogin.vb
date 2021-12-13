Public Class frmLogin
  Private ReadOnly _validator As New InjectValidator
  Private ReadOnly _service As New InjectService


  Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
    Try
      Dim login As New ModelViewLoginInput(txtUsername.Text, txtPassword.Text)

      _validator.GetValidateFormLogin.ValidateEmptyFields(login)

      Dim user = _service.GetAuthenticationService.AuthenticationUser(login)

      MsgBox("Bem vindo! " & user.Username, MsgBoxStyle.Information, "Acesso ao Sistema")

    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Information, "Erro")
      txtUsername.Focus()
    End Try

  End Sub

  Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub
End Class