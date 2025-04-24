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
using concert.Pages.Menu;
using Menu = concert.Pages.Menu.Menu;
using concert.Pages.TicketsOrder;
using concert.Pages.Images;

namespace concert
{
    public partial class Main : Form
    {
        public Main()
        {
            this.Size = new Size(1720, 920);
            this.BackColor = Color.White;
            InitHeader();
            InitButton();
            InitBody();
        }

        private void InitHeader()
        {
            this.Header = new Panel();
            this.Header.Location = new Point(0, 0);
            this.Header.Size = new Size(this.ClientSize.Width, 80);
            this.Header.BackColor = ColorTranslator.FromHtml("#141929");

            this.Controls.Add(this.Header);
        }
        private void InitButton()
        {
            this.MainPage = new Button();
            this.Pictures = new Button();
            this.Logout = new Button();
            this.BuyTicket = new Button();
            Dictionary <string, Button> buttons = new Dictionary<string, Button>()
            {
                {"Main", MainPage},
                {"Pictures", Pictures },
                {"Buy ticket", BuyTicket},
            };
            
            MainPage.Click += MainPage_Click;
            Pictures.Click += PicturesPage_Click;
            BuyTicket.Click += BuyTicket_Click;
            int currentX = 0;
            int betweenButtons = 100;
            foreach (KeyValuePair<string, Button> button in buttons)
            {
                button.Value.BackColor = Color.Black;
                button.Value.ForeColor = Color.White;
                button.Value.Size = new Size(200, this.Header.ClientSize.Height);
                button.Value.Location = new Point(currentX, this.Header.Height / 2 - button.Value.Height / 2);
                Console.WriteLine($"size x {button.Value.Size.Width} size y {button.Value.Size.Height}  | x{button.Value.Location.X} y {button.Value.Location.Y}");
                button.Value.Text = button.Key;
                currentX += button.Value.Width + betweenButtons;
               
                Header.Controls.Add(button.Value);
            }

        }

        private void BuyTicket_Click(object sender, EventArgs e)
        {
            ClearBody();
            this.BodyPanel.Controls.Add(new TicketsOrder());
        }

        private void PicturesPage_Click(object sender, EventArgs e)
        {
            ClearBody();
            this.BodyPanel.Controls.Add(new Images());

        }

        private void MainPage_Click(object sender, EventArgs e)
        {
            ClearBody();
            this.BodyPanel.Controls.Add(new Menu());
        }
        private void ClearBody()
        {
            this.BodyPanel.Controls.Clear();
            this.BodyPanel.Refresh();
            this.BodyPanel.Invalidate();
        }
        private void InitBody()
        {
            BodyPanel = new Panel();
            BodyPanel.Location = new Point(0, 80);
            BodyPanel.Size = new Size(this.Width, this.Height - 80);
            BodyPanel.BackColor = ColorTranslator.FromHtml("#232736");
            this.Controls.Add (BodyPanel);
        }
    }
}
