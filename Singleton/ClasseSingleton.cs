using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class ClasseSingleton
    {
        static ClasseSingleton _instancia;

        public static ClasseSingleton Instancia
        {
            get { return _instancia ?? (_instancia = new ClasseSingleton());}
        }

        private ClasseSingleton()
        {

        }
        public string Mensagem { get; set; }
    }
}
