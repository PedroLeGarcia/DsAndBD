﻿namespace ProjetoBD2
{
    partial class frmUsuario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cdusuarioLabel;
            System.Windows.Forms.Label nmusuarioLabel;
            System.Windows.Forms.Label sgnivelLabel;
            System.Windows.Forms.Label nmloginLabel;
            System.Windows.Forms.Label cdsenhaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.cdusuarioTextBox = new System.Windows.Forms.TextBox();
            this.tbUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroDataSet = new ProjetoBD2.CadastroDataSet();
            this.nmusuarioTextBox = new System.Windows.Forms.TextBox();
            this.sgnivelTextBox = new System.Windows.Forms.TextBox();
            this.nmloginTextBox = new System.Windows.Forms.TextBox();
            this.cdsenhaTextBox = new System.Windows.Forms.TextBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.tbUsuarioTableAdapter = new ProjetoBD2.CadastroDataSetTableAdapters.tbUsuarioTableAdapter();
            cdusuarioLabel = new System.Windows.Forms.Label();
            nmusuarioLabel = new System.Windows.Forms.Label();
            sgnivelLabel = new System.Windows.Forms.Label();
            nmloginLabel = new System.Windows.Forms.Label();
            cdsenhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cdusuarioLabel
            // 
            cdusuarioLabel.AutoSize = true;
            cdusuarioLabel.BackColor = System.Drawing.Color.Transparent;
            cdusuarioLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdusuarioLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            cdusuarioLabel.Location = new System.Drawing.Point(107, 58);
            cdusuarioLabel.Name = "cdusuarioLabel";
            cdusuarioLabel.Size = new System.Drawing.Size(110, 27);
            cdusuarioLabel.TabIndex = 1;
            cdusuarioLabel.Text = "Código:";
            cdusuarioLabel.Click += new System.EventHandler(this.CdusuarioLabel_Click);
            // 
            // nmusuarioLabel
            // 
            nmusuarioLabel.AutoSize = true;
            nmusuarioLabel.BackColor = System.Drawing.Color.Transparent;
            nmusuarioLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nmusuarioLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nmusuarioLabel.Location = new System.Drawing.Point(107, 97);
            nmusuarioLabel.Name = "nmusuarioLabel";
            nmusuarioLabel.Size = new System.Drawing.Size(82, 27);
            nmusuarioLabel.TabIndex = 3;
            nmusuarioLabel.Text = "Nome:";
            nmusuarioLabel.Click += new System.EventHandler(this.NmusuarioLabel_Click);
            // 
            // sgnivelLabel
            // 
            sgnivelLabel.AutoSize = true;
            sgnivelLabel.BackColor = System.Drawing.Color.Transparent;
            sgnivelLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sgnivelLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            sgnivelLabel.Location = new System.Drawing.Point(534, 98);
            sgnivelLabel.Name = "sgnivelLabel";
            sgnivelLabel.Size = new System.Drawing.Size(96, 27);
            sgnivelLabel.TabIndex = 5;
            sgnivelLabel.Text = "Nível:";
            sgnivelLabel.Click += new System.EventHandler(this.SgnivelLabel_Click);
            // 
            // nmloginLabel
            // 
            nmloginLabel.AutoSize = true;
            nmloginLabel.BackColor = System.Drawing.Color.Transparent;
            nmloginLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nmloginLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nmloginLabel.Location = new System.Drawing.Point(107, 139);
            nmloginLabel.Name = "nmloginLabel";
            nmloginLabel.Size = new System.Drawing.Size(96, 27);
            nmloginLabel.TabIndex = 7;
            nmloginLabel.Text = "Login:";
            nmloginLabel.Click += new System.EventHandler(this.NmloginLabel_Click);
            // 
            // cdsenhaLabel
            // 
            cdsenhaLabel.AutoSize = true;
            cdsenhaLabel.BackColor = System.Drawing.Color.Transparent;
            cdsenhaLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cdsenhaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            cdsenhaLabel.Location = new System.Drawing.Point(416, 140);
            cdsenhaLabel.Name = "cdsenhaLabel";
            cdsenhaLabel.Size = new System.Drawing.Size(96, 27);
            cdsenhaLabel.TabIndex = 9;
            cdsenhaLabel.Text = "Senha:";
            cdsenhaLabel.Click += new System.EventHandler(this.CdsenhaLabel_Click);
            // 
            // cdusuarioTextBox
            // 
            this.cdusuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "cdusuario", true));
            this.cdusuarioTextBox.Location = new System.Drawing.Point(209, 65);
            this.cdusuarioTextBox.Name = "cdusuarioTextBox";
            this.cdusuarioTextBox.Size = new System.Drawing.Size(73, 20);
            this.cdusuarioTextBox.TabIndex = 2;
            this.cdusuarioTextBox.TextChanged += new System.EventHandler(this.CdusuarioTextBox_TextChanged);
            // 
            // tbUsuarioBindingSource
            // 
            this.tbUsuarioBindingSource.DataMember = "tbUsuario";
            this.tbUsuarioBindingSource.DataSource = this.cadastroDataSet;
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "CadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nmusuarioTextBox
            // 
            this.nmusuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "nmusuario", true));
            this.nmusuarioTextBox.Location = new System.Drawing.Point(182, 102);
            this.nmusuarioTextBox.Name = "nmusuarioTextBox";
            this.nmusuarioTextBox.Size = new System.Drawing.Size(345, 20);
            this.nmusuarioTextBox.TabIndex = 4;
            this.nmusuarioTextBox.TextChanged += new System.EventHandler(this.NmusuarioTextBox_TextChanged);
            // 
            // sgnivelTextBox
            // 
            this.sgnivelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "sgnivel", true));
            this.sgnivelTextBox.Location = new System.Drawing.Point(627, 102);
            this.sgnivelTextBox.Name = "sgnivelTextBox";
            this.sgnivelTextBox.Size = new System.Drawing.Size(51, 20);
            this.sgnivelTextBox.TabIndex = 6;
            this.sgnivelTextBox.TextChanged += new System.EventHandler(this.SgnivelTextBox_TextChanged);
            // 
            // nmloginTextBox
            // 
            this.nmloginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "nmlogin", true));
            this.nmloginTextBox.Location = new System.Drawing.Point(209, 145);
            this.nmloginTextBox.Name = "nmloginTextBox";
            this.nmloginTextBox.Size = new System.Drawing.Size(201, 20);
            this.nmloginTextBox.TabIndex = 8;
            this.nmloginTextBox.TextChanged += new System.EventHandler(this.NmloginTextBox_TextChanged);
            // 
            // cdsenhaTextBox
            // 
            this.cdsenhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "cdsenha", true));
            this.cdsenhaTextBox.Location = new System.Drawing.Point(506, 145);
            this.cdsenhaTextBox.Name = "cdsenhaTextBox";
            this.cdsenhaTextBox.Size = new System.Drawing.Size(201, 20);
            this.cdsenhaTextBox.TabIndex = 10;
            this.cdsenhaTextBox.TextChanged += new System.EventHandler(this.CdsenhaTextBox_TextChanged);
            // 
            // btnAnterior
            // 
            this.btnAnterior.AutoSize = true;
            this.btnAnterior.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAnterior.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnterior.Location = new System.Drawing.Point(166, 225);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(134, 37);
            this.btnAnterior.TabIndex = 11;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.AutoSize = true;
            this.btnProximo.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnProximo.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProximo.Location = new System.Drawing.Point(321, 225);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(134, 37);
            this.btnProximo.TabIndex = 12;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnNovo.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNovo.Location = new System.Drawing.Point(476, 225);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(134, 37);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAlterar.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlterar.Location = new System.Drawing.Point(170, 294);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(134, 37);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnExcluir.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Location = new System.Drawing.Point(321, 294);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(134, 37);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSalvar.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.Location = new System.Drawing.Point(476, 294);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(134, 37);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(166, 352);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 37);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnPesquisar.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisar.Location = new System.Drawing.Point(166, 405);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(444, 37);
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnImprimir.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimir.Location = new System.Drawing.Point(321, 352);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(134, 37);
            this.btnImprimir.TabIndex = 19;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSair.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(476, 352);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(134, 37);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // tbUsuarioTableAdapter
            // 
            this.tbUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 464);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(cdusuarioLabel);
            this.Controls.Add(this.cdusuarioTextBox);
            this.Controls.Add(nmusuarioLabel);
            this.Controls.Add(this.nmusuarioTextBox);
            this.Controls.Add(sgnivelLabel);
            this.Controls.Add(this.sgnivelTextBox);
            this.Controls.Add(nmloginLabel);
            this.Controls.Add(this.nmloginTextBox);
            this.Controls.Add(cdsenhaLabel);
            this.Controls.Add(this.cdsenhaTextBox);
            this.DoubleBuffered = true;
            this.Name = "frmUsuario";
            this.Text = "Cadastro Usuário";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CadastroDataSet cadastroDataSet;
        private System.Windows.Forms.BindingSource tbUsuarioBindingSource;
        private CadastroDataSetTableAdapters.tbUsuarioTableAdapter tbUsuarioTableAdapter;
        private System.Windows.Forms.TextBox cdusuarioTextBox;
        private System.Windows.Forms.TextBox nmusuarioTextBox;
        private System.Windows.Forms.TextBox sgnivelTextBox;
        private System.Windows.Forms.TextBox nmloginTextBox;
        private System.Windows.Forms.TextBox cdsenhaTextBox;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSair;
    }
}