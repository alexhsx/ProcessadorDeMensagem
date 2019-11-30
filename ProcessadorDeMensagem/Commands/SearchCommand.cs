using System;

namespace ProcessadorDeMensagem.Commands
{
    public class SearchCommand : ICommandScript
    {
        private Message _message;

        public SearchCommand(Message message)
        {
            _message = message;
        }

        public void Execute()
        {
            Console.WriteLine($"LISTA DE ITEMS - PARAMETROS: {_message.Keywords} e {_message.Destination}" );
        }

    }
}
