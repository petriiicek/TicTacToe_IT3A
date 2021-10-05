using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe_IT3A
{
    public class Field
    {
        public State Value { get; set; }

        public override string ToString()
        {
            switch (Value)
            {
                case State.Empty:
                    return "";
                case State.Circle:
                    return "O";
                default:
                    return "X";
            }
        }

        public enum State
        {
            Empty,
            Circle,
            Cross
        }
    }
}
