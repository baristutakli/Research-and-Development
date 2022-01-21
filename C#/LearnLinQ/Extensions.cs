using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLinQ
{
    public static class Extensions
    {
        public delegate bool FindMessage(string message);
        public static List<string> Find(this IEnumerable<Message> source, FindMessage del)
        {
            List<string> newList = new List<string>();
            foreach (var item in source)
            {
                if (del(item.MessageDetail))
                {
                    newList.Add(item.MessageDetail);
                }
            }
           return newList;
        }


        // Func<Tinput,Toutput> => TInput: typeof input. TOutput: typeof output 

        public static IEnumerable<T> CustomExtension<T>(this IEnumerable<T> data, Func<T, bool> predicate)
        {
            //List<string> newList = new List<string>();
            foreach (T value in data)
            {
                if (predicate(value)) yield return value;
            }
        }

    }}
