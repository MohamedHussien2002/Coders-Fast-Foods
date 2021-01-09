using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FastFoodDemo
{
	public partial class CustomerService : UserControl
	{
		public CustomerService()
		{
			InitializeComponent();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			using ( Form3 app = new Form3() )
			{
				app.ShowDialog();
			}
			
		}
	}
}
