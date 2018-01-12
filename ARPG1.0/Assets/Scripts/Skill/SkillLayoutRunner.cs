using UnityEngine;
using System.Collections;

namespace MyLib
{

    public class SkillLayoutRunner : MonoBehaviour
    {

        public SkillStateMachine stateMachine
        {
            get;
            set;
        }

        public SkillDataConfig.EventItem Event
        {
            get;
            set;
        }
        public MyEvent triggerEvent;

        public void DoDamage(GameObject g)
        {

        }

        //玩家先在处于一个Skill状态 玩家先在处于一个Skill状态 技能时间1s钟 玩家才能结束状态
        public bool MoveOwner(Vector3 position, float speed)
        {
            return true;
        }
    }
}