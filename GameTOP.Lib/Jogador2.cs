using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Jogador 2 está chutando";
        }

        public string Corre()
        {
            return "Jogador 2 está correndo";
        }   

        public string Passe()
        {
            return "Jogador 2 está passando";
        }
    }
}