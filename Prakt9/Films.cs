namespace Prakt9
{
    struct Films // Фильмотека
    {
        public string Name { get; set; } // Название фильма
        public string Genre { get; set; } // Жанр фильма
        public int Year { get; set; } // Год выпуска
        public int Length { get; set; } // Продолжительность просмотра

        public Films(string name, string genre, int year, int length)
        {
            Name = name;
            Genre = genre;
            Year = year;
            Length = length;
        }
    }
}
