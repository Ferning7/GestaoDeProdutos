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
            label2 = new Label();
            txtUsuarioEmail = new TextBox();
            label1 = new Label();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            lblLogIn = new Label();
            linkLblCadastrar = new LinkLabel();
            panel1 = new Panel();
            gbLogin = new GroupBox();
            panel1.SuspendLayout();
            gbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 296);
            label2.Name = "label2";
            label2.Size = new Size(75, 29);
            label2.TabIndex = 2;
            label2.Text = "Senha:";
            // 
            // txtUsuarioEmail
            // 
            txtUsuarioEmail.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuarioEmail.Location = new Point(231, 211);
            txtUsuarioEmail.Name = "txtUsuarioEmail";
            txtUsuarioEmail.Size = new Size(276, 35);
            txtUsuarioEmail.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 178);
            label1.Name = "label1";
            label1.Size = new Size(139, 29);
            label1.TabIndex = 1;
            label1.Text = "Usuário/Email:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(231, 328);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(276, 35);
            txtSenha.TabIndex = 4;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(302, 443);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(142, 51);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblLogIn
            // 
            lblLogIn.AutoSize = true;
            lblLogIn.Font = new Font("Arial", 17F, FontStyle.Bold);
            lblLogIn.Location = new Point(319, 86);
            lblLogIn.Name = "lblLogIn";
            lblLogIn.Size = new Size(118, 40);
            lblLogIn.TabIndex = 5;
            lblLogIn.Text = "Log In";
            // 
            // linkLblCadastrar
            // 
            linkLblCadastrar.AutoSize = true;
            linkLblCadastrar.Location = new Point(326, 497);
            linkLblCadastrar.Name = "linkLblCadastrar";
            linkLblCadastrar.Size = new Size(100, 29);
            linkLblCadastrar.TabIndex = 6;
            linkLblCadastrar.TabStop = true;
            linkLblCadastrar.Text = "Cadastrar";
            linkLblCadastrar.LinkClicked += linkLblCadastrar_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(gbLogin);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(996, 675);
            panel1.TabIndex = 0;
            // 
            // gbLogin
            // 
            gbLogin.BackColor = SystemColors.Control;
            gbLogin.Controls.Add(linkLblCadastrar);
            gbLogin.Controls.Add(lblLogIn);
            gbLogin.Controls.Add(txtSenha);
            gbLogin.Controls.Add(txtUsuarioEmail);
            gbLogin.Controls.Add(label2);
            gbLogin.Controls.Add(label1);
            gbLogin.Controls.Add(btnEntrar);
            gbLogin.Location = new Point(113, 44);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(746, 578);
            gbLogin.TabIndex = 1;
            gbLogin.TabStop = false;
            // 
            // UCLogin
            // 
            AutoScaleDimensions = new SizeF(11F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 675);
            Controls.Add(panel1);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UCLogin";
            panel1.ResumeLayout(false);
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private TextBox txtUsuarioEmail;
        private Label label1;
        private TextBox txtSenha;
        private Button btnEntrar;
        private Label lblLogIn;
        private LinkLabel linkLblCadastrar;
        private Panel panel1;
        private GroupBox gbLogin;
    }
}
