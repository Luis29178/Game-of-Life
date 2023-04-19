using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Life.Frames
{
    public class FrameManager
    {
        #region params
        public List<Frame> frames;
        private int _currentFrameIndex;
        public bool rewind;
        public bool stop;

        #endregion

        #region Props

        public int NbFrames { get { return frames.Count; } }

        public Frame CurrentFrame { get {

                if(frames.Count > 0)
                { 
                    return frames[CurrentFrameIndex]; 
                }
                else
                {
                    return null;
                }
            
            } }

        public bool NeedsNewFrame { get { return (CurrentFrameIndex == NbFrames - 1); } }




        public int CurrentFrameIndex
        {
            get { return _currentFrameIndex; }
            set
            {
                if(value >= 0 && value< NbFrames)
                {
                    _currentFrameIndex = value;
                }
            }
        }
        #endregion

        #region Constructor
        public FrameManager(int frameWidth, int frameHeight, bool rewind = false)
        {
            frames = new List<Frame>();
            _currentFrameIndex = 0;
            this.rewind = rewind;
            stop = false;
        }
        #endregion

        #region Functions

        public void AddFrame(Frame newFrame)
        {
            frames.Add(newFrame);
        }

        public void RemoveFrame(int index)
        {
            if(index < NbFrames)
            {
                frames.RemoveAt(index);
            }
        }

        public void CutAtIndex(int index)
        {
            frames.RemoveRange(index, frames.Count - (index + 1));
        }

        public void NextFrame()
        {
                CurrentFrameIndex = CurrentFrameIndex + 1; 
        }
        public void PrevFrame()
        {
            CurrentFrameIndex = CurrentFrameIndex - 1;
        }
        public void FirstFrame()
        {
            CurrentFrameIndex = 0;
        }
        public void LastFrame()
        {
            CurrentFrameIndex = NbFrames - 1;
        }
        public void SkipToFrame(int index)
        {
            if (index >= frames.Count)
            {
                CurrentFrameIndex = frames.Count;
            }
            else if (index < 0)
            {
                CurrentFrameIndex = 0;
            }
            else 
            { 
                CurrentFrameIndex = index;
            }
            
        }
        public void Play()
        {
            stop = false;
        }
        public void Pause()
        {
            stop = true;
        }
        public void Update()
        {
            if (!stop) 
            {
                if (!rewind)
                {
                    NextFrame();
                }
                else
                {
                    PrevFrame();
                }
            
            }
        }
        #endregion
    }
}
