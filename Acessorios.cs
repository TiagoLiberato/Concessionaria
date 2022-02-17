using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro
{
    public class Acessorios
    {
        public static Volante Autoesporte(int Ano, string Nome, string Marca)
        {
            Volante volante = new Volante();
            volante.Ano = Ano;
            volante.Nome = Nome;
            volante.Marca = Marca;
            return volante;
        }
        public static List<Volante> ListCount(int Ano, string Nome, string Marca)
        {
            List<Volante> lista = new List<Volante>();
            Volante volante = new Volante();
            volante.Nome = Nome;
            volante.Marca = Marca;
            volante.Ano = Ano;
            lista.Add(volante);

            Volante volante1 = new Volante();
            volante1.Nome = "Opala";
            volante1.Marca = "Chevrolet";
            volante1.Ano = 1978;
            lista.Add(volante1);

            Volante volante2 = new Volante();
            volante2.Nome = "Palio";
            volante2.Ano = 2006;
            volante2.Marca = "Fiat";
            lista.Add(volante2);

            Volante volante3 = new Volante();
            volante3.Nome = "Escorte";
            volante3.Marca = "Ford";
            volante3.Ano= 1998;
            lista.Add(volante3);

            Volante volante4 = new Volante();
            volante4.Nome = "Fusion";
            volante4.Ano = 2010;
            volante4.Marca = "Ford";
            lista.Add(volante4);

            Volante volante5 = new Volante();
            volante5.Nome = "MErcedez";
            volante5.Marca = "Mercedez";
            volante5.Ano = 2022;
            lista.Add(volante5);

            return lista;

        }
    }
}
