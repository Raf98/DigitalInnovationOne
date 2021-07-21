using System;

namespace DIO.Series
{
  class Program
  {
    static SerieRepositorio repositorio = new SerieRepositorio();
    static void Main(string[] args)
    {
      string opcaoUsuario = ObterOpcaoUsuario();

      while (opcaoUsuario.ToUpper() != "X")
      {
        switch (opcaoUsuario)
        {
          case "1":
            ListarSeries();
            break;
          case "2":
            InserirSerie();
            break;
          case "3":
            AtualizarSerie();
            break;
          case "4":
            ExcluirSerie();
            break;
          case "5":
            VisualizarSerie();
            break;
          case "C":
            Console.Clear();
            break;

          default:
            throw new ArgumentOutOfRangeException();
        }

        opcaoUsuario = ObterOpcaoUsuario();
      }

      Console.WriteLine("Obrigado por utilizar nossos serviços.");
      Console.ReadLine();
    }

    private static void ExcluirSerie()
    {
      if (!ListaEstaVazia())
      {
        Console.Write("Digite o id da série: ");
        int indiceSerie = int.Parse(Console.ReadLine());

				if(IdExiste(indiceSerie))
				{
					if(repositorio.Exclui(indiceSerie)){
						Console.WriteLine("Série excluída com sucesso!");
					} else {
						Console.WriteLine("Falha na exclusão da série!");
					}
				}
      }

    }

    private static void VisualizarSerie()
    {

      if (!ListaEstaVazia())
      {
        Console.Write("Digite o id da série: ");
        int indiceSerie = int.Parse(Console.ReadLine());

        var serie = repositorio.RetornaPorId(indiceSerie);

        if (serie == null)
        {
          Console.WriteLine("ID de série inexistente!");
        }
        else
        {
          Console.WriteLine(serie);
        }
      }
    }

    private static void AtualizarSerie()
    {
      if (!ListaEstaVazia())
      {
        Console.Write("Digite o id da série: ");
        int indiceSerie = int.Parse(Console.ReadLine());

        if (IdExiste(indiceSerie))
        {
          // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
          // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
          foreach (int i in Enum.GetValues(typeof(Genero)))
          {
            Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
          }
          Console.Write("Digite o gênero entre as opções acima: ");
          int entradaGenero = int.Parse(Console.ReadLine());

          Console.Write("Digite o Título da Série: ");
          string entradaTitulo = Console.ReadLine();

          Console.Write("Digite o Ano de Início da Série: ");
          int entradaAno = int.Parse(Console.ReadLine());

          Console.Write("Digite a Descrição da Série: ");
          string entradaDescricao = Console.ReadLine();

          Serie atualizaSerie = new Serie(id: indiceSerie,
                        genero: (Genero)entradaGenero,
                        titulo: entradaTitulo,
                        ano: entradaAno,
                        descricao: entradaDescricao);

					if(repositorio.Atualiza(indiceSerie, atualizaSerie)){
						Console.WriteLine("Série atualizada com sucesso!");
					} else {
						Console.WriteLine("Falha na atualização da série!");
					}
        }
      }
    }
    private static void ListarSeries()
    {
      if (!ListaEstaVazia())
      {
        Console.WriteLine("Listar séries");

        var lista = repositorio.Lista();

        /*if (lista.Count == 0)
        {
          Console.WriteLine("Nenhuma série cadastrada.");
          return;
        }*/

        foreach (var serie in lista)
        {
          //var excluido = serie.retornaExcluido();

          //Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluído*" : ""));
          Console.WriteLine("#ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo());
        }
      }
    }

    private static void InserirSerie()
    {
      Console.WriteLine("Inserir nova série");

      // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
      // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
      foreach (int i in Enum.GetValues(typeof(Genero)))
      {
        Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
      }
      Console.Write("Digite o gênero entre as opções acima: ");
      int entradaGenero = int.Parse(Console.ReadLine());

      Console.Write("Digite o Título da Série: ");
      string entradaTitulo = Console.ReadLine();

      Console.Write("Digite o Ano de Início da Série: ");
      int entradaAno = int.Parse(Console.ReadLine());

      Console.Write("Digite a Descrição da Série: ");
      string entradaDescricao = Console.ReadLine();

      Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                    genero: (Genero)entradaGenero,
                    titulo: entradaTitulo,
                    ano: entradaAno,
                    descricao: entradaDescricao);

      repositorio.Insere(novaSerie);
			Console.WriteLine("Série adicionada com sucesso!");
    }

    private static string ObterOpcaoUsuario()
    {
      Console.WriteLine();
      Console.WriteLine("DIO Séries a seu dispor!!!");
      Console.WriteLine("Informe a opção desejada:");

      Console.WriteLine("1- Listar séries");
      Console.WriteLine("2- Inserir nova série");
      Console.WriteLine("3- Atualizar série");
      Console.WriteLine("4- Excluir série");
      Console.WriteLine("5- Visualizar série");
      Console.WriteLine("C- Limpar Tela");
      Console.WriteLine("X- Sair");
      Console.WriteLine();

      string opcaoUsuario = Console.ReadLine().ToUpper();
      Console.WriteLine();
      return opcaoUsuario;
    }

    private static bool ListaEstaVazia()
    {
      if (repositorio.ListaEstaVazia())
      {
        Console.WriteLine("Nenhuma série cadastrada!");
        return true;
      }
      return false;
    }

    private static bool IdExiste(int id)
    {
      if (!repositorio.IdExiste(id))
      {
        Console.WriteLine($"Serie com ID {id} não encontrada!\n");
        return false;
      }
      return true;
    }
  }
}
