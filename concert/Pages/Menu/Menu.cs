using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace concert.Pages.Menu
{
    public partial class Menu: UserControl
    {
        private Label ConcertName { get; set; }
        private Label Description { get; set; }
        public Menu()
        {
            this.ClientSize = new System.Drawing.Size(1720, 840);
            this.ConcertName = new Label();
            this.Description = new Label();

            ConcertName.Text = "Concert";
            ConcertName.Font = new System.Drawing.Font("Arial", 25);
            ConcertName.ForeColor = System.Drawing.Color.White;
            ConcertName.AutoSize = true;
            this.ConcertName.Location = new System.Drawing.Point(this.Width / 2 - this.ConcertName.Width / 2, 50);
            Description.Text = "Lorem ipsum";
            Description.Font = new System.Drawing.Font("Arial", 18);
            Description.ForeColor = System.Drawing.Color.White;
            Description.AutoSize = true;
            Description.Location = new System.Drawing.Point(this.Width / 2 - Description.Width / 2, ConcertName.Location.Y + 50);
            this.Controls.Add(this.ConcertName);
            this.Controls.Add(this.Description);
        }
    }
}
