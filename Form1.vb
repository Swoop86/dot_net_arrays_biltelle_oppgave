
Public Class Form1

    Dim biler(6) As Integer         'Lager en endimensjonel array for biltyper

    'Lager en populert array for bilnavn
    Dim bilnavn() As String = {"Personbil  ", "Lastebil  ", "Stasjonsvogn  ", "Varebil  ", "Buss  ", "Trailer  ", "Sportsbil  "}

    'Lager en populert array for små og store biler
    Dim gruppenavn() As String = {"Små Biler:  ", "Store Biler:  "}
    Dim gruppe(1) As Integer        'Lager en array for bilgrupper (små og store)
    ' gruppe(0) Små biler, type: 1,3,4 og 7 
    ' gruppe(1) Store biler, type: 2,5 og 6

    Dim totalt As Integer           'Totalt antall biler

    'Populerer arrayene med verdier

    'biler(0)  'Personbil
    Private Sub cmdPersonbil_Click(sender As Object, e As EventArgs) Handles cmdPersonbil.Click
        biler(0) = biler(0) + 1
        gruppe(0) = gruppe(0) + 1

    End Sub

    'biler(1)  'Lastebil
    Private Sub cmdLastebil_Click(sender As Object, e As EventArgs) Handles cmdLastebil.Click
        biler(1) = biler(1) + 1
        gruppe(1) = gruppe(1) + 1
    End Sub

    'biler(2)  'Stasjonsvogn
    Private Sub cmdStasjonsvogn_Click(sender As Object, e As EventArgs) Handles cmdStasjonsvogn.Click
        biler(2) = biler(2) + 1
        gruppe(0) = gruppe(0) + 1
    End Sub

    'biler(3)  'Varebil
    Private Sub cmdVarebil_Click(sender As Object, e As EventArgs) Handles cmdVarebil.Click
        biler(3) = biler(3) + 1
        gruppe(0) = gruppe(0) + 1
    End Sub

    'biler(4)  'Buss
    Private Sub cmdBuss_Click(sender As Object, e As EventArgs) Handles cmdBuss.Click
        biler(4) = biler(4) + 1
        gruppe(1) = gruppe(1) + 1
    End Sub

    'biler(5)  'Trailer
    Private Sub cmdTrailer_Click(sender As Object, e As EventArgs) Handles cmdTrailer.Click
        biler(5) = biler(5) + 1
        gruppe(1) = gruppe(1) + 1
    End Sub

    'biler(6)  'Sportsbil
    Private Sub cmdSportsbil_Click(sender As Object, e As EventArgs) Handles cmdSportsbil.Click
        biler(6) = biler(6) + 1
        gruppe(0) = gruppe(0) + 1
    End Sub

    Private Sub cmdVisListe_Click(sender As Object, e As EventArgs) Handles cmdVisListe.Click
        lstListe.Items.Clear() 'Renser listen for gammel informasjon

        'Populerer listboksen med informasjon hentet fra array
        For i As Integer = 0 To 6
            lstListe.Items.Add(bilnavn(i))
            lstListe.Items.Add(biler(i))
        Next
        'Legger til et mellomrom mellom biltype og gruppe
        lstListe.Items.Add("----------------------")

        For i As Integer = 0 To 1
            lstListe.Items.Add(gruppenavn(i))
            lstListe.Items.Add(gruppe(i))
        Next
        'Henter totalt antall biler som er registrert
        For Each item As Integer In biler
            totalt += item
        Next

        'Populerer listboksen med totalt antall biler
        lstListe.Items.Add("Totalt: " & totalt)

    End Sub
End Class
