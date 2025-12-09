/*
 * Created by SharpDevelop.
 * User: Isabella
 * Date: 07/12/2025
 * Time: 19:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace quizEducaSP
{
	partial class TelaAnotacoes
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblEscolherMateria;
		private System.Windows.Forms.Panel telaTopo;
		private System.Windows.Forms.PictureBox picPerfil;
		private System.Windows.Forms.PictureBox picTrofeu;
		private System.Windows.Forms.PictureBox picBuscar;
		private System.Windows.Forms.PictureBox picLogo;
		private System.Windows.Forms.PictureBox picMenu;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnSalvar;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAnotacoes));
			this.lblEscolherMateria = new System.Windows.Forms.Label();
			this.telaTopo = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.picPerfil = new System.Windows.Forms.PictureBox();
			this.picTrofeu = new System.Windows.Forms.PictureBox();
			this.picBuscar = new System.Windows.Forms.PictureBox();
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.picMenu = new System.Windows.Forms.PictureBox();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.telaTopo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picTrofeu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
			this.SuspendLayout();
			// 
			// lblEscolherMateria
			// 
			this.lblEscolherMateria.AutoSize = true;
			this.lblEscolherMateria.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEscolherMateria.Location = new System.Drawing.Point(200, 100);
			this.lblEscolherMateria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblEscolherMateria.Name = "lblEscolherMateria";
			this.lblEscolherMateria.Size = new System.Drawing.Size(193, 25);
			this.lblEscolherMateria.TabIndex = 8;
			this.lblEscolherMateria.Text = "Faça suas anotações:";
			// 
			// telaTopo
			// 
			this.telaTopo.BackColor = System.Drawing.Color.White;
			this.telaTopo.Controls.Add(this.pictureBox1);
			this.telaTopo.Controls.Add(this.picPerfil);
			this.telaTopo.Controls.Add(this.picTrofeu);
			this.telaTopo.Controls.Add(this.picBuscar);
			this.telaTopo.Controls.Add(this.picLogo);
			this.telaTopo.Controls.Add(this.picMenu);
			this.telaTopo.Controls.Add(this.lblTitulo);
			this.telaTopo.Dock = System.Windows.Forms.DockStyle.Top;
			this.telaTopo.Location = new System.Drawing.Point(0, 0);
			this.telaTopo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.telaTopo.Name = "telaTopo";
			this.telaTopo.Size = new System.Drawing.Size(594, 59);
			this.telaTopo.TabIndex = 9;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(5, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(23, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// picPerfil
			// 
			this.picPerfil.Image = ((System.Drawing.Image)(resources.GetObject("picPerfil.Image")));
			this.picPerfil.Location = new System.Drawing.Point(559, 17);
			this.picPerfil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
			this.picTrofeu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
			this.picBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picBuscar.Name = "picBuscar";
			this.picBuscar.Size = new System.Drawing.Size(27, 25);
			this.picBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picBuscar.TabIndex = 4;
			this.picBuscar.TabStop = false;
			// 
			// picLogo
			// 
			this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
			this.picLogo.Location = new System.Drawing.Point(72, 15);
			this.picLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(31, 29);
			this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picLogo.TabIndex = 3;
			this.picLogo.TabStop = false;
			// 
			// picMenu
			// 
			this.picMenu.Image = ((System.Drawing.Image)(resources.GetObject("picMenu.Image")));
			this.picMenu.Location = new System.Drawing.Point(37, 18);
			this.picMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picMenu.Name = "picMenu";
			this.picMenu.Size = new System.Drawing.Size(27, 26);
			this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picMenu.TabIndex = 2;
			this.picMenu.TabStop = false;
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
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(137, 145);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(311, 20);
			this.textBox1.TabIndex = 10;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(257, 217);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 23);
			this.btnSalvar.TabIndex = 12;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.BtnSalvarClick);
			// 
			// TelaAnotacoes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 333);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lblEscolherMateria);
			this.Controls.Add(this.telaTopo);
			this.Name = "TelaAnotacoes";
			this.Text = "TelaAnotacoes";
			this.telaTopo.ResumeLayout(false);
			this.telaTopo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picTrofeu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
