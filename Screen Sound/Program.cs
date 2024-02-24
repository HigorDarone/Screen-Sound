using System.Runtime.ExceptionServices;

Banda Veigh = new Banda("Veigh");


Album albumDoVeigh = new Album("Dos Predios");

Musica musica1 = new Musica(Veigh, "Mil Maneiras")
{
    Duracao = 130,
    Disponivel = false,
};


Musica musica2 = new Musica(Veigh, "Vida Chique")
{
    Duracao = 200,
    Disponivel = true,
};








Episodio episodio1 = new Episodio(" Oque sera de nos?", 1, 50);
         episodio1.AdicionarConvidado("Higor Darone");


Episodio episodio2 = new Episodio(" Ovnis existem", 2, 43);
         episodio2.AdicionarConvidado("Serjao ");




PodCast podcast1 = new PodCast("igor", "Flow");
podcast1.AdicionarEpisodio(episodio1);
podcast1.AdicionarEpisodio(episodio2);

podcast1.ExibirDetalhes();






albumDoVeigh.AdicionarMusica(musica1);
albumDoVeigh.AdicionarMusica(musica2);
Veigh.AdicionarAlbum(albumDoVeigh);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();

albumDoVeigh.ExibiMusicasDoAlbum();


Veigh.ExibirDiscrografia();








/*Musica musica1 = new Musica();
musica1.Nome = "Anos Luz";
musica1.Artista = "Matue";
musica1.Duracao = 273;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);

Musica musica2 = new Musica();
musica2.Nome = "Mil Maneiras";
musica2.Artista = "Veigh";
musica2.Duracao = 367;
musica2.Disponivel = false;

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();*/