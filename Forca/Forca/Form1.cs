using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnSubmit.Enabled = false;
        }

        string[] Tron = new string[] { "T", "R", "O", "N", "O", "L", "E", "G", "A", "D", "O" };
        string[] Kuwait = new string[] { "K", "U", "W", "A", "I", "T" };
        string[] Artur = new string[] { "A", "R", "T", "U", "R"};
        string[] Kyoto = new string[] { "K", "Y", "O", "T", "O" };
        string[] Emma = new string[] { "E", "M", "M", "A", "S", "T", "O", "N", "E" };
        int erros = 0;
        

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            erros = 0;
            pctBxCabeca.Visible = false;
            pctBoxTronco.Visible = false;
            pctBxBraco1.Visible = false;
            pctBxBraco2.Visible = false;
            pctBxPerna1.Visible = false;
            pctBxPerna2.Visible = false;
            //
            btnSubmit.Enabled = true;
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
            //
            TronT.Text = "_";
            TronR.Text = "_";
            TronO.Text = "_";
            TronN.Text = "_";
            TronO2.Text = "_";
            TronL.Text = "_";
            TronE.Text = "_";
            TronG.Text = "_";
            TronA.Text = "_";
            TronD.Text = "_";
            TronO3.Text = "_";
            KwaitK.Text = "_";
            KwaitU.Text = "_";
            KwaitW.Text = "_";
            KwaitA.Text = "_";
            KwaitI.Text = "_";
            KwaitT.Text = "_";
            ArturA.Text = "_";
            ArturR.Text = "_";
            ArturT.Text = "_";
            ArturU.Text = "_";
            ArturR2.Text = "_";
            KyotoK.Text = "_";
            KyotoY.Text = "_";
            KyotoO.Text = "_";
            KyotoT.Text = "_";
            KyotoO2.Text = "_";
            EmmaE.Text = "_";
            EmmaM.Text = "_";
            EmmaM2.Text = "_";
            EmmaA.Text = "_";
            EmmaS.Text = "_";
            EmmaT.Text = "_";
            EmmaO.Text = "_";
            EmmaN.Text = "_";
            EmmaE2.Text = "_";
            //
            pctBoxTronco.Visible = false;
            pctBxCabeca.Visible = false;
            pctBxBraco1.Visible = false;
            pctBxBraco2.Visible = false;
            pctBxPerna1.Visible = false;
            pctBxPerna2.Visible = false;
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
                    lblDica.Text = "O petróleo e seus derivados constituem quase 85% das receitas de exportação do mundo";
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
            if (cmbBxCategoria.Text == "Filme")
            {
                if (Tron.Contains(txtBxLetra.Text) == false)
                {
                    erros = erros + 1;
                }
                else if (Tron.Contains(txtBxLetra.Text) == true)
                {
                    if (txtBxLetra.Text == "T")
                        TronT.Text = "T";
                    else if (txtBxLetra.Text == "R")
                        TronR.Text = "R";
                    else if (txtBxLetra.Text == "O")
                    {
                        TronO.Text = "O";
                        TronO2.Text = "O";
                        TronO3.Text = "O";
                    }
                    else if (txtBxLetra.Text == "N")
                        TronN.Text = "N";
                    else if (txtBxLetra.Text == "L")
                        TronL.Text = "L";
                    else if (txtBxLetra.Text == "E")
                        TronE.Text = "E";
                    else if (txtBxLetra.Text == "G")
                        TronG.Text = "G";
                    else if (txtBxLetra.Text == "A")
                        TronA.Text = "A";
                    else if (txtBxLetra.Text == "D")
                        TronD.Text = "D";
                }
            }

            if (cmbBxCategoria.Text == "País")
            {
                if (Kuwait.Contains(txtBxLetra.Text) == false)
                {
                    erros = erros + 1;
                }
                else if (Kuwait.Contains(txtBxLetra.Text) == true)
                {
                    if (txtBxLetra.Text == "K")
                        KwaitK.Text = "K";
                    else if (txtBxLetra.Text == "U")
                        KwaitU.Text = "U";
                    else if (txtBxLetra.Text == "W")
                        KwaitW.Text = "W";
                    else if (txtBxLetra.Text == "A")
                        KwaitA.Text = "A";
                    else if (txtBxLetra.Text == "I")
                        KwaitI.Text = "I";
                    else if (txtBxLetra.Text == "T")
                        KwaitT.Text = "T";
                }
            }

            if (cmbBxCategoria.Text == "Nome")
            {
                if (Artur.Contains(txtBxLetra.Text) == false)
                {
                    erros = erros + 1;
                }
                else if (Artur.Contains(txtBxLetra.Text) == true)
                {
                    if (txtBxLetra.Text == "A")
                        ArturA.Text = "A";
                    else if (txtBxLetra.Text == "R")
                    {
                        ArturR.Text = "R";
                        ArturR2.Text = "R";
                    } 
                    else if (txtBxLetra.Text == "T") 
                        ArturT.Text = "T";
                    else if (txtBxLetra.Text == "U") 
                        ArturU.Text = "U";
                }
            }

            if (cmbBxCategoria.Text == "Capital")
            {
                if (Kyoto.Contains(txtBxLetra.Text) == false)
                {
                    erros = erros + 1;
                }
                else if (Kyoto.Contains(txtBxLetra.Text) == true)
                {
                    if (txtBxLetra.Text == "K")
                        KyotoK.Text = "K";
                    else if (txtBxLetra.Text == "Y")
                        KyotoY.Text = "Y";
                    else if (txtBxLetra.Text == "O")
                    {
                        KyotoO.Text = "O";
                        KyotoO2.Text = "O";
                    }
                    else if (txtBxLetra.Text == "T")
                        KyotoT.Text = "T";
                }
            }

            if (cmbBxCategoria.Text == "Celebridade" )
            {
                if (Emma.Contains(txtBxLetra.Text) == false)
                {
                    erros = erros + 1;
                }
                else if (Emma.Contains(txtBxLetra.Text) == true)
                {
                    if (txtBxLetra.Text == "E")
                    {
                        EmmaE.Text = "E";
                        EmmaE2.Text = "E";
                    }
                    else if (txtBxLetra.Text == "M")
                    {
                        EmmaM.Text = "M";
                        EmmaM2.Text = "M";
                    }
                    else if (txtBxLetra.Text == "A")
                        EmmaA.Text = "A";
                    else if (txtBxLetra.Text == "S")
                        EmmaS.Text = "S";
                    else if (txtBxLetra.Text == "T")
                        EmmaT.Text = "T";
                    else if (txtBxLetra.Text == "O")
                        EmmaO.Text = "O";
                    else if (txtBxLetra.Text == "N")
                        EmmaN.Text = "N";
                }
            }

            switch (erros)
            {
                case 1:
                    pctBxCabeca.Visible = true;
                    break;
                case 2:
                    pctBoxTronco.Visible = true;
                    break;
                case 3:
                    pctBxBraco1.Visible = true;
                    break;
                case 4:
                    pctBxBraco2.Visible = true;
                    break;
                case 5:
                    pctBxPerna1.Visible = true;
                    break;
                case 6:
                    pctBxPerna2.Visible = true;
                    lblDica.Text = "Você Perdeu";
                    btnSubmit.Enabled = false;
                    break;
            }
        }
    }
}