using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtendimento
{
    internal class Senha
    {

        private int id;

        private DateTime dataGerac;
        private DateTime horaGerac;
        private DateTime dataAtend;
        private DateTime horaAtend;

        public DateTime DataAtend
        {
            get { return dataAtend; }
            set { dataAtend = value; }
        }

        public DateTime HoraAtend
        {
            get { return horaAtend; }
            set { horaAtend = value; }
        }

        public Senha(int id)
        {
            this.id = id;
            dataGerac = DateTime.Today;
            horaGerac = DateTime.Now;
        }

        public string dadosParciais()
        {
            string data = dataGerac.ToString("dd/MM/yyyy");
            string hora = horaGerac.ToString("HH:mm:ss");

            return id + " - " +
                    data + " - " +
                    hora;
        }

        public string dadosCompletos()
        {
            string data = dataAtend.ToString("dd/MM/yyyy");
            string hora = horaAtend.ToString("HH:mm:ss");

            return dadosParciais() + " - " +
                    data + "/" + " - " +
                    hora;
        }
    }
}
