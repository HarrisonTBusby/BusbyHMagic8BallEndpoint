//Harrison Busby
//10/27/2022
//Magic 8 Ball Endpoints
//Peer reviewed by: Peer Review: Reed Goodwin- This is a truly well functioning 8ball that works just as a 8ball should, you input you question or phrase and it drops your fate! Code is clean.
//Good job Harrison :)




using Microsoft.AspNetCore.Mvc;

namespace BusbyHMagic8BallEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class Magic8BallController : ControllerBase
{

[HttpGet]
[Route("8Ball/{response}")]

public string Magic8Ball(string response){

Random random = new Random();
int newRandom = random.Next(0,5);

string[] MagicBall = {"No","Yes", "Maybe", "This will take further inspection", "Absolutely not."};

return $"{response}? The 8Ball says {MagicBall[newRandom]}";


}


}
