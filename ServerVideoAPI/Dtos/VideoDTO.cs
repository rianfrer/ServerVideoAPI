using System.Text.Json.Serialization;
using ServerVideoAPI.Entity;

namespace ServerVideoAPI.Dtos
{
    public class VideoDTO
    {
        public string FileName { get; set; }

        
        public int ServerId { get; set; }  

        // Conversão implícita de VideoDTO para Video
        public static implicit operator Video(VideoDTO dto)
           => new Video(dto.FileName, dto.ServerId);
    }
}
