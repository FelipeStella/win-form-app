Public Class User
  Private _username As String

  Private _password As String

  Public Sub New(ByVal username As String, ByVal password As String)
    _username = username
    _password = password
  End Sub

  Public Property Username As String
    Get
      Return _username
    End Get
    Set(value As String)
      _username = value
    End Set
  End Property

  Public Property Password As String
    Get
      Return _password
    End Get
    Set(value As String)
      _password = value
    End Set
  End Property
End Class
