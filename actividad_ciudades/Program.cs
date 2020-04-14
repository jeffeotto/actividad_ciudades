using System;
using System.Linq;

namespace actividad_ciudades
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var bcn = " ";
            var mdr = "";
            var vln = "";
            var mal = "";
            var cdz = "";
            var stnd = "";

            Console.WriteLine("Escribe Barcelona");
            bcn  = Console.ReadLine();
           

            Console.WriteLine("Escribe Madrid");
            mdr  = Console.ReadLine();
         

            Console.WriteLine("Escribe Valencia");
            vln = Console.ReadLine();


            Console.WriteLine("Escribe Málaga");
            mal = Console.ReadLine();
           

            Console.WriteLine("Escribe Cádiz");
            cdz = Console.ReadLine();
           

            Console.WriteLine("Escribe Santander");
            stnd = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Primera ciudad " + bcn);
            Console.WriteLine("Segunda ciudad " + mdr);
            Console.WriteLine("Tercera ciudad " + vln);
            Console.WriteLine("Cuarta ciudad " + mal);
            Console.WriteLine("Quinta ciudad " + cdz);
            Console.WriteLine("Sexta ciudad " + stnd);

            string[] cities = {bcn,mdr,vln,mal,cdz,stnd};


            Console.WriteLine("");
            Console.WriteLine("Mostrar las ciudades en order alfabetico.");
            Array.Sort(cities);

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }


            Console.WriteLine("");
            string[] ArrayCiudadesModificadas = new string[6];

                for (var i = 0; i<cities.Length;i++)
                {
                    ArrayCiudadesModificadas[i] = cities[i];
   
               
                    if (ArrayCiudadesModificadas[i].Contains("a"))
                    {
                    Console.WriteLine(ArrayCiudadesModificadas[i].Replace('a', '4'));
                    }


                }

 
              string[] bcnArray = new string[bcn.Length];
              string[] mdrArray = new string[mdr.Length];
              string[] vlnArray = new string[vln.Length];
              string[] malArray = new string[mal.Length];
              string[] cdzArray = new string[cdz.Length];
              string[] stndArray = new string[stnd.Length];


                Console.WriteLine("");
                for (int i = bcn.Length -1; i >= 0; i--)
                    {

                       bcnArray[i] += bcn[i];
                        Console.WriteLine(bcnArray[i]);

                    }


                Console.WriteLine("");
                for (int i = mdr.Length - 1; i >= 0; i--)
                {

                   mdrArray[i] += mdr[i];
                    Console.WriteLine(mdrArray[i]);

                }


                Console.WriteLine("");
                for (int i =vln.Length - 1; i >= 0; i--)
                {

                    vlnArray[i] += vln[i];
                    Console.WriteLine(vlnArray[i]);

                }


                Console.WriteLine("");
                for (int i = mal.Length - 1; i >= 0; i--)
                {

                   malArray[i] +=mal[i];
                    Console.WriteLine(malArray[i]);

                }


                Console.WriteLine("");
                for (int i = cdz.Length - 1; i >= 0; i--)
                {

                   cdzArray[i] +=cdz[i];
                    Console.WriteLine(cdzArray[i]);

                }


                Console.WriteLine("");
                for (int i = stnd.Length - 1; i >= 0; i--)
                {

                   stndArray[i] += stnd[i];
                    Console.WriteLine(stndArray[i]);

                }


        }



    }
}
