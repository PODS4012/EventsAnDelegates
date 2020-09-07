using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsAnDelegates
{
    class VideoEncoder
    {
        // 1- Define a delegate
        // 2- Define an event based on that delegate
        // 3- Raise the event

        // 1- Define a delegate
        //public delegate void VideoEncodedEventHandler(object source, EventArgs e);
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs e);

        // 2- Define an event based on that delegate
        //public event VideoEncodedEventHandler VideoEncoded;

        //EventHandler
        //EventHandler<TEventArgs>
        public event EventHandler<VideoEventArgs> VideoEncoded;

        //public event EventHandler VideoEncodedWithoutSendingAdditionalData;


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        // 3- Raise the event
        protected virtual void OnVideoEncoded(Video video)
        {
            //if ( VideoEncoded != null )
            //    VideoEncoded(this, EventArgs.Empty);

            // Refactored into this
            VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video });
        }
    }
}
