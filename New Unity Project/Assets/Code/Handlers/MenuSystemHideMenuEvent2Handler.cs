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
    using UnityEngine;
    
    
    public class MenuSystemHideMenuEvent2Handler {
        
        public SubMenuComponent Group;
        
        private abgabe.HideMenuEvent _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private UnityEngine.GameObject ActionNode42_obj = default( UnityEngine.GameObject );
        
        private bool ActionNode42_state = default( System.Boolean );
        
        private bool BoolNode43 = false;
        
        public abgabe.HideMenuEvent Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public uFrame.ECS.EcsSystem System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public virtual System.Collections.IEnumerator Execute() {
            ActionNode42_obj = Group.gameObject;
            ActionNode42_state = BoolNode43;
            // ActionNode
            while (this.DebugInfo("d7318fd2-3da5-4dd8-bfa4-db92d34c7bce","d0332702-b94e-4430-b85e-7d0060a07905", this) == 1) yield return null;
            // Visit GameObjectUtils.setActive
            GameObjectUtils.setActive(ActionNode42_obj, ActionNode42_state);
            yield break;
        }
    }
}