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
    using abgabe;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using UniRx;
    using UnityEngine;
    
    
    [uFrame.Attributes.EventId(2)]
    public partial class SubMenuSelectEvent : object {
        
        [UnityEngine.SerializeField()]
        private Int32 _index;
        
        [UnityEngine.SerializeField()]
        private GameObject _msc;
        
        public Int32 index {
            get {
                return _index;
            }
            set {
                _index = value;
            }
        }
        
        public GameObject msc {
            get {
                return _msc;
            }
            set {
                _msc = value;
            }
        }
    }
}