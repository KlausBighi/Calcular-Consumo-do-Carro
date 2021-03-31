using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_Consumo_do_Carro
{
    public partial class CalcularConsumo : Form
    {
        public CalcularConsumo()
        {
            InitializeComponent();
        }

        //Método Validar Decimal
        private decimal ValidarDecimal(TextBox txt)
        {
            try
            {
                return Convert.ToDecimal(txt.Text);
            }
            catch
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Preencha Corretamente o Campo" + txt.Name.ToUpper().Replace("TEXTBOX", ""));
            }
        }

        //Método Limpar Tela
        private void LimparTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
                else if (ctl is Label && Convert.ToInt32(ctl.Tag).Equals(1))
                {
                    ctl.Text = string.Empty;
                }
            }
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            rendimentoLabel.ResetText();
             consumoLabel.ResetText();
             try
             {
                 decimal km = ValidarDecimal(kmTextBox);
                 decimal litros = ValidarDecimal(litrosTextBox);
                 decimal rendimento = km / litros;
                 decimal consumo = litros / km;
                 rendimentoLabel.Text = rendimento.ToString("N1");
                 consumoLabel.Text = consumo.ToString("N3");
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Alerta de Erro",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

        private void CalcularConsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //Propriedade KeyPreview deve ser true
                if (e.KeyChar == 27)
                {
                    LimparTela();
                    kmTextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
