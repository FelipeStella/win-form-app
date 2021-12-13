Public Class ValidateFormLogin
  Implements IValidateFormFields

  Public Sub ValidateEmptyFields(obj As Object) Implements IValidateFormFields.ValidateEmptyFields
    If obj.Username = "" Or obj.Password = "" Then
      Throw New Exception("Preencha todos os campos do formulário!")
    End If
  End Sub
End Class
