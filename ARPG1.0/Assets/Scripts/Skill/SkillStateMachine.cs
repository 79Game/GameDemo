using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace MyLib
{
    public class SkillStateMachine : MonoBehaviour
    {

        /// <summary>
        /// 默认技能状态机 存在时间 不超过5s 
        /// </summary>
        float lifeTime = 5;
        /// <summary>
        /// 所有技能运行层 
        /// </summary>
        List<GameObject> allRunners = new List<GameObject>();
        /// <summary>
        /// 技能状态机是否已经停止了 
        /// </summary>
        public bool isStop = false;
        /// <summary>
        /// 技能状态机初始位置 
        /// </summary>
        public Vector3 InitPos = Vector3.zero;

        //需要前摇时间的技能标记目标位置 记录当前攻击目标的位置
        public Vector3 MarkPos;
        //攻击者 攻击目标
        public GameObject attacker
        {
            get;
            set;
        }

        public GameObject target
        {
            get;
            set;
        }
        //技能相关数据
        public SkillFullInfo skillFullData
        {
            get;
            set;
        }

        public SkillDataConfig skillDataConfig
        {
            get;
            set;
        }
        public bool forwardSet = false;
        private Vector3 forwardDir;
        public void SetForwardDirection(Vector3 f)
        {
            forwardSet = true;
            forwardDir = f;
        }

        public int ownerLocalId = -1;
        //注册监听技能相关事件  攻击命中事件 子弹命中或者死亡 攻击动画结束
        static List<MyEvent.EventType> regEvt = new List<MyEvent.EventType>(){
            MyEvent.EventType.EventTrigger,
            MyEvent.EventType.EventMissileDie,
            MyEvent.EventType.AnimationOver,
        };


    }
}