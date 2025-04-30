using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestãoDeProduto
{
    public partial class UCLogin : telaCadastro
    {
        public UCLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtUsuarioEmail.Text.Equals("") && txtSenha.Text.Equals(""))
                {
                    Metodos metodo = new Metodos();
                    metodo.Email = txtUsuarioEmail.Text;
                    metodo.Usuario = txtUsuarioEmail.Text;
                    metodo.Senha = txtSenha.Text;
                }
                else
                {

                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void linkLblCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
