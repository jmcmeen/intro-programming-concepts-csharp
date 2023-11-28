// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1010 C# Examples

namespace DataModels
{
    /// <summary>
    /// Models a musical note
    /// </summary>
    public class Note
    {
        /// <summary>
        /// Note frequency
        /// </summary>
        public int Frequency { get; set; }  

        /// <summary>
        /// Duration of note in milliseconds
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Post note pause in milliseconds
        /// </summary>
        public int PostPauseDuration { get; set; }

        /// <summary>
        /// Paramterized constructor
        /// </summary>
        /// <param name="frequency">frequency in milliseconds</param>
        /// <param name="duration">duration in milliseconds</param>
        /// <param name="postPauseDuration">post note pause in milliseconds</param>
        public Note (int frequency, int duration, int postPauseDuration)
        {
            Frequency = frequency;
            Duration = duration;
            PostPauseDuration = postPauseDuration;
        }
    }
}
