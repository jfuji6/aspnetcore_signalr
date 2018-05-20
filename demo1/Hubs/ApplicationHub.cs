using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace demo1
{
    public class ApplicationHub : Hub
    {
        public async Task Send(string message)
        {
              await  Clients.All.SendAsync("Recieve", new Messsage
              {
                  Data = message
              });
        }
            class Messsage
        {
            public string Data  {get; set;}
        }
    }


}