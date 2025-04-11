Public Class Form1
    Private Sub frmIntro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form properties
        Me.Text = "Iraqi Airways"
        Me.Width = 600
        Me.Height = 450
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False


        ' Logo/Titles
        Dim lblTitle As New Label()
        lblTitle.Text = "WELCOME TO IRAQI AIRWAYS"

        lblTitle.Font = New Font("Arial", 20, FontStyle.Bold)
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        lblTitle.Location = New Point(0, 30)
        lblTitle.Width = Me.Width
        lblTitle.Height = 40
        Me.Controls.Add(lblTitle)

        ' Subtitle
        Dim lblSubtitle As New Label()
        lblSubtitle.Text = "Your simple flight booking solution"
        lblSubtitle.Font = New Font("Arial", 12, FontStyle.Italic)
        lblSubtitle.TextAlign = ContentAlignment.MiddleCenter
        lblSubtitle.Location = New Point(0, 70)
        lblSubtitle.Width = Me.Width
        lblSubtitle.Height = 30
        Me.Controls.Add(lblSubtitle)

        ' Services Group
        Dim grpServices As New GroupBox()
        grpServices.Text = "Our Services"
        grpServices.Location = New Point(50, 120)
        grpServices.Width = 500
        grpServices.Height = 200
        Me.Controls.Add(grpServices)

        ' Booking Button
        Dim btnBooking As New Button()
        btnBooking.Text = "Flight Booking"
        btnBooking.Location = New Point(30, 40)
        btnBooking.Width = 200
        btnBooking.Height = 50
        btnBooking.BackColor = Color.LightGreen
        btnBooking.Font = New Font("Arial", 12, FontStyle.Bold)
        grpServices.Controls.Add(btnBooking)
        AddHandler btnBooking.Click, AddressOf btnBooking_Click

        ' Check Status Button
        Dim btnStatus As New Button()
        btnStatus.Text = "Check Flight Status"
        btnStatus.Location = New Point(260, 40)
        btnStatus.Width = 200
        btnStatus.Height = 50
        btnStatus.Font = New Font("Arial", 12)
        grpServices.Controls.Add(btnStatus)
        AddHandler btnStatus.Click, AddressOf btnStatus_Click

        ' Check-in Button
        Dim btnCheckin As New Button()
        btnCheckin.Text = "Online Check-in"
        btnCheckin.Location = New Point(30, 120)
        btnCheckin.Width = 200
        btnCheckin.Height = 50
        btnCheckin.Font = New Font("Arial", 12)
        grpServices.Controls.Add(btnCheckin)
        AddHandler btnCheckin.Click, AddressOf btnCheckin_Click

        ' Customer Support Button
        Dim btnSupport As New Button()
        btnSupport.Text = "Customer Support"
        btnSupport.Location = New Point(260, 120)
        btnSupport.Width = 200
        btnSupport.Height = 50
        btnSupport.Font = New Font("Arial", 12)
        grpServices.Controls.Add(btnSupport)
        AddHandler btnSupport.Click, AddressOf btnSupport_Click

        ' Exit Button
        Dim btnExit As New Button()
        btnExit.Text = "Exit"
        btnExit.Location = New Point(250, 350)
        btnExit.Width = 100
        btnExit.Height = 40
        Me.Controls.Add(btnExit)
        AddHandler btnExit.Click, AddressOf btnExit_Click
    End Sub

    ' Booking Button Click Event
    Private Sub btnBooking_Click(sender As Object, e As EventArgs)
        Dim bookingForm As New Form2()
        bookingForm.ShowDialog()

    End Sub

    ' Check Status Button Click Event
    Private Sub btnStatus_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Flight Status feature is coming soon.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Check-in Button Click Event
    Private Sub btnCheckin_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Online Check-in feature is coming soon.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Customer Support Button Click Event
    Private Sub btnSupport_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Customer Support: +964-772-883-3423" & vbCrLf & "Email: support@iraqairways.gov", "Customer Support", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Exit Button Click Event
    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
End Class
