using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContadorDeDiasHSY
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

        }

        private void Principal_Load(object sender, EventArgs e)
        {
        
            BoxBarras.Items.Add("Barra CNC 20g");
            BoxBarras.Items.Add("Barra CNC 40g");
            BoxBarras.Items.Add("Barra CNC 87g");
            BoxBarras.Items.Add("Barra Dark 73% 85g");
            BoxBarras.Items.Add("Barra Dark Caramelo 17g");
            BoxBarras.Items.Add("Barra Dark Caramelo 85g");
            BoxBarras.Items.Add("Barra Dark Cranberry 20g");
            BoxBarras.Items.Add("Barra Dark Cranberry 85g");
            BoxBarras.Items.Add("Barra Dark Laranja 85g");
            BoxBarras.Items.Add("Barra Ovomaltine 20g");
            BoxBarras.Items.Add("Barra Ovomaltine 87g");
        }

        public void Calcular()
        {
            try
            {
                double formas = 0;
                double kilos = 0;
                double porcentagem = 0;
                double produzido = 0;
                
                formas = Convert.ToDouble(BoxFormas.Text);
                kilos = Convert.ToDouble(BoxKilos.Text);
                
				//Barras 17g
                if (BoxBarras.SelectedIndex == 4)
                {
                    produzido = (formas * 22 * 17 / 1000);
                    porcentagem = ((kilos / produzido) * 100);
                }
				
                //Barras 20g
                if (BoxBarras.SelectedIndex == 0 | BoxBarras.SelectedIndex == 6 | BoxBarras.SelectedIndex == 9)
                {
                    produzido = (formas * 22 * 20 / 1000);
                    porcentagem = ((kilos / produzido) * 100);
                }

                //Barras 40g
                if (BoxBarras.SelectedIndex == 1)
                {
                    produzido = (formas * 18 * 40 / 1000);
                    porcentagem = ((kilos / produzido) * 100);
                }

                //Barras 87g
                if (BoxBarras.SelectedIndex == 2 | BoxBarras.SelectedIndex == 10)
                {
                    produzido = (formas * 6 * 87 / 1000);
                    porcentagem = ((kilos / produzido) * 100);
                }

                //Barras 85g
                if (BoxBarras.SelectedIndex == 3 | BoxBarras.SelectedIndex == 5 | BoxBarras.SelectedIndex == 7 | BoxBarras.SelectedIndex == 8)
                {
                    produzido = (formas * 14 * 85 / 1000);
                    porcentagem = ((kilos / produzido) * 100);
                }
                
                BoxAgregado.Text = Math.Round(porcentagem, 2).ToString() + "%";
                BoxProduzido.Text = produzido.ToString();

                    switch (BoxBarras.SelectedIndex)
                    {
                        //Barra CNC 20g
                        case 0:
                            if (Math.Round(porcentagem, 2) >= 11 && Math.Round(porcentagem, 2) <= 13)
                            {
                                BoxAgregado.BackColor = Color.Green;
                            }
                            else
                            {
                                BoxAgregado.BackColor = Color.Red;
                            }
                            break;
                        //Barra CNC 40g
                        case 1:
                            if (Math.Round(porcentagem, 2) >= 11 && Math.Round(porcentagem, 2) <= 13)
                            {
                                BoxAgregado.BackColor = Color.Green;
                            }
                            else
                            {
                                BoxAgregado.BackColor = Color.Red;
                            }
                            break;
                        //Barra CNC 87g
                        case 2:
                            if (Math.Round(porcentagem, 2) >= 11 && Math.Round(porcentagem, 2) <= 13)
                            {
                                BoxAgregado.BackColor = Color.Green;
                            }
                            else
                            {
                                BoxAgregado.BackColor = Color.Red;
                            }
                            break;
                        //Barra Dark 77% 85g
                        case 3:
                            if (Math.Round(porcentagem, 2) >= 9 && Math.Round(porcentagem, 2) <= 11)
                            {
                                BoxAgregado.BackColor = Color.Green;
                            }
                            else
                            {
                                BoxAgregado.BackColor = Color.Red;
                            }
                            break;
                        //Barra Dark Caramelo 17g
                        case 4:
                             if (Math.Round(porcentagem, 2) >= 9 && Math.Round(porcentagem, 2) <= 11)
                             {
                                BoxAgregado.BackColor = Color.Green;
                             }
                             else
                             {
                                BoxAgregado.BackColor = Color.Red;
                             }
                             break;
                        //Barra Dark Caramelo 85g
                        case 5:
                            if (Math.Round(porcentagem, 2) >= 9 && Math.Round(porcentagem, 2) <= 11)
                            {
                                BoxAgregado.BackColor = Color.Green;
                            }
                            else
                            {
                                BoxAgregado.BackColor = Color.Red;
                            }
                            break;							
                        //Barra Dark Cranberry 20g
                        case 6:
                            if (Math.Round(porcentagem, 2) >= 5 && Math.Round(porcentagem, 2) <= 7)
                            {
                                BoxAgregado.BackColor = Color.Green;
                            }
                            else
                            {
                                BoxAgregado.BackColor = Color.Red;
                            }
                            break;
                        //Barra Dark Cranberry 85g
                        case 7:
                            if (Math.Round(porcentagem, 2) >= 7 && Math.Round(porcentagem, 2) <= 9)
                            {
                                BoxAgregado.BackColor = Color.Green;
                            }
                            else
                            {
                                BoxAgregado.BackColor = Color.Red;
                            }
                            break;
                        //Barra Dark Laranja 85g
                        case 8:
                            if (Math.Round(porcentagem, 2) >= 5 && Math.Round(porcentagem, 2) <= 7)
                            {
                                BoxAgregado.BackColor = Color.Green;
                            }
                            else
                            {
                                BoxAgregado.BackColor = Color.Red;
                            }
                            break;
                        //Barra Ovomaltine 20g
                        case 9:
                            if (Math.Round(porcentagem, 2) >= 9 && Math.Round(porcentagem, 2) <= 11)
                            {
                                BoxAgregado.BackColor = Color.Green;
                            }
                            else
                            {
                                BoxAgregado.BackColor = Color.Red;
                            }
                            break;
                        //Barra Ovomaltine 87g
                        case 10:
                            if (Math.Round(porcentagem, 2) >= 9 && Math.Round(porcentagem, 2) <= 11)
                            {
                                BoxAgregado.BackColor = Color.Green;
                            }
                            else
                            {
                                BoxAgregado.BackColor = Color.Red;
                            }
                            break;
                    }
                }
                                 
            catch (FormatException)
            {
                if (String.IsNullOrEmpty(Convert.ToString(BoxBarras.Text)))
                {
                MessageBox.Show("Selecione a Barra Produzida.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (String.IsNullOrEmpty(Convert.ToString(BoxKilos.Text)))
                {
                    MessageBox.Show("Preencha o campo Agregado (Kg/H).", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (String.IsNullOrEmpty(Convert.ToString(BoxFormas.Text)))
                {
                    MessageBox.Show("Preencha o campo Número de Formas.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Digite apenas números.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        public void Limpar()
        {
            BoxBarras.SelectedIndex = -1;
            BoxKilos.Text = "";
            BoxFormas.Text = "";
            BoxAgregado.Text = "";
            BoxProduzido.Text = "";
            BoxAgregado.BackColor = Color.Empty;
            BackgroundImage = ControleDeAgregadoB1.Properties.Resources.Logo_B1;
        }


        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Limpar();
        }

        private void BoxKilos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Calcular();
            }
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == '.') && !(e.KeyChar == ','))
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas números.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BoxCiclos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Calcular();
            }
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Enter))
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas números", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BoxBarras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BoxBarras.SelectedIndex == 0 || BoxBarras.SelectedIndex == 1 || BoxBarras.SelectedIndex == 2)
            {
                BackgroundImage = global::ControleDeAgregadoB1.Properties.Resources.Logo_Cookies;
            }

            if (BoxBarras.SelectedIndex == 3)
            {
                BackgroundImage = global::ControleDeAgregadoB1.Properties.Resources.Logo_Cafe;
            }

            if (BoxBarras.SelectedIndex == 4 || BoxBarras.SelectedIndex == 5)
            {
                BackgroundImage = global::ControleDeAgregadoB1.Properties.Resources.Logo_Caramelo;
            }
			
            if (BoxBarras.SelectedIndex == 6 || BoxBarras.SelectedIndex == 7)
            {
                BackgroundImage = global::ControleDeAgregadoB1.Properties.Resources.Logo_Cranberry;
            }

            if (BoxBarras.SelectedIndex == 8)
            {
                BackgroundImage = global::ControleDeAgregadoB1.Properties.Resources.Logo_Laranja;
            }
            if (BoxBarras.SelectedIndex == 9 || BoxBarras.SelectedIndex == 10)
            {
                BackgroundImage = global::ControleDeAgregadoB1.Properties.Resources.Logo_Ovomaltine;
            }
        }

    }

}