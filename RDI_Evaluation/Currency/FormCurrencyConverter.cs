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
    public partial class FormCurrencyConverter : Form
    {
        private List<string> Centenas { get; set; }
        private List<string> Dezenas { get; set; }
        private List<string> ValoresUnicos { get; set; }

        public FormCurrencyConverter()
        {
            IniciarVariaveis();

            InitializeComponent();
        }

        private void IniciarVariaveis()
        {
            PreencheValoresUnicos();
            PreencheCentenas();
            PreencheDezenas();
        }

        private void PreencheCentenas()
        {
            Centenas = new List<string>();
            Centenas.Add("");
            Centenas.Add("cento");
            Centenas.Add("duzentos");
            Centenas.Add("trezentos");
            Centenas.Add("quatrocentos");
            Centenas.Add("quinhentos");
            Centenas.Add("seiscentos");
            Centenas.Add("setecentos");
            Centenas.Add("oitocentos");
            Centenas.Add("novecentos");
        }

        private void PreencheDezenas()
        {
            Dezenas = new List<string>();
            Dezenas.Add("");
            Dezenas.Add("dez");
            Dezenas.Add("vinte");
            Dezenas.Add("trinta");
            Dezenas.Add("quarenta");
            Dezenas.Add("cinquenta");
            Dezenas.Add("sessenta");
            Dezenas.Add("setenta");
            Dezenas.Add("oitenta");
            Dezenas.Add("noventa");
        }

        private void PreencheValoresUnicos()
        {
            ValoresUnicos = new List<string>();
            ValoresUnicos.Add("zero");
            ValoresUnicos.Add("um");
            ValoresUnicos.Add("dois");
            ValoresUnicos.Add("três");
            ValoresUnicos.Add("quatro");
            ValoresUnicos.Add("cinco");
            ValoresUnicos.Add("seis");
            ValoresUnicos.Add("sete");
            ValoresUnicos.Add("oito");
            ValoresUnicos.Add("nove");
            ValoresUnicos.Add("dez");
            ValoresUnicos.Add("onze");
            ValoresUnicos.Add("doze");
            ValoresUnicos.Add("treze");
            ValoresUnicos.Add("quatorze");
            ValoresUnicos.Add("quinze");
            ValoresUnicos.Add("dezesseis");
            ValoresUnicos.Add("dezessete");
            ValoresUnicos.Add("dezoito");
            ValoresUnicos.Add("dezenove");
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (!IsValidNumber(textBoxValue.Text))
            {
                MessageBox.Show("Número inválido, verifique!");
                textBoxValue.Focus();
                return;
            }
            
            if (!IsValidNumber(textBoxDecimals.Text))
            {
                MessageBox.Show("Decimais inválidos, verifique!");
                textBoxValue.Focus();
                return;
            }

            textBoxResult.Text = ConvertCurrency(textBoxValue.Text, textBoxDecimals.Text);
        }

        private bool IsValidNumber(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }

            try
            {
                var Numero = Convert.ToInt32(text);

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        private string ConvertCurrency(string ValueText, string DecimalText)
        {
            var Milhoes = 0;
            var Milhares = 0;
            var Resto = 0;
            var Valor = Convert.ToInt32(ValueText);
            var Decimais = Convert.ToInt32(DecimalText);

            var Result = "";

            //-- Verificar se tem milhões
            if (ValueText.Length > 6)
            {
                Milhoes = Convert.ToInt32(ValueText.Substring(0, ValueText.Length - 6));
                Valor -= Milhoes * 1000000;
                ValueText = Valor.ToString();
            }

            //-- Verificar se tem milhares
            if (ValueText.Length > 3)
            {
                Milhares = Convert.ToInt32(ValueText.Substring(0, ValueText.Length - 3));
                Valor -= Milhares * 1000;
                ValueText = Valor.ToString();
            }
            
            //-- Tratar o resto do valor
            Resto = Convert.ToInt32(ValueText);

            #region Montar o resultado final
            //-- Milhões
            Result += TratarMilhao(Milhoes);

            //-- Milhares
            //Result += TratarMilhares(Milhares);
            var Mils = TratarMilhares(Milhares);

            Result += Mils;

            //-- Unidades/Dezenas/Centenas
            var RestoTexto = TratarResto(Resto);

            //-- Confere se tem Unidades/Dezenas/Centenas 
            if (!string.IsNullOrEmpty(RestoTexto))
            {
                if (!string.IsNullOrEmpty(Result))
                {
                    Result += " e ";
                }

                Result += RestoTexto;
            }
            //-- Se não tem
            else
            {
                //-- Confere se tem algum valor preenchido
                if (!string.IsNullOrEmpty(Result))
                {
                    if (string.IsNullOrEmpty(Mils))
                    {
                        Result += "de reais ";
                    }
                    else
                    {
                        Result += "reais ";
                    }
                }
            }
            
            //-- Centavos
            var Centavos = TratarDecimais(Decimais);

            //-- Se tem centavos
            if (!string.IsNullOrEmpty(Centavos))
            {
                //-- Se tem reais também
                if (!string.IsNullOrEmpty(Result))
                {
                    Result += " e ";
                }

                Result += Centavos;
            }
            //-- Se não tem centavos nem reais
            else if (string.IsNullOrEmpty(Result))
            {
                Result += "zero centavos";
            }
            #endregion

            //-- Tratar texto
            Result = Result.Trim().Replace("  "," ");

            Result = Result.Substring(0,1).ToUpper() + Result.Substring(1);

            if (Result.Substring(0, "Um mil".Length) == "Um mil")
            {
                Result = "M" + Result.Substring(4);
            }

            return Result;
        }

        private string TratarMilhao(int milhoes)
        {
            return TratarValor(milhoes, "milhões", "milhão");
        }

        private string TratarMilhares(int milhares)
        {
            return TratarValor(milhares, "mil", "mil");
        }

        private string TratarResto(int resto)
        {
            return TratarValor(resto, "reais", "real");
        }

        private string TratarDecimais(int Decimais)
        {
            return TratarValor(Decimais, "centavos", "centavo");
        }

        private string TratarValor(int valor, string plural, string singular)
        {
            var Result = "";

            //-- Caso não tenha valor, retorna vazio
            if (valor <= 0)
            {
                return Result;
            }

            //-- Converter o valor em texto
            Result += ConvertToText(valor);

            //-- Adicionar a descrição apropriada no singular/plural
            if (valor > 1)
            {
                Result += $" {plural} ";
            }
            else
            {
                Result += $" {singular} ";
            }

            return Result;
        }

        private string ConvertToText(int Valor)
        {
            var Result = "";

            if (Valor <= 0)
            {
                return "";
            }
            else if (Valor < 20)
            {
                return ValoresUnicos[Valor];
            }
            else
            {
                if (Valor > 99)
                {
                    var Centena = Convert.ToInt32(Valor.ToString().Substring(0, 1));
                    
                    Valor -= Centena * 100;

                    if (Valor <= 0 && Centena == 1)
                    {
                        Result += "cem";
                    }
                    else
                    {
                        Result += Centenas[Centena];
                    }

                }

                if (Valor >= 20)
                {
                    var Dezena = Convert.ToInt32(Valor.ToString().Substring(0, 1));

                    if (!string.IsNullOrEmpty(Result))
                    {
                        Result += " e ";
                    }

                    Result += Dezenas[Dezena];
                    Valor -= Dezena * 10;
                }

                if (Valor > 0)
                {
                    if (!string.IsNullOrEmpty(Result))
                    {
                        Result += " e ";
                    }

                    Result += ValoresUnicos[Valor];
                }
            }

            return Result;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var ctrl = (Control)sender;    
                SelectNextControl(ctrl,!e.Shift,true,true,true);
            }
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            var ctrl = (TextBox)sender;
            ctrl.SelectAll();
        }
    }
}
