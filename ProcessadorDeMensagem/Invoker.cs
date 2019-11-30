using ProcessadorDeMensagem.Commands;
using System;

namespace ProcessadorDeMensagem
{
   public class Invoker
    {
        Message _message;
        public Invoker(Message message)
        {
            _message = message;
        }

        public void SetMessage(Message message)
        {
            _message = message;
        }

        public void ExecuteCommand()
        {
            ICommandScript command;

            switch (_message.Command)
            {
                case "search":
                    command = new SearchCommand(_message);
                    break;
                case "upload":
                    command = new UploadCommand(_message);
                    break;
                case "execute":
                    command = new ExecuteCommand(_message);
                    break;
                case "neighbors":
                    command = new NeighborsCommand(_message);
                    break;
                default:
                    throw new EntryPointNotFoundException("Comando não encontrado");
            }

            command.Execute();
        }
    }
}
