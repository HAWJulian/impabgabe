using UnityEngine;
using System.Collections;
using uFrame.Attributes;
using Leap;
using System;

[ActionLibrary, uFrameCategory("Hand")]
public static class HandUtils
{



    public static void getLeftHandIfNotNull(out Hand left, Action success)
    {
        Frame frame = FrameUtils.getFrame();
        for (int i = 0; i < frame.Hands.Count; i++)
        {
            if (frame.Hands[i].IsLeft)
            {
                left = frame.Hands[i];
                success.Invoke();
                return;
            }
        }

        left = null;
    }
    public static void getRightHandIfNotNull(out Hand right, Action success)
    {
        Frame frame = FrameUtils.getFrame();
        for (int i = 0; i < frame.Hands.Count; i++)
        {
            if (frame.Hands[i].IsRight)
            {
                right = frame.Hands[i];
                success.Invoke();
                return;
            }
        }

        right = null;
    }

    public static Vector getPalNormal(Hand hand)
    {
        return hand.PalmNormal;

    }


    public static Finger getFinger(int index, Hand hand)
    {
        return hand.Finger(index);
    }

    public static Vector getDirection(Hand hand)
    {

        return hand.Direction;
    }

    public static float getPinchDistance(Hand hand)
    {
        return hand.PinchDistance;
    }

    public static float getPinchStrength(Hand hand)
    {
        return hand.PinchStrength;
    }

    public static float getTimeVisible(Hand hand)
    {
        return hand.TimeVisible;
    }

    public static Vector getWristPosition(Hand hand)
    {
        return hand.WristPosition;
    }

    public static bool isLeft(Hand hand)
    {
        return hand.IsLeft;
    }

    public static bool isRight(Hand hand)
    {
        return hand.IsRight;

    }

    public static float getGrabAngle(Hand hand)
    {
        return hand.GrabAngle;
    }

    public static float getGrabStrength(Hand hand)
    {
        return hand.GrabStrength;
    }

    public static Arm getArm(Hand hand)
    {
        return hand.Arm;
    }




}
