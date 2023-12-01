namespace Prakt9
{
    struct Films
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public int Length { get; set; }

        public Films(string name, string genre, int year, int length)
        {
            Name = name;
            Genre = genre;
            Year = year;
            Length = length;
        }
    }
}
