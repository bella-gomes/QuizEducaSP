/*
 * Created by SharpDevelop.
 * User: Isabella
 * Date: 08/12/2025
 * Time: 20:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace quizEducaSP
{
	/// <summary>
	/// Description of TelaPerguntas4.
	/// </summary>
	public partial class TelaPerguntas4 : Form
	{
		public TelaPerguntas4()
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
			TelaPerguntas5 perguntas = new TelaPerguntas5();
		    perguntas.Show();
		    this.Hide();
		}
		void BtnVoltarClick(object sender, EventArgs e)
		{
			TelaPerguntas3 perguntas = new TelaPerguntas3();
		    perguntas.Show();
		    this.Hide();
		}
	}
}
