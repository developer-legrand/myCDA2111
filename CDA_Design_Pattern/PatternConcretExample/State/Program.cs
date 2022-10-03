// See https://aka.ms/new-console-template for more information
using State;

Console.WriteLine("Hello, World!");

StopVideo sv = new StopVideo();
Video v = new Video(sv);

v.Play();
v.Play();
v.Stop();





