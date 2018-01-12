using UnityEngine;
using System.Collections;

namespace MyLib
{
    public class PhysicComponent : MonoBehaviour
    {

		//冲击技能接管了移动控制
		bool skillMove = false;
        public bool EnterSkillMoveState()
        {
            return false;
        }

        public void ExitSkillMove()
        {

        }
    }
}
