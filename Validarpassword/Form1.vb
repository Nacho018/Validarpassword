﻿Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TextBox1.MaxLength = 20


    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
       
        If Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True


        End If

    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        Dim min, may, num, x As Integer
        Dim l As String

        For x = 0 To TextBox1.Text.Length - 1


            l = TextBox1.Text.Substring(x, 1)

            If l >= "0" And l <= "9" Then

                num += 1





            End If

            If l >= "a" And l <= "z" Then

                min += 1


            End If


            If l >= "A" And l <= "Z" Then
                may += 1




            End If

            next

            If num < 2 Then

                MsgBox(" ingrese al menos dos numeros ")

                TextBox1.Focus()





            End If



            If min < 2 Then



                MsgBox(" ingrese al menos dos letras minusculas ")

                TextBox1.Focus()

            Exit Sub



            End If
            If may < 2 Then


                MsgBox(" ingrese al menos dos mayusculas ")

                TextBox1.Focus()
            Exit Sub

        End If

        If TextBox1.Text.Length < 8 Then

            MsgBox(" ingrese mas de 8 caracteres ")

            TextBox1.Focus()

            Exit Sub


        End If


        MsgBox(" contraseña correcta ")




    End Sub
End Class
