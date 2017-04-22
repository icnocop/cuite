using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITe.IntegrationTests.ObjectRecorder.Features
{
#if DEBUG
    [DeploymentItem(@".\CUITe_ObjectRecorder\bin\Debug\CUITe_ObjectRecorder.exe")]
#else
    [DeploymentItem(@".\CUITe_ObjectRecorder\bin\Release\CUITe_ObjectRecorder.exe")]
#endif
    public partial class RecordingFeature
    {
    }
}
