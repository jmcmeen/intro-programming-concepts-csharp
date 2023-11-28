// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1010 C# Examples

using DataModels;
using NAudio.Wave.SampleProviders;
using NAudio.Wave;

namespace _15_2_ToxicNAudio;

/// <summary>
/// Demonstrates using arrays of objects and the NAudio NuGet package
/// which can generate audio signals
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        //Create an array for note references
        Note[] toxicNotes = new Note[12];

        //Instantiate objects for each note reference to point to 
        toxicNotes[0] = new Note(523, 200, 0);
        toxicNotes[1] = new Note(523, 200, 0);
        toxicNotes[2] = new Note(622, 100, 0);
        toxicNotes[3] = new Note(587, 100, 0);
        toxicNotes[4] = new Note(523, 100, 0);
        toxicNotes[5] = new Note(587, 100, 0);
        toxicNotes[6] = new Note(622, 400, 600);
        toxicNotes[7] = new Note(1369, 500, 0);
        toxicNotes[8] = new Note(1174, 500, 0);
        toxicNotes[9] = new Note(1244, 200, 0);
        toxicNotes[10] = new Note(1174, 200, 0);
        toxicNotes[11] = new Note(1046, 250, 0);

        //Play the notes!
        PlayNotes(toxicNotes);
    }

    /// <summary>
    /// Plays each note in an array of notes using Console.Beep
    /// </summary>
    /// <param name="notes">The notes to play</param>
    static void PlayNotes(Note[] notes)
    {
        //Create an array of ISampleProvider the same length as notes
        ISampleProvider[] sampleProviders = new ISampleProvider[notes.Length];

        SignalGenerator signalGenerator;

        for (int i = 0; i < sampleProviders.Length; i++)
        {
            signalGenerator = new SignalGenerator()
            {
                Gain = 0.2,
                Frequency = notes[i].Frequency,
                Type = SignalGeneratorType.Sin
            };

            sampleProviders[i] = signalGenerator.Take(TimeSpan.FromMilliseconds(notes[i].Duration));
        }

        WaveOutEvent wo = new WaveOutEvent();

        for (int i = 0; i < sampleProviders.Length; i++)
        {
            wo.Init(sampleProviders[i]);
            wo.Play();
            while (wo.PlaybackState == PlaybackState.Playing)
            {
                Thread.Sleep(1);
            }

            Thread.Sleep(notes[i].PostPauseDuration);
        }
    }
}
