using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore; //講義上沒有

namespace mod09API.Models;
public class MeetingRoom
{
    public int ID { get; set; }
    [Column(TypeName = "nvarchar(30)")]
    public required string Name { get; set; }
    public int Size { get; set; }
    public bool? Projector { get; set; }
    public bool? TV { get; set; }
}


// 加入DBContext類別
public class MeetingRoomContext : DbContext
{
    public MeetingRoomContext(
        DbContextOptions<MeetingRoomContext> options) : base(options)
        { }
    public DbSet<MeetingRoom> MeetingRooms { get; set; }
}

