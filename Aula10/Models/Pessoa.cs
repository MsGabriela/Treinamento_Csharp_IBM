using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10.Models
{
    class Pessoa
    {
        static public int _counInstacias;
​
        private DateTime _nascimento;
​
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
​
        static public int CounInstacias
        {
            get { return _counInstacias; }
            set { _counInstacias = value; }
        }
​
        //protected int Idade { get; set; }
​
        internal protected int Idade;
​
​
​
        public int AnosCompletos
        {
            get
            {
                return (DateTime.Now.Year - _nascimento.Year);
            }
        }
​
        
        public DateTime Nascimento
        {
​
            set
            {
                this._nascimento = value;
            }
            get
            {
                return _nascimento;
            }
        }
​
​
​
        public Pessoa()
        {
            CounInstacias++;
        }

    }
}
