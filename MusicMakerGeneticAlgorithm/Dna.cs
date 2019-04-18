using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicMakerGeneticAlgorithm
{
    class Dna
    {
        Random num;
        int MutationRate;

        private string[] notes = new string[13]
        {"0", "C", "C#", "D" , "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
        //posição zero com 0 para poder ter a escala 1 a 12 de notas correspondente no array

        private string[] whiteNotes = new string[8] {"0", "C", "D", "E", "F", "G", "A", "B" };
        public int[] progression = new int[4];

        public int fitness = 0;

        public Dna(Random randNum)
        {
            for (int i = 0; i < progression.Length; i++)
		    {
                progression[i] = randNum.Next(1, 7);
		    }
            Fitness(this);
        }

        public Dna(Dna Pai1, Dna Pai2, Random randNum, int MutationRate)
        {
            //Construtor para o cruzamento na classe Crossover
            this.MutationRate = MutationRate;
            int copyMark     = randNum.Next(Pai1.progression.Length - 1);
            int geneticLoad  = copyMark;

            Array.Copy(Pai1.progression, copyMark, progression, copyMark, geneticLoad);
            Array.Copy(Pai2.progression, progression.Length - copyMark,
                       progression, progression.Length - copyMark, geneticLoad);


            Fitness(this);
        }

        private void Fitness(Dna Individuo)
        {

            int[] scale = new int[8];

            scale[0] = 0;
            scale[1] = Array.IndexOf(whiteNotes, whiteNotes[CheckIndexScale(Individuo.progression[0], 0)]);
            scale[2] = Array.IndexOf(whiteNotes, whiteNotes[CheckIndexScale(Individuo.progression[0], 1)]);
            scale[3] = Array.IndexOf(whiteNotes, whiteNotes[CheckIndexScale(Individuo.progression[0], 2)]);
            scale[4] = Array.IndexOf(whiteNotes, whiteNotes[CheckIndexScale(Individuo.progression[0], 3)]);
            scale[5] = Array.IndexOf(whiteNotes, whiteNotes[CheckIndexScale(Individuo.progression[0], 4)]);
            scale[6] = Array.IndexOf(whiteNotes, whiteNotes[CheckIndexScale(Individuo.progression[0], 5)]);
            scale[7] = Array.IndexOf(whiteNotes, whiteNotes[CheckIndexScale(Individuo.progression[0], 6)]);

            //fourths 
            if (Individuo.progression[1] == scale[4])
            {
                fitness += 20;
            }
            // suspended
            if (Individuo.progression[1] == scale[4] 
                &&
                Individuo.progression[2] == scale[3] 
                ||
                Individuo.progression[2] == scale[4] 
                &&
                Individuo.progression[3] == scale[3])
            {
                fitness += 30;
            }
            //fifths
            if(Individuo.progression[1] == scale[5])
            {
                fitness += 20;
            }
            
            //Leading
            if(Individuo.progression[3] == scale[7])
            {
                fitness += 30;
            }
            //Resolution/Tension
            if(Individuo.progression[3] == scale[5] || Individuo.progression[2] == scale[5] && Individuo.progression[3] == scale[1])
            {
                fitness += 30;
            }
            
            

        }
        
        public string[] GetChordProgression()
        {
            string[] ChordProgression = new string[progression.Length];

            for (int i = 0; i < ChordProgression.Length; i++)
            {
                ChordProgression[i] =   notes[progression[i]] + "-" +
                                        notes[CheckIndexChord(progression[i], 4)] + "-" +
                                        notes[CheckIndexChord(progression[i], 7)];
            }
            

            return ChordProgression;
        }

        private void Mutation(ref Dna Individuo, int MutationRate)
        {
            string[] whiteNotes = new string[8]
            { "0", "C", "D", "E", "F", "G", "A", "B" };

            num = new Random(Environment.TickCount);

            for (int i = 0; i < MutationRate * 0.10; i++)
            {
                Individuo.progression[num.Next(1, Individuo.progression.Length - 1)] =
                Array.IndexOf(whiteNotes, whiteNotes[num.Next(1, whiteNotes.Length - 1)]);

            }

        }

        private int CheckIndexScale(int rootNote, int num)
        {

            if ((rootNote + num) > (whiteNotes.Length - 1))
            {
                return ((rootNote + num) - (whiteNotes.Length - 1));
            }
            else
                return rootNote + num;
        }

        private int CheckIndexChord(int rootNote, int num)
        {
            if ((rootNote + num) > (notes.Length - 1))
            {
                return ((rootNote + num) - (notes.Length - 1));
            }
            else
                return rootNote + num;
        }


    }
}
