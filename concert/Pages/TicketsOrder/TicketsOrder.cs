using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace concert.Pages.TicketsOrder
{
    public partial class TicketsOrder: UserControl
    {
        private Label DateTimePickerLabel { get; set; }
        private DateTimePicker DateTimePicker { get; set; }
        private Button BuyTicket { get; set; }
        private NumericUpDown Numeric { get; set; }
        private Label TicketsCount { get; set; }
        public TicketsOrder()
        {
            this.ClientSize = new Size(1720, 840);
            DateTimePicker = new DateTimePicker();

            DateTimePickerLabel = new Label();
            DateTimePickerLabel.AutoSize = true;
            DateTimePickerLabel.Text = "Choose the date";
            DateTimePickerLabel.ForeColor = Color.White;
            DateTimePickerLabel.Font = new Font("Arial", 15);

            Console.WriteLine(this.Width);
            DateTimePicker.Location = new Point(this.ClientSize.Width / 2 - DateTimePicker.Width / 2, 50);
            DateTimePickerLabel.Location = new Point(DateTimePicker.Location.X, DateTimePicker.Location.Y - DateTimePicker.Height - 20);
            
            TicketsCount = new Label();
            TicketsCount.AutoSize = true;
            TicketsCount.Text = "Choose number of tickets";

            Numeric = new NumericUpDown();

            TicketsCount.Location = new Point(this.Width / 2 - TicketsCount.Width / 2, DateTimePicker.Location.Y + 20);

            BuyTicket = new Button();
            BuyTicket.Text = "Buy ticket";
            BuyTicket.Size = new Size(150, 40);
            BuyTicket.Location = new Point(this.ClientSize.Width / 2 - BuyTicket.Width / 2, DateTimePicker.Location.Y + BuyTicket.Height + 20);
            BuyTicket.BackColor = Color.White;
            BuyTicket.ForeColor = Color.Black;

            this.Controls.Add(BuyTicket);
            this.Controls.Add(DateTimePicker);
            this.Controls.Add(DateTimePickerLabel);
        }

    }
}
