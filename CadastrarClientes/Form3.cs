using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_De_Clientes
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco_De_DadosDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco_De_DadosDataSet.Table'. Você pode movê-la ou removê-la conforme necessário.
            this.tableTableAdapter.Fill(this.banco_De_DadosDataSet.Table);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tableTableAdapter.Fill(this.banco_De_DadosDataSet.Table);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.tableTableAdapter.FillByNome(this.banco_De_DadosDataSet.Table, "%" + textBox1.Text + "%");
        }
    }
}
