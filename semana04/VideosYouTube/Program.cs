using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Olá, Mundo! Este é o Projeto VideosYouTube.");
        Video video1 = new Video("aprendendo C#", "Jonathan", 600);
        Video video2 = new Video("tutorial de programação", "white", 200);
        Video video3 = new Video("como ganhar dinheiro com programação", "Albert", 1200);

        video1.AdicionarComentario(new Comentario("jonathan", "muito bom, adorei"));
        video1.AdicionarComentario(new Comentario("white", "poderia durar mais"));
        video1.AdicionarComentario(new Comentario("Albert", "ganhando milhões no tigrinho"));

        video2.AdicionarComentario(new Comentario("Lucas", "Gostei muito!"));
        video2.AdicionarComentario(new Comentario("Mariana", "Muito didático!"));
        video2.AdicionarComentario(new Comentario("Paulo", "Ótima aula!"));

        video3.AdicionarComentario(new Comentario("Pedro", "Muito interessante!"));
        video3.AdicionarComentario(new Comentario("Fernanda", "Conteúdo excelente!"));
        video3.AdicionarComentario(new Comentario("Rafael", "Parabéns pelo vídeo!"));

        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.ExibirInformacoes();
            Console.WriteLine("________________________");
        }
    }
}