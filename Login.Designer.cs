namespace SAT
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNumPol = new System.Windows.Forms.Label();
            this.txbNumPol = new System.Windows.Forms.TextBox();
            this.lblNomFun = new System.Windows.Forms.Label();
            this.txbNomFun = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.SystemColors.Window;
            this.btnEntrar.Location = new System.Drawing.Point(237, 262);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(96, 23);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "ENTRAR\r\n";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(224, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(142, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "SAT - CORPO DA GUARDA\r\n";
            // 
            // lblNumPol
            // 
            this.lblNumPol.AutoSize = true;
            this.lblNumPol.Location = new System.Drawing.Point(238, 114);
            this.lblNumPol.Name = "lblNumPol";
            this.lblNumPol.Size = new System.Drawing.Size(99, 13);
            this.lblNumPol.TabIndex = 2;
            this.lblNumPol.Text = "NUMERO POLICIA\r\n";
            // 
            // txbNumPol
            // 
            this.txbNumPol.Location = new System.Drawing.Point(237, 130);
            this.txbNumPol.Name = "txbNumPol";
            this.txbNumPol.Size = new System.Drawing.Size(100, 20);
            this.txbNumPol.TabIndex = 3;
            this.txbNumPol.TextChanged += new System.EventHandler(this.txbNumPol_TextChanged);
            // 
            // lblNomFun
            // 
            this.lblNomFun.AutoSize = true;
            this.lblNomFun.Location = new System.Drawing.Point(234, 173);
            this.lblNomFun.Name = "lblNomFun";
            this.lblNomFun.Size = new System.Drawing.Size(103, 13);
            this.lblNomFun.TabIndex = 4;
            this.lblNomFun.Text = "NOME FUNCIONAL";
            // 
            // txbNomFun
            // 
            this.txbNomFun.Location = new System.Drawing.Point(215, 189);
            this.txbNomFun.Name = "txbNomFun";
            this.txbNomFun.Size = new System.Drawing.Size(139, 20);
            this.txbNomFun.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "TEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 383);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbNomFun);
            this.Controls.Add(this.lblNomFun);
            this.Controls.Add(this.txbNumPol);
            this.Controls.Add(this.lblNumPol);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnEntrar);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNumPol;
        private System.Windows.Forms.TextBox txbNumPol;
        private System.Windows.Forms.Label lblNomFun;
        private System.Windows.Forms.TextBox txbNomFun;
        private System.Windows.Forms.Button button1;
    }
}