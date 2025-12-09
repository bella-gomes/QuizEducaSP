/*
 * Created by SharpDevelop.
 * User: Isabella
 * Date: 02/10/2025
 * Time: 22:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace quizEducaSP
{
	partial class telaLogin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelLogin;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaLogin));
			this.panelLogin = new System.Windows.Forms.Panel();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblCriarConta = new System.Windows.Forms.LinkLabel();
			this.btnLogin = new System.Windows.Forms.Button();
			this.lnkEsqueceu = new System.Windows.Forms.LinkLabel();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.lblSenha = new System.Windows.Forms.Label();
			this.lblSubtitulo = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.panelRight = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelLogin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			this.panelRight.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelLogin
			// 
			this.panelLogin.BackColor = System.Drawing.Color.White;
			this.panelLogin.Controls.Add(this.txtUsuario);
			this.panelLogin.Controls.Add(this.label2);
			this.panelLogin.Controls.Add(this.lblCriarConta);
			this.panelLogin.Controls.Add(this.btnLogin);
			this.panelLogin.Controls.Add(this.lnkEsqueceu);
			this.panelLogin.Controls.Add(this.txtSenha);
			this.panelLogin.Controls.Add(this.lblSenha);
			this.panelLogin.Controls.Add(this.lblSubtitulo);
			this.panelLogin.Controls.Add(this.lblTitulo);
			this.panelLogin.Controls.Add(this.picLogo);
			this.panelLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.panelLogin.Location = new System.Drawing.Point(64, 0);
			this.panelLogin.Name = "panelLogin";
			this.panelLogin.Size = new System.Drawing.Size(197, 339);
			this.panelLogin.TabIndex = 0;
			// 
			// txtUsuario
			// 
			this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUsuario.Location = new System.Drawing.Point(40, 138);
			this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(137, 20);
			this.txtUsuario.TabIndex = 14;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(1, 138);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 18);
			this.label2.TabIndex = 13;
			this.label2.Text = "Email:";
			// 
			// lblCriarConta
			// 
			this.lblCriarConta.AutoSize = true;
			this.lblCriarConta.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCriarConta.Location = new System.Drawing.Point(21, 284);
			this.lblCriarConta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblCriarConta.Name = "lblCriarConta";
			this.lblCriarConta.Size = new System.Drawing.Size(150, 12);
			this.lblCriarConta.TabIndex = 11;
			this.lblCriarConta.TabStop = true;
			this.lblCriarConta.Text = "Não tem uma conta? Crie uma conta";
			this.lblCriarConta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblCriarContaLinkClicked);
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnLogin.FlatAppearance.BorderSize = 0;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(26, 246);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(137, 23);
			this.btnLogin.TabIndex = 9;
			this.btnLogin.Text = "Entrar";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.BtnLoginClick);
			// 
			// lnkEsqueceu
			// 
			this.lnkEsqueceu.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnkEsqueceu.Location = new System.Drawing.Point(96, 201);
			this.lnkEsqueceu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lnkEsqueceu.Name = "lnkEsqueceu";
			this.lnkEsqueceu.Size = new System.Drawing.Size(90, 15);
			this.lnkEsqueceu.TabIndex = 8;
			this.lnkEsqueceu.TabStop = true;
			this.lnkEsqueceu.Text = "Esqueceu sua senha?";
			// 
			// txtSenha
			// 
			this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSenha.Location = new System.Drawing.Point(40, 177);
			this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(137, 20);
			this.txtSenha.TabIndex = 6;
			// 
			// lblSenha
			// 
			this.lblSenha.Location = new System.Drawing.Point(1, 177);
			this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(67, 15);
			this.lblSenha.TabIndex = 5;
			this.lblSenha.Text = "Senha:";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.Location = new System.Drawing.Point(33, 99);
			this.lblSubtitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(126, 26);
			this.lblSubtitulo.TabIndex = 2;
			this.lblSubtitulo.Text = "Por favor insira seus dados";
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(15, 80);
			this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(165, 45);
			this.lblTitulo.TabIndex = 1;
			this.lblTitulo.Text = "Bem-vindo de volta!";
			// 
			// picLogo
			// 
			this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
			this.picLogo.Location = new System.Drawing.Point(63, 12);
			this.picLogo.Margin = new System.Windows.Forms.Padding(2);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(71, 64);
			this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picLogo.TabIndex = 0;
			this.picLogo.TabStop = false;
			// 
			// panelRight
			// 
			this.panelRight.Controls.Add(this.label1);
			this.panelRight.Controls.Add(this.pictureBox1);
			this.panelRight.Location = new System.Drawing.Point(254, 0);
			this.panelRight.Margin = new System.Windows.Forms.Padding(2);
			this.panelRight.Name = "panelRight";
			this.panelRight.Size = new System.Drawing.Size(264, 335);
			this.panelRight.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Gray;
			this.label1.Location = new System.Drawing.Point(49, 30);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(194, 75);
			this.label1.TabIndex = 1;
			this.label1.Text = "Todo conhecimento, \r\nvocê encontra em um\r\n só lugar!";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(78, 118);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(117, 214);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// telaLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(523, 332);
			this.Controls.Add(this.panelRight);
			this.Controls.Add(this.panelLogin);
			this.Name = "telaLogin";
			this.Text = "TelaLogin";
			this.panelLogin.ResumeLayout(false);
			this.panelLogin.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			this.panelRight.ResumeLayout(false);
			this.panelRight.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panelRight;
		private System.Windows.Forms.LinkLabel lblCriarConta;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblSubtitulo;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.LinkLabel lnkEsqueceu;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.PictureBox picLogo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtSenha;
	}
}
