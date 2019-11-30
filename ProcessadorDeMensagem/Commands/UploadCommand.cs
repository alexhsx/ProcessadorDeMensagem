using System;

namespace ProcessadorDeMensagem.Commands
{
    public class UploadCommand : ICommandScript
    {
        private Message _message;

        public UploadCommand(Message message)
        {
            _message = message;
        }

        public void Execute()
        {
            Console.WriteLine($"UPLOAD REALIZADO COM SUCESSO - PARAMETROS: {_message.Filename} e {_message.Content}" );
        }

    }
}
