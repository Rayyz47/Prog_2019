Imports Dll_cSharpe
Public Class Form1
    'Utilise la dll en csharpe pour encoder le texte
    Private Sub btnCrypt_Click(sender As Object, e As EventArgs) Handles btnCrypt.Click
        'Instancier la DLL scharpe
        Dim dll As New DLL()
        'retourne le texter crypter
        txtResult.Text = dll.cryptSimple(txtText.Text)
        'Nettoye le texte entrer
        txtText.Text = ""
    End Sub

    Private Sub btnUnCrypt_Click(sender As Object, e As EventArgs) Handles btnUnCrypt.Click
        'Instancier la DLL scharpe
        Dim dll As New DLL()
        'retourne le texter decrypter
        txtResult.Text = dll.unCryptSimple(txtText.Text)
        'Nettoye le texte entrer
        txtText.Text = ""
    End Sub
End Class
