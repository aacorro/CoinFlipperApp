using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinFlipApp
{
	public partial class Form1 : Form
	{

		//array of coins
		Coin[] coins = new Coin[5];

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < coins.Length; i++)
			{
				coins[i] = new Coin(false);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Random r = new Random();

			//display the labels
			label1.Text = "";
			for (int i = 0; i < coins.Length; i++)
			{
				label1.Text += coins[i].isHeads + ",";
				coins[i].flipCoin(r);
			}
			//set the pictures
			pictureBox1.Image = coins[0].isHeads ? Properties.Resources.coinFace : Properties.Resources.coinTail;
			pictureBox2.Image = coins[1].isHeads ? Properties.Resources.coinFace : Properties.Resources.coinTail;
			pictureBox3.Image = coins[2].isHeads ? Properties.Resources.coinFace : Properties.Resources.coinTail;
			pictureBox4.Image = coins[3].isHeads ? Properties.Resources.coinFace : Properties.Resources.coinTail;
			pictureBox5.Image = coins[4].isHeads ? Properties.Resources.coinFace : Properties.Resources.coinTail;

			
		}

	}
}
