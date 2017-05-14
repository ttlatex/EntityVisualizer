using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Collections.Generic;
using System.Windows.Forms;



namespace EntityVisualizer
{
    public class ListEntityVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            dynamic entity = objectProvider.GetObject();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EntityDialog(entity));
        }
    }
}
