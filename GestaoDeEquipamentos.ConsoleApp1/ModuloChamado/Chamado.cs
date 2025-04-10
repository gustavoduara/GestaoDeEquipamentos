﻿using GestaoDeEquipamentos.ConsoleApp.ModuloEquipamento;
using GestaoDeEquipamentos.ConsoleApp.ModuloEquipamento;

namespace GestaoDeEquipamentos.ConsoleApp.ModuloChamado;

public class Chamado
{
    public int Id;
    public string Titulo;
    public string Descricao;
    public Equipamento Equipamento;
    public DateTime DataAbertura;

    public string Validacao()
    {
        string erros = "";
        if (string.IsNullOrWhiteSpace(Titulo))
            erros += "O campo 'Título' não pode ser vazio.\n";


    }

    public Chamado(string titulo, string descricao, Equipamento equipamento)
    {
        Titulo = titulo;
        Descricao = descricao;
        Equipamento = equipamento;
        DataAbertura = DateTime.Now;
    }

    public int ObterTempoDecorrido()
    {
        TimeSpan diferencaTempo = DateTime.Now.Subtract(DataAbertura);

        return diferencaTempo.Days;
    }
}