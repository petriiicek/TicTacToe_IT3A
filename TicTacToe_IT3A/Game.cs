using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe_IT3A
{
    public class Game
    {
        private List<int[]> winCombinations;
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Player PlayerOnMove { get; set; }
        public Field[] Fields { get; set; }

        public Action OnChange;
        public Action<Field.State> OnWin;

        public Game()
        {
            winCombinations = new List<int[]>();
            winCombinations.Add(new int[] { 0, 1, 2 });
            winCombinations.Add(new int[] { 3, 4, 5 });
            winCombinations.Add(new int[] { 6, 7, 8 });
            winCombinations.Add(new int[] { 0, 3, 6 });
            winCombinations.Add(new int[] { 1, 4, 7 });
            winCombinations.Add(new int[] { 2, 5, 8 });
            winCombinations.Add(new int[] { 0, 4, 8 });
            winCombinations.Add(new int[] { 2, 4, 6 });
            Player1 = new Player(Field.State.Circle);
            Player2 = new Player(Field.State.Cross);
            var random = new Random();
            if (random.NextDouble() > 0.5)
            {
                PlayerOnMove = Player1;
            }
            else
            {
                PlayerOnMove = Player2;
            }
            Fields = new Field[9];
            for (int i = 0; i < Fields.Length; i++)
            {
                Fields[i] = new Field();
            }
        }

        public void Move(int fieldIndex)
        {
            if (Fields[fieldIndex].Value == Field.State.Empty)
            {
                Fields[fieldIndex].Value = PlayerOnMove.Value;
                if (PlayerOnMove == Player1)
                {
                    PlayerOnMove = Player2;
                }
                else
                {
                    PlayerOnMove = Player1;
                }
                var winner = IsWinner();
                if (winner != Field.State.Empty)
                {
                    OnWin?.Invoke(winner);
                }
                OnChange?.Invoke();
            }
        }

        private Field.State IsWinner()
        {
            Field.State winner = Field.State.Empty;
            foreach(var combination in winCombinations)
            {
                winner = Fields[combination[0]].Value;
                if (Fields[combination[1]].Value != winner)
                {
                    winner = Field.State.Empty;                    
                }
                if (Fields[combination[2]].Value != winner)
                {
                    winner = Field.State.Empty;                    
                }
                if(!(winner == Field.State.Empty))
                {
                    return winner;
                }
            }
            return winner;
        }
    }
}
