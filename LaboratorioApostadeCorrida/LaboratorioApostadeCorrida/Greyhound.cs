using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LaboratorioApostadeCorrida
{
   public class Greyhound
    {
        public int StartingPosition;//Onde PictureBox inicia
        public int RacetrackLength;//O tamanho da pista de corrida
        public PictureBox MyPictureBox = null;//Meu objeto PictureBox
        public int Location = 0; // Minha posição na pista
        public Random Randomizer; // Uma instancia de Random


        public bool Run()
        {
            //Avance 1,2,3 ou 4 espaços aleatoriamente
            //Atualize a posição de PictureBox no formulário
            //Retorna true se eu ganhei a corrida
        }

        public void TakeStartingPosition()
        {
            //Redefina minha posição para a linha de partida
        }
    }
}
