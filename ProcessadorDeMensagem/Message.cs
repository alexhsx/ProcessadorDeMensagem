using ProcessadorDeMensagem.Commands;

namespace ProcessadorDeMensagem
{
    public class Message
    {
        public string Command { get; set; }
        public string Keywords { get; set; }
        public string Destination { get; set; }
        public string Filename { get; set; }
        public string Content { get; set; }
        public string Script { get; set; }
        public string Depth { get; set; }
    }
}
