using ServerVideoAPI.Entity;

namespace ServerVideoAPI.Dtos
{
    public class ServerDTO
    {
        public string Name { get; set; }
        public string IpAddress { get; set; }
        public string Description { get; set; }

        // Conversão implícita de ServerDTO para Server
        public static implicit operator Server(ServerDTO dto)
            => new Server(dto.Name, dto.IpAddress, dto.Description);
    }
}
