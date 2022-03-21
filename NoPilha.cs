using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreDeHanoi
{
    public class NoPilha
    {
        /// <summary>
        /// Informação a ser guardada
        /// </summary>
        public int Info { get; set; }

        /// <summary>
        /// Aponta para o próximo nó da pilha
        /// </summary>
        public NoPilha Proximo { get; set; }

        /// <summary>
        /// Construtora padrão
        /// </summary>
        public NoPilha()
        {
            Info = 0;
            Proximo = null;
        }

        /// <summary>
        /// Construtora
        /// </summary>
        /// <param name="info">Valor a ser empilhado</param>
        public NoPilha(int info)
        {
            Info = info;
            Proximo = null;
        }
    }
}
