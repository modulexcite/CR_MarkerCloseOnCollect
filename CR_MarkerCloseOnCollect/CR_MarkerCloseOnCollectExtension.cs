using System.ComponentModel.Composition;
using DevExpress.CodeRush.Common;

namespace CR_MarkerCloseOnCollect
{
  [Export(typeof(IVsixPluginExtension))]
  public class CR_MarkerCloseOnCollectExtension : IVsixPluginExtension { }
}