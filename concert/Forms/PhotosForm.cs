using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace concert.Forms
{
    public partial class PhotosForm : Form
    {
        public PhotosForm()
        {
            InitializeComponent();
            LoadPhotos();
        }

        private void LoadPhotos()
        {
            using (var conn = new MySqlConnection(AppData.ConnectionString))
            {
                conn.Open();
                string query = "SELECT file_path FROM photos";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var path = reader.GetString(0);
                            if (File.Exists(path))
                            {
                                PictureBox pic = new PictureBox();
                                pic.Image = Image.FromFile(path);
                                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                                pic.Width = 100;
                                pic.Height = 100;
                                flowLayoutPanel1.Controls.Add(pic);
                            }
                        }
                    }
                    
                }

            }
        }
    }
}
