using viggoWebApi.Models;
using System.Collections.Generic;

namespace viggoWebApi.Services.CharacterService
{
    public interface ICharacterService
    {
         List<Character> GetAllCharacters();

         Character GetCharacterById(int id);

         List<Character> AddCharacter(Character newCharacter);
    }
}