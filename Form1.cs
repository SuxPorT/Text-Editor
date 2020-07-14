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
		public Form1()
		{
			InitializeComponent();
		}

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

			if (this.rtb_texto.SelectionFont.Bold)
			{
				fonte = rtb_texto.Font.Name;
				tamanho = rtb_texto.Font.Size;
				this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Regular);
			}
			else
			{
				fonte = rtb_texto.Font.Name;
				tamanho = rtb_texto.Font.Size;
				this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Bold);
			}
		}

		private void Italico()
		{
			string fonte = null;
			float tamanho = 0;

			if (this.rtb_texto.SelectionFont.Italic)
			{
				fonte = rtb_texto.Font.Name;
				tamanho = rtb_texto.Font.Size;
				this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Regular);
			}
			else
			{
				fonte = rtb_texto.Font.Name;
				tamanho = rtb_texto.Font.Size;
				this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Italic);
			}
		}

		private void Sublinhado()
		{
			string fonte = null;
			float tamanho = 0;

			if (this.rtb_texto.SelectionFont.Underline)
			{
				fonte = rtb_texto.Font.Name;
				tamanho = rtb_texto.Font.Size;
				this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Regular);
			}
			else
			{
				fonte = rtb_texto.Font.Name;
				tamanho = rtb_texto.Font.Size;
				this.rtb_texto.SelectionFont = new Font(fonte, tamanho, FontStyle.Underline);
			}
		}

		private void btn_novo_Click(object sender, EventArgs e)
		{
			this.Novo();
		}

		private void novoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Novo();
		}

		private void btn_abrir_Click(object sender, EventArgs e)
		{
			this.Abrir();
		}

		private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Abrir();
		}

		private void btn_salvar_Click(object sender, EventArgs e)
		{
			this.Salvar();
		}

		private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Salvar();
		}

		private void btn_copiar_Click(object sender, EventArgs e)
		{
			this.Copiar();
		}

		private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Copiar();
		}

		private void btn_colar_Click(object sender, EventArgs e)
		{
			this.Colar();
		}

		private void colarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Colar();
		}

		private void btn_negrito_Click(object sender, EventArgs e)
		{
			this.Negrito();
		}

		private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Negrito();
		}

		private void btn_italico_Click(object sender, EventArgs e)
		{
			this.Italico();
		}

		private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Italico();
		}

		private void btn_sublinhado_Click(object sender, EventArgs e)
		{
			this.Sublinhado();
		}

		private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Sublinhado();
		}
	}
}
