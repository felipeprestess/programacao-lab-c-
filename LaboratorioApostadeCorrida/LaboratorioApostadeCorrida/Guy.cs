using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioApostadeCorrida
{
    class Guy
    {
        public string Name;//O nome do cara
        public Bet MyBet;//Uma instância de Be() que tem sua aposta
        public int Cash;//Quanto dinheiro ele tem

        //Os últimos dois campos são controles no formulário da GUI dos caras
        public RadioButton MyRadionButton;//Meu RadioButton
        public Label MyLabel;// Minha Label

        public void UpdateLabels()
        {
            //defina minha etiqueta para a descrição dda minha aposta e a etiqueta em meu
            //botão de rádio para mostrar meu dinheiro ("João tem 43 reais")
        }

        public void ClearBet()//Redefina minha aposta para que seja zero
        {

        }

        public bool PlaceBet(int Amount, int Dog)
        {
            //Faça uma nova aposta e armazene-a no meu campo de aposta
            //Retorne true se o cara teve o dinheiro suficiente para apostar
        }

        public void Collect(int Winner)
        {
            //cobre a minha aposta se eu ganhei
        }
    }
}
