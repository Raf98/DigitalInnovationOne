using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
  public class SerieRepositorio : IRepositorio<Serie>
  {

    private List<Serie> listaSerie = new List<Serie>();
    public bool Atualiza(int id, Serie objeto)
    {
      for (int i = 0; i < this.TamanhoDaLista(); i++)
      {
        if (listaSerie[i].retornaId() == id)
        {
          listaSerie[i] = objeto;
					return true;
        }
      }

			return false;
    }

    public bool Exclui(int id)
    {

      for (int i = 0; i < this.TamanhoDaLista(); i++)
      {
        if (listaSerie[i].retornaId() == id)
        {
          listaSerie.Remove(listaSerie[i]);
					return true;
        }
      }

			return false;
      //listaSerie[id].Excluir();
    }

    public void Insere(Serie objeto)
    {
      listaSerie.Add(objeto);
    }

    public List<Serie> Lista()
    {
      return listaSerie;
    }

    public int ProximoId()
    {
      //return listaSerie.Count;
      return listaSerie.Count == 0 ? 0 : listaSerie[listaSerie.Count - 1].retornaId() + 1;
    }

    public Serie RetornaPorId(int id)
    {
      foreach (var serie in listaSerie)
      {
        if (serie.retornaId() == id)
        {
          return serie;
        }
      }
      //return listaSerie[id];
      //throw new ArgumentOutOfRangeException();
      return null;
    }

    public int TamanhoDaLista()
    {
      return listaSerie.Count;
    }

    public bool ListaEstaVazia()
    {
      return this.TamanhoDaLista() == 0 ? true : false;
    }

    public bool IdExiste(int id)
    {
      for (int i = 0; i < this.TamanhoDaLista(); i++)
      {
        if (listaSerie[i].retornaId() == id)
        {
          return true;
        }
      }

      return false;
    }
  }
}