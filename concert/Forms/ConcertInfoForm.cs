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
    public partial class ConcertInfoForm : Form
    {
        public ConcertInfoForm()
        {
            InitializeComponent();
            LoadConcertInfo();
        }

        private void LoadConcertInfo()
        {
            string connStr = "server=localhost;user=root;password=;database=concertdb;";
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM concert LIMIT 1";
                using( var cmd = new MySqlCommand(query, conn))
                {
                    using( var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            labelTitle.Text = reader["title"].ToString();
                            textBoxDescription.Text = reader["description"].ToString();
                            labelLocation.Text = reader["location"].ToString();
                            labelDateTime.Text = Convert.ToDateTime(reader["datetime"]).ToString("g");
                        }
                    }
                }
                

            }
        }
    }
}
