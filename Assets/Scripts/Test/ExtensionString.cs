using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public static class ExtensionString
    {
        public static String ExtensionStr(this string str)
        {
            int count = str.Length;
            string message = ("Количество знаков в строке: " + count);
            return message;
        }
    }
}