namespace TextEditor
{
	partial class Form1
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
			this.rtb_texto = new System.Windows.Forms.RichTextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.negritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.itálicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sublinhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alinhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.centralizadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.esquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.direitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btn_novo = new System.Windows.Forms.ToolStripButton();
			this.btn_abrir = new System.Windows.Forms.ToolStripButton();
			this.btn_salvar = new System.Windows.Forms.ToolStripButton();
			this.tss_1 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_copiar = new System.Windows.Forms.ToolStripButton();
			this.btn_colar = new System.Windows.Forms.ToolStripButton();
			this.tss_2 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_negrito = new System.Windows.Forms.ToolStripButton();
			this.btn_italico = new System.Windows.Forms.ToolStripButton();
			this.btn_sublinhado = new System.Windows.Forms.ToolStripButton();
			this.tss_3 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_centralizado = new System.Windows.Forms.ToolStripButton();
			this.btn_esquerda = new System.Windows.Forms.ToolStripButton();
			this.btn_direita = new System.Windows.Forms.ToolStripButton();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// rtb_texto
			// 
			this.rtb_texto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtb_texto.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtb_texto.Location = new System.Drawing.Point(12, 52);
			this.rtb_texto.Name = "rtb_texto";
			this.rtb_texto.Size = new System.Drawing.Size(600, 317);
			this.rtb_texto.TabIndex = 0;
			this.rtb_texto.Text = "";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatarToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(624, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// arquivoToolStripMenuItem
			// 
			this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
			this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
			this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.arquivoToolStripMenuItem.Text = "Arquivo";
			// 
			// novoToolStripMenuItem
			// 
			this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
			this.novoToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.novoToolStripMenuItem.Text = "Novo";
			this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
			// 
			// abrirToolStripMenuItem
			// 
			this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
			this.abrirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.abrirToolStripMenuItem.Text = "Abrir";
			this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
			// 
			// salvarToolStripMenuItem
			// 
			this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
			this.salvarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.salvarToolStripMenuItem.Text = "Salvar";
			this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
			// 
			// imprimirToolStripMenuItem
			// 
			this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
			this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.imprimirToolStripMenuItem.Text = "Imprimir";
			this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 6);
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.sairToolStripMenuItem.Text = "Sair";
			this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
			// 
			// editarToolStripMenuItem
			// 
			this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem});
			this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
			this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
			this.editarToolStripMenuItem.Text = "Editar";
			// 
			// copiarToolStripMenuItem
			// 
			this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
			this.copiarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
			this.copiarToolStripMenuItem.Text = "Copiar";
			this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
			// 
			// colarToolStripMenuItem
			// 
			this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
			this.colarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
			this.colarToolStripMenuItem.Text = "Colar";
			this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
			// 
			// formatarToolStripMenuItem
			// 
			this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negritoToolStripMenuItem,
            this.itálicoToolStripMenuItem,
            this.sublinhadoToolStripMenuItem,
            this.alinhadoToolStripMenuItem});
			this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
			this.formatarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.formatarToolStripMenuItem.Text = "Formatar";
			// 
			// negritoToolStripMenuItem
			// 
			this.negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
			this.negritoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.negritoToolStripMenuItem.Text = "Negrito";
			this.negritoToolStripMenuItem.Click += new System.EventHandler(this.negritoToolStripMenuItem_Click);
			// 
			// itálicoToolStripMenuItem
			// 
			this.itálicoToolStripMenuItem.Name = "itálicoToolStripMenuItem";
			this.itálicoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.itálicoToolStripMenuItem.Text = "Itálico";
			this.itálicoToolStripMenuItem.Click += new System.EventHandler(this.itálicoToolStripMenuItem_Click);
			// 
			// sublinhadoToolStripMenuItem
			// 
			this.sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
			this.sublinhadoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.sublinhadoToolStripMenuItem.Text = "Sublinhado";
			this.sublinhadoToolStripMenuItem.Click += new System.EventHandler(this.sublinhadoToolStripMenuItem_Click);
			// 
			// alinhadoToolStripMenuItem
			// 
			this.alinhadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centralizadoToolStripMenuItem,
            this.esquerdaToolStripMenuItem,
            this.direitaToolStripMenuItem});
			this.alinhadoToolStripMenuItem.Name = "alinhadoToolStripMenuItem";
			this.alinhadoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.alinhadoToolStripMenuItem.Text = "Alinhamento";
			// 
			// centralizadoToolStripMenuItem
			// 
			this.centralizadoToolStripMenuItem.Name = "centralizadoToolStripMenuItem";
			this.centralizadoToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.centralizadoToolStripMenuItem.Text = "Centralizado";
			this.centralizadoToolStripMenuItem.Click += new System.EventHandler(this.centralizadoToolStripMenuItem_Click);
			// 
			// esquerdaToolStripMenuItem
			// 
			this.esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
			this.esquerdaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.esquerdaToolStripMenuItem.Text = "Esquerda";
			this.esquerdaToolStripMenuItem.Click += new System.EventHandler(this.esquerdaToolStripMenuItem_Click);
			// 
			// direitaToolStripMenuItem
			// 
			this.direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
			this.direitaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.direitaToolStripMenuItem.Text = "Direita";
			this.direitaToolStripMenuItem.Click += new System.EventHandler(this.direitaToolStripMenuItem_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_novo,
            this.btn_abrir,
            this.btn_salvar,
            this.tss_1,
            this.btn_copiar,
            this.btn_colar,
            this.tss_2,
            this.btn_negrito,
            this.btn_italico,
            this.btn_sublinhado,
            this.tss_3,
            this.btn_centralizado,
            this.btn_esquerda,
            this.btn_direita});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(624, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btn_novo
			// 
			this.btn_novo.BackgroundImage = global::TextEditor.Properties.Resources._new;
			this.btn_novo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_novo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_novo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_novo.Name = "btn_novo";
			this.btn_novo.Size = new System.Drawing.Size(23, 22);
			this.btn_novo.Text = "Novo";
			this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
			// 
			// btn_abrir
			// 
			this.btn_abrir.BackgroundImage = global::TextEditor.Properties.Resources.open;
			this.btn_abrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_abrir.Name = "btn_abrir";
			this.btn_abrir.Size = new System.Drawing.Size(23, 22);
			this.btn_abrir.Text = "Abrir";
			this.btn_abrir.Click += new System.EventHandler(this.btn_abrir_Click);
			// 
			// btn_salvar
			// 
			this.btn_salvar.BackgroundImage = global::TextEditor.Properties.Resources.save;
			this.btn_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_salvar.Name = "btn_salvar";
			this.btn_salvar.Size = new System.Drawing.Size(23, 22);
			this.btn_salvar.Text = "Salvar";
			this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
			// 
			// tss_1
			// 
			this.tss_1.Name = "tss_1";
			this.tss_1.Size = new System.Drawing.Size(6, 25);
			// 
			// btn_copiar
			// 
			this.btn_copiar.BackgroundImage = global::TextEditor.Properties.Resources.copy;
			this.btn_copiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_copiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_copiar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_copiar.Name = "btn_copiar";
			this.btn_copiar.Size = new System.Drawing.Size(23, 22);
			this.btn_copiar.Text = "Copiar";
			this.btn_copiar.Click += new System.EventHandler(this.btn_copiar_Click);
			// 
			// btn_colar
			// 
			this.btn_colar.BackgroundImage = global::TextEditor.Properties.Resources.paste;
			this.btn_colar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_colar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_colar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_colar.Name = "btn_colar";
			this.btn_colar.Size = new System.Drawing.Size(23, 22);
			this.btn_colar.Text = "Colar";
			this.btn_colar.Click += new System.EventHandler(this.btn_colar_Click);
			// 
			// tss_2
			// 
			this.tss_2.Name = "tss_2";
			this.tss_2.Size = new System.Drawing.Size(6, 25);
			// 
			// btn_negrito
			// 
			this.btn_negrito.BackgroundImage = global::TextEditor.Properties.Resources.bold;
			this.btn_negrito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_negrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_negrito.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_negrito.Name = "btn_negrito";
			this.btn_negrito.Size = new System.Drawing.Size(23, 22);
			this.btn_negrito.Text = "Negrito";
			this.btn_negrito.Click += new System.EventHandler(this.btn_negrito_Click);
			// 
			// btn_italico
			// 
			this.btn_italico.BackgroundImage = global::TextEditor.Properties.Resources.italic;
			this.btn_italico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_italico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_italico.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_italico.Name = "btn_italico";
			this.btn_italico.Size = new System.Drawing.Size(23, 22);
			this.btn_italico.Text = "Itálico";
			this.btn_italico.Click += new System.EventHandler(this.btn_italico_Click);
			// 
			// btn_sublinhado
			// 
			this.btn_sublinhado.BackgroundImage = global::TextEditor.Properties.Resources.underline;
			this.btn_sublinhado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_sublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_sublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_sublinhado.Name = "btn_sublinhado";
			this.btn_sublinhado.Size = new System.Drawing.Size(23, 22);
			this.btn_sublinhado.Text = "Sublinhado";
			this.btn_sublinhado.Click += new System.EventHandler(this.btn_sublinhado_Click);
			// 
			// tss_3
			// 
			this.tss_3.Name = "tss_3";
			this.tss_3.Size = new System.Drawing.Size(6, 25);
			// 
			// btn_centralizado
			// 
			this.btn_centralizado.BackgroundImage = global::TextEditor.Properties.Resources.center;
			this.btn_centralizado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_centralizado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_centralizado.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_centralizado.Name = "btn_centralizado";
			this.btn_centralizado.Size = new System.Drawing.Size(23, 22);
			this.btn_centralizado.Text = "Centralizado";
			this.btn_centralizado.Click += new System.EventHandler(this.btn_centralizado_Click);
			// 
			// btn_esquerda
			// 
			this.btn_esquerda.BackgroundImage = global::TextEditor.Properties.Resources.left;
			this.btn_esquerda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_esquerda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_esquerda.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_esquerda.Name = "btn_esquerda";
			this.btn_esquerda.Size = new System.Drawing.Size(23, 22);
			this.btn_esquerda.Text = "Esquerda";
			this.btn_esquerda.Click += new System.EventHandler(this.btn_esquerda_Click);
			// 
			// btn_direita
			// 
			this.btn_direita.BackgroundImage = global::TextEditor.Properties.Resources.right;
			this.btn_direita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_direita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_direita.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_direita.Name = "btn_direita";
			this.btn_direita.Size = new System.Drawing.Size(23, 22);
			this.btn_direita.Text = "Direita";
			this.btn_direita.Click += new System.EventHandler(this.btn_direita_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "txt";
			this.saveFileDialog1.Filter = "(*.txt)|*.txt";
			// 
			// printDialog1
			// 
			this.printDialog1.UseEXDialog = true;
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 381);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.rtb_texto);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Text Editor";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtb_texto;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem negritoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem itálicoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sublinhadoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alinhadoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem centralizadoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem esquerdaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem direitaToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btn_novo;
		private System.Windows.Forms.ToolStripButton btn_abrir;
		private System.Windows.Forms.ToolStripButton btn_salvar;
		private System.Windows.Forms.ToolStripSeparator tss_1;
		private System.Windows.Forms.ToolStripButton btn_copiar;
		private System.Windows.Forms.ToolStripButton btn_colar;
		private System.Windows.Forms.ToolStripSeparator tss_2;
		private System.Windows.Forms.ToolStripButton btn_negrito;
		private System.Windows.Forms.ToolStripButton btn_italico;
		private System.Windows.Forms.ToolStripButton btn_sublinhado;
		private System.Windows.Forms.ToolStripSeparator tss_3;
		private System.Windows.Forms.ToolStripButton btn_centralizado;
		private System.Windows.Forms.ToolStripButton btn_esquerda;
		private System.Windows.Forms.ToolStripButton btn_direita;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
	}
}

