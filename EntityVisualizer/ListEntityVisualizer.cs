using Microsoft.VisualStudio.DebuggerVisualizers;
using MsgPack;
using MsgPack.Serialization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EntityVisualizer
{
    public class ListEntityVisualizerObjectSource : VisualizerObjectSource
    {
        /// <summary>
        /// シリアライズを行なう
        /// </summary>
        public override void GetData(object target, Stream outgoingData)
        {
            var context = new SerializationContext();
            context.SerializationMethod = SerializationMethod.Map;

            var serializer = MessagePackSerializer.Get(target.GetType(), context);

            serializer.Pack(outgoingData, target);
            outgoingData.Position = 0;
        }
    }

    public class ListEntityVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            // Dictionary<object, ocbect>[]へのデシリアライズ
            var rawObject = Unpacking.UnpackObject(objectProvider.GetData());
            var entity = rawObject
                .AsList()
                .Select(x => x.AsDictionary())
                .Select(x => x.ToDictionary(y => y.Key.ToString(), y => y.Value.ToObject()))
                .ToArray();

            using (var dialog = new EntityDialog(entity))
            {
                dialog.StartPosition = FormStartPosition.CenterParent;
                dialog.ShowDialog();
            }
        }
    }
}
