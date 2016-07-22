// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace abgabe {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.Kernel;
    using UniRx;
    
    
    public partial class NewGroupNodeGroup : ReactiveGroup<NewGroupNode> {
        
        private IEcsComponentManagerOf<LeftHandComponent> _LeftHandComponentManager;
        
        private int lastEntityId;
        
        private LeftHandComponent LeftHandComponent;
        
        public IEcsComponentManagerOf<LeftHandComponent> LeftHandComponentManager {
            get {
                return _LeftHandComponentManager;
            }
            set {
                _LeftHandComponentManager = value;
            }
        }
        
        public override System.Collections.Generic.IEnumerable<UniRx.IObservable<int>> Install(uFrame.ECS.IComponentSystem componentSystem) {
            LeftHandComponentManager = componentSystem.RegisterComponent<LeftHandComponent>();
            yield return LeftHandComponentManager.CreatedObservable.Select(_=>_.EntityId);;
            yield return LeftHandComponentManager.RemovedObservable.Select(_=>_.EntityId);;
        }
        
        public override bool Match(int entityId) {
            lastEntityId = entityId;
            if ((LeftHandComponent = LeftHandComponentManager[entityId]) == null) {
                return false;
            }
            return true;
        }
        
        public override NewGroupNode Select() {
            var item = new NewGroupNode();;
            item.EntityId = lastEntityId;
            item.LeftHandComponent = LeftHandComponent;
            return item;
        }
    }
}