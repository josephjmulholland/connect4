Class MainWindow

    Dim columnOne As Integer = 0
    Dim columnTwo As Integer = 0
    Dim columnThree As Integer = 0
    Dim columnFour As Integer = 0
    Dim columnFive As Integer = 0
    Dim columnSix As Integer = 0
    Dim columnSeven As Integer = 0
    Dim playerOne As Boolean = True

    Private Sub eli1_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli1.MouseLeftButtonDown
        placeColumnOne()
    End Sub
    Private Sub eli2_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli2.MouseLeftButtonDown
        placeColumnTwo()
    End Sub
    Private Sub eli3_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli3.MouseLeftButtonDown
        placeColumnThree()
    End Sub
    Private Sub eli4_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli4.MouseLeftButtonDown
        placeColumnFour()
    End Sub
    Private Sub eli5_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli5.MouseLeftButtonDown
        placeColumnFive()
    End Sub
    Private Sub eli6_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli6.MouseLeftButtonDown
        placeColumnSix()
    End Sub
    Private Sub eli7_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli7.MouseLeftButtonDown
        placeColumnSeven()
    End Sub
    Private Sub eli8_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli8.MouseLeftButtonDown
        placeColumnOne()
    End Sub
    Private Sub eli9_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli9.MouseLeftButtonDown
        placeColumnTwo()
    End Sub
    Private Sub eli10_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli10.MouseLeftButtonDown
        placeColumnThree()
    End Sub
    Private Sub eli11_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli11.MouseLeftButtonDown
        placeColumnFour()
    End Sub
    Private Sub eli12_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli12.MouseLeftButtonDown
        placeColumnFive()
    End Sub
    Private Sub eli13_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli13.MouseLeftButtonDown
        placeColumnSix()
    End Sub
    Private Sub eli14_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli14.MouseLeftButtonDown
        placeColumnSeven()
    End Sub
    Private Sub eli15_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli15.MouseLeftButtonDown
        placeColumnOne()
    End Sub
    Private Sub eli16_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli16.MouseLeftButtonDown
        placeColumnTwo()
    End Sub
    Private Sub eli17_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli17.MouseLeftButtonDown
        placeColumnThree()
    End Sub
    Private Sub eli18_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli18.MouseLeftButtonDown
        placeColumnFour()
    End Sub
    Private Sub eli19_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli19.MouseLeftButtonDown
        placeColumnFive()
    End Sub
    Private Sub eli20_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli20.MouseLeftButtonDown
        placeColumnSix()
    End Sub
    Private Sub eli21_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli21.MouseLeftButtonDown
        placeColumnSeven()
    End Sub
    Private Sub eli22_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli22.MouseLeftButtonDown
        placeColumnOne()
    End Sub
    Private Sub eli23_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli23.MouseLeftButtonDown
        placeColumnTwo()
    End Sub
    Private Sub eli24_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli24.MouseLeftButtonDown
        placeColumnThree()
    End Sub
    Private Sub eli25_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli25.MouseLeftButtonDown
        placeColumnFour()
    End Sub
    Private Sub eli26_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli26.MouseLeftButtonDown
        placeColumnFive()
    End Sub
    Private Sub eli27_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli27.MouseLeftButtonDown
        placeColumnSix()
    End Sub
    Private Sub eli28_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli28.MouseLeftButtonDown
        placeColumnSeven()
    End Sub
    Private Sub eli29_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli29.MouseLeftButtonDown
        placeColumnOne()
    End Sub
    Private Sub eli30_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli30.MouseLeftButtonDown
        placeColumnTwo()
    End Sub
    Private Sub eli31_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli31.MouseLeftButtonDown
        placeColumnThree()
    End Sub
    Private Sub eli32_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli32.MouseLeftButtonDown
        placeColumnFour()
    End Sub
    Private Sub eli33_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli33.MouseLeftButtonDown
        placeColumnFive()
    End Sub
    Private Sub eli34_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli34.MouseLeftButtonDown
        placeColumnSix()
    End Sub
    Private Sub eli35_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli35.MouseLeftButtonDown
        placeColumnSeven()
    End Sub
    Private Sub eli36_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli36.MouseLeftButtonDown
        placeColumnOne()
    End Sub
    Private Sub eli37_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli37.MouseLeftButtonDown
        placeColumnTwo()
    End Sub
    Private Sub eli38_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli38.MouseLeftButtonDown
        placeColumnThree()
    End Sub
    Private Sub eli39_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli39.MouseLeftButtonDown
        placeColumnFour()
    End Sub
    Private Sub eli40_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli40.MouseLeftButtonDown
        placeColumnFive()
    End Sub
    Private Sub eli41_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli41.MouseLeftButtonDown
        placeColumnSix()
    End Sub
    Private Sub eli42_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles eli42.MouseLeftButtonDown
        placeColumnSeven()
    End Sub

    Private Sub placeColumnOne()
        columnOne += 1
        If playerOne = True Then 'PLAYER ONE'S TURN (RED)
            playerOne = False
            If columnOne = 1 Then
                eli36.Fill = Brushes.Red
            ElseIf columnOne = 2 Then
                eli29.Fill = Brushes.Red
            ElseIf columnOne = 3 Then
                eli22.Fill = Brushes.Red
            ElseIf columnOne = 4 Then
                eli15.Fill = Brushes.Red
            ElseIf columnOne = 5 Then
                eli8.Fill = Brushes.Red
            ElseIf columnOne = 6 Then
                eli1.Fill = Brushes.Red
            End If
        Else 'PLAYER TWO'S TURN (BLACK)
            playerOne = True
            If columnOne = 1 Then
                eli36.Fill = Brushes.Black
            ElseIf columnOne = 2 Then
                eli29.Fill = Brushes.Black
            ElseIf columnOne = 3 Then
                eli22.Fill = Brushes.Black
            ElseIf columnOne = 4 Then
                eli15.Fill = Brushes.Black
            ElseIf columnOne = 5 Then
                eli8.Fill = Brushes.Black
            ElseIf columnOne = 6 Then
                eli1.Fill = Brushes.Black
            End If
        End If
    End Sub

    Private Sub placeColumnTwo()
        columnTwo += 1
        If playerOne = True Then 'PLAYER ONE'S TURN (RED)
            playerOne = False
            If columnTwo = 1 Then
                eli37.Fill = Brushes.Red
            ElseIf columnTwo = 2 Then
                eli30.Fill = Brushes.Red
            ElseIf columnTwo = 3 Then
                eli23.Fill = Brushes.Red
            ElseIf columnTwo = 4 Then
                eli16.Fill = Brushes.Red
            ElseIf columnTwo = 5 Then
                eli9.Fill = Brushes.Red
            ElseIf columnTwo = 6 Then
                eli2.Fill = Brushes.Red
            End If
        Else 'PLAYER TWO'S TURN (BLACK)
            playerOne = True
            If columnTwo = 1 Then
                eli37.Fill = Brushes.Black
            ElseIf columnTwo = 2 Then
                eli30.Fill = Brushes.Black
            ElseIf columnTwo = 3 Then
                eli23.Fill = Brushes.Black
            ElseIf columnTwo = 4 Then
                eli16.Fill = Brushes.Black
            ElseIf columnTwo = 5 Then
                eli9.Fill = Brushes.Black
            ElseIf columnTwo = 6 Then
                eli2.Fill = Brushes.Black
            End If
        End If
    End Sub

    Private Sub placeColumnThree()
        columnThree += 1
        If playerOne = True Then 'PLAYER ONE'S TURN (RED)
            playerOne = False
            If columnThree = 1 Then
                eli38.Fill = Brushes.Red
            ElseIf columnThree = 2 Then
                eli31.Fill = Brushes.Red
            ElseIf columnThree = 3 Then
                eli24.Fill = Brushes.Red
            ElseIf columnThree = 4 Then
                eli17.Fill = Brushes.Red
            ElseIf columnThree = 5 Then
                eli10.Fill = Brushes.Red
            ElseIf columnThree = 6 Then
                eli3.Fill = Brushes.Red
            End If
        Else 'PLAYER TWO'S TURN (BLACK)
            playerOne = True
            If columnThree = 1 Then
                eli38.Fill = Brushes.Black
            ElseIf columnThree = 2 Then
                eli31.Fill = Brushes.Black
            ElseIf columnThree = 3 Then
                eli24.Fill = Brushes.Black
            ElseIf columnThree = 4 Then
                eli17.Fill = Brushes.Black
            ElseIf columnThree = 5 Then
                eli10.Fill = Brushes.Black
            ElseIf columnThree = 6 Then
                eli3.Fill = Brushes.Black
            End If
        End If
    End Sub

    Private Sub placeColumnFour()
        columnFour += 1
        If playerOne = True Then 'PLAYER ONE'S TURN (RED)
            playerOne = False
            If columnFour = 1 Then
                eli39.Fill = Brushes.Red
            ElseIf columnFour = 2 Then
                eli32.Fill = Brushes.Red
            ElseIf columnFour = 3 Then
                eli25.Fill = Brushes.Red
            ElseIf columnFour = 4 Then
                eli18.Fill = Brushes.Red
            ElseIf columnFour = 5 Then
                eli11.Fill = Brushes.Red
            ElseIf columnFour = 6 Then
                eli4.Fill = Brushes.Red
            End If
        Else 'PLAYER TWO'S TURN (BLACK)
            playerOne = True
            If columnFour = 1 Then
                eli39.Fill = Brushes.Black
            ElseIf columnFour = 2 Then
                eli32.Fill = Brushes.Black
            ElseIf columnFour = 3 Then
                eli25.Fill = Brushes.Black
            ElseIf columnFour = 4 Then
                eli18.Fill = Brushes.Black
            ElseIf columnFour = 5 Then
                eli11.Fill = Brushes.Black
            ElseIf columnFour = 6 Then
                eli4.Fill = Brushes.Black
            End If
        End If
    End Sub

    Private Sub placeColumnFive()
        columnFive += 1
        If playerOne = True Then 'PLAYER ONE'S TURN (RED)
            playerOne = False
            If columnFive = 1 Then
                eli40.Fill = Brushes.Red
            ElseIf columnFive = 2 Then
                eli33.Fill = Brushes.Red
            ElseIf columnFive = 3 Then
                eli26.Fill = Brushes.Red
            ElseIf columnFive = 4 Then
                eli19.Fill = Brushes.Red
            ElseIf columnFive = 5 Then
                eli12.Fill = Brushes.Red
            ElseIf columnFive = 6 Then
                eli5.Fill = Brushes.Red
            End If
        Else 'PLAYER TWO'S TURN (BLACK)
            playerOne = True
            If columnFive = 1 Then
                eli40.Fill = Brushes.Black
            ElseIf columnFive = 2 Then
                eli33.Fill = Brushes.Black
            ElseIf columnFive = 3 Then
                eli26.Fill = Brushes.Black
            ElseIf columnFive = 4 Then
                eli19.Fill = Brushes.Black
            ElseIf columnFive = 5 Then
                eli12.Fill = Brushes.Black
            ElseIf columnFive = 6 Then
                eli5.Fill = Brushes.Black
            End If
        End If
    End Sub

    Private Sub placeColumnSix()
        columnSix += 1
        If playerOne = True Then 'PLAYER ONE'S TURN (RED)
            playerOne = False
            If columnSix = 1 Then
                eli41.Fill = Brushes.Red
            ElseIf columnSix = 2 Then
                eli34.Fill = Brushes.Red
            ElseIf columnSix = 3 Then
                eli27.Fill = Brushes.Red
            ElseIf columnSix = 4 Then
                eli20.Fill = Brushes.Red
            ElseIf columnSix = 5 Then
                eli13.Fill = Brushes.Red
            ElseIf columnSix = 6 Then
                eli6.Fill = Brushes.Red
            End If
        Else 'PLAYER TWO'S TURN (BLACK)
            playerOne = True
            If columnSix = 1 Then
                eli41.Fill = Brushes.Black
            ElseIf columnSix = 2 Then
                eli34.Fill = Brushes.Black
            ElseIf columnSix = 3 Then
                eli27.Fill = Brushes.Black
            ElseIf columnSix = 4 Then
                eli20.Fill = Brushes.Black
            ElseIf columnSix = 5 Then
                eli13.Fill = Brushes.Black
            ElseIf columnSix = 6 Then
                eli6.Fill = Brushes.Black
            End If
        End If
    End Sub

    Private Sub placeColumnSeven()
        columnSeven += 1
        If playerOne = True Then 'PLAYER ONE'S TURN (RED)
            playerOne = False
            If columnSeven = 1 Then
                eli42.Fill = Brushes.Red
            ElseIf columnSeven = 2 Then
                eli35.Fill = Brushes.Red
            ElseIf columnSeven = 3 Then
                eli28.Fill = Brushes.Red
            ElseIf columnSeven = 4 Then
                eli21.Fill = Brushes.Red
            ElseIf columnSeven = 5 Then
                eli14.Fill = Brushes.Red
            ElseIf columnSeven = 6 Then
                eli7.Fill = Brushes.Red
            End If
        Else 'PLAYER TWO'S TURN (BLACK)
            playerOne = True
            If columnSeven = 1 Then
                eli42.Fill = Brushes.Black
            ElseIf columnSeven = 2 Then
                eli35.Fill = Brushes.Black
            ElseIf columnSeven = 3 Then
                eli28.Fill = Brushes.Black
            ElseIf columnSeven = 4 Then
                eli21.Fill = Brushes.Black
            ElseIf columnSeven = 5 Then
                eli14.Fill = Brushes.Black
            ElseIf columnSeven = 6 Then
                eli7.Fill = Brushes.Black
            End If
        End If
    End Sub

    Private Sub Grid_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs)

        If columnOne >= 6 Then
            eli1.IsEnabled = False
            eli8.IsEnabled = False
            eli15.IsEnabled = False
            eli22.IsEnabled = False
            eli29.IsEnabled = False
            eli36.IsEnabled = False
        ElseIf columnTwo >= 6 Then
            eli2.IsEnabled = False
            eli9.IsEnabled = False
            eli16.IsEnabled = False
            eli23.IsEnabled = False
            eli30.IsEnabled = False
            eli37.IsEnabled = False
        ElseIf columnThree >= 6 Then
            eli3.IsEnabled = False
            eli10.IsEnabled = False
            eli17.IsEnabled = False
            eli24.IsEnabled = False
            eli31.IsEnabled = False
            eli38.IsEnabled = False
        ElseIf columnFour >= 6 Then
            eli4.IsEnabled = False
            eli11.IsEnabled = False
            eli18.IsEnabled = False
            eli25.IsEnabled = False
            eli32.IsEnabled = False
            eli39.IsEnabled = False
        ElseIf columnFive >= 6 Then
            eli5.IsEnabled = False
            eli12.IsEnabled = False
            eli19.IsEnabled = False
            eli26.IsEnabled = False
            eli33.IsEnabled = False
            eli40.IsEnabled = False
        ElseIf columnSix >= 6 Then
            eli6.IsEnabled = False
            eli13.IsEnabled = False
            eli20.IsEnabled = False
            eli27.IsEnabled = False
            eli34.IsEnabled = False
            eli41.IsEnabled = False
        ElseIf columnSeven >= 6 Then
            eli7.IsEnabled = False
            eli14.IsEnabled = False
            eli21.IsEnabled = False
            eli28.IsEnabled = False
            eli35.IsEnabled = False
            eli42.IsEnabled = False
        Else
            My.Computer.Audio.Play(My.Resources.checkerDrop, AudioPlayMode.Background)
        End If

        If eli42.Fill.Equals(Brushes.Red) AndAlso eli35.Fill.Equals(Brushes.Red) AndAlso eli28.Fill.Equals(Brushes.Red) AndAlso eli21.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli42.Fill.Equals(Brushes.Red) AndAlso eli34.Fill.Equals(Brushes.Red) AndAlso eli26.Fill.Equals(Brushes.Red) AndAlso eli18.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli42.Fill.Equals(Brushes.Red) AndAlso eli41.Fill.Equals(Brushes.Red) AndAlso eli40.Fill.Equals(Brushes.Red) AndAlso eli39.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli41.Fill.Equals(Brushes.Red) AndAlso eli34.Fill.Equals(Brushes.Red) AndAlso eli27.Fill.Equals(Brushes.Red) AndAlso eli20.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli41.Fill.Equals(Brushes.Red) AndAlso eli33.Fill.Equals(Brushes.Red) AndAlso eli25.Fill.Equals(Brushes.Red) AndAlso eli17.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli41.Fill.Equals(Brushes.Red) AndAlso eli40.Fill.Equals(Brushes.Red) AndAlso eli39.Fill.Equals(Brushes.Red) AndAlso eli38.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli40.Fill.Equals(Brushes.Red) AndAlso eli33.Fill.Equals(Brushes.Red) AndAlso eli26.Fill.Equals(Brushes.Red) AndAlso eli19.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli40.Fill.Equals(Brushes.Red) AndAlso eli32.Fill.Equals(Brushes.Red) AndAlso eli24.Fill.Equals(Brushes.Red) AndAlso eli16.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli40.Fill.Equals(Brushes.Red) AndAlso eli39.Fill.Equals(Brushes.Red) AndAlso eli38.Fill.Equals(Brushes.Red) AndAlso eli37.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli39.Fill.Equals(Brushes.Red) AndAlso eli32.Fill.Equals(Brushes.Red) AndAlso eli25.Fill.Equals(Brushes.Red) AndAlso eli18.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli39.Fill.Equals(Brushes.Red) AndAlso eli31.Fill.Equals(Brushes.Red) AndAlso eli23.Fill.Equals(Brushes.Red) AndAlso eli15.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli39.Fill.Equals(Brushes.Red) AndAlso eli33.Fill.Equals(Brushes.Red) AndAlso eli27.Fill.Equals(Brushes.Red) AndAlso eli21.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli39.Fill.Equals(Brushes.Red) AndAlso eli38.Fill.Equals(Brushes.Red) AndAlso eli37.Fill.Equals(Brushes.Red) AndAlso eli36.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli39.Fill.Equals(Brushes.Red) AndAlso eli40.Fill.Equals(Brushes.Red) AndAlso eli41.Fill.Equals(Brushes.Red) AndAlso eli42.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli38.Fill.Equals(Brushes.Red) AndAlso eli39.Fill.Equals(Brushes.Red) AndAlso eli40.Fill.Equals(Brushes.Red) AndAlso eli41.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli38.Fill.Equals(Brushes.Red) AndAlso eli31.Fill.Equals(Brushes.Red) AndAlso eli24.Fill.Equals(Brushes.Red) AndAlso eli17.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli38.Fill.Equals(Brushes.Red) AndAlso eli32.Fill.Equals(Brushes.Red) AndAlso eli26.Fill.Equals(Brushes.Red) AndAlso eli20.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli37.Fill.Equals(Brushes.Red) AndAlso eli31.Fill.Equals(Brushes.Red) AndAlso eli25.Fill.Equals(Brushes.Red) AndAlso eli19.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli37.Fill.Equals(Brushes.Red) AndAlso eli38.Fill.Equals(Brushes.Red) AndAlso eli39.Fill.Equals(Brushes.Red) AndAlso eli40.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli37.Fill.Equals(Brushes.Red) AndAlso eli30.Fill.Equals(Brushes.Red) AndAlso eli23.Fill.Equals(Brushes.Red) AndAlso eli16.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli36.Fill.Equals(Brushes.Red) AndAlso eli37.Fill.Equals(Brushes.Red) AndAlso eli38.Fill.Equals(Brushes.Red) AndAlso eli39.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli36.Fill.Equals(Brushes.Red) AndAlso eli29.Fill.Equals(Brushes.Red) AndAlso eli22.Fill.Equals(Brushes.Red) AndAlso eli15.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli36.Fill.Equals(Brushes.Red) AndAlso eli30.Fill.Equals(Brushes.Red) AndAlso eli24.Fill.Equals(Brushes.Red) AndAlso eli18.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli35.Fill.Equals(Brushes.Red) AndAlso eli28.Fill.Equals(Brushes.Red) AndAlso eli21.Fill.Equals(Brushes.Red) AndAlso eli14.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli35.Fill.Equals(Brushes.Red) AndAlso eli27.Fill.Equals(Brushes.Red) AndAlso eli19.Fill.Equals(Brushes.Red) AndAlso eli11.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli35.Fill.Equals(Brushes.Red) AndAlso eli34.Fill.Equals(Brushes.Red) AndAlso eli33.Fill.Equals(Brushes.Red) AndAlso eli32.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli34.Fill.Equals(Brushes.Red) AndAlso eli27.Fill.Equals(Brushes.Red) AndAlso eli20.Fill.Equals(Brushes.Red) AndAlso eli13.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli34.Fill.Equals(Brushes.Red) AndAlso eli33.Fill.Equals(Brushes.Red) AndAlso eli32.Fill.Equals(Brushes.Red) AndAlso eli31.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli34.Fill.Equals(Brushes.Red) AndAlso eli26.Fill.Equals(Brushes.Red) AndAlso eli18.Fill.Equals(Brushes.Red) AndAlso eli10.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli33.Fill.Equals(Brushes.Red) AndAlso eli25.Fill.Equals(Brushes.Red) AndAlso eli17.Fill.Equals(Brushes.Red) AndAlso eli9.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli33.Fill.Equals(Brushes.Red) AndAlso eli26.Fill.Equals(Brushes.Red) AndAlso eli19.Fill.Equals(Brushes.Red) AndAlso eli12.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli33.Fill.Equals(Brushes.Red) AndAlso eli32.Fill.Equals(Brushes.Red) AndAlso eli31.Fill.Equals(Brushes.Red) AndAlso eli30.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli32.Fill.Equals(Brushes.Red) AndAlso eli31.Fill.Equals(Brushes.Red) AndAlso eli30.Fill.Equals(Brushes.Red) AndAlso eli29.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli32.Fill.Equals(Brushes.Red) AndAlso eli33.Fill.Equals(Brushes.Red) AndAlso eli34.Fill.Equals(Brushes.Red) AndAlso eli35.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli32.Fill.Equals(Brushes.Red) AndAlso eli24.Fill.Equals(Brushes.Red) AndAlso eli16.Fill.Equals(Brushes.Red) AndAlso eli8.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli32.Fill.Equals(Brushes.Red) AndAlso eli26.Fill.Equals(Brushes.Red) AndAlso eli20.Fill.Equals(Brushes.Red) AndAlso eli13.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli32.Fill.Equals(Brushes.Red) AndAlso eli25.Fill.Equals(Brushes.Red) AndAlso eli18.Fill.Equals(Brushes.Red) AndAlso eli11.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli31.Fill.Equals(Brushes.Red) AndAlso eli24.Fill.Equals(Brushes.Red) AndAlso eli17.Fill.Equals(Brushes.Red) AndAlso eli10.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli31.Fill.Equals(Brushes.Red) AndAlso eli32.Fill.Equals(Brushes.Red) AndAlso eli33.Fill.Equals(Brushes.Red) AndAlso eli34.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli31.Fill.Equals(Brushes.Red) AndAlso eli25.Fill.Equals(Brushes.Red) AndAlso eli19.Fill.Equals(Brushes.Red) AndAlso eli13.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli30.Fill.Equals(Brushes.Red) AndAlso eli31.Fill.Equals(Brushes.Red) AndAlso eli32.Fill.Equals(Brushes.Red) AndAlso eli33.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli30.Fill.Equals(Brushes.Red) AndAlso eli23.Fill.Equals(Brushes.Red) AndAlso eli16.Fill.Equals(Brushes.Red) AndAlso eli9.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli30.Fill.Equals(Brushes.Red) AndAlso eli24.Fill.Equals(Brushes.Red) AndAlso eli18.Fill.Equals(Brushes.Red) AndAlso eli12.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli29.Fill.Equals(Brushes.Red) AndAlso eli30.Fill.Equals(Brushes.Red) AndAlso eli31.Fill.Equals(Brushes.Red) AndAlso eli32.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli29.Fill.Equals(Brushes.Red) AndAlso eli22.Fill.Equals(Brushes.Red) AndAlso eli15.Fill.Equals(Brushes.Red) AndAlso eli8.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli29.Fill.Equals(Brushes.Red) AndAlso eli23.Fill.Equals(Brushes.Red) AndAlso eli17.Fill.Equals(Brushes.Red) AndAlso eli11.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli28.Fill.Equals(Brushes.Red) AndAlso eli21.Fill.Equals(Brushes.Red) AndAlso eli14.Fill.Equals(Brushes.Red) AndAlso eli7.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli28.Fill.Equals(Brushes.Red) AndAlso eli20.Fill.Equals(Brushes.Red) AndAlso eli12.Fill.Equals(Brushes.Red) AndAlso eli4.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli28.Fill.Equals(Brushes.Red) AndAlso eli27.Fill.Equals(Brushes.Red) AndAlso eli26.Fill.Equals(Brushes.Red) AndAlso eli25.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli27.Fill.Equals(Brushes.Red) AndAlso eli20.Fill.Equals(Brushes.Red) AndAlso eli13.Fill.Equals(Brushes.Red) AndAlso eli6.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli27.Fill.Equals(Brushes.Red) AndAlso eli26.Fill.Equals(Brushes.Red) AndAlso eli25.Fill.Equals(Brushes.Red) AndAlso eli24.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli27.Fill.Equals(Brushes.Red) AndAlso eli19.Fill.Equals(Brushes.Red) AndAlso eli11.Fill.Equals(Brushes.Red) AndAlso eli3.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli26.Fill.Equals(Brushes.Red) AndAlso eli19.Fill.Equals(Brushes.Red) AndAlso eli12.Fill.Equals(Brushes.Red) AndAlso eli5.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli26.Fill.Equals(Brushes.Red) AndAlso eli25.Fill.Equals(Brushes.Red) AndAlso eli24.Fill.Equals(Brushes.Red) AndAlso eli23.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli26.Fill.Equals(Brushes.Red) AndAlso eli18.Fill.Equals(Brushes.Red) AndAlso eli10.Fill.Equals(Brushes.Red) AndAlso eli2.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli25.Fill.Equals(Brushes.Red) AndAlso eli24.Fill.Equals(Brushes.Red) AndAlso eli23.Fill.Equals(Brushes.Red) AndAlso eli22.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli25.Fill.Equals(Brushes.Red) AndAlso eli26.Fill.Equals(Brushes.Red) AndAlso eli27.Fill.Equals(Brushes.Red) AndAlso eli28.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli25.Fill.Equals(Brushes.Red) AndAlso eli18.Fill.Equals(Brushes.Red) AndAlso eli11.Fill.Equals(Brushes.Red) AndAlso eli4.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli25.Fill.Equals(Brushes.Red) AndAlso eli1.Fill.Equals(Brushes.Red) AndAlso eli9.Fill.Equals(Brushes.Red) AndAlso eli1.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli25.Fill.Equals(Brushes.Red) AndAlso eli19.Fill.Equals(Brushes.Red) AndAlso eli13.Fill.Equals(Brushes.Red) AndAlso eli7.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli24.Fill.Equals(Brushes.Red) AndAlso eli17.Fill.Equals(Brushes.Red) AndAlso eli10.Fill.Equals(Brushes.Red) AndAlso eli3.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli24.Fill.Equals(Brushes.Red) AndAlso eli25.Fill.Equals(Brushes.Red) AndAlso eli26.Fill.Equals(Brushes.Red) AndAlso eli27.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli24.Fill.Equals(Brushes.Red) AndAlso eli18.Fill.Equals(Brushes.Red) AndAlso eli12.Fill.Equals(Brushes.Red) AndAlso eli6.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli23.Fill.Equals(Brushes.Red) AndAlso eli16.Fill.Equals(Brushes.Red) AndAlso eli9.Fill.Equals(Brushes.Red) AndAlso eli2.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli23.Fill.Equals(Brushes.Red) AndAlso eli17.Fill.Equals(Brushes.Red) AndAlso eli11.Fill.Equals(Brushes.Red) AndAlso eli5.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli23.Fill.Equals(Brushes.Red) AndAlso eli24.Fill.Equals(Brushes.Red) AndAlso eli25.Fill.Equals(Brushes.Red) AndAlso eli26.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli22.Fill.Equals(Brushes.Red) AndAlso eli15.Fill.Equals(Brushes.Red) AndAlso eli8.Fill.Equals(Brushes.Red) AndAlso eli1.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli22.Fill.Equals(Brushes.Red) AndAlso eli23.Fill.Equals(Brushes.Red) AndAlso eli24.Fill.Equals(Brushes.Red) AndAlso eli25.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        ElseIf eli22.Fill.Equals(Brushes.Red) AndAlso eli16.Fill.Equals(Brushes.Red) AndAlso eli10.Fill.Equals(Brushes.Red) AndAlso eli4.Fill.Equals(Brushes.Red) Then
            MsgBox("Red Checker Wins!")
            reset()
        End If

        If eli1.Fill.Equals(Brushes.Red) AndAlso eli2.Fill.Equals(Brushes.Red) AndAlso eli3.Fill.Equals(Brushes.Red) AndAlso eli4.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli2.Fill.Equals(Brushes.Red) AndAlso eli3.Fill.Equals(Brushes.Red) AndAlso eli4.Fill.Equals(Brushes.Red) AndAlso eli5.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli3.Fill.Equals(Brushes.Red) AndAlso eli4.Fill.Equals(Brushes.Red) AndAlso eli5.Fill.Equals(Brushes.Red) AndAlso eli6.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli4.Fill.Equals(Brushes.Red) AndAlso eli5.Fill.Equals(Brushes.Red) AndAlso eli6.Fill.Equals(Brushes.Red) AndAlso eli7.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli8.Fill.Equals(Brushes.Red) AndAlso eli9.Fill.Equals(Brushes.Red) AndAlso eli10.Fill.Equals(Brushes.Red) AndAlso eli11.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli9.Fill.Equals(Brushes.Red) AndAlso eli10.Fill.Equals(Brushes.Red) AndAlso eli11.Fill.Equals(Brushes.Red) AndAlso eli12.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli10.Fill.Equals(Brushes.Red) AndAlso eli11.Fill.Equals(Brushes.Red) AndAlso eli12.Fill.Equals(Brushes.Red) AndAlso eli13.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli11.Fill.Equals(Brushes.Red) AndAlso eli12.Fill.Equals(Brushes.Red) AndAlso eli13.Fill.Equals(Brushes.Red) AndAlso eli14.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli15.Fill.Equals(Brushes.Red) AndAlso eli16.Fill.Equals(Brushes.Red) AndAlso eli17.Fill.Equals(Brushes.Red) AndAlso eli18.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli16.Fill.Equals(Brushes.Red) AndAlso eli17.Fill.Equals(Brushes.Red) AndAlso eli18.Fill.Equals(Brushes.Red) AndAlso eli19.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli17.Fill.Equals(Brushes.Red) AndAlso eli18.Fill.Equals(Brushes.Red) AndAlso eli19.Fill.Equals(Brushes.Red) AndAlso eli20.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli18.Fill.Equals(Brushes.Red) AndAlso eli19.Fill.Equals(Brushes.Red) AndAlso eli20.Fill.Equals(Brushes.Red) AndAlso eli21.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli22.Fill.Equals(Brushes.Red) AndAlso eli23.Fill.Equals(Brushes.Red) AndAlso eli24.Fill.Equals(Brushes.Red) AndAlso eli25.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli23.Fill.Equals(Brushes.Red) AndAlso eli24.Fill.Equals(Brushes.Red) AndAlso eli25.Fill.Equals(Brushes.Red) AndAlso eli26.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli24.Fill.Equals(Brushes.Red) AndAlso eli25.Fill.Equals(Brushes.Red) AndAlso eli26.Fill.Equals(Brushes.Red) AndAlso eli27.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli25.Fill.Equals(Brushes.Red) AndAlso eli26.Fill.Equals(Brushes.Red) AndAlso eli27.Fill.Equals(Brushes.Red) AndAlso eli28.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli29.Fill.Equals(Brushes.Red) AndAlso eli30.Fill.Equals(Brushes.Red) AndAlso eli31.Fill.Equals(Brushes.Red) AndAlso eli32.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli30.Fill.Equals(Brushes.Red) AndAlso eli31.Fill.Equals(Brushes.Red) AndAlso eli32.Fill.Equals(Brushes.Red) AndAlso eli33.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli31.Fill.Equals(Brushes.Red) AndAlso eli32.Fill.Equals(Brushes.Red) AndAlso eli33.Fill.Equals(Brushes.Red) AndAlso eli34.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli32.Fill.Equals(Brushes.Red) AndAlso eli33.Fill.Equals(Brushes.Red) AndAlso eli34.Fill.Equals(Brushes.Red) AndAlso eli35.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli36.Fill.Equals(Brushes.Red) AndAlso eli37.Fill.Equals(Brushes.Red) AndAlso eli38.Fill.Equals(Brushes.Red) AndAlso eli39.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli37.Fill.Equals(Brushes.Red) AndAlso eli38.Fill.Equals(Brushes.Red) AndAlso eli39.Fill.Equals(Brushes.Red) AndAlso eli40.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli38.Fill.Equals(Brushes.Red) AndAlso eli39.Fill.Equals(Brushes.Red) AndAlso eli40.Fill.Equals(Brushes.Red) AndAlso eli41.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli39.Fill.Equals(Brushes.Red) AndAlso eli40.Fill.Equals(Brushes.Red) AndAlso eli41.Fill.Equals(Brushes.Red) AndAlso eli42.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli1.Fill.Equals(Brushes.Red) AndAlso eli8.Fill.Equals(Brushes.Red) AndAlso eli15.Fill.Equals(Brushes.Red) AndAlso eli22.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli8.Fill.Equals(Brushes.Red) AndAlso eli15.Fill.Equals(Brushes.Red) AndAlso eli22.Fill.Equals(Brushes.Red) AndAlso eli29.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli15.Fill.Equals(Brushes.Red) AndAlso eli22.Fill.Equals(Brushes.Red) AndAlso eli29.Fill.Equals(Brushes.Red) AndAlso eli36.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli2.Fill.Equals(Brushes.Red) AndAlso eli9.Fill.Equals(Brushes.Red) AndAlso eli16.Fill.Equals(Brushes.Red) AndAlso eli23.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli9.Fill.Equals(Brushes.Red) AndAlso eli16.Fill.Equals(Brushes.Red) AndAlso eli23.Fill.Equals(Brushes.Red) AndAlso eli30.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli16.Fill.Equals(Brushes.Red) AndAlso eli23.Fill.Equals(Brushes.Red) AndAlso eli30.Fill.Equals(Brushes.Red) AndAlso eli37.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli3.Fill.Equals(Brushes.Red) AndAlso eli10.Fill.Equals(Brushes.Red) AndAlso eli17.Fill.Equals(Brushes.Red) AndAlso eli24.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli10.Fill.Equals(Brushes.Red) AndAlso eli17.Fill.Equals(Brushes.Red) AndAlso eli24.Fill.Equals(Brushes.Red) AndAlso eli31.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli17.Fill.Equals(Brushes.Red) AndAlso eli24.Fill.Equals(Brushes.Red) AndAlso eli31.Fill.Equals(Brushes.Red) AndAlso eli38.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli4.Fill.Equals(Brushes.Red) AndAlso eli11.Fill.Equals(Brushes.Red) AndAlso eli18.Fill.Equals(Brushes.Red) AndAlso eli25.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli11.Fill.Equals(Brushes.Red) AndAlso eli18.Fill.Equals(Brushes.Red) AndAlso eli25.Fill.Equals(Brushes.Red) AndAlso eli32.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli18.Fill.Equals(Brushes.Red) AndAlso eli25.Fill.Equals(Brushes.Red) AndAlso eli32.Fill.Equals(Brushes.Red) AndAlso eli39.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli5.Fill.Equals(Brushes.Red) AndAlso eli12.Fill.Equals(Brushes.Red) AndAlso eli19.Fill.Equals(Brushes.Red) AndAlso eli26.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli12.Fill.Equals(Brushes.Red) AndAlso eli19.Fill.Equals(Brushes.Red) AndAlso eli26.Fill.Equals(Brushes.Red) AndAlso eli33.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli19.Fill.Equals(Brushes.Red) AndAlso eli26.Fill.Equals(Brushes.Red) AndAlso eli33.Fill.Equals(Brushes.Red) AndAlso eli40.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli6.Fill.Equals(Brushes.Red) AndAlso eli13.Fill.Equals(Brushes.Red) AndAlso eli20.Fill.Equals(Brushes.Red) AndAlso eli27.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli13.Fill.Equals(Brushes.Red) AndAlso eli20.Fill.Equals(Brushes.Red) AndAlso eli27.Fill.Equals(Brushes.Red) AndAlso eli34.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli20.Fill.Equals(Brushes.Red) AndAlso eli27.Fill.Equals(Brushes.Red) AndAlso eli34.Fill.Equals(Brushes.Red) AndAlso eli41.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli7.Fill.Equals(Brushes.Red) AndAlso eli14.Fill.Equals(Brushes.Red) AndAlso eli21.Fill.Equals(Brushes.Red) AndAlso eli28.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli14.Fill.Equals(Brushes.Red) AndAlso eli21.Fill.Equals(Brushes.Red) AndAlso eli28.Fill.Equals(Brushes.Red) AndAlso eli35.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli21.Fill.Equals(Brushes.Red) AndAlso eli28.Fill.Equals(Brushes.Red) AndAlso eli35.Fill.Equals(Brushes.Red) AndAlso eli42.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli4.Fill.Equals(Brushes.Red) AndAlso eli10.Fill.Equals(Brushes.Red) AndAlso eli16.Fill.Equals(Brushes.Red) AndAlso eli22.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli5.Fill.Equals(Brushes.Red) AndAlso eli11.Fill.Equals(Brushes.Red) AndAlso eli27.Fill.Equals(Brushes.Red) AndAlso eli23.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli11.Fill.Equals(Brushes.Red) AndAlso eli17.Fill.Equals(Brushes.Red) AndAlso eli23.Fill.Equals(Brushes.Red) AndAlso eli29.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli6.Fill.Equals(Brushes.Red) AndAlso eli12.Fill.Equals(Brushes.Red) AndAlso eli18.Fill.Equals(Brushes.Red) AndAlso eli24.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli12.Fill.Equals(Brushes.Red) AndAlso eli18.Fill.Equals(Brushes.Red) AndAlso eli24.Fill.Equals(Brushes.Red) AndAlso eli30.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli18.Fill.Equals(Brushes.Red) AndAlso eli24.Fill.Equals(Brushes.Red) AndAlso eli30.Fill.Equals(Brushes.Red) AndAlso eli36.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli7.Fill.Equals(Brushes.Red) AndAlso eli13.Fill.Equals(Brushes.Red) AndAlso eli19.Fill.Equals(Brushes.Red) AndAlso eli25.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli13.Fill.Equals(Brushes.Red) AndAlso eli19.Fill.Equals(Brushes.Red) AndAlso eli25.Fill.Equals(Brushes.Red) AndAlso eli31.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli19.Fill.Equals(Brushes.Red) AndAlso eli25.Fill.Equals(Brushes.Red) AndAlso eli31.Fill.Equals(Brushes.Red) AndAlso eli38.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli14.Fill.Equals(Brushes.Red) AndAlso eli20.Fill.Equals(Brushes.Red) AndAlso eli26.Fill.Equals(Brushes.Red) AndAlso eli32.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli20.Fill.Equals(Brushes.Red) AndAlso eli26.Fill.Equals(Brushes.Red) AndAlso eli32.Fill.Equals(Brushes.Red) AndAlso eli38.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli21.Fill.Equals(Brushes.Red) AndAlso eli27.Fill.Equals(Brushes.Red) AndAlso eli33.Fill.Equals(Brushes.Red) AndAlso eli39.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli15.Fill.Equals(Brushes.Red) AndAlso eli23.Fill.Equals(Brushes.Red) AndAlso eli31.Fill.Equals(Brushes.Red) AndAlso eli39.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli8.Fill.Equals(Brushes.Red) AndAlso eli16.Fill.Equals(Brushes.Red) AndAlso eli24.Fill.Equals(Brushes.Red) AndAlso eli32.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli16.Fill.Equals(Brushes.Red) AndAlso eli24.Fill.Equals(Brushes.Red) AndAlso eli32.Fill.Equals(Brushes.Red) AndAlso eli40.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli1.Fill.Equals(Brushes.Red) AndAlso eli9.Fill.Equals(Brushes.Red) AndAlso eli17.Fill.Equals(Brushes.Red) AndAlso eli25.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli9.Fill.Equals(Brushes.Red) AndAlso eli17.Fill.Equals(Brushes.Red) AndAlso eli25.Fill.Equals(Brushes.Red) AndAlso eli33.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli17.Fill.Equals(Brushes.Red) AndAlso eli25.Fill.Equals(Brushes.Red) AndAlso eli33.Fill.Equals(Brushes.Red) AndAlso eli41.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli2.Fill.Equals(Brushes.Red) AndAlso eli10.Fill.Equals(Brushes.Red) AndAlso eli18.Fill.Equals(Brushes.Red) AndAlso eli26.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli10.Fill.Equals(Brushes.Red) AndAlso eli18.Fill.Equals(Brushes.Red) AndAlso eli26.Fill.Equals(Brushes.Red) AndAlso eli34.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli18.Fill.Equals(Brushes.Red) AndAlso eli26.Fill.Equals(Brushes.Red) AndAlso eli34.Fill.Equals(Brushes.Red) AndAlso eli42.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli3.Fill.Equals(Brushes.Red) AndAlso eli11.Fill.Equals(Brushes.Red) AndAlso eli19.Fill.Equals(Brushes.Red) AndAlso eli27.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli11.Fill.Equals(Brushes.Red) AndAlso eli19.Fill.Equals(Brushes.Red) AndAlso eli27.Fill.Equals(Brushes.Red) AndAlso eli35.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli4.Fill.Equals(Brushes.Red) AndAlso eli12.Fill.Equals(Brushes.Red) AndAlso eli20.Fill.Equals(Brushes.Red) AndAlso eli28.Fill.Equals(Brushes.Red) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli1.Fill.Equals(Brushes.Black) AndAlso eli2.Fill.Equals(Brushes.Black) AndAlso eli3.Fill.Equals(Brushes.Black) AndAlso eli4.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli2.Fill.Equals(Brushes.Black) AndAlso eli3.Fill.Equals(Brushes.Black) AndAlso eli4.Fill.Equals(Brushes.Black) AndAlso eli5.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli3.Fill.Equals(Brushes.Black) AndAlso eli4.Fill.Equals(Brushes.Black) AndAlso eli5.Fill.Equals(Brushes.Black) AndAlso eli6.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli4.Fill.Equals(Brushes.Black) AndAlso eli5.Fill.Equals(Brushes.Black) AndAlso eli6.Fill.Equals(Brushes.Black) AndAlso eli7.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli8.Fill.Equals(Brushes.Black) AndAlso eli9.Fill.Equals(Brushes.Black) AndAlso eli10.Fill.Equals(Brushes.Black) AndAlso eli11.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli9.Fill.Equals(Brushes.Black) AndAlso eli10.Fill.Equals(Brushes.Black) AndAlso eli11.Fill.Equals(Brushes.Black) AndAlso eli12.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli10.Fill.Equals(Brushes.Black) AndAlso eli11.Fill.Equals(Brushes.Black) AndAlso eli12.Fill.Equals(Brushes.Black) AndAlso eli13.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli11.Fill.Equals(Brushes.Black) AndAlso eli12.Fill.Equals(Brushes.Black) AndAlso eli13.Fill.Equals(Brushes.Black) AndAlso eli14.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli15.Fill.Equals(Brushes.Black) AndAlso eli16.Fill.Equals(Brushes.Black) AndAlso eli17.Fill.Equals(Brushes.Black) AndAlso eli18.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli16.Fill.Equals(Brushes.Black) AndAlso eli17.Fill.Equals(Brushes.Black) AndAlso eli18.Fill.Equals(Brushes.Black) AndAlso eli19.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli17.Fill.Equals(Brushes.Black) AndAlso eli18.Fill.Equals(Brushes.Black) AndAlso eli19.Fill.Equals(Brushes.Black) AndAlso eli20.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli18.Fill.Equals(Brushes.Black) AndAlso eli19.Fill.Equals(Brushes.Black) AndAlso eli20.Fill.Equals(Brushes.Black) AndAlso eli21.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli22.Fill.Equals(Brushes.Black) AndAlso eli23.Fill.Equals(Brushes.Black) AndAlso eli24.Fill.Equals(Brushes.Black) AndAlso eli25.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli23.Fill.Equals(Brushes.Black) AndAlso eli24.Fill.Equals(Brushes.Black) AndAlso eli25.Fill.Equals(Brushes.Black) AndAlso eli26.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli24.Fill.Equals(Brushes.Black) AndAlso eli25.Fill.Equals(Brushes.Black) AndAlso eli26.Fill.Equals(Brushes.Black) AndAlso eli27.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli25.Fill.Equals(Brushes.Black) AndAlso eli26.Fill.Equals(Brushes.Black) AndAlso eli27.Fill.Equals(Brushes.Black) AndAlso eli28.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli29.Fill.Equals(Brushes.Black) AndAlso eli30.Fill.Equals(Brushes.Black) AndAlso eli31.Fill.Equals(Brushes.Black) AndAlso eli32.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli30.Fill.Equals(Brushes.Black) AndAlso eli31.Fill.Equals(Brushes.Black) AndAlso eli32.Fill.Equals(Brushes.Black) AndAlso eli33.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli31.Fill.Equals(Brushes.Black) AndAlso eli32.Fill.Equals(Brushes.Black) AndAlso eli33.Fill.Equals(Brushes.Black) AndAlso eli34.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli32.Fill.Equals(Brushes.Black) AndAlso eli33.Fill.Equals(Brushes.Black) AndAlso eli34.Fill.Equals(Brushes.Black) AndAlso eli35.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli36.Fill.Equals(Brushes.Black) AndAlso eli37.Fill.Equals(Brushes.Black) AndAlso eli38.Fill.Equals(Brushes.Black) AndAlso eli39.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli37.Fill.Equals(Brushes.Black) AndAlso eli38.Fill.Equals(Brushes.Black) AndAlso eli39.Fill.Equals(Brushes.Black) AndAlso eli40.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli38.Fill.Equals(Brushes.Black) AndAlso eli39.Fill.Equals(Brushes.Black) AndAlso eli40.Fill.Equals(Brushes.Black) AndAlso eli41.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli39.Fill.Equals(Brushes.Black) AndAlso eli40.Fill.Equals(Brushes.Black) AndAlso eli41.Fill.Equals(Brushes.Black) AndAlso eli42.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli1.Fill.Equals(Brushes.Black) AndAlso eli8.Fill.Equals(Brushes.Black) AndAlso eli15.Fill.Equals(Brushes.Black) AndAlso eli22.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli8.Fill.Equals(Brushes.Black) AndAlso eli15.Fill.Equals(Brushes.Black) AndAlso eli22.Fill.Equals(Brushes.Black) AndAlso eli29.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli15.Fill.Equals(Brushes.Black) AndAlso eli22.Fill.Equals(Brushes.Black) AndAlso eli29.Fill.Equals(Brushes.Black) AndAlso eli36.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli2.Fill.Equals(Brushes.Black) AndAlso eli9.Fill.Equals(Brushes.Black) AndAlso eli16.Fill.Equals(Brushes.Black) AndAlso eli23.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli9.Fill.Equals(Brushes.Black) AndAlso eli16.Fill.Equals(Brushes.Black) AndAlso eli23.Fill.Equals(Brushes.Black) AndAlso eli30.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli16.Fill.Equals(Brushes.Black) AndAlso eli23.Fill.Equals(Brushes.Black) AndAlso eli30.Fill.Equals(Brushes.Black) AndAlso eli37.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli3.Fill.Equals(Brushes.Black) AndAlso eli10.Fill.Equals(Brushes.Black) AndAlso eli17.Fill.Equals(Brushes.Black) AndAlso eli24.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli10.Fill.Equals(Brushes.Black) AndAlso eli17.Fill.Equals(Brushes.Black) AndAlso eli24.Fill.Equals(Brushes.Black) AndAlso eli31.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli17.Fill.Equals(Brushes.Black) AndAlso eli24.Fill.Equals(Brushes.Black) AndAlso eli31.Fill.Equals(Brushes.Black) AndAlso eli38.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli4.Fill.Equals(Brushes.Black) AndAlso eli11.Fill.Equals(Brushes.Black) AndAlso eli18.Fill.Equals(Brushes.Black) AndAlso eli25.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli11.Fill.Equals(Brushes.Black) AndAlso eli18.Fill.Equals(Brushes.Black) AndAlso eli25.Fill.Equals(Brushes.Black) AndAlso eli32.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli18.Fill.Equals(Brushes.Black) AndAlso eli25.Fill.Equals(Brushes.Black) AndAlso eli32.Fill.Equals(Brushes.Black) AndAlso eli39.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli5.Fill.Equals(Brushes.Black) AndAlso eli12.Fill.Equals(Brushes.Black) AndAlso eli19.Fill.Equals(Brushes.Black) AndAlso eli26.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli12.Fill.Equals(Brushes.Black) AndAlso eli19.Fill.Equals(Brushes.Black) AndAlso eli26.Fill.Equals(Brushes.Black) AndAlso eli33.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli19.Fill.Equals(Brushes.Black) AndAlso eli26.Fill.Equals(Brushes.Black) AndAlso eli33.Fill.Equals(Brushes.Black) AndAlso eli40.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli6.Fill.Equals(Brushes.Black) AndAlso eli13.Fill.Equals(Brushes.Black) AndAlso eli20.Fill.Equals(Brushes.Black) AndAlso eli27.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli13.Fill.Equals(Brushes.Black) AndAlso eli20.Fill.Equals(Brushes.Black) AndAlso eli27.Fill.Equals(Brushes.Black) AndAlso eli34.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli20.Fill.Equals(Brushes.Black) AndAlso eli27.Fill.Equals(Brushes.Black) AndAlso eli34.Fill.Equals(Brushes.Black) AndAlso eli41.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli7.Fill.Equals(Brushes.Black) AndAlso eli14.Fill.Equals(Brushes.Black) AndAlso eli21.Fill.Equals(Brushes.Black) AndAlso eli28.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli14.Fill.Equals(Brushes.Black) AndAlso eli21.Fill.Equals(Brushes.Black) AndAlso eli28.Fill.Equals(Brushes.Black) AndAlso eli35.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli21.Fill.Equals(Brushes.Black) AndAlso eli28.Fill.Equals(Brushes.Black) AndAlso eli35.Fill.Equals(Brushes.Black) AndAlso eli42.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli4.Fill.Equals(Brushes.Black) AndAlso eli10.Fill.Equals(Brushes.Black) AndAlso eli16.Fill.Equals(Brushes.Black) AndAlso eli22.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli5.Fill.Equals(Brushes.Black) AndAlso eli11.Fill.Equals(Brushes.Black) AndAlso eli27.Fill.Equals(Brushes.Black) AndAlso eli23.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli11.Fill.Equals(Brushes.Black) AndAlso eli17.Fill.Equals(Brushes.Black) AndAlso eli23.Fill.Equals(Brushes.Black) AndAlso eli29.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli6.Fill.Equals(Brushes.Black) AndAlso eli12.Fill.Equals(Brushes.Black) AndAlso eli18.Fill.Equals(Brushes.Black) AndAlso eli24.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli12.Fill.Equals(Brushes.Black) AndAlso eli18.Fill.Equals(Brushes.Black) AndAlso eli24.Fill.Equals(Brushes.Black) AndAlso eli30.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli18.Fill.Equals(Brushes.Black) AndAlso eli24.Fill.Equals(Brushes.Black) AndAlso eli30.Fill.Equals(Brushes.Black) AndAlso eli36.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli7.Fill.Equals(Brushes.Black) AndAlso eli13.Fill.Equals(Brushes.Black) AndAlso eli19.Fill.Equals(Brushes.Black) AndAlso eli25.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli13.Fill.Equals(Brushes.Black) AndAlso eli19.Fill.Equals(Brushes.Black) AndAlso eli25.Fill.Equals(Brushes.Black) AndAlso eli31.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli19.Fill.Equals(Brushes.Black) AndAlso eli25.Fill.Equals(Brushes.Black) AndAlso eli31.Fill.Equals(Brushes.Black) AndAlso eli38.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli14.Fill.Equals(Brushes.Black) AndAlso eli20.Fill.Equals(Brushes.Black) AndAlso eli26.Fill.Equals(Brushes.Black) AndAlso eli32.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli20.Fill.Equals(Brushes.Black) AndAlso eli26.Fill.Equals(Brushes.Black) AndAlso eli32.Fill.Equals(Brushes.Black) AndAlso eli38.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli21.Fill.Equals(Brushes.Black) AndAlso eli27.Fill.Equals(Brushes.Black) AndAlso eli33.Fill.Equals(Brushes.Black) AndAlso eli39.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli15.Fill.Equals(Brushes.Black) AndAlso eli23.Fill.Equals(Brushes.Black) AndAlso eli31.Fill.Equals(Brushes.Black) AndAlso eli39.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli8.Fill.Equals(Brushes.Black) AndAlso eli16.Fill.Equals(Brushes.Black) AndAlso eli24.Fill.Equals(Brushes.Black) AndAlso eli32.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli16.Fill.Equals(Brushes.Black) AndAlso eli24.Fill.Equals(Brushes.Black) AndAlso eli32.Fill.Equals(Brushes.Black) AndAlso eli40.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli1.Fill.Equals(Brushes.Black) AndAlso eli9.Fill.Equals(Brushes.Black) AndAlso eli17.Fill.Equals(Brushes.Black) AndAlso eli25.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli9.Fill.Equals(Brushes.Black) AndAlso eli17.Fill.Equals(Brushes.Black) AndAlso eli25.Fill.Equals(Brushes.Black) AndAlso eli33.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli17.Fill.Equals(Brushes.Black) AndAlso eli25.Fill.Equals(Brushes.Black) AndAlso eli33.Fill.Equals(Brushes.Black) AndAlso eli41.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli2.Fill.Equals(Brushes.Black) AndAlso eli10.Fill.Equals(Brushes.Black) AndAlso eli18.Fill.Equals(Brushes.Black) AndAlso eli26.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli10.Fill.Equals(Brushes.Black) AndAlso eli18.Fill.Equals(Brushes.Black) AndAlso eli26.Fill.Equals(Brushes.Black) AndAlso eli34.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli18.Fill.Equals(Brushes.Black) AndAlso eli26.Fill.Equals(Brushes.Black) AndAlso eli34.Fill.Equals(Brushes.Black) AndAlso eli42.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli3.Fill.Equals(Brushes.Black) AndAlso eli11.Fill.Equals(Brushes.Black) AndAlso eli19.Fill.Equals(Brushes.Black) AndAlso eli27.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli11.Fill.Equals(Brushes.Black) AndAlso eli19.Fill.Equals(Brushes.Black) AndAlso eli27.Fill.Equals(Brushes.Black) AndAlso eli35.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli4.Fill.Equals(Brushes.Black) AndAlso eli12.Fill.Equals(Brushes.Black) AndAlso eli20.Fill.Equals(Brushes.Black) AndAlso eli28.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli42.Fill.Equals(Brushes.Black) AndAlso eli35.Fill.Equals(Brushes.Black) AndAlso eli28.Fill.Equals(Brushes.Black) AndAlso eli21.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli42.Fill.Equals(Brushes.Black) AndAlso eli34.Fill.Equals(Brushes.Black) AndAlso eli26.Fill.Equals(Brushes.Black) AndAlso eli18.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli42.Fill.Equals(Brushes.Black) AndAlso eli41.Fill.Equals(Brushes.Black) AndAlso eli40.Fill.Equals(Brushes.Black) AndAlso eli39.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli41.Fill.Equals(Brushes.Black) AndAlso eli34.Fill.Equals(Brushes.Black) AndAlso eli27.Fill.Equals(Brushes.Black) AndAlso eli20.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli41.Fill.Equals(Brushes.Black) AndAlso eli33.Fill.Equals(Brushes.Black) AndAlso eli25.Fill.Equals(Brushes.Black) AndAlso eli17.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli41.Fill.Equals(Brushes.Black) AndAlso eli40.Fill.Equals(Brushes.Black) AndAlso eli39.Fill.Equals(Brushes.Black) AndAlso eli38.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli40.Fill.Equals(Brushes.Black) AndAlso eli33.Fill.Equals(Brushes.Black) AndAlso eli26.Fill.Equals(Brushes.Black) AndAlso eli19.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli40.Fill.Equals(Brushes.Black) AndAlso eli32.Fill.Equals(Brushes.Black) AndAlso eli24.Fill.Equals(Brushes.Black) AndAlso eli16.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli40.Fill.Equals(Brushes.Black) AndAlso eli39.Fill.Equals(Brushes.Black) AndAlso eli38.Fill.Equals(Brushes.Black) AndAlso eli37.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli39.Fill.Equals(Brushes.Black) AndAlso eli32.Fill.Equals(Brushes.Black) AndAlso eli25.Fill.Equals(Brushes.Black) AndAlso eli18.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli39.Fill.Equals(Brushes.Black) AndAlso eli31.Fill.Equals(Brushes.Black) AndAlso eli23.Fill.Equals(Brushes.Black) AndAlso eli15.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli39.Fill.Equals(Brushes.Black) AndAlso eli33.Fill.Equals(Brushes.Black) AndAlso eli27.Fill.Equals(Brushes.Black) AndAlso eli21.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli39.Fill.Equals(Brushes.Black) AndAlso eli38.Fill.Equals(Brushes.Black) AndAlso eli37.Fill.Equals(Brushes.Black) AndAlso eli36.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli39.Fill.Equals(Brushes.Black) AndAlso eli40.Fill.Equals(Brushes.Black) AndAlso eli41.Fill.Equals(Brushes.Black) AndAlso eli42.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli38.Fill.Equals(Brushes.Black) AndAlso eli39.Fill.Equals(Brushes.Black) AndAlso eli40.Fill.Equals(Brushes.Black) AndAlso eli41.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli38.Fill.Equals(Brushes.Black) AndAlso eli31.Fill.Equals(Brushes.Black) AndAlso eli24.Fill.Equals(Brushes.Black) AndAlso eli17.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli38.Fill.Equals(Brushes.Black) AndAlso eli32.Fill.Equals(Brushes.Black) AndAlso eli26.Fill.Equals(Brushes.Black) AndAlso eli20.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli37.Fill.Equals(Brushes.Black) AndAlso eli31.Fill.Equals(Brushes.Black) AndAlso eli25.Fill.Equals(Brushes.Black) AndAlso eli19.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli37.Fill.Equals(Brushes.Black) AndAlso eli38.Fill.Equals(Brushes.Black) AndAlso eli39.Fill.Equals(Brushes.Black) AndAlso eli40.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli37.Fill.Equals(Brushes.Black) AndAlso eli30.Fill.Equals(Brushes.Black) AndAlso eli23.Fill.Equals(Brushes.Black) AndAlso eli16.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli36.Fill.Equals(Brushes.Black) AndAlso eli37.Fill.Equals(Brushes.Black) AndAlso eli38.Fill.Equals(Brushes.Black) AndAlso eli39.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli36.Fill.Equals(Brushes.Black) AndAlso eli29.Fill.Equals(Brushes.Black) AndAlso eli22.Fill.Equals(Brushes.Black) AndAlso eli15.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli36.Fill.Equals(Brushes.Black) AndAlso eli30.Fill.Equals(Brushes.Black) AndAlso eli24.Fill.Equals(Brushes.Black) AndAlso eli18.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli35.Fill.Equals(Brushes.Black) AndAlso eli28.Fill.Equals(Brushes.Black) AndAlso eli21.Fill.Equals(Brushes.Black) AndAlso eli14.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli35.Fill.Equals(Brushes.Black) AndAlso eli27.Fill.Equals(Brushes.Black) AndAlso eli19.Fill.Equals(Brushes.Black) AndAlso eli11.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli35.Fill.Equals(Brushes.Black) AndAlso eli34.Fill.Equals(Brushes.Black) AndAlso eli33.Fill.Equals(Brushes.Black) AndAlso eli32.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli34.Fill.Equals(Brushes.Black) AndAlso eli37.Fill.Equals(Brushes.Black) AndAlso eli20.Fill.Equals(Brushes.Black) AndAlso eli13.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli34.Fill.Equals(Brushes.Black) AndAlso eli33.Fill.Equals(Brushes.Black) AndAlso eli32.Fill.Equals(Brushes.Black) AndAlso eli31.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli34.Fill.Equals(Brushes.Black) AndAlso eli26.Fill.Equals(Brushes.Black) AndAlso eli18.Fill.Equals(Brushes.Black) AndAlso eli10.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli33.Fill.Equals(Brushes.Black) AndAlso eli25.Fill.Equals(Brushes.Black) AndAlso eli17.Fill.Equals(Brushes.Black) AndAlso eli9.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli33.Fill.Equals(Brushes.Black) AndAlso eli26.Fill.Equals(Brushes.Black) AndAlso eli19.Fill.Equals(Brushes.Black) AndAlso eli12.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli33.Fill.Equals(Brushes.Black) AndAlso eli32.Fill.Equals(Brushes.Black) AndAlso eli31.Fill.Equals(Brushes.Black) AndAlso eli30.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli32.Fill.Equals(Brushes.Black) AndAlso eli31.Fill.Equals(Brushes.Black) AndAlso eli30.Fill.Equals(Brushes.Black) AndAlso eli29.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli32.Fill.Equals(Brushes.Black) AndAlso eli33.Fill.Equals(Brushes.Black) AndAlso eli34.Fill.Equals(Brushes.Black) AndAlso eli35.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli32.Fill.Equals(Brushes.Black) AndAlso eli24.Fill.Equals(Brushes.Black) AndAlso eli16.Fill.Equals(Brushes.Black) AndAlso eli8.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli32.Fill.Equals(Brushes.Black) AndAlso eli26.Fill.Equals(Brushes.Black) AndAlso eli20.Fill.Equals(Brushes.Black) AndAlso eli13.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli32.Fill.Equals(Brushes.Black) AndAlso eli25.Fill.Equals(Brushes.Black) AndAlso eli18.Fill.Equals(Brushes.Black) AndAlso eli11.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli31.Fill.Equals(Brushes.Black) AndAlso eli24.Fill.Equals(Brushes.Black) AndAlso eli17.Fill.Equals(Brushes.Black) AndAlso eli10.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli31.Fill.Equals(Brushes.Black) AndAlso eli32.Fill.Equals(Brushes.Black) AndAlso eli33.Fill.Equals(Brushes.Black) AndAlso eli34.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli31.Fill.Equals(Brushes.Black) AndAlso eli25.Fill.Equals(Brushes.Black) AndAlso eli19.Fill.Equals(Brushes.Black) AndAlso eli13.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli30.Fill.Equals(Brushes.Black) AndAlso eli31.Fill.Equals(Brushes.Black) AndAlso eli32.Fill.Equals(Brushes.Black) AndAlso eli33.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli30.Fill.Equals(Brushes.Black) AndAlso eli23.Fill.Equals(Brushes.Black) AndAlso eli16.Fill.Equals(Brushes.Black) AndAlso eli9.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli30.Fill.Equals(Brushes.Black) AndAlso eli24.Fill.Equals(Brushes.Black) AndAlso eli18.Fill.Equals(Brushes.Black) AndAlso eli12.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli29.Fill.Equals(Brushes.Black) AndAlso eli30.Fill.Equals(Brushes.Black) AndAlso eli31.Fill.Equals(Brushes.Black) AndAlso eli32.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli29.Fill.Equals(Brushes.Black) AndAlso eli22.Fill.Equals(Brushes.Black) AndAlso eli15.Fill.Equals(Brushes.Black) AndAlso eli8.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli29.Fill.Equals(Brushes.Black) AndAlso eli23.Fill.Equals(Brushes.Black) AndAlso eli17.Fill.Equals(Brushes.Black) AndAlso eli11.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli28.Fill.Equals(Brushes.Black) AndAlso eli21.Fill.Equals(Brushes.Black) AndAlso eli14.Fill.Equals(Brushes.Black) AndAlso eli7.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli28.Fill.Equals(Brushes.Black) AndAlso eli20.Fill.Equals(Brushes.Black) AndAlso eli12.Fill.Equals(Brushes.Black) AndAlso eli4.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli28.Fill.Equals(Brushes.Black) AndAlso eli27.Fill.Equals(Brushes.Black) AndAlso eli26.Fill.Equals(Brushes.Black) AndAlso eli25.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli27.Fill.Equals(Brushes.Black) AndAlso eli20.Fill.Equals(Brushes.Black) AndAlso eli13.Fill.Equals(Brushes.Black) AndAlso eli6.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli27.Fill.Equals(Brushes.Black) AndAlso eli26.Fill.Equals(Brushes.Black) AndAlso eli25.Fill.Equals(Brushes.Black) AndAlso eli24.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli27.Fill.Equals(Brushes.Black) AndAlso eli19.Fill.Equals(Brushes.Black) AndAlso eli11.Fill.Equals(Brushes.Black) AndAlso eli3.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli26.Fill.Equals(Brushes.Black) AndAlso eli19.Fill.Equals(Brushes.Black) AndAlso eli12.Fill.Equals(Brushes.Black) AndAlso eli5.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli26.Fill.Equals(Brushes.Black) AndAlso eli25.Fill.Equals(Brushes.Black) AndAlso eli24.Fill.Equals(Brushes.Black) AndAlso eli23.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli26.Fill.Equals(Brushes.Black) AndAlso eli18.Fill.Equals(Brushes.Black) AndAlso eli10.Fill.Equals(Brushes.Black) AndAlso eli2.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli25.Fill.Equals(Brushes.Black) AndAlso eli24.Fill.Equals(Brushes.Black) AndAlso eli23.Fill.Equals(Brushes.Black) AndAlso eli22.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli25.Fill.Equals(Brushes.Black) AndAlso eli26.Fill.Equals(Brushes.Black) AndAlso eli27.Fill.Equals(Brushes.Black) AndAlso eli28.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli25.Fill.Equals(Brushes.Black) AndAlso eli18.Fill.Equals(Brushes.Black) AndAlso eli11.Fill.Equals(Brushes.Black) AndAlso eli4.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli25.Fill.Equals(Brushes.Black) AndAlso eli1.Fill.Equals(Brushes.Black) AndAlso eli9.Fill.Equals(Brushes.Black) AndAlso eli1.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli25.Fill.Equals(Brushes.Black) AndAlso eli19.Fill.Equals(Brushes.Black) AndAlso eli13.Fill.Equals(Brushes.Black) AndAlso eli7.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli24.Fill.Equals(Brushes.Black) AndAlso eli17.Fill.Equals(Brushes.Black) AndAlso eli10.Fill.Equals(Brushes.Black) AndAlso eli3.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli24.Fill.Equals(Brushes.Black) AndAlso eli25.Fill.Equals(Brushes.Black) AndAlso eli26.Fill.Equals(Brushes.Black) AndAlso eli27.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli24.Fill.Equals(Brushes.Black) AndAlso eli18.Fill.Equals(Brushes.Black) AndAlso eli12.Fill.Equals(Brushes.Black) AndAlso eli6.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli23.Fill.Equals(Brushes.Black) AndAlso eli16.Fill.Equals(Brushes.Black) AndAlso eli9.Fill.Equals(Brushes.Black) AndAlso eli2.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli23.Fill.Equals(Brushes.Black) AndAlso eli17.Fill.Equals(Brushes.Black) AndAlso eli11.Fill.Equals(Brushes.Black) AndAlso eli5.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli23.Fill.Equals(Brushes.Black) AndAlso eli24.Fill.Equals(Brushes.Black) AndAlso eli25.Fill.Equals(Brushes.Black) AndAlso eli26.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli22.Fill.Equals(Brushes.Black) AndAlso eli15.Fill.Equals(Brushes.Black) AndAlso eli8.Fill.Equals(Brushes.Black) AndAlso eli1.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli22.Fill.Equals(Brushes.Black) AndAlso eli23.Fill.Equals(Brushes.Black) AndAlso eli24.Fill.Equals(Brushes.Black) AndAlso eli25.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        ElseIf eli22.Fill.Equals(Brushes.Black) AndAlso eli16.Fill.Equals(Brushes.Black) AndAlso eli10.Fill.Equals(Brushes.Black) AndAlso eli4.Fill.Equals(Brushes.Black) Then
            MsgBox("Black Checker Wins!")
            reset()
        End If

        If (columnOne >= 6) AndAlso (columnTwo >= 6) AndAlso (columnThree >= 6) AndAlso (columnFour >= 6) AndAlso (columnFive >= 6) AndAlso (columnSix >= 6) AndAlso (columnSeven >= 6) Then
            MsgBox("Tie!")
            reset()
        End If

    End Sub

    Private Sub reset()
        eli1.IsEnabled = True
        eli1.Fill = Brushes.White
        eli8.IsEnabled = True
        eli8.Fill = Brushes.White
        eli15.IsEnabled = True
        eli15.Fill = Brushes.White
        eli22.IsEnabled = True
        eli22.Fill = Brushes.White
        eli29.IsEnabled = True
        eli29.Fill = Brushes.White
        eli36.IsEnabled = True
        eli36.Fill = Brushes.White
        eli2.IsEnabled = True
        eli2.Fill = Brushes.White
        eli9.IsEnabled = True
        eli9.Fill = Brushes.White
        eli16.IsEnabled = True
        eli16.Fill = Brushes.White
        eli23.IsEnabled = True
        eli23.Fill = Brushes.White
        eli30.IsEnabled = True
        eli30.Fill = Brushes.White
        eli37.IsEnabled = True
        eli37.Fill = Brushes.White
        eli3.IsEnabled = True
        eli3.Fill = Brushes.White
        eli10.IsEnabled = True
        eli10.Fill = Brushes.White
        eli17.IsEnabled = True
        eli17.Fill = Brushes.White
        eli24.IsEnabled = True
        eli24.Fill = Brushes.White
        eli31.IsEnabled = True
        eli31.Fill = Brushes.White
        eli38.IsEnabled = True
        eli38.Fill = Brushes.White
        eli4.IsEnabled = True
        eli4.Fill = Brushes.White
        eli11.IsEnabled = True
        eli11.Fill = Brushes.White
        eli18.IsEnabled = True
        eli18.Fill = Brushes.White
        eli25.IsEnabled = True
        eli25.Fill = Brushes.White
        eli32.IsEnabled = True
        eli32.Fill = Brushes.White
        eli39.IsEnabled = True
        eli39.Fill = Brushes.White
        eli5.IsEnabled = True
        eli5.Fill = Brushes.White
        eli12.IsEnabled = True
        eli12.Fill = Brushes.White
        eli19.IsEnabled = True
        eli19.Fill = Brushes.White
        eli26.IsEnabled = True
        eli26.Fill = Brushes.White
        eli33.IsEnabled = True
        eli33.Fill = Brushes.White
        eli40.IsEnabled = True
        eli40.Fill = Brushes.White
        eli6.IsEnabled = True
        eli6.Fill = Brushes.White
        eli13.IsEnabled = True
        eli13.Fill = Brushes.White
        eli20.IsEnabled = True
        eli20.Fill = Brushes.White
        eli27.IsEnabled = True
        eli27.Fill = Brushes.White
        eli34.IsEnabled = True
        eli34.Fill = Brushes.White
        eli41.IsEnabled = True
        eli41.Fill = Brushes.White
        eli7.IsEnabled = True
        eli7.Fill = Brushes.White
        eli14.IsEnabled = True
        eli14.Fill = Brushes.White
        eli21.IsEnabled = True
        eli21.Fill = Brushes.White
        eli28.IsEnabled = True
        eli28.Fill = Brushes.White
        eli35.IsEnabled = True
        eli35.Fill = Brushes.White
        eli42.IsEnabled = True
        eli42.Fill = Brushes.White
        columnOne = 0
        columnTwo = 0
        columnThree = 0
        columnFour = 0
        columnFive = 0
        columnSix = 0
        columnSeven = 0
        playerOne = True
    End Sub

End Class
