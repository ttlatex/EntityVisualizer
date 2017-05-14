using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Windows.Forms;

namespace EntityVisualizer
{
    public class ListEntityVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            dynamic entity = objectProvider.GetObject();

            using (var dialog = new EntityDialog(entity))
            {
                dialog.StartPosition = FormStartPosition.CenterParent;
                dialog.ShowDialog();
            }
        }
    }
}
