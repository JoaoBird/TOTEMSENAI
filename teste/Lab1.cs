using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.WindowsAPICodePack.Shell.PropertySystem.SystemProperties.System;

namespace teste
{
    public class Laboratorio
    {
        
        public Laboratorio(string nome, int _id_lab) 
        {
            nome_lab = nome;
            id_lab = _id_lab;
            Medias = new List<Media>();

        }

        public int id_lab {get; set;}
        public string nome_lab { get; set; }
        public string caminho_img { get; set; }
        public string txt_laboratorio { get; set; }
        public List<Media> Medias { get; set; }
    }
    
    public class Media
    {
        public const string Imagem = "Imagem";
        public const string Video = "Video";

        private Media(string tipo, string nome, string path)
        {
            Tipo = tipo;
            Nome = nome;
            Path = path;
        }

        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Path { get; set; }

        public static Media CriarImagem(string nome, string path)
        {
            return new Media(Imagem, nome, path);
        }

        public static Media CriarVideo(string nome, string path)
        {
            return new Media(Video, nome, path);
        }
    }
}
