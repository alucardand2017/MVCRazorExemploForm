using System.Collections.Generic;

namespace AULA06APPENQUETES.Models;

public static class Repositorio
{
    private static List<Resposta> respostas = new List<Resposta>();
    public static IEnumerable<Resposta> Respostas {get {return respostas; }}
    public static void AdicionaResposta(Resposta resposta)
    {
        respostas.Add(resposta);
    }
    static Repositorio()
    {
        respostas.Add(new Resposta(){Nome = "Fulano", Email = "fulano@gmail.com", Escolha = true});
        respostas.Add(new Resposta(){Nome = "Ciclado", Email = "Ciclado@gmail.com", Escolha = false});
        respostas.Add(new Resposta(){Nome = "Beltrano", Email = "Beltrano@gmail.com", Escolha = true});
        respostas.Add(new Resposta(){Nome = "Anderson", Email = "Anderson@gmail.com", Escolha = false});
        respostas.Add(new Resposta(){Nome = "Maria", Email = "Maria@gmail.com", Escolha = true});
        respostas.Add(new Resposta(){Nome = "Vanessa", Email = "Vanessa@gmail.com", Escolha = true});
        respostas.Add(new Resposta(){Nome = "Luigi", Email = "Luigi@gmail.com", Escolha = true});
        respostas.Add(new Resposta(){Nome = "Kirby", Email = "Kirby@gmail.com", Escolha = false});
    }
}
