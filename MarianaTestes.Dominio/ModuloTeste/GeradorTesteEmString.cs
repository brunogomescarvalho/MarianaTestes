using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarianaTestes.Dominio.ModuloTeste
{
    public class GeradorTesteEmString
    {
        private Teste teste;

        public GeradorTesteEmString(Teste teste)
        {
            this.teste = teste;
        }

        private string ConstruirCabecalho(string tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{tipo} Nr° {teste.Id}");
            sb.AppendLine($"Título: {teste.Titulo}");
            sb.AppendLine($"Data: {teste.DataTeste:d} - Recuperação: {(teste.Recuperacao ? "Sim" : "Não")}");
            sb.AppendLine($"Disciplina: {teste.Disciplina.Nome} {(teste.Recuperacao ? "" : $" - Matéria: {teste.Materia?.Nome}")}");
            sb.AppendLine($"Série: {teste.Serie}");

            return sb.ToString();
        }

        public string ObterTesteEmString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(ConstruirCabecalho("Teste"));

            int i = 1;

            foreach (var questao in teste.Questoes)
            {
                sb.AppendLine($"{i}) {questao.Pergunta}");

                foreach (var alternativa in questao.Alternativas)
                {
                    sb.AppendLine($"[_] {alternativa.Texto}");
                }

                sb.AppendLine();
                i++;
            }

            return sb.ToString();
        }

        public string ObterGabaritoEmString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(ConstruirCabecalho("Gabarito"));

            int i = 1;

            foreach (var questao in teste.Questoes)
            {
                sb.AppendLine($"{i}) {questao.Pergunta}");

                foreach (var alternativa in questao.Alternativas)
                {
                    var marcador = alternativa.EhCorreta ? "[x]" : "[_]";
                    sb.AppendLine($"{marcador} {alternativa.Texto}");
                }

                sb.AppendLine();
                i++;
            }

            return sb.ToString();
        }
    }
}
