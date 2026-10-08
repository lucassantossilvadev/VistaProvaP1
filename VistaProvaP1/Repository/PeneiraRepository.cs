using VistaProvaP1.Models;

namespace VistaProvaP1.Repository
{
    public class PeneiraRepository : IPeneiraRepository
    {
        private static List<Jogador> _jogadores = new List<Jogador>();
        private static List<Resultado> _resultados = new List<Resultado>();

        public void CadastrarJogador(Jogador jogador)
        {
            _jogadores.Add(jogador);
        }

        public List<Jogador> ListarJogadores()
        {
            return _jogadores;
        }

        public Jogador ObterJogadorPorCpf(string cpf)
        {
            return _jogadores.FirstOrDefault(j => j.Cpf == cpf);
        }

        public void RegistrarResultado(Resultado resultado)
        {
            _resultados.Add(resultado);
        }

        public Resultado ObterResultadoPorCpf(string cpf)
        {
            return _resultados.FirstOrDefault(r => r.Cpf == cpf);
        }

        public List<Jogador> ListarAprovados()
        {
            var cpfsAprovados = _resultados.Where(r => r.Aprovado).Select(r => r.Cpf).ToList();
            return _jogadores.Where(j => cpfsAprovados.Contains(j.Cpf)).ToList();
        }
    }
}