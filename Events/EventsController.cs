using Microsoft.AspNetCore.Mvc;

namespace SampleWeb.Events;

[ApiController]
[Route("api/[controller]")]
public class EventsController : ControllerBase
{
    [HttpGet]
    public async Task<YearWithEventsDto[]> GetAllEvents()
    {
        await Task.Delay(Random.Shared.Next(5));
        return new[]
        {
            new YearWithEventsDto(1968, new[]
            {
                new EventDto("Apollo 7", new DateOnly(1968, 10, 11),
                    "The first crewed Apollo space mission was Apollo 7. The three astronauts on Apollo 7 were Walter Schirra, Jr., Donn Eisele, and Walter Cunningham. They spent 10 days, 20 hours, 9 minutes, and 3 seconds in space. Apollo 7 completed 163 orbits around Earth, traveling 4,546,918.3 miles.",
                    false),
                new EventDto("Apollo 8", new DateOnly(1968, 12, 21),
                    "Apollo 8 was the first to fly around the Moon. The three astronauts on Apollo 8 were William Anders, Frank Borman, and James Lovell, Jr. They spent 6 days, 3 hours, and 42 seconds in space. Apollo 8 completed 10 orbits around Earth, traveling 579,606.9 miles.",
                    false)
            }),
            new YearWithEventsDto(1969, new[]
            {
                new EventDto("Apollo 9", new DateOnly(1969, 3, 3),
                    "Apollo 9 tested the Lunar Module in Earth orbit. The three astronauts on Apollo 9 were James McDivitt, David Scott, and Russell Schweickart. They spent 10 days, 1 hour, and 54 seconds in space. Apollo 9 completed 151 orbits around Earth, traveling 4,214,543 miles.",
                    false),
                new EventDto("Apollo 10", new DateOnly(1969, 5, 18),
                    "Apollo 10 was the rehearsal for the first Moon landing. The three astronauts on Apollo 10 were Thomas Stafford, John Young, and Eugene Cernan. They spent 8 days, 23 minutes, and 23 seconds in space. Apollo 10 completed 31 orbits around Earth, traveling 829,437.5 miles.",
                    false),
                new EventDto("Apollo 11", new DateOnly(1969, 7, 16),
                    "Apollo 11 was the first mission to land and walk on the Moon. The three astronauts on Apollo 11 were Neil Armstrong, Edwin “Buzz” Aldrin, and Michael Collins. Armstrong and Aldrin each spent a total of 2 hours and 32 minutes on the surface of the Moon. All three astronauts spent 8 days, 3 hours, 18 minutes, and 35 seconds in space and traveled a total of 953,054 miles. “The Eagle has landed…”— Astronaut Neil Armstrong as the Apollo 11 Lunar Module landed on the Moon. “…one small step for [a] man, one giant leap for mankind”— Astronaut Neil Armstrong as he stepped onto the Moon for the first time.",
                    true),
                new EventDto("Apollo 12", new DateOnly(1969, 11, 14),
                    "Apollo 12 was the first precision landing on the Moon. The three astronauts on Apollo 12 were Charles Conrad, Alan Bean, and Richard Gordon. Conrad and Bean each spent a total of 7 hours and 27 minutes on the surface of the Moon. All three astronauts spent 10 days, 4 hours, 36 minutes, and 25 seconds in space and traveled 952,354 miles.",
                    false)
            }),
            new YearWithEventsDto(1970, new[]
            {
                new EventDto("Apollo 13", new DateOnly(1970, 4, 11),
                    "Apollo 13 survived an oxygen tank explosion. The three astronauts on Apollo 13 were James Lovell, Jr., Fred Haise, Jr., and Jack Swigert. They spent 5 days, 22 hours, 54 minutes, and 41 seconds in space. Apollo 13 completed 1.5 orbits around Earth, traveling 622,268 miles. “Houston, we’ve had a problem…”—Astronaut Jack Swigert.",
                    true)
            }),
            new YearWithEventsDto(1971, new[]
            {
                new EventDto("Apollo 14", new DateOnly(1971, 1, 31),
                    "Apollo 14 was the first Moon landing in the lunar highlands. The three astronauts on Apollo 14 were Alan B. Shepard, Jr., Edgar D. Mitchell, and Stuart A. Roosa. Shepard and Mitchell each spent a total of 9 hours and 35 minutes on the surface of the Moon. All three astronauts spent 9 days and 2 seconds in space and traveled 1,150,321 miles.",
                    false),
                new EventDto("Apollo 15", new DateOnly(1971, 7, 26),
                    "Apollo 15 was the first mission to use the lunar rover. The three astronauts on Apollo 15 were David Scott, James Irwin, and Alfred Worden. Scott and Irwin each spent 18 hours and 40 minutes on the surface of the Moon. All three astronauts spent 12 days, 17 hours, and 12 minutes in space and traveled 1,274,137 miles.",
                    false)
            }),
            new YearWithEventsDto(1972, new[]
            {
                new EventDto("Apollo 16", new DateOnly(1972, 4, 16),
                    "Apollo 16 spent their mission exploring the lunar highlands. The three astronauts on Apollo 16 were John Young, Charles Duke, and Thomas Mattingly. Young and Duke each spent a total of 20 hours and 15 minutes on the surface of the Moon. All three astronauts spent 11 days, 1 hour, and 51 minutes in space and traveled 1,391,550 miles.",
                    false),
                new EventDto("Apollo 17", new DateOnly(1972, 12, 7),
                    "Apollo 17 was the last mission to walk on the Moon. The three astronauts were Eugene Cernan, Harrison Schmitt, and Ron Evans. Cernan and Schmitt each spent a total of 22 hours and 5 minutes on the surface of the Moon. All three astronauts spent 12 days, 13 hours, and 52 minutes in space and traveled 1,484,933.8 miles.",
                    false)
            })
        };
    }
}
