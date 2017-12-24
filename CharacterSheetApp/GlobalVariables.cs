using System.Collections.Generic;
using CharacterSheetApp.Models;
using System;

namespace CharacterSheetApp
{
    public static class GlobalVariables
    {
        // setting our Character property's default value to be a new list of character.
        public static List<CharacterSheetApp.Models.Character> Characters { get; set; } = new List<Character>();
    }
}
