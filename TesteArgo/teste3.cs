using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteArgo.Models;

namespace TesteArgo
{
    public class teste3
    {
        ///www.omdbapi.com/
        const string ApiKey = "18693fd6";
        List<Filme> filmes = new List<Filme>() {
            new Filme { Ano = 1980, ID = "tt0372784", Imagem="1.jpg", Titulo="Batman" },
            new Filme { Ano = 1981, ID = "tt0372785", Imagem="2.jpg", Titulo="Super Man" },
            new Filme { Ano = 1982, ID = "tt0372786", Imagem="3.jpg", Titulo="Spider Man" },
        };

        /// <summary>
        /// By Search
        /// www.omdbapi.com/?s=titulo&apikey=18693fd6
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns></returns>
        public List<Filme> ListarFilmes(string filtro)
        {
            return filmes.Where(o => o.Titulo.ToLower().Contains(filtro.ToLower())).ToList();
        }

        /// <summary>
        /// By ID or Title
        /// www.omdbapi.com/?i=tt0372784&apikey=18693fd6
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Filme ListarPorId(string id)
        {
            return filmes.Where(o => o.ID.ToLower() == id.ToLower()).FirstOrDefault();
        }
    }
}
