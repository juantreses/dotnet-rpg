using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static readonly List<Character> characters = new List<Character> {
            new(),
            new() { Id = 1, Name = "Sam" }
        };

        public List<Character> GetAllCharacters()
        {
            return characters;
        }

        public Character GetCharacterById(int id)
        {
            var character = characters.FirstOrDefault(c => c.Id == id);
            if (character is not null)
            {
                return character;
            }

            throw new Exception("Character not Found");
        }

        public List<Character> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }
    }
}