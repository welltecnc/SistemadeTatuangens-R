using System.Linq.Expressions;

namespace Tatuagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try {
            //INSTANCIAR A CLASSE DO OBJETO
            Agendamento tatto = new Agendamento();

            tatto.NomeCliente = txtNomeCliente.Text;
            tatto.ParteCorpo = txtParteCorpo.Text;
            tatto.Tamanho = Convert.ToDouble(txtTamanho.Text);
            tatto.PrimeiraTatuagem = chkPrimeiraTatuagem.Checked;

            bool agendamentoValido = tatto.validarAgendamento();

            if (!agendamentoValido)
            {
                MessageBox.Show("O Tamanho dever ser maior que 3cm e nome deve ser preenchido",
                        "Dados Inválidos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                return;
            }

            double valorBase = tatto.CalcularValorBase();
            double valorFinal = tatto.CalcularValorFinal();

            lblValorbase.Text = $"R$ {valorBase:N2}";
            lblValorFinal.Text = $"R$ {valorFinal:N2}";

                lblStatus.Text = $"Cliente: {tatto.NomeCliente}  | Local: {tatto.ParteCorpo}\n ORÇAMENTO APROVADO COM SUCESSO";
                lblStatus.ForeColor = Color.Blue;


                txtNomeCliente.Clear();
                txtParteCorpo.Clear();
                txtTamanho.Clear();

            }catch (FormatException)
            {
                MessageBox.Show("Atenção, Preencha os campos Numéricos",
                           "Erro de formato",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Warning
                );
            }

        }

     }
 }
