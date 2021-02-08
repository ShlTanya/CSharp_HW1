namespace HW6.HelpMaterial
{
    public class CharacterStory
    {               
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public int StoryId { get; set; }
        public string StoryName { get; set; }
        public string Description { get; set; }

        public CharacterStory(string firstName, string lastName, bool gender, int age, int storyId, string storyName, string description)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Age = age;
            StoryId = storyId;
            StoryName = storyName;
            Description = description;
        }

        public override string ToString()
        {
            return $"FN: {FirstName},\tLN: {LastName},\tG: {Gender}," +
                $"\tAge: {Age},\tStoryId: {StoryId},\tSN: {StoryName}" +
                $"\tDesc: {Description}";
        }
    }
}