/*
 * Created by SharpDevelop.
 * User: marci
 * Date: 27/11/2025
 * Time: 23:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace quizEducaSP
{
	/// <summary>
	/// Description of TelaInicial.
	/// </summary>
	public partial class TelaInicial : Form
	{
		public TelaInicial()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		
			
		}
		void BtnQuestoesClick(object sender, EventArgs e)
		{
			TelaMaterias perguntas = new TelaMaterias();
		    perguntas.Show();
		    this.Hide();
		}
		void BtnAnotacoesClick(object sender, EventArgs e)
		{
			TelaAnotacoes perguntas = new TelaAnotacoes();
		    perguntas.Show();
		    this.Hide();
		}
	}
}
