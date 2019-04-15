Public Class Class1
    'Exemple de constante public 
    Public Const exempleConstante = "Alexis est vraiment trop bon"
    Public Const DayInYear = 365
    Public Const DayInWeek = 7
    Public Const SomeonePretty = "Alexis"

    'retourne le resultat d'une addition
    Public Function add(nb1 As Decimal, nb2 As Decimal) As Decimal
        Return nb1 + nb2
    End Function
    'retourne le resultat d'une sustraction
    Public Function sustrac(nb1 As Decimal, nb2 As Decimal) As Decimal
        Return nb1 - nb2
    End Function
    'retourne le resultat d'une multiplication
    Public Function multi(nb1 As Decimal, nb2 As Decimal) As Decimal
        Return nb1 * nb2
    End Function

End Class
