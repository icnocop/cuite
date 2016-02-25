using System;
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a video control for web page user interface (UI) testing.
    /// </summary>
    public class HtmlVideo : HtmlControl<CUITControls.HtmlVideo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlVideo"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlVideo(By searchConfiguration = null)
            : this(new CUITControls.HtmlVideo(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlVideo"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlVideo(CUITControls.HtmlVideo sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the value of autoplay attribute of the media.
        /// </summary>
        public bool AutoPlay
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.AutoPlay;
            }
        }

        /// <summary>
        /// Gets the current source of the media.
        /// </summary>
        public string CurrentSrc
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.CurrentSrc;
            }
        }

        /// <summary>
        /// Gets the current playing time of the media.
        /// </summary>
        public TimeSpan CurrentTime
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.CurrentTime;
            }
        }

        /// <summary>
        /// Gets the current playing time of the media as string.
        /// </summary>
        public string CurrentTimeAsString
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.CurrentTimeAsString;
            }
        }

        /// <summary>
        /// Gets the duration of the media.
        /// </summary>
        public TimeSpan Duration
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Duration;
            }
        }

        /// <summary>
        /// Gets the duration of the media as string.
        /// </summary>
        public string DurationAsString
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.DurationAsString;
            }
        }

        /// <summary>
        /// Gets the ended state of the media.
        /// </summary>
        public bool Ended
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Ended;
            }
        }

        /// <summary>
        /// Gets the value of loop attribute of the media.
        /// </summary>
        public bool Loop
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Loop;
            }
        }

        /// <summary>
        /// Gets the muted state of the media.
        /// </summary>
        public bool Muted
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Muted;
            }
        }

        /// <summary>
        /// Gets the paused state of the media.
        /// </summary>
        public bool Paused
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Paused;
            }
        }

        /// <summary>
        /// Gets the playback rate of the media.
        /// </summary>
        public float PlaybackRate
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.PlaybackRate;
            }
        }

        /// <summary>
        /// Gets the value of poster attribute of the video.
        /// </summary>
        public string Poster
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Poster;
            }
        }

        /// <summary>
        /// Gets the ready state value of the media.
        /// </summary>
        public int ReadyState
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.ReadyState;
            }
        }

        /// <summary>
        /// Gets the seeking state of the media.
        /// </summary>
        public bool Seeking
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Seeking;
            }
        }

        /// <summary>
        /// Gets the value of src attribute of the media.
        /// </summary>
        public string Src
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Src;
            }
        }

        /// <summary>
        /// Gets the height of the video.
        /// </summary>
        public int VideoHeight
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.VideoHeight;
            }
        }

        /// <summary>
        /// Gets the width of the video.
        /// </summary>
        public int VideoWidth
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.VideoWidth;
            }
        }

        /// <summary>
        /// Gets the current volume of the media.
        /// </summary>
        public float Volume
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Volume;
            }
        }
    }
}