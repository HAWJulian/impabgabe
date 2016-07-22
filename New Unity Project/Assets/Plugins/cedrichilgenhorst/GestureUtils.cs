using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using Leap;
using System;
using uFrame.Attributes;

[ActionLibrary, uFrameCategory("Gestures")]
public static class GestureUtils  {


    
    private struct GestureAction
    {
        public readonly Gesture gesture;
        public readonly Action action;
        public readonly bool triggerLeft, triggerRight;

        public GestureAction(Gesture gesture, Action action, bool triggerLeft, bool triggerRight)
        {
            this.gesture = gesture;
            this.action = action;
            this.triggerLeft = triggerLeft;
            this.triggerRight = triggerRight;
        }
    };

    private static List<GestureAction> updatingGestures = new List<GestureAction>();

    private static IDictionary dictionary = new System.Collections.Generic.Dictionary<object, Gesture>();

    public static void registerUpdatingGesture(bool thumb, bool index, bool middle, bool fourth, bool fifth, Action action, bool triggerLeft, bool triggerRight)
    {
        updatingGestures.Add(new GestureAction(new Gesture(new bool[] {thumb,index,middle,fourth, fifth } ),action, triggerLeft, triggerRight));
    }

    public static void registerGesture(object key, bool thumb, bool index, bool middle, bool fourth, bool fifth)
    {
        dictionary.Add(key, new Gesture(new bool[] {thumb,index,middle,fourth,fifth}));
    }

    public static void isGestureSatisified(object key, Hand hand, Action yes, Action no)
    {
        if ((dictionary[key] as Gesture).isSatisfied(hand))
        {
            yes();
        }
        else
            no();
    }

    
    public static void update()
    {
        Frame frame = FrameUtils.getFrame();
        for(int i=0; i<updatingGestures.Count;i++)
        {
            GestureAction ga = updatingGestures[i];
             for(int j=0; j<frame.Hands.Count;j++)
            {
                Hand hand = frame.Hands[j];
                if(hand.IsLeft && ga.triggerLeft || hand.IsRight && ga.triggerRight)
                {
                    if(ga.gesture.isSatisfied(hand))
                    {
                        ga.action.Invoke();
                        continue;
                    }
                }
            }
        }
    }
}
