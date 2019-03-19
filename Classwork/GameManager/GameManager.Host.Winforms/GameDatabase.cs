using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager
{
    public class GameDatabase
    {

        public GameDatabase()
        {
            //var game = new Game();
            //game.Name = "DOOM";
            //game.Description = "Space Marine";
            //game.Price = 49.99M;
            //below is object initializer syntax, it is all one expression this syntax can be used anywhere an expression is allowed

            //var game = new Game() { Name = "Doom", Description = "Space Marine", Price = 49.99M };
            //Add(game);

            game = new Game();
            //{
            //    Name = "Oblivion",
            //    Description = "Medieval",
            //    Price = 89.99M,
            //};
            //Add(game);

            //Add(new Game()
            //{
            //    Name = "Fallout 76",
            //    Description = "Failed MMO",
            //    Price = 0.01M
            //});
            // collection initialize syntax, you can set and iniialize a collection in one swoop        var game = new Game() { Name = "Doom", Description = "Space Marine", Price = 49.99M };
            Add(game);

            var games = new []
     {
                    new Game() { Name = "DOOM", Description = "Space Marine", Price = 49.99M },
                    new Game() { Name = "Oblivion", Description = "Medieval", Price = 89.99M },
                    new Game() { Name = "Fallout 76", Description = "Failed MMO", Price = 0.01M }
     };

            foreach (var game in games)
                Add(game);

            Add(new Game()
            {
                Name = "Fallout 76",
                Description = "Failed MMO",
                Price = 0.01M
            });

        }

        public Game Add( Game game )
        {
            if (game == null)
                throw new ArgumentNullException(nameof(game));
            if (game == null)
                return null;
            // validate input
            if (!game.Validate())
                throw new Exception("Game is invalid");

            var existing = GetIndex(game.Name);
            if (existing >= 0)
                throw new Exception("Game name has aleady been used");
            //for (var index = 0; index < _items.Length; ++index)
            //{
            //    if (_items[index] == null)
            //    {
            //        game.Id = ++_nextId;
            //        _items[index] = Clone(game);
            //        break;
            //    };
            game.Id = ++_nextId;
            _items.Add(Clone(game));

            return game;
        }
    }
    public void Delete( int id )
    {
        if (id <= 0)
            throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");

        var index = GetIndex(id);
        if (index >= 0)
            _items.RemoveAt(index);

    }
    public Game Get( int id )
    {
        if (id <= 0)
            throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");

        var index = GetIndex(id);
        if (index >= 0)
            return Clone(_items[index]);

        return null;
    }


    public Game Update( int id, Game game )
    {
        var index = GetIndex(id);
        var existing = _items[index];

        Clone(existing, game);

        game.Id = id;
        return game;
    }

    public Game[] GetAll()
    {// how many games?
     //var game = _items[0];

        //int count = 0;
        //foreach (var item in _items)
        //    if (item != null)
        //        ++count;
        //var temp = new Game[count];
        //var tempIndex = 0;
        //for (var index = 0; index < _items.Length; ++index)
        //    if (_items[index] != null)
        //        temp[tempIndex++] = Clone(_items[index]);
        Array temp = new List<Game>();
        foreach (var item in _items)
            temp.Add(Clone(item));

        return temp.ToArray();
    }
    private int GetIndex( int id )
    {
        for (var index = 0; index < _items.Count; ++index)
            if (_items[index]?.Id == id)
                return index;

        return -1;
    }
    private Game Clone( Game game )
    {
        var newGame = new Game();
        Clone(newGame, game);

        return newGame;
    }

    private void Clone( Game target, Game source )
    {
        target.Id = source.Id;
        target.Name = source.Name;
        target.Description = source.Description;
        target.Price = source.Price;
        target.Owned = source.Owned;
        target.Completed = source.Completed;
    }
    // private readonly Game[] _items = new Game[100];

    //private readonly ArrayList _items = new ArrayList();
    private readonly List<Game> _items = new List<Game>();

    private int _nextId = 0;
    private int GetIndex( string name )
    {
        for (var index = 0; index < _items.Length; ++index)
            if (String.Compare(_items[index].Name, name, true) == 0)
                return index;

        return -1;
    }
}



