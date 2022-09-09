using Newtonsoft.Json.Linq;
using SwansonWestConvo;

var convo = new Methods();

for (int i = 0; i < 6; i++)
{
    convo.SwansonQuote();
    Thread.Sleep(2500);
    convo.WestQuote();
    Thread.Sleep(2500);
}


