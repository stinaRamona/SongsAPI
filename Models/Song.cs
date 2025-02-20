namespace SongsAPI.Models {

    public class Song {
        public int SongId { get; set; }

        public string? Artist { get; set;}

        public string? Title { get; set; }

        public int Duration { get; set; }

        public string? Genre { get; set; }

    }
}