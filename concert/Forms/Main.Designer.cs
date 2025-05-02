namespace concert
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(379, 61);
            this.button2.TabIndex = 0;
            this.button2.Text = "Concert info";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnConcertInfo_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(331, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(379, 59);
            this.button3.TabIndex = 1;
            this.button3.Text = "Photos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnPhotos_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(331, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(379, 56);
            this.button4.TabIndex = 2;
            this.button4.Text = "Booking form";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1160, 464);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

