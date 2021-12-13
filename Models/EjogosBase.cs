using System.IO;

namespace E_JOGOS.Models
{
    public class EjogosBase
    {
        // Função para criar a pasta e o arquivo

        //String path é o parametro da função, que terá o caminho para análise.
        public void CreateFolderAndFile(string path)
        {
            // Pasta / arquivo.csv

            string folder = path.Split('/')[0]; //Recebe nome da pasta.
            string file = path.Split('/')[1]; //recebe nome do arquivo.

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (!File.Exists(file))
            {
                File.Create(path);
            }
        }
    }
}
