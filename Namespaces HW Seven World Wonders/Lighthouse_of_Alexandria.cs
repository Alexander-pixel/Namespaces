namespace Seven_World_Wonders
{
    public class Lighthouse_of_Alexandria
    {
        private string _description;
        public Lighthouse_of_Alexandria()
        {
            _description = "The Lighthouse of Alexandria, sometimes called the Pharos of Alexandria, was a lighthouse built by the Ptolemaic Kingdom, during the reign of Ptolemy II Philadelphus, " +
                           "which has been estimated to be at least 100 metres in overall height." +
                           " One of the Seven Wonders of the Ancient World, for many centuries it was one of the tallest man-made structures in the world.";
        }

        public string GetDescription() => _description;

        public override string ToString()
        {
            return $"Lighthouse of Alexandria: {_description}";
        }
    }
}