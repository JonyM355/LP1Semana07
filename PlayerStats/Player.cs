using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    public class Player
    {
        //support
        private float highscore;

        private int playedGames;
        private int wonGames;

        public string Name { get; }
        public float HighScore
        {
            get => highscore;

            set
            {
                if (value > highscore)
                {
                    highscore = value;
                }
            }
        }
        public float WinRate
        {
            get
            {
                if (playedGames == 0)
                {
                    return 0;
                }
                return (float)wonGames / playedGames;
            }
        }

        public void PlayGame(bool win)
        {
            playedGames++;

            if (win == true)
            {
                wonGames++;
            }
        }

        public Player(string name)
        {
            Name = name;
            HighScore = 0;
            playedGames = 0;
            wonGames = 0;
        }
    }

}