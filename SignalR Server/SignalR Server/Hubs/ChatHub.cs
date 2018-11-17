
using Microsoft.AspNet.SignalR;


namespace ProfessusAppAdminWeb.Hubs
{
    public class ChatHub : Hub
    {
        public void EnviarMensagem(string apelido, string mensagem)
        {
//            Clients.All.publicarMensagem(apelido, mensagem);
            Clients.All.publicarMensagem(mensagem);

        }
    }
}