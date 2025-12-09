/*
 * Created by SharpDevelop.
 * User: Isabella
 * Date: 02/10/2025
 * Time: 12:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace quizEducaSP
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		
	
		

	  
		
	
		}
		void LblLogueAquiClick(object sender, EventArgs e)
		{
	telaLogin cadastro = new telaLogin();
    cadastro.Show();
    this.Hide();
		}

		string arquivo = "usuarios.txt";
		void BtnCadastrarClick(object sender, EventArgs e)
		{
			
			string usuario = txtUsuario.Text.Trim();
			string senha = txtSenha.Text.Trim();
			string confirmarSenha = txtConfirmeSenha.Text.Trim();
			
			if (txtNome.Text.Trim() == "")
			{
			    MessageBox.Show("Preencha o nome.");
			    return;
			}
			
			if (txtSobrenome.Text.Trim() == "")
			{
			    MessageBox.Show("Preencha o sobrenome.");
			    return;
			}
			
			if (txtUsuario.Text.Trim() == "")
			{
			    MessageBox.Show("Preencha o e-mail.");
			    return;
			}
			
			if (txtTelefone.Text.Trim() == "")
			{
			    MessageBox.Show("Preencha o telefone.");
			    return;
			}
			
			if (txtMunicipio.Text.Trim() == "")
			{
			    MessageBox.Show("Preencha o município.");
			    return;
			}
			
			if (usuario == ""  || senha == ""  || confirmarSenha == ""){
				MessageBox.Show("Preencha o e-mail, a senha e a confirmação de senha.");
				return;
			}
			
			if (senha != confirmarSenha)
    		{
       			MessageBox.Show("As senhas não coincidem.");
        		return;
    		}
			
			bool usuarioExiste = false;
			if (File.Exists(arquivo)) {
			    	foreach (string linha in File.ReadAllLines(arquivo)) {
			    		string[] dados = linha.Split (';');
			    		if (dados[0] == usuario){
			    			MessageBox.Show("Usuário já cadastrado.");
			    			usuarioExiste = true;
			    			break;
			    		}
			    	}
			    } 
			
			if (!usuarioExiste) {
    			bool cadastrado = false;
    			using (StreamWriter sw = File.AppendText(arquivo)) {
        			sw.WriteLine(usuario + ";" + senha);
        			cadastrado = true;
    			}
    			if (cadastrado == true){
        			MessageBox.Show("Cadastro realizado com sucesso!");
        		txtUsuario.Clear();
        		txtSenha.Clear();
        		txtConfirmeSenha.Clear();
        		
        		TelaInicial telaInicial = new TelaInicial();
        		telaInicial.Show();
        		this.Hide();
   					}
				}			
	
	
		}
		
		
		
		
	}
}