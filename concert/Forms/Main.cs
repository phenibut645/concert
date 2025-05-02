using concert.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace concert
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnConcertInfo_Click(object sender, EventArgs e)
        {
            new ConcertInfoForm().ShowDialog();
        }

        private void btnPhotos_Click(object sender, EventArgs e)
        {
            new PhotosForm().ShowDialog();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            new BookingForm().ShowDialog();
        }
    }
}
