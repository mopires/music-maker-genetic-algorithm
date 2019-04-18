using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicMakerGeneticAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            CreatePopulation();
        }

        private void CreatePopulation()
        {
            int sizePopulation = int.Parse(txtSizePopulation.Text);
            int mutationRate   = int.Parse(txtMutation.Text);
            int maxGeneration  = 500;

            Dna[] Population = new Dna[sizePopulation];

            for (int i = 0; i < sizePopulation; i++)
            {
                Population[i] = new Dna(new Random(Environment.TickCount + i));
            }

            Crossover crossover = new Crossover(mutationRate);
            crossover.Cross(ref Population, maxGeneration);


            //TA ERRADO A SAIDA
            for (int i = 0; i < Population[0].GetChordProgression().Length; i++)
            {
                MessageBox.Show(Population[0].GetChordProgression()[i]);
            }
                
            
        }
    }
}
