using System.Drawing;
using System.Threading.Tasks;
using DiscoScript.Core.Attributes;
using Pastel;

namespace DiscoScript.Core.Native.Values
{
    public class Promise : INative, IInternalValue<Task>
    {
        public PromiseStatus Status => Helpers.TaskStatusToPromise(PromisedTask);

        public Task PromisedTask { get; }

        public Promise(Task promisedTask)
        {
            PromisedTask = promisedTask;
        }
        
        public bool Greater(INative b) => false;
        public bool Lesser(INative b) => false;

        private string GetStatusString()
        {
            return Status switch
            {
                PromiseStatus.Pending => "Pendiente".Pastel(Color.DimGray),
                PromiseStatus.Completed => "Completada".Pastel(Color.Green),
                PromiseStatus.Errored => "Error".Pastel(Color.Red),
                PromiseStatus.Canceled => "Cancelada".Pastel(Color.Aqua),
                _ => "?"
            };
        }

        public override string ToString()
        {
            return $"Promesa {{<{GetStatusString()}>}}";
        }
        
        [ShowAs("aTexto")]
        public Task<INative> ToString(Scope scope, params INative[] natives) =>
            Task.FromResult(new Text("Promesa").As<INative>());

        public Task GetInternalValue() => PromisedTask;
    }

    public enum PromiseStatus
    {
        [ShowAs("Pendiente")]
        Pending,
        [ShowAs("Completada")]
        Completed,
        [ShowAs("Cancelada")]
        Canceled,
        [ShowAs("Error")]
        Errored
    }
}