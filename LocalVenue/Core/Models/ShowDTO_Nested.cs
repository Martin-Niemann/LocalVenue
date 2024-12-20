using LocalVenue.Core.Enums;

namespace LocalVenue.Core.Models;

public class ShowDTO_Nested
{
    public long ShowId { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public Genre Genre { get; set; }

    public ICollection<TicketDTO> Tickets { get; set; } = new List<TicketDTO>();

}