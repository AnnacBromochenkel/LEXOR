using System;
using System.Collections.Generic;
using System.Linq;

// guarda as informações que serão usadas -> lê e grava o valor de um atributo 
class UserAdv
{
    public string NomeComp { get; set; }
    public int Idade { get; set; }
    public string InscricaoOAB { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public string Estado { get; set; }
    public List<string> Formacao { get; set; }
    public string TempoExperiencia { get; set; }
    public List<string> AreasAtuacao { get; set; }
    public List<string> Idiomas { get; set; }
}

class UserEsc
{
    public string NomeEsc { get; set; }
    public string Cnpj { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }
    public string SociOAB { get; set; }
    public List<string> PrefAreas { get; set; }
    public List<string> IdiomasEx { get; set; }
    public string MinExperiencia { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // banco de dados dos escritórios (todos fictícios)
        List<UserEsc> escritorios = new List<UserEsc>
        {
            new UserEsc {
                NomeEsc = "Silva & Associados",
                Cnpj = "12.345.678/0001-90",
                Endereco = "Rua Haddock Lobo, 585 - Cerqueira César, São Paulo - SP",
                Telefone = "(11) 998154-4848",
                PrefAreas = new List<string> { "Direito Civil", "Direito Trabalhista" },
                IdiomasEx = new List<string> { "" },
                MinExperiencia = "2 anos",
            },
            new UserEsc {
                NomeEsc = "Martins Advogados",
                Cnpj = "98.765.432/0001-12",
                Endereco = "Avenida Atlântica, 1702 - Copacabana, Rio de Janeiro - RJ",
                Telefone = "(21) 98888-1111",
                PrefAreas = new List<string> { "Direito Penal", "Direito Constitucional" },
                IdiomasEx = new List<string> { "Inglês" },
                MinExperiencia = "6 meses",
            },
            new UserEsc {
                NomeEsc = "Global Law",
                Cnpj = "11.222.333/0001-44",
                Endereco = "SHIS QI 5, Bloco F - Lago Sul, Brasília - DF",
                Telefone = "(61)97777-2222",
                PrefAreas = new List<string> { "Direito Internacional", "Direito Empresarial" },
                IdiomasEx = new List<string> { "Inglês", "Espanhol" },
                MinExperiencia = "3.5 meses",
            },
            new UserEsc {
                NomeEsc = "Ramos & Tavares Advocacia",
                Cnpj = "27.456.123/0001-82",
                Endereco = "Avenida Princesa Isabel, 250 - Praia do Suá, Vitória - ES",
                Telefone = "(27) 3225-8741",
                PrefAreas = new List<string> { "Direito Civil", "Direito Empresarial" },
                IdiomasEx = new List<string> { "Inglês" },
                MinExperiencia = "1 ano",
            },
            new UserEsc {
                NomeEsc = "Lima e Associados",
                Cnpj = "29.874.562/0001-47",
                Endereco = "Rua José Teixeira, 315 - Centro, Vitória - ES",
                Telefone = "(27) 3345-2198",
                PrefAreas = new List<string> { "Direito do Trabalho", "Direito Previdenciário" },
                IdiomasEx = new List<string> { "" },
                MinExperiencia = "2 anos",
            },
            new UserEsc {
                NomeEsc = "Carvalho, Mendes & Dias Advogados",
                Cnpj = "31.965.480/0001-02",
                Endereco = "Rua da Carioca, 45 - Centro, Rio de Janeiro - RJ",
                Telefone = "(21) 3289-1075",
                PrefAreas = new List<string> { "Direito Tributário", "Direito Empresarial" },
                IdiomasEx = new List<string> { "Inglês", "Espanhol" },
                MinExperiencia = "2 anos",
            },
            new UserEsc {
                NomeEsc = "Souza Pereira Advocacia",
                Cnpj = "32.841.902/0001-63",
                Endereco = "Rua do Ouvidor, 98 - Centro, Rio de Janeiro - RJ",
                Telefone = "(21) 2705-3320",
                PrefAreas = new List<string> {"Direito Civil", "Direito de Família"},
                IdiomasEx = new List<string> {"Português"},
                MinExperiencia = "1 ano",
            },
            new UserEsc {
                NomeEsc = "Ferreira & Castro Sociedade de Advogados",
                Cnpj = "33.714.059/0001-54",
                Endereco = "Rua Visconde de Pirajá, 414 - Ipanema, Rio de Janeiro - RJ",
                Telefone = "(24) 2251-6409",
                PrefAreas = new List<string> {"Direito Ambiental", "Direito Administrativo"},
                IdiomasEx = new List<string> {"Inglês"},
                MinExperiencia = "3 anos",
            },
            new UserEsc {
                NomeEsc = "Barbosa & Costa Advocacia",
                Cnpj = "41.236.587/0001-19",
                Endereco = "Avenida Beira-Mar Norte, 1260 - Centro, Santa Catarina - SC",
                Telefone = "(48) 3235-4478",
                PrefAreas = new List<string> {"Direito Empresarial", "Direito Digital"},
                IdiomasEx = new List<string> {"Inglês"},
                MinExperiencia = "Não possui",
            },
            new UserEsc {
                NomeEsc = "Martins, Rocha & Lacerda Advogados",
                Cnpj = "42.785.698/0001-40",
                Endereco = "Rua Felipe Schmidt, 345 - Centro, Santa Catarina - SC",
                Telefone = "(47) 3425-9920",
                PrefAreas = new List<string> { "Direito Trabalhista", "Direito Civil" },
                IdiomasEx = new List<string> { "" },
                MinExperiencia = "Não possui",
            }
        };

        // input para inserir os dados dos advogados
        UserAdv novoAdvogado = new UserAdv();

        Console.Write("Insira seu Nome: ");
        novoAdvogado.NomeComp = Console.ReadLine();

        Console.Write("Insira sua idade: ");
        novoAdvogado.Idade = int.Parse(Console.ReadLine());

        Console.Write("Insira seu número da OAB: ");
        novoAdvogado.InscricaoOAB = Console.ReadLine();

        Console.Write("Informe seu tempo de experiência (ex: 2 anos, 6 meses): ");
        novoAdvogado.TempoExperiencia = Console.ReadLine();

        Console.Write("Insira o telefone: ");
        novoAdvogado.Telefone = Console.ReadLine();

        Console.Write("Insira o e-mail: ");
        novoAdvogado.Email = Console.ReadLine();

        Console.Write("Informe o estado que você mora: ");
        novoAdvogado.Estado = Console.ReadLine().ToUpper().Trim(); // padroniza a leitura da string em letras maiúsculas

        Console.Write("Informe as áreas de atuação: ");
        novoAdvogado.AreasAtuacao = Console.ReadLine()
            .Split(',')
            .Select(a => a.Trim())
            .ToList(); // metódo que é chamado por uma string para usar a vírgula como separador, retornando um array de strings

        Console.Write("Informe os idiomas que domina: ");
        novoAdvogado.Idiomas = Console.ReadLine()
            .Split(',')
            .Select(i => i.Trim())
            .Where(i => !string.IsNullOrEmpty(i)) // verifica se existem strings vazias que possam atrapalhar a comparação e anula
            .ToList();

        // inicio do algoritmo de recomendação:
        var recomendacoes = RecomendarEscritorios(novoAdvogado, escritorios); 

        Console.WriteLine($"\n * Recomendações para você: *");
        Console.WriteLine("");
        
        if (recomendacoes.Count == 0) // contador

        {
            Console.WriteLine("Nenhum escritório com suas preferências foi encontrado.");
        }
        else
        {
            foreach (var r in recomendacoes)
            {
                Console.WriteLine($"{r.NomeEsc} - {r.Endereco}");
                Console.WriteLine($"Tel: {r.Telefone}");
                Console.WriteLine($"Áreas: {string.Join(", ", r.PrefAreas)}");
                Console.WriteLine($"Idiomas: {(r.IdiomasEx.Any(i => !string.IsNullOrEmpty(i)) ? string.Join(", ", r.IdiomasEx.Where(i => !string.IsNullOrEmpty(i))) : "Não especificado")}");
                Console.WriteLine($"Experiência mínima: {(string.IsNullOrEmpty(r.MinExperiencia) ? "Não especificada" : r.MinExperiencia)}");
                Console.WriteLine("");
            }
        }
    }

    // calcula compatibilidade e retorna recomendação
    static List<UserEsc> RecomendarEscritorios(UserAdv advogado, List<UserEsc> escritorios)
    {
        return escritorios
            .Select(e => new // para cada escritório na lista, é criado um objeto temporário que contém o escritório original
            {
                Escritorio = e,
                Pontuacao = CalcularPontuacao(advogado, e),
                CompatibilidadeAreas = CalcularCompatibilidadeAreas(advogado, e),
                CompatibilidadeExperiencia = VerificarExperiencia(advogado, e),
                CompatibilidadeEstado = VerificarEstado(advogado, e),
                CompatibilidadeIdiomas = CalcularCompatibilidadeIdiomas(advogado, e)
            })
            .Where(x => x.Pontuacao >= 15) // define a pontuação mínima de 15 pontos para ter relevância
            .OrderByDescending(x => x.Pontuacao) // ordena a lista de recomendações de forma decrescente
            .ThenByDescending(x => x.CompatibilidadeAreas) // se dois escritórios tiverem a mesma pontuação final, usa a compatibilidade de áreas como critério de desempate 
            .ThenByDescending(x => x.CompatibilidadeExperiencia) // se mesmo assim persistir, irá usar o critério de tempo de experiência
            .Select(x => x.Escritorio)
            .ToList();
    }

    // calculadora de pontos
    static int CalcularPontuacao(UserAdv advogado, UserEsc escritorio)
    {
        int pontuacao = 0;

        // compatibilidade -> peso alto = 3
        // compatibilidade -> peso médio = 2
        pontuacao += CalcularCompatibilidadeAreas(advogado, escritorio) * 3;
        pontuacao += VerificarEstado(advogado, escritorio) * 2;
        pontuacao += CalcularCompatibilidadeIdiomas(advogado, escritorio) * 2;
        pontuacao += VerificarExperiencia(advogado, escritorio) * 3;

        // escritórios que não exigem experiência mínima recebem bônus de 5 pontos
        if (string.IsNullOrEmpty(escritorio.MinExperiencia))
            pontuacao += 5;

        return pontuacao;
    }

    // função para compatibilidade de áreas
    static int CalcularCompatibilidadeAreas(UserAdv advogado, UserEsc escritorio)
    {
        if (advogado.AreasAtuacao == null || !advogado.AreasAtuacao.Any() || 
            escritorio.PrefAreas == null || !escritorio.PrefAreas.Any())
            return 0;

        var areasComuns = advogado.AreasAtuacao
            .Select(a => a.ToLower().Trim())
            .Intersect(escritorio.PrefAreas
                .Select(p => p.ToLower().Trim()))
            .Count();

        // bònus se todas as áreas do advogado são atendidas pelo escritório
        if (areasComuns == advogado.AreasAtuacao.Count)
            areasComuns += 2;

        return areasComuns;
    }

    // função para verificar o estado
    static int VerificarEstado(UserAdv advogado, UserEsc escritorio)
    {
        if (string.IsNullOrEmpty(advogado.Estado) || string.IsNullOrEmpty(escritorio.Endereco))
            return 0;

        // extrai o estado e endereço do escritório
        var partesEndereco = escritorio.Endereco.Split('-');
        if (partesEndereco.Length >= 2)
        {
            var estadoEscritorio = partesEndereco[partesEndereco.Length - 1].Trim();
            return advogado.Estado.Equals(estadoEscritorio, StringComparison.OrdinalIgnoreCase) ? 3 : 0;
        }

        return 0;
    }

    // função que calcula a compatibilidade de idiomas
    static int CalcularCompatibilidadeIdiomas(UserAdv advogado, UserEsc escritorio)
    {
        if (advogado.Idiomas == null || !advogado.Idiomas.Any())
            return 0;

        var idiomasEscritorio = escritorio.IdiomasEx ?? new List<string>();
        
        if (!idiomasEscritorio.Any() || idiomasEscritorio.All(string.IsNullOrEmpty))
            return 1; // bônus se o escritório não exige idiomas

        var idiomasComuns = advogado.Idiomas
            .Select(i => i.ToLower().Trim())
            .Intersect(idiomasEscritorio
                .Where(i => !string.IsNullOrEmpty(i))
                .Select(i => i.ToLower().Trim()))
            .Count();

        return idiomasComuns;
    }

    // verifica a compatibilidade de experiência
    static int VerificarExperiencia(UserAdv advogado, UserEsc escritorio)
    {
        if (string.IsNullOrEmpty(escritorio.MinExperiencia))
            return 2; // bônus se não existe exigência de experiência

        if (string.IsNullOrEmpty(advogado.TempoExperiencia))
            return 0;

        try
        {
            var expAdvogado = ConverterExperienciaParaMeses(advogado.TempoExperiencia);
            var expEscritorio = ConverterExperienciaParaMeses(escritorio.MinExperiencia);

            if (expAdvogado >= expEscritorio)
                return 3; // atende ou supera a exigência
            else if (expAdvogado >= expEscritorio * 0.5)
                return 1; // atende parcialmente
            else
                return 0; // não atende
        }
        catch
        {
            // fallback: comparação textual 
            return advogado.TempoExperiencia.ToLower().Contains(escritorio.MinExperiencia.ToLower()) ? 1 : 0;
        }
    }

    // função auxiliar que converte experiência em meses
    static double ConverterExperienciaParaMeses(string experiencia)
    {
        if (string.IsNullOrEmpty(experiencia))
            return 0;

        experiencia = experiencia.ToLower();
        var partes = experiencia.Split(' ');

        if (partes.Length < 2) return 0;

        if (double.TryParse(partes[0], out double valor))
        {
            if (experiencia.Contains("ano") || experiencia.Contains("anos"))
                return valor * 12;
            else if (experiencia.Contains("mês") || experiencia.Contains("meses") || experiencia.Contains("mes"))
                return valor;
        }

        return 0;
    }
}