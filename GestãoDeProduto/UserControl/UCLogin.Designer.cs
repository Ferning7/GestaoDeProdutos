namespace GestãoDeProduto
{
    partial class UCLogin
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnEntrar = new Button();
            gbLogin = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            txtUsuarioEmail = new TextBox();
            txtSenha = new TextBox();
            lblLogIn = new Label();
            linkLblCadastrar = new LinkLabel();
            gbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(467, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(551, 731);
            panel1.TabIndex = 0;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(135, 399);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(129, 44);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // gbLogin
            // 
            gbLogin.Controls.Add(linkLblCadastrar);
            gbLogin.Controls.Add(lblLogIn);
            gbLogin.Controls.Add(txtSenha);
            gbLogin.Controls.Add(txtUsuarioEmail);
            gbLogin.Controls.Add(label2);
            gbLogin.Controls.Add(label1);
            gbLogin.Controls.Add(btnEntrar);
            gbLogin.Location = new Point(37, 64);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(398, 605);
            gbLogin.TabIndex = 1;
            gbLogin.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 171);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 1;
            label1.Text = "Usuário/Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 272);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 2;
            label2.Text = "Senha:";
            // 
            // txtUsuarioEmail
            // 
            txtUsuarioEmail.Location = new Point(70, 199);
            txtUsuarioEmail.Name = "txtUsuarioEmail";
            txtUsuarioEmail.Size = new Size(251, 31);
            txtUsuarioEmail.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(70, 300);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(251, 31);
            txtSenha.TabIndex = 4;
            // 
            // lblLogIn
            // 
            lblLogIn.AutoSize = true;
            lblLogIn.Font = new Font("Arial", 17F, FontStyle.Bold);
            lblLogIn.Location = new Point(143, 79);
            lblLogIn.Name = "lblLogIn";
            lblLogIn.Size = new Size(118, 40);
            lblLogIn.TabIndex = 5;
            lblLogIn.Text = "Log In";
            // 
            // linkLblCadastrar
            // 
            linkLblCadastrar.AutoSize = true;
            linkLblCadastrar.Location = new Point(156, 446);
            linkLblCadastrar.Name = "linkLblCadastrar";
            linkLblCadastrar.Size = new Size(87, 25);
            linkLblCadastrar.TabIndex = 6;
            linkLblCadastrar.TabStop = true;
            linkLblCadastrar.Text = "Cadastrar";
            linkLblCadastrar.LinkClicked += linkLblCadastrar_LinkClicked;
            // 
            // UCLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbLogin);
            Controls.Add(panel1);
            Name = "UCLogin";
            Size = new Size(1018, 731);
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnEntrar;
        private GroupBox gbLogin;
        private TextBox txtSenha;
        private TextBox txtUsuarioEmail;
        private Label label2;
        private Label label1;
        private Label lblLogIn;
        private LinkLabel linkLblCadastrar;
    }
}
