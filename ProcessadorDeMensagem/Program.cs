using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProcessadorDeMensagem
{
    class Program
    {
        static void Main(string[] args)
        {
            var messages = JsonConvert.DeserializeObject<List<Message>>(@"[
                              { command: 'search', keywords: 'music mp3', destination: '100.22.11.25:8888' }
                             ,{ command: 'upload', filename: 'music.mp3', content: '[byte array]' }
                             ,{ command: 'execute', script: 'music.sh'}
                             ,{ command: 'neighbors', depth: 2, destination: '90.12.50.21:8975'}]");

            messages.ForEach(m =>
            {
                var invoker = new Invoker(m);
                invoker.ExecuteCommand();
            });

            Console.ReadKey();
        }
    }
}
