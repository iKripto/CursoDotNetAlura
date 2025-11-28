class Banda
{
    private List<Album> albums = new List<Album>();
    public string Nome { get; set; }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        foreach (var album in albums) 
        {
            Console.WriteLine($"Álbum: {album.Nome}, Duração Total: {album.DuracaoTotal} segundos");
            album.ExibirMusicas();
        }
    }
}