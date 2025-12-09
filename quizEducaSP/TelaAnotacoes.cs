/*
 * Created by SharpDevelop.
 * User: Isabella
 * Date: 07/12/2025
 * Time: 19:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace quizEducaSP
{
	/// <summary>
	/// Description of TelaAnotacoes.
	/// </summary>
	public partial class TelaAnotacoes : Form
	{
		public TelaAnotacoes()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
		TelaInicial perguntas = new TelaInicial();
		perguntas.Show();
		this.Hide();
		}
		void BtnSalvarClick(object sender, EventArgs e)
		{
			MessageBox.Show("Anotação salva com sucesso!");
		}
	}
}
