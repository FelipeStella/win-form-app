Public Class ModelViewLoginInput

  Private _username As String
  Private _password As String

  Public Property Username() As String
    Get
      Return _username
    End Get
    Set(ByVal value As String)
      _username = value
    End Set
  End Property
  Public Property Password() As String
    Get
      Return _password
    End Get
    Set(ByVal value As String)
      _password = value
    End Set
  End Property

  Public Sub New(ByVal username As String, ByVal password As String)
    _username = username
    _password = password
  End Sub

End Class
