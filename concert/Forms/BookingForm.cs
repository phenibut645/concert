using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace concert.Forms
{
    public partial class BookingForm : Form
    {
        decimal pricePerTicket = 10m;

        public BookingForm()
        {
            InitializeComponent();
            LoadConcertDates();
            numericUpDown1.ValueChanged += (s, e) => CalculatePrice();
        }

        private void LoadConcertDates()
        {
            using( var conn = new MySqlConnection(AppData.ConnectionString))
            {
                conn.Open();
                string query = "SELECT id, datetime FROM concert";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxDates.Items.Add(new ComboBoxItem
                            {
                                Text = Convert.ToDateTime(reader["datetime"]).ToString("g"),
                                Value = reader["id"]
                            });
                        }
                        if (comboBoxDates.Items.Count > 0) comboBoxDates.SelectedIndex = 0;
                    }
                }
            }
        }

        private void CalculatePrice()
        {
            int count = (int)numericUpDown1.Value;
            labelTotal.Text = $"Hind kokku: {count * pricePerTicket} €";
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (comboBoxDates.SelectedItem is ComboBoxItem selectedItem)
            {
                int concertId = (int)selectedItem.Value;
                int ticketCount = (int)numericUpDown1.Value;
                decimal total = ticketCount * pricePerTicket;
                using( var conn = new MySqlConnection(AppData.ConnectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO booking (concert_id, ticket_count, total_price) VALUES (@cid, @count, @price)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cid", concertId);
                        cmd.Parameters.AddWithValue("@count", ticketCount);
                        cmd.Parameters.AddWithValue("@price", total);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Broneering salvestatud!", "Edu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                }

            }
        }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString() => Text;
    }
}
