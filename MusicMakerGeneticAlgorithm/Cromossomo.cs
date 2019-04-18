using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicMakerGeneticAlgorithm
{
    class Cromossomo
    {

        private string[] notes = new string[13]
        {"0", "C", "C#", "D" , "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
        //posição zero com 0 para poder ter a escala 1 a 12 de notas correspondente no array

        private string[] whiteNotes = new string[7] { "C", "D", "E", "F", "G", "A", "B" };









        private string[,] chordNotes = new string[4,3];
        private int[] chordRootNoteNumber = new int[4];
        private int rootNote;
        private int chordPitch;
        private int fitness = 0;

        private Random randNum = new Random(Environment.TickCount);

        public Cromossomo()
        {
            chordPitch = randNum.Next(1, 10);
            for (int i = 0; i < chordNotes.GetLength(0); i++)
            {
                rootNote = randNum.Next(1, 12);
                chordRootNoteNumber[i] = rootNote;
                chordNotes[i, 0] = notes[rootNote] + chordPitch;
                chordNotes[i, 1] = notes[CheckIndexChord(rootNote, 4, ref chordPitch)]
                                                                        + chordPitch;
                chordNotes[i, 2] = notes[CheckIndexChord(rootNote, 7, ref chordPitch)]
                                                                        + chordPitch;

            }

            Fitness();

        }

        public Cromossomo(Cromossomo pai1, Cromossomo pai2)
        {
            
            
            //Fitness(); verificar
        }


        private void Fitness()
        {
            /* 
             * Resolution/Tension 1 <- 5 +30
             * Suspended/Landing  3 <- 4 +30 
             * Leading            7 -> 1 +30
             * Fourth's/Fifth's   1 -> 4 +10
             */



        }

        public int GetFitness()
        {
            return fitness;
        }


        public string[,] GetChord()
        {
            return chordNotes;
        }


        private int CheckIndexChord(int rootNote, int num, ref int chordPitch)
        {
            if ((rootNote + num) > (notes.Length - 1))
            {
                chordPitch++;
                return ((rootNote + num) - (notes.Length - 1));
            }
            else
                return rootNote + num;
        }

        private int CheckIndexScale(int rootNote, int num)
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
