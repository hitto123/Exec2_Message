using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Message
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Showlabel1.Text=string.Empty;
		}

		private void button_Click(object sender, EventArgs e)
		{
			DateTime now=DateTime.Now;
			string time = now.ToString();
			ShowtextBox.Text = time;
			Showlabel1.Text = now.ToString("yyyy/MM/dd") +"\r\n"+"你好";

		}
	}
}
