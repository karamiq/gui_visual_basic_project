Public Class Form2
    Private Sub frmBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Iraq Airways Booking"
        Me.Width = 550
        Me.Height = 550
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False

        Dim lblHeading As New Label()
        lblHeading.Text = "IRAQ AIRWAYS BOOKING"
        lblHeading.Font = New Font("Arial", 16, FontStyle.Bold)
        lblHeading.TextAlign = ContentAlignment.MiddleCenter
        lblHeading.Location = New Point(0, 10)
        lblHeading.Width = Me.Width
        lblHeading.Height = 30
        Me.Controls.Add(lblHeading)

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
        cboFlights.Items.Add("IA445: Baghdad to Dubai - $320")
        cboFlights.Items.Add("IA237: Baghdad to London - $480")
        cboFlights.Items.Add("IA117: Basra to Istanbul - $300")
        cboFlights.Items.Add("IA526: Erbil to Frankfurt - $420")
        cboFlights.Items.Add("IA333: Baghdad to Cairo - $250")
        cboFlights.Items.Add("IA764: Najaf to Tehran - $180")
        Me.Controls.Add(cboFlights)

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

        Dim grpPassenger As New GroupBox()
        grpPassenger.Name = "grpPassenger"
        grpPassenger.Text = "Passenger Details"
        grpPassenger.Location = New Point(30, 140)
        grpPassenger.Width = 470
        grpPassenger.Height = 140
        Me.Controls.Add(grpPassenger)

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

        Dim grpSeat As New GroupBox()
        grpSeat.Name = "grpSeat"
        grpSeat.Text = "Seat Selection"
        grpSeat.Location = New Point(30, 290)
        grpSeat.Width = 470
        grpSeat.Height = 100
        Me.Controls.Add(grpSeat)

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

        Dim btnSeatMap As New Button()
        btnSeatMap.Name = "btnSeatMap"
        btnSeatMap.Text = "View Seat Map"
        btnSeatMap.Location = New Point(230, 60)
        btnSeatMap.Width = 120
        btnSeatMap.Height = 25
        grpSeat.Controls.Add(btnSeatMap)
        AddHandler btnSeatMap.Click, AddressOf btnSeatMap_Click

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

    Private Sub btnSeatMap_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Seat Map:" & vbCrLf &
                        "1A-5F (First Class)" & vbCrLf &
                        "6A-10F (Business)" & vbCrLf &
                        "11A-20F (Premium Economy)" & vbCrLf &
                        "21A-40F (Economy)",
                        "Available Seats", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs)
        Dim cboFlights As ComboBox = DirectCast(Me.Controls("cboFlights"), ComboBox)
        Dim dtpDate As DateTimePicker = DirectCast(Me.Controls("dtpDate"), DateTimePicker)
        Dim grpPassenger As GroupBox = DirectCast(Me.Controls("grpPassenger"), GroupBox)
        Dim grpSeat As GroupBox = DirectCast(Me.Controls("grpSeat"), GroupBox)
        Dim txtSpecialRequests As TextBox = DirectCast(Me.Controls("txtSpecialRequests"), TextBox)

        Dim txtName As TextBox = DirectCast(grpPassenger.Controls("txtName"), TextBox)
        Dim txtEmail As TextBox = DirectCast(grpPassenger.Controls("txtEmail"), TextBox)
        Dim txtPhone As TextBox = DirectCast(grpPassenger.Controls("txtPhone"), TextBox)

        Dim cboClass As ComboBox = DirectCast(grpSeat.Controls("cboClass"), ComboBox)
        Dim txtSeat As TextBox = DirectCast(grpSeat.Controls("txtSeat"), TextBox)

        If cboFlights.SelectedIndex = -1 Then
            MessageBox.Show("Please select a flight!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboFlights.Focus()
            Return
        End If

        If txtName.Text.Trim() = "" Then
            MessageBox.Show("Please enter the passenger's name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtName.Focus()
            Return
        End If

        If Not isEmailValid(txtEmail.Text) Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return
        End If

        If txtPhone.Text.Trim() = "" Then
            MessageBox.Show("Please enter a phone number.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPhone.Focus()
            Return
        End If

        If txtSeat.Text.Trim() = "" Then
            MessageBox.Show("Please enter a seat number.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSeat.Focus()
            Return
        End If

        MessageBox.Show("Booking confirmed for " & txtName.Text & " on " & cboFlights.SelectedItem.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        Dim grpPassenger As GroupBox = DirectCast(Me.Controls("grpPassenger"), GroupBox)
        Dim grpSeat As GroupBox = DirectCast(Me.Controls("grpSeat"), GroupBox)

        DirectCast(Me.Controls("cboFlights"), ComboBox).SelectedIndex = -1
        DirectCast(Me.Controls("dtpDate"), DateTimePicker).Value = DateTime.Now.AddDays(1)
        DirectCast(grpPassenger.Controls("txtName"), TextBox).Clear()
        DirectCast(grpPassenger.Controls("txtEmail"), TextBox).Clear()
        DirectCast(grpPassenger.Controls("txtPhone"), TextBox).Clear()
        DirectCast(grpSeat.Controls("cboClass"), ComboBox).SelectedIndex = 0
        DirectCast(grpSeat.Controls("txtSeat"), TextBox).Clear()
        DirectCast(Me.Controls("txtSpecialRequests"), TextBox).Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Function isEmailValid(ByVal email As String) As Boolean
        If email.Contains("@") And email.Contains(".") Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
