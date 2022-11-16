namespace SampleWeb.Events;

public record YearWithEventsDto(int Year, EventDto[] Events);
public record EventDto(string Title, DateOnly Date, string Description, bool Noteful);
