Public Class Form1
    Private Sub frmIntro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Iraqi Airways"
        Me.Width = 600
        Me.Height = 450

        Me.FormBorderStyle = FormBorderStyle.FixedSingle




        Dim lblTitle As New Label()
        lblTitle.Text = "WELCOME TO IRAQI AIRWAYS"

        lblTitle.Font = New Font("Arial", 20, FontStyle.Bold)
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        lblTitle.Location = New Point(0, 30)
        lblTitle.Width = Me.Width
        lblTitle.Height = 40
        Me.Controls.Add(lblTitle)

        Dim lblSubtitle As New Label()
        lblSubtitle.Text = "Your simple flight booking solution"
        lblSubtitle.Font = New Font("Arial", 12, FontStyle.Italic)
        lblSubtitle.TextAlign = ContentAlignment.MiddleCenter
        lblSubtitle.Location = New Point(0, 70)
        lblSubtitle.Width = Me.Width
        lblSubtitle.Height = 30
        Me.Controls.Add(lblSubtitle)


        Dim grpServices As New GroupBox()
        grpServices.Text = "Our Services"
        grpServices.Location = New Point(50, 120)
        grpServices.Width = 500
        grpServices.Height = 200
        Me.Controls.Add(grpServices)


        Dim btnBooking As New Button()
        btnBooking.Text = "Flight Booking"
        btnBooking.Location = New Point(30, 40)
        btnBooking.Width = 200
        btnBooking.Height = 50
        btnBooking.BackColor = Color.LightGreen
        btnBooking.Font = New Font("Arial", 12, FontStyle.Bold)
        grpServices.Controls.Add(btnBooking)
        AddHandler btnBooking.Click, AddressOf btnBooking_Click

        Dim btnStatus As New Button()
        btnStatus.Text = "Available Flights"
        btnStatus.Location = New Point(260, 40)
        btnStatus.Width = 200
        btnStatus.Height = 50
        btnStatus.Font = New Font("Arial", 12)
        grpServices.Controls.Add(btnStatus)
        AddHandler btnStatus.Click, AddressOf btnAvaliableFlights_Click

        Dim btnCheckin As New Button()
        btnCheckin.Text = "Online Check-in"
        btnCheckin.Location = New Point(30, 120)
        btnCheckin.Width = 200
        btnCheckin.Height = 50
        btnCheckin.Font = New Font("Arial", 12)
        grpServices.Controls.Add(btnCheckin)
        AddHandler btnCheckin.Click, AddressOf btnCheckin_Click

        Dim btnSupport As New Button()
        btnSupport.Text = "Customer Support"
        btnSupport.Location = New Point(260, 120)
        btnSupport.Width = 200
        btnSupport.Height = 50
        btnSupport.Font = New Font("Arial", 12)
        grpServices.Controls.Add(btnSupport)
        AddHandler btnSupport.Click, AddressOf btnSupport_Click

        Dim btnExit As New Button()
        btnExit.Text = "Exit"
        btnExit.Location = New Point(250, 350)
        btnExit.Width = 100
        btnExit.Height = 40
        Me.Controls.Add(btnExit)
        AddHandler btnExit.Click, AddressOf btnExit_Click
    End Sub

    Private Sub btnBooking_Click(sender As Object, e As EventArgs)

        Form2.ShowDialog()

    End Sub


    Private Sub btnAvaliableFlights_Click(sender As Object, e As EventArgs)
        Form3.Show()
    End Sub

    Private Sub btnCheckin_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Online Check-in feature is coming soon.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSupport_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Customer Support: +964-772-883-3423" & vbCrLf & "Email: support@iraqairways.gov", "Customer Support", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class
