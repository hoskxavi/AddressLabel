'Xavier Hoskins
'RCET 0265
'Fall 2022
'Address Label
'https://www.github.com/hoskxavi/AddressLabel

Public Class AddressLabelForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        Dim displayLabel As String
        displayLabel = FirstNameTextBox.Text + " " +
                       LastNameTextBox.Text + vbCrLf +
                       StreetAddressTextBox.Text + vbCrLf +
                       CityTextBox.Text + "," + " " +
                       StateTextBox.Text + " " +
                       ZipTextBox.Text
        AddressLabelTextBox.Text = displayLabel
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        StreetAddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipTextBox.Text = ""
        AddressLabelTextBox.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        MsgBox("Have a nice day!")
        Me.Close()
    End Sub

End Class
