using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.IBase.I_Core;

namespace ZZHMHN.IBase.Common
{
    public class Ext
    {
        public static T SetScence<T>(T obj,IScene scene) where T : ISceneGet
        {
            obj.Scene = scene;
            return obj;
        }
    }
}
