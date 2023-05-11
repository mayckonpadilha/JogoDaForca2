using JogoDaForca2.WinApp.Properties;
using System.Resources;

namespace JogoDaForca2.WinApp
{
    public partial class Form1 : Form
    {
        public char palpite;
        Forca jogo = new Forca();
        char charComErro = '?';
        public Form1()
        {
            InitializeComponent();
            ConfigurarClickDosBotoes();
        }
        
        private void ConfigurarClickDosBotoes()
        {
            BTN_A.Click += AtribuirLetra;
            BTN_B.Click += AtribuirLetra;
            BTN_C.Click += AtribuirLetra;
            BTN_D.Click += AtribuirLetra;
            BTN_E.Click += AtribuirLetra;
            BTN_F.Click += AtribuirLetra;
            BTN_G.Click += AtribuirLetra;
            BTN_H.Click += AtribuirLetra;
            BTN_I.Click += AtribuirLetra;
            BTN_J.Click += AtribuirLetra;
            BTN_K.Click += AtribuirLetra;
            BTN_L.Click += AtribuirLetra;
            BTN_M.Click += AtribuirLetra;
            BTN_N.Click += AtribuirLetra;
            BTN_O.Click += AtribuirLetra;
            BTN_P.Click += AtribuirLetra;
            BTN_Q.Click += AtribuirLetra;
            BTN_R.Click += AtribuirLetra;
            BTN_S.Click += AtribuirLetra;
            BTN_T.Click += AtribuirLetra;
            BTN_U.Click += AtribuirLetra;
            BTN_V.Click += AtribuirLetra;
            BTN_W.Click += AtribuirLetra;
            BTN_X.Click += AtribuirLetra;
            BTN_Y.Click += AtribuirLetra;
            BTN_Z.Click += AtribuirLetra;
        }
        private void AtribuirLetra(object? sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;

            TXT_OBTER_PA.Text += botaoClicado.Text;
        }
        private char ObterPalpite()
        {
            try
            {
                palpite = Convert.ToChar(TXT_OBTER_PA.Text.ToUpper());
            }
            catch (FormatException)
            {
                MessageBox.Show("Deve ser informado apenas uma letra..", "LETRA INVÁLIDA");
                return '?';
            }
            return palpite;
        }
        void DesenharForca(int quantidadeErros)
        {
            if (quantidadeErros == 1)
            {
                pbox_Forca.Image = Resources._2;
            }
            if (quantidadeErros == 2)
            {
                pbox_Forca.Image = Resources._3;
            }
            if (quantidadeErros == 3)
            {
                pbox_Forca.Image = Resources._5;
            }
            if (quantidadeErros == 4)
            {
                pbox_Forca.Image = Resources._8;
            }
            if (quantidadeErros == 5)
            {
                pbox_Forca.Image = Resources._8;
            }

        }

        private void RodaOJogo()
        {
            palpite = ObterPalpite();
            if (palpite != charComErro)
            {
                if (jogo.JogadorAcertou(palpite) || jogo.JogadorPerdeu())
                {
                    LBL_PALAVRAPARCIAL.Text = jogo.PalavraParcial;
                    return;

                }
                LBL_PALAVRAPARCIAL.Text = jogo.PalavraParcial;
                DesenharForca(jogo.Erros);
                TXT_OBTER_PA.Text = "";
            }
        }

        private void BTN_CHUTAR_Click(object sender, EventArgs e)
        {
            RodaOJogo();
        }
    }
}