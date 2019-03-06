﻿using System;
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
            public GameDatabase()
            {
                var game = new Game();
                game.Name = "DOOM";
                game.Description = "Space Marine";
                game.Price = 49.99M;
                Add(game);

                game = new Game();
                game.Name = "Oblivion";
                game.Description = "Medieval";
                game.Price = 89.99M;
                Add(game);

                game = new Game();
                game.Name = "Fallout 76";
                game.Description = "Failed MMO";
                game.Price = 0.01M;
                Add(game);
            }
        }
        public Game Add (Game game)
        {
            if (game == null)
                throw new ArgumentNullException(nameof(game));
            if (game == null)
                return null;
            // validate input
            if (!game.Validate())
                throw new Exception("Game is invalid");
            
            var existing = GetIndex(game.Name;
            if (existing >= 0)
                throw new Exception("Game name has aleady been used");
            for (var index = 0; index < _items.Length; ++index)
            {
                if (_items[index] == null)
                {
                    game.Id = ++_nextId;
                    _items[index] = Clone(game);
                    break;
                };
                
            };
            return game;
        }
        public void Delete (int id)
        {
            var index = GetIndex(id);
            if (index >= 0)
                _items[index] = null;

        }
        public Game Get( int id )
        {
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

        public Game [] GetAll()
        {// how many games?
            int count = 0;
            foreach (var item in _items)
                if (item != null)
                    ++count;
            var temp = new Game[count];
            var tempIndex = 0;
            for (var index = 0; index < _items.Length; ++index)
                if (_items[index] != null)
                    temp[tempIndex++] = Clone(_items[index]);

            return temp;
        }
        private int GetIndex( int id )
        {
            for (var index = 0; index < _items.Length; ++index)
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
        private readonly Game[] _items = new Game[100];
        private int _nextId = 0;
        private int GetIndex( string name )
        {
            for (var index = 0; index < _items.Length; ++index)
                if (String.Compare(_items[index].Name, name, true) == 0)
                    return index;

            return -1;
        }
    }
   
