using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MusicMakerGeneticAlgorithm
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Console.Write("Populacao: ");
            int sizePopulation = int.Parse(Console.ReadLine());
            Console.Write("Mutacao em %: ");
            int mutationRate = int.Parse(Console.ReadLine());
            Console.Write("Numero de Geracoes: ");
            int maxGeneration = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Dna[] Population = new Dna[sizePopulation];

            for (int i = 0; i < sizePopulation; i++)
            {
                Population[i] = new Dna(new Random(Environment.TickCount + i));
            }

            Crossover crossover = new Crossover(mutationRate);
            crossover.Cross(ref Population, maxGeneration);

            for (int i = 0; i < sizePopulation; i++)
            {
                Console.WriteLine(i + " " + Population[i].fitness);
            }

            Console.WriteLine("######\n The best chord is... ");
            for (int i = 0; i < Population[0].GetChordProgression().Length; i++)
            {
                Console.Write(Population[0].GetChordProgression()[i] + " | ");
            }

            Console.ReadLine();


        }
    }
}
