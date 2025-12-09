/*
 * Created by SharpDevelop.
 * User: Isabella
 * Date: 07/10/2025
 * Time: 21:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace quizEducaSP
{
	/// <summary>
	/// Description of Splash.
	/// </summary>
	public partial class Splash : Form
	{
		public Splash()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			timer1.Enabled = false;
			MainForm telaPrincipal = new MainForm();
			telaPrincipal.Show();
			this.Hide();
		}
	}
}
