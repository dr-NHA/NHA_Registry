
using Microsoft.Win32;

namespace NHA_Registry{
public static class RegistryUtil{

public static uint GetRegistryUInt32Value(string Path,string ValueName,uint Default) =>
(uint)Registry.GetValue(Path,ValueName,Default);   

        
public static string GetRegistryStringValue(string Path,string ValueName,string Default) =>
(string)Registry.GetValue(Path,ValueName,Default);   

}

}