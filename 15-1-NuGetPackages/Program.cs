using NAudio.Wave.SampleProviders;
using NAudio.Wave;

namespace _15_1_NuGetPackages
{
    internal class Program
    {
        static void Main()
        {
            //NAudio
            var sine20Seconds = new SignalGenerator()
            {
                Gain = 0.2,
                Frequency = 500,
                Type = SignalGeneratorType.Sin
            }
            .Take(TimeSpan.FromSeconds(1));
            using (var wo = new WaveOutEvent())
            {
                wo.Init(sine20Seconds);
                wo.Play();
                while (wo.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(500);
                }
            }
        }
    }
}