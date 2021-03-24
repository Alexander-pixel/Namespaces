namespace Seven_World_Wonders
{
    public class Statue_of_Zeus_at_Olympia
    {
        private string _description;

        public Statue_of_Zeus_at_Olympia()
        {
            _description = "The Statue of Zeus at Olympia was a giant seated figure, about 12.4 m tall, " +
                           "made by the Greek sculptor Phidias around 435 BC at the sanctuary of Olympia, Greece, " +
                           "and erected in the Temple of Zeus there. Zeus was the sky and thunder god in ancient Greek religion, " +
                           "who ruled as king of the gods of Mount Olympus.";
        }

        public string GetDescription() => _description;

        public override string ToString()
        {
            return $"Statue of Zeus at Olympia: {_description}";
        }
    }
}