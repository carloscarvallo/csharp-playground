using System.Collections.Generic;
using System;

namespace CharacterSheetApp.Models
{
    public class Character
    {
        public string Name;
        public static void Create(string CharacterName)
        {
            var character = new Character();
            character.Name = CharacterName;
            GlobalVariables.Characters.Add(character);
        }
        public static List<Character> GetAll()
        {
            return GlobalVariables.Characters;
        }
    }
}