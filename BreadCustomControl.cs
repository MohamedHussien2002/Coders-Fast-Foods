using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FastFoodDemo
{
	public partial class BreadCustomControl : UserControl
	{
		public static string breadName;
    	public static int breadPrice;
    	public static int b;
    	
		public BreadCustomControl()
		{
			InitializeComponent();
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			breadName = "Challah";
			breadPrice = 15;
			listBox1.Items.Add(breadName);
        	listBox2.Items.Add(breadPrice);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			breadName = "Multigrain";
			breadPrice = 30;
			listBox1.Items.Add(breadName);
        	listBox2.Items.Add(breadPrice);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			breadName = "Brioche";
			breadPrice = 45;
			listBox1.Items.Add(breadName);
        	listBox2.Items.Add(breadPrice);
		}
		
		void BreadTotalClick(object sender, EventArgs e)
		{
			
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
        	listBox2.Items.Clear();
        	breadTotal.Text = "";
        	using ( Thanks pop = new Thanks () )
        	{
        		pop.ShowDialog();
        	}
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			int totalbread = 0;
			for ( b = 0; b < listBox2.Items.Count ; b++ )
			{
				totalbread+= Convert.ToInt32(listBox2.Items[b]);
			}
			breadTotal.Text = totalbread.ToString();
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			for ( b = 0 ; b < listBox1.SelectedItems.Count ; b++)
        		listBox1.Items.Remove(listBox1.SelectedItems[b]);
        	
        	for ( b = 0 ; b < listBox2.SelectedItems.Count ; b++)
				listBox2.Items.Remove(listBox2.SelectedItems[b]);
		}
	}
}
