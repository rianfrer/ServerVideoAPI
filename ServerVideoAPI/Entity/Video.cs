namespace ServerVideoAPI.Entity
{
    public class Video
    {

        public Video()
        {
            
        }
        public Video(string fileName, int serverId)
        {

            FileName = fileName;
            ServerId = serverId;
            UploadDate = DateTime.Now.ToString("dd-MM-yyyy");
            
        }

        public int Id { get; protected set; }
        public string FileName { get; protected set; }
        public string UploadDate { get; protected set; }
        public int ServerId { get; protected set; } // Chave estrangeira para o servidor
        public virtual Server Server { get; protected set; }  // Navegação para o servidor associado
    }
}
