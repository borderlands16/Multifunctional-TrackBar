using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface ITrackBar
    {
        int MinValue { get; set; }
        int MaxValue { get; set; }
        int Value { get; set; }

        void SetValue(int value);
        int GetValue();
    }

    public class TrackBar1 : ITrackBar
    {
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public int Value { get; set; }

        public TrackBar1(int minValue, int maxValue)
        {
            MinValue = minValue;
            MaxValue = maxValue;
            Value = minValue;
        }

        public int GetValue()
        {
            return Value;
        }

        public void SetValue(int value)
        {
            if(value >= MinValue && value <= MaxValue)
            {
                Value = value;
            }
            else
            {
                throw new Exception("Value out of range.");
            }
        }
    }

    public class ETrackBar
    {
        private List<ITrackBar> channels;
        private int num_channels;

        public Action<int, int> OnValueChanged;

        public ETrackBar(params ITrackBar[] channels)
        {
            this.channels = channels.ToList<ITrackBar>();
            num_channels = channels.Count();
        }

        public void SetChanelValue(int channel, int value)
        {
            if (channel < num_channels && channel >= 0)
            {
                channels[channel].SetValue(value);
                OnValueChanged?.Invoke(channel, value);
            }
            else
            {
                throw new Exception("Invalid channel index.");
            }
        }

        public int GetChannelValue(int channel)
        {
            if (channel < num_channels)
            {
                return channels[channel].GetValue();
            }
            else
            {
                throw new Exception("Invalid channel index.");
            }
        }

        public void SetAllChannelsValue(int value)
        {
            channels.ForEach((ITrackBar tb) => { tb.SetValue(value);  });
        }

        public List<ITrackBar> GetAllChannelsValue()
        {
            return channels;
        }

        public int GetMinValue(int channel)
        {
            return channels[channel].MinValue;
        }

        public int GetMaxValue(int channel)
        {
            return channels[channel].MaxValue;
        }
    }
}
