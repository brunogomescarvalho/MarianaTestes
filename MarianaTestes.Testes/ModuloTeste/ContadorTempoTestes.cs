using MarianaTestes.Dominio.ModuloTeste;

namespace MarianaTestes.TestesUnitarios.ModuloTeste
{
    [TestClass]
    public class ContadorTempoTestes
    {

        [TestMethod]
        public void Deve_retornar_58_segundos()
        {
            var dataCalcular = DateTime.Now.AddSeconds(-58);

            string tempoCalculado = new ContadorTempo(dataCalcular).ObterTempoEmString();

            Assert.AreEqual($"O teste foi realizado a 58 segundos", tempoCalculado);

        }

        [TestMethod]
        public void Deve_retornar_cinco_minutos()
        {
            var dataCalcular = DateTime.Now.AddMinutes(-5);

            string tempoCalculado = new ContadorTempo(dataCalcular).ObterTempoEmString();

            Assert.AreEqual($"O teste foi realizado a 5 minutos", tempoCalculado);

        }


        [TestMethod]
        public void Deve_retornar_1_minuto()
        {
            var dataCalcular = DateTime.Now.AddMinutes(-1);

            string tempoCalculado = new ContadorTempo(dataCalcular).ObterTempoEmString();

            Assert.AreEqual($"O teste foi realizado a 1 minuto", tempoCalculado);

        }

        [TestMethod]
        public void Deve_retornar_cinco_dias()
        {
            var dataCalcular = DateTime.Now.AddDays(-5);

            string tempoCalculado = new ContadorTempo(dataCalcular).ObterTempoEmString();

            Assert.AreEqual($"O teste foi realizado a 5 dias", tempoCalculado);

        }

        [TestMethod]
        public void Deve_retornar_1_dia()
        {
            var dataCalcular = DateTime.Now.AddDays(-1);

            string tempoCalculado = new ContadorTempo(dataCalcular).ObterTempoEmString();

            Assert.AreEqual($"O teste foi realizado a 1 dia", tempoCalculado);

        }


        [TestMethod]
        public void Deve_retornar_3_semanas()
        {
            var dataCalcular = DateTime.Now.AddDays(-21);

            string tempoCalculado = new ContadorTempo(dataCalcular).ObterTempoEmString();

            Assert.AreEqual($"O teste foi realizado a 3 semanas", tempoCalculado);

        }

        [TestMethod]
        public void Deve_retornar_1_semana()
        {
            var dataCalcular = DateTime.Now.AddDays(-7);

            string tempoCalculado = new ContadorTempo(dataCalcular).ObterTempoEmString();

            Assert.AreEqual($"O teste foi realizado a 1 semana", tempoCalculado);

        }


        [TestMethod]
        public void Deve_retornar_seis_meses()
        {
            var dataCalcular = DateTime.Now.AddMonths(-6);

            string tempoCalculado = new ContadorTempo(dataCalcular).ObterTempoEmString();

            Assert.AreEqual($"O teste foi realizado a 6 meses", tempoCalculado);

        }

        [TestMethod]
        public void Deve_retornar_1_mes()
        {
            var dataCalcular = DateTime.Now.AddMonths(-1);

            string tempoCalculado = new ContadorTempo(dataCalcular).ObterTempoEmString();

            Assert.AreEqual($"O teste foi realizado a 1 mês", tempoCalculado);

        }

        [TestMethod]
        public void Deve_retornar_1_ano()
        {
            var dataCalcular = DateTime.Now.AddYears(-1);

            string tempoCalculado = new ContadorTempo(dataCalcular).ObterTempoEmString();

            Assert.AreEqual($"O teste foi realizado a 1 ano", tempoCalculado);

        }

        [TestMethod]
        public void Deve_retornar_3_anos()
        {
            var dataCalcular = DateTime.Now.AddYears(-3);

            string tempoCalculado = new ContadorTempo(dataCalcular).ObterTempoEmString();

            Assert.AreEqual($"O teste foi realizado a 3 anos", tempoCalculado);

        }
    }
}
