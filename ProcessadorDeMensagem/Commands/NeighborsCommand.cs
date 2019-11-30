using System;

namespace ProcessadorDeMensagem.Commands
{
    public class NeighborsCommand : ICommandScript
    {
        private Message _message;

        public NeighborsCommand(Message message)
        {
            _message = message;
        }

        public void Execute()
        {
            Console.WriteLine($"LISTA DE ITEMS - PARAMETROS: {_message.Keywords} e {_message.Destination}" );
        }

    }
}
