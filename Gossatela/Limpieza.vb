Imports Gossatela

Public Interface ILimpieza
    Function Limpiar() As String
End Interface

Public Class Limpiando
    Implements ILimpieza
    Public Function Limpiar() As String Implements ILimpieza.Limpiar
        Return ("")
    End Function
End Class
