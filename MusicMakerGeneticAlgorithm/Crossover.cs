using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicMakerGeneticAlgorithm
{
    class Crossover
    {
        int MutationRate;

        public Crossover(int MutationRate) { this.MutationRate = MutationRate; }
        
        public void Cross(ref Dna[] Population, int maxGeneration)
        {
            for (int i = 0; i < maxGeneration; i++)
            {
                Classification(ref Population);

                Random num = new Random(Environment.TickCount + i);
                Dna newPopulation = new Dna(Population[num.Next(Population.Length - 1)],
                                            Population[num.Next(Population.Length - 1)],
                                            new Random(Environment.TickCount + i),
                                            MutationRate);

                for (int j = Population.Length - 1; j > 0 ; j--)
                {
                    if(newPopulation.fitness <= Population[j].fitness)
                    {
                        Population[j-1] = newPopulation;
                        break;
                    }
                    
                }

            }

            
        }

        private void Classification(ref Dna[] Population)
        {
            try
            {
                Population = Population.OrderBy(p => p.fitness).ToArray();
                Array.Reverse(Population);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        


    }





}
