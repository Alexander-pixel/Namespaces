namespace Seven_World_Wonders
{
    public class Colossus_of_Rhodes
    {
        private string _description;

        public Colossus_of_Rhodes()
        {
            _description =
                "The Colossus of Rhodes was a statue of the Greek sun-god Helios, erected in the city of Rhodes, on the Greek island of the same name, " +
                "by Chares of Lindos in 280 BC. One of the Seven Wonders of the Ancient World, it was constructed to celebrate its successful defense against Demetrius Poliorcetes, " +
                "who had besieged it for a year with a large army and navy.";
        }

        public string GetDescription() => _description;

        public override string ToString()
        {
            return $"Colossus of Rhodes: {_description}";
        }
    }
}