namespace State
{
    internal class StopVideo : StateVideo
    {
        public StateVideo Play(Video v)
        {
            Console.WriteLine("video play");
            return new PlayVideo();
        }

        public StateVideo Stop(Video v)
        {
            Console.WriteLine("video is already stop");
            return this;
        }
    }
}