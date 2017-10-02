using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreNodeModels;
using Dynamo.Graph.Nodes;
using ProtoCore.AST.AssociativeAST;

namespace MEP.Toolkit
{
    [NodeName("Duct System Types")]
    [NodeDescription("Choose from a list of available duct system types")]
    [IsDesignScriptCompatible]
    public class DuctSystemSelector : DSDropDownBase
    {
        protected override SelectionState PopulateItemsCore(string currentSelection)
        {
            Items.Clear();

            var newItems = new List<DynamoDropDownItem>()
            {
                new DynamoDropDownItem("supply", 4),
                new DynamoDropDownItem("return", 3),
            };

            Items.Concat(newItems);
            SelectedIndex = 0;
            return SelectionState.Done;
        }


    }
}
