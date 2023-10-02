using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtendimento
{
    internal class Guiche
    {
        private int id;
        private Queue<Senha> atendimentos;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Queue<Senha> Atendimentos
        {
            get { return atendimentos; }
            set { atendimentos = value; }
        }

        public Guiche()
        {
            atendimentos = new Queue<Senha>();
            id = 0;
        }

        public Guiche(int id)
        {
            atendimentos = new Queue<Senha>();
            this.id = id;
        }

        public bool chamar(Queue<Senha> filasenhas)
        {
            if (filasenhas.Count == 0) return false;

            Senha atendida = filasenhas.Dequeue();

            DateTime agora = DateTime.Now;
            atendida.DataAtend = agora;
            atendida.HoraAtend = agora;

            atendimentos.Enqueue(atendida);
            return true;
        }
    }
}
