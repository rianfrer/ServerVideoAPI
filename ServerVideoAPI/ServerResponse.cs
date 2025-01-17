using ServerVideoAPI.Entity;

namespace ServerVideoAPI
{
    public class ServerResponse
    {

        public int Id { get; set; }
        public string FileName { get; set; }
        public string UploadDate { get; set; }
        public int ServerId { get; set; } // Chave estrangeira para o servidor

    }
}
