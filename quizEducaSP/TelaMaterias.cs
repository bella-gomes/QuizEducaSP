/*
 * Created by SharpDevelop.
 * User: 20252930122
 * Date: 01/12/2025
 * Time: 09:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace quizEducaSP
{
	/// <summary>
	/// Description of TelaMaterias.
	/// </summary>
	public partial class TelaMaterias : Form
	{
		public TelaMaterias()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		void BtnExatasClick(object sender, EventArgs e)
		{
			frm tp = new frm();
            tp.Show();
            this.Hide();
		}
		void BtnHumanasClick(object sender, EventArgs e)
		{
			TelaHumanas tp = new TelaHumanas();
            tp.Show();
            this.Hide();
		}
		void BtnLinguagensClick(object sender, EventArgs e)
		{
			TelaLinguagens tp = new TelaLinguagens();
            tp.Show();
            this.Hide();
		}
	}
}
