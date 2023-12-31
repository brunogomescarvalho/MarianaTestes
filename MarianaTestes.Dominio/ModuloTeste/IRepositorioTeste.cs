﻿using MarianaTestes.Dominio.Compartilhado;
using MarianaTestes.Dominio.ModuloQuestao;

namespace MarianaTestes.Dominio.ModuloTeste
{
    public interface IRepositorioTeste : IRepositorioBase<Teste>
    {
        List<Teste> FiltrarTestes(FiltroTeste filtro);

        Teste BuscarTestePorTitulo(string titulo);

        List<Teste> BuscarTodos(bool carregarQuestoes = false);

        Teste SelecionarPorId(int id, bool incluirQuestoes = false, bool incluirAlternativas = false, bool incluirMateria = false);


    }

}

