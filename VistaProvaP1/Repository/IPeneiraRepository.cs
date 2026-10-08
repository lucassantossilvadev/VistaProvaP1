using VistaProvaP1.Models;

namespace VistaProvaP1.Repository
{
    public interface IPeneiraRepository
    {
        public void CadastrarJogador(Jogador jogador);
        public List<Jogador> ListarJogadores();
        public Jogador ObterJogadorPorCpf(string cpf);
        public void RegistrarResultado(Resultado resultado);
        public Resultado ObterResultadoPorCpf(string cpf);
        public List<Jogador> ListarAprovados();
    }
}