Public Class Calculation
    Public Function WriteGetResult(ByVal str) As Decimal
        Return New DataTable().Compute(str, Nothing)
    End Function

End Class
