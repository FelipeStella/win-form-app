Public Class InjectService
  Public Function GetAuthenticationService() As IAuthentication
    Return New Authentication
  End Function

End Class
