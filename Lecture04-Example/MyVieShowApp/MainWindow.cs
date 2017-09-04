using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyVieShowApp
{
    public partial class MainWindow : Form
    {
        private PictureBox[] seats;
        private Random random;
        private bool[] seatsAvail;

        public MainWindow()
        {
            InitializeComponent();
            random = new Random();
            seats = new PictureBox[20];
            seatsAvail = new bool[20];
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            int x_ini = 12;
            int y_ini = 12;
            int numberOfRow = 6;
            int w = 80;
            int h = 120;
            int g = 10;
            for (int count = 0; count < seats.Length; count++)
            {
                int randomNumber = random.Next(1, 7);
                int row = count / numberOfRow;
                int col = count % numberOfRow;
                seats[count] = new PictureBox();

                seats[count].Image = randomNumber > 2 ?
                    Properties.Resources.seat_avail :
                    Properties.Resources.seat_unavail;
                seatsAvail[count] = randomNumber > 2;
                //if (randomNumber > 2)
                //{
                //    seats[count].Image = Properties.Resources.seat_avail;
                //    seatsAvail[count] = true;
                //}
                //else
                //{
                //    seats[count].Image = Properties.Resources.seat_unavail;
                //    seatsAvail[count] = false;
                //}
                int x = x_ini + (w + g) * col;
                int y = y_ini + (h + g) * row;
                seats[count].Location = new Point(x, y);
                seats[count].Size = new Size(w, h);
                seats[count].SizeMode = PictureBoxSizeMode.Zoom;
                this.Controls.Add(seats[count]);
            }
        }

        private void summitButton_Click(object sender, EventArgs e)
        {
            int numberOfPeople = selectNumberComboBox.SelectedIndex + 1;
            MessageBox.Show(numberOfPeople.ToString());

            //for(int number = 0; number < seatsAvail.Length; number ++)
        }
    }
}