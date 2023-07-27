
namespace MarianaTestes.Dominio.ModuloTeste
{

    public class ContadorTempo
    {
        private const int SEMANA = 7;
        private const int MES = 30;
        private const int ANO = 365;
        private long tempo;

        private MedidaTempoEnum medidaTempo;
        private Dictionary<MedidaTempoEnum, string> plural;
        private Dictionary<MedidaTempoEnum, string> singular;

        private DateTime dataParaCalcular;


        public ContadorTempo(DateTime dataParaCalcular)
        {
            this.dataParaCalcular = dataParaCalcular;

            InicializarListas();
        }


        public string ObterTempoEmString()
        {
            CalcularTempo(dataParaCalcular);

            Dictionary<MedidaTempoEnum, string> lista;

            lista = tempo > 1 ? plural : singular;

            string medida = lista[medidaTempo];

            return $"O teste foi realizado a {tempo} {medida}";

        }

        private void CalcularTempo(DateTime dataParaCalcular)
        {
            TimeSpan diferenca = DateTime.Now.Subtract(dataParaCalcular);

            if (diferenca < TimeSpan.FromMinutes(1))
            {
                medidaTempo = MedidaTempoEnum.segundos;
                tempo = diferenca.Seconds;
            }
            else if (diferenca < TimeSpan.FromHours(1))
            {
                medidaTempo = MedidaTempoEnum.minutos;
                tempo = diferenca.Minutes;
            }
            else if (diferenca < TimeSpan.FromDays(1))
            {
                medidaTempo = MedidaTempoEnum.horas;
                tempo = diferenca.Hours;
            }
            else if (diferenca < TimeSpan.FromDays(SEMANA))
            {
                medidaTempo = MedidaTempoEnum.dias;
                tempo = diferenca.Days;
            }
            else if (diferenca < TimeSpan.FromDays(MES))
            {
                medidaTempo = MedidaTempoEnum.semanas;
                tempo = (long)diferenca.TotalDays / SEMANA;
            }
            else if (diferenca < TimeSpan.FromDays(ANO))
            {
                medidaTempo = MedidaTempoEnum.meses;
                tempo = (long)diferenca.TotalDays / MES;
            }
            else
            {
                medidaTempo = MedidaTempoEnum.anos;
                tempo = (long)diferenca.TotalDays / ANO;
            }
        }

        private void InicializarListas()
        {
            plural = new();
            singular = new();

            plural.Add(MedidaTempoEnum.segundos, "segundos");
            plural.Add(MedidaTempoEnum.minutos, "minutos");
            plural.Add(MedidaTempoEnum.horas, "horas");
            plural.Add(MedidaTempoEnum.dias, "dias");
            plural.Add(MedidaTempoEnum.semanas, "semanas");
            plural.Add(MedidaTempoEnum.meses, "meses");
            plural.Add(MedidaTempoEnum.anos, "anos");

            singular.Add(MedidaTempoEnum.segundos, "segundo");
            singular.Add(MedidaTempoEnum.minutos, "minuto");
            singular.Add(MedidaTempoEnum.horas, "hora");
            singular.Add(MedidaTempoEnum.dias, "dia");
            singular.Add(MedidaTempoEnum.semanas, "semana");
            singular.Add(MedidaTempoEnum.meses, "mês");
            singular.Add(MedidaTempoEnum.anos, "ano");
        }
    }



    public enum MedidaTempoEnum
    {
        segundos,
        minutos,
        horas,
        dias,
        semanas,
        meses,
        anos
    }
}

