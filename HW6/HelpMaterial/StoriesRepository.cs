using System.Collections.Generic;

namespace HW6.HelpMaterial
{
    public static class StoriesRepository
    {
        public static IEnumerable<Story> GetStories()
        {
            var stories = new List<Story>();

            stories.Add(new Story(1, "Fairytail of the lost needle", "None1"));
            stories.Add(new Story(2, "Foundation", "None2"));
            stories.Add(new Story(3, "Cool story, Bob", "None3"));

            return stories;
        }
    }
}