using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace MusicMakerGeneticAlgorithm
{
    class Piano
    {
        private string[] notes = new string[13]
        {"0", "C", "C#", "D" , "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

        SoundPlayer C, CS, D, DS , E, F, FS, G, GS, A, AS, B;
        public Piano()
        {
            C  = new SoundPlayer(@"C:\Users\mathe\Desktop\piano\C.wav");
            CS = new SoundPlayer(@"C:\Users\mathe\Desktop\piano\C#.wav");
            D  = new SoundPlayer(@"C:\Users\mathe\Desktop\piano\D.wav");
            DS = new SoundPlayer(@"C:\Users\mathe\Desktop\piano\D#.wav");
            E  = new SoundPlayer(@"C:\Users\mathe\Desktop\piano\E.wav");
            F  = new SoundPlayer(@"C:\Users\mathe\Desktop\piano\F.wav");
            FS = new SoundPlayer(@"C:\Users\mathe\Desktop\piano\F#.wav");
            G  = new SoundPlayer(@"C:\Users\mathe\Desktop\piano\G.wav");
            GS = new SoundPlayer(@"C:\Users\mathe\Desktop\piano\G#.wav");
            A  = new SoundPlayer(@"C:\Users\mathe\Desktop\piano\A.wav");
            AS = new SoundPlayer(@"C:\Users\mathe\Desktop\piano\A#.wav");
            B  = new SoundPlayer(@"C:\Users\mathe\Desktop\piano\B.wav");
        }

        public void PlayChord()
        {
            
        }
        
    }
}
