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
	/// Description of TelaLinguagens5.
	/// </summary>
	public partial class TelaLinguagens5 : Form
	{
		public TelaLinguagens5()
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
		    MessageBox.Show("Alternativa correta!");
		}
		void BtnBClick(object sender, EventArgs e)
		{
			MessageBox.Show("Alternativa incorreta!");
		}
		void BtnCClick(object sender, EventArgs e)
		{
			MessageBox.Show("Alternativa incorreta!");
		}
		void BtnDClick(object sender, EventArgs e)
		{
			MessageBox.Show("Alternativa incorreta!");
		}
		void BtnVoltarClick(object sender, EventArgs e)
		{
			TelaLinguagens4 perguntas = new TelaLinguagens4();
		    perguntas.Show();
		    this.Hide();
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
			TelaMaterias perguntas = new TelaMaterias();
			perguntas.Show();
			this.Hide();
		}
	}
}
