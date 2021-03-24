namespace Seven_World_Wonders
{
    public class Hanging_Gardens_of_Babylon
    {
        private string _description;

        public Hanging_Gardens_of_Babylon()
        {
            _description = "The Hanging Gardens of Babylon were one of the Seven Wonders of the Ancient World listed by Hellenic culture. " +
                           "They were described as a remarkable feat of engineering " +
                           "with an ascending series of tiered gardens containing a wide variety of trees, shrubs, and vines, " +
                           "resembling a large green mountain constructed of mud bricks.";
        }

        public string GetDescription() => _description;

        public override string ToString()
        {
            return $"Hanging Gardens of Babylon: {_description}";
        }
    }
}