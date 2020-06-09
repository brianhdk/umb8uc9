using System.IO;
using Ucommerce.EntitiesV2;
using Ucommerce.Pipelines;

namespace Relewise.Plugins.UCommerce.Pipelines
{
    public class MyPipelineTask : IPipelineTask<PurchaseOrder>
    {
        public PipelineExecutionResult Execute(PurchaseOrder subject)
        {
            string s = "";

            File.WriteAllText(@"c:\tmp\basket.txt", "test");

            return PipelineExecutionResult.Success;
        }
    }
}