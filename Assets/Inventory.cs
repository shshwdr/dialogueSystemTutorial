using PixelCrushers.DialogueSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    int appleCount = 1;
    void OnEnable()
    {
        Lua.RegisterFunction("getAppleCount", this, SymbolExtensions.GetMethodInfo(() => getAppleCount()));
        Lua.RegisterFunction("hasApple", this, SymbolExtensions.GetMethodInfo(() => hasApple()));
        Lua.RegisterFunction("changeAppleCount", this, SymbolExtensions.GetMethodInfo(() => changeAppleCount((double)0)));
    }

    void OnDisable()
    {
        Lua.UnregisterFunction("getAppleCount");
    }

    public int getAppleCount()
    {
        return appleCount;
    }
    public bool hasApple()
    {
        return appleCount>0;
    }
    public void changeAppleCount(double add)
    {
        appleCount += (int)add;
    }
}
