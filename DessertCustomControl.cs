using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
	public partial class DessertCustomControl : UserControl
	{
		public static string dessertName;
    	public static int dessertPrice;
    	public static int d;
    	
		public DessertCustomControl()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			dessertName = "Fruit Salad";
        	dessertPrice = 5;
        	listBox1.Items.Add(dessertName);
        	listBox2.Items.Add(dessertPrice);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			dessertName = "Cake";
        	dessertPrice = 10;
        	listBox1.Items.Add(dessertName);
        	listBox2.Items.Add(dessertPrice);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			dessertName = "Custerd";
        	dessertPrice = 15;
        	listBox1.Items.Add(dessertName);
        	listBox2.Items.Add(dessertPrice);
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			dessertName = "Tart";
        	dessertPrice = 20;
        	listBox1.Items.Add(dessertName);
        	listBox2.Items.Add(dessertPrice);
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			dessertName = "IceCream";
        	dessertPrice = 5;
        	listBox1.Items.Add(dessertName);
        	listBox2.Items.Add(dessertPrice);
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			dessertName = "Doughnuts";
        	dessertPrice = 10;
        	listBox1.Items.Add(dessertName);
        	listBox2.Items.Add(dessertPrice);
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			int dessert = 0;
			for ( d = 0 ; d < listBox2.Items.Count ; d++ )
			{
				dessert+= Convert.ToInt32(listBox2.Items[d]);
			}
			dessertTotal.Text = dessert.ToString();
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
        	listBox2.Items.Clear();
        	dessertTotal.Text = "";
        	using ( Thanks pop = new Thanks () )
        	{
        		pop.ShowDialog();
        	}
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			for ( d = 0 ; d < listBox1.SelectedItems.Count ; d++)
        		listBox1.Items.Remove(listBox1.SelectedItems[d]);
        	
        	for ( d = 0 ; d < listBox2.SelectedItems.Count; d++)
				listBox2.Items.Remove(listBox2.SelectedItems[d]);
		}
	}
}
