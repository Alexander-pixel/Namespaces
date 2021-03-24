namespace Seven_World_Wonders
{
    public class Mausoleum_at_Halicarnassus
    {
        private string _description;

        public Mausoleum_at_Halicarnassus()
        {
            _description =
                "The Mausoleum at Halicarnassus or Tomb of Mausolus was a tomb built between 353 and 350 BC in Halicarnassus (present Bodrum, Turkey) for Mausolus, " +
                "a native Anatolian from Caria and a satrap in the Achaemenid Empire, and his sister-wife Artemisia II of Caria. The structure was designed by the Greek architects Satyros and Pythius of Priene. " +
                "Its elevated tomb structure is derived from the tombs of neighbouring Lycia, a territory Mausolus had invaded and annexed circa 360 BC, such as the Nereid Monument.";
        }

        public override string ToString()
        {
            return $"Mausoleum at Halicarnassus: {_description}";
        }

        public string GetDescription() => _description;
    }
}