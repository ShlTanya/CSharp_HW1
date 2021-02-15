using HW7.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HW7
{
    class Program
    {
        static void Main(string[] args)
        {
           //HW7();
            HW8();
        }

        private static void HW7()
        {
            var dbContext = new CharactersDbContext();
            DropStories(dbContext);
            CreateStories(dbContext);
            DropCharacters(dbContext);
            CreateCharacters(dbContext);
            Console.ReadKey();
        }

        private static void DropCharacters(CharactersDbContext dbContext)
        {
            dbContext.Characters.RemoveRange(dbContext.Characters);
            dbContext.SaveChanges();
        }

        private static void CreateCharacters(CharactersDbContext dbContext)
        {
            var characters = GetCharactersCollection(dbContext);

            foreach (var character in characters)
            {
                dbContext.Characters.Add(character);
            }

            dbContext.SaveChanges();
            Console.WriteLine("Characters added");
        }


        private static void DropStories(CharactersDbContext dbContext)
        {
            dbContext.Stories.RemoveRange(dbContext.Stories);
            dbContext.SaveChanges();
        }

        private static void CreateStories(CharactersDbContext dbContext)
        {
            var stories = GetStoriesCollection();
            foreach (var story in stories)
            {
                dbContext.Stories.Add(story);
            }

            dbContext.SaveChanges();
            Console.WriteLine("Stories added");
        }

        private static List<Story> GetStoriesCollection()
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

        private static List<Character> GetCharactersCollection(CharactersDbContext dbContext)
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

        private static void HW8()
        {
            var dbContext = new CharactersDbContext();
            UpdateStories(dbContext);
            GetCharacters(dbContext);
            Console.ReadKey();
        }

        private static void UpdateStories(CharactersDbContext dbContext)
        {
            var st = dbContext.Stories.Where(s => s.Name == "LOTR").FirstOrDefault();
            st.AuthorID = dbContext.Authors.Where(a => a.LastName == "Tolkien").Select(i => i.Id).FirstOrDefault();

            st = dbContext.Stories.Where(s => s.Name == "Foundation").FirstOrDefault();
            st.AuthorID = dbContext.Authors.Where(a => a.LastName == "Azimov").Select(i => i.Id).FirstOrDefault();

            st = dbContext.Stories.Where(s => s.Name == "Star Wars").FirstOrDefault();
            st.AuthorID = dbContext.Authors.Where(a => a.LastName == "Lucas").Select(i => i.Id).FirstOrDefault();

            dbContext.SaveChanges();
        }

        private static void GetCharacters(CharactersDbContext dbContext)
        {
            var ch = dbContext.Characters
                        .Include(c => c.Story)
                        .ThenInclude(s => s.Author);

            foreach (var c in ch)
            {
                Console.WriteLine($"FirstName: {c.FirstName},   \tLastName: {c.LastName},   \tGender: {c.Gender}, \tAge: {c.Age},"
                    + $"\tStoryName: {c.Story?.Name},     \tAuthor: {c.Story?.Author?.FirstName} {c.Story?.Author?.LastName}");

            }
        }
    }
}
