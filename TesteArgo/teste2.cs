using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteArgo
{
    public class teste2
    {
        public List<int> CriarLista(int quantidade)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < quantidade; i++)
            {
                result.Add(i);
            }
            return result;
        }

        public List<int> OrdenarLista(params int[] valores)
        {
            return valores.OrderBy(o => o).ToList();
        }
    }
}
