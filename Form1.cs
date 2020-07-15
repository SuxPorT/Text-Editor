using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEditor
{
	public partial class Form1 : Form
	{
		StringReader leitura = null;

		public Form1()
		{
			InitializeComponent();
		}

		// Funções principais
		private void Novo()
		{
			this.rtb_texto.Clear();
			this.rtb_texto.Focus();
		}

		private void Abrir()
		{
			this.openFileDialog1.Title = "Abrir arquivo";
			this.openFileDialog1.InitialDirectory = @"Desktop";
			this.openFileDialog1.Filter = "Arquivos de texto (*.txt)|*.txt|Todos arquivos (*.*)|*.*";

			DialogResult resultado_DialogResult = this.openFileDialog1.ShowDialog();

			if (resultado_DialogResult == System.Windows.Forms.DialogResult.OK)
			{
				try
				{
					FileStream arquivo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
					StreamReader arquivo_StreamReader = new StreamReader(arquivo);
					string linha = arquivo_StreamReader.ReadLine();
					this.rtb_texto.Text = "";

					while (linha != null)
					{
						this.rtb_texto.Text += linha + "\n";
						linha = arquivo_StreamReader.ReadLine();
					}

					arquivo_StreamReader.Close();
				}
				catch (Exception e)
				{
					MessageBox.Show("Erro de leitura: " + e.Message, "Erro ao ler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void Salvar()
		{
			try
			{
				if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
					StreamWriter arquivo_StreamWriter = new StreamWriter(arquivo);

					arquivo_StreamWriter.Flush();
					arquivo_StreamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
					arquivo_StreamWriter.Write(rtb_texto.Text);
					arquivo_StreamWriter.Flush();
					arquivo_StreamWriter.Close();
				}
			}
			catch (Exception e)
			{
				MessageBox.Show("Erro na gravação: " + e.Message, "Erro ao gravar", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Impirmir()
		{
			this.printDialog1.Document = this.printDocument1;
			string texto = this.rtb_texto.Text;
			this.leitura = new StringReader(texto);

			if (this.printDialog1.ShowDialog() == DialogResult.OK) {
				this.printDocument1.Print();
			}
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			float linhasPagina = 0;
			float posicaoY = 0;
			int contador = 0;
			float margemEsquerda = e.MarginBounds.Left - 50;
			float margemSuperior = e.MarginBounds.Top - 50;

			if (margemEsquerda < 5)
			{
				margemEsquerda = 20;
			}

			if (margemSuperior < 5)
			{
				margemSuperior = 20;
			}

			Font fonte = this.rtb_texto.Font;
			SolidBrush pincel = new SolidBrush(Color.Black);
			linhasPagina = e.MarginBounds.Height / Font.GetHeight(e.Graphics);
			string linha = this.leitura.ReadLine();

			while (contador++ < linhasPagina)
			{
				posicaoY = (margemSuperior + (contador * fonte.GetHeight(e.Graphics)));
				e.Graphics.DrawString(linha, fonte, pincel, margemEsquerda, posicaoY, new StringFormat());
				linha = this.leitura.ReadLine();
			}

			if (linha != null)
			{
				e.HasMorePages = true;
			}
			else
			{
				e.HasMorePages = false;
			}

			pincel.Dispose();
		}

		private void Copiar()
		{
			if (rtb_texto.SelectionLength > 0)
			{
				rtb_texto.Copy();
			}
		}

		private void Colar()
		{
			rtb_texto.Paste();
		}

		private void Negrito()
		{
			string fonte = null;
			float tamanho = 0;
			bool negrito, italico, sublinhado;

			fonte = rtb_texto.Font.Name;
			tamanho = rtb_texto.Font.Size;
			negrito = rtb_texto.SelectionFont.Bold;
			italico = rtb_texto.SelectionFont.Italic;
			sublinhado = rtb_texto.SelectionFont.Underline;

			if (this.rtb_texto.SelectionFont.Bold)
			{
				if (italico && sublinhado)
				{
					this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Italic | FontStyle.Underline);
				}
				else if	(italico)
				{
					this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Italic);
				}
				else if (sublinhado)
				{
					this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Underline);
				}
				else
				{
					this.rtb_texto.SelectionFont = new Font(fonte, tamanho);
				}
			}
			else
			{
				if (italico && sublinhado)
				{
					this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
				}
				else if (italico)
				{
					this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Bold | FontStyle.Italic);
				}
				else if (sublinhado)
				{
					this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Bold | FontStyle.Underline);
				}
				else
				{
					this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Bold);
				}
			}
		}

		private void Italico()
		{
			string fonte = null;
			float tamanho = 0;
			bool negrito, italico, sublinhado;

			fonte = rtb_texto.Font.Name;
			tamanho = rtb_texto.Font.Size;
			negrito = rtb_texto.SelectionFont.Bold;
			italico = rtb_texto.SelectionFont.Italic;
			sublinhado = rtb_texto.SelectionFont.Underline;

			if (this.rtb_texto.SelectionFont.Italic)
			{
				if (negrito && sublinhado)
				{
					this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Bold | FontStyle.Underline);
				}
				else if (negrito)
				{
					this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Bold);
				}
				else if (sublinhado)
				{
					this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Underline);
				}
				else
				{
					this.rtb_texto.SelectionFont = new Font(fonte, tamanho);
				}
			}
			else
			{
				if (negrito && sublinhado)
				{
					this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);
				}
				else if (negrito)
				{
					this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Italic | FontStyle.Bold);
				}
				else if (sublinhado)
				{
					this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Italic | FontStyle.Underline);
				}
				else
				{
					this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Italic);
				}
			}
		}

		private void Sublinhado()
		{
			string fonte = null;
			float tamanho = 0;
			bool negrito, italico, sublinhado;

			fonte = rtb_texto.Font.Name;
			tamanho = rtb_texto.Font.Size;
			negrito = rtb_texto.SelectionFont.Bold;
			italico = rtb_texto.SelectionFont.Italic;
			sublinhado = rtb_texto.SelectionFont.Underline;

			if (this.rtb_texto.SelectionFont.Underline)
			{
				if (negrito && italico)
				{
					this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Bold | FontStyle.Underline);
				}
				else if (negrito)
				{
					this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Bold);
				}
				else if (italico)
				{
					this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Underline);
				}
				else
				{
					this.rtb_texto.SelectionFont = new Font(fonte, tamanho);
				}
			}
			else
			{
				if (negrito && italico)
				{
					this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Underline | FontStyle.Bold | FontStyle.Underline);
				}
				else if (negrito)
				{
					this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Underline | FontStyle.Bold);
				}
				else if (italico)
				{
					this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Underline | FontStyle.Italic);
				}
				else
				{
					this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Underline);
				}
			}
		}

		private void AlinharCentralizado()
		{
			this.rtb_texto.SelectionAlignment = HorizontalAlignment.Center;
		}

		private void AlinharEsquerda()
		{
			this.rtb_texto.SelectionAlignment = HorizontalAlignment.Left;
		}

		private void AlinharDireita()
		{
			this.rtb_texto.SelectionAlignment = HorizontalAlignment.Right;
		}

		// Eventos do Menu Strip
		private void novoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Novo();
		}

		private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Abrir();
		}

		private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Salvar();
		}

		private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Impirmir();
		}

		private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Copiar();
		}

		private void colarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Colar();
		}

		private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Negrito();
		}

		private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Italico();
		}

		private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Sublinhado();
		}

		private void centralizadoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.AlinharCentralizado();
		}

		private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.AlinharEsquerda();
		}

		private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.AlinharDireita();
		}

		// Eventos do Tool Strip
		private void btn_novo_Click(object sender, EventArgs e)
		{
			this.Novo();
		}

		private void btn_abrir_Click(object sender, EventArgs e)
		{
			this.Abrir();
		}

		private void btn_salvar_Click(object sender, EventArgs e)
		{
			this.Salvar();
		}

		private void btn_copiar_Click(object sender, EventArgs e)
		{
			this.Copiar();
		}

		private void btn_colar_Click(object sender, EventArgs e)
		{
			this.Colar();
		}

		private void btn_negrito_Click(object sender, EventArgs e)
		{
			this.Negrito();
		}

		private void btn_italico_Click(object sender, EventArgs e)
		{
			this.Italico();
		}

		private void btn_sublinhado_Click(object sender, EventArgs e)
		{
			this.Sublinhado();
		}

		private void btn_centralizado_Click(object sender, EventArgs e)
		{
			this.AlinharCentralizado();
		}

		private void btn_esquerda_Click(object sender, EventArgs e)
		{
			this.AlinharEsquerda();
		}

		private void btn_direita_Click(object sender, EventArgs e)
		{
			this.AlinharDireita();
		}
	}
}