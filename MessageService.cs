using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAnDelegates
{
    class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: Sending an message..." + e.Video.Title);
        }
    }
}
