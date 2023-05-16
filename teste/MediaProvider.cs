
using System.Collections.Generic;
using System.IO;
using teste;

namespace Teste
{
    public static class MediaProvider
    {
        public static IEnumerable<Media> GetImagens(Laboratorio laboratorio)//enumerar os itens
        {
            string folderPath = Path.Combine("imagens", laboratorio.id_lab.ToString());//combinar nome e caminho para puxar dados
            if (!Directory.Exists(folderPath))//se nao existir
            {
                yield break;
            }

            string[] imagens = Directory.GetFiles(folderPath);
            foreach (string imagem in imagens)//se existir
            {
                yield return Media.CriarImagem("imagem", imagem);
            }
        }

        public static IEnumerable<Media> GetVideos(Laboratorio laboratorio)
        {
            string folderPath = Path.Combine("videos", laboratorio.id_lab.ToString());
            if (!Directory.Exists(folderPath))
            {
                yield break;
            }

            string[] videos = Directory.GetFiles(folderPath, "*.mp4");
            foreach (string video in videos)
            {
                yield return Media.CriarVideo("video", video);
            }
        }
    }
}
