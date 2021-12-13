Public Class Authentication
  Implements IAuthentication

  Private ReadOnly _repository As New InjectRepository

  Private Function AuthenticationUser(modelViewLoginInput As ModelViewLoginInput) As User Implements IAuthentication.AuthenticationUser
    Dim user = _repository.GetUserRepository.GetUserByUsername(modelViewLoginInput.Username)
    Return user
  End Function
End Class
