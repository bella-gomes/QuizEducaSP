/*
 * Created by SharpDevelop.
 * User: Isabella
 * Date: 02/10/2025
 * Time: 12:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace quizEducaSP
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblSobrenome;
		private System.Windows.Forms.TextBox txtSobrenome;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblConfirmeSenha;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.TextBox txtConfirmeSenha;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Label lblMunicipio;
		private System.Windows.Forms.Label lblTelefone;
		private System.Windows.Forms.TextBox txtMunicipio;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label lblJaTemConta;
		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.Label lblTítulo;
		private System.Windows.Forms.Label lblDescrição;
		private System.Windows.Forms.Label lblDescrição1;
		private System.Windows.Forms.Label lblLogo;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtTelefone;
		private System.Windows.Forms.Label lblLogueAqui;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblLogueAqui = new System.Windows.Forms.Label();
			this.txtTelefone = new System.Windows.Forms.TextBox();
			this.lblJaTemConta = new System.Windows.Forms.Label();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.lblConfirmeSenha = new System.Windows.Forms.Label();
			this.lblSenha = new System.Windows.Forms.Label();
			this.txtConfirmeSenha = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.lblMunicipio = new System.Windows.Forms.Label();
			this.lblTelefone = new System.Windows.Forms.Label();
			this.txtMunicipio = new System.Windows.Forms.TextBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.lblSobrenome = new System.Windows.Forms.Label();
			this.txtSobrenome = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblTítulo = new System.Windows.Forms.Label();
			this.lblDescrição = new System.Windows.Forms.Label();
			this.lblDescrição1 = new System.Windows.Forms.Label();
			this.lblLogo = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.lblLogueAqui);
			this.panel1.Controls.Add(this.txtTelefone);
			this.panel1.Controls.Add(this.lblJaTemConta);
			this.panel1.Controls.Add(this.btnCadastrar);
			this.panel1.Controls.Add(this.lblConfirmeSenha);
			this.panel1.Controls.Add(this.lblSenha);
			this.panel1.Controls.Add(this.txtConfirmeSenha);
			this.panel1.Controls.Add(this.txtSenha);
			this.panel1.Controls.Add(this.lblMunicipio);
			this.panel1.Controls.Add(this.lblTelefone);
			this.panel1.Controls.Add(this.txtMunicipio);
			this.panel1.Controls.Add(this.lblEmail);
			this.panel1.Controls.Add(this.txtUsuario);
			this.panel1.Controls.Add(this.lblSobrenome);
			this.panel1.Controls.Add(this.txtSobrenome);
			this.panel1.Controls.Add(this.txtNome);
			this.panel1.Controls.Add(this.lblNome);
			this.panel1.Location = new System.Drawing.Point(173, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(365, 333);
			this.panel1.TabIndex = 0;
			// 
			// lblLogueAqui
			// 
			this.lblLogueAqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLogueAqui.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(150)))));
			this.lblLogueAqui.Location = new System.Drawing.Point(129, 277);
			this.lblLogueAqui.Name = "lblLogueAqui";
			this.lblLogueAqui.Size = new System.Drawing.Size(114, 23);
			this.lblLogueAqui.TabIndex = 19;
			this.lblLogueAqui.Text = "Logue aqui!";
			this.lblLogueAqui.Click += new System.EventHandler(this.LblLogueAquiClick);
			// 
			// txtTelefone
			// 
			this.txtTelefone.Location = new System.Drawing.Point(17, 157);
			this.txtTelefone.Name = "txtTelefone";
			this.txtTelefone.Size = new System.Drawing.Size(151, 20);
			this.txtTelefone.TabIndex = 17;
			// 
			// lblJaTemConta
			// 
			this.lblJaTemConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblJaTemConta.Location = new System.Drawing.Point(17, 277);
			this.lblJaTemConta.Name = "lblJaTemConta";
			this.lblJaTemConta.Size = new System.Drawing.Size(114, 23);
			this.lblJaTemConta.TabIndex = 15;
			this.lblJaTemConta.Text = "Já tem uma conta?";
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(15)))), ((int)(((byte)(13)))));
			this.btnCadastrar.ForeColor = System.Drawing.Color.White;
			this.btnCadastrar.Location = new System.Drawing.Point(17, 238);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(319, 28);
			this.btnCadastrar.TabIndex = 14;
			this.btnCadastrar.Text = "REGISTRAR";
			this.btnCadastrar.UseVisualStyleBackColor = false;
			this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrarClick);
			// 
			// lblConfirmeSenha
			// 
			this.lblConfirmeSenha.Location = new System.Drawing.Point(185, 187);
			this.lblConfirmeSenha.Name = "lblConfirmeSenha";
			this.lblConfirmeSenha.Size = new System.Drawing.Size(100, 14);
			this.lblConfirmeSenha.TabIndex = 13;
			this.lblConfirmeSenha.Text = "Confirme senha:";
			// 
			// lblSenha
			// 
			this.lblSenha.Location = new System.Drawing.Point(17, 187);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(100, 14);
			this.lblSenha.TabIndex = 12;
			this.lblSenha.Text = "Senha:";
			// 
			// txtConfirmeSenha
			// 
			this.txtConfirmeSenha.Location = new System.Drawing.Point(185, 204);
			this.txtConfirmeSenha.Name = "txtConfirmeSenha";
			this.txtConfirmeSenha.Size = new System.Drawing.Size(151, 20);
			this.txtConfirmeSenha.TabIndex = 11;
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(17, 204);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(151, 20);
			this.txtSenha.TabIndex = 10;
			// 
			// lblMunicipio
			// 
			this.lblMunicipio.Location = new System.Drawing.Point(185, 140);
			this.lblMunicipio.Name = "lblMunicipio";
			this.lblMunicipio.Size = new System.Drawing.Size(100, 14);
			this.lblMunicipio.TabIndex = 9;
			this.lblMunicipio.Text = "Município:";
			// 
			// lblTelefone
			// 
			this.lblTelefone.Location = new System.Drawing.Point(17, 140);
			this.lblTelefone.Name = "lblTelefone";
			this.lblTelefone.Size = new System.Drawing.Size(100, 14);
			this.lblTelefone.TabIndex = 8;
			this.lblTelefone.Text = "Telefone:";
			// 
			// txtMunicipio
			// 
			this.txtMunicipio.Location = new System.Drawing.Point(185, 157);
			this.txtMunicipio.Name = "txtMunicipio";
			this.txtMunicipio.Size = new System.Drawing.Size(151, 20);
			this.txtMunicipio.TabIndex = 7;
			// 
			// lblEmail
			// 
			this.lblEmail.Location = new System.Drawing.Point(17, 93);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(100, 14);
			this.lblEmail.TabIndex = 5;
			this.lblEmail.Text = "Email:";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(17, 110);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(319, 20);
			this.txtUsuario.TabIndex = 4;
			// 
			// lblSobrenome
			// 
			this.lblSobrenome.Location = new System.Drawing.Point(185, 46);
			this.lblSobrenome.Name = "lblSobrenome";
			this.lblSobrenome.Size = new System.Drawing.Size(100, 14);
			this.lblSobrenome.TabIndex = 3;
			this.lblSobrenome.Text = "Sobrenome:";
			// 
			// txtSobrenome
			// 
			this.txtSobrenome.Location = new System.Drawing.Point(185, 63);
			this.txtSobrenome.Name = "txtSobrenome";
			this.txtSobrenome.Size = new System.Drawing.Size(151, 20);
			this.txtSobrenome.TabIndex = 2;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(17, 63);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(151, 20);
			this.txtNome.TabIndex = 1;
			// 
			// lblNome
			// 
			this.lblNome.Location = new System.Drawing.Point(17, 46);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(100, 14);
			this.lblNome.TabIndex = 0;
			this.lblNome.Text = "Nome:";
			// 
			// lblTítulo
			// 
			this.lblTítulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTítulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(150)))));
			this.lblTítulo.Location = new System.Drawing.Point(3, 108);
			this.lblTítulo.Name = "lblTítulo";
			this.lblTítulo.Size = new System.Drawing.Size(164, 61);
			this.lblTítulo.TabIndex = 1;
			this.lblTítulo.Text = "BEM-VINDO(A) AO QUIZ DA PROVA PAULISTA!";
			// 
			// lblDescrição
			// 
			this.lblDescrição.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescrição.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(150)))));
			this.lblDescrição.Location = new System.Drawing.Point(3, 195);
			this.lblDescrição.Name = "lblDescrição";
			this.lblDescrição.Size = new System.Drawing.Size(164, 33);
			this.lblDescrição.TabIndex = 2;
			this.lblDescrição.Text = "Preparação de verdade começa aqui. Vamos juntos?";
			// 
			// lblDescrição1
			// 
			this.lblDescrição1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescrição1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(150)))));
			this.lblDescrição1.Location = new System.Drawing.Point(1, 228);
			this.lblDescrição1.Name = "lblDescrição1";
			this.lblDescrição1.Size = new System.Drawing.Size(172, 33);
			this.lblDescrição1.TabIndex = 3;
			this.lblDescrição1.Text = "Crie uma conta gratuita e comece agora!";
			// 
			// lblLogo
			// 
			this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(150)))));
			this.lblLogo.Location = new System.Drawing.Point(63, 25);
			this.lblLogo.Name = "lblLogo";
			this.lblLogo.Size = new System.Drawing.Size(104, 22);
			this.lblLogo.TabIndex = 4;
			this.lblLogo.Text = "QUIZEDUCASP";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(64, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(536, 324);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblLogo);
			this.Controls.Add(this.lblDescrição1);
			this.Controls.Add(this.lblDescrição);
			this.Controls.Add(this.lblTítulo);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "quizEducaSP";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
