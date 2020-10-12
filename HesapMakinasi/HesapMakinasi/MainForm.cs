/*
 * Created by SharpDevelop.
 * User: ERKAN
 * Date: 11.10.2020
 * Time: 21:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HesapMakinasi
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		
		
		char islem=' ';
		
		string ilkSayi="";
		string sonSayi="";
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			lbPanel.Text +=  "1";
		}
		
		void Button9Click(object sender, EventArgs e)
		{
					lbPanel.Text +=  "9";
		}
		
		void Button2Click(object sender, EventArgs e)
		{
					lbPanel.Text +=  "2";
		}
		
		void Button3Click(object sender, EventArgs e)
		{
					lbPanel.Text +=  "3";
		}
		
		void Button4Click(object sender, EventArgs e)
		{
					lbPanel.Text +=  "4";
		}
		
		void Button5Click(object sender, EventArgs e)
		{
		lbPanel.Text +=  "5";			
		}
		
		void Button6Click(object sender, EventArgs e)
		{
					lbPanel.Text +=  "6";
		}
		
		void Button7Click(object sender, EventArgs e)
		{
		lbPanel.Text +=  "7";			
		}
		
		void Button8Click(object sender, EventArgs e)
		{
					lbPanel.Text +=  "8";
		}
		
		void Button0Click(object sender, EventArgs e)
		{
					lbPanel.Text +=  "0";
		}
		
		void ButtonToplaClick(object sender, EventArgs e)
		{
			islem='T';
			ilkSayi= lbPanel.Text;
			lbPanel.Text="";
		}
		
		void ButtonCikarClick(object sender, EventArgs e)
		{
			islem='C';
				ilkSayi= lbPanel.Text;
				lbPanel.Text="";
		}
		
		void ButtonBolmeClick(object sender, EventArgs e)
		{
			islem='B';
	ilkSayi= lbPanel.Text;	
lbPanel.Text="";	
		}
		
		void ButtonCarpClick(object sender, EventArgs e)
		{
			islem='M';	
	ilkSayi= lbPanel.Text;
lbPanel.Text="";	
		}
		
		void ButtonSonucClick(object sender, EventArgs e)
		{
			if (islem=='T')
			{
				double sayi1= Convert.ToDouble(ilkSayi);
				double sayi2 = Convert.ToDouble(lbPanel.Text);
				lbPanel.Text=Convert.ToString (sayi1+sayi2);
			}
			else if (islem=='C')
			{
				double sayi1= Convert.ToDouble(ilkSayi);
				double sayi2 = Convert.ToDouble(lbPanel.Text);
				lbPanel.Text=Convert.ToString (sayi1-sayi2);
			}
			else if (islem=='M')
			{
				double sayi1= Convert.ToDouble(ilkSayi);
				double sayi2 = Convert.ToDouble(lbPanel.Text);
				lbPanel.Text=Convert.ToString (sayi1*sayi2);
			}
			if (islem=='B')
			{
				double sayi1= Convert.ToDouble(ilkSayi);
				double sayi2 = Convert.ToDouble(lbPanel.Text);
				lbPanel.Text=Convert.ToString (sayi1/sayi2);
			}
				
		}
		
		void ButtonVirgulClick(object sender, EventArgs e)
		{
			lbPanel.Text+= ",";
			
		}
		
		void ButtonTemizleClick(object sender, EventArgs e)
		{
			lbPanel.Text="";
			islem=' ';
			ilkSayi="";
		}
		
		
		
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			
			if(e.KeyCode== Keys.NumPad1)
			{
			lbPanel.Text+="1";
			}
			else if(e.KeyCode== Keys.NumPad2)
			{
			lbPanel.Text+="2";
			}
			else if(e.KeyCode== Keys.NumPad3)
			{
			lbPanel.Text+="3";
			}
			else if(e.KeyCode== Keys.NumPad4)
			{
			lbPanel.Text+="4";
			}
			else if(e.KeyCode== Keys.NumPad5)
			{
			lbPanel.Text+="5";
			}
			else if(e.KeyCode== Keys.NumPad6)
			{
			lbPanel.Text+="6";
			}
			else if(e.KeyCode== Keys.NumPad7)
			{
			lbPanel.Text+="7";
			}
			else if(e.KeyCode== Keys.NumPad8)
			{
			lbPanel.Text+="8";
			}
			else if(e.KeyCode== Keys.NumPad9)
			{
			lbPanel.Text+="9";
			}
			else if(e.KeyCode== Keys.NumPad0)
			{
			lbPanel.Text+="0";
			}
			else if(e.KeyCode== Keys.Decimal)
			{
			lbPanel.Text+="1";
			}
		}
	}
}
