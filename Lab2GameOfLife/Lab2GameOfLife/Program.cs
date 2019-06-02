using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab2GameOfLife
{
    class StillLifeGame:Game
    {
        public enum GameType
        {
            Block,
            Beehive,
            Loaf,
            Boat
        }

        public GameType Type { get; set; }

        public StillLifeGame(GameType gameType, int maxGenerations) : base(maxGenerations)
        {
            Type = gameType;
            if (Type == GameType.Block)
            {
                grid = new Grid(4, 4);
                grid.ToggleCell(1, 1, true);
                grid.ToggleCell(1, 2, true);
                grid.ToggleCell(2, 1, true);
                grid.ToggleCell(2, 2, true);
            }

            if (Type == GameType.Beehive)
            {
                grid = new Grid(5, 6);
                grid.ToggleCell(1, 2, true);
                grid.ToggleCell(1, 3, true);
                grid.ToggleCell(2, 1, true);
                grid.ToggleCell(2, 4, true);
                grid.ToggleCell(3, 2, true);
                grid.ToggleCell(3, 3, true);
            }
        }

        override public void Show()
        {
            Console.Title = String.Format("Still Game of Life: {0}", Type);
            base.Show();
        }
    }
    class OscilatorGame:Game
    {
        public enum GameType
        {
            Blinker,
            Toad,
            Beacon,
            Pulsar
        }

        public GameType Type { get; set; }

        public OscilatorGame(GameType gameType, int maxGenerations) : base(maxGenerations)
        {
            Type = gameType;
            if (gameType == GameType.Blinker)
            {
                grid = new Grid(5, 5);
                grid.ToggleCell(2, 1, true);
                grid.ToggleCell(2, 2, true);
                grid.ToggleCell(2, 3, true);
            }

            if (gameType == GameType.Toad)
            {
                grid = new Grid(6, 6);
                grid.ToggleCell(2, 1, true);
                grid.ToggleCell(3, 1, true);
                grid.ToggleCell(4, 2, true);
                grid.ToggleCell(1, 3, true);
                grid.ToggleCell(2, 4, true);
                grid.ToggleCell(3, 4, true);
            }
            if (gameType == GameType.Beacon)
            {
                grid = new Grid(6, 6);
                grid.ToggleCell(1, 1, true);
                grid.ToggleCell(1, 2, true);
                grid.ToggleCell(2, 1, true);
                grid.ToggleCell(2, 2, true);
                grid.ToggleCell(3, 3, true);
                grid.ToggleCell(3, 4, true);
                grid.ToggleCell(4, 3, true);
                grid.ToggleCell(4, 4, true);
            }
            if (gameType == GameType.Pulsar)
            {
                grid = new Grid(17, 17);
                for (int i = 0; i < 17; i++)
                {
                    for (int j = 0; j < 17; j++)
                    {
                        if (i == 2 || i == 7 || i == 9 || i == 14)
                        {
                            if (j == 4 || j == 5 || j == 6 || j == 10 || j == 11 || j == 12)
                            {
                                grid.ToggleCell(i, j, true);
                            }
                        }
                        if ((i >= 4 && i <= 6) || (i >= 10 && i <= 12))
                        {
                            if (j == 2 || j == 7 || j == 9 || j == 14)
                            {
                                grid.ToggleCell(i, j, true);
                            }

                        }
                    }
                }
            }
        }

        override public void Show()
        {
            Console.Title = String.Format("Oscilator Game of Life: {0}", Type);
            base.Show();
        }
    }
    abstract class Game
    {
        protected Grid grid;
        public int CurrentGeneration { get; set; }
        public int MaxGenerations { get; set; }

        public Game(int maxGenerations)
        {
            MaxGenerations = maxGenerations;
            CurrentGeneration = 0;
        }

        public void Evolve()
        {
            grid.Evolve();
            CurrentGeneration++;
        }

        virtual public void Show()
        {
            Console.Clear();
            Console.WriteLine(grid);
        }


    }
    class Grid
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public Cell[][] cells { get; set; }

        public Grid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            cells = new Cell[rows][];

            for (int i = 0; i < rows; i++)
            {
                cells[i] = new Cell[columns];
                for(int j = 0; j < columns; j++)
                {
                    cells[i][j] = new Cell();
                }
            }
        }

        public void ToggleCell(int x,int y,bool isAlive)
        {
            cells[x][y].IsAlive = isAlive;
        }

        public void Evolve()
        {
            for(int i = 0; i < Rows; i++)
            {
                int counter = 0;
                for(int j=0;j<Columns;j++)
                {
                    //COUNTING
                    if(i-1>=0)
                    {
                        if (cells[i - 1][j].IsAlive)
                            counter++;
                        if (j + 1 <= Columns - 1 && cells[i - 1][j + 1].IsAlive)
                            counter++;
                        if (j - 1 >= 0 && cells[i - 1][j - 1].IsAlive)
                            counter++;
                    }
                    if(i+1<=Rows-1)
                    {
                        if (cells[i + 1][j].IsAlive)
                            counter++;
                        if (j + 1 <= Columns - 1 && cells[i + 1][j + 1].IsAlive)
                            counter++;
                        if (j - 1 >= 0 && cells[i + 1][j - 1].IsAlive)
                            counter++;
                    }
                    if (j - 1 >= 0 && cells[i][j - 1].IsAlive)
                        counter++;
                    if (j + 1 <= Columns - 1 && cells[i][j + 1].IsAlive)
                        counter++;

                    if (cells[i][j].IsAlive && (counter < 2||counter>3))
                        cells[i][j].ShouldLive = false;
                    if (cells[i][j].IsAlive && (counter == 2 || counter == 3))
                        cells[i][j].ShouldLive = false;
                    if (!cells[i][j].IsAlive && counter == 3)
                        cells[i][j].ShouldLive = true;
                }

            }

            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                    ToggleCell(i, j, cells[i][j].ShouldLive);

        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            for(int i=0;i<Rows;i++)
            { 
                for (int j = 0; j < Columns; j++)
                {
                    stringBuilder.Append(cells[i][j]);
                }
                stringBuilder.Append("\n");
            }

            return stringBuilder.ToString();
                
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    class Cell
    {
        public bool IsAlive { get; set; }
        public bool ShouldLive { get; set; }

        public Cell()
        {
            IsAlive = false;
            ShouldLive = false;
        }

        public override string ToString()
        {
            if (IsAlive)
                return " X ";
            return " _ ";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    class Program
    {
        static readonly int MAX_GENERATIONS = 50;

        static void Main(string[] args)
        {
            // Instanciranje na objekt od igrata
            Game game = new OscilatorGame(OscilatorGame.GameType.Pulsar, MAX_GENERATIONS);
            
            while (game.CurrentGeneration <= game.MaxGenerations)
            {
                game.Show();
                game.Evolve();
                Thread.Sleep(100);

            }

           /* Game game2 = new StillLifeGame(StillLifeGame.GameType.Beehive, MAX_GENERATIONS);
            while (game2.CurrentGeneration <= game2.MaxGenerations)
            {
                game2.Show();
                game2.Evolve();
                Thread.Sleep(500);

            }*/
            
            Console.WriteLine("Evaluation ended!\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
