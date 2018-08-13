using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_If_statement
{
    class TimeClock
    {
        public class TimeLog
        {
            public DateTime EntryDateTime;
            public EntryTypes EntryType;
        }

        public enum EntryTypes
        {
            In,
            Out
        }

        public enum BlockTypes
        {
            Working,
            Break
        }

        public class TimeBlock
        {
            public BlockTypes BlockType;
            public TimeLog In;
            public TimeLog Out;

            public TimeSpan Duration
            {
                get
                {
                    // TODO: Need error checking
                    return Out.EntryDateTime.Subtract(In.EntryDateTime);
                }
            }

            public override string ToString()
            {
                return $"In: {In.EntryDateTime:HH:mm} - Out: {Out.EntryDateTime:HH:mm}";
            }

        }
    }
}
