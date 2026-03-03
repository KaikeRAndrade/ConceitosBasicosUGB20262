using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosPOO
{
    public class Agencia
    {
        private string _numero;
        private string _nome;
        private string _telefone;
        public string Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                if (value.Length != 0)
                    _numero = value;
                else
                    throw new Exception("O numero não pode estar vazio");
            }
        }
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value.Length != 0)
                    _nome = value;
                else
                    throw new Exception("Nome da agência não pode estar vazio");
            }
        }
        public string Telefone
        {
            get
            {
                return _telefone;
            }
            set
            {
                if (value.Length != 0)
                    _telefone = value;
                else
                    throw new Exception("O numero de telefone não pode estar vazio");
            }
        }
    }
}
