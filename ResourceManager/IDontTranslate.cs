using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ResourceManager
{
    public interface IDontTranslate
    {
        bool CheckComponent(Component component);
    }
}
