using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LessonA.DayThree
{
    internal class MediaContent
    {
        public virtual void StartPlayingContent()
        {
            Console.WriteLine("start");
        }
        public virtual void StopPlayingContent()
        {
            Console.WriteLine("stop");
        }
        public virtual void PausePlayingContent()
        {
            Console.WriteLine("pause");
        }
        public virtual void ContinuePlayingContent()
        {
            Console.WriteLine("continue");
        }
        public override string ToString()
        {
            return "ott";
        }
    }
    //end of mediacontent class
    internal class AudioContent :  MediaContent
    {
            public override sealed void StartPlayingContent()//using virtual becasue we use override in these method key word add virutual in method partent class
            {
                Console.WriteLine("start from audio");//sealed is used virtual comment to sealed
            }
            //public override string ToString()
            //{
                  
            //    return "audiocontent";
            //}

    }
    //end of audiocontent class
    internal class VideoContent : AudioContent
    {
        //public override void StartPlayingContent()
        //{
        //    Console.WriteLine("start from video");
        //}

    }
    internal class MediaTester
    {
        public static void TestOne()
        {

        }
    }
    // end of mediatester class
}
