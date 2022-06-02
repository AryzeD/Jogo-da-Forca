using System;
using System.Drawing;

namespace Forca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] Tron = new string[] { "T", "R", "O", "N", "O", "L", "E", "G", "A", "D", "O" };
        string[] Kuwait = new string[] { "K", "U", "W", "A", "I", "T" };
        string[] Artur = new string[] { "A", "R", "T", "U", "R"};
        string[] Kyoto = new string[] { "K", "Y", "O", "T", "O" };
        string[] Emma = new string[] { "E", "M", "M", "A", "S", "T", "O", "N", "E" };

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            TronT.Visible = false;
            TronR.Visible = false;
            TronO.Visible = false;
            TronN.Visible = false;
            TronO2.Visible = false;
            TronL.Visible = false;
            TronE.Visible = false;
            TronG.Visible = false;
            TronA.Visible = false;
            TronD.Visible = false;
            TronO3.Visible = false;
            KwaitK.Visible = false;
            KwaitU.Visible = false;
            KwaitW.Visible = false;
            KwaitA.Visible = false;
            KwaitI.Visible = false;
            KwaitT.Visible = false;
            ArturA.Visible = false;
            ArturR.Visible = false;
            ArturT.Visible = false;
            ArturU.Visible = false;
            ArturR2.Visible = false;
            KyotoK.Visible = false;
            KyotoY.Visible = false;
            KyotoO.Visible = false;
            KyotoT.Visible = false;
            KyotoO2.Visible = false;
            EmmaE.Visible = false;
            EmmaM.Visible = false;
            EmmaM2.Visible = false;
            EmmaA.Visible = false;
            EmmaS.Visible = false;
            EmmaT.Visible = false;
            EmmaO.Visible = false;
            EmmaN.Visible = false;
            EmmaE2.Visible = false;
            switch (cmbBxCategoria.Text)
            {
                case "Filme":
                    TronT.Visible = true;
                    TronR.Visible = true;
                    TronO.Visible = true;
                    TronN.Visible = true;
                    TronO2.Visible = true;
                    TronL.Visible = true;
                    TronE.Visible = true;
                    TronG.Visible = true;
                    TronA.Visible = true;
                    TronD.Visible = true;
                    TronO3.Visible = true;
                    lblDica.Text = "A sua primeira versão foi lançada em 1982";
                    break;
                case "País":
                    KwaitK.Visible = true;
                    KwaitU.Visible = true;
                    KwaitW.Visible = true;
                    KwaitA.Visible = true;
                    KwaitI.Visible = true;
                    KwaitT.Visible = true;
                    lblDica.Text = "O petróleo e seus derivados constituem quase 85% das receitas de exportação";
                    break;
                case "Nome":
                    ArturA.Visible = true;
                    ArturR.Visible = true;
                    ArturT.Visible = true;
                    ArturU.Visible = true;
                    ArturR2.Visible = true;
                    lblDica.Text = "Um dos Antigos Reis da Britania";
                    break;
                case "Capital":
                    KyotoK.Visible = true;
                    KyotoY.Visible = true;
                    KyotoO.Visible = true;
                    KyotoT.Visible = true;
                    KyotoO2.Visible = true;
                    lblDica.Text = "É uma anagrama de sua antiga capital";
                    break;
                case "Celebridade":
                    EmmaE.Visible = true;
                    EmmaM.Visible = true;
                    EmmaM2.Visible = true;
                    EmmaA.Visible = true;
                    EmmaS.Visible = true;
                    EmmaT.Visible = true;
                    EmmaO.Visible = true;
                    EmmaN.Visible = true;
                    EmmaE2.Visible = true;
                    lblDica.Text = "Seu verdadeiro nome é Emily Jean";
                    break;
                default:
                    lblDica.Text = "Escolha uma Categoria antes de apertar o botão";
                    break;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}