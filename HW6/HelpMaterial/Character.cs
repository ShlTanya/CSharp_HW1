namespace HW6.HelpMaterial
{
    public class Character
    {               
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public int StoryId { get; set; }

        public Character()
        {
        }

        public Character(string firstName, string lastName, bool gender, int age, int storyId)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Age = age;
            StoryId = storyId;
        }

        public override string ToString()
        {
            return $"FirstName: {FirstName}, \tLastName: {LastName},  \tGender: {Gender}," +
                $" \tAge: {Age},  \tStoryId: {StoryId}";
        }
    }
}