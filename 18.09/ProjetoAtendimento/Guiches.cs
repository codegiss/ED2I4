using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtendimento
{
    internal class Guiches
    {
        private List<Guiche> listaGuiches;

        public List<Guiche> ListaGuiches
        {
            get { return listaGuiches; }
        }

        public Guiches()
        {
            listaGuiches = new List<Guiche>();
        }

        public void adicionar(Guiche guiche)
        {
            if(listaGuiches.Count == 0)
                listaGuiches.Add(guiche);
            else
            {
                Guiche novo = new Guiche(listaGuiches.Count);
                listaGuiches.Add(novo);
            }
        }
        public Queue<string> getFilaSenhasAtendidas(int id)
        {
            Queue<string> fila = new Queue<string>();
            Guiche g = listaGuiches.Find(e => e.Id == id);
            MessageBox.Show("" + g.Id);

            foreach (Senha senha in g.Atendimentos)
            {
                fila.Enqueue(senha.dadosCompletos());
            }

            return fila;
        }
    }
}
