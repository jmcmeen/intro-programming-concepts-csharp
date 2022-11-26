/// File: Television.cs
/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: C# Examples
namespace CISP1010
{
    /// <summary>
    /// Models a Television object
    /// </summary>
    internal class Television
    {
        private ushort channel;
        private byte volume;
        private const ushort MIN_CHANNEL = 2;
        private const ushort MAX_CHANNEL = 50;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Television()
        {
            channel = MIN_CHANNEL;
        }

        /// <summary>
        /// Sets the Television channel if it is between a valid range, otherwise does nothing
        /// This is a more of a classic OOP design and a property could be used instead
        /// </summary>
        /// <param name="channel">A channel number</param>
        public void SetChannel(ushort channel)
        {
            if(channel >= MIN_CHANNEL && channel <= MAX_CHANNEL) 
            { 
                this.channel = channel;
            }
        }

        /// <summary>
        /// Here we accomplish the same thing as SetChannel above using a property
        /// to expose a private member, but also get the convencience of creating
        /// a get property in the same block.
        /// </summary>
        public ushort Channel
        {
            set
            {
                if (channel >= MIN_CHANNEL && channel <= MAX_CHANNEL)
                {
                    this.channel = value;
                }
            }

            get { return channel; }
        }

        /// <summary>
        /// Increments the Television's channel, or if the Television is currently equal to MAX_CHANNEL,
        /// will set the Television's channel to the MIN_CHANNEL
        /// </summary>
        public void ChannelUp()
        {
            if(this.channel == MAX_CHANNEL)
            {
                this.channel = MIN_CHANNEL;
            }
            else
            {
                this.channel++;
            }
        }
        /// <summary>
        /// Decrements the Television's channel, or if the Television is currently equal to MIN_CHANNEL,
        /// will set the Television's channel to the MAX_CHANNEL
        /// </summary>
        public void ChannelDown()
        {
            if(this.channel == MIN_CHANNEL)
            {
                this.channel = MAX_CHANNEL;
            }
            else
            {
                this.channel--;
            }
        }

        /// <summary>
        /// Creates a string representation of the Television
        /// </summary>
        /// <returns>The string representation of the Television</returns>
        override public string ToString()
        {
            //could also use the public get property Channel
            //return $"TV-> current channel: {Channel}";

            return $"TV-> current channel: {channel}";
        }
    }
}
