/*
 * Created by SharpDevelop.
 * User: 20252930122
 * Date: 01/12/2025
 * Time: 09:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace quizEducaSP
{
	partial class TelaMaterias
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaMaterias));
			this.lblTitulo = new System.Windows.Forms.Label();
			this.panelHumanas = new System.Windows.Forms.Panel();
			this.btnHumanas = new System.Windows.Forms.Button();
			this.lblHumanas = new System.Windows.Forms.Label();
			this.picHumanas = new System.Windows.Forms.PictureBox();
			this.panelLinguagens = new System.Windows.Forms.Panel();
			this.btnLinguagens = new System.Windows.Forms.Button();
			this.lblLinguagens = new System.Windows.Forms.Label();
			this.picLinguagens = new System.Windows.Forms.PictureBox();
			this.telaTopo = new System.Windows.Forms.Panel();
			this.picPerfil = new System.Windows.Forms.PictureBox();
			this.picTrofeu = new System.Windows.Forms.PictureBox();
			this.picBuscar = new System.Windows.Forms.PictureBox();
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.picMenu = new System.Windows.Forms.PictureBox();
			this.lblEscolherMateria = new System.Windows.Forms.Label();
			this.picMatematica = new System.Windows.Forms.PictureBox();
			this.lblMatematica = new System.Windows.Forms.Label();
			this.pnlMatematica = new System.Windows.Forms.Panel();
			this.btnExatas = new System.Windows.Forms.Button();
			this.panelHumanas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picHumanas)).BeginInit();
			this.panelLinguagens.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLinguagens)).BeginInit();
			this.telaTopo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picTrofeu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMatematica)).BeginInit();
			this.pnlMatematica.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(222, 19);
			this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(144, 25);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "QUIZEDUCASP";
			// 
			// panelHumanas
			// 
			this.panelHumanas.BackColor = System.Drawing.Color.AliceBlue;
			this.panelHumanas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelHumanas.Controls.Add(this.btnHumanas);
			this.panelHumanas.Controls.Add(this.lblHumanas);
			this.panelHumanas.Controls.Add(this.picHumanas);
			this.panelHumanas.Location = new System.Drawing.Point(230, 136);
			this.panelHumanas.Margin = new System.Windows.Forms.Padding(2);
			this.panelHumanas.Name = "panelHumanas";
			this.panelHumanas.Size = new System.Drawing.Size(134, 163);
			this.panelHumanas.TabIndex = 2;
			// 
			// btnHumanas
			// 
			this.btnHumanas.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHumanas.Location = new System.Drawing.Point(29, 124);
			this.btnHumanas.Margin = new System.Windows.Forms.Padding(2);
			this.btnHumanas.Name = "btnHumanas";
			this.btnHumanas.Size = new System.Drawing.Size(77, 19);
			this.btnHumanas.TabIndex = 2;
			this.btnHumanas.Text = "Selecionar";
			this.btnHumanas.UseVisualStyleBackColor = true;
			this.btnHumanas.Click += new System.EventHandler(this.BtnHumanasClick);
			// 
			// lblHumanas
			// 
			this.lblHumanas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHumanas.Location = new System.Drawing.Point(30, 13);
			this.lblHumanas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblHumanas.Name = "lblHumanas";
			this.lblHumanas.Size = new System.Drawing.Size(76, 22);
			this.lblHumanas.TabIndex = 1;
			this.lblHumanas.Text = "Humanas";
			// 
			// picHumanas
			// 
			this.picHumanas.Image = ((System.Drawing.Image)(resources.GetObject("picHumanas.Image")));
			this.picHumanas.Location = new System.Drawing.Point(42, 44);
			this.picHumanas.Margin = new System.Windows.Forms.Padding(2);
			this.picHumanas.Name = "picHumanas";
			this.picHumanas.Size = new System.Drawing.Size(50, 54);
			this.picHumanas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picHumanas.TabIndex = 0;
			this.picHumanas.TabStop = false;
			// 
			// panelLinguagens
			// 
			this.panelLinguagens.BackColor = System.Drawing.Color.AliceBlue;
			this.panelLinguagens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelLinguagens.Controls.Add(this.btnLinguagens);
			this.panelLinguagens.Controls.Add(this.lblLinguagens);
			this.panelLinguagens.Controls.Add(this.picLinguagens);
			this.panelLinguagens.Location = new System.Drawing.Point(384, 136);
			this.panelLinguagens.Margin = new System.Windows.Forms.Padding(2);
			this.panelLinguagens.Name = "panelLinguagens";
			this.panelLinguagens.Size = new System.Drawing.Size(134, 163);
			this.panelLinguagens.TabIndex = 3;
			// 
			// btnLinguagens
			// 
			this.btnLinguagens.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLinguagens.Location = new System.Drawing.Point(30, 124);
			this.btnLinguagens.Margin = new System.Windows.Forms.Padding(2);
			this.btnLinguagens.Name = "btnLinguagens";
			this.btnLinguagens.Size = new System.Drawing.Size(77, 19);
			this.btnLinguagens.TabIndex = 2;
			this.btnLinguagens.Text = "Selecionar";
			this.btnLinguagens.UseVisualStyleBackColor = true;
			this.btnLinguagens.Click += new System.EventHandler(this.BtnLinguagensClick);
			// 
			// lblLinguagens
			// 
			this.lblLinguagens.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLinguagens.Location = new System.Drawing.Point(30, 14);
			this.lblLinguagens.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblLinguagens.Name = "lblLinguagens";
			this.lblLinguagens.Size = new System.Drawing.Size(87, 22);
			this.lblLinguagens.TabIndex = 1;
			this.lblLinguagens.Text = "Linguagens";
			// 
			// picLinguagens
			// 
			this.picLinguagens.Image = ((System.Drawing.Image)(resources.GetObject("picLinguagens.Image")));
			this.picLinguagens.Location = new System.Drawing.Point(43, 44);
			this.picLinguagens.Margin = new System.Windows.Forms.Padding(2);
			this.picLinguagens.Name = "picLinguagens";
			this.picLinguagens.Size = new System.Drawing.Size(50, 54);
			this.picLinguagens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picLinguagens.TabIndex = 0;
			this.picLinguagens.TabStop = false;
			// 
			// telaTopo
			// 
			this.telaTopo.BackColor = System.Drawing.Color.White;
			this.telaTopo.Controls.Add(this.picPerfil);
			this.telaTopo.Controls.Add(this.picTrofeu);
			this.telaTopo.Controls.Add(this.picBuscar);
			this.telaTopo.Controls.Add(this.picLogo);
			this.telaTopo.Controls.Add(this.picMenu);
			this.telaTopo.Controls.Add(this.lblTitulo);
			this.telaTopo.Dock = System.Windows.Forms.DockStyle.Top;
			this.telaTopo.Location = new System.Drawing.Point(0, 0);
			this.telaTopo.Margin = new System.Windows.Forms.Padding(2);
			this.telaTopo.Name = "telaTopo";
			this.telaTopo.Size = new System.Drawing.Size(585, 59);
			this.telaTopo.TabIndex = 4;
			// 
			// picPerfil
			// 
			this.picPerfil.Image = ((System.Drawing.Image)(resources.GetObject("picPerfil.Image")));
			this.picPerfil.Location = new System.Drawing.Point(559, 17);
			this.picPerfil.Margin = new System.Windows.Forms.Padding(2);
			this.picPerfil.Name = "picPerfil";
			this.picPerfil.Size = new System.Drawing.Size(20, 25);
			this.picPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picPerfil.TabIndex = 6;
			this.picPerfil.TabStop = false;
			// 
			// picTrofeu
			// 
			this.picTrofeu.Image = ((System.Drawing.Image)(resources.GetObject("picTrofeu.Image")));
			this.picTrofeu.Location = new System.Drawing.Point(527, 17);
			this.picTrofeu.Margin = new System.Windows.Forms.Padding(2);
			this.picTrofeu.Name = "picTrofeu";
			this.picTrofeu.Size = new System.Drawing.Size(25, 25);
			this.picTrofeu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picTrofeu.TabIndex = 5;
			this.picTrofeu.TabStop = false;
			// 
			// picBuscar
			// 
			this.picBuscar.Image = ((System.Drawing.Image)(resources.GetObject("picBuscar.Image")));
			this.picBuscar.Location = new System.Drawing.Point(492, 17);
			this.picBuscar.Margin = new System.Windows.Forms.Padding(2);
			this.picBuscar.Name = "picBuscar";
			this.picBuscar.Size = new System.Drawing.Size(27, 25);
			this.picBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picBuscar.TabIndex = 4;
			this.picBuscar.TabStop = false;
			// 
			// picLogo
			// 
			this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
			this.picLogo.Location = new System.Drawing.Point(37, 15);
			this.picLogo.Margin = new System.Windows.Forms.Padding(2);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(31, 29);
			this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picLogo.TabIndex = 3;
			this.picLogo.TabStop = false;
			// 
			// picMenu
			// 
			this.picMenu.Image = ((System.Drawing.Image)(resources.GetObject("picMenu.Image")));
			this.picMenu.Location = new System.Drawing.Point(7, 18);
			this.picMenu.Margin = new System.Windows.Forms.Padding(2);
			this.picMenu.Name = "picMenu";
			this.picMenu.Size = new System.Drawing.Size(27, 26);
			this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picMenu.TabIndex = 2;
			this.picMenu.TabStop = false;
			// 
			// lblEscolherMateria
			// 
			this.lblEscolherMateria.AutoSize = true;
			this.lblEscolherMateria.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEscolherMateria.Location = new System.Drawing.Point(210, 83);
			this.lblEscolherMateria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblEscolherMateria.Name = "lblEscolherMateria";
			this.lblEscolherMateria.Size = new System.Drawing.Size(170, 25);
			this.lblEscolherMateria.TabIndex = 4;
			this.lblEscolherMateria.Text = "Escolha a Matéria:";
			// 
			// picMatematica
			// 
			this.picMatematica.Image = ((System.Drawing.Image)(resources.GetObject("picMatematica.Image")));
			this.picMatematica.Location = new System.Drawing.Point(37, 41);
			this.picMatematica.Margin = new System.Windows.Forms.Padding(2);
			this.picMatematica.Name = "picMatematica";
			this.picMatematica.Size = new System.Drawing.Size(59, 57);
			this.picMatematica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picMatematica.TabIndex = 0;
			this.picMatematica.TabStop = false;
			// 
			// lblMatematica
			// 
			this.lblMatematica.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMatematica.Location = new System.Drawing.Point(42, 13);
			this.lblMatematica.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblMatematica.Name = "lblMatematica";
			this.lblMatematica.Size = new System.Drawing.Size(54, 22);
			this.lblMatematica.TabIndex = 1;
			this.lblMatematica.Text = "Exatas";
			// 
			// pnlMatematica
			// 
			this.pnlMatematica.BackColor = System.Drawing.Color.AliceBlue;
			this.pnlMatematica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlMatematica.Controls.Add(this.btnExatas);
			this.pnlMatematica.Controls.Add(this.lblMatematica);
			this.pnlMatematica.Controls.Add(this.picMatematica);
			this.pnlMatematica.Location = new System.Drawing.Point(72, 136);
			this.pnlMatematica.Margin = new System.Windows.Forms.Padding(2);
			this.pnlMatematica.Name = "pnlMatematica";
			this.pnlMatematica.Size = new System.Drawing.Size(134, 163);
			this.pnlMatematica.TabIndex = 1;
			// 
			// btnExatas
			// 
			this.btnExatas.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExatas.Location = new System.Drawing.Point(28, 124);
			this.btnExatas.Margin = new System.Windows.Forms.Padding(2);
			this.btnExatas.Name = "btnExatas";
			this.btnExatas.Size = new System.Drawing.Size(77, 19);
			this.btnExatas.TabIndex = 3;
			this.btnExatas.Text = "Selecionar";
			this.btnExatas.UseVisualStyleBackColor = true;
			this.btnExatas.Click += new System.EventHandler(this.BtnExatasClick);
			// 
			// TelaMaterias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(585, 336);
			this.Controls.Add(this.lblEscolherMateria);
			this.Controls.Add(this.telaTopo);
			this.Controls.Add(this.panelLinguagens);
			this.Controls.Add(this.panelHumanas);
			this.Controls.Add(this.pnlMatematica);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "TelaMaterias";
			this.Text = "TelaMaterias";
			this.panelHumanas.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picHumanas)).EndInit();
			this.panelLinguagens.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picLinguagens)).EndInit();
			this.telaTopo.ResumeLayout(false);
			this.telaTopo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picTrofeu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMatematica)).EndInit();
			this.pnlMatematica.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.PictureBox picBuscar;
		private System.Windows.Forms.PictureBox picTrofeu;
		private System.Windows.Forms.PictureBox picPerfil;
		private System.Windows.Forms.Label lblEscolherMateria;
		private System.Windows.Forms.PictureBox picMenu;
		private System.Windows.Forms.PictureBox picLogo;
		private System.Windows.Forms.Panel telaTopo;
		private System.Windows.Forms.PictureBox picLinguagens;
		private System.Windows.Forms.Label lblLinguagens;
		private System.Windows.Forms.Button btnLinguagens;
		private System.Windows.Forms.Panel panelLinguagens;
		private System.Windows.Forms.PictureBox picHumanas;
		private System.Windows.Forms.Label lblHumanas;
		private System.Windows.Forms.Button btnHumanas;
		private System.Windows.Forms.Panel panelHumanas;
		private System.Windows.Forms.Button btnExatas;
		private System.Windows.Forms.PictureBox picMatematica;
		private System.Windows.Forms.Label lblMatematica;
		private System.Windows.Forms.Panel pnlMatematica;
		private System.Windows.Forms.Label lblTitulo;
	}
}
