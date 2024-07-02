using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz2024
{
    internal class Player
    {
        //Atributos
        private string _name;
        private int _score;
        private TimeSpan _gameTime;
        private int _movimentos;
        private Stopwatch _tempoJogo;

        public Player(string name) {
            Name = name;
            Score = 0;
            gameTime = TimeSpan.FromSeconds(0);
            _movimentos = 0;
            _tempoJogo = new Stopwatch();
        }

        public string Name
        {
            get { return _name; }
            set {
                if (!string.IsNullOrEmpty(value))
                    _name = value;
            }
        }

        public int Score
        {
            get { return _score; }
            set
            {
                if (value >= 0)
                    _score += value;
            }
        }

        public TimeSpan gameTime
        {
            get { return _gameTime; }
            set
            {
                _gameTime += value;
            }
        }

        public int movimentos
        {
            get { return _movimentos; }
            private set { _movimentos = value; }
        }

        public void IniJogo()
        { 
            _tempoJogo.Start();
        }

        public void TermJogo()
        {
        _tempoJogo.Stop();
            _gameTime = _tempoJogo.Elapsed;
        }

        public override string ToString()
        {
            return "Nome: " + Name +
            "\nPontuação: " + Score +
            $"\nTempo de Partida: {gameTime:hh\\:mm\\:ss}" +
            "\nJogadas" + movimentos;
        }
    }
}
