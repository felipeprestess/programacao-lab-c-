using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioApostadeCorrida
{
    class Bet
    {
        public int Amount;//A quantidade de dinheiro que foi apostada
        public int Dog;// O número do cão em que apostamos
        public Guy Bettor;//O cara que fez a aposta

        public string GetDescription()
        {
            //Retorne uma string que diga quem fez a aposta, quanto
            //dinheiro foi apostado e em qual cão ("João apostou 8 no cão #4")
            //Se a quantidade for zero, a aposta não foi feita
            //("João não apostou")
        }

        public int PayOut(int Winner)
        {
            //O parâmetro é o vencedor da corrida. Se o cão venceu,
            //retorne a quantia apostada. De outra forma, retorne um valor
            //negativo do valor apostado
        }
    }
}
