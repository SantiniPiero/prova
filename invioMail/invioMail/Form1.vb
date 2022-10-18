Imports System.Net.Mail
Imports System.Net
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        InviaMail()

    End Sub
    Sub InviaMail()

        Try
            Dim SmtpServer As New SmtpClient("smtps.aruba.it")
            'Dim SmtpServer As New SmtpClient("smtps.libero.it")
            Dim mail As New MailMessage()

            'SmtpServer.Credentials = New Net.NetworkCredential("piero.santini@libero.it", "123Stella!")
            SmtpServer.EnableSsl = True
            SmtpServer.Credentials = New Net.NetworkCredential("psantini@siconsulting.it", "Sicons12072021")
            SmtpServer.Port = 587  '<--------- PORTA PER ARUBA


            'mail.From = New MailAddress("psantini@siconsulting.it")
            mail.From = New MailAddress("psantini@siconsulting.it")
            mail.To.Add("piero.santini@libero.it, psantini@siconsulting.it")

            mail.Body = "pizza"
            mail.IsBodyHtml = True

            mail.Subject = "ATTENZIONE: Riparazioni ___"

            Dim allegato As String
            allegato = ""
            allegato = "C:\app\pc.xlsx"

            If allegato <> "" Then
                Dim attach As Net.Mail.Attachment = New Net.Mail.Attachment(allegato)
                'attach.Name = "filleeee"
                mail.Attachments.Add(attach)
            End If

            SmtpServer.Send(mail)
        Catch ex As Exception
            ex = ex
        End Try
        Dim app As String
        app="SSS"
        app=app


    End Sub
End Class
