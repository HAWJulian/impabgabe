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
    using Invert.Json;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using UniRx;
    using UnityEngine;
    
    
    [uFrame.Attributes.ComponentId(6)]
    [uFrame.Attributes.uFrameIdentifier("ae2092da-a4fb-4deb-a9ae-a4406d3ecac5")]
    public partial class SubMenuComponent : uFrame.ECS.EcsComponent {
        
        [UnityEngine.SerializeField()]
        private Int32 _index;
        
        private Subject<PropertyChangedEvent<Int32>> _indexObservable;
        
        private PropertyChangedEvent<Int32> _indexEvent;
        
        public override int ComponentId {
            get {
                return 6;
            }
        }
        
        public IObservable<PropertyChangedEvent<Int32>> indexObservable {
            get {
                return _indexObservable ?? (_indexObservable = new Subject<PropertyChangedEvent<Int32>>());
            }
        }
        
        public Int32 index {
            get {
                return _index;
            }
            set {
                Setindex(value);
            }
        }
        
        public virtual void Setindex(Int32 value) {
            SetProperty(ref _index, value, ref _indexEvent, _indexObservable);
        }
    }
}
