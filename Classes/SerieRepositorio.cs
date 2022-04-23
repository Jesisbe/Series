using System;
using System.Collections.Generic;
using Series.Interfaces;

namespace Series
{
    //Mihna classe SerieRepositorio esta implementando IRepositorio y Serie
    public class SerieRepositorio : IRepositorio<Serie>
    {
       private List<Serie> listaSerie = new List<Serie>();     
    public void Atualiza(int id, Serie objeto)
    {
        //throw new NotImplementedException();
        listaSerie[id] = objeto;
    }
    public void Exclui(int id)
    {
       //throw new NotImplementedException(); 
       listaSerie[id].Excluir();
     }
     public void Insere(Serie objeto)
     {
       //throw new NotImplementedException(); 
       listaSerie.Add(objeto);
     }

     public List<Serie> Lista()
     {
        //throw new NotImplementedException(); 
        return listaSerie;
     }

     public int ProximoId()
     {
        //throw new NotImplementedException(); 
        return listaSerie.Count;
     }

     public Serie RetornaPorId(int id)
     {
         //throw new NotImplementedException();
         return listaSerie[id];
     }

   }
}