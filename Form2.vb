Public Class Form2
    ' Form Load - Sets up the entire UI
    Private Sub frmBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Form properties
        Me.Text = "Iraq Airways Booking"
        Me.Width = 550
            Me.Height = 550
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.MaximizeBox = False


        ' ---------- HEADING ----------
        Dim lblHeading As New Label()
        lblHeading.Text = "IRAQ AIRWAYS AIRWAYS BOOKING"
        lblHeading.Font = New Font("Arial", 16, FontStyle.Bold)
            lblHeading.TextAlign = ContentAlignment.MiddleCenter
            lblHeading.Location = New Point(0, 10)
            lblHeading.Width = Me.Width
            lblHeading.Height = 30
            Me.Controls.Add(lblHeading)

            ' ---------- FLIGHT SELECTION ----------
            Dim lblFlight As New Label()
            lblFlight.Text = "Select Flight:"
            lblFlight.Location = New Point(30, 60)
            lblFlight.Width = 100
            lblFlight.TextAlign = ContentAlignment.MiddleLeft
            Me.Controls.Add(lblFlight)

            Dim cboFlights As New ComboBox()
            cboFlights.Name = "cboFlights"
            cboFlights.Location = New Point(150, 60)
        cboFlights.Width = 350
        cboFlights.DropDownStyle = ComboBoxStyle.DropDownList
        cboFlights.Items.Add("IQ101: New York to London - $450")
        cboFlights.Items.Add("IQ202: London to Paris - $220")
        cboFlights.Items.Add("IQ303: Paris to Rome - $185")
        cboFlights.Items.Add("IQ404: Rome to Madrid - $210")
        cboFlights.Items.Add("IQ505: Madrid to New York - $520")
        cboFlights.Items.Add("IQ606: Tokyo to Sydney - $650")
            Me.Controls.Add(cboFlights)

            ' ---------- DATE SELECTION ----------
            Dim lblDate As New Label()
            lblDate.Text = "Travel Date:"
            lblDate.Location = New Point(30, 100)
            lblDate.Width = 100
            lblDate.TextAlign = ContentAlignment.MiddleLeft
            Me.Controls.Add(lblDate)

            Dim dtpDate As New DateTimePicker()
            dtpDate.Name = "dtpDate"
            dtpDate.Location = New Point(150, 100)
            dtpDate.Width = 200
            dtpDate.Format = DateTimePickerFormat.Short
            dtpDate.MinDate = DateTime.Now.AddDays(1)
            dtpDate.MaxDate = DateTime.Now.AddMonths(6)
            Me.Controls.Add(dtpDate)

            ' ---------- PASSENGER DETAILS ----------
            Dim grpPassenger As New GroupBox()
            grpPassenger.Name = "grpPassenger"
            grpPassenger.Text = "Passenger Details"
            grpPassenger.Location = New Point(30, 140)
            grpPassenger.Width = 470
            grpPassenger.Height = 140
            Me.Controls.Add(grpPassenger)

            ' Name
            Dim lblName As New Label()
            lblName.Text = "Full Name:"
            lblName.Location = New Point(20, 30)
            lblName.Width = 100
            lblName.TextAlign = ContentAlignment.MiddleLeft
            grpPassenger.Controls.Add(lblName)

            Dim txtName As New TextBox()
            txtName.Name = "txtName"
            txtName.Location = New Point(120, 30)
            txtName.Width = 320
            grpPassenger.Controls.Add(txtName)

            ' Email
            Dim lblEmail As New Label()
            lblEmail.Text = "Email:"
            lblEmail.Location = New Point(20, 60)
            lblEmail.Width = 100
            lblEmail.TextAlign = ContentAlignment.MiddleLeft
            grpPassenger.Controls.Add(lblEmail)

            Dim txtEmail As New TextBox()
            txtEmail.Name = "txtEmail"
            txtEmail.Location = New Point(120, 60)
            txtEmail.Width = 320
            grpPassenger.Controls.Add(txtEmail)

            ' Phone
            Dim lblPhone As New Label()
            lblPhone.Text = "Phone:"
            lblPhone.Location = New Point(20, 90)
            lblPhone.Width = 100
            lblPhone.TextAlign = ContentAlignment.MiddleLeft
            grpPassenger.Controls.Add(lblPhone)

            Dim txtPhone As New TextBox()
            txtPhone.Name = "txtPhone"
            txtPhone.Location = New Point(120, 90)
            txtPhone.Width = 200
            grpPassenger.Controls.Add(txtPhone)

            ' ---------- SEAT SELECTION ----------
            Dim grpSeat As New GroupBox()
            grpSeat.Name = "grpSeat"
            grpSeat.Text = "Seat Selection"
            grpSeat.Location = New Point(30, 290)
            grpSeat.Width = 470
            grpSeat.Height = 100
            Me.Controls.Add(grpSeat)

            ' Seat class
            Dim lblClass As New Label()
            lblClass.Text = "Class:"
            lblClass.Location = New Point(20, 30)
            lblClass.Width = 100
            lblClass.TextAlign = ContentAlignment.MiddleLeft
            grpSeat.Controls.Add(lblClass)

            Dim cboClass As New ComboBox()
            cboClass.Name = "cboClass"
            cboClass.Location = New Point(120, 30)
            cboClass.Width = 200
            cboClass.DropDownStyle = ComboBoxStyle.DropDownList
            cboClass.Items.Add("Economy")
            cboClass.Items.Add("Premium Economy")
            cboClass.Items.Add("Business")
            cboClass.Items.Add("First Class")
            cboClass.SelectedIndex = 0
            grpSeat.Controls.Add(cboClass)

            ' Seat number
            Dim lblSeat As New Label()
            lblSeat.Text = "Seat Number:"
            lblSeat.Location = New Point(20, 60)
            lblSeat.Width = 100
            lblSeat.TextAlign = ContentAlignment.MiddleLeft
            grpSeat.Controls.Add(lblSeat)

            Dim txtSeat As New TextBox()
            txtSeat.Name = "txtSeat"
            txtSeat.Location = New Point(120, 60)
            txtSeat.Width = 100
            grpSeat.Controls.Add(txtSeat)

            ' Seat map button
            Dim btnSeatMap As New Button()
            btnSeatMap.Name = "btnSeatMap"
            btnSeatMap.Text = "View Seat Map"
            btnSeatMap.Location = New Point(230, 60)
            btnSeatMap.Width = 120
            btnSeatMap.Height = 25
            grpSeat.Controls.Add(btnSeatMap)
            AddHandler btnSeatMap.Click, AddressOf btnSeatMap_Click

            ' ---------- SPECIAL REQUESTS ----------
            Dim lblSpecialRequests As New Label()
            lblSpecialRequests.Text = "Special Requests:"
            lblSpecialRequests.Location = New Point(30, 400)
            lblSpecialRequests.Width = 120
            lblSpecialRequests.TextAlign = ContentAlignment.MiddleLeft
            Me.Controls.Add(lblSpecialRequests)

            Dim txtSpecialRequests As New TextBox()
            txtSpecialRequests.Name = "txtSpecialRequests"
            txtSpecialRequests.Location = New Point(150, 400)
            txtSpecialRequests.Width = 350
            txtSpecialRequests.Height = 40
            txtSpecialRequests.Multiline = True
            Me.Controls.Add(txtSpecialRequests)

            ' ---------- BUTTONS ----------
            Dim btnBook As New Button()
            btnBook.Name = "btnBook"
            btnBook.Text = "Book Flight"
            btnBook.Location = New Point(110, 460)
            btnBook.Width = 120
            btnBook.Height = 40
            btnBook.BackColor = Color.LightGreen
            btnBook.Font = New Font("Arial", 10, FontStyle.Bold)
            Me.Controls.Add(btnBook)
            AddHandler btnBook.Click, AddressOf btnBook_Click

            Dim btnClear As New Button()
            btnClear.Name = "btnClear"
            btnClear.Text = "Clear"
            btnClear.Location = New Point(240, 460)
            btnClear.Width = 120
            btnClear.Height = 40
            Me.Controls.Add(btnClear)
            AddHandler btnClear.Click, AddressOf btnClear_Click

            Dim btnClose As New Button()
            btnClose.Name = "btnClose"
            btnClose.Text = "Close"
            btnClose.Location = New Point(370, 460)
            btnClose.Width = 120
            btnClose.Height = 40
            Me.Controls.Add(btnClose)
            AddHandler btnClose.Click, AddressOf btnClose_Click


    End Sub

    ' Seat Map button click event
    Private Sub btnSeatMap_Click(sender As Object, e As EventArgs)

        MessageBox.Show("Seat Map would display here." & vbCrLf &
                            "Available seats: 1A-5F (First Class)" & vbCrLf &
                            "6A-10F (Business)" & vbCrLf &
                            "11A-20F (Premium Economy)" & vbCrLf &
                            "21A-40F (Economy)",
                            "Seat Map", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Book button click event
    Private Sub btnBook_Click(sender As Object, e As EventArgs)

        ' Get controls safely
        Dim cboFlights As ComboBox = DirectCast(Me.Controls("cboFlights"), ComboBox)
            Dim dtpDate As DateTimePicker = DirectCast(Me.Controls("dtpDate"), DateTimePicker)
            Dim grpPassenger As GroupBox = DirectCast(Me.Controls("grpPassenger"), GroupBox)
            Dim grpSeat As GroupBox = DirectCast(Me.Controls("grpSeat"), GroupBox)
            Dim txtSpecialRequests As TextBox = DirectCast(Me.Controls("txtSpecialRequests"), TextBox)

            ' Get passenger controls
            Dim txtName As TextBox = DirectCast(grpPassenger.Controls("txtName"), TextBox)
            Dim txtEmail As TextBox = DirectCast(grpPassenger.Controls("txtEmail"), TextBox)
            Dim txtPhone As TextBox = DirectCast(grpPassenger.Controls("txtPhone"), TextBox)

            ' Get seat controls
            Dim cboClass As ComboBox = DirectCast(grpSeat.Controls("cboClass"), ComboBox)
            Dim txtSeat As TextBox = DirectCast(grpSeat.Controls("txtSeat"), TextBox)

            ' Basic validation
            If cboFlights.SelectedIndex = -1 Then
                MessageBox.Show("Please select a flight!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cboFlights.Focus()
                Return
            End If

            If txtName.Text.Trim() = "" Then
                MessageBox.Show("Please enter passenger name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtName.Focus()
                Return
            End If

            If Not IsValidEmail(txtEmail.Text) Then
                MessageBox.Show("Please enter a valid email address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtEmail.Focus()
                Return
            End If

            If txtPhone.Text.Trim() = "" Then
                MessageBox.Show("Please enter a phone number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPhone.Focus()
                Return
            End If

            If txtSeat.Text.Trim() = "" Then
                MessageBox.Show("Please enter a seat number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtSeat.Focus()
                Return
            End If

            ' Generate booking reference
            Dim random As New Random()
            Dim bookingRef As String = "VB" & random.Next(10000, 99999).ToString()

            ' Show booking confirmation
            Dim flight As String = cboFlights.SelectedItem.ToString()
            Dim travelDate As String = dtpDate.Value.ToShortDateString()
            Dim name As String = txtName.Text
            Dim seatClass As String = cboClass.SelectedItem.ToString()
            Dim seat As String = txtSeat.Text

            ' Display confirmation dialog
            Dim confirmationMessage As String = "BOOKING CONFIRMED!" & vbCrLf &
                                              "Booking Reference: " & bookingRef & vbCrLf &
                                              "Flight: " & flight & vbCrLf &
                                              "Date: " & travelDate & vbCrLf &
                                              "Passenger: " & name & vbCrLf &
                                              "Class: " & seatClass & vbCrLf &
                                              "Seat: " & seat

            If txtSpecialRequests.Text.Trim() <> "" Then
                confirmationMessage &= vbCrLf & "Special Requests: " & txtSpecialRequests.Text
            End If

            MessageBox.Show(confirmationMessage, "Booking Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Create a new form to display the booking receipt
        ShowBookingReceipt(bookingRef, flight, travelDate, name, seatClass, seat, txtSpecialRequests.Text)
    End Sub

    ' Email validation function
    Private Function IsValidEmail(email As String) As Boolean
        If String.IsNullOrWhiteSpace(email) Then
            Return False
        End If

        ' Simple email validation
        Return email.Contains("@") AndAlso email.Contains(".")

    End Function

    ' Show booking receipt in a new form
    Private Sub ShowBookingReceipt(bookingRef As String, flight As String, travelDate As String,
                                  name As String, seatClass As String, seat As String,
                                  specialRequests As String)

        ' Create receipt form
        Dim frmReceipt As New Form()
            frmReceipt.Text = "Booking Receipt"
            frmReceipt.Width = 400
            frmReceipt.Height = 400
            frmReceipt.StartPosition = FormStartPosition.CenterParent
            frmReceipt.FormBorderStyle = FormBorderStyle.FixedDialog
            frmReceipt.MaximizeBox = False
            frmReceipt.MinimizeBox = False

            ' Receipt title
            Dim lblReceiptTitle As New Label()
            lblReceiptTitle.Text = "VB AIRWAYS BOOKING RECEIPT"
            lblReceiptTitle.Font = New Font("Arial", 12, FontStyle.Bold)
            lblReceiptTitle.TextAlign = ContentAlignment.MiddleCenter
            lblReceiptTitle.Location = New Point(0, 20)
            lblReceiptTitle.Width = frmReceipt.Width
            lblReceiptTitle.Height = 30
            frmReceipt.Controls.Add(lblReceiptTitle)

            ' Receipt details
            Dim lblDetails As New Label()
            lblDetails.Text = "Booking Reference: " & bookingRef & vbCrLf & vbCrLf &
                            "Flight: " & flight & vbCrLf &
                            "Date: " & travelDate & vbCrLf &
                            "Passenger: " & name & vbCrLf &
                            "Class: " & seatClass & vbCrLf &
                            "Seat: " & seat

            If specialRequests.Trim() <> "" Then
                lblDetails.Text &= vbCrLf & vbCrLf & "Special Requests: " & specialRequests
            End If

            lblDetails.Location = New Point(30, 70)
            lblDetails.Width = frmReceipt.Width - 60
            lblDetails.Height = 200
            frmReceipt.Controls.Add(lblDetails)

            ' Thank you message
            Dim lblThankYou As New Label()
            lblThankYou.Text = "Thank you for choosing VB Airways!"
            lblThankYou.Font = New Font("Arial", 10, FontStyle.Italic)
            lblThankYou.TextAlign = ContentAlignment.MiddleCenter
            lblThankYou.Location = New Point(0, 280)
            lblThankYou.Width = frmReceipt.Width
            lblThankYou.Height = 30
            frmReceipt.Controls.Add(lblThankYou)

            ' Print button
            Dim btnPrint As New Button()
            btnPrint.Text = "Print"
            btnPrint.Location = New Point(100, 320)
            btnPrint.Width = 80
            btnPrint.Height = 30
            frmReceipt.Controls.Add(btnPrint)
            AddHandler btnPrint.Click, Sub(sender, e) MessageBox.Show("Printing functionality would be implemented here.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Close button
            Dim btnClose As New Button()
            btnClose.Text = "Close"
            btnClose.Location = New Point(220, 320)
            btnClose.Width = 80
            btnClose.Height = 30
            frmReceipt.Controls.Add(btnClose)
            AddHandler btnClose.Click, Sub(sender, e) frmReceipt.Close()

            ' Show the receipt form
            frmReceipt.ShowDialog()

    End Sub

    ' Clear button click event
    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        ' Get controls safely
        Dim cboFlights As ComboBox = DirectCast(Me.Controls("cboFlights"), ComboBox)
        Dim dtpDate As DateTimePicker = DirectCast(Me.Controls("dtpDate"), DateTimePicker)
        Dim grpPassenger As GroupBox = DirectCast(Me.Controls("grpPassenger"), GroupBox)
        Dim grpSeat As GroupBox = DirectCast(Me.Controls("grpSeat"), GroupBox)
        Dim txtSpecialRequests As TextBox = DirectCast(Me.Controls("txtSpecialRequests"), TextBox)

        ' Get passenger controls
        Dim txtName As TextBox = DirectCast(grpPassenger.Controls("txtName"), TextBox)
        Dim txtEmail As TextBox = DirectCast(grpPassenger.Controls("txtEmail"), TextBox)
        Dim txtPhone As TextBox = DirectCast(grpPassenger.Controls("txtPhone"), TextBox)

        ' Get seat controls
        Dim cboClass As ComboBox = DirectCast(grpSeat.Controls("cboClass"), ComboBox)
        Dim txtSeat As TextBox = DirectCast(grpSeat.Controls("txtSeat"), TextBox)

        ' Clear all fields
        cboFlights.SelectedIndex = -1
        dtpDate.Value = DateTime.Now.AddDays(1)
        txtName.Text = ""
        txtEmail.Text = ""
        txtPhone.Text = ""
        cboClass.SelectedIndex = 0
        txtSeat.Text = ""
        txtSpecialRequests.Text = ""

        ' Focus on first field
        cboFlights.Focus()

    End Sub

    ' Close button click event
    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class