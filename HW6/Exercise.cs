using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using HW6.HelpMaterial;

namespace HW6
{
    static class Exercise
    {
        public static void Exercise1()
        {
            var characters = CharactersRepository.GetCharacters();

            var results = from character in characters
                          select new
                          {
                              PersonDescription = character.ToString() 
                          };

            foreach (var result in results)
                Console.WriteLine(result.PersonDescription);
        }

        public static void Exercise2()
        {
            var characters = CharactersRepository.GetCharacters();
            var stories = StoriesRepository.GetStories();

            var results = from character in characters
                          join story in stories
                          on character.StoryId equals story.Id
                          into characterstories
                          from story in characterstories.DefaultIfEmpty()
                          select new CharacterStory(character.FirstName, character.LastName, character.Gender,
                                         character.Age, character.StoryId, story != null ? story.Name: default(string),
                                         story != null ? story.Description : default(string));


            foreach (var result in results)
                Console.WriteLine(result.ToString());
        }
    }
}