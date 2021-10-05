using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe_IT3A
{
    public class Player
    {
        public Field.State Value { get; }

        public Player(Field.State value)
        {
            Value = value;
        }

        public override string ToString()
        {
            switch (Value)
            {
                case Field.State.Empty:
                    return "";
                case Field.State.Circle:
                    return "O";
                default:
                    return "X";
            }
        }
    }
}
