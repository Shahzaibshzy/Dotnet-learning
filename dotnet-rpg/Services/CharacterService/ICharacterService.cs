using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

using dotnet_rpg.Models;

namespace dotnet_rpz.Services.CharacterService
{
    public interface ICharacterService
    {
        List<Character> GetAll();
        
        Character GetCharacterbyID(int id);
        
        List<Character> addcharachter(Character newcharacter);


    }
}
