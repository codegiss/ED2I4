using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtendimento
{
    internal class Senhas
    {
        private int proximoAtendimento;
        private Queue<Senha> filaSenhas;

        public Queue<Senha> FilaSenhas
        {
            get { return filaSenhas; }
        }

        public Senhas()
        {
            filaSenhas = new Queue<Senha>();
            proximoAtendimento = 1;
        }

        public void gerar()
        {
            Senha novaSenha = new Senha(proximoAtendimento++);
            filaSenhas.Enqueue(novaSenha);
        }

        public Queue<string> getFilaSenhasAtender()
        {
            Queue<string> fila = new Queue<string>();

            foreach (Senha senha in filaSenhas)
            {
                fila.Enqueue(senha.dadosParciais());
            }

            return fila;
        }
    }
}
