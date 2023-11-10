// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1010 C# Examples

namespace DataModels;

/// <summary>
/// Models a Television object
/// </summary>
public class Television
{
    private ushort _channel;
    private byte _volume;
    private const ushort _MIN_CHANNEL = 2;
    private const ushort _MAX_CHANNEL = 50;

    /// <summary>
    /// Default constructor
    /// </summary>
    public Television()
    {
        _channel = _MIN_CHANNEL;
    }

    /// <summary>
    /// Television's channel
    /// </summary>
    public ushort Channel
    {
        set
        {
            if (value >= _MIN_CHANNEL && value <= _MAX_CHANNEL)
            {
                _channel = value;
            }
        }

        get { return _channel; }
    }

    /// <summary>
    /// Increments the Television's channel, or if the Television is currently equal to MAX_CHANNEL,
    /// will set the Television's channel to the MIN_CHANNEL
    /// </summary>
    public void ChannelUp()
    {
        if (_channel == _MAX_CHANNEL)
        {
            _channel = _MIN_CHANNEL;
        }
        else
        {
            _channel++;
        }
    }
    /// <summary>
    /// Decrements the Television's channel, or if the Television is currently equal to MIN_CHANNEL,
    /// will set the Television's channel to the MAX_CHANNEL
    /// </summary>
    public void ChannelDown()
    {
        if (_channel == _MIN_CHANNEL)
        {
            _channel = _MAX_CHANNEL;
        }
        else
        {
            _channel--;
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

        return $"TV-> current channel: {_channel}";
    }
}
