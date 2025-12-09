/*
 * Created by SharpDevelop.
 * User: Isabella
 * Date: 08/12/2025
 * Time: 20:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace quizEducaSP
{
	/// <summary>
	/// Description of TelaHumanas3.
	/// </summary>
	public partial class TelaHumanas3 : Form
	{
		public TelaHumanas3()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnAClick(object sender, EventArgs e)
		{
		    MessageBox.Show("Alternativa incorreta!");
		}
		void BtnBClick(object sender, EventArgs e)
		{
			MessageBox.Show("Alternativa correta!");
		}
		void BtnCClick(object sender, EventArgs e)
		{
			MessageBox.Show("Alternativa incorreta!");
		}
		void BtnDClick(object sender, EventArgs e)
		{
			MessageBox.Show("Alternativa incorreta!");
		}
		void BtnProximoClick(object sender, EventArgs e)
		{
			TelaHumanas4 perguntas = new TelaHumanas4();
		    perguntas.Show();
		    this.Hide();
		}
		void BtnVoltarClick(object sender, EventArgs e)
		{
			TelaHumanas2 perguntas = new TelaHumanas2();
		    perguntas.Show();
		    this.Hide();
		}
	}
}
