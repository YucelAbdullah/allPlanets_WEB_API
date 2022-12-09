namespace allPlanets.Models
{
    public class BasicDetail
    {
        public string mass { get; set; }
        public string volume { get; set; }
    }

    public class ImgSrc
    {
        public string img { get; set; }
        public string imgDescription { get; set; }
    }

    public class Planets
    {
        public List<BasicDetail> basicDetails { get; set; }
        public string description { get; set; }
        public int id { get; set; }
        public List<ImgSrc> imgSrc { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string planetOrder { get; set; }
        public string source { get; set; }
        public string wikiLink { get; set; }
    }
}

