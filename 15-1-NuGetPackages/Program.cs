using NAudio.Wave.SampleProviders;
using NAudio.Wave;

namespace _15_1_NuGetPackages
{
    internal class Program
    {
        static void Main()
        {

        }

        public static void Play()
        {
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

        public static void Play2()
        {
            SignalGenerator sg = new SignalGenerator()
            {
                Gain = 0.2,
                Frequency = 500,
                Type = SignalGeneratorType.Sin
            };

            ISampleProvider sampleProvider = sg.Take(TimeSpan.FromSeconds(1));

            WaveOutEvent wo = new WaveOutEvent();
            wo.Init(sampleProvider);
            wo.Play();
            while (wo.PlaybackState == PlaybackState.Playing)
            {
                Thread.Sleep(500);
            }
        }
    }
}