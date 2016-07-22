using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using uFrame.Attributes;
using System;
using Leap;

[ActionLibrary, uFrameCategory("Complex Gesture")]
public static class ComplexGestureUtils
{


    private struct ComplexGestureAction
    {
        public readonly ComplexGesture gesture;
        public readonly Action action;
        public readonly bool triggerLeft, triggerRight;

        public ComplexGestureAction(ComplexGesture gesture, Action action, bool triggerLeft, bool triggerRight)
        {
            this.gesture = gesture;
            this.action = action;
            this.triggerLeft = triggerLeft;
            this.triggerRight = triggerRight;
        }
    };

    private static List<ComplexGestureAction> updatingGestures = new List<ComplexGestureAction>();


    private static IDictionary dictionary = new System.Collections.Generic.Dictionary<object, ComplexGesture>();


    public static ComplexGesture createComplexGesture()
    {

        return new ComplexGesture();
    }

    public static ComplexGesture addComplexFingerState(ComplexGesture gesture, bool first, bool second, bool third, bool fourth, bool fifth)
    {
        ComplexFingerState fingerState = new ComplexFingerState(new bool[] { first, second, third, fourth, fifth });
        gesture.addCondition(fingerState);
        return gesture;
    }

    public static ComplexGesture addComplexPalmWidth(ComplexGesture gesture, float min, float max)
    {
        ComplexPalmWidth palmWidth = new ComplexPalmWidth(min, max);
        gesture.addCondition(palmWidth);
        return gesture;
    }

    public static ComplexGesture addComplexPinchDistance(ComplexGesture gesture, float min, float max)
    {
        ComplexPinchDistance distance = new ComplexPinchDistance(min, max);
        gesture.addCondition(distance);
        return gesture;
    }

    public static ComplexGesture addComplexPinchStrength(ComplexGesture gesture, float min, float max)
    {
        ComplexPinchStrength strength = new ComplexPinchStrength(min, max);
        gesture.addCondition(strength);
        return gesture;
    }

    public static ComplexGesture addComplexGrabStrength(ComplexGesture gesture, float min, float max)
    {
        ComplexGrabStrength strength = new ComplexGrabStrength(min, max);
        gesture.addCondition(strength);
        return gesture;
    }

    public static ComplexGesture addComplexGrabAngle(ComplexGesture gesture, float min, float max)
    {
        ComplexGrabAngle angle = new ComplexGrabAngle(min, max);
        gesture.addCondition(angle);
        return gesture;
    }


    public static void isComplexGestureSatisfied(object key, Leap.Hand hand, Action yes, Action no)
    {
        ComplexGesture gesture = dictionary[key] as ComplexGesture;
        if (gesture.isSatisfied(hand))
        {
            yes();
        }
        else
        {
            no();
        }
    }

    public static void registerComplexGesture(ComplexGesture gesture, object key)
    {
        dictionary.Add(key, gesture);
    }

    public static void registerUpdatingGesture(ComplexGesture gesture, bool triggerLeft, bool triggerRight, Action onDetect)
    {
        updatingGestures.Add(new ComplexGestureAction(gesture, onDetect, triggerLeft, triggerRight));
    }

    public static void update()
    {
        Frame frame = FrameUtils.getFrame();
        for (int i = 0; i < updatingGestures.Count; i++)
        {
            ComplexGestureAction ga = updatingGestures[i];
            for (int j = 0; j < frame.Hands.Count; j++)
            {
                Hand hand = frame.Hands[j];
                if (hand.IsLeft && ga.triggerLeft || hand.IsRight && ga.triggerRight)
                {
                    if (ga.gesture.isSatisfied(hand))
                    {
                        ga.action.Invoke();
                        continue;
                    }
                }
            }
        }
    }







}
