using System;

namespace Simple.HttpPatch
{
    [AttributeUsage(AttributeTargets.Property)]
    public class PatchIgnoreNullAttribute : Attribute
    {
    }
}
