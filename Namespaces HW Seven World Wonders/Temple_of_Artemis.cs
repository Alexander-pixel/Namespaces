namespace Seven_World_Wonders
{
    public class Temple_of_Artemis
    {
        private string _description;

        public Temple_of_Artemis()
        {
            _description = "The Temple of Artemis or Artemision, also known less precisely as the Temple of Diana, " +
                           "was a Greek temple dedicated to an ancient, local form of the goddess Artemis (associated with Diana, a Roman goddess). " +
                           "It was located in Ephesus (near the modern town of Selçuk in present-day Turkey). It was completely rebuilt twice, " +
                           "once after a devastating flood and three hundred years later after an act of arson, and in its final form was one of the Seven Wonders of the Ancient World. " +
                           "By 401 AD it had been ruined or destroyed.[1] Only foundations and fragments of the last temple remain at the site.";
        }

        public string GetDescription() => _description;

        public override string ToString()
        {
            return $"Temple of Artemis: {_description}";
        }
    }
}