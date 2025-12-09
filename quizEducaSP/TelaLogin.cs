/*
 * Created by SharpDevelop.
 * User: Isabella
 * Date: 02/10/2025
 * Time: 22:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace quizEducaSP
{
	/// <summary>
	/// Description of TelaLogin.
	/// </summary>
	public partial class telaLogin : Form
	{
		string arquivo = "usuarios.txt";
		
		public telaLogin()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
	
	
	
		}
		void LblCriarContaLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MainForm cadastro = new MainForm();
    		cadastro.Show();
    		this.Hide();
		}
		void BtnLoginClick(object sender, EventArgs e)
		{
			string usuario = txtUsuario.Text.Trim();
    		string senha = txtSenha.Text.Trim();

    		if (usuario == "" || senha == "")
    		{
        		MessageBox.Show("Preencha o e-mail e a senha.");
        		return;
    		}

    	bool usuarioExiste = false;
    	bool senhaCorreta = false;

    		if (File.Exists(arquivo))
    		{
	        	foreach (string linha in File.ReadAllLines(arquivo))
	        	{
            		string[] dados = linha.Split(';');
            		if (dados[0] == usuario) // usuário encontrado
            		{
                		usuarioExiste = true;
                		if (dados[1] == senha) // senha correta
                		{
                    		senhaCorreta = true;
                		}
                		break;
         		    }
        		}
    		}

    		if (!usuarioExiste)
    		{
	        	MessageBox.Show("Usuário não existe. Realize o cadastro.");
	        	return;
    		}

	    	if (!senhaCorreta)
	    	{
		        MessageBox.Show("Senha incorreta.");
	        	return;
    		}
	    	
		    MessageBox.Show("Login realizado com sucesso!");
		    txtUsuario.Clear();
		    txtSenha.Clear();
		
		    TelaInicial telaInicial = new TelaInicial();
		    telaInicial.Show();
		    this.Hide();
		}
		
		
	}
}
