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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.tableDataGridView.SolucionDataGridView();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco_De_DadosDataSet);
            MessageBox.Show("Dados Foram Salvos Com Sucesso");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco_De_DadosDataSet.Table'. Você pode movê-la ou removê-la conforme necessário.
            this.tableTableAdapter.Fill(this.banco_De_DadosDataSet.Table);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fotoPictureBox.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = ("");
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dados Excluídos Com Sucesso!");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form2 window = new Form2();
            window.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 search = new Form3();
            search.Show();
        }

        private void fotoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
    public static class Extensions
    {
        public static void SolucionDataGridView(this DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                int colw = dataGridView.Columns[i].Width;
                if (dataGridView.Columns[i].ValueType == typeof(Decimal))
                {
                    dataGridView.Columns[i].DefaultCellStyle.Format = "N2";
                }
                dataGridView.Columns[i].Width = colw;
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
