Imports System.ComponentModel
Imports System.Text


Partial Public Class Form1
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If TextEdit1.Text = "" Or MemoEdit1.Text = "" Then
            MsgBox("Lütfen hız seçin veya yazılacak kelime,cümle,harf Girin.!", MsgBoxStyle.Critical, "Dikkat !")
        Else
            If TextEdit1.Text = "Çok Yavaş" Then
                Timer1.Interval = 700
                Timer1.Start()

            End If
            If TextEdit1.Text = "Yavaş" Then
                Timer1.Interval = 500
                Timer1.Start()
            End If
            If TextEdit1.Text = "Orta" Then
                Timer1.Interval = 450
                Timer1.Start()
            End If
            If TextEdit1.Text = "Hızlı" Then
                Timer1.Interval = 300
                Timer1.Start()
            End If
            If TextEdit1.Text = "Çok Hızlı" Then
                Timer1.Interval = 200
                Timer1.Start()
            End If
            If TextEdit1.Text = "Aşırı Hızlı" Then
                Timer1.Interval = 100
                Timer1.Start()
            End If
        End If
        
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Timer1.Stop()
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.F5) Then
            If TextEdit1.Text = "" Or MemoEdit1.Text = "" Then
                MsgBox("Lütfen hız seçin veya yazılacak kelime,cümle,harf Girin.!", MsgBoxStyle.Critical, "Dikkat !")
            Else
                If TextEdit1.Text = "Çok Yavaş" Then
                    Timer1.Interval = 700
                    Timer1.Start()

                End If
                If TextEdit1.Text = "Yavaş" Then
                    Timer1.Interval = 500
                    Timer1.Start()
                End If
                If TextEdit1.Text = "Orta" Then
                    Timer1.Interval = 450
                    Timer1.Start()
                End If
                If TextEdit1.Text = "Hızlı" Then
                    Timer1.Interval = 300
                    Timer1.Start()
                End If
                If TextEdit1.Text = "Çok Hızlı" Then
                    Timer1.Interval = 200
                    Timer1.Start()
                End If
                If TextEdit1.Text = "Aşırı Hızlı" Then
                    Timer1.Interval = 100
                    Timer1.Start()
                End If
            End If
        End If

        If (e.KeyCode = Keys.F6) Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        SendKeys.Send(MemoEdit1.Text)
        If CheckEdit1.Checked = True Then
            SendKeys.Send("{ENTER}")
        End If

    End Sub
End Class
