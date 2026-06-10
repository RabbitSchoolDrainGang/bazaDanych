using bazaDanych.Models;

namespace bazaDanych.Service.Interfaces
{
    public interface IGamesService
    {
        Task<List<Game>> PobierzWszystkieGry();
        Task<Game> PobierzGre(int id);
        Task Usun(int id);
        Task Dodaj(Game game);
        Task Edit(Game game);
    }
}