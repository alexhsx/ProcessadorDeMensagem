using System;

namespace ProcessadorDeMensagem.Commands
{
    public class ExecuteCommand : ICommandScript
    {
        private Message _message;

        public ExecuteCommand(Message message)
        {
            _message = message;
        }

        public void Execute()
        {
            Console.WriteLine($"PROGRAMA EXECUTADO - NOME DO PROGRAMA: {_message.Script}" );
        }

    }
}
