Public Class InjectRepository
  Public Function GetUserRepository() As IUserRepository
    Return New UserRepository
  End Function

End Class
