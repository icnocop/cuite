using Microsoft.VisualStudio.TestTools.UITesting;
using TechTalk.SpecFlow;

namespace CUITe.IntegrationTests.NuGet
{
    [Binding]
    class CodedUITestBinding
    {
        /// <summary>
        /// Runs before each scenario block.
        /// </summary>
        [BeforeTestRun]
        public static void BeforeScenarioBlock()
        {
            // initialize Coded UI Test playback
            if (!Playback.IsInitialized)
            {
                Playback.Initialize();
            }

#if VS2010
            // Visual Studio 2010 doesn't have a Playback.PlaybackSettings.LoggerOverrideState property
#else
            // set playback settings
            Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.AllActionSnapshot;
#endif
        }

        /// <summary>
        /// Runs after each scenario block.
        /// </summary>
        [AfterTestRun]
        public static void AfterScenarioBlock()
        {
            if (Playback.IsInitialized)
            {
                // clean up Coded UI Test playback
                Playback.Cleanup();
            }
        }
    }
}
