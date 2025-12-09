/*
 * Created by SharpDevelop.
 * User: Isabella
 * Date: 08/12/2025
 * Time: 20:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace quizEducaSP
{
	/// <summary>
	/// Description of TelaLinguagens4.
	/// </summary>
	public partial class TelaLinguagens4 : Form
	{
		public TelaLinguagens4()
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
			MessageBox.Show("Alternativa incorreta!");
		}
		void BtnCClick(object sender, EventArgs e)
		{
			MessageBox.Show("Alternativa correta!");
		}
		void BtnDClick(object sender, EventArgs e)
		{
			MessageBox.Show("Alternativa incorreta!");
		}
		void BtnProximoClick(object sender, EventArgs e)
		{
			TelaLinguagens5 perguntas = new TelaLinguagens5();
		    perguntas.Show();
		    this.Hide();
		}
		void BtnVoltarClick(object sender, EventArgs e)
		{
			TelaLinguagens3 perguntas = new TelaLinguagens3();
		    perguntas.Show();
		    this.Hide();
		}
	}
}
