using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtendimento
{
    public partial class Form1 : Form
    {
        int prox = 1;
        BindingSource bsAtender, bsAtendidas;

        Senhas fila = new Senhas();
        Guiches atend = new Guiches();
        public Form1()
        {
            InitializeComponent();
        }

        private void gerarSenha_Click(object sender, EventArgs e)
        {
            fila.gerar();
        }

        public void atualizarSenhasAtender()
        {
            bsAtender = new BindingSource();
            bsAtender.DataSource = fila.getFilaSenhasAtender();
            listBoxAtender.DataSource = bsAtender;
        }

        private void listarSenhas_Click(object sender, EventArgs e)
        {
            atualizarSenhasAtender();
        }

        private void addGuiche_Click(object sender, EventArgs e)
        {
            atend.adicionar(new Guiche());

            int qtdGuiches = int.Parse(lblQtdGuiches.Text);
            qtdGuiches++;
            lblQtdGuiches.Text = "" + qtdGuiches;
        }

        private void chamarSenha_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtGuiche.Text);
            Guiche atender = atend.ListaGuiches.Find(f => f.Id == id);

            atender.chamar(fila.FilaSenhas);
        }

        public void atualizarSenhasAtendidas()
        {
            int id = int.Parse(txtGuiche.Text);
            bsAtendidas = new BindingSource();
            bsAtendidas.DataSource = atend.getFilaSenhasAtendidas(id);
            listBoxAtendidas.DataSource = bsAtendidas;
        }

        private void listarAtendimentos_Click(object sender, EventArgs e)
        {
            atualizarSenhasAtendidas();
        }

        private void txtGuiche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
