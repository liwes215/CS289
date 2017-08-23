using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_PokemonsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            outputLabel.Text = String.Format("輸入的Pokemon編號為{0},名稱為{1}。\n" +
               "種類為{2},高度為{3},重量為{4}(lbs)。"
               , numTextBox.Text, nameTextBox.Text, categoryTextBox.Text, heightTextBox.Text, weightTextBox.Text);
        }

        private void numTextBox_TextChanged(object sender, EventArgs e)
        {
            outputLabel.Text = String.Format("輸入的Pokemon編號為{0},名稱為{1}。\n" +
   "種類為{2},高度為{3},重量為{4}(lbs)。"
   , numTextBox.Text, nameTextBox.Text, categoryTextBox.Text, heightTextBox.Text, weightTextBox.Text);
        }

        private void categoryTextBox_TextChanged(object sender, EventArgs e)
        {
            outputLabel.Text = String.Format("輸入的Pokemon編號為{0},名稱為{1}。\n" +
   "種類為{2},高度為{3},重量為{4}(lbs)。"
   , numTextBox.Text, nameTextBox.Text, categoryTextBox.Text, heightTextBox.Text, weightTextBox.Text);
        }

        private void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            outputLabel.Text = String.Format("輸入的Pokemon編號為{0},名稱為{1}。\n" +
   "種類為{2},高度為{3},重量為{4}(lbs)。"
   , numTextBox.Text, nameTextBox.Text, categoryTextBox.Text, heightTextBox.Text, weightTextBox.Text);
        }

        private void weightTextBox_TextChanged(object sender, EventArgs e)
        {
            outputLabel.Text = String.Format("輸入的Pokemon編號為{0},名稱為{1}。\n" +
   "種類為{2},高度為{3},重量為{4}(lbs)。"
   , numTextBox.Text, nameTextBox.Text, categoryTextBox.Text, heightTextBox.Text, weightTextBox.Text);
        }
    }
}