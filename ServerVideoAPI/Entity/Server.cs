namespace ServerVideoAPI.Entity
{

    // Classe que representa um servidor
    public class Server
    {
        public Server()
        {
            
        }
        public Server(string name, string ipAddress, string description) // Contrutor
        {

            this.Name = name;
            this.IpAddress = ipAddress;
            this.Description = description;
            
        }

        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string IpAddress { get; protected set; }
        public string Description { get; protected set; }

        public virtual IList<Video> Videos { get; protected set; } // Um servidor pode ter vários vídeos

    }
}
