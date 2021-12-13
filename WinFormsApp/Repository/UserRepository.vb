Public Class UserRepository
  Implements IUserRepository

  Private Function IUserRepository_GetUserByUsername(username As String) As User Implements IUserRepository.GetUserByUsername
    Dim user As New User(username, "teste")
    Return user
  End Function
End Class
