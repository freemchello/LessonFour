using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class ListT : MonoBehaviour
    {
        private List<int> _list7;
        private void Awake()
        {
            _list7 = new List<int>();

            _list7.Add(8);
            _list7.Add(7);
            _list7.Add(7);
            _list7.Add(7);
            _list7.Add(1);
            _list7.Add(1);
            _list7.Add(3);
            _list7.Add(8);
            _list7.Add(2);
            _list7.Add(2);

            CountElements(_list7);
        }
        private void CountElements(List<int> list)
        {
            list = _list7;

            for(int i = 0; i < list.Count; i++)
            {
                int countElements = 0;
                for(int l = 0; l < list.Count; l++)
                {
                    if(list[i] == list[l])
                    {
                        countElements++;
                    }
                }
                string List = ("Ёлемент " + _list7[i] + " встречаетс€ " + countElements + " раз в листе T");
                Debug.Log(List);
            }
        }
    }
}