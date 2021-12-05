using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDI_Evaluation
{
    public partial class FormRobotLoop : Form
    {
        private int Linha { get; set; }
        private int Coluna { get; set; }
        private List<Posicao> Posicoes {get;set; }   
        private string Comandos { get; set; }
        private string Resultado { get; set; }
        public FormRobotLoop()
        {
            IniciarVariaveis();

            InitializeComponent();
        }

        private void IniciarVariaveis()
        {
            Linha = 0;
            Coluna = 0;
            Posicoes = new List<Posicao>
            {
                new Posicao(Linha, Coluna)
            };
            Comandos = "";
            Resultado = "";

        }
        #region Métodos do formulário
        private void FormRobotLoop_KeyDown(object sender, KeyEventArgs e)
        {
            var Tecla = e.KeyData;

            switch (Tecla)
            {
                case Keys.Left:
                    GravaComando(Movimentos.Left);
                    break;
                case Keys.Up:
                    GravaComando(Movimentos.Up);
                    break;
                case Keys.Right:
                    GravaComando(Movimentos.Right);
                    break;
                case Keys.Down:
                    GravaComando(Movimentos.Down);
                    break;
                default:
                    break;
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            GravaComando(Movimentos.Up);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            GravaComando(Movimentos.Right);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            GravaComando(Movimentos.Left);
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            GravaComando(Movimentos.Down);
        }
        #endregion

        private void GravaComando(Movimentos Direcao)
        {
            listBoxComandos.Items.Add(Direcao);

            switch (Direcao)
            {
                case Movimentos.Up:
                    Linha++;
                    Comandos += "U";
                    break;
                case Movimentos.Down:
                    Linha--;
                    Comandos += "D";
                    break;
                case Movimentos.Left:
                    Coluna--;
                    Comandos += "L";
                    break;
                case Movimentos.Right:
                    Coluna++;
                    Comandos += "R";
                    break;
                default:
                    break;
            }

            var Nova = new Posicao(Linha, Coluna);

            labelLinha.Text = $"Linha: {Linha}";
            labelColuna.Text = $"Coluna: {Coluna}";

            if (Posicoes.Any( x => x.Coluna == Coluna && x.Linha == Linha) )
            {
                if (!string.IsNullOrEmpty(Resultado))
                {
                    Resultado = Comandos;
                }
            }
            else
            {
                Posicoes.Add(Nova);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonExecutar_Click(object sender, EventArgs e)
        {
            var Texto = textBox1.Text;
            var Letra = "";

            for (int i = 0; i < Texto.Length; i++)
            {
                Letra = Texto.Substring(i, 1);

                switch (Letra)
                {
                    case "L":
                        GravaComando(Movimentos.Left);
                        break;
                    case "U":
                        GravaComando(Movimentos.Up);
                        break;
                    case "R":
                        GravaComando(Movimentos.Right);
                        break;
                    case "D":
                        GravaComando(Movimentos.Down);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
