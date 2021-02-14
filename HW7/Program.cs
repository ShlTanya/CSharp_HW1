using HW7.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new CharactersDbContext();
            dropStories(dbContext);
            createStories(dbContext);
            dropCharacters(dbContext);
            createCharacters(dbContext);
            Console.ReadKey();
        }

        private static void dropCharacters(CharactersDbContext dbContext)
        {
            dbContext.Characters.RemoveRange(dbContext.Characters);
            dbContext.SaveChanges();
        }

        private static void createCharacters(CharactersDbContext dbContext)
        {
            var characters = getCharactersCollection(dbContext);

            foreach (var character in characters)
            {
                dbContext.Characters.Add(character);
            }

            dbContext.SaveChanges();
            Console.WriteLine("Characters added");
        }


        private static void dropStories(CharactersDbContext dbContext)
        {
            dbContext.Stories.RemoveRange(dbContext.Stories);
            dbContext.SaveChanges();
        }

        private static void createStories(CharactersDbContext dbContext)
        {
            var stories = getStoriesCollection();
            foreach (var story in stories)
            {
                dbContext.Stories.Add(story);
            }

            dbContext.SaveChanges();
            Console.WriteLine("Stories added");
        }

        private static List<Story> getStoriesCollection()
        {
            var stories = new List<Story>();

            stories.Add(new Story() { Name = "Adventure Time", Description = "" });
            stories.Add(new Story() { Name = "Futurama", Description = "" });
            stories.Add(new Story() { Name = "LOTR", Description = "" });
            stories.Add(new Story() { Name = "Breakfast at Tiffanys", Description = "" });
            stories.Add(new Story() { Name = "John Wick Trilogy", Description = "" });
            stories.Add(new Story() { Name = "Star Wars", Description = "" });
            stories.Add(new Story() { Name = "WoW", Description = "" });
            stories.Add(new Story() { Name = "Foundation ", Description = "" });
            return stories;
        }

        private static List<Character> getCharactersCollection(CharactersDbContext dbContext)
        {
            var stories = dbContext.Stories;
            var characters = new List<Character>();

            characters.Add(new Character() { FirstName = "Finn", LastName = "Mertens", Gender = true, Age = 14, Story = stories.Where(c => c.Name == "Adventure Time").FirstOrDefault() });
            characters.Add(new Character() { FirstName = "Philip", LastName = "Fry", Gender = true, Age = 25, Story = stories.Where(c => c.Name == "Futurama").FirstOrDefault() });
            characters.Add(new Character() { FirstName = "Arven", LastName = "Undomiel", Gender = false, Age = 2700, Story = stories.Where(c => c.Name == "LOTR").FirstOrDefault() });
            characters.Add(new Character() { FirstName = "Audrey", LastName = "Hepburn", Gender = false, Age = 29, Story = stories.Where(c => c.Name == "Breakfast at Tiffanys").FirstOrDefault() });
            characters.Add(new Character() { FirstName = "John", LastName = "Wick", Gender = true, Age = 42, Story = stories.Where(c => c.Name == "John Wick Trilogy").FirstOrDefault() });
            characters.Add(new Character() { FirstName = "Anakin", LastName = "Skywalker", Gender = true, Age = 29, Story = stories.Where(c => c.Name == "Star Wars").FirstOrDefault() });
            characters.Add(new Character() { FirstName = "Princess", LastName = "Bubblegum", Gender = false, Age = 827, Story = stories.Where(c => c.Name == "Adventure Time").FirstOrDefault() });
            characters.Add(new Character() { FirstName = "Princess", LastName = "Lea", Gender = false, Age = 45, Story = stories.Where(c => c.Name == "Star Wars").FirstOrDefault() });
            characters.Add(new Character() { FirstName = "Varian", LastName = "Wrynn", Gender = true, Age = 42, Story = stories.Where(c => c.Name == "WoW").FirstOrDefault() });
            characters.Add(new Character() { FirstName = "Harry", LastName = "Seldon", Gender = true, Age = 35, Story = stories.Where(c => c.Name == "Foundation").FirstOrDefault() });
            return characters;
        }
    }
}
