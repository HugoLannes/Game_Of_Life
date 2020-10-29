using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife
{
    public class Cell
    {
        public bool _isAlive;
        public bool _nextState;


        public Cell(bool isAlive)
        {
            this._isAlive = isAlive;
        }

        public void ComeAlive() //Méthode qui modifie à true l’attribut _nextState si VIE
        {
            _nextState = true;
        }

        public void PassAway() // Méthode qui modifie à false l’attribut _nextState si MORT
        {
            _nextState = false;
        }

        public void Update() // Méthode qui met à jour l’attribut _isAlive
        {
            _isAlive = _nextState;
        }
    }
}
