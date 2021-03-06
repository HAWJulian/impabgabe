using Invert.Data;
using Invert.Json;

namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core;
    using Invert.Core.GraphDesigner;
    
    
    public class SequenceContainerNode : SequenceContainerNodeBase, ISequenceNode, ICodeOutput
    {
        private string _startActionId;

        [JsonProperty, KeyProperty]
        public string StartActionId
        {
            get
            {
                
                return _startActionId;
            }
            set
            {
              
                this.Changed("StartActionId", ref _startActionId, value);
            }
        }

        private SequenceItemNode _startAction;


        public virtual bool CanGenerate
        {
            get { return true; }
        }

        public virtual string HandlerMethodName
        {
            get { return this.Name; }
        }

        //  public virtual IEnumerable<IFilterInput> FilterInputs { get; }
      //  public string EventType { get; set; }
        public virtual void Accept(ISequenceVisitor csharpVisitor)
        {
            csharpVisitor.Visit(StartNode);
        }

        public override IEnumerable<string> ForeignKeys
        {
            get
            {
                yield return GraphId;
                yield return StartActionId;
            }
        }

        public SequenceItemNode StartNode
        {
            get
            {
                return _startAction ?? (_startAction =  Repository.GetById<SequenceItemNode>(StartActionId) ?? this.OutputTo<SequenceItemNode>() ?? FilterNodes.OfType<SequenceItemNode>().FirstOrDefault(p => p != this));
            }
            set
            {
                _startAction = value;
                StartActionId = value.Identifier;
         
          
            }

        }

   
    }
    
    public partial interface ISequenceContainerConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
}
