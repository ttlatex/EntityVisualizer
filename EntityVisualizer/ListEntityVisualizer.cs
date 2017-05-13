using Microsoft.VisualStudio.DebuggerVisualizers;

namespace EntityVisualizer
{
    public class ListEntityVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            var entity = objectProvider.GetObject();

            // Here is where you would show the visualizer and deserialize
            // Make sure the object is replacable before you try to replace 
            // it. Otherwise, you will get an exception.
            if (objectProvider.IsObjectReplaceable)
            {
                // Reserialize here
                //objectProvider.ReplaceData(myNewStream);
            }
        }
        // Other class methods would be here.
    }
}
