using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteArgo.Models;

namespace TesteArgo
{
    /// <summary>
    /// Nessa classe deve ser feito o acesso a banco de dados SQL SERVER
    /// Dados de conexao do banco de dados
    /// host: den1.mssql6.gear.host
    /// base: testecore
    /// user:testecore
    /// senha : Dz2iI~!U1Edq
    /// 
    /// Tabela Destino
    /// 
    /// Colunas:
    /// DestinoId inteiro 
    /// Nome texto nulavel
    /// Dia data nulavel
    /// 
    /// </summary>
    public class teste4
    {
        List<Destino> destinos = new List<Destino>() {
            new Destino { DestinoId = 1, Nome="Destino A", Dia = new DateTime(2019,04,07) },
            new Destino { DestinoId = 2, Nome="Destino B", Dia = new DateTime(2019,04,08) },
            new Destino { DestinoId = 3, Nome="Destino C", Dia = new DateTime(2019,04,09) },
        };
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns></returns>
        public List<Destino> ListarDestino()
        {
            return destinos.ToList();
        }

        public Destino buscarPorId(int id)
        {
            return destinos.Where( o => o.DestinoId == id).FirstOrDefault();
        }
    }
}
