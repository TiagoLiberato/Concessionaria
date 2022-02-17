using System;
using Carro;


namespace carro
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========Carros Do Ano=================== ");
            Volante Prisma = Acessorios.Autoesporte(2005, "Apollo", "Ford");
            Console.WriteLine("Seu carro é:" + Prisma.Nome);
            Console.WriteLine("Sua Marca é:" + Prisma.Marca);
            Console.WriteLine("Seu Ano é:" + Prisma.Ano);

            Console.WriteLine("=============Proximos Carros================");
            List<Volante> lista=Acessorios.ListCount(2005,"Veloster","Hyunday");



            foreach (Volante ListCount in lista) {
                Console.WriteLine("Nome :  " + ListCount.Nome);
                Console.WriteLine("Marca :" + ListCount.Marca);
                Console.WriteLine("Ano : " + ListCount.Ano);
                Console.WriteLine("-------------------------------------");

            }



            /*lista.ForEach(ListCount => {
                             
                Console.WriteLine("Nome :  "  + ListCount. Nome );
                Console.WriteLine("Marca :" + ListCount.Marca);
                Console.WriteLine("Ano : " + ListCount.Ano);
                Console.WriteLine("-------------------------------------");
                
                

            });*/
        }
    }
}
