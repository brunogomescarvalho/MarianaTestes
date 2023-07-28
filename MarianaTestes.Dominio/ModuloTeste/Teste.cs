using MarianaTestes.Dominio.Compartilhado;
using MarianaTestes.Dominio.ModuloDisciplina;
using MarianaTestes.Dominio.ModuloMateria;
using MarianaTestes.Dominio.ModuloQuestao;

namespace MarianaTestes.Dominio.ModuloTeste
{

    public delegate void on_InformarQuestoesInsuficientes(string msg);
    public class Teste : EntidadeBase<Teste>
    {
        public string Titulo { get; set; }

        public List<Questao> Questoes { get; set; }

        public Disciplina Disciplina { get; set; }

        public int QtdQuestoes { get; set; }

        public DateTime DataTeste { get; set; }

        public SerieMateriaEnum? Serie { get; set; }

        public Materia? Materia { get; set; }

        public bool Recuperacao { get; set; }
        public string TempoDesdeRealizacao { get => ObterTempoDoTesteString(); }

        public event on_InformarQuestoesInsuficientes InformarQtdInsuficiente;

        public Teste()
        {
            Questoes = new List<Questao>();
        }

        public Teste(int id, string titulo, Disciplina disciplina, Materia materia, int qtdQuestoes, SerieMateriaEnum? serie, DateTime dataTeste, bool recuperacao) : this()
        {
            Id = id;
            Titulo = titulo;
            DataTeste = dataTeste;
            Disciplina = disciplina;
            DataTeste = dataTeste;
            QtdQuestoes = qtdQuestoes;
            Recuperacao = recuperacao;
            Materia = materia;
            Serie = serie;
        }


        public void AdicionarQuestoes(List<Questao> questoes)
        {
            this.Questoes.AddRange(questoes);
        }

        public void ObterQuestoesSorteadas(List<Questao> questoes, int qtdQuestoes)
        {
            Questoes.Clear();

            questoes = FiltrarLista(questoes);

            if (questoes.Count < qtdQuestoes)
            {
                InformarQtdInsuficiente($"A quantidade de questões solicitada: '{qtdQuestoes}', é superior a disponível: '{questoes.Count}'");
                return;
            }

            var random = new Random();

            var questoesTeste = new HashSet<Questao>();

            while (questoesTeste.Count < qtdQuestoes)
            {
                Questao questao = questoes[random.Next(0, questoes.Count)];

                questoesTeste.Add(questao);
            }

            Questoes = questoesTeste.ToList();
        }

        private List<Questao> FiltrarLista(List<Questao> questoes)
        {
            return questoes.Distinct().ToList();
        }

        public string ObterTesteString(bool gabarito)
        {
            var geradorTeste = new GeradorTesteEmString(this);

            if (gabarito == true)
                return geradorTeste.ObterGabaritoEmString();
            else
                return geradorTeste.ObterTesteEmString();
        }

        private string ObterTempoDoTesteString()
        {
            return new ContadorTempo(DataTeste).ObterTempoEmString();
        }

        public override void Editar(Teste entidade)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Titulo}";
        }

        public override bool Equals(object? obj)
        {
            bool equals = obj is Teste teste &&
            Id == teste.Id &&
            Titulo == teste.Titulo &&
            Questoes.Count == teste.Questoes.Count &&
            Disciplina.Id == teste.Disciplina.Id &&
            QtdQuestoes == teste.QtdQuestoes &&
            DataTeste.Date == teste.DataTeste.Date &&
            Serie == teste.Serie &&
            Materia?.Id == teste.Materia?.Id &&
            Recuperacao == teste.Recuperacao &&
            TempoDesdeRealizacao == teste.TempoDesdeRealizacao;

            return equals;
        }

    }
}
