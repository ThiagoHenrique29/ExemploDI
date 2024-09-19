﻿namespace IDConsole.Exemplo;

internal sealed class ServicoMostrarCicloDeVida(
    ITransientService servicoTransiente,
    IScopedService servicoScoped,
    ISingletonService servicoSingleton)
{
    private static void MostraServico<T>(T servico, string mensagem)
        where T : IReportServiceLifetime => 
        Console.WriteLine($"{typeof(T).Name}: {servico.Id} ({mensagem})");
        
    public void MostrarDetalhes(string detalhes)
    {
        Console.WriteLine(detalhes);

        MostraServico(servicoTransiente, "Muda Sempre");
        MostraServico(servicoScoped, "Muda no escopo");
        MostraServico(servicoSingleton, "Muda Nunca");
    }



}