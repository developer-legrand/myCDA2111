namespace State
{
    public class PlayVideo : StateVideo
    {

        StateVideo StateVideo.Play(Video v)
        {
            Console.WriteLine("video is already play");
            return this;
        }

        StateVideo StateVideo.Stop(Video v)
        {
            Console.WriteLine("video stop");
            return new StopVideo();
        }
    }
}