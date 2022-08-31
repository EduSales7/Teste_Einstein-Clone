using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tela_inicial_testeEinsten
{
    public partial class Form1 : Form
    {
        //Variaveis Globais
        int minuto = 9;
        int segundo = 59;

        int contErros = 0;
        int contAcertos = 0;

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Leia as instruções antes de iniciar o jogo!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Botão fechar
        private void btnFecharFacil_Click(object sender, EventArgs e)
        {
            DialogResult resposta = new DialogResult();

            resposta = MessageBox.Show("Tem certeza que quer fechar o jogo?\nAs respostas já preenchidas serão perdidas!", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (resposta == DialogResult.Yes)
            {
                this.Close();

            }
        }

        //Habilitar Jogo
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pnlComboBox.Visible = true;
        }

        //Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (minuto == 0 && segundo == 0)
            {
                timer1.Enabled = false;
                DialogResult resultado = MessageBox.Show("Deseja jogar novamente?", "Fim de jogo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.Yes)
                {
                }
                else
                {
                    Application.Exit();
                }
            }
            else if (segundo == 0)
            {
                minuto -= 1;
                segundo = 59;
            }
            else
            {
                segundo -= 1;
            }
            lblTimer.Text = Convert.ToString(minuto) + ":" + Convert.ToString(segundo);
        }



        //Mudar cor do Panel
        private void cmb1Caixa2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb1Caixa2.Text == "Amarela")
            {
                pnlCaixa2.BackColor = Color.Yellow;

            }
            else if (cmb1Caixa2.Text == "Azul")
            {
                pnlCaixa2.BackColor = Color.Blue;
                ContadorErros();
            }
            else if (cmb1Caixa2.Text == "Branca")
            {
                pnlCaixa2.BackColor = Color.White;
                ContadorErros();
            }
            else if (cmb1Caixa2.Text == "Verde")
            {
                pnlCaixa2.BackColor = Color.DarkGreen;
                ContadorErros();
            }
            else if (cmb1Caixa2.Text == "Vermelha")
            {
                pnlCaixa2.BackColor = Color.Red;
                ContadorErros();
            }

            if (cmb2Caixa1.Text != "" && cmb1Caixa2.Text != "")
            {

                if (cmb2Caixa1.Text == "Juliana" && cmb1Caixa2.Text == "Amarela")
                {
                    lblDicaFacil17.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();

                }
                else
                {
                    lblDicaFacil17.ForeColor = Color.Red;
                    ContadorErros();
                }
            }
        }

        private void cmb1Caixa1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb1Caixa1.Text == "Amarela")
            {
                pnlCaixa1.BackColor = Color.Yellow;
                ContadorErros();

            }
            else if (cmb1Caixa1.Text == "Azul")
            {
                pnlCaixa1.BackColor = Color.Blue;
                ContadorErros();
            }
            else if (cmb1Caixa1.Text == "Branca")
            {
                pnlCaixa1.BackColor = Color.White;
                ContadorErros();
            }
            else if (cmb1Caixa1.Text == "Verde")
            {
                pnlCaixa1.BackColor = Color.DarkGreen;
            }
            else if (cmb1Caixa1.Text == "Vermelha")
            {
                pnlCaixa1.BackColor = Color.Red;
                ContadorErros();
            }

            if (cmb1Caixa1.Text != "" && cmb1Caixa3.Text != "")
            {

                if (cmb1Caixa1.Text == "Verde" && cmb1Caixa3.Text == "Azul")
                {
                    lblDicaFacil13.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil13.ForeColor = Color.Red;
                    ContadorErros();
                }
            }

        }

        private void cmb1Caixa3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb1Caixa3.Text == "Amarela")
            {
                pnlCaixa3.BackColor = Color.Yellow;
                ContadorErros();

            }
            else if (cmb1Caixa3.Text == "Azul")
            {
                pnlCaixa3.BackColor = Color.Blue;
            }
            else if (cmb1Caixa3.Text == "Branca")
            {
                pnlCaixa3.BackColor = Color.White;
                ContadorErros();
            }
            else if (cmb1Caixa3.Text == "Verde")
            {
                pnlCaixa3.BackColor = Color.DarkGreen;
                ContadorErros();
            }
            else if (cmb1Caixa3.Text == "Vermelha")
            {
                pnlCaixa3.BackColor = Color.Red;
                ContadorErros();
            }

            if (cmb1Caixa3.Text != "" && cmb5Caixa5.Text != "")
            {

                if (cmb1Caixa3.Text == "Azul" && cmb5Caixa5.Text == "filho")
                {
                    lblDicaFacil2.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil2.ForeColor = Color.Red;
                    ContadorErros();
                }
            }

            if (cmb1Caixa1.Text != "" && cmb1Caixa3.Text != "")
            {

                if (cmb1Caixa1.Text == "Verde" && cmb1Caixa3.Text == "Azul")
                {
                    lblDicaFacil13.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil13.ForeColor = Color.Red;
                    ContadorErros();
                }
            }
        }


        private void cmb1Caixa4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb1Caixa4.Text == "Amarela")
            {
                pnlCaixa4.BackColor = Color.Yellow;
                ContadorErros();

            }
            else if (cmb1Caixa4.Text == "Azul")
            {
                pnlCaixa4.BackColor = Color.Blue;
                ContadorErros();
            }
            else if (cmb1Caixa4.Text == "Branca")
            {
                pnlCaixa4.BackColor = Color.White;
            }
            else if (cmb1Caixa4.Text == "Verde")
            {
                pnlCaixa4.BackColor = Color.DarkGreen;
                ContadorErros();
            }
            else if (cmb1Caixa4.Text == "Vermelha")
            {
                pnlCaixa4.BackColor = Color.Red;
                ContadorErros();
            }

            if (cmb2Caixa4.Text != "" && cmb1Caixa4.Text != "")
            {

                if (cmb2Caixa4.Text == "Fernanda" && cmb1Caixa4.Text == "Branca")
                {
                    lblDicaFacil12.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil12.ForeColor = Color.Red;
                    ContadorErros();
                }
            }

            if (cmb1Caixa4.Text != "" && cmb3Caixa4.Text != "")
            {

                if (cmb1Caixa4.Text == "Branca" && cmb3Caixa4.Text == "presunto")
                {
                    lblDicaFacil18.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();

                }
                else
                {
                    lblDicaFacil18.ForeColor = Color.Red;
                    ContadorErros();
                }
            }
        }

        private void cmb1Caixa5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb1Caixa5.Text == "Amarela")
            {
                pnlCaixa5.BackColor = Color.Yellow;
                ContadorErros();

            }
            else if (cmb1Caixa5.Text == "Azul")
            {
                pnlCaixa5.BackColor = Color.Blue;
                ContadorErros();
            }
            else if (cmb1Caixa5.Text == "Branca")
            {
                pnlCaixa5.BackColor = Color.White;
                ContadorErros();
            }
            else if (cmb1Caixa5.Text == "Verde")
            {
                pnlCaixa5.BackColor = Color.DarkGreen;
                ContadorErros();
            }
            else if (cmb1Caixa5.Text == "Vermelha")
            {
                pnlCaixa5.BackColor = Color.Red;
            }

            if (cmb1Caixa5.Text != "" && cmb5Caixa5.Text != "")
            {

                if (cmb1Caixa5.Text == "Vermelha" && cmb5Caixa5.Text == "filho")
                {
                    lblDicaFacil19.ForeColor = Color.Green;
                    ContadorAcertos();
                    contAcertos += 1;
                }
                else
                {
                    lblDicaFacil19.ForeColor = Color.Red;
                    ContadorErros();
                }
            }

        }

        //função contador de erros

        public void ContadorErros()
        {

            contErros += 1;

            if (contErros == 30)
            {

                MessageBox.Show("Não dessa vez! :( Você atingiu a quantidade erros permitidos!\nE será redirecionado para a tela inicial!", "Fim de Jogo!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Close();

            }
            else
            {
                lblContErros.Text = Convert.ToString(contErros);

            }
        }

        //contador de acertoverificar acertos
        public void ContadorAcertos()
        {
            
            if (contAcertos == 22)
            {

                MessageBox.Show("Você ganhou!!!\n Einstein está orgulho do seu resultado!", "EUREKA!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }


        }

        //verificar dicas (verde e vermelha)
        private void cmb3Caixa3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb3Caixa3.Text != "" && cmb5Caixa4.Text != "")
            {

                if (cmb3Caixa3.Text == "pão" && cmb5Caixa4.Text == "irmã")
                {
                    lblDicaFacil1.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil1.ForeColor = Color.Red;
                    ContadorErros();
                }
            }

            if (cmb5Caixa2.Text != "" && cmb3Caixa3.Text != "")
            {

                if (cmb5Caixa2.Text == "marido" && cmb3Caixa3.Text == "pão")
                {
                    lblDicaFacil7.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil7.ForeColor = Color.Red;
                    ContadorErros();
                }
            }
        }

        private void cmb5Caixa4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb3Caixa3.Text != "" && cmb5Caixa4.Text != "")
            {

                if (cmb3Caixa3.Text == "pão" && cmb5Caixa4.Text == "irmã")
                {
                    lblDicaFacil1.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil1.ForeColor = Color.Red;
                    ContadorErros();
                }
            }
        }

        private void cmb5Caixa5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb1Caixa3.Text != "" && cmb5Caixa5.Text != "")
            {

                if (cmb1Caixa3.Text == "Azul" && cmb5Caixa5.Text == "filho")
                {
                    lblDicaFacil2.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil2.ForeColor = Color.Red;
                    ContadorErros();
                }
            }

            if (cmb1Caixa5.Text != "" && cmb5Caixa5.Text != "")
            {

                if (cmb1Caixa5.Text == "Vermelha" && cmb5Caixa5.Text == "filho")
                {
                    lblDicaFacil19.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil19.ForeColor = Color.Red;
                    ContadorErros();
                }
            }
        }

        private void cmb4Caixa2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb4Caixa2.Text != "" && cmb5Caixa2.Text != "")
            {

                if (cmb4Caixa2.Text == "vale" && cmb5Caixa2.Text == "marido")
                {
                    lblDicaFacil3.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil3.ForeColor = Color.Red;
                    ContadorErros();
                }
            }
        }

        private void cmb5Caixa2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb4Caixa2.Text != "" && cmb5Caixa2.Text != "")
            {

                if (cmb4Caixa2.Text == "vale" && cmb5Caixa2.Text == "marido")
                {
                    lblDicaFacil3.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil3.ForeColor = Color.Red;
                    ContadorErros();
                }
            }

            if (cmb5Caixa2.Text != "" && cmb3Caixa3.Text != "")
            {

                if (cmb5Caixa2.Text == "marido" && cmb3Caixa3.Text == "pão")
                {
                    lblDicaFacil7.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil7.ForeColor = Color.Red;
                    ContadorErros();
                }
            }

            if (cmb2Caixa2.Text != "" && cmb5Caixa2.Text != "")
            {

                if (cmb2Caixa2.Text == "Aline" && cmb5Caixa2.Text == "marido")
                {
                    lblDicaFacil14.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil14.ForeColor = Color.Red;
                    ContadorErros();
                }
            }

            if (cmb2Caixa3.Text != "" && cmb5Caixa2.Text != "")
            {

                if (cmb2Caixa3.Text == "Carol" && cmb5Caixa2.Text == "marido")
                {
                    lblDicaFacil15.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil15.ForeColor = Color.Red;
                    ContadorErros();
                }
            }
        }

        private void cmb5Caixa1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb5Caixa1.Text != "")
            {

                if (cmb5Caixa1.Text == "namorado")
                {
                    lblDicaFacil4.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil4.ForeColor = Color.Red;
                    ContadorErros();
                }
            }
        }


        private void cmb4Caixa4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb4Caixa4.Text != "")
            {

                if (cmb4Caixa4.Text == "crédito")
                {
                    lblDicaFacil5.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil5.ForeColor = Color.Red;
                    ContadorErros();
                }
            }

            if (cmb4Caixa4.Text != "" && cmb3Caixa4.Text != "")
            {

                if (cmb4Caixa4.Text == "crédito" && cmb3Caixa4.Text == "presunto")
                {
                    lblDicaFacil9.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil9.ForeColor = Color.Red;
                    ContadorErros();
                }
            }
        }

        private void cmb4Caixa5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb4Caixa5.Text != "")
            {

                if (cmb4Caixa5.Text == "dinheiro")
                {
                    lblDicaFacil6.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil6.ForeColor = Color.Red;
                    ContadorErros();
                }
            }

            if (cmb3Caixa5.Text != "" && cmb4Caixa5.Text != "")
            {

                if (cmb3Caixa5.Text == "leite" && cmb4Caixa5.Text == "dinheiro")
                {
                    lblDicaFacil10.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil10.ForeColor = Color.Red;
                    ContadorErros();
                }
            }
        }

        private void cmb4Caixa1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb4Caixa1.Text != "")
            {

                if (cmb4Caixa1.Text == "cheque")
                {
                    lblDicaFacil8.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil8.ForeColor = Color.Red;
                    ContadorErros();

                }
            }
        }

        private void cmb3Caixa4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb4Caixa4.Text != "" && cmb3Caixa4.Text != "")
            {

                if (cmb4Caixa4.Text == "crédito" && cmb3Caixa4.Text == "presunto")
                {
                    lblDicaFacil9.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil9.ForeColor = Color.Red;
                    ContadorErros();
                }
            }

            if (cmb1Caixa4.Text != "" && cmb3Caixa4.Text != "")
            {

                if (cmb1Caixa4.Text == "Branca" && cmb3Caixa4.Text == "presunto")
                {
                    lblDicaFacil18.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil18.ForeColor = Color.Red;
                    ContadorErros();
                }
            }
        }

        private void cmb3Caixa5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb3Caixa5.Text != "" && cmb4Caixa5.Text != "")
            {

                if (cmb3Caixa5.Text == "leite" && cmb4Caixa5.Text == "dinheiro")
                {
                    lblDicaFacil10.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil10.ForeColor = Color.Red;
                    ContadorErros();
                }
            }
        }

        private void cmb3Caixa1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb3Caixa1.Text != "")
            {

                if (cmb3Caixa1.Text == "amaciante")
                {
                    lblDicaFacil11.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil11.ForeColor = Color.Red;
                    ContadorErros();
                }
            }
        }

        private void cmb2Caixa4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb2Caixa4.Text != "" && cmb1Caixa4.Text != "")
            {

                if (cmb2Caixa4.Text == "Fernanda" && cmb1Caixa4.Text == "Branca")
                {
                    lblDicaFacil12.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil12.ForeColor = Color.Red;
                    ContadorErros();
                }
            }
        }

        private void cmb2Caixa2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb2Caixa2.Text != "" && cmb5Caixa2.Text != "")
            {

                if (cmb2Caixa2.Text == "Aline" && cmb5Caixa2.Text == "marido")
                {
                    lblDicaFacil14.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil14.ForeColor = Color.Red;
                    ContadorErros();
                }
            }
        }

        private void cmb2Caixa3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb2Caixa3.Text != "" && cmb5Caixa2.Text != "")
            {

                if (cmb2Caixa3.Text == "Carol" && cmb5Caixa2.Text == "marido")
                {
                    lblDicaFacil15.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil15.ForeColor = Color.Red;
                    ContadorErros();
                }
            }
        }

        private void cmb2Caixa5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb2Caixa5.Text != "")
            {

                if (cmb2Caixa5.Text == "Natalia")
                {
                    lblDicaFacil16.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil16.ForeColor = Color.Red;
                    ContadorErros();
                }
            }
        }

        private void cmb2Caixa1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb2Caixa1.Text != "" && cmb1Caixa2.Text != "")
            {

                if (cmb2Caixa1.Text == "Juliana" && cmb1Caixa2.Text == "Amarela")
                {
                    lblDicaFacil17.ForeColor = Color.Green;
                    contAcertos += 1;
                    ContadorAcertos();
                }
                else
                {
                    lblDicaFacil17.ForeColor = Color.Red;
                    ContadorErros();
                }
            }
        }

        private void cmb3Caixa2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb3Caixa2.Text == "frutas")
            {
                contAcertos += 1;
                ContadorAcertos();
            }
            else
            {
                ContadorErros();
            }
         
        }

        private void cmb4Caixa3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb4Caixa3.Text == "débito")
            {
                contAcertos += 1;
                ContadorAcertos();
            }
            else
            {
                ContadorErros();
            }
        }

        private void cmb5Caixa3_SelectedIndexChanged(object sender, EventArgs e)
        {

                if (cmb5Caixa3.Text == "mãe")
                {
                contAcertos += 1;
                ContadorAcertos();
                }
                else
                {
                ContadorErros();
                }
        }

        private void pnlCronometro_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
    

