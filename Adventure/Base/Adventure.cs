using Intents;
using OSRIC.DotNetCore.Characters.Base;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Base
{
    public class Adventure
    {

        World world = new World();
        Character character = new Character();

        public string Start()
        {
            return "Begin";
        }
        public string Continue()
        {
            return "Begin";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="direction">
        /// 0,-1 N
        /// 1,-1 NE
        /// 1,0 E
        /// 1,1 SE
        /// 0,1 S
        /// -1,1 SW
        /// -1,0 W
        /// -1,-1 NW
        /// </param>
        /// <param name="progress"></param>
        /// <param name="abort"></param>
        /// <returns></returns>
        public string Move(Point direction,Action progress, Action abort)
        {
            throw new NotImplementedException();

        }

        public string React(string? requested)
        {
            var intent = IntentFactory.Derive(requested);
            return IntentManager.ProcessEvent(world,character,intent);
        }
    }

 }
