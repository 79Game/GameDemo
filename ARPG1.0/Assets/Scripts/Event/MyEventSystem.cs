using UnityEngine;
using System.Collections;

namespace MyLib
{
    public class MyEvent
    {
        public enum EventType
        {
            EventTrigger = 10000,//动画的Hit事件
            EventStart = 10001,
            SpawnParticle = 10002,
            EventMissileDie = 10003,
            EventEnd = 10004,
            AnimationOver = 10005, //Skill AnimationOver
        }
    }

    public class MyEventSystem
    {

    }
}
