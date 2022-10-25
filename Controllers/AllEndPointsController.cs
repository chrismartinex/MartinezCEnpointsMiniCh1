//Chris Martinez
//10/24/22
//All challenges with EndPoints
// Peer Review: Mark A Ramirez everything seems to work glad you fixed the thing i broke on accident.


using Microsoft.AspNetCore.Mvc;

namespace MartinezCEnpointsMiniCh1.Controllers;

[ApiController]
[Route("[controller]")]
public class AllEndPointsController : ControllerBase
{
  [HttpGet]
  [Route("Hello")]

  public string SayHello()
  {
   return "Hello Chris";
  }
 [HttpGet]
 [Route("AddingPlusTwo")]

 public int AddingNumbers ()

 {
  return 70 + 7;
 }
 [HttpGet]
 [Route("AskingAQuestion")]

 public string TellMeYourName()
 {
  return "My name is Chris";
 }
 [HttpGet]
 [Route("GreaterThanOrLessThan")]

 public string GreaterOrLess ()

 {
  return "70 is greater than 7";
 }
 [HttpGet]
 [Route("MadLib")]

 public string LetsPlayAgame ()

 {
  return "Once upon a time, on a rainy monday morning.I was goofing off, on the Yosemite National Park. When I ran into Jim Carrey. He asked what my name was?. I said my name was: Chris, and who my favorite superhero was, Superman.Jim Carrey look at me?!!, and laughed in my face. I started to cry. I soon realize the 5 hours of traveling to Usa, had affected my rationale, and I was Dreaming! so instead I asked the flight attended for more CheeseCake and took another hard sip of my good old IPA..";
 }
 [HttpGet]
 [Route("OddOrEvenNumbers")]

 public string EnterAValidNumber ()

 {
  return "Type in a number, and I will foretell you if its an even or odd number, go ahead try it?";
 }

 [HttpGet]
 [Route("ReverseDigits")]

 public string numberReverseIt ()

 {
  return "Type in a number, and I will reverse it for you? Go ahead,";

 }
 [HttpGet]
 [Route("Magic8Ball")]

 public string shakeAndTell ()

 {
  return "Ask me a question, and I will tell you what the future holds";

 }
 [HttpGet]
 [Route("RestaurantPicker")]

 public string bestPlaceEat ()

 {
  return "Don't Ever go hungry!, I will hand pick the best places for you to eat! Based on these three categories: Mexican, Asian, FastFood. Go ahead and select";
 
 }

}
