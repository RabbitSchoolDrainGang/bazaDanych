using bazaDanych.Models;
using bazaDanych.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace bazaDanych.Service
{
    public class GamesService : IGamesService
    {
        private readonly BazaDbContext _db;
        public GamesService(BazaDbContext db)
        {
            _db = db;
        }

        public async Task<List<Game>> PobierzWszystkieGry()
        {
            return await _db.Games.ToListAsync();
        }
        public async Task<Game> PobierzGre(int id) 
        {
            return await _db.Games.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task Usun(int id)
        {
            var ent = await _db.Games.FirstOrDefaultAsync(x => x.Id == id);
            _db.Games.Remove(ent);
            await _db.SaveChangesAsync(); 
        }
        public async Task Dodaj(Game game)
        {
            await _db.Games.AddAsync(game);
            await _db.SaveChangesAsync();
        }
        public async Task Edit(Game game)
        {
            var ent = await _db.Games.FirstOrDefaultAsync(x => x.Id == game.Id);

            ent.Title = game.Title;
            ent.Genre = game.Genre;
            ent.Platform = game.Platform;
            ent.ReleaseDate = game.ReleaseDate;

            await _db.SaveChangesAsync();
        }
    }
}
