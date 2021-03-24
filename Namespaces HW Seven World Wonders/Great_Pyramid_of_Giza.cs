namespace Seven_World_Wonders
{
    public class Great_Pyramid_of_Giza
    {
        private string _description;

        public Great_Pyramid_of_Giza()
        {
            _description =
                "The Great Pyramid of Giza is the oldest and largest of the three pyramids in the Giza pyramid complex bordering present-day Giza in Greater Cairo, Egypt. " +
                "It is the oldest of the Seven Wonders of the Ancient World, and the only one to remain largely intact.";
        }

        public override string ToString()
        {
            return $"Great Pyramid of Giza: {_description}";
        }

        public string GetDescription() => _description;
    }
}