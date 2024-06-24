using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RGR
{
    public class Bus
    {
        public int BusNumber { get; set; }
        public string DeparturePoint { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public decimal TicketPrice { get; set; }

        public Bus(int busNumber, string departurePoint, string destination, DateTime departureTime, decimal ticketPrice)
        {
            BusNumber = busNumber;
            DeparturePoint = departurePoint;
            Destination = destination;
            DepartureTime = departureTime;
            TicketPrice = ticketPrice;
        }

        public override string ToString()
        {
            return $"Bus Number: {BusNumber}, Departure Point: {DeparturePoint}, Destination: {Destination}, Departure Time: {DepartureTime}, Ticket Price: {TicketPrice}";
        }
    }

    public class BusStation
    {
        private List<Bus> buses;

        public BusStation()
        {
            buses = new List<Bus>();
        }

        public void AddBus(Bus bus)
        {
            buses.Add(bus);
        }

        public void RemoveBus(int busNumber)
        {
            Bus busToRemove = buses.Find(bus => bus.BusNumber == busNumber);
            if (busToRemove != null)
            {
                buses.Remove(busToRemove);
            }
        }

        public List<Bus> GetAllBuses()
        {
            return buses;
        }
    }

    public partial class Form1 : Form
    {
        private BusStation busStation;

        public Form1()
        {
            InitializeComponent();
            busStation = new BusStation();
        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            int busNumber;
            string departurePoint = txtDeparturePoint.Text;
            string destination = txtDestination.Text;
            DateTime departureTime;
            decimal ticketPrice;

            if (!int.TryParse(txtBusNumber.Text, out busNumber))
            {
                MessageBox.Show("Некорректный номер автобуса. Пожалуйста, введите целое число.");
                return;
            }

            if (!DateTime.TryParse(txtDepartureTime.Text, out departureTime))
            {
                MessageBox.Show("Некорректный формат времени отправления. Пожалуйста, введите дату и время в правильном формате.");
                return;
            }

            if (!decimal.TryParse(txtTicketPrice.Text, out ticketPrice))
            {
                MessageBox.Show("Некорректная цена билета. Пожалуйста, введите число.");
                return;
            }

            Bus newBus = new Bus(busNumber, departurePoint, destination, departureTime, ticketPrice);
            busStation.AddBus(newBus);
            UpdateBusList();
        }

        private void btnRemoveBus_Click(object sender, EventArgs e)
        {
            int busNumber;

            if (!int.TryParse(txtBusNumber.Text, out busNumber))
            {
                MessageBox.Show("Некорректный номер автобуса. Пожалуйста, введите целое число.");
                return;
            }

            busStation.RemoveBus(busNumber);
            UpdateBusList();
        }

        private void UpdateBusList()
        {
            listBoxBuses.Items.Clear();
            foreach (Bus bus in busStation.GetAllBuses())
            {
                listBoxBuses.Items.Add(bus.ToString());
            }
        }
    }
}