
namespace Core
{
    public class BaseObject : System.Object
    {
        private int instanceId = Core.Utils.Utils.GenID();

        public int GetPid() { return instanceId; }

    }

}
