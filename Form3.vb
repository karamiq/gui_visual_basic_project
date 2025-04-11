Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Iraqi Airways Available Flight"
        Me.Size = New Size(1300, 550)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle

        Dim dataGridView = New DataGridView()
        dataGridView.Name = "dataGridView"
        dataGridView.Location = New Point(20, 60)
        dataGridView.Size = New Size(1200, 400)
        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dataGridView.Columns.Add("FlightNumber", "Flight Number")
        dataGridView.Columns.Add("DepartureTime", "Departure Time")
        dataGridView.Columns.Add("ArrivalTime", "Arrival Time")
        dataGridView.Columns.Add("Status", "Status")
        dataGridView.Columns.Add("AircraftType", "Aircraft Type")
        dataGridView.Columns.Add("DepartureAirport", "Departure Airport")
        dataGridView.Columns.Add("ArrivalAirport", "Arrival Airport")
        dataGridView.Columns.Add("FlightDuration", "Flight Duration")
        Me.Controls.Add(dataGridView)

        dataGridView.Rows.Add("IA123", "2025-04-10 08:00", "2025-04-10 11:00", "On Time", "Airbus A320", "Baghdad International", "Dubai International", "3h 0m")
        dataGridView.Rows.Add("IA124", "2025-04-10 14:00", "2025-04-10 17:00", "Delayed", "Boeing 737", "Baghdad International", "Cairo International", "3h 0m")
        dataGridView.Rows.Add("IA125", "2025-04-10 18:00", "2025-04-10 21:00", "On Time", "Airbus A330", "Basra International", "Amman International", "3h 0m")
        dataGridView.Rows.Add("IA126", "2025-04-10 22:00", "2025-04-11 01:00", "Delayed", "Boeing 777", "Baghdad International", "Beirut International", "4h 0m")
        dataGridView.Rows.Add("IA127", "2025-04-11 06:00", "2025-04-11 09:00", "Cancelled", "Airbus A310", "Najaf International", "Tehran Imam Khomeini", "3h 0m")
        dataGridView.Rows.Add("IA128", "2025-04-11 11:00", "2025-04-11 14:00", "On Time", "Boeing 787", "Baghdad International", "Frankfurt Airport", "5h 0m")
        dataGridView.Rows.Add("IA129", "2025-04-11 16:00", "2025-04-11 19:00", "On Time", "Airbus A350", "Sulaymaniyah Airport", "Istanbul Airport", "3h 0m")
    End Sub


End Class

