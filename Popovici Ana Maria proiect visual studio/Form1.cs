using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Popovici_Ana_Maria_proiect_visual_studio
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form3 b2 = new Form3();
			b2.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form4 b3 = new Form4();
			b3.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Form5 b4 = new Form5();
			b4.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form2 b1 = new Form2();
			b1.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Form6 b5 = new Form6();
			b5.Show();
		}
	}
}
